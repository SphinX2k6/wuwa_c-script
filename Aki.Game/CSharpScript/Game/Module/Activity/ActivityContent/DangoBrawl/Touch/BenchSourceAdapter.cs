using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A2 RID: 22434
	[NullableContext(1)]
	[Nullable(0)]
	public class BenchSourceAdapter : IDragSourceAdapter
	{
		// Token: 0x17006AA3 RID: 27299
		// (get) Token: 0x06037623 RID: 226851 RVA: 0x00F79470 File Offset: 0x00F77670
		public EDragSourceKind Kind
		{
			get
			{
				return EDragSourceKind.Bench;
			}
		}

		// Token: 0x17006AA4 RID: 27300
		// (get) Token: 0x06037624 RID: 226852 RVA: 0x00F79473 File Offset: 0x00F77673
		private static DangoBrawlRollbackController RollbackCtrl
		{
			get
			{
				return DangoBrawlModel.Instance.GetRollbackController();
			}
		}

		// Token: 0x17006AA5 RID: 27301
		// (get) Token: 0x06037625 RID: 226853 RVA: 0x00F7947F File Offset: 0x00F7767F
		[Nullable(2)]
		private static DangoBrawlItemViewRegistry Registry
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06037626 RID: 226854 RVA: 0x00F7948B File Offset: 0x00F7768B
		public BenchSourceAdapter(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			this.Data = data;
			this.Context = context;
			this.PlatformState = platformState;
		}

		// Token: 0x06037627 RID: 226855 RVA: 0x00F794A8 File Offset: 0x00F776A8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<BuildResult> Build(IDangoBrawlDraggableView sourceView)
		{
			int myUid = sourceView.MyUid;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(myUid) : null;
			if (dangoBrawlBenchItemData == null)
			{
				return UniTask.FromResult<BuildResult>(null);
			}
			DangoBrawlItemViewRegistry registry = BenchSourceAdapter.Registry;
			IDangoBrawlDraggableView dangoBrawlDraggableView = (registry != null) ? registry.GetView(myUid) : null;
			if (dangoBrawlDraggableView == null)
			{
				return UniTask.FromResult<BuildResult>(null);
			}
			UUIItem dragLayer = this.Context.DragLayer;
			UUIItem draggableRootItem = dangoBrawlDraggableView.GetDraggableRootItem();
			if (dragLayer == null || !dragLayer.IsValid() || !draggableRootItem.IsValid())
			{
				return UniTask.FromResult<BuildResult>(null);
			}
			DangoBrawlUtil.ReparentMoveKeepWorld(draggableRootItem, dragLayer);
			return UniTask.FromResult<BuildResult>(new BuildResult(new RealVisual(EDragSourceKind.Bench, myUid, dangoBrawlBenchItemData.MyConfigId, dangoBrawlBenchItemData.MyTemplateType, dangoBrawlBenchItemData.MyRotation, dangoBrawlDraggableView, Array.Empty<DragPayloadFollower>())
			{
				DragAnchorOffset = this.PlatformState.DragAnchorOffset(dangoBrawlBenchItemData.MyTemplateType)
			}, null));
		}

		// Token: 0x06037628 RID: 226856 RVA: 0x00F79580 File Offset: 0x00F77780
		public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
		{
			visual.DraggableItem.SetDraggableActive(true);
			if (anchor == null || anchor.SourceKind != EDragSourceKind.Bench)
			{
				EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BenchToBench, visual.SourceUid);
				return;
			}
			DangoBrawlBenchData benchData = this.Data.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(visual.SourceUid) : null;
			if (dangoBrawlBenchItemData != null && anchor.BenchPos != null)
			{
				FVector2D value = anchor.BenchPos.Value;
				dangoBrawlBenchItemData.MyDropLguiPos = new FVector2D?(new FVector2D(value.X, value.Y));
			}
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BenchToBench, visual.SourceUid);
		}

		// Token: 0x06037629 RID: 226857 RVA: 0x00F7962C File Offset: 0x00F7782C
		[return: Nullable(0)]
		public UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			BenchSourceAdapter.<Commit>d__12 <Commit>d__;
			<Commit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Commit>d__.<>4__this = this;
			<Commit>d__.visual = visual;
			<Commit>d__.target = target;
			<Commit>d__.extraOps = extraOps;
			<Commit>d__.<>1__state = -1;
			<Commit>d__.<>t__builder.Start<BenchSourceAdapter.<Commit>d__12>(ref <Commit>d__);
			return <Commit>d__.<>t__builder.Task;
		}

		// Token: 0x0603762A RID: 226858 RVA: 0x00F79688 File Offset: 0x00F77888
		private bool CommitBenchToBench(IDragVisual visual, DragTarget target)
		{
			if (target.Bench == null)
			{
				return false;
			}
			this.Data.BenchData.MoveItem(visual.SourceUid, target.Bench.Value.LguiPos, new EDangoBrawlRotate?(target.Bench.Value.Rotate), true);
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BenchToBench, visual.SourceUid);
			return true;
		}

		// Token: 0x0603762B RID: 226859 RVA: 0x00F796FC File Offset: 0x00F778FC
		[return: Nullable(0)]
		private UniTask<bool> CommitBenchToBag(ActivityDangoBrawlController controller, IDragVisual visual, DragTarget target, DangoBrawlBenchItemData benchItem, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps)
		{
			BenchSourceAdapter.<CommitBenchToBag>d__14 <CommitBenchToBag>d__;
			<CommitBenchToBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CommitBenchToBag>d__.<>4__this = this;
			<CommitBenchToBag>d__.controller = controller;
			<CommitBenchToBag>d__.visual = visual;
			<CommitBenchToBag>d__.target = target;
			<CommitBenchToBag>d__.benchItem = benchItem;
			<CommitBenchToBag>d__.extraOps = extraOps;
			<CommitBenchToBag>d__.<>1__state = -1;
			<CommitBenchToBag>d__.<>t__builder.Start<BenchSourceAdapter.<CommitBenchToBag>d__14>(ref <CommitBenchToBag>d__);
			return <CommitBenchToBag>d__.<>t__builder.Task;
		}

		// Token: 0x0603762C RID: 226860 RVA: 0x00F7976C File Offset: 0x00F7796C
		[return: Nullable(0)]
		private static UniTask<bool> CommitBenchToShop(ActivityDangoBrawlController controller, IDragVisual visual)
		{
			BenchSourceAdapter.<CommitBenchToShop>d__15 <CommitBenchToShop>d__;
			<CommitBenchToShop>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CommitBenchToShop>d__.controller = controller;
			<CommitBenchToShop>d__.visual = visual;
			<CommitBenchToShop>d__.<>1__state = -1;
			<CommitBenchToShop>d__.<>t__builder.Start<BenchSourceAdapter.<CommitBenchToShop>d__15>(ref <CommitBenchToShop>d__);
			return <CommitBenchToShop>d__.<>t__builder.Task;
		}

		// Token: 0x0603762D RID: 226861 RVA: 0x00F797B8 File Offset: 0x00F779B8
		[return: Nullable(2)]
		public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			bool bagpackData = this.Data.BagpackData != null;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (!bagpackData || benchData == null)
			{
				return null;
			}
			DangoBrawlBenchItemData item = benchData.GetItem(visual.SourceUid);
			if (item == null)
			{
				return null;
			}
			EDragTargetKind kind = target.Kind;
			if (kind == EDragTargetKind.Bag)
			{
				return this.ApplyLocalBenchToBag(visual, target, item);
			}
			if (kind == EDragTargetKind.Bench)
			{
				return this.ApplyLocalBenchToBench(visual, target);
			}
			return null;
		}

		// Token: 0x0603762E RID: 226862 RVA: 0x00F79818 File Offset: 0x00F77A18
		public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
		{
			if (target.Kind != EDragTargetKind.Bag || target.Bag == null)
			{
				return Array.Empty<DangoBrawlBagOpInfo>();
			}
			DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
			dangoBrawlBagOpInfo.FromUid = visual.SourceUid;
			DangoBrawlBagSlotInfo dangoBrawlBagSlotInfo = DangoBrawlBagSlotInfo.Create();
			dangoBrawlBagSlotInfo.X = target.Bag.Value.LeftTopPos.ColIndex;
			dangoBrawlBagSlotInfo.Y = target.Bag.Value.LeftTopPos.RowIndex;
			dangoBrawlBagSlotInfo.Rotation = (int)target.Bag.Value.Rotate;
			dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.BenchToNormal;
			dangoBrawlBagOpInfo.Slot = dangoBrawlBagSlotInfo;
			return new DangoBrawlBagOpInfo[]
			{
				dangoBrawlBagOpInfo
			};
		}

		// Token: 0x0603762F RID: 226863 RVA: 0x00F798C0 File Offset: 0x00F77AC0
		[return: Nullable(2)]
		private OpSnapshot ApplyLocalBenchToBench(IDragVisual visual, DragTarget target)
		{
			if (target.Bench == null)
			{
				return null;
			}
			this.Data.BenchData.MoveItem(visual.SourceUid, target.Bench.Value.LguiPos, new EDangoBrawlRotate?(target.Bench.Value.Rotate), true);
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BenchToBench, visual.SourceUid);
			return BenchSourceAdapter.RollbackCtrl.TakeSnapshot(Array.Empty<OpSnapshotItem>());
		}

		// Token: 0x06037630 RID: 226864 RVA: 0x00F79940 File Offset: 0x00F77B40
		[return: Nullable(2)]
		private OpSnapshot ApplyLocalBenchToBag(IDragVisual visual, DragTarget target, DangoBrawlBenchItemData benchItem)
		{
			if (target.Bag == null)
			{
				return null;
			}
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			FVector2D? myDropLguiPos = benchItem.MyDropLguiPos;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = new DangoBrawlBackpackItemData(DangoBrawlBackPackItemServerData.MakeData(benchItem.MyUid, benchItem.MyConfigId, target.Bag.Value.LeftTopPos, target.Bag.Value.Rotate));
			benchData.DelItemDataFromMap(visual.SourceUid, true);
			if (!bagpackData.AddItemData(dangoBrawlBackpackItemData, true))
			{
				benchData.AddItemDataToMap(benchItem.MyServerData, myDropLguiPos, EDangoBrawlRotate.Direction0, true);
				return null;
			}
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BenchToBag, visual.SourceUid);
			return BenchSourceAdapter.RollbackCtrl.TakeSnapshot(new OpSnapshotItem[]
			{
				new OpSnapshotItem
				{
					Item = dangoBrawlBackpackItemData,
					RestoreTo = ERestoreZone.Bench,
					BenchDropPos = myDropLguiPos
				}
			});
		}

		// Token: 0x0401D3D0 RID: 119760
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D3D1 RID: 119761
		private readonly DragContext Context;

		// Token: 0x0401D3D2 RID: 119762
		private readonly DangoBrawlPlatformState PlatformState;
	}
}

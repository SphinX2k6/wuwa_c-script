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
	// Token: 0x02006852 RID: 26706
	[NullableContext(1)]
	[Nullable(0)]
	public class BenchSourceAdapter : IDragSourceAdapter
	{
		// Token: 0x17009762 RID: 38754
		// (get) Token: 0x06042ACE RID: 273102 RVA: 0x01037F24 File Offset: 0x01036124
		public EDragSourceKind Kind
		{
			get
			{
				return EDragSourceKind.Bench;
			}
		}

		// Token: 0x17009763 RID: 38755
		// (get) Token: 0x06042ACF RID: 273103 RVA: 0x01037F27 File Offset: 0x01036127
		private static DangoBrawlRollbackController RollbackCtrl
		{
			get
			{
				return DangoBrawlModel.Instance.GetRollbackController();
			}
		}

		// Token: 0x17009764 RID: 38756
		// (get) Token: 0x06042AD0 RID: 273104 RVA: 0x01037F33 File Offset: 0x01036133
		[Nullable(2)]
		private static DangoBrawlItemViewRegistry Registry
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06042AD1 RID: 273105 RVA: 0x01037F3F File Offset: 0x0103613F
		public BenchSourceAdapter(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			this.Data = data;
			this.Context = context;
			this.PlatformState = platformState;
		}

		// Token: 0x06042AD2 RID: 273106 RVA: 0x01037F5C File Offset: 0x0103615C
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

		// Token: 0x06042AD3 RID: 273107 RVA: 0x01038034 File Offset: 0x01036234
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

		// Token: 0x06042AD4 RID: 273108 RVA: 0x010380E0 File Offset: 0x010362E0
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

		// Token: 0x06042AD5 RID: 273109 RVA: 0x0103813C File Offset: 0x0103633C
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

		// Token: 0x06042AD6 RID: 273110 RVA: 0x010381B0 File Offset: 0x010363B0
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

		// Token: 0x06042AD7 RID: 273111 RVA: 0x01038220 File Offset: 0x01036420
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

		// Token: 0x06042AD8 RID: 273112 RVA: 0x0103826C File Offset: 0x0103646C
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

		// Token: 0x06042AD9 RID: 273113 RVA: 0x010382CC File Offset: 0x010364CC
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

		// Token: 0x06042ADA RID: 273114 RVA: 0x01038374 File Offset: 0x01036574
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

		// Token: 0x06042ADB RID: 273115 RVA: 0x010383F4 File Offset: 0x010365F4
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

		// Token: 0x04022B73 RID: 142195
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022B74 RID: 142196
		private readonly DragContext Context;

		// Token: 0x04022B75 RID: 142197
		private readonly DangoBrawlPlatformState PlatformState;
	}
}

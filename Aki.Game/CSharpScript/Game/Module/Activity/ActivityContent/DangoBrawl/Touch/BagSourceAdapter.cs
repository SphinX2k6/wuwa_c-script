using System;
using System.Collections.Generic;
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
	// Token: 0x02006851 RID: 26705
	[NullableContext(1)]
	[Nullable(0)]
	public class BagSourceAdapter : IDragSourceAdapter
	{
		// Token: 0x1700975F RID: 38751
		// (get) Token: 0x06042AB1 RID: 273073 RVA: 0x01036CF7 File Offset: 0x01034EF7
		public EDragSourceKind Kind
		{
			get
			{
				return EDragSourceKind.Bag;
			}
		}

		// Token: 0x17009760 RID: 38752
		// (get) Token: 0x06042AB2 RID: 273074 RVA: 0x01036CFA File Offset: 0x01034EFA
		private static DangoBrawlRollbackController RollbackCtrl
		{
			get
			{
				return DangoBrawlModel.Instance.GetRollbackController();
			}
		}

		// Token: 0x17009761 RID: 38753
		// (get) Token: 0x06042AB3 RID: 273075 RVA: 0x01036D06 File Offset: 0x01034F06
		[Nullable(2)]
		private static DangoBrawlItemViewRegistry Registry
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06042AB4 RID: 273076 RVA: 0x01036D12 File Offset: 0x01034F12
		public BagSourceAdapter(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			this.Data = data;
			this.Context = context;
			this.PlatformState = platformState;
		}

		// Token: 0x06042AB5 RID: 273077 RVA: 0x01036D30 File Offset: 0x01034F30
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<BuildResult> Build(IDangoBrawlDraggableView sourceView)
		{
			int myUid = sourceView.MyUid;
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(myUid) : null;
			if (dangoBrawlBackpackItemData == null)
			{
				return UniTask.FromResult<BuildResult>(null);
			}
			DangoBrawlItemViewRegistry registry = BagSourceAdapter.Registry;
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
			List<DragPayloadFollower> list = new List<DragPayloadFollower>();
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			bool? flag;
			if (instance == null)
			{
				flag = null;
			}
			else
			{
				DangoBrawlDataController dataController = instance.GetDataController();
				flag = ((dataController != null) ? new bool?(dataController.GetViewLayerMode()) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			if (dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Bag && !valueOrDefault)
			{
				this.CollectBagFollowers(dangoBrawlBackpackItemData, dangoBrawlDraggableView, list);
			}
			DragPayloadFollower[] array = list.ToArray();
			FVector lguispaceAbsolutePosition = draggableRootItem.GetLGUISpaceAbsolutePosition();
			FVector2D value = new FVector2D(lguispaceAbsolutePosition.X, lguispaceAbsolutePosition.Y);
			DangoBrawlUtil.ReparentMoveKeepWorld(draggableRootItem, dragLayer);
			DragPayloadFollower[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				DangoBrawlUtil.ReparentMoveKeepWorld(array2[i].View.GetDraggableRootItem(), dragLayer);
			}
			return UniTask.FromResult<BuildResult>(new BuildResult(new RealVisual(EDragSourceKind.Bag, myUid, dangoBrawlBackpackItemData.MyConfigId, dangoBrawlBackpackItemData.MyTemplateType, dangoBrawlBackpackItemData.MyRotation, dangoBrawlDraggableView, array)
			{
				DragAnchorOffset = this.PlatformState.DragAnchorOffset(dangoBrawlBackpackItemData.MyTemplateType)
			}, new FVector2D?(value)));
		}

		// Token: 0x06042AB6 RID: 273078 RVA: 0x01036EAE File Offset: 0x010350AE
		public void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor)
		{
			this.EmitBagToBagForVisual(visual);
		}

		// Token: 0x06042AB7 RID: 273079 RVA: 0x01036EB8 File Offset: 0x010350B8
		[return: Nullable(0)]
		public UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			BagSourceAdapter.<Commit>d__12 <Commit>d__;
			<Commit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Commit>d__.<>4__this = this;
			<Commit>d__.visual = visual;
			<Commit>d__.target = target;
			<Commit>d__.extraOps = extraOps;
			<Commit>d__.<>1__state = -1;
			<Commit>d__.<>t__builder.Start<BagSourceAdapter.<Commit>d__12>(ref <Commit>d__);
			return <Commit>d__.<>t__builder.Task;
		}

		// Token: 0x06042AB8 RID: 273080 RVA: 0x01036F14 File Offset: 0x01035114
		[return: Nullable(2)]
		public OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (bagpackData == null || benchData == null)
			{
				return null;
			}
			DangoBrawlBackpackItemData item = bagpackData.GetItem(visual.SourceUid);
			if (item == null)
			{
				return null;
			}
			EDragTargetKind kind = target.Kind;
			if (kind == EDragTargetKind.Bag)
			{
				return this.ApplyLocalBagToBag(visual, target, item);
			}
			if (kind != EDragTargetKind.Bench)
			{
				return null;
			}
			return this.ApplyLocalBagToBench(visual, target, item);
		}

		// Token: 0x06042AB9 RID: 273081 RVA: 0x01036F7C File Offset: 0x0103517C
		public DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target)
		{
			EDragTargetKind kind = target.Kind;
			if (kind != EDragTargetKind.Bag)
			{
				if (kind != EDragTargetKind.Bench)
				{
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				List<DangoBrawlBagOpInfo> list = new List<DangoBrawlBagOpInfo>();
				list.Add(BagSourceAdapter.MakeToBenchOp(visual.SourceUid));
				DragPayloadFollower[] followers = visual.Followers;
				for (int i = 0; i < followers.Length; i++)
				{
					DangoBrawlItemBase myItemData = followers[i].View.MyItemData;
					int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
					if (num != null && num.Value > 0)
					{
						list.Add(BagSourceAdapter.MakeToBenchOp(num.Value));
					}
				}
				return list.ToArray();
			}
			else
			{
				DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
				if (bagpackData == null)
				{
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				DangoBrawlBackpackItemData item = bagpackData.GetItem(visual.SourceUid);
				if (item == null)
				{
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				List<DangoBrawlBagOpInfo> list2 = new List<DangoBrawlBagOpInfo>();
				list2.Add(BagSourceAdapter.MakeBagSlotOp(visual.SourceUid, item.MyLeftTopPos, item.MyRotation));
				DragPayloadFollower[] followers = visual.Followers;
				for (int i = 0; i < followers.Length; i++)
				{
					DangoBrawlItemBase myItemData2 = followers[i].View.MyItemData;
					int? num2 = (myItemData2 != null) ? new int?(myItemData2.MyUid) : null;
					if (num2 != null && num2.Value > 0)
					{
						DangoBrawlBackpackItemData item2 = bagpackData.GetItem(num2.Value);
						if (item2 != null)
						{
							list2.Add(BagSourceAdapter.MakeBagSlotOp(num2.Value, item2.MyLeftTopPos, item2.MyRotation));
						}
					}
				}
				return list2.ToArray();
			}
		}

		// Token: 0x06042ABA RID: 273082 RVA: 0x01037114 File Offset: 0x01035314
		private static DangoBrawlBagOpInfo MakeBagSlotOp(int uid, PanelPos leftTop, EDangoBrawlRotate rotate)
		{
			DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
			dangoBrawlBagOpInfo.FromUid = uid;
			DangoBrawlBagSlotInfo dangoBrawlBagSlotInfo = DangoBrawlBagSlotInfo.Create();
			dangoBrawlBagSlotInfo.X = leftTop.ColIndex;
			dangoBrawlBagSlotInfo.Y = leftTop.RowIndex;
			dangoBrawlBagSlotInfo.Rotation = (int)rotate;
			dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.NormalChange;
			dangoBrawlBagOpInfo.Slot = dangoBrawlBagSlotInfo;
			return dangoBrawlBagOpInfo;
		}

		// Token: 0x06042ABB RID: 273083 RVA: 0x01037160 File Offset: 0x01035360
		private static DangoBrawlBagOpInfo MakeToBenchOp(int uid)
		{
			DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
			dangoBrawlBagOpInfo.FromUid = uid;
			dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.ToBench;
			return dangoBrawlBagOpInfo;
		}

		// Token: 0x06042ABC RID: 273084 RVA: 0x01037175 File Offset: 0x01035375
		[return: Nullable(0)]
		private UniTask<bool> CommitToBag(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item, ActivityDangoBrawlController controller, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps)
		{
			return this.CommitToBagCore(visual, target, item, controller, extraOps, false, null);
		}

		// Token: 0x06042ABD RID: 273085 RVA: 0x01037188 File Offset: 0x01035388
		[return: TupleElementNames(new string[]
		{
			"Ok",
			"BenchedFollowers"
		})]
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		public UniTask<ValueTuple<bool, List<DangoBrawlBackpackItemData>>> CommitToBagBestEffort(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			BagSourceAdapter.<CommitToBagBestEffort>d__18 <CommitToBagBestEffort>d__;
			<CommitToBagBestEffort>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<bool, List<DangoBrawlBackpackItemData>>>.Create();
			<CommitToBagBestEffort>d__.<>4__this = this;
			<CommitToBagBestEffort>d__.visual = visual;
			<CommitToBagBestEffort>d__.target = target;
			<CommitToBagBestEffort>d__.extraOps = extraOps;
			<CommitToBagBestEffort>d__.<>1__state = -1;
			<CommitToBagBestEffort>d__.<>t__builder.Start<BagSourceAdapter.<CommitToBagBestEffort>d__18>(ref <CommitToBagBestEffort>d__);
			return <CommitToBagBestEffort>d__.<>t__builder.Task;
		}

		// Token: 0x06042ABE RID: 273086 RVA: 0x010371E4 File Offset: 0x010353E4
		[return: Nullable(0)]
		private UniTask<bool> CommitToBagCore(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item, ActivityDangoBrawlController controller, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps, bool bestEffort, [Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> benchedOut = null)
		{
			BagSourceAdapter.<CommitToBagCore>d__19 <CommitToBagCore>d__;
			<CommitToBagCore>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CommitToBagCore>d__.<>4__this = this;
			<CommitToBagCore>d__.visual = visual;
			<CommitToBagCore>d__.target = target;
			<CommitToBagCore>d__.item = item;
			<CommitToBagCore>d__.controller = controller;
			<CommitToBagCore>d__.extraOps = extraOps;
			<CommitToBagCore>d__.bestEffort = bestEffort;
			<CommitToBagCore>d__.benchedOut = benchedOut;
			<CommitToBagCore>d__.<>1__state = -1;
			<CommitToBagCore>d__.<>t__builder.Start<BagSourceAdapter.<CommitToBagCore>d__19>(ref <CommitToBagCore>d__);
			return <CommitToBagCore>d__.<>t__builder.Task;
		}

		// Token: 0x06042ABF RID: 273087 RVA: 0x01037264 File Offset: 0x01035464
		[return: Nullable(0)]
		private UniTask<bool> CommitToBench(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item, ActivityDangoBrawlController controller)
		{
			BagSourceAdapter.<CommitToBench>d__20 <CommitToBench>d__;
			<CommitToBench>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CommitToBench>d__.<>4__this = this;
			<CommitToBench>d__.visual = visual;
			<CommitToBench>d__.target = target;
			<CommitToBench>d__.item = item;
			<CommitToBench>d__.controller = controller;
			<CommitToBench>d__.<>1__state = -1;
			<CommitToBench>d__.<>t__builder.Start<BagSourceAdapter.<CommitToBench>d__20>(ref <CommitToBench>d__);
			return <CommitToBench>d__.<>t__builder.Task;
		}

		// Token: 0x06042AC0 RID: 273088 RVA: 0x010372C8 File Offset: 0x010354C8
		[return: Nullable(0)]
		private UniTask<bool> CommitToShop(IDragVisual visual, ActivityDangoBrawlController controller)
		{
			BagSourceAdapter.<CommitToShop>d__21 <CommitToShop>d__;
			<CommitToShop>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CommitToShop>d__.<>4__this = this;
			<CommitToShop>d__.visual = visual;
			<CommitToShop>d__.controller = controller;
			<CommitToShop>d__.<>1__state = -1;
			<CommitToShop>d__.<>t__builder.Start<BagSourceAdapter.<CommitToShop>d__21>(ref <CommitToShop>d__);
			return <CommitToShop>d__.<>t__builder.Task;
		}

		// Token: 0x06042AC1 RID: 273089 RVA: 0x0103731C File Offset: 0x0103551C
		[return: Nullable(2)]
		private OpSnapshot ApplyLocalBagToBag(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item)
		{
			List<int> list;
			return this.ApplyLocalBagToBagCore(visual, target, item, false, out list);
		}

		// Token: 0x06042AC2 RID: 273090 RVA: 0x01037338 File Offset: 0x01035538
		[return: TupleElementNames(new string[]
		{
			"Snapshot",
			"BenchedFollowerUids"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<OpSnapshot, List<int>>? ApplyLocalBagToBagBestEffort(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(visual.SourceUid) : null;
			if (bagpackData == null || dangoBrawlBackpackItemData == null)
			{
				return null;
			}
			List<int> item;
			OpSnapshot opSnapshot = this.ApplyLocalBagToBagCore(visual, target, dangoBrawlBackpackItemData, true, out item);
			if (opSnapshot == null)
			{
				return null;
			}
			return new ValueTuple<OpSnapshot, List<int>>?(new ValueTuple<OpSnapshot, List<int>>(opSnapshot, item));
		}

		// Token: 0x06042AC3 RID: 273091 RVA: 0x0103739C File Offset: 0x0103559C
		[return: Nullable(2)]
		private OpSnapshot ApplyLocalBagToBagCore(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item, bool bestEffort, out List<int> benchedUids)
		{
			benchedUids = new List<int>();
			if (target.Bag == null)
			{
				return null;
			}
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (item.MyLeftTopPos.RowIndex == target.Bag.Value.LeftTopPos.RowIndex && item.MyLeftTopPos.ColIndex == target.Bag.Value.LeftTopPos.ColIndex && item.MyRotation == target.Bag.Value.Rotate)
			{
				this.EmitBagToBagForVisual(visual);
				return BagSourceAdapter.RollbackCtrl.TakeSnapshot(Array.Empty<OpSnapshotItem>());
			}
			PanelPos rotatedLeftTopPos = DangoBrawlUtil.GetRotatedLeftTopPos(item.MyLeftTopPos, item.MyRotation, target.Bag.Value.Rotate, item.MyConfigId);
			int deltaRow = target.Bag.Value.LeftTopPos.RowIndex - rotatedLeftTopPos.RowIndex;
			int deltaCol = target.Bag.Value.LeftTopPos.ColIndex - rotatedLeftTopPos.ColIndex;
			PanelPos myLeftTopPos = item.MyLeftTopPos;
			EDangoBrawlRotate myRotation = item.MyRotation;
			List<DangoBrawlBackpackItemData> followerItems = this.GetFollowerItems(visual);
			OpSnapshotItem[] array = new OpSnapshotItem[1 + followerItems.Count];
			array[0] = new OpSnapshotItem
			{
				Item = item,
				Pos = myLeftTopPos,
				Rot = myRotation
			};
			for (int i = 0; i < followerItems.Count; i++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = followerItems[i];
				array[i + 1] = new OpSnapshotItem
				{
					Item = dangoBrawlBackpackItemData,
					Pos = dangoBrawlBackpackItemData.MyLeftTopPos,
					Rot = dangoBrawlBackpackItemData.MyRotation
				};
			}
			OpSnapshot opSnapshot = BagSourceAdapter.RollbackCtrl.TakeSnapshot(array);
			bagpackData.RemoveItemData(visual.SourceUid, false);
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in followerItems)
			{
				bagpackData.RemoveItemData(dangoBrawlBackpackItemData2.MyUid, false);
			}
			item.MyLeftTopPos = target.Bag.Value.LeftTopPos;
			item.MyRotation = target.Bag.Value.Rotate;
			if (!bagpackData.AddItemData(item, false))
			{
				BagSourceAdapter.RollbackCtrl.RestoreSnapshot(opSnapshot);
				return null;
			}
			for (int j = 0; j < followerItems.Count; j++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData3 = followerItems[j];
				ValueTuple<PanelPos, EDangoBrawlRotate> valueTuple = DangoBrawlUtil.RotateFollower(dangoBrawlBackpackItemData3, myLeftTopPos, visual.ConfigId, myRotation, target.Bag.Value.Rotate, deltaRow, deltaCol);
				PanelPos item2 = valueTuple.Item1;
				EDangoBrawlRotate item3 = valueTuple.Item2;
				dangoBrawlBackpackItemData3.MyLeftTopPos = item2;
				dangoBrawlBackpackItemData3.MyRotation = item3;
				if (!bagpackData.AddItemData(dangoBrawlBackpackItemData3, false))
				{
					if (!bestEffort)
					{
						BagSourceAdapter.RollbackCtrl.RestoreSnapshot(opSnapshot);
						return null;
					}
					dangoBrawlBackpackItemData3.MyLeftTopPos = array[j + 1].Pos;
					dangoBrawlBackpackItemData3.MyRotation = array[j + 1].Rot;
					this.MoveToBenchDataAndEmit(dangoBrawlBackpackItemData3);
					benchedUids.Add(dangoBrawlBackpackItemData3.MyUid);
				}
			}
			this.EmitBagToBagForVisual(visual);
			return opSnapshot;
		}

		// Token: 0x06042AC4 RID: 273092 RVA: 0x010376BC File Offset: 0x010358BC
		[return: Nullable(2)]
		private OpSnapshot ApplyLocalBagToBench(IDragVisual visual, DragTarget target, DangoBrawlBackpackItemData item)
		{
			if (target.Bench == null)
			{
				return null;
			}
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			DangoBrawlBenchData benchData = this.Data.BenchData;
			List<DangoBrawlBackpackItemData> followerItems = this.GetFollowerItems(visual);
			OpSnapshotItem[] array = new OpSnapshotItem[1 + followerItems.Count];
			array[0] = new OpSnapshotItem
			{
				Item = item,
				Pos = item.MyLeftTopPos,
				Rot = item.MyRotation
			};
			for (int i = 0; i < followerItems.Count; i++)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = followerItems[i];
				array[i + 1] = new OpSnapshotItem
				{
					Item = dangoBrawlBackpackItemData,
					Pos = dangoBrawlBackpackItemData.MyLeftTopPos,
					Rot = dangoBrawlBackpackItemData.MyRotation
				};
			}
			OpSnapshot result = BagSourceAdapter.RollbackCtrl.TakeSnapshot(array);
			DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(item.MyUid, item.MyConfigId);
			bagpackData.RemoveItemData(visual.SourceUid, true);
			benchData.AddItemDataToMap(serverData, target.Bench.Value.LguiPos, item.MyRotation, true);
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBench, visual.SourceUid);
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in followerItems)
			{
				DangoBrawlBenchItemServerData serverData2 = DangoBrawlBenchServerData.MakeData(dangoBrawlBackpackItemData2.MyUid, dangoBrawlBackpackItemData2.MyConfigId);
				bagpackData.RemoveItemData(dangoBrawlBackpackItemData2.MyUid, true);
				benchData.AddItemDataToMap(serverData2, null, dangoBrawlBackpackItemData2.MyRotation, true);
				EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBench, dangoBrawlBackpackItemData2.MyUid);
			}
			return result;
		}

		// Token: 0x06042AC5 RID: 273093 RVA: 0x01037874 File Offset: 0x01035A74
		[NullableContext(0)]
		private static UniTask<bool> ShowSellFollowerConfirmAsync()
		{
			UniTaskCompletionSource<bool> tcs = new UniTaskCompletionSource<bool>();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlSellFollowerConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				tcs.TrySetResult(true);
			};
			confirmBoxDataNew.DestroyFunction = delegate()
			{
				tcs.TrySetResult(false);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return tcs.Task;
		}

		// Token: 0x06042AC6 RID: 273094 RVA: 0x010378E0 File Offset: 0x01035AE0
		private static List<int> CollectInvolvedUids(IDragVisual visual, List<DangoBrawlBackpackItemData> followerItems)
		{
			List<int> list = new List<int>(followerItems.Count + 1)
			{
				visual.SourceUid
			};
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in followerItems)
			{
				list.Add(dangoBrawlBackpackItemData.MyUid);
			}
			return list;
		}

		// Token: 0x06042AC7 RID: 273095 RVA: 0x01037950 File Offset: 0x01035B50
		private static string DescribeFollowerCells(DangoBrawlBackpackData bag, PanelPos leftTop, PanelPos[] panelPosList)
		{
			List<string> list = new List<string>(panelPosList.Length);
			foreach (PanelPos panelPos in panelPosList)
			{
				PanelPos panelPos2 = new PanelPos(leftTop.RowIndex + panelPos.RowIndex, leftTop.ColIndex + panelPos.ColIndex);
				int bagIdAt = bag.GetBagIdAt(panelPos2);
				int bagItemIdAt = bag.GetBagItemIdAt(panelPos2);
				string text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (bagIdAt == -1)
				{
					text = "B=无";
				}
				else
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("B=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(bagIdAt);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string value = text;
				string text2;
				if (bagItemIdAt == -1)
				{
					text2 = "I=空";
				}
				else
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("I=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(bagItemIdAt);
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string value2 = text2;
				List<string> list2 = list;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted<int>(panelPos2.RowIndex);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(panelPos2.ColIndex);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return string.Join(" ", list);
		}

		// Token: 0x06042AC8 RID: 273096 RVA: 0x01037AA0 File Offset: 0x01035CA0
		private void EmitBagToBagForVisual(IDragVisual visual)
		{
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBag, visual.SourceUid);
			DragPayloadFollower[] followers = visual.Followers;
			for (int i = 0; i < followers.Length; i++)
			{
				DangoBrawlItemBase myItemData = followers[i].View.MyItemData;
				int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
				if (num != null && num.Value > 0)
				{
					EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBag, num.Value);
				}
			}
		}

		// Token: 0x06042AC9 RID: 273097 RVA: 0x01037B2C File Offset: 0x01035D2C
		private void MoveToBenchDataAndEmit(DangoBrawlBackpackItemData fo)
		{
			DangoBrawlBenchData benchData = this.Data.BenchData;
			if (benchData == null)
			{
				return;
			}
			DangoBrawlBenchItemServerData serverData = DangoBrawlBenchServerData.MakeData(fo.MyUid, fo.MyConfigId);
			benchData.AddItemDataToMap(serverData, null, EDangoBrawlRotate.Direction0, true);
			EventSystem.Instance.Emit<EBagOpKind, int>(EEventName.OnDangoBrawlBagOperated, EBagOpKind.BagToBench, fo.MyUid);
		}

		// Token: 0x06042ACA RID: 273098 RVA: 0x01037B84 File Offset: 0x01035D84
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private static DangoBrawlBagOpInfo[] PrependOps(List<DangoBrawlBagOpInfo> prepend, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] existing)
		{
			if (prepend.Count == 0)
			{
				return existing;
			}
			int num = (existing != null) ? existing.Length : 0;
			DangoBrawlBagOpInfo[] array = new DangoBrawlBagOpInfo[prepend.Count + num];
			for (int i = 0; i < prepend.Count; i++)
			{
				array[i] = prepend[i];
			}
			if (existing != null)
			{
				existing.CopyTo(array, prepend.Count);
			}
			return array;
		}

		// Token: 0x06042ACB RID: 273099 RVA: 0x01037BE0 File Offset: 0x01035DE0
		[return: Nullable(0)]
		private UniTask<bool> DispatchBagOp(ActivityDangoBrawlController controller, int sourceUid, EBagOpKind kind, DragTarget target, DangoBrawlBagOpInfo[] followerOps, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			BagSourceAdapter.<DispatchBagOp>d__32 <DispatchBagOp>d__;
			<DispatchBagOp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DispatchBagOp>d__.controller = controller;
			<DispatchBagOp>d__.sourceUid = sourceUid;
			<DispatchBagOp>d__.kind = kind;
			<DispatchBagOp>d__.target = target;
			<DispatchBagOp>d__.followerOps = followerOps;
			<DispatchBagOp>d__.extraOps = extraOps;
			<DispatchBagOp>d__.<>1__state = -1;
			<DispatchBagOp>d__.<>t__builder.Start<BagSourceAdapter.<DispatchBagOp>d__32>(ref <DispatchBagOp>d__);
			return <DispatchBagOp>d__.<>t__builder.Task;
		}

		// Token: 0x06042ACC RID: 273100 RVA: 0x01037C50 File Offset: 0x01035E50
		private List<DangoBrawlBackpackItemData> GetFollowerItems(IDragVisual visual)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (bagpackData == null)
			{
				return new List<DangoBrawlBackpackItemData>();
			}
			List<DangoBrawlBackpackItemData> list = new List<DangoBrawlBackpackItemData>();
			foreach (DragPayloadFollower dragPayloadFollower in visual.Followers)
			{
				DangoBrawlItemBase myItemData = dragPayloadFollower.View.MyItemData;
				int? num = (myItemData != null) ? new int?(myItemData.MyUid) : null;
				if (num != null && num.Value > 0)
				{
					DangoBrawlBackpackItemData dangoBrawlBackpackItemData = bagpackData.GetItem(num.Value) ?? (dragPayloadFollower.View.MyItemData as DangoBrawlBackpackItemData);
					if (dangoBrawlBackpackItemData != null)
					{
						list.Add(dangoBrawlBackpackItemData);
					}
				}
			}
			return list;
		}

		// Token: 0x06042ACD RID: 273101 RVA: 0x01037D00 File Offset: 0x01035F00
		private void CollectBagFollowers(DangoBrawlBackpackItemData bag, IDangoBrawlDraggableView primaryView, List<DragPayloadFollower> out2)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (bagpackData == null || BagSourceAdapter.Registry == null)
			{
				return;
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (PanelPos panelPos in bag.MyPanelPosList)
			{
				HashSet<string> hashSet2 = hashSet;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(bag.MyLeftTopPos.RowIndex + panelPos.RowIndex);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(bag.MyLeftTopPos.ColIndex + panelPos.ColIndex);
				hashSet2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UUIItem draggableRootItem = primaryView.GetDraggableRootItem();
			if (!draggableRootItem.IsValid())
			{
				return;
			}
			FVector lguispaceAbsolutePosition = draggableRootItem.GetLGUISpaceAbsolutePosition();
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in bagpackData.GetItemList())
			{
				if (dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Item)
				{
					bool flag = false;
					foreach (PanelPos panelPos2 in dangoBrawlBackpackItemData.MyPanelPosList)
					{
						HashSet<string> hashSet3 = hashSet;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex + panelPos2.RowIndex);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						defaultInterpolatedStringHandler.AppendFormatted<int>(dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex + panelPos2.ColIndex);
						if (hashSet3.Contains(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						IDangoBrawlDraggableView view = BagSourceAdapter.Registry.GetView(dangoBrawlBackpackItemData.MyUid);
						UUIItem uuiitem = (view != null) ? view.GetDraggableRootItem() : null;
						if (view != null && uuiitem != null && uuiitem.IsValid())
						{
							FVector lguispaceAbsolutePosition2 = uuiitem.GetLGUISpaceAbsolutePosition();
							out2.Add(new DragPayloadFollower
							{
								View = view,
								OffsetToPrimary = new FVector2D(lguispaceAbsolutePosition2.X - lguispaceAbsolutePosition.X, lguispaceAbsolutePosition2.Y - lguispaceAbsolutePosition.Y)
							});
						}
					}
				}
			}
		}

		// Token: 0x04022B70 RID: 142192
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022B71 RID: 142193
		private readonly DragContext Context;

		// Token: 0x04022B72 RID: 142194
		private readonly DangoBrawlPlatformState PlatformState;
	}
}

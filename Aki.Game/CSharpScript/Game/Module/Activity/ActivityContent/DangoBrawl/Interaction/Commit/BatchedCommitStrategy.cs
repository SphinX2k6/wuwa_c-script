using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006882 RID: 26754
	[NullableContext(1)]
	[Nullable(0)]
	public class BatchedCommitStrategy : ICommitStrategy
	{
		// Token: 0x170097B6 RID: 38838
		// (get) Token: 0x06042CBA RID: 273594 RVA: 0x01041A7F File Offset: 0x0103FC7F
		[Nullable(2)]
		private static DangoBrawlRollbackController RollbackCtrl
		{
			[NullableContext(2)]
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetRollbackController();
			}
		}

		// Token: 0x06042CBB RID: 273595 RVA: 0x01041A91 File Offset: 0x0103FC91
		public BatchedCommitStrategy(ActivityDangoBrawlData data)
		{
			this.Data = data;
		}

		// Token: 0x06042CBC RID: 273596 RVA: 0x01041AAB File Offset: 0x0103FCAB
		public bool IsEmpty()
		{
			return this.Pending.Count == 0;
		}

		// Token: 0x06042CBD RID: 273597 RVA: 0x01041ABB File Offset: 0x0103FCBB
		public void Start()
		{
			this.Started = true;
			this.Pending.Clear();
		}

		// Token: 0x06042CBE RID: 273598 RVA: 0x01041ACF File Offset: 0x0103FCCF
		public void Stop()
		{
			if (!this.Started)
			{
				return;
			}
			this.RollbackInvolvedToAnchors(null);
			this.Started = false;
		}

		// Token: 0x06042CBF RID: 273599 RVA: 0x01041AE8 File Offset: 0x0103FCE8
		[return: Nullable(0)]
		public UniTask<EPlaceResult> Commit(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			if (target == null)
			{
				return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
			}
			EDragTargetKind kind = target.Kind;
			if (kind == EDragTargetKind.Bag)
			{
				return this.CommitToBag(adapter, visual, target, anchor);
			}
			if (kind == EDragTargetKind.Bench)
			{
				return this.CommitToBench(adapter, visual, target, anchor);
			}
			return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
		}

		// Token: 0x06042CC0 RID: 273600 RVA: 0x01041B2C File Offset: 0x0103FD2C
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToBench(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			BatchedCommitStrategy.<CommitToBench>d__10 <CommitToBench>d__;
			<CommitToBench>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPlaceResult>.Create();
			<CommitToBench>d__.<>4__this = this;
			<CommitToBench>d__.adapter = adapter;
			<CommitToBench>d__.visual = visual;
			<CommitToBench>d__.target = target;
			<CommitToBench>d__.anchor = anchor;
			<CommitToBench>d__.<>1__state = -1;
			<CommitToBench>d__.<>t__builder.Start<BatchedCommitStrategy.<CommitToBench>d__10>(ref <CommitToBench>d__);
			return <CommitToBench>d__.<>t__builder.Task;
		}

		// Token: 0x06042CC1 RID: 273601 RVA: 0x01041B90 File Offset: 0x0103FD90
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToBag(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			EPlaceResult eplaceResult = this.JudgeBagPlacement(visual, target);
			if (eplaceResult != EPlaceResult.Success)
			{
				return UniTask.FromResult<EPlaceResult>(eplaceResult);
			}
			if (adapter.ApplyLocal(visual, target, anchor) == null)
			{
				return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
			}
			this.EnqueuePendingOp(adapter, visual, target);
			return UniTask.FromResult<EPlaceResult>(EPlaceResult.Success);
		}

		// Token: 0x06042CC2 RID: 273602 RVA: 0x01041BD4 File Offset: 0x0103FDD4
		[return: Nullable(0)]
		public UniTask<EPlaceResult> CommitBestEffort(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			if (target == null)
			{
				return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
			}
			EDragTargetKind kind = target.Kind;
			UniTask<EPlaceResult> result;
			if (kind != EDragTargetKind.Bag)
			{
				if (kind == EDragTargetKind.Bench)
				{
					result = this.CommitToBench(adapter, visual, target, anchor);
				}
				else
				{
					result = UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
				}
			}
			else
			{
				result = this.CommitToBagBestEffort(adapter, visual, target, anchor);
			}
			return result;
		}

		// Token: 0x06042CC3 RID: 273603 RVA: 0x01041C20 File Offset: 0x0103FE20
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToBagBestEffort(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			EPlaceResult eplaceResult = this.JudgePrimaryBagPlacement(visual, target);
			if (eplaceResult != EPlaceResult.Success)
			{
				return UniTask.FromResult<EPlaceResult>(eplaceResult);
			}
			BagSourceAdapter bagSourceAdapter = adapter as BagSourceAdapter;
			if (bagSourceAdapter == null)
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[CommitToBagBestEffort] adapter 不是 BagSourceAdapter，降级为常规落地", default(ReadOnlySpan<ValueTuple<string, object>>));
				return this.CommitToBag(adapter, visual, target, anchor);
			}
			ValueTuple<OpSnapshot, List<int>>? valueTuple = bagSourceAdapter.ApplyLocalBagToBagBestEffort(visual, target, anchor);
			if (valueTuple == null)
			{
				return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
			}
			foreach (int uid in valueTuple.Value.Item2)
			{
				this.EnqueueBagToBench(uid);
			}
			this.EnqueuePendingOp(adapter, visual, target);
			return UniTask.FromResult<EPlaceResult>(EPlaceResult.Success);
		}

		// Token: 0x06042CC4 RID: 273604 RVA: 0x01041CF0 File Offset: 0x0103FEF0
		[NullableContext(0)]
		public UniTask<bool> Flush([Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null)
		{
			BatchedCommitStrategy.<Flush>d__14 <Flush>d__;
			<Flush>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Flush>d__.<>4__this = this;
			<Flush>d__.extraOps = extraOps;
			<Flush>d__.<>1__state = -1;
			<Flush>d__.<>t__builder.Start<BatchedCommitStrategy.<Flush>d__14>(ref <Flush>d__);
			return <Flush>d__.<>t__builder.Task;
		}

		// Token: 0x06042CC5 RID: 273605 RVA: 0x01041D3C File Offset: 0x0103FF3C
		private void RollbackInvolvedToAnchors([Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps)
		{
			HashSet<int> hashSet = new HashSet<int>(this.Pending.Keys);
			if (extraOps != null)
			{
				foreach (DangoBrawlBagOpInfo dangoBrawlBagOpInfo in extraOps)
				{
					hashSet.Add(dangoBrawlBagOpInfo.FromUid);
				}
			}
			if (hashSet.Count > 0)
			{
				DangoBrawlRollbackController rollbackCtrl = BatchedCommitStrategy.RollbackCtrl;
				if (rollbackCtrl != null)
				{
					rollbackCtrl.RestoreToServerAnchor(hashSet);
				}
			}
			this.Pending.Clear();
		}

		// Token: 0x06042CC6 RID: 273606 RVA: 0x01041DA4 File Offset: 0x0103FFA4
		public void DropPending(int uid)
		{
			this.Pending.Remove(uid);
		}

		// Token: 0x06042CC7 RID: 273607 RVA: 0x01041DB3 File Offset: 0x0103FFB3
		public void EnqueueBagToBench(int uid)
		{
			this.EnqueueByZone(uid);
		}

		// Token: 0x06042CC8 RID: 273608 RVA: 0x01041DBC File Offset: 0x0103FFBC
		private void EnqueuePendingOp(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target)
		{
			this.EnqueueByZone(visual.SourceUid);
		}

		// Token: 0x06042CC9 RID: 273609 RVA: 0x01041DCC File Offset: 0x0103FFCC
		private void EnqueueByZone(int uid)
		{
			this.Pending.Remove(uid);
			this.Pending[uid] = new PendingOp
			{
				SourceUid = uid,
				BuildOp = (() => this.BuildOpByZone(uid))
			};
		}

		// Token: 0x06042CCA RID: 273610 RVA: 0x01041E34 File Offset: 0x01040034
		private DangoBrawlBagOpInfo[] BuildOpByZone(int uid)
		{
			DangoBrawlRollbackController rollbackCtrl = BatchedCommitStrategy.RollbackCtrl;
			EItemZone eitemZone = (rollbackCtrl != null) ? rollbackCtrl.ResolveServerZone(uid) : EItemZone.None;
			EItemZone eitemZone2 = (rollbackCtrl != null) ? rollbackCtrl.ResolveZone(uid) : EItemZone.None;
			if (eitemZone2 != EItemZone.Bag)
			{
				if (eitemZone2 != EItemZone.Bench)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.DangoBrawl;
					ELogAuthor author = ELogAuthor.LSH;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[BatchedCommit] uid=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(uid);
					defaultInterpolatedStringHandler.AppendLiteral(" 终态不在两区，跳过 op 构建（serverZone=");
					defaultInterpolatedStringHandler.AppendFormatted<EItemZone>(eitemZone);
					defaultInterpolatedStringHandler.AppendLiteral("）");
					instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				if (eitemZone != EItemZone.Bag)
				{
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				DangoBrawlBagOpInfo dangoBrawlBagOpInfo = DangoBrawlBagOpInfo.Create();
				dangoBrawlBagOpInfo.FromUid = uid;
				dangoBrawlBagOpInfo.OpType = DangoBrawlBagOpType.ToBench;
				return new DangoBrawlBagOpInfo[]
				{
					dangoBrawlBagOpInfo
				};
			}
			else
			{
				DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(uid) : null;
				if (dangoBrawlBackpackItemData == null)
				{
					return Array.Empty<DangoBrawlBagOpInfo>();
				}
				DangoBrawlBagOpInfo dangoBrawlBagOpInfo2 = DangoBrawlBagOpInfo.Create();
				dangoBrawlBagOpInfo2.FromUid = uid;
				dangoBrawlBagOpInfo2.OpType = ((eitemZone == EItemZone.Bench) ? DangoBrawlBagOpType.BenchToNormal : DangoBrawlBagOpType.NormalChange);
				DangoBrawlBagSlotInfo dangoBrawlBagSlotInfo = DangoBrawlBagSlotInfo.Create();
				dangoBrawlBagSlotInfo.X = dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex;
				dangoBrawlBagSlotInfo.Y = dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex;
				dangoBrawlBagSlotInfo.Rotation = (int)dangoBrawlBackpackItemData.MyRotation;
				dangoBrawlBagOpInfo2.Slot = dangoBrawlBagSlotInfo;
				return new DangoBrawlBagOpInfo[]
				{
					dangoBrawlBagOpInfo2
				};
			}
		}

		// Token: 0x06042CCB RID: 273611 RVA: 0x01041F90 File Offset: 0x01040190
		private EPlaceResult JudgeBagPlacement(IDragVisual visual, DragTarget target)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (bagpackData == null || target.Bag == null)
			{
				return EPlaceResult.Reject;
			}
			if (DangoBrawlPlaceUtil.EvaluatePrimaryMode(bagpackData, visual, target.Bag.Value.LeftTopPos, target.Bag.Value.Rotate) != EDangoBrawlPlaceMode.Direct)
			{
				return EPlaceResult.Holding;
			}
			return EPlaceResult.Success;
		}

		// Token: 0x06042CCC RID: 273612 RVA: 0x01041FE8 File Offset: 0x010401E8
		private EPlaceResult JudgePrimaryBagPlacement(IDragVisual visual, DragTarget target)
		{
			DangoBrawlBackpackData bagpackData = this.Data.BagpackData;
			if (bagpackData == null || target.Bag == null)
			{
				return EPlaceResult.Reject;
			}
			if (DangoBrawlPlaceUtil.EvaluatePrimaryMode(bagpackData, visual, target.Bag.Value.LeftTopPos, target.Bag.Value.Rotate) == EDangoBrawlPlaceMode.Cannot)
			{
				return EPlaceResult.Holding;
			}
			return EPlaceResult.Success;
		}

		// Token: 0x04022C34 RID: 142388
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C35 RID: 142389
		private bool Started;

		// Token: 0x04022C36 RID: 142390
		private readonly Dictionary<int, PendingOp> Pending = new Dictionary<int, PendingOp>();
	}
}

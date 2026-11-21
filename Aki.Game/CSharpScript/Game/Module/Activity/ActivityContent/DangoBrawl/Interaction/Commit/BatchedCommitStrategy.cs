using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x020057D2 RID: 22482
	[NullableContext(1)]
	[Nullable(0)]
	public class BatchedCommitStrategy : ICommitStrategy
	{
		// Token: 0x17006AF6 RID: 27382
		// (get) Token: 0x06037812 RID: 227346 RVA: 0x00F82FFD File Offset: 0x00F811FD
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

		// Token: 0x06037813 RID: 227347 RVA: 0x00F8300F File Offset: 0x00F8120F
		public BatchedCommitStrategy(ActivityDangoBrawlData data)
		{
			this.Data = data;
		}

		// Token: 0x06037814 RID: 227348 RVA: 0x00F83029 File Offset: 0x00F81229
		public bool IsEmpty()
		{
			return this.Pending.Count == 0;
		}

		// Token: 0x06037815 RID: 227349 RVA: 0x00F83039 File Offset: 0x00F81239
		public void Start()
		{
			this.Started = true;
			this.Pending.Clear();
		}

		// Token: 0x06037816 RID: 227350 RVA: 0x00F8304D File Offset: 0x00F8124D
		public void Stop()
		{
			if (!this.Started)
			{
				return;
			}
			this.RollbackInvolvedToAnchors(null);
			this.Started = false;
		}

		// Token: 0x06037817 RID: 227351 RVA: 0x00F83068 File Offset: 0x00F81268
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

		// Token: 0x06037818 RID: 227352 RVA: 0x00F830AC File Offset: 0x00F812AC
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

		// Token: 0x06037819 RID: 227353 RVA: 0x00F83110 File Offset: 0x00F81310
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

		// Token: 0x0603781A RID: 227354 RVA: 0x00F83154 File Offset: 0x00F81354
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

		// Token: 0x0603781B RID: 227355 RVA: 0x00F831A0 File Offset: 0x00F813A0
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

		// Token: 0x0603781C RID: 227356 RVA: 0x00F83270 File Offset: 0x00F81470
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

		// Token: 0x0603781D RID: 227357 RVA: 0x00F832BC File Offset: 0x00F814BC
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

		// Token: 0x0603781E RID: 227358 RVA: 0x00F83324 File Offset: 0x00F81524
		public void DropPending(int uid)
		{
			this.Pending.Remove(uid);
		}

		// Token: 0x0603781F RID: 227359 RVA: 0x00F83333 File Offset: 0x00F81533
		public void EnqueueBagToBench(int uid)
		{
			this.EnqueueByZone(uid);
		}

		// Token: 0x06037820 RID: 227360 RVA: 0x00F8333C File Offset: 0x00F8153C
		private void EnqueuePendingOp(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target)
		{
			this.EnqueueByZone(visual.SourceUid);
		}

		// Token: 0x06037821 RID: 227361 RVA: 0x00F8334C File Offset: 0x00F8154C
		private void EnqueueByZone(int uid)
		{
			this.Pending.Remove(uid);
			this.Pending[uid] = new PendingOp
			{
				SourceUid = uid,
				BuildOp = (() => this.BuildOpByZone(uid))
			};
		}

		// Token: 0x06037822 RID: 227362 RVA: 0x00F833B4 File Offset: 0x00F815B4
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

		// Token: 0x06037823 RID: 227363 RVA: 0x00F83510 File Offset: 0x00F81710
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

		// Token: 0x06037824 RID: 227364 RVA: 0x00F83568 File Offset: 0x00F81768
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

		// Token: 0x0401D490 RID: 119952
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D491 RID: 119953
		private bool Started;

		// Token: 0x0401D492 RID: 119954
		private readonly Dictionary<int, PendingOp> Pending = new Dictionary<int, PendingOp>();
	}
}

using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006888 RID: 26760
	[NullableContext(1)]
	[Nullable(0)]
	public class ImmediateCommitStrategy : ICommitStrategy
	{
		// Token: 0x06042CE5 RID: 273637 RVA: 0x0104307C File Offset: 0x0104127C
		public ImmediateCommitStrategy(ActivityDangoBrawlData data)
		{
			this.Data = data;
		}

		// Token: 0x06042CE6 RID: 273638 RVA: 0x0104308C File Offset: 0x0104128C
		[return: Nullable(0)]
		public UniTask<EPlaceResult> Commit(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			if (target == null)
			{
				return UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
			}
			UniTask<EPlaceResult> result;
			switch (target.Kind)
			{
			case EDragTargetKind.Shop:
				result = this.CommitToShop(adapter, visual, target, anchor);
				break;
			case EDragTargetKind.Bag:
				result = this.CommitToBag(adapter, visual, target, anchor);
				break;
			case EDragTargetKind.Bench:
				result = this.CommitToBench(adapter, visual, target, anchor);
				break;
			default:
				result = UniTask.FromResult<EPlaceResult>(EPlaceResult.Reject);
				break;
			}
			return result;
		}

		// Token: 0x06042CE7 RID: 273639 RVA: 0x010430F0 File Offset: 0x010412F0
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToShop(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			ImmediateCommitStrategy.<CommitToShop>d__3 <CommitToShop>d__;
			<CommitToShop>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPlaceResult>.Create();
			<CommitToShop>d__.<>4__this = this;
			<CommitToShop>d__.adapter = adapter;
			<CommitToShop>d__.visual = visual;
			<CommitToShop>d__.target = target;
			<CommitToShop>d__.anchor = anchor;
			<CommitToShop>d__.<>1__state = -1;
			<CommitToShop>d__.<>t__builder.Start<ImmediateCommitStrategy.<CommitToShop>d__3>(ref <CommitToShop>d__);
			return <CommitToShop>d__.<>t__builder.Task;
		}

		// Token: 0x06042CE8 RID: 273640 RVA: 0x01043154 File Offset: 0x01041354
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToBench(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			return this.RunAdapterCommit(adapter, visual, target, anchor);
		}

		// Token: 0x06042CE9 RID: 273641 RVA: 0x01043164 File Offset: 0x01041364
		[return: Nullable(0)]
		private UniTask<EPlaceResult> CommitToBag(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			ImmediateCommitStrategy.<CommitToBag>d__5 <CommitToBag>d__;
			<CommitToBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPlaceResult>.Create();
			<CommitToBag>d__.<>4__this = this;
			<CommitToBag>d__.adapter = adapter;
			<CommitToBag>d__.visual = visual;
			<CommitToBag>d__.target = target;
			<CommitToBag>d__.anchor = anchor;
			<CommitToBag>d__.<>1__state = -1;
			<CommitToBag>d__.<>t__builder.Start<ImmediateCommitStrategy.<CommitToBag>d__5>(ref <CommitToBag>d__);
			return <CommitToBag>d__.<>t__builder.Task;
		}

		// Token: 0x06042CEA RID: 273642 RVA: 0x010431C8 File Offset: 0x010413C8
		[return: Nullable(0)]
		private UniTask<EPlaceResult> RunAdapterCommit(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			ImmediateCommitStrategy.<RunAdapterCommit>d__6 <RunAdapterCommit>d__;
			<RunAdapterCommit>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPlaceResult>.Create();
			<RunAdapterCommit>d__.adapter = adapter;
			<RunAdapterCommit>d__.visual = visual;
			<RunAdapterCommit>d__.target = target;
			<RunAdapterCommit>d__.anchor = anchor;
			<RunAdapterCommit>d__.<>1__state = -1;
			<RunAdapterCommit>d__.<>t__builder.Start<ImmediateCommitStrategy.<RunAdapterCommit>d__6>(ref <RunAdapterCommit>d__);
			return <RunAdapterCommit>d__.<>t__builder.Task;
		}

		// Token: 0x04022C41 RID: 142401
		private readonly ActivityDangoBrawlData Data;
	}
}

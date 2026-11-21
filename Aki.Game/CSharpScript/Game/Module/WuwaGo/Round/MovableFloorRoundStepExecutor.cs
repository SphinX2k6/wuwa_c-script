using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x02003659 RID: 13913
	[NullableContext(1)]
	[Nullable(0)]
	public class MovableFloorRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x06024170 RID: 147824 RVA: 0x00A36BC7 File Offset: 0x00A34DC7
		public MovableFloorRoundStepExecutor(IWuWaGoGridMutationService gridMutationService, Func<int> getExecutionToken, [Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<IExecutableUnit, string> setCurrentProcess, [Nullable(new byte[]
		{
			2,
			1
		})] Func<IWuWaGoMovableFloorBatchResult, int, UniTask> onBatchFinished = null)
		{
		}

		// Token: 0x06024171 RID: 147825 RVA: 0x00A36BEC File Offset: 0x00A34DEC
		public UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken)
		{
			MovableFloorRoundStepExecutor.<Execute>d__5 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.units = units;
			<Execute>d__.executionToken = executionToken;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<MovableFloorRoundStepExecutor.<Execute>d__5>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x040141F4 RID: 82420
		[CompilerGenerated]
		private IWuWaGoGridMutationService <gridMutationService>P = gridMutationService;

		// Token: 0x040141F5 RID: 82421
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x040141F6 RID: 82422
		[Nullable(new byte[]
		{
			1,
			2,
			2
		})]
		[CompilerGenerated]
		private Action<IExecutableUnit, string> <setCurrentProcess>P = setCurrentProcess;

		// Token: 0x040141F7 RID: 82423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private Func<IWuWaGoMovableFloorBatchResult, int, UniTask> <onBatchFinished>P = onBatchFinished;
	}
}

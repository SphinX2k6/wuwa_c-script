using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x02004728 RID: 18216
	[NullableContext(1)]
	[Nullable(0)]
	public class MovableFloorRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x0602F9A6 RID: 194982 RVA: 0x00B06D3B File Offset: 0x00B04F3B
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

		// Token: 0x0602F9A7 RID: 194983 RVA: 0x00B06D60 File Offset: 0x00B04F60
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

		// Token: 0x04019B44 RID: 105284
		[CompilerGenerated]
		private IWuWaGoGridMutationService <gridMutationService>P = gridMutationService;

		// Token: 0x04019B45 RID: 105285
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x04019B46 RID: 105286
		[Nullable(new byte[]
		{
			1,
			2,
			2
		})]
		[CompilerGenerated]
		private Action<IExecutableUnit, string> <setCurrentProcess>P = setCurrentProcess;

		// Token: 0x04019B47 RID: 105287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private Func<IWuWaGoMovableFloorBatchResult, int, UniTask> <onBatchFinished>P = onBatchFinished;
	}
}

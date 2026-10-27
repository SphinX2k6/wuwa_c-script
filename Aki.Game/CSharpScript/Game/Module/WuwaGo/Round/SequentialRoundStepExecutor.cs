using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x0200472A RID: 18218
	[NullableContext(1)]
	[Nullable(0)]
	public class SequentialRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x0602F9C5 RID: 195013 RVA: 0x00B0756D File Offset: 0x00B0576D
		public SequentialRoundStepExecutor([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<ERoundStep, IReadOnlyList<IExecutableUnit>> getRegisteredUnits, Func<int> getExecutionToken, [Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<IExecutableUnit, string> setCurrentProcess, Func<int, bool> shouldAbortRound)
		{
		}

		// Token: 0x0602F9C6 RID: 195014 RVA: 0x00B07594 File Offset: 0x00B05794
		public UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken)
		{
			SequentialRoundStepExecutor.<Execute>d__5 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.step = step;
			<Execute>d__.units = units;
			<Execute>d__.executionToken = executionToken;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<SequentialRoundStepExecutor.<Execute>d__5>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x04019B53 RID: 105299
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		[CompilerGenerated]
		private Func<ERoundStep, IReadOnlyList<IExecutableUnit>> <getRegisteredUnits>P = getRegisteredUnits;

		// Token: 0x04019B54 RID: 105300
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x04019B55 RID: 105301
		[Nullable(new byte[]
		{
			1,
			2,
			2
		})]
		[CompilerGenerated]
		private Action<IExecutableUnit, string> <setCurrentProcess>P = setCurrentProcess;

		// Token: 0x04019B56 RID: 105302
		[CompilerGenerated]
		private Func<int, bool> <shouldAbortRound>P = shouldAbortRound;
	}
}

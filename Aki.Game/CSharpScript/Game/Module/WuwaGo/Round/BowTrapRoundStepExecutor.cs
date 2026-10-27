using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x02004725 RID: 18213
	[NullableContext(1)]
	[Nullable(0)]
	public class BowTrapRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x0602F9A0 RID: 194976 RVA: 0x00B06BE1 File Offset: 0x00B04DE1
		public BowTrapRoundStepExecutor(Func<int> getExecutionToken, [Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<IExecutableUnit, string> setCurrentProcess)
		{
		}

		// Token: 0x0602F9A1 RID: 194977 RVA: 0x00B06BF8 File Offset: 0x00B04DF8
		public UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken)
		{
			BowTrapRoundStepExecutor.<Execute>d__3 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.units = units;
			<Execute>d__.executionToken = executionToken;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<BowTrapRoundStepExecutor.<Execute>d__3>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x04019B3B RID: 105275
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x04019B3C RID: 105276
		[Nullable(new byte[]
		{
			1,
			2,
			2
		})]
		[CompilerGenerated]
		private Action<IExecutableUnit, string> <setCurrentProcess>P = setCurrentProcess;
	}
}

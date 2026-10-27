using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x02004727 RID: 18215
	[NullableContext(1)]
	[Nullable(0)]
	public class GearTrapRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x0602F9A4 RID: 194980 RVA: 0x00B06CC3 File Offset: 0x00B04EC3
		public GearTrapRoundStepExecutor([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Func<ERoundStep, IReadOnlyList<IExecutableUnit>> getRegisteredUnits, Func<int> getExecutionToken, [Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<IExecutableUnit, string> setCurrentProcess)
		{
		}

		// Token: 0x0602F9A5 RID: 194981 RVA: 0x00B06CE0 File Offset: 0x00B04EE0
		public UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken)
		{
			GearTrapRoundStepExecutor.<Execute>d__4 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.step = step;
			<Execute>d__.units = units;
			<Execute>d__.executionToken = executionToken;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<GearTrapRoundStepExecutor.<Execute>d__4>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x04019B41 RID: 105281
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		[CompilerGenerated]
		private Func<ERoundStep, IReadOnlyList<IExecutableUnit>> <getRegisteredUnits>P = getRegisteredUnits;

		// Token: 0x04019B42 RID: 105282
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x04019B43 RID: 105283
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

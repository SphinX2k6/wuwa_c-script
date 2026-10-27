using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Round
{
	// Token: 0x02004726 RID: 18214
	[NullableContext(1)]
	[Nullable(0)]
	public class GearAndBowTrapRoundStepExecutor : IRoundStepExecutor
	{
		// Token: 0x0602F9A2 RID: 194978 RVA: 0x00B06C4B File Offset: 0x00B04E4B
		public GearAndBowTrapRoundStepExecutor([Nullable(new byte[]
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

		// Token: 0x0602F9A3 RID: 194979 RVA: 0x00B06C68 File Offset: 0x00B04E68
		public UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken)
		{
			GearAndBowTrapRoundStepExecutor.<Execute>d__5 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.step = step;
			<Execute>d__.units = units;
			<Execute>d__.executionToken = executionToken;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<GearAndBowTrapRoundStepExecutor.<Execute>d__5>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x04019B3D RID: 105277
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		[CompilerGenerated]
		private Func<ERoundStep, IReadOnlyList<IExecutableUnit>> <getRegisteredUnits>P = getRegisteredUnits;

		// Token: 0x04019B3E RID: 105278
		[CompilerGenerated]
		private Func<int> <getExecutionToken>P = getExecutionToken;

		// Token: 0x04019B3F RID: 105279
		[Nullable(new byte[]
		{
			1,
			2,
			2
		})]
		[CompilerGenerated]
		private Action<IExecutableUnit, string> <setCurrentProcess>P = setCurrentProcess;

		// Token: 0x04019B40 RID: 105280
		private const string DAMAGE_BATCH_REASON = "GearAndBowTrapRoundStep";
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x02004528 RID: 17704
	[NullableContext(1)]
	[Nullable(0)]
	public class StepSequence
	{
		// Token: 0x0602DBAC RID: 187308 RVA: 0x00A82159 File Offset: 0x00A80359
		public StepSequence AddStep(SequenceStep step)
		{
			this.Steps.Add(step);
			return this;
		}

		// Token: 0x0602DBAD RID: 187309 RVA: 0x00A82168 File Offset: 0x00A80368
		public StepSequence SetOnAbort(Action handler)
		{
			this.OnAbortHandler = handler;
			return this;
		}

		// Token: 0x0602DBAE RID: 187310 RVA: 0x00A82172 File Offset: 0x00A80372
		public StepSequence SetFinally(Action handler)
		{
			this.FinallyHandler = handler;
			return this;
		}

		// Token: 0x0602DBAF RID: 187311 RVA: 0x00A8217C File Offset: 0x00A8037C
		[NullableContext(0)]
		private static UniTask<bool> RaceStep(UniTask stepResult, [Nullable(1)] ISequenceAbortSignal abortSignal)
		{
			StepSequence.<RaceStep>d__6 <RaceStep>d__;
			<RaceStep>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RaceStep>d__.stepResult = stepResult;
			<RaceStep>d__.abortSignal = abortSignal;
			<RaceStep>d__.<>1__state = -1;
			<RaceStep>d__.<>t__builder.Start<StepSequence.<RaceStep>d__6>(ref <RaceStep>d__);
			return <RaceStep>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBB0 RID: 187312 RVA: 0x00A821C8 File Offset: 0x00A803C8
		public UniTask Run(ISequenceAbortSignal abortSignal)
		{
			StepSequence.<Run>d__7 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.abortSignal = abortSignal;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<StepSequence.<Run>d__7>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0401869B RID: 99995
		private readonly List<SequenceStep> Steps = new List<SequenceStep>();

		// Token: 0x0401869C RID: 99996
		[Nullable(2)]
		private Action OnAbortHandler;

		// Token: 0x0401869D RID: 99997
		[Nullable(2)]
		private Action FinallyHandler;
	}
}

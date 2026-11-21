using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x0200344D RID: 13389
	[NullableContext(1)]
	[Nullable(0)]
	public class StepSequence
	{
		// Token: 0x06022273 RID: 139891 RVA: 0x009AD3C1 File Offset: 0x009AB5C1
		public StepSequence AddStep(SequenceStep step)
		{
			this.Steps.Add(step);
			return this;
		}

		// Token: 0x06022274 RID: 139892 RVA: 0x009AD3D0 File Offset: 0x009AB5D0
		public StepSequence SetOnAbort(Action handler)
		{
			this.OnAbortHandler = handler;
			return this;
		}

		// Token: 0x06022275 RID: 139893 RVA: 0x009AD3DA File Offset: 0x009AB5DA
		public StepSequence SetFinally(Action handler)
		{
			this.FinallyHandler = handler;
			return this;
		}

		// Token: 0x06022276 RID: 139894 RVA: 0x009AD3E4 File Offset: 0x009AB5E4
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

		// Token: 0x06022277 RID: 139895 RVA: 0x009AD430 File Offset: 0x009AB630
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

		// Token: 0x04012CBF RID: 76991
		private readonly List<SequenceStep> Steps = new List<SequenceStep>();

		// Token: 0x04012CC0 RID: 76992
		[Nullable(2)]
		private Action OnAbortHandler;

		// Token: 0x04012CC1 RID: 76993
		[Nullable(2)]
		private Action FinallyHandler;
	}
}

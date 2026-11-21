using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034FE RID: 13566
	public class PostProcessTriggerStateInsideToOutside : PostProcessTriggerStateBase
	{
		// Token: 0x06022832 RID: 141362 RVA: 0x009CBAA7 File Offset: 0x009C9CA7
		[NullableContext(1)]
		public PostProcessTriggerStateInsideToOutside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022833 RID: 141363 RVA: 0x009CBAB4 File Offset: 0x009C9CB4
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Timer = 0.0;
			double targetDefaultValue = base.GetTargetDefaultValue();
			this.Owner.GetPostProcessComponent().BlendWeight = (float)targetDefaultValue;
		}

		// Token: 0x06022834 RID: 141364 RVA: 0x009CBAEC File Offset: 0x009C9CEC
		protected override void OnUpdate(float delta)
		{
			if (this.Timer > this.Owner.TransitionTime)
			{
				this.StateMachine.Switch(EPostProcessTriggerState.Outside);
				return;
			}
			this.Timer += (double)delta / 1000.0;
			double num = MathUtils.Instance.Clamp(this.Timer / this.Owner.TransitionTime, 0.0, 1.0);
			double targetDefaultValue = base.GetTargetDefaultValue();
			this.Owner.GetPostProcessComponent().BlendWeight = (float)MathUtils.Instance.Clamp(1.0 - num, 0.0, targetDefaultValue);
		}

		// Token: 0x0401314F RID: 78159
		protected double Timer;
	}
}

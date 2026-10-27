using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D4 RID: 17876
	public class PostProcessTriggerStateInside : PostProcessTriggerStateBase
	{
		// Token: 0x0602E13B RID: 188731 RVA: 0x00A9F2B2 File Offset: 0x00A9D4B2
		[NullableContext(1)]
		public PostProcessTriggerStateInside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E13C RID: 188732 RVA: 0x00A9F2C0 File Offset: 0x00A9D4C0
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			double targetDefaultValue = base.GetTargetDefaultValue();
			this.Owner.GetPostProcessComponent().BlendWeight = (float)targetDefaultValue;
			this.LastInnerValue = targetDefaultValue;
			this.IsTickingState = false;
			this.Timer = 0.0;
		}

		// Token: 0x0602E13D RID: 188733 RVA: 0x00A9F304 File Offset: 0x00A9D504
		protected override void OnUpdate(float delta)
		{
			double targetDefaultValue = base.GetTargetDefaultValue();
			if (this.IsTickingState)
			{
				this.Timer += (double)delta / 1000.0;
				double num = MathUtils.Instance.Clamp(this.Timer / this.Owner.TransitionTime, 0.0, 1.0);
				this.Owner.GetPostProcessComponent().BlendWeight = (float)MathUtils.Instance.Lerp(this.LastInnerValue, targetDefaultValue, num);
				if (num >= 1.0)
				{
					this.IsTickingState = false;
					this.Timer = 0.0;
					this.LastInnerValue = targetDefaultValue;
					return;
				}
			}
			else if (this.LastInnerValue != targetDefaultValue)
			{
				this.IsTickingState = true;
				this.Timer = 0.0;
			}
		}

		// Token: 0x04018B0E RID: 101134
		private double LastInnerValue;

		// Token: 0x04018B0F RID: 101135
		private bool IsTickingState;

		// Token: 0x04018B10 RID: 101136
		private double Timer;
	}
}

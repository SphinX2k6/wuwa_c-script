using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034FD RID: 13565
	public class PostProcessTriggerStateInside : PostProcessTriggerStateBase
	{
		// Token: 0x0602282F RID: 141359 RVA: 0x009CB982 File Offset: 0x009C9B82
		[NullableContext(1)]
		public PostProcessTriggerStateInside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022830 RID: 141360 RVA: 0x009CB990 File Offset: 0x009C9B90
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			double targetDefaultValue = base.GetTargetDefaultValue();
			this.Owner.GetPostProcessComponent().BlendWeight = (float)targetDefaultValue;
			this.LastInnerValue = targetDefaultValue;
			this.IsTickingState = false;
			this.Timer = 0.0;
		}

		// Token: 0x06022831 RID: 141361 RVA: 0x009CB9D4 File Offset: 0x009C9BD4
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

		// Token: 0x0401314C RID: 78156
		private double LastInnerValue;

		// Token: 0x0401314D RID: 78157
		private bool IsTickingState;

		// Token: 0x0401314E RID: 78158
		private double Timer;
	}
}

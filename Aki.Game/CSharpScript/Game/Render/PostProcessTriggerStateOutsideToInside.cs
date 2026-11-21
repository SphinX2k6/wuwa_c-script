using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003500 RID: 13568
	public class PostProcessTriggerStateOutsideToInside : PostProcessTriggerStateBase
	{
		// Token: 0x06022837 RID: 141367 RVA: 0x009CBBBB File Offset: 0x009C9DBB
		[NullableContext(1)]
		public PostProcessTriggerStateOutsideToInside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022838 RID: 141368 RVA: 0x009CBBC6 File Offset: 0x009C9DC6
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Timer = 0.0;
			this.Owner.GetPostProcessComponent().BlendWeight = 0f;
		}

		// Token: 0x06022839 RID: 141369 RVA: 0x009CBBEC File Offset: 0x009C9DEC
		protected override void OnUpdate(float delta)
		{
			if (this.Timer > this.Owner.TransitionTime)
			{
				this.StateMachine.Switch(EPostProcessTriggerState.Inside);
				return;
			}
			this.Timer += (double)delta / 1000.0;
			double num = MathUtils.Instance.Clamp(this.Timer / this.Owner.TransitionTime, 0.0, base.GetTargetDefaultValue());
			this.Owner.GetPostProcessComponent().BlendWeight = (float)num;
		}

		// Token: 0x04013150 RID: 78160
		protected double Timer;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D7 RID: 17879
	public class PostProcessTriggerStateOutsideToInside : PostProcessTriggerStateBase
	{
		// Token: 0x0602E143 RID: 188739 RVA: 0x00A9F4EB File Offset: 0x00A9D6EB
		[NullableContext(1)]
		public PostProcessTriggerStateOutsideToInside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E144 RID: 188740 RVA: 0x00A9F4F6 File Offset: 0x00A9D6F6
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Timer = 0.0;
			this.Owner.GetPostProcessComponent().BlendWeight = 0f;
		}

		// Token: 0x0602E145 RID: 188741 RVA: 0x00A9F51C File Offset: 0x00A9D71C
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

		// Token: 0x04018B12 RID: 101138
		protected double Timer;
	}
}

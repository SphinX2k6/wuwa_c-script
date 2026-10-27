using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D5 RID: 17877
	public class PostProcessTriggerStateInsideToOutside : PostProcessTriggerStateBase
	{
		// Token: 0x0602E13E RID: 188734 RVA: 0x00A9F3D7 File Offset: 0x00A9D5D7
		[NullableContext(1)]
		public PostProcessTriggerStateInsideToOutside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E13F RID: 188735 RVA: 0x00A9F3E4 File Offset: 0x00A9D5E4
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Timer = 0.0;
			double targetDefaultValue = base.GetTargetDefaultValue();
			this.Owner.GetPostProcessComponent().BlendWeight = (float)targetDefaultValue;
		}

		// Token: 0x0602E140 RID: 188736 RVA: 0x00A9F41C File Offset: 0x00A9D61C
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

		// Token: 0x04018B11 RID: 101137
		protected double Timer;
	}
}

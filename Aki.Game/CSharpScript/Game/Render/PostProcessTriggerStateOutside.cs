using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045D6 RID: 17878
	public class PostProcessTriggerStateOutside : PostProcessTriggerStateBase
	{
		// Token: 0x0602E141 RID: 188737 RVA: 0x00A9F4C9 File Offset: 0x00A9D6C9
		[NullableContext(1)]
		public PostProcessTriggerStateOutside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E142 RID: 188738 RVA: 0x00A9F4D4 File Offset: 0x00A9D6D4
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Owner.GetPostProcessComponent().BlendWeight = 0f;
		}
	}
}

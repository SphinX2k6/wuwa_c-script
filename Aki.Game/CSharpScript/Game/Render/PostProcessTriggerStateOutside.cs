using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034FF RID: 13567
	public class PostProcessTriggerStateOutside : PostProcessTriggerStateBase
	{
		// Token: 0x06022835 RID: 141365 RVA: 0x009CBB99 File Offset: 0x009C9D99
		[NullableContext(1)]
		public PostProcessTriggerStateOutside(PostProcessTrigger owner, EPostProcessTriggerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<PostProcessTrigger, EPostProcessTriggerState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022836 RID: 141366 RVA: 0x009CBBA4 File Offset: 0x009C9DA4
		protected override void OnEnter(EPostProcessTriggerState? lastState)
		{
			this.Owner.GetPostProcessComponent().BlendWeight = 0f;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200637B RID: 25467
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegardAsFollowShooterHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x0603DB69 RID: 252777 RVA: 0x011E22D2 File Offset: 0x011E04D2
		protected override bool CanHandle(EntityHandleParameterContext context)
		{
			return FollowUtils.IsFollowShooter(context.EntityHandle);
		}

		// Token: 0x0603DB6A RID: 252778 RVA: 0x011E22DF File Offset: 0x011E04DF
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.FollowShooter);
		}

		// Token: 0x0603DB6B RID: 252779 RVA: 0x011E22ED File Offset: 0x011E04ED
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x0603DB6C RID: 252780 RVA: 0x011E22F0 File Offset: 0x011E04F0
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

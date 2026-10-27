using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714D RID: 29005
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegardAsFollowShooterHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x06046D0F RID: 290063 RVA: 0x011D9120 File Offset: 0x011D7320
		protected override bool CanHandle(EntityHandleParameterContext context)
		{
			return FollowUtils.IsFollowShooter(context.EntityHandle);
		}

		// Token: 0x06046D10 RID: 290064 RVA: 0x011D912D File Offset: 0x011D732D
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.FollowShooter);
		}

		// Token: 0x06046D11 RID: 290065 RVA: 0x011D913B File Offset: 0x011D733B
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x06046D12 RID: 290066 RVA: 0x011D913E File Offset: 0x011D733E
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

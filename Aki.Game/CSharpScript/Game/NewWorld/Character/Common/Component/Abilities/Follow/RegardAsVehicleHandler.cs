using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007150 RID: 29008
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegardAsVehicleHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x06046D27 RID: 290087 RVA: 0x011D9480 File Offset: 0x011D7680
		protected override bool CanHandle(EntityHandleParameterContext context)
		{
			return context.EntityHandle.EntityType == 10;
		}

		// Token: 0x06046D28 RID: 290088 RVA: 0x011D9491 File Offset: 0x011D7691
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.Vehicle);
		}

		// Token: 0x06046D29 RID: 290089 RVA: 0x011D949F File Offset: 0x011D769F
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x06046D2A RID: 290090 RVA: 0x011D94A2 File Offset: 0x011D76A2
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

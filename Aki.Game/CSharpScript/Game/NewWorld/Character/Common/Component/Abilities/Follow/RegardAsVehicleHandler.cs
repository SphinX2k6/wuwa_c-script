using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200637E RID: 25470
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegardAsVehicleHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x0603DB81 RID: 252801 RVA: 0x011E2634 File Offset: 0x011E0834
		protected override bool CanHandle(EntityHandleParameterContext context)
		{
			return context.EntityHandle.EntityType == 10;
		}

		// Token: 0x0603DB82 RID: 252802 RVA: 0x011E2645 File Offset: 0x011E0845
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.Vehicle);
		}

		// Token: 0x0603DB83 RID: 252803 RVA: 0x011E2653 File Offset: 0x011E0853
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x0603DB84 RID: 252804 RVA: 0x011E2656 File Offset: 0x011E0856
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

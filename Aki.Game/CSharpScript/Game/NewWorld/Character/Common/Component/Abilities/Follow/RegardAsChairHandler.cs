using System;
using Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007149 RID: 29001
	internal class RegardAsChairHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x06046CAF RID: 289967 RVA: 0x011D6B44 File Offset: 0x011D4D44
		protected override bool CanHandle(EntityHandleParameterContext context)
		{
			WorldEntity entity = context.EntityHandle.Entity;
			if (entity == null)
			{
				return false;
			}
			DecorationFollowerComponent component = entity.GetComponent<DecorationFollowerComponent>();
			return ((component != null) ? new bool?(component.IsChair) : null).GetValueOrDefault();
		}

		// Token: 0x06046CB0 RID: 289968 RVA: 0x011D6B88 File Offset: 0x011D4D88
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.Chair);
		}

		// Token: 0x06046CB1 RID: 289969 RVA: 0x011D6B96 File Offset: 0x011D4D96
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x06046CB2 RID: 289970 RVA: 0x011D6B99 File Offset: 0x011D4D99
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

using System;
using Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006377 RID: 25463
	internal class RegardAsChairHandler : AbstractHandler<EntityHandleParameterContext>
	{
		// Token: 0x0603DB01 RID: 252673 RVA: 0x011DF524 File Offset: 0x011DD724
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

		// Token: 0x0603DB02 RID: 252674 RVA: 0x011DF568 File Offset: 0x011DD768
		protected override void ExecuteProcessing(EntityHandleParameterContext context)
		{
			context.OutPlayerFollowerHandlerType = new EPlayerFollowerHandlerType?(EPlayerFollowerHandlerType.Chair);
		}

		// Token: 0x0603DB03 RID: 252675 RVA: 0x011DF576 File Offset: 0x011DD776
		protected override bool ShouldStop(EntityHandleParameterContext context)
		{
			return false;
		}

		// Token: 0x0603DB04 RID: 252676 RVA: 0x011DF579 File Offset: 0x011DD779
		protected override void ExecuteStopping(EntityHandleParameterContext context)
		{
		}
	}
}

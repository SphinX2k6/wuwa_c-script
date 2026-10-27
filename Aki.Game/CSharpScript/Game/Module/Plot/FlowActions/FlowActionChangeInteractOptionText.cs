using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B1 RID: 20657
	public class FlowActionChangeInteractOptionText : FlowActionBase
	{
		// Token: 0x06034EBB RID: 216763 RVA: 0x00C88DB0 File Offset: 0x00C86FB0
		protected override void OnExecute()
		{
			int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
			if (currentInteractEntityId == null)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(currentInteractEntityId.Value);
			if (entity == null)
			{
				return;
			}
			PawnInteractNewComponent component = entity.GetComponent<PawnInteractNewComponent>();
			if (component == null)
			{
				return;
			}
			PawnInteractController interactController = component.GetInteractController();
			if (interactController == null)
			{
				return;
			}
			CommonInteractOption currentInteractOption = interactController.CurrentInteractOption;
			if (currentInteractOption == null)
			{
				return;
			}
			ChangeInteractOptionText changeInteractOptionText = this.ActionInfo.Params as ChangeInteractOptionText;
			currentInteractOption.TidContent = ((changeInteractOptionText != null) ? changeInteractOptionText.TidContent : null);
		}
	}
}

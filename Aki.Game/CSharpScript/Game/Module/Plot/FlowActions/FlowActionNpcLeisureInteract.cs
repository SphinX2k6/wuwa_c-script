using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C3 RID: 20675
	public class FlowActionNpcLeisureInteract : FlowActionBase
	{
		// Token: 0x06034EF6 RID: 216822 RVA: 0x00C89B64 File Offset: 0x00C87D64
		protected override void OnExecute()
		{
			NpcLeisureInteract npcLeisureInteract = this.ActionInfo.Params as NpcLeisureInteract;
			if (npcLeisureInteract == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CWZ, " LevelEventNpcLeisureInteract, 坐下参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			switch (npcLeisureInteract.Option.Type)
			{
			case ENpcLeisureInteract.SitDown:
				break;
			case ENpcLeisureInteract.Swing:
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(((INpcSwing)npcLeisureInteract.Option).TargetNpcId);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				if (worldEntity == null)
				{
					return;
				}
				CharacterSwingComponent component = worldEntity.GetComponent<CharacterSwingComponent>();
				if (component == null)
				{
					return;
				}
				component.StartSwing(((INpcSwing)npcLeisureInteract.Option).SwingDa, ((INpcSwing)npcLeisureInteract.Option).EntityId, new bool?(((INpcSwing)npcLeisureInteract.Option).SkipSitDown.GetValueOrDefault()));
				break;
			}
			case ENpcLeisureInteract.SwingGetUp:
			{
				EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(((INpcSwingGetUp)npcLeisureInteract.Option).TargetNpcId);
				WorldEntity worldEntity2 = (entityByPbDataId2 != null) ? entityByPbDataId2.Entity : null;
				if (worldEntity2 == null)
				{
					return;
				}
				CharacterSwingComponent component2 = worldEntity2.GetComponent<CharacterSwingComponent>();
				if (component2 == null)
				{
					return;
				}
				component2.ExitLoopSwing();
				return;
			}
			default:
				return;
			}
		}
	}
}

using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200407E RID: 16510
	public class FlowActionChangeEntitySelfState : FlowActionBase
	{
		// Token: 0x06029DAD RID: 171437 RVA: 0x00BD5DD0 File Offset: 0x00BD3FD0
		protected override void OnExecute()
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName((this.ActionInfo.Params as ChangeSelfEntityState).EntityState);
			EGeneralContextType? type = this.Context.Context.Type;
			if (type == null)
			{
				return;
			}
			EGeneralContextType valueOrDefault = type.GetValueOrDefault();
			int? num;
			if (valueOrDefault != EGeneralContextType.Entity)
			{
				if (valueOrDefault != EGeneralContextType.Trigger)
				{
					return;
				}
				TriggerContext triggerContext = this.Context.Context as TriggerContext;
				num = ((triggerContext != null) ? triggerContext.TriggerEntityId : null);
			}
			else
			{
				EntityContext entityContext = this.Context.Context as EntityContext;
				num = ((entityContext != null) ? entityContext.EntityId : null);
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(num.GetValueOrDefault());
			if (entityById == null || !entityById.IsInit)
			{
				return;
			}
			LevelGeneralCommons.PrechangeStateTag(CreatureModel.Instance.GetPbDataIdByEntity(entityById), tagIdByName, "ShowInPlotSequence");
		}
	}
}

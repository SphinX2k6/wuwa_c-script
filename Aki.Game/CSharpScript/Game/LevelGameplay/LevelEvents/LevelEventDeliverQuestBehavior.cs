using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.ItemDeliver;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B0E RID: 27406
	public class LevelEventDeliverQuestBehavior : LevelEventBase
	{
		// Token: 0x06044084 RID: 278660 RVA: 0x010B88E7 File Offset: 0x010B6AE7
		public LevelEventDeliverQuestBehavior(int id) : base(id)
		{
		}

		// Token: 0x06044085 RID: 278661 RVA: 0x010B88F0 File Offset: 0x010B6AF0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionDeliverQuestBehavior actionDeliverQuestBehavior = inParams as ActionDeliverQuestBehavior;
			if (actionDeliverQuestBehavior == null)
			{
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(actionDeliverQuestBehavior.EntityId);
			string npcName = "";
			if (entityByPbDataId != null)
			{
				PawnInfoManageComponent component = entityByPbDataId.Entity.GetComponent<PawnInfoManageComponent>();
				npcName = (((component != null) ? component.PawnName : null) ?? "");
			}
			ItemDeliverController.Instance.OpenItemDeliverViewByHandInItem(actionDeliverQuestBehavior.Items, npcName, null, actionDeliverQuestBehavior.DescText, null);
		}
	}
}

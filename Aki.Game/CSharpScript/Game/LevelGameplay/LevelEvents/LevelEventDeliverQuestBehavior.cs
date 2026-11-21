using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.ItemDeliver;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C86 RID: 23686
	public class LevelEventDeliverQuestBehavior : LevelEventBase
	{
		// Token: 0x0603A1D6 RID: 238038 RVA: 0x01062173 File Offset: 0x01060373
		public LevelEventDeliverQuestBehavior(int id) : base(id)
		{
		}

		// Token: 0x0603A1D7 RID: 238039 RVA: 0x0106217C File Offset: 0x0106037C
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

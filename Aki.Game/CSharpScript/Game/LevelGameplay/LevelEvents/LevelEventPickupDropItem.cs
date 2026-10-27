using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B4A RID: 27466
	public class LevelEventPickupDropItem : LevelEventBase
	{
		// Token: 0x0604419D RID: 278941 RVA: 0x010C1919 File Offset: 0x010BFB19
		public LevelEventPickupDropItem(int id) : base(id)
		{
		}

		// Token: 0x0604419E RID: 278942 RVA: 0x010C1924 File Offset: 0x010BFB24
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionPickupDropItem actionPickupDropItem = inParams as ActionPickupDropItem;
			if (actionPickupDropItem == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			int entityId = actionPickupDropItem.EntityId;
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null || !entity.Valid)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (!RewardController.Instance.PickUpFightDrop(component.GetCreatureDataId(), component.GetPbDataId(), new Action<bool>(this.OnResponse)))
			{
				base.FinishExecute(false, false, true);
			}
		}

		// Token: 0x0604419F RID: 278943 RVA: 0x010C19A7 File Offset: 0x010BFBA7
		private void OnResponse(bool isSuccess)
		{
			base.FinishExecute(isSuccess, false, true);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AFF RID: 27391
	public class LevelEventChangeSelfEntityState : LevelEventBase
	{
		// Token: 0x0604403C RID: 278588 RVA: 0x010B5BA5 File Offset: 0x010B3DA5
		public LevelEventChangeSelfEntityState(int id) : base(id)
		{
		}

		// Token: 0x0604403D RID: 278589 RVA: 0x010B5BB0 File Offset: 0x010B3DB0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ChangeSelfEntityState changeSelfEntityState = inParams as ChangeSelfEntityState;
			int? num = null;
			num = new int?(GameplayTagUtils.GetTagIdByName(changeSelfEntityState.EntityState));
			int? num2 = null;
			EGeneralContextType? type = context.Type;
			if (type == null)
			{
				return;
			}
			EGeneralContextType valueOrDefault = type.GetValueOrDefault();
			if (valueOrDefault != EGeneralContextType.Entity)
			{
				if (valueOrDefault != EGeneralContextType.Trigger)
				{
					return;
				}
				num2 = (context as TriggerContext).TriggerEntityId;
			}
			else
			{
				num2 = (context as EntityContext).EntityId;
			}
			if (num == null || num2 == null)
			{
				return;
			}
			this.StateId = num.Value;
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(num2.Value);
			this.PbDataId = CreatureModel.Instance.GetPbDataIdByEntity(entityById);
			base.CreateWaitEntityTask(this.PbDataId);
		}

		// Token: 0x0604403E RID: 278590 RVA: 0x010B5C77 File Offset: 0x010B3E77
		protected override void ExecuteWhenEntitiesReady()
		{
			LevelGeneralCommons.PrechangeStateTag(this.PbDataId, this.StateId, "LevelEventChangeSelfEntityState");
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0604403F RID: 278591 RVA: 0x010B5C98 File Offset: 0x010B3E98
		protected override void OnReset()
		{
			this.StateId = 0;
			this.PbDataId = 0;
		}

		// Token: 0x040238BB RID: 145595
		private int StateId;

		// Token: 0x040238BC RID: 145596
		private int PbDataId;
	}
}

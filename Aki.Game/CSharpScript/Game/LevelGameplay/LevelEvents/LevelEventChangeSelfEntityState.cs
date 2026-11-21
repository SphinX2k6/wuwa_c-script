using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C77 RID: 23671
	public class LevelEventChangeSelfEntityState : LevelEventBase
	{
		// Token: 0x0603A18E RID: 237966 RVA: 0x0105F441 File Offset: 0x0105D641
		public LevelEventChangeSelfEntityState(int id) : base(id)
		{
		}

		// Token: 0x0603A18F RID: 237967 RVA: 0x0105F44C File Offset: 0x0105D64C
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

		// Token: 0x0603A190 RID: 237968 RVA: 0x0105F513 File Offset: 0x0105D713
		protected override void ExecuteWhenEntitiesReady()
		{
			LevelGeneralCommons.PrechangeStateTag(this.PbDataId, this.StateId, "LevelEventChangeSelfEntityState");
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A191 RID: 237969 RVA: 0x0105F534 File Offset: 0x0105D734
		protected override void OnReset()
		{
			this.StateId = 0;
			this.PbDataId = 0;
		}

		// Token: 0x0401EB5D RID: 125789
		private int StateId;

		// Token: 0x0401EB5E RID: 125790
		private int PbDataId;
	}
}

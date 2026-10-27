using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B0A RID: 27402
	public class LevelEventCloseWalkingOverlayMontage : LevelEventBase
	{
		// Token: 0x06044078 RID: 278648 RVA: 0x010B8311 File Offset: 0x010B6511
		public LevelEventCloseWalkingOverlayMontage(int id) : base(id)
		{
		}

		// Token: 0x06044079 RID: 278649 RVA: 0x010B831C File Offset: 0x010B651C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			CloseWalkingOverlayMontage closeWalkingOverlayMontage = inParams as CloseWalkingOverlayMontage;
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(closeWalkingOverlayMontage.EntityId);
			if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			int infoId = PlayMontageUtils.Instance.EntityIsPlayingMontage(entityByPbDataId.Entity.Id);
			PlayMontageUtils.Instance.ClearAndEndMontage(infoId, true, null);
			base.FinishExecute(true, false, true);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C82 RID: 23682
	public class LevelEventCloseWalkingOverlayMontage : LevelEventBase
	{
		// Token: 0x0603A1CA RID: 238026 RVA: 0x01061B9D File Offset: 0x0105FD9D
		public LevelEventCloseWalkingOverlayMontage(int id) : base(id)
		{
		}

		// Token: 0x0603A1CB RID: 238027 RVA: 0x01061BA8 File Offset: 0x0105FDA8
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

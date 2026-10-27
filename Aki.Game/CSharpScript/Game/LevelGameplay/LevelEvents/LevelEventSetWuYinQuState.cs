using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B82 RID: 27522
	public class LevelEventSetWuYinQuState : LevelEventBase
	{
		// Token: 0x0604426E RID: 279150 RVA: 0x010CABE0 File Offset: 0x010C8DE0
		public LevelEventSetWuYinQuState(int id) : base(id)
		{
		}

		// Token: 0x0604426F RID: 279151 RVA: 0x010CABEC File Offset: 0x010C8DEC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetWuYinQuState setWuYinQuState = inParams as SetWuYinQuState;
			if (setWuYinQuState == null)
			{
				return;
			}
			RenderModuleController.Instance.SetBattleState(setWuYinQuState.WuYinQuName, (AkiClient.Game.Aki.Render.RuntimeBP.Battle.EWuYinQuState)setWuYinQuState.State, false);
		}
	}
}

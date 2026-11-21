using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFA RID: 23802
	public class LevelEventSetWuYinQuState : LevelEventBase
	{
		// Token: 0x0603A3C0 RID: 238528 RVA: 0x01074878 File Offset: 0x01072A78
		public LevelEventSetWuYinQuState(int id) : base(id)
		{
		}

		// Token: 0x0603A3C1 RID: 238529 RVA: 0x01074884 File Offset: 0x01072A84
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

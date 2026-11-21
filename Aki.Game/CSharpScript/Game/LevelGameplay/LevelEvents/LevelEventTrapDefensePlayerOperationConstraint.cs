using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D22 RID: 23842
	public class LevelEventTrapDefensePlayerOperationConstraint : LevelEventBase
	{
		// Token: 0x0603A463 RID: 238691 RVA: 0x010786F9 File Offset: 0x010768F9
		public LevelEventTrapDefensePlayerOperationConstraint(int id) : base(id)
		{
		}

		// Token: 0x0603A464 RID: 238692 RVA: 0x01078704 File Offset: 0x01076904
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TrapDefensePlayerOperationConstraint trapDefensePlayerOperationConstraint = inParams as TrapDefensePlayerOperationConstraint;
			if (trapDefensePlayerOperationConstraint == null)
			{
				return;
			}
			TrapDefenseBattleGuideManager.RegisterBehaviorTreeGuideData(trapDefensePlayerOperationConstraint);
			base.FinishExecute(true, false, true);
		}
	}
}

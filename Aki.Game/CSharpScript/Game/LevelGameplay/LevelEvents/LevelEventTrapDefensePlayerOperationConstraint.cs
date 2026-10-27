using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BAA RID: 27562
	public class LevelEventTrapDefensePlayerOperationConstraint : LevelEventBase
	{
		// Token: 0x0604430D RID: 279309 RVA: 0x010CE86D File Offset: 0x010CCA6D
		public LevelEventTrapDefensePlayerOperationConstraint(int id) : base(id)
		{
		}

		// Token: 0x0604430E RID: 279310 RVA: 0x010CE878 File Offset: 0x010CCA78
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

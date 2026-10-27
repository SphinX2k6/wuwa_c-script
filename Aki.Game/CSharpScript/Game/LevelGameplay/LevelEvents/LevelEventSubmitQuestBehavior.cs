using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B9E RID: 27550
	public class LevelEventSubmitQuestBehavior : LevelEventBase
	{
		// Token: 0x060442E7 RID: 279271 RVA: 0x010CDB78 File Offset: 0x010CBD78
		public LevelEventSubmitQuestBehavior(int id) : base(id)
		{
		}

		// Token: 0x060442E8 RID: 279272 RVA: 0x010CDB84 File Offset: 0x010CBD84
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionSubmitQuestBehavior actionSubmitQuestBehavior = inParams as ActionSubmitQuestBehavior;
			if (actionSubmitQuestBehavior == null || actionSubmitQuestBehavior.Callback == null)
			{
				return;
			}
			actionSubmitQuestBehavior.Callback();
		}
	}
}

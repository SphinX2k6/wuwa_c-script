using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D16 RID: 23830
	public class LevelEventSubmitQuestBehavior : LevelEventBase
	{
		// Token: 0x0603A43B RID: 238651 RVA: 0x010779B0 File Offset: 0x01075BB0
		public LevelEventSubmitQuestBehavior(int id) : base(id)
		{
		}

		// Token: 0x0603A43C RID: 238652 RVA: 0x010779BC File Offset: 0x01075BBC
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

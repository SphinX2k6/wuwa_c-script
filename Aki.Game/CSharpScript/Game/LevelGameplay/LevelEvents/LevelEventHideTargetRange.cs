using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CAA RID: 23722
	public class LevelEventHideTargetRange : LevelEventBase
	{
		// Token: 0x0603A279 RID: 238201 RVA: 0x0106682B File Offset: 0x01064A2B
		public LevelEventHideTargetRange(int id) : base(id)
		{
		}

		// Token: 0x0603A27A RID: 238202 RVA: 0x01066834 File Offset: 0x01064A34
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
			}
			if ((inParams as HideTargetRange).IsHideSimpleNpc.GetValueOrDefault())
			{
				SimpleNpcController.Instance.SetClearOutState(ESimpleNpcClearOutModuleDefine.Quest, true);
			}
			base.FinishExecute(true, false, true);
		}
	}
}

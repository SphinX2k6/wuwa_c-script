using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B32 RID: 27442
	public class LevelEventHideTargetRange : LevelEventBase
	{
		// Token: 0x06044127 RID: 278823 RVA: 0x010BCF9F File Offset: 0x010BB19F
		public LevelEventHideTargetRange(int id) : base(id)
		{
		}

		// Token: 0x06044128 RID: 278824 RVA: 0x010BCFA8 File Offset: 0x010BB1A8
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

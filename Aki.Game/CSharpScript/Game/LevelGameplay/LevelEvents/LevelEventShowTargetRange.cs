using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B84 RID: 27524
	public class LevelEventShowTargetRange : LevelEventBase
	{
		// Token: 0x06044272 RID: 279154 RVA: 0x010CAC7A File Offset: 0x010C8E7A
		public LevelEventShowTargetRange(int id) : base(id)
		{
		}

		// Token: 0x06044273 RID: 279155 RVA: 0x010CAC83 File Offset: 0x010C8E83
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SimpleNpcController.Instance.SetClearOutState(ESimpleNpcClearOutModuleDefine.Quest, false);
			base.FinishExecute(true, false, true);
		}
	}
}

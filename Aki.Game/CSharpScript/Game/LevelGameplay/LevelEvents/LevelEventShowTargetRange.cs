using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFC RID: 23804
	public class LevelEventShowTargetRange : LevelEventBase
	{
		// Token: 0x0603A3C4 RID: 238532 RVA: 0x01074912 File Offset: 0x01072B12
		public LevelEventShowTargetRange(int id) : base(id)
		{
		}

		// Token: 0x0603A3C5 RID: 238533 RVA: 0x0107491B File Offset: 0x01072B1B
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

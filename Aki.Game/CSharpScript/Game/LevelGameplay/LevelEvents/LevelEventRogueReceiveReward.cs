using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B66 RID: 27494
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRogueReceiveReward : LevelEventBase
	{
		// Token: 0x060441FE RID: 279038 RVA: 0x010C5243 File Offset: 0x010C3443
		public LevelEventRogueReceiveReward(int id) : base(id)
		{
		}

		// Token: 0x060441FF RID: 279039 RVA: 0x010C524C File Offset: 0x010C344C
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044200 RID: 279040 RVA: 0x010C5257 File Offset: 0x010C3457
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}

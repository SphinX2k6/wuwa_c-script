using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B5E RID: 27486
	public class LevelEventReignsSetPropertyVisible : LevelEventBase
	{
		// Token: 0x060441E7 RID: 279015 RVA: 0x010C4998 File Offset: 0x010C2B98
		public LevelEventReignsSetPropertyVisible(int id) : base(id)
		{
		}

		// Token: 0x060441E8 RID: 279016 RVA: 0x010C49A1 File Offset: 0x010C2BA1
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}

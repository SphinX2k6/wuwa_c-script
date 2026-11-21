using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD6 RID: 23766
	public class LevelEventReignsSetPropertyVisible : LevelEventBase
	{
		// Token: 0x0603A339 RID: 238393 RVA: 0x0106E568 File Offset: 0x0106C768
		public LevelEventReignsSetPropertyVisible(int id) : base(id)
		{
		}

		// Token: 0x0603A33A RID: 238394 RVA: 0x0106E571 File Offset: 0x0106C771
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}

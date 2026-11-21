using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.DemoInteract
{
	// Token: 0x02005DAF RID: 23983
	public class LevelEventSetDemoActorVar : LevelEventBase
	{
		// Token: 0x0603A618 RID: 239128 RVA: 0x0107D6C1 File Offset: 0x0107B8C1
		public LevelEventSetDemoActorVar(int id) : base(id)
		{
		}

		// Token: 0x0603A619 RID: 239129 RVA: 0x0107D6CC File Offset: 0x0107B8CC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}

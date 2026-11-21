using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.DemoInteract
{
	// Token: 0x02005DAE RID: 23982
	public class LevelEventRunDemoActorCustomEvent : LevelEventBase
	{
		// Token: 0x0603A616 RID: 239126 RVA: 0x0107D6A8 File Offset: 0x0107B8A8
		public LevelEventRunDemoActorCustomEvent(int id) : base(id)
		{
		}

		// Token: 0x0603A617 RID: 239127 RVA: 0x0107D6B4 File Offset: 0x0107B8B4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}
	}
}

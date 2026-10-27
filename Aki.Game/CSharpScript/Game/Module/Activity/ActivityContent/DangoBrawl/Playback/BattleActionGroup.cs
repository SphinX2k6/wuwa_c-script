using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006862 RID: 26722
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleActionGroup : IBattleActionGroup
	{
		// Token: 0x17009786 RID: 38790
		// (get) Token: 0x06042B9A RID: 273306 RVA: 0x0103AB96 File Offset: 0x01038D96
		// (set) Token: 0x06042B9B RID: 273307 RVA: 0x0103AB9E File Offset: 0x01038D9E
		public int GroupUid { get; set; }

		// Token: 0x17009787 RID: 38791
		// (get) Token: 0x06042B9C RID: 273308 RVA: 0x0103ABA7 File Offset: 0x01038DA7
		// (set) Token: 0x06042B9D RID: 273309 RVA: 0x0103ABAF File Offset: 0x01038DAF
		public int TriggerMs { get; set; }

		// Token: 0x17009788 RID: 38792
		// (get) Token: 0x06042B9E RID: 273310 RVA: 0x0103ABB8 File Offset: 0x01038DB8
		// (set) Token: 0x06042B9F RID: 273311 RVA: 0x0103ABC0 File Offset: 0x01038DC0
		public List<IDangoBrawlBattleAction> Actions { get; set; }
	}
}

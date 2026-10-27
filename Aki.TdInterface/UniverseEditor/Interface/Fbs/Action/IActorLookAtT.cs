using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D2 RID: 24786
	public class IActorLookAtT
	{
		// Token: 0x1700B6A8 RID: 46760
		// (get) Token: 0x0602A550 RID: 173392 RVA: 0x005D5C4D File Offset: 0x005D3E4D
		// (set) Token: 0x0602A551 RID: 173393 RVA: 0x005D5C55 File Offset: 0x005D3E55
		public int ActorIndex { get; set; }

		// Token: 0x1700B6A9 RID: 46761
		// (get) Token: 0x0602A552 RID: 173394 RVA: 0x005D5C5E File Offset: 0x005D3E5E
		// (set) Token: 0x0602A553 RID: 173395 RVA: 0x005D5C66 File Offset: 0x005D3E66
		public TActorLookAtDataUnion Target { get; set; }

		// Token: 0x1700B6AA RID: 46762
		// (get) Token: 0x0602A554 RID: 173396 RVA: 0x005D5C6F File Offset: 0x005D3E6F
		// (set) Token: 0x0602A555 RID: 173397 RVA: 0x005D5C77 File Offset: 0x005D3E77
		public float DelayTime { get; set; }

		// Token: 0x1700B6AB RID: 46763
		// (get) Token: 0x0602A556 RID: 173398 RVA: 0x005D5C80 File Offset: 0x005D3E80
		// (set) Token: 0x0602A557 RID: 173399 RVA: 0x005D5C88 File Offset: 0x005D3E88
		public float LookAtSpeedRate { get; set; }

		// Token: 0x1700B6AC RID: 46764
		// (get) Token: 0x0602A558 RID: 173400 RVA: 0x005D5C91 File Offset: 0x005D3E91
		// (set) Token: 0x0602A559 RID: 173401 RVA: 0x005D5C99 File Offset: 0x005D3E99
		public byte NullMask { get; set; }

		// Token: 0x0602A55A RID: 173402 RVA: 0x005D5CA2 File Offset: 0x005D3EA2
		public IActorLookAtT()
		{
			this.ActorIndex = 0;
			this.Target = null;
			this.DelayTime = 0f;
			this.LookAtSpeedRate = 0f;
			this.NullMask = 0;
		}
	}
}

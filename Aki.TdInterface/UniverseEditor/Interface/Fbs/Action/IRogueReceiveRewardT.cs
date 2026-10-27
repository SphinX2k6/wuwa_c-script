using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE9 RID: 28393
	public class IRogueReceiveRewardT
	{
		// Token: 0x1700D33F RID: 54079
		// (get) Token: 0x060322D5 RID: 205525 RVA: 0x006C8004 File Offset: 0x006C6204
		// (set) Token: 0x060322D6 RID: 205526 RVA: 0x006C800C File Offset: 0x006C620C
		public ERogueRewardReceiveType RogueRewardReceiveType { get; set; }

		// Token: 0x1700D340 RID: 54080
		// (get) Token: 0x060322D7 RID: 205527 RVA: 0x006C8015 File Offset: 0x006C6215
		// (set) Token: 0x060322D8 RID: 205528 RVA: 0x006C801D File Offset: 0x006C621D
		public byte NullMask { get; set; }

		// Token: 0x060322D9 RID: 205529 RVA: 0x006C8026 File Offset: 0x006C6226
		public IRogueReceiveRewardT()
		{
			this.RogueRewardReceiveType = ERogueRewardReceiveType.ReceiveByCount;
			this.NullMask = 0;
		}
	}
}

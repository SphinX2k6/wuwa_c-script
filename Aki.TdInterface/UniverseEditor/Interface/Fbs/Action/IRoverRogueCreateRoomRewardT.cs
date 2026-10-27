using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0A RID: 28426
	public class IRoverRogueCreateRoomRewardT
	{
		// Token: 0x1700D35E RID: 54110
		// (get) Token: 0x06032398 RID: 205720 RVA: 0x006C9252 File Offset: 0x006C7452
		// (set) Token: 0x06032399 RID: 205721 RVA: 0x006C925A File Offset: 0x006C745A
		public int RewardType { get; set; }

		// Token: 0x0603239A RID: 205722 RVA: 0x006C9263 File Offset: 0x006C7463
		public IRoverRogueCreateRoomRewardT()
		{
			this.RewardType = 0;
		}
	}
}

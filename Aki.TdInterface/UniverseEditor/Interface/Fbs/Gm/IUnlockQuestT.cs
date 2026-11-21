using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B3B RID: 19259
	public class IUnlockQuestT
	{
		// Token: 0x17008713 RID: 34579
		// (get) Token: 0x0601D0F0 RID: 119024 RVA: 0x00415490 File Offset: 0x00413690
		// (set) Token: 0x0601D0F1 RID: 119025 RVA: 0x00415498 File Offset: 0x00413698
		public EGmCommand Type { get; set; }

		// Token: 0x17008714 RID: 34580
		// (get) Token: 0x0601D0F2 RID: 119026 RVA: 0x004154A1 File Offset: 0x004136A1
		// (set) Token: 0x0601D0F3 RID: 119027 RVA: 0x004154A9 File Offset: 0x004136A9
		public int QuestId { get; set; }

		// Token: 0x0601D0F4 RID: 119028 RVA: 0x004154B2 File Offset: 0x004136B2
		public IUnlockQuestT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.QuestId = 0;
		}
	}
}

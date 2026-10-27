using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DAA RID: 15786
	public class ICompleteMessageQuestConditionT
	{
		// Token: 0x17006C9D RID: 27805
		// (get) Token: 0x06015F3A RID: 89914 RVA: 0x0032B872 File Offset: 0x00329A72
		// (set) Token: 0x06015F3B RID: 89915 RVA: 0x0032B87A File Offset: 0x00329A7A
		public EPhoneMessageProgressType Type { get; set; }

		// Token: 0x06015F3C RID: 89916 RVA: 0x0032B883 File Offset: 0x00329A83
		public ICompleteMessageQuestConditionT()
		{
			this.Type = EPhoneMessageProgressType.CompleteMessage;
		}
	}
}

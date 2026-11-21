using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B2 RID: 17586
	public class IReadPhoneMessageQuestConditionT
	{
		// Token: 0x17007A6A RID: 31338
		// (get) Token: 0x06019648 RID: 104008 RVA: 0x0039FDF9 File Offset: 0x0039DFF9
		// (set) Token: 0x06019649 RID: 104009 RVA: 0x0039FE01 File Offset: 0x0039E001
		public EChildQuest Type { get; set; }

		// Token: 0x17007A6B RID: 31339
		// (get) Token: 0x0601964A RID: 104010 RVA: 0x0039FE0A File Offset: 0x0039E00A
		// (set) Token: 0x0601964B RID: 104011 RVA: 0x0039FE12 File Offset: 0x0039E012
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007A6C RID: 31340
		// (get) Token: 0x0601964C RID: 104012 RVA: 0x0039FE1B File Offset: 0x0039E01B
		// (set) Token: 0x0601964D RID: 104013 RVA: 0x0039FE23 File Offset: 0x0039E023
		public int PhoneMessageId { get; set; }

		// Token: 0x17007A6D RID: 31341
		// (get) Token: 0x0601964E RID: 104014 RVA: 0x0039FE2C File Offset: 0x0039E02C
		// (set) Token: 0x0601964F RID: 104015 RVA: 0x0039FE34 File Offset: 0x0039E034
		public ICompleteMessageQuestConditionT ProgressType { get; set; }

		// Token: 0x17007A6E RID: 31342
		// (get) Token: 0x06019650 RID: 104016 RVA: 0x0039FE3D File Offset: 0x0039E03D
		// (set) Token: 0x06019651 RID: 104017 RVA: 0x0039FE45 File Offset: 0x0039E045
		public byte NullMask { get; set; }

		// Token: 0x06019652 RID: 104018 RVA: 0x0039FE4E File Offset: 0x0039E04E
		public IReadPhoneMessageQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.PhoneMessageId = 0;
			this.ProgressType = null;
			this.NullMask = 0;
		}
	}
}

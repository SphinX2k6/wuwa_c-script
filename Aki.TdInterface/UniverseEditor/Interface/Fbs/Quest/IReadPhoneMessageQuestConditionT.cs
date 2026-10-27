using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004071 RID: 16497
	public class IReadPhoneMessageQuestConditionT
	{
		// Token: 0x17007468 RID: 29800
		// (get) Token: 0x06017FAF RID: 98223 RVA: 0x00375FC1 File Offset: 0x003741C1
		// (set) Token: 0x06017FB0 RID: 98224 RVA: 0x00375FC9 File Offset: 0x003741C9
		public EChildQuest Type { get; set; }

		// Token: 0x17007469 RID: 29801
		// (get) Token: 0x06017FB1 RID: 98225 RVA: 0x00375FD2 File Offset: 0x003741D2
		// (set) Token: 0x06017FB2 RID: 98226 RVA: 0x00375FDA File Offset: 0x003741DA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700746A RID: 29802
		// (get) Token: 0x06017FB3 RID: 98227 RVA: 0x00375FE3 File Offset: 0x003741E3
		// (set) Token: 0x06017FB4 RID: 98228 RVA: 0x00375FEB File Offset: 0x003741EB
		public int PhoneMessageId { get; set; }

		// Token: 0x1700746B RID: 29803
		// (get) Token: 0x06017FB5 RID: 98229 RVA: 0x00375FF4 File Offset: 0x003741F4
		// (set) Token: 0x06017FB6 RID: 98230 RVA: 0x00375FFC File Offset: 0x003741FC
		public ICompleteMessageQuestConditionT ProgressType { get; set; }

		// Token: 0x1700746C RID: 29804
		// (get) Token: 0x06017FB7 RID: 98231 RVA: 0x00376005 File Offset: 0x00374205
		// (set) Token: 0x06017FB8 RID: 98232 RVA: 0x0037600D File Offset: 0x0037420D
		public byte NullMask { get; set; }

		// Token: 0x06017FB9 RID: 98233 RVA: 0x00376016 File Offset: 0x00374216
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

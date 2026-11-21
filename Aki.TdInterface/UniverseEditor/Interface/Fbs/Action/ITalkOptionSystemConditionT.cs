using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B2B RID: 31531
	public class ITalkOptionSystemConditionT
	{
		// Token: 0x1700EC2A RID: 60458
		// (get) Token: 0x06038C73 RID: 232563 RVA: 0x007ADA77 File Offset: 0x007ABC77
		// (set) Token: 0x06038C74 RID: 232564 RVA: 0x007ADA7F File Offset: 0x007ABC7F
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700EC2B RID: 60459
		// (get) Token: 0x06038C75 RID: 232565 RVA: 0x007ADA88 File Offset: 0x007ABC88
		// (set) Token: 0x06038C76 RID: 232566 RVA: 0x007ADA90 File Offset: 0x007ABC90
		public ITalkOptionConditionSolarSchoolT System { get; set; }

		// Token: 0x1700EC2C RID: 60460
		// (get) Token: 0x06038C77 RID: 232567 RVA: 0x007ADA99 File Offset: 0x007ABC99
		// (set) Token: 0x06038C78 RID: 232568 RVA: 0x007ADAA1 File Offset: 0x007ABCA1
		public bool HideWhenUnmet { get; set; }

		// Token: 0x1700EC2D RID: 60461
		// (get) Token: 0x06038C79 RID: 232569 RVA: 0x007ADAAA File Offset: 0x007ABCAA
		// (set) Token: 0x06038C7A RID: 232570 RVA: 0x007ADAB2 File Offset: 0x007ABCB2
		public bool HideConditionTextWhenUnmet { get; set; }

		// Token: 0x1700EC2E RID: 60462
		// (get) Token: 0x06038C7B RID: 232571 RVA: 0x007ADABB File Offset: 0x007ABCBB
		// (set) Token: 0x06038C7C RID: 232572 RVA: 0x007ADAC3 File Offset: 0x007ABCC3
		public string TidReplaceTextWhenUnmet { get; set; }

		// Token: 0x1700EC2F RID: 60463
		// (get) Token: 0x06038C7D RID: 232573 RVA: 0x007ADACC File Offset: 0x007ABCCC
		// (set) Token: 0x06038C7E RID: 232574 RVA: 0x007ADAD4 File Offset: 0x007ABCD4
		public byte NullMask { get; set; }

		// Token: 0x06038C7F RID: 232575 RVA: 0x007ADADD File Offset: 0x007ABCDD
		public ITalkOptionSystemConditionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.System = null;
			this.HideWhenUnmet = false;
			this.HideConditionTextWhenUnmet = false;
			this.TidReplaceTextWhenUnmet = null;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B07 RID: 31495
	public class ITalkOptionFirstSelectT
	{
		// Token: 0x1700EBF9 RID: 60409
		// (get) Token: 0x06038B6D RID: 232301 RVA: 0x007AC0F2 File Offset: 0x007AA2F2
		// (set) Token: 0x06038B6E RID: 232302 RVA: 0x007AC0FA File Offset: 0x007AA2FA
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x06038B6F RID: 232303 RVA: 0x007AC103 File Offset: 0x007AA303
		public ITalkOptionFirstSelectT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
		}
	}
}

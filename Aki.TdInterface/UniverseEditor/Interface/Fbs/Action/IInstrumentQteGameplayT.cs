using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006979 RID: 27001
	public class IInstrumentQteGameplayT
	{
		// Token: 0x1700C842 RID: 51266
		// (get) Token: 0x0602F278 RID: 193144 RVA: 0x0066C8A2 File Offset: 0x0066AAA2
		// (set) Token: 0x0602F279 RID: 193145 RVA: 0x0066C8AA File Offset: 0x0066AAAA
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C843 RID: 51267
		// (get) Token: 0x0602F27A RID: 193146 RVA: 0x0066C8B3 File Offset: 0x0066AAB3
		// (set) Token: 0x0602F27B RID: 193147 RVA: 0x0066C8BB File Offset: 0x0066AABB
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700C844 RID: 51268
		// (get) Token: 0x0602F27C RID: 193148 RVA: 0x0066C8C4 File Offset: 0x0066AAC4
		// (set) Token: 0x0602F27D RID: 193149 RVA: 0x0066C8CC File Offset: 0x0066AACC
		public int Id { get; set; }

		// Token: 0x0602F27E RID: 193150 RVA: 0x0066C8D5 File Offset: 0x0066AAD5
		public IInstrumentQteGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.InstrumentType = EInstrumentType.ChineseZither;
			this.Id = 0;
		}
	}
}

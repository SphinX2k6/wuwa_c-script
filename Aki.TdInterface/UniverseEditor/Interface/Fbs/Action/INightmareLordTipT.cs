using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F3 RID: 29427
	public class INightmareLordTipT
	{
		// Token: 0x1700D7BF RID: 55231
		// (get) Token: 0x060334F7 RID: 210167 RVA: 0x006EBA48 File Offset: 0x006E9C48
		// (set) Token: 0x060334F8 RID: 210168 RVA: 0x006EBA50 File Offset: 0x006E9C50
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D7C0 RID: 55232
		// (get) Token: 0x060334F9 RID: 210169 RVA: 0x006EBA59 File Offset: 0x006E9C59
		// (set) Token: 0x060334FA RID: 210170 RVA: 0x006EBA61 File Offset: 0x006E9C61
		public string TidMainText { get; set; }

		// Token: 0x1700D7C1 RID: 55233
		// (get) Token: 0x060334FB RID: 210171 RVA: 0x006EBA6A File Offset: 0x006E9C6A
		// (set) Token: 0x060334FC RID: 210172 RVA: 0x006EBA72 File Offset: 0x006E9C72
		public string TidSubText { get; set; }

		// Token: 0x060334FD RID: 210173 RVA: 0x006EBA7B File Offset: 0x006E9C7B
		public INightmareLordTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}

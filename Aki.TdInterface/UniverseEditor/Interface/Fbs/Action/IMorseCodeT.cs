using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0A RID: 27402
	public class IMorseCodeT
	{
		// Token: 0x1700CB79 RID: 52089
		// (get) Token: 0x0603010A RID: 196874 RVA: 0x00688BFF File Offset: 0x00686DFF
		// (set) Token: 0x0603010B RID: 196875 RVA: 0x00688C07 File Offset: 0x00686E07
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CB7A RID: 52090
		// (get) Token: 0x0603010C RID: 196876 RVA: 0x00688C10 File Offset: 0x00686E10
		// (set) Token: 0x0603010D RID: 196877 RVA: 0x00688C18 File Offset: 0x00686E18
		public string MorseCodeId { get; set; }

		// Token: 0x0603010E RID: 196878 RVA: 0x00688C21 File Offset: 0x00686E21
		public IMorseCodeT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.MorseCodeId = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006416 RID: 25622
	public class ICloseBrokenRockT
	{
		// Token: 0x1700BEC8 RID: 48840
		// (get) Token: 0x0602C55B RID: 181595 RVA: 0x006159FA File Offset: 0x00613BFA
		// (set) Token: 0x0602C55C RID: 181596 RVA: 0x00615A02 File Offset: 0x00613C02
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602C55D RID: 181597 RVA: 0x00615A0B File Offset: 0x00613C0B
		public ICloseBrokenRockT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}

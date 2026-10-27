using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710A RID: 28938
	public class ISignalBreakGameplayT
	{
		// Token: 0x1700D71D RID: 55069
		// (get) Token: 0x060334D7 RID: 210135 RVA: 0x006EA8CB File Offset: 0x006E8ACB
		// (set) Token: 0x060334D8 RID: 210136 RVA: 0x006EA8D3 File Offset: 0x006E8AD3
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D71E RID: 55070
		// (get) Token: 0x060334D9 RID: 210137 RVA: 0x006EA8DC File Offset: 0x006E8ADC
		// (set) Token: 0x060334DA RID: 210138 RVA: 0x006EA8E4 File Offset: 0x006E8AE4
		public string SignalBreakId { get; set; }

		// Token: 0x060334DB RID: 210139 RVA: 0x006EA8ED File Offset: 0x006E8AED
		public ISignalBreakGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SignalBreakId = null;
		}
	}
}

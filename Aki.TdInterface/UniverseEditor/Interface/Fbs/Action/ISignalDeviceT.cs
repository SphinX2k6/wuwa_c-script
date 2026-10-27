using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710D RID: 28941
	public class ISignalDeviceT
	{
		// Token: 0x1700D722 RID: 55074
		// (get) Token: 0x060334EF RID: 210159 RVA: 0x006EABB6 File Offset: 0x006E8DB6
		// (set) Token: 0x060334F0 RID: 210160 RVA: 0x006EABBE File Offset: 0x006E8DBE
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D723 RID: 55075
		// (get) Token: 0x060334F1 RID: 210161 RVA: 0x006EABC7 File Offset: 0x006E8DC7
		// (set) Token: 0x060334F2 RID: 210162 RVA: 0x006EABCF File Offset: 0x006E8DCF
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x060334F3 RID: 210163 RVA: 0x006EABD8 File Offset: 0x006E8DD8
		public ISignalDeviceT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Config = null;
		}
	}
}

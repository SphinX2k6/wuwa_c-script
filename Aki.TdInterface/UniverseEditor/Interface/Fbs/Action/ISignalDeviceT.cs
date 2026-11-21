using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D9 RID: 30937
	public class ISignalDeviceT
	{
		// Token: 0x1700E305 RID: 58117
		// (get) Token: 0x06036791 RID: 223121 RVA: 0x0074B1C2 File Offset: 0x007493C2
		// (set) Token: 0x06036792 RID: 223122 RVA: 0x0074B1CA File Offset: 0x007493CA
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E306 RID: 58118
		// (get) Token: 0x06036793 RID: 223123 RVA: 0x0074B1D3 File Offset: 0x007493D3
		// (set) Token: 0x06036794 RID: 223124 RVA: 0x0074B1DB File Offset: 0x007493DB
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x06036795 RID: 223125 RVA: 0x0074B1E4 File Offset: 0x007493E4
		public ISignalDeviceT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Config = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1D RID: 28189
	public class IReignsT
	{
		// Token: 0x1700D220 RID: 53792
		// (get) Token: 0x06031CF9 RID: 204025 RVA: 0x006BE5B0 File Offset: 0x006BC7B0
		// (set) Token: 0x06031CFA RID: 204026 RVA: 0x006BE5B8 File Offset: 0x006BC7B8
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D221 RID: 53793
		// (get) Token: 0x06031CFB RID: 204027 RVA: 0x006BE5C1 File Offset: 0x006BC7C1
		// (set) Token: 0x06031CFC RID: 204028 RVA: 0x006BE5C9 File Offset: 0x006BC7C9
		public int ReignsId { get; set; }

		// Token: 0x06031CFD RID: 204029 RVA: 0x006BE5D2 File Offset: 0x006BC7D2
		public IReignsT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ReignsId = 0;
		}
	}
}

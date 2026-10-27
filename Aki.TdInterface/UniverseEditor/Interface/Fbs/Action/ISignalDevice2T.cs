using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007110 RID: 28944
	public class ISignalDevice2T
	{
		// Token: 0x1700D727 RID: 55079
		// (get) Token: 0x06033507 RID: 210183 RVA: 0x006EAEA2 File Offset: 0x006E90A2
		// (set) Token: 0x06033508 RID: 210184 RVA: 0x006EAEAA File Offset: 0x006E90AA
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D728 RID: 55080
		// (get) Token: 0x06033509 RID: 210185 RVA: 0x006EAEB3 File Offset: 0x006E90B3
		// (set) Token: 0x0603350A RID: 210186 RVA: 0x006EAEBB File Offset: 0x006E90BB
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x0603350B RID: 210187 RVA: 0x006EAEC4 File Offset: 0x006E90C4
		public ISignalDevice2T()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Config = null;
		}
	}
}

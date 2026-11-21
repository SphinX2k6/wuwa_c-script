using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078DC RID: 30940
	public class ISignalDevice2T
	{
		// Token: 0x1700E30A RID: 58122
		// (get) Token: 0x060367A9 RID: 223145 RVA: 0x0074B4AE File Offset: 0x007496AE
		// (set) Token: 0x060367AA RID: 223146 RVA: 0x0074B4B6 File Offset: 0x007496B6
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E30B RID: 58123
		// (get) Token: 0x060367AB RID: 223147 RVA: 0x0074B4BF File Offset: 0x007496BF
		// (set) Token: 0x060367AC RID: 223148 RVA: 0x0074B4C7 File Offset: 0x007496C7
		public List<IColorPieceT> Config { get; set; }

		// Token: 0x060367AD RID: 223149 RVA: 0x0074B4D0 File Offset: 0x007496D0
		public ISignalDevice2T()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Config = null;
		}
	}
}

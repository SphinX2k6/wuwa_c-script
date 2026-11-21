using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005362 RID: 21346
	public class IActiveRenjuPieceT
	{
		// Token: 0x170096B6 RID: 38582
		// (get) Token: 0x060213DD RID: 136157 RVA: 0x0049681A File Offset: 0x00494A1A
		// (set) Token: 0x060213DE RID: 136158 RVA: 0x00496822 File Offset: 0x00494A22
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x170096B7 RID: 38583
		// (get) Token: 0x060213DF RID: 136159 RVA: 0x0049682B File Offset: 0x00494A2B
		// (set) Token: 0x060213E0 RID: 136160 RVA: 0x00496833 File Offset: 0x00494A33
		public List<IRenjuConfigT> RenjuConfig { get; set; }

		// Token: 0x170096B8 RID: 38584
		// (get) Token: 0x060213E1 RID: 136161 RVA: 0x0049683C File Offset: 0x00494A3C
		// (set) Token: 0x060213E2 RID: 136162 RVA: 0x00496844 File Offset: 0x00494A44
		public List<IJigsawItemMatchedConfigT> ExitMatchedConfig { get; set; }

		// Token: 0x170096B9 RID: 38585
		// (get) Token: 0x060213E3 RID: 136163 RVA: 0x0049684D File Offset: 0x00494A4D
		// (set) Token: 0x060213E4 RID: 136164 RVA: 0x00496855 File Offset: 0x00494A55
		public byte NullMask { get; set; }

		// Token: 0x060213E5 RID: 136165 RVA: 0x0049685E File Offset: 0x00494A5E
		public IActiveRenjuPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.RenjuConfig = null;
			this.ExitMatchedConfig = null;
			this.NullMask = 0;
		}
	}
}

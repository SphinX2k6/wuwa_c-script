using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4B RID: 20043
	public class IActivateSpecifiedPieceT
	{
		// Token: 0x17008F71 RID: 36721
		// (get) Token: 0x0601F754 RID: 128852 RVA: 0x00461F3B File Offset: 0x0046013B
		// (set) Token: 0x0601F755 RID: 128853 RVA: 0x00461F43 File Offset: 0x00460143
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x17008F72 RID: 36722
		// (get) Token: 0x0601F756 RID: 128854 RVA: 0x00461F4C File Offset: 0x0046014C
		// (set) Token: 0x0601F757 RID: 128855 RVA: 0x00461F54 File Offset: 0x00460154
		public List<IActivateSpecifiedPieceConfigT> Config { get; set; }

		// Token: 0x0601F758 RID: 128856 RVA: 0x00461F5D File Offset: 0x0046015D
		public IActivateSpecifiedPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.Config = null;
		}
	}
}

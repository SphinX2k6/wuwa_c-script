using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BB RID: 22459
	public class IPutInTheSpecifiedPieceT
	{
		// Token: 0x1700A7A3 RID: 42915
		// (get) Token: 0x06025B1C RID: 154396 RVA: 0x00532EB3 File Offset: 0x005310B3
		// (set) Token: 0x06025B1D RID: 154397 RVA: 0x00532EBB File Offset: 0x005310BB
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x1700A7A4 RID: 42916
		// (get) Token: 0x06025B1E RID: 154398 RVA: 0x00532EC4 File Offset: 0x005310C4
		// (set) Token: 0x06025B1F RID: 154399 RVA: 0x00532ECC File Offset: 0x005310CC
		public List<IJigsawPieceMatchT> MatchList { get; set; }

		// Token: 0x06025B20 RID: 154400 RVA: 0x00532ED5 File Offset: 0x005310D5
		public IPutInTheSpecifiedPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.MatchList = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC2 RID: 24002
	public class IPutInTheSpecifiedPieceT
	{
		// Token: 0x1700B0C7 RID: 45255
		// (get) Token: 0x0602803C RID: 163900 RVA: 0x0057903F File Offset: 0x0057723F
		// (set) Token: 0x0602803D RID: 163901 RVA: 0x00579047 File Offset: 0x00577247
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x1700B0C8 RID: 45256
		// (get) Token: 0x0602803E RID: 163902 RVA: 0x00579050 File Offset: 0x00577250
		// (set) Token: 0x0602803F RID: 163903 RVA: 0x00579058 File Offset: 0x00577258
		public List<IJigsawPieceMatchT> MatchList { get; set; }

		// Token: 0x06028040 RID: 163904 RVA: 0x00579061 File Offset: 0x00577261
		public IPutInTheSpecifiedPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.MatchList = null;
		}
	}
}

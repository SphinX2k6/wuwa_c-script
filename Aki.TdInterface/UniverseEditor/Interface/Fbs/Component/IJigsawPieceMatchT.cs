using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A39 RID: 23097
	public class IJigsawPieceMatchT
	{
		// Token: 0x1700A7F5 RID: 42997
		// (get) Token: 0x06025C2E RID: 154670 RVA: 0x0052D45F File Offset: 0x0052B65F
		// (set) Token: 0x06025C2F RID: 154671 RVA: 0x0052D467 File Offset: 0x0052B667
		public int EntityId { get; set; }

		// Token: 0x1700A7F6 RID: 42998
		// (get) Token: 0x06025C30 RID: 154672 RVA: 0x0052D470 File Offset: 0x0052B670
		// (set) Token: 0x06025C31 RID: 154673 RVA: 0x0052D478 File Offset: 0x0052B678
		public IPieceIndexT Index { get; set; }

		// Token: 0x06025C32 RID: 154674 RVA: 0x0052D481 File Offset: 0x0052B681
		public IJigsawPieceMatchT()
		{
			this.EntityId = 0;
			this.Index = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007816 RID: 30742
	public class ISetPieceStateT
	{
		// Token: 0x1700E166 RID: 57702
		// (get) Token: 0x0603608A RID: 221322 RVA: 0x0073CF6D File Offset: 0x0073B16D
		// (set) Token: 0x0603608B RID: 221323 RVA: 0x0073CF75 File Offset: 0x0073B175
		public ESetJigsawFoundationType Type { get; set; }

		// Token: 0x1700E167 RID: 57703
		// (get) Token: 0x0603608C RID: 221324 RVA: 0x0073CF7E File Offset: 0x0073B17E
		// (set) Token: 0x0603608D RID: 221325 RVA: 0x0073CF86 File Offset: 0x0073B186
		public int EntityId { get; set; }

		// Token: 0x1700E168 RID: 57704
		// (get) Token: 0x0603608E RID: 221326 RVA: 0x0073CF8F File Offset: 0x0073B18F
		// (set) Token: 0x0603608F RID: 221327 RVA: 0x0073CF97 File Offset: 0x0073B197
		public List<IJigsawPieceT> PieceState { get; set; }

		// Token: 0x06036090 RID: 221328 RVA: 0x0073CFA0 File Offset: 0x0073B1A0
		public ISetPieceStateT()
		{
			this.Type = ESetJigsawFoundationType.SetPieceState;
			this.EntityId = 0;
			this.PieceState = null;
		}
	}
}

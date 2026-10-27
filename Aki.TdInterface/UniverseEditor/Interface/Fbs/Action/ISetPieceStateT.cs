using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704A RID: 28746
	public class ISetPieceStateT
	{
		// Token: 0x1700D585 RID: 54661
		// (get) Token: 0x06032DED RID: 208365 RVA: 0x006DCA45 File Offset: 0x006DAC45
		// (set) Token: 0x06032DEE RID: 208366 RVA: 0x006DCA4D File Offset: 0x006DAC4D
		public ESetJigsawFoundationType Type { get; set; }

		// Token: 0x1700D586 RID: 54662
		// (get) Token: 0x06032DEF RID: 208367 RVA: 0x006DCA56 File Offset: 0x006DAC56
		// (set) Token: 0x06032DF0 RID: 208368 RVA: 0x006DCA5E File Offset: 0x006DAC5E
		public int EntityId { get; set; }

		// Token: 0x1700D587 RID: 54663
		// (get) Token: 0x06032DF1 RID: 208369 RVA: 0x006DCA67 File Offset: 0x006DAC67
		// (set) Token: 0x06032DF2 RID: 208370 RVA: 0x006DCA6F File Offset: 0x006DAC6F
		public List<IJigsawPieceT> PieceState { get; set; }

		// Token: 0x06032DF3 RID: 208371 RVA: 0x006DCA78 File Offset: 0x006DAC78
		public ISetPieceStateT()
		{
			this.Type = ESetJigsawFoundationType.SetPieceState;
			this.EntityId = 0;
			this.PieceState = null;
		}
	}
}

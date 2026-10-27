using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F98 RID: 20376
	public class IChessmanPickInteractionT
	{
		// Token: 0x17009373 RID: 37747
		// (get) Token: 0x0602065D RID: 132701 RVA: 0x00481F76 File Offset: 0x00480176
		// (set) Token: 0x0602065E RID: 132702 RVA: 0x00481F7E File Offset: 0x0048017E
		public EPickInteraction Type { get; set; }

		// Token: 0x17009374 RID: 37748
		// (get) Token: 0x0602065F RID: 132703 RVA: 0x00481F87 File Offset: 0x00480187
		// (set) Token: 0x06020660 RID: 132704 RVA: 0x00481F8F File Offset: 0x0048018F
		public List<IActionInfoT> CheckedActions { get; set; }

		// Token: 0x17009375 RID: 37749
		// (get) Token: 0x06020661 RID: 132705 RVA: 0x00481F98 File Offset: 0x00480198
		// (set) Token: 0x06020662 RID: 132706 RVA: 0x00481FA0 File Offset: 0x004801A0
		public List<IActionInfoT> UncheckedActions { get; set; }

		// Token: 0x17009376 RID: 37750
		// (get) Token: 0x06020663 RID: 132707 RVA: 0x00481FA9 File Offset: 0x004801A9
		// (set) Token: 0x06020664 RID: 132708 RVA: 0x00481FB1 File Offset: 0x004801B1
		public int TargetChessboard { get; set; }

		// Token: 0x17009377 RID: 37751
		// (get) Token: 0x06020665 RID: 132709 RVA: 0x00481FBA File Offset: 0x004801BA
		// (set) Token: 0x06020666 RID: 132710 RVA: 0x00481FC2 File Offset: 0x004801C2
		public string AvailablePosEffect { get; set; }

		// Token: 0x17009378 RID: 37752
		// (get) Token: 0x06020667 RID: 132711 RVA: 0x00481FCB File Offset: 0x004801CB
		// (set) Token: 0x06020668 RID: 132712 RVA: 0x00481FD3 File Offset: 0x004801D3
		public byte NullMask { get; set; }

		// Token: 0x06020669 RID: 132713 RVA: 0x00481FDC File Offset: 0x004801DC
		public IChessmanPickInteractionT()
		{
			this.Type = EPickInteraction.ChessmanInteract;
			this.CheckedActions = null;
			this.UncheckedActions = null;
			this.TargetChessboard = 0;
			this.AvailablePosEffect = null;
			this.NullMask = 0;
		}
	}
}

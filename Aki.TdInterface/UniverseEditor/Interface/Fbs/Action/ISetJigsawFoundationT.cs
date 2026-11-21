using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D1 RID: 30673
	public class ISetJigsawFoundationT
	{
		// Token: 0x1700E0D9 RID: 57561
		// (get) Token: 0x06035E23 RID: 220707 RVA: 0x00738329 File Offset: 0x00736529
		// (set) Token: 0x06035E24 RID: 220708 RVA: 0x00738331 File Offset: 0x00736531
		public ISetPieceStateT Config { get; set; }

		// Token: 0x06035E25 RID: 220709 RVA: 0x0073833A File Offset: 0x0073653A
		public ISetJigsawFoundationT()
		{
			this.Config = null;
		}
	}
}

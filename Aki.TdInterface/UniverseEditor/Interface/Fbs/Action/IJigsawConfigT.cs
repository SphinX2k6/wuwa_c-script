using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707D RID: 28797
	public class IJigsawConfigT
	{
		// Token: 0x1700D2F9 RID: 54009
		// (get) Token: 0x06031F41 RID: 204609 RVA: 0x006C2E0F File Offset: 0x006C100F
		// (set) Token: 0x06031F42 RID: 204610 RVA: 0x006C2E17 File Offset: 0x006C1017
		public int Row { get; set; }

		// Token: 0x1700D2FA RID: 54010
		// (get) Token: 0x06031F43 RID: 204611 RVA: 0x006C2E20 File Offset: 0x006C1020
		// (set) Token: 0x06031F44 RID: 204612 RVA: 0x006C2E28 File Offset: 0x006C1028
		public int Column { get; set; }

		// Token: 0x1700D2FB RID: 54011
		// (get) Token: 0x06031F45 RID: 204613 RVA: 0x006C2E31 File Offset: 0x006C1031
		// (set) Token: 0x06031F46 RID: 204614 RVA: 0x006C2E39 File Offset: 0x006C1039
		public int Size { get; set; }

		// Token: 0x1700D2FC RID: 54012
		// (get) Token: 0x06031F47 RID: 204615 RVA: 0x006C2E42 File Offset: 0x006C1042
		// (set) Token: 0x06031F48 RID: 204616 RVA: 0x006C2E4A File Offset: 0x006C104A
		public EJigsawShape Shape { get; set; }

		// Token: 0x1700D2FD RID: 54013
		// (get) Token: 0x06031F49 RID: 204617 RVA: 0x006C2E53 File Offset: 0x006C1053
		// (set) Token: 0x06031F4A RID: 204618 RVA: 0x006C2E5B File Offset: 0x006C105B
		public List<IJigsawPieceT> Pieces { get; set; }

		// Token: 0x1700D2FE RID: 54014
		// (get) Token: 0x06031F4B RID: 204619 RVA: 0x006C2E64 File Offset: 0x006C1064
		// (set) Token: 0x06031F4C RID: 204620 RVA: 0x006C2E6C File Offset: 0x006C106C
		public byte NullMask { get; set; }

		// Token: 0x06031F4D RID: 204621 RVA: 0x006C2E75 File Offset: 0x006C1075
		public IJigsawConfigT()
		{
			this.Row = 0;
			this.Column = 0;
			this.Size = 0;
			this.Shape = EJigsawShape.Circle;
			this.Pieces = null;
			this.NullMask = 0;
		}
	}
}

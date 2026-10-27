using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CD RID: 27085
	public class IJigsawConfigT
	{
		// Token: 0x1700C8F9 RID: 51449
		// (get) Token: 0x0602F581 RID: 193921 RVA: 0x00672AB7 File Offset: 0x00670CB7
		// (set) Token: 0x0602F582 RID: 193922 RVA: 0x00672ABF File Offset: 0x00670CBF
		public int Row { get; set; }

		// Token: 0x1700C8FA RID: 51450
		// (get) Token: 0x0602F583 RID: 193923 RVA: 0x00672AC8 File Offset: 0x00670CC8
		// (set) Token: 0x0602F584 RID: 193924 RVA: 0x00672AD0 File Offset: 0x00670CD0
		public int Column { get; set; }

		// Token: 0x1700C8FB RID: 51451
		// (get) Token: 0x0602F585 RID: 193925 RVA: 0x00672AD9 File Offset: 0x00670CD9
		// (set) Token: 0x0602F586 RID: 193926 RVA: 0x00672AE1 File Offset: 0x00670CE1
		public int Size { get; set; }

		// Token: 0x1700C8FC RID: 51452
		// (get) Token: 0x0602F587 RID: 193927 RVA: 0x00672AEA File Offset: 0x00670CEA
		// (set) Token: 0x0602F588 RID: 193928 RVA: 0x00672AF2 File Offset: 0x00670CF2
		public EJigsawShape Shape { get; set; }

		// Token: 0x1700C8FD RID: 51453
		// (get) Token: 0x0602F589 RID: 193929 RVA: 0x00672AFB File Offset: 0x00670CFB
		// (set) Token: 0x0602F58A RID: 193930 RVA: 0x00672B03 File Offset: 0x00670D03
		public List<IJigsawPieceT> Pieces { get; set; }

		// Token: 0x1700C8FE RID: 51454
		// (get) Token: 0x0602F58B RID: 193931 RVA: 0x00672B0C File Offset: 0x00670D0C
		// (set) Token: 0x0602F58C RID: 193932 RVA: 0x00672B14 File Offset: 0x00670D14
		public byte NullMask { get; set; }

		// Token: 0x0602F58D RID: 193933 RVA: 0x00672B1D File Offset: 0x00670D1D
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

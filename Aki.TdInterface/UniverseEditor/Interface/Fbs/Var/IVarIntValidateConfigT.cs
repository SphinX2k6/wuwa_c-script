using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B0C RID: 15116
	public class IVarIntValidateConfigT
	{
		// Token: 0x170067B8 RID: 26552
		// (get) Token: 0x06014A1B RID: 84507 RVA: 0x00300FFD File Offset: 0x002FF1FD
		// (set) Token: 0x06014A1C RID: 84508 RVA: 0x00301005 File Offset: 0x002FF205
		public EVar Type { get; set; }

		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x06014A1D RID: 84509 RVA: 0x0030100E File Offset: 0x002FF20E
		// (set) Token: 0x06014A1E RID: 84510 RVA: 0x00301016 File Offset: 0x002FF216
		public List<int> ValidList { get; set; }

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x06014A1F RID: 84511 RVA: 0x0030101F File Offset: 0x002FF21F
		// (set) Token: 0x06014A20 RID: 84512 RVA: 0x00301027 File Offset: 0x002FF227
		public int MinValue { get; set; }

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x06014A21 RID: 84513 RVA: 0x00301030 File Offset: 0x002FF230
		// (set) Token: 0x06014A22 RID: 84514 RVA: 0x00301038 File Offset: 0x002FF238
		public int MaxValue { get; set; }

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x06014A23 RID: 84515 RVA: 0x00301041 File Offset: 0x002FF241
		// (set) Token: 0x06014A24 RID: 84516 RVA: 0x00301049 File Offset: 0x002FF249
		public byte NullMask { get; set; }

		// Token: 0x06014A25 RID: 84517 RVA: 0x00301052 File Offset: 0x002FF252
		public IVarIntValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.MinValue = 0;
			this.MaxValue = 0;
			this.NullMask = 0;
		}
	}
}

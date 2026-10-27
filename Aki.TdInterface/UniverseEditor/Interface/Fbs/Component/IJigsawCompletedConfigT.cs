using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A7 RID: 21671
	public class IJigsawCompletedConfigT
	{
		// Token: 0x17009F8E RID: 40846
		// (get) Token: 0x06023ABC RID: 146108 RVA: 0x004EE51E File Offset: 0x004EC71E
		// (set) Token: 0x06023ABD RID: 146109 RVA: 0x004EE526 File Offset: 0x004EC726
		public bool IsSilentPiece { get; set; }

		// Token: 0x17009F8F RID: 40847
		// (get) Token: 0x06023ABE RID: 146110 RVA: 0x004EE52F File Offset: 0x004EC72F
		// (set) Token: 0x06023ABF RID: 146111 RVA: 0x004EE537 File Offset: 0x004EC737
		public bool IsSilentFoundation { get; set; }

		// Token: 0x17009F90 RID: 40848
		// (get) Token: 0x06023AC0 RID: 146112 RVA: 0x004EE540 File Offset: 0x004EC740
		// (set) Token: 0x06023AC1 RID: 146113 RVA: 0x004EE548 File Offset: 0x004EC748
		public byte NullMask { get; set; }

		// Token: 0x06023AC2 RID: 146114 RVA: 0x004EE551 File Offset: 0x004EC751
		public IJigsawCompletedConfigT()
		{
			this.IsSilentPiece = false;
			this.IsSilentFoundation = false;
			this.NullMask = 0;
		}
	}
}

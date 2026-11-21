using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2D RID: 23085
	public class IJigsawCompletedConfigT
	{
		// Token: 0x1700A7C8 RID: 42952
		// (get) Token: 0x06025B74 RID: 154484 RVA: 0x0052B592 File Offset: 0x00529792
		// (set) Token: 0x06025B75 RID: 154485 RVA: 0x0052B59A File Offset: 0x0052979A
		public bool IsSilentPiece { get; set; }

		// Token: 0x1700A7C9 RID: 42953
		// (get) Token: 0x06025B76 RID: 154486 RVA: 0x0052B5A3 File Offset: 0x005297A3
		// (set) Token: 0x06025B77 RID: 154487 RVA: 0x0052B5AB File Offset: 0x005297AB
		public bool IsSilentFoundation { get; set; }

		// Token: 0x1700A7CA RID: 42954
		// (get) Token: 0x06025B78 RID: 154488 RVA: 0x0052B5B4 File Offset: 0x005297B4
		// (set) Token: 0x06025B79 RID: 154489 RVA: 0x0052B5BC File Offset: 0x005297BC
		public byte NullMask { get; set; }

		// Token: 0x06025B7A RID: 154490 RVA: 0x0052B5C5 File Offset: 0x005297C5
		public IJigsawCompletedConfigT()
		{
			this.IsSilentPiece = false;
			this.IsSilentFoundation = false;
			this.NullMask = 0;
		}
	}
}

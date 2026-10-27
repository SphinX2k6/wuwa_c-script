using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D3 RID: 27091
	public class IJigsawPieceT
	{
		// Token: 0x1700C909 RID: 51465
		// (get) Token: 0x0602F5C1 RID: 193985 RVA: 0x006731DB File Offset: 0x006713DB
		// (set) Token: 0x0602F5C2 RID: 193986 RVA: 0x006731E3 File Offset: 0x006713E3
		public IPieceIndexT Index { get; set; }

		// Token: 0x1700C90A RID: 51466
		// (get) Token: 0x0602F5C3 RID: 193987 RVA: 0x006731EC File Offset: 0x006713EC
		// (set) Token: 0x0602F5C4 RID: 193988 RVA: 0x006731F4 File Offset: 0x006713F4
		public bool Active { get; set; }

		// Token: 0x1700C90B RID: 51467
		// (get) Token: 0x0602F5C5 RID: 193989 RVA: 0x006731FD File Offset: 0x006713FD
		// (set) Token: 0x0602F5C6 RID: 193990 RVA: 0x00673205 File Offset: 0x00671405
		public bool IsCorrect { get; set; }

		// Token: 0x1700C90C RID: 51468
		// (get) Token: 0x0602F5C7 RID: 193991 RVA: 0x0067320E File Offset: 0x0067140E
		// (set) Token: 0x0602F5C8 RID: 193992 RVA: 0x00673216 File Offset: 0x00671416
		public EJigsawPieceState InitState { get; set; }

		// Token: 0x0602F5C9 RID: 193993 RVA: 0x0067321F File Offset: 0x0067141F
		public IJigsawPieceT()
		{
			this.Index = null;
			this.Active = false;
			this.IsCorrect = false;
			this.InitState = EJigsawPieceState.Disable;
		}
	}
}

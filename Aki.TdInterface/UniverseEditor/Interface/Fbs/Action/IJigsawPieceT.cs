using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007083 RID: 28803
	public class IJigsawPieceT
	{
		// Token: 0x1700D309 RID: 54025
		// (get) Token: 0x06031F81 RID: 204673 RVA: 0x006C3533 File Offset: 0x006C1733
		// (set) Token: 0x06031F82 RID: 204674 RVA: 0x006C353B File Offset: 0x006C173B
		public IPieceIndexT Index { get; set; }

		// Token: 0x1700D30A RID: 54026
		// (get) Token: 0x06031F83 RID: 204675 RVA: 0x006C3544 File Offset: 0x006C1744
		// (set) Token: 0x06031F84 RID: 204676 RVA: 0x006C354C File Offset: 0x006C174C
		public bool Active { get; set; }

		// Token: 0x1700D30B RID: 54027
		// (get) Token: 0x06031F85 RID: 204677 RVA: 0x006C3555 File Offset: 0x006C1755
		// (set) Token: 0x06031F86 RID: 204678 RVA: 0x006C355D File Offset: 0x006C175D
		public bool IsCorrect { get; set; }

		// Token: 0x1700D30C RID: 54028
		// (get) Token: 0x06031F87 RID: 204679 RVA: 0x006C3566 File Offset: 0x006C1766
		// (set) Token: 0x06031F88 RID: 204680 RVA: 0x006C356E File Offset: 0x006C176E
		public EJigsawPieceState InitState { get; set; }

		// Token: 0x06031F89 RID: 204681 RVA: 0x006C3577 File Offset: 0x006C1777
		public IJigsawPieceT()
		{
			this.Index = null;
			this.Active = false;
			this.IsCorrect = false;
			this.InitState = EJigsawPieceState.Disable;
		}
	}
}

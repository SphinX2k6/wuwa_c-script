using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704D RID: 28749
	public class ISetPlayerMoveControlT
	{
		// Token: 0x1700D58D RID: 54669
		// (get) Token: 0x06032E09 RID: 208393 RVA: 0x006DCD50 File Offset: 0x006DAF50
		// (set) Token: 0x06032E0A RID: 208394 RVA: 0x006DCD58 File Offset: 0x006DAF58
		public int Left { get; set; }

		// Token: 0x1700D58E RID: 54670
		// (get) Token: 0x06032E0B RID: 208395 RVA: 0x006DCD61 File Offset: 0x006DAF61
		// (set) Token: 0x06032E0C RID: 208396 RVA: 0x006DCD69 File Offset: 0x006DAF69
		public int Right { get; set; }

		// Token: 0x1700D58F RID: 54671
		// (get) Token: 0x06032E0D RID: 208397 RVA: 0x006DCD72 File Offset: 0x006DAF72
		// (set) Token: 0x06032E0E RID: 208398 RVA: 0x006DCD7A File Offset: 0x006DAF7A
		public int Forward { get; set; }

		// Token: 0x1700D590 RID: 54672
		// (get) Token: 0x06032E0F RID: 208399 RVA: 0x006DCD83 File Offset: 0x006DAF83
		// (set) Token: 0x06032E10 RID: 208400 RVA: 0x006DCD8B File Offset: 0x006DAF8B
		public int Back { get; set; }

		// Token: 0x06032E11 RID: 208401 RVA: 0x006DCD94 File Offset: 0x006DAF94
		public ISetPlayerMoveControlT()
		{
			this.Left = 0;
			this.Right = 0;
			this.Forward = 0;
			this.Back = 0;
		}
	}
}

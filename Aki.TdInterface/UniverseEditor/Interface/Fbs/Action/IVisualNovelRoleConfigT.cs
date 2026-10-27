using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D5 RID: 30165
	public class IVisualNovelRoleConfigT
	{
		// Token: 0x1700E52E RID: 58670
		// (get) Token: 0x06036F36 RID: 225078 RVA: 0x00775396 File Offset: 0x00773596
		// (set) Token: 0x06036F37 RID: 225079 RVA: 0x0077539E File Offset: 0x0077359E
		public int Expression { get; set; }

		// Token: 0x1700E52F RID: 58671
		// (get) Token: 0x06036F38 RID: 225080 RVA: 0x007753A7 File Offset: 0x007735A7
		// (set) Token: 0x06036F39 RID: 225081 RVA: 0x007753AF File Offset: 0x007735AF
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700E530 RID: 58672
		// (get) Token: 0x06036F3A RID: 225082 RVA: 0x007753B8 File Offset: 0x007735B8
		// (set) Token: 0x06036F3B RID: 225083 RVA: 0x007753C0 File Offset: 0x007735C0
		public bool HideAvatar { get; set; }

		// Token: 0x1700E531 RID: 58673
		// (get) Token: 0x06036F3C RID: 225084 RVA: 0x007753C9 File Offset: 0x007735C9
		// (set) Token: 0x06036F3D RID: 225085 RVA: 0x007753D1 File Offset: 0x007735D1
		public bool HidePortrait { get; set; }

		// Token: 0x1700E532 RID: 58674
		// (get) Token: 0x06036F3E RID: 225086 RVA: 0x007753DA File Offset: 0x007735DA
		// (set) Token: 0x06036F3F RID: 225087 RVA: 0x007753E2 File Offset: 0x007735E2
		public byte NullMask { get; set; }

		// Token: 0x06036F40 RID: 225088 RVA: 0x007753EB File Offset: 0x007735EB
		public IVisualNovelRoleConfigT()
		{
			this.Expression = 0;
			this.VisualEffect = EAvgVisualEffect.Default;
			this.HideAvatar = false;
			this.HidePortrait = false;
			this.NullMask = 0;
		}
	}
}

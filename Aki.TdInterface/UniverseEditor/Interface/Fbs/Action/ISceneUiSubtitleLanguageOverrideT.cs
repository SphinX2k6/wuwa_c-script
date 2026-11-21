using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D6 RID: 30422
	public class ISceneUiSubtitleLanguageOverrideT
	{
		// Token: 0x1700DF2D RID: 57133
		// (get) Token: 0x0603560B RID: 218635 RVA: 0x00728E53 File Offset: 0x00727053
		// (set) Token: 0x0603560C RID: 218636 RVA: 0x00728E5B File Offset: 0x0072705B
		public string Language { get; set; }

		// Token: 0x1700DF2E RID: 57134
		// (get) Token: 0x0603560D RID: 218637 RVA: 0x00728E64 File Offset: 0x00727064
		// (set) Token: 0x0603560E RID: 218638 RVA: 0x00728E6C File Offset: 0x0072706C
		public TSceneUiSubtitlePositionUnion Position { get; set; }

		// Token: 0x1700DF2F RID: 57135
		// (get) Token: 0x0603560F RID: 218639 RVA: 0x00728E75 File Offset: 0x00727075
		// (set) Token: 0x06035610 RID: 218640 RVA: 0x00728E7D File Offset: 0x0072707D
		public float Scale { get; set; }

		// Token: 0x1700DF30 RID: 57136
		// (get) Token: 0x06035611 RID: 218641 RVA: 0x00728E86 File Offset: 0x00727086
		// (set) Token: 0x06035612 RID: 218642 RVA: 0x00728E8E File Offset: 0x0072708E
		public byte NullMask { get; set; }

		// Token: 0x06035613 RID: 218643 RVA: 0x00728E97 File Offset: 0x00727097
		public ISceneUiSubtitleLanguageOverrideT()
		{
			this.Language = null;
			this.Position = null;
			this.Scale = 0f;
			this.NullMask = 0;
		}
	}
}

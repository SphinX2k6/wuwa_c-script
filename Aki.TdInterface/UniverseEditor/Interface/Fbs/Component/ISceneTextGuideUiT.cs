using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EEA RID: 24298
	public class ISceneTextGuideUiT
	{
		// Token: 0x1700B396 RID: 45974
		// (get) Token: 0x06028BF4 RID: 166900 RVA: 0x00591DC5 File Offset: 0x0058FFC5
		// (set) Token: 0x06028BF5 RID: 166901 RVA: 0x00591DCD File Offset: 0x0058FFCD
		public ESceneTextType Type { get; set; }

		// Token: 0x1700B397 RID: 45975
		// (get) Token: 0x06028BF6 RID: 166902 RVA: 0x00591DD6 File Offset: 0x0058FFD6
		// (set) Token: 0x06028BF7 RID: 166903 RVA: 0x00591DDE File Offset: 0x0058FFDE
		public ISceneTextGuideUiScaleConfigT ScaleConfig { get; set; }

		// Token: 0x1700B398 RID: 45976
		// (get) Token: 0x06028BF8 RID: 166904 RVA: 0x00591DE7 File Offset: 0x0058FFE7
		// (set) Token: 0x06028BF9 RID: 166905 RVA: 0x00591DEF File Offset: 0x0058FFEF
		public ISceneTextGuideUiContentT Content { get; set; }

		// Token: 0x06028BFA RID: 166906 RVA: 0x00591DF8 File Offset: 0x0058FFF8
		public ISceneTextGuideUiT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
			this.ScaleConfig = null;
			this.Content = null;
		}
	}
}

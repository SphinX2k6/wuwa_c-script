using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DD RID: 22749
	public class ISceneTextGuideUiT
	{
		// Token: 0x1700AA66 RID: 43622
		// (get) Token: 0x06026692 RID: 157330 RVA: 0x0054B279 File Offset: 0x00549479
		// (set) Token: 0x06026693 RID: 157331 RVA: 0x0054B281 File Offset: 0x00549481
		public ESceneTextType Type { get; set; }

		// Token: 0x1700AA67 RID: 43623
		// (get) Token: 0x06026694 RID: 157332 RVA: 0x0054B28A File Offset: 0x0054948A
		// (set) Token: 0x06026695 RID: 157333 RVA: 0x0054B292 File Offset: 0x00549492
		public ISceneTextGuideUiScaleConfigT ScaleConfig { get; set; }

		// Token: 0x1700AA68 RID: 43624
		// (get) Token: 0x06026696 RID: 157334 RVA: 0x0054B29B File Offset: 0x0054949B
		// (set) Token: 0x06026697 RID: 157335 RVA: 0x0054B2A3 File Offset: 0x005494A3
		public ISceneTextGuideUiContentT Content { get; set; }

		// Token: 0x06026698 RID: 157336 RVA: 0x0054B2AC File Offset: 0x005494AC
		public ISceneTextGuideUiT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
			this.ScaleConfig = null;
			this.Content = null;
		}
	}
}

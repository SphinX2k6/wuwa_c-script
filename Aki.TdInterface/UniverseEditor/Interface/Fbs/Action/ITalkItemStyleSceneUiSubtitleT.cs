using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ADD RID: 31453
	public class ITalkItemStyleSceneUiSubtitleT
	{
		// Token: 0x1700E9C3 RID: 59843
		// (get) Token: 0x0603832A RID: 230186 RVA: 0x0079010F File Offset: 0x0078E30F
		// (set) Token: 0x0603832B RID: 230187 RVA: 0x00790117 File Offset: 0x0078E317
		public ETalkItemStyle Type { get; set; }

		// Token: 0x1700E9C4 RID: 59844
		// (get) Token: 0x0603832C RID: 230188 RVA: 0x00790120 File Offset: 0x0078E320
		// (set) Token: 0x0603832D RID: 230189 RVA: 0x00790128 File Offset: 0x0078E328
		public TSceneUiSubtitleStyleUnion Style { get; set; }

		// Token: 0x0603832E RID: 230190 RVA: 0x00790131 File Offset: 0x0078E331
		public ITalkItemStyleSceneUiSubtitleT()
		{
			this.Type = ETalkItemStyle.InnerVoice;
			this.Style = null;
		}
	}
}

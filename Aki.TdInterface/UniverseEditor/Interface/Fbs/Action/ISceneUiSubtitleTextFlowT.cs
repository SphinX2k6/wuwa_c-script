using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FD RID: 30461
	public class ISceneUiSubtitleTextFlowT
	{
		// Token: 0x1700DF6C RID: 57196
		// (get) Token: 0x0603572B RID: 218923 RVA: 0x0072AEFF File Offset: 0x007290FF
		// (set) Token: 0x0603572C RID: 218924 RVA: 0x0072AF07 File Offset: 0x00729107
		public ESceneUiSubtitleTextType Type { get; set; }

		// Token: 0x1700DF6D RID: 57197
		// (get) Token: 0x0603572D RID: 218925 RVA: 0x0072AF10 File Offset: 0x00729110
		// (set) Token: 0x0603572E RID: 218926 RVA: 0x0072AF18 File Offset: 0x00729118
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0603572F RID: 218927 RVA: 0x0072AF21 File Offset: 0x00729121
		public ISceneUiSubtitleTextFlowT()
		{
			this.Type = ESceneUiSubtitleTextType.Flow;
			this.Flow = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A8 RID: 29864
	public class IPlayMovieT
	{
		// Token: 0x1700DB7D RID: 56189
		// (get) Token: 0x060344E4 RID: 214244 RVA: 0x0070B748 File Offset: 0x00709948
		// (set) Token: 0x060344E5 RID: 214245 RVA: 0x0070B750 File Offset: 0x00709950
		public string VideoName { get; set; }

		// Token: 0x1700DB7E RID: 56190
		// (get) Token: 0x060344E6 RID: 214246 RVA: 0x0070B759 File Offset: 0x00709959
		// (set) Token: 0x060344E7 RID: 214247 RVA: 0x0070B761 File Offset: 0x00709961
		public IMovieBackgroundFadeDataT BackgroundFade { get; set; }

		// Token: 0x1700DB7F RID: 56191
		// (get) Token: 0x060344E8 RID: 214248 RVA: 0x0070B76A File Offset: 0x0070996A
		// (set) Token: 0x060344E9 RID: 214249 RVA: 0x0070B772 File Offset: 0x00709972
		public IMp4UiReplaceMaterialT ProgramSpecialConfig { get; set; }

		// Token: 0x1700DB80 RID: 56192
		// (get) Token: 0x060344EA RID: 214250 RVA: 0x0070B77B File Offset: 0x0070997B
		// (set) Token: 0x060344EB RID: 214251 RVA: 0x0070B783 File Offset: 0x00709983
		public float Mp4FadeOutTime { get; set; }

		// Token: 0x1700DB81 RID: 56193
		// (get) Token: 0x060344EC RID: 214252 RVA: 0x0070B78C File Offset: 0x0070998C
		// (set) Token: 0x060344ED RID: 214253 RVA: 0x0070B794 File Offset: 0x00709994
		public float Mp4FadeInTime { get; set; }

		// Token: 0x1700DB82 RID: 56194
		// (get) Token: 0x060344EE RID: 214254 RVA: 0x0070B79D File Offset: 0x0070999D
		// (set) Token: 0x060344EF RID: 214255 RVA: 0x0070B7A5 File Offset: 0x007099A5
		public float BlackBorderFadeOutTime { get; set; }

		// Token: 0x1700DB83 RID: 56195
		// (get) Token: 0x060344F0 RID: 214256 RVA: 0x0070B7AE File Offset: 0x007099AE
		// (set) Token: 0x060344F1 RID: 214257 RVA: 0x0070B7B6 File Offset: 0x007099B6
		public List<IMp4FrameEventT> Mp4FrameEvents { get; set; }

		// Token: 0x1700DB84 RID: 56196
		// (get) Token: 0x060344F2 RID: 214258 RVA: 0x0070B7BF File Offset: 0x007099BF
		// (set) Token: 0x060344F3 RID: 214259 RVA: 0x0070B7C7 File Offset: 0x007099C7
		public ISetBlendAnimT Mp4BlendAnim { get; set; }

		// Token: 0x1700DB85 RID: 56197
		// (get) Token: 0x060344F4 RID: 214260 RVA: 0x0070B7D0 File Offset: 0x007099D0
		// (set) Token: 0x060344F5 RID: 214261 RVA: 0x0070B7D8 File Offset: 0x007099D8
		public byte NullMask { get; set; }

		// Token: 0x060344F6 RID: 214262 RVA: 0x0070B7E4 File Offset: 0x007099E4
		public IPlayMovieT()
		{
			this.VideoName = null;
			this.BackgroundFade = new IMovieBackgroundFadeDataT();
			this.ProgramSpecialConfig = null;
			this.Mp4FadeOutTime = 0f;
			this.Mp4FadeInTime = 0f;
			this.BlackBorderFadeOutTime = 0f;
			this.Mp4FrameEvents = null;
			this.Mp4BlendAnim = null;
			this.NullMask = 0;
		}
	}
}

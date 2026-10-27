using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2D RID: 27949
	public class IPlayMovieT
	{
		// Token: 0x1700D036 RID: 53302
		// (get) Token: 0x060314EA RID: 201962 RVA: 0x006B008E File Offset: 0x006AE28E
		// (set) Token: 0x060314EB RID: 201963 RVA: 0x006B0096 File Offset: 0x006AE296
		public string VideoName { get; set; }

		// Token: 0x1700D037 RID: 53303
		// (get) Token: 0x060314EC RID: 201964 RVA: 0x006B009F File Offset: 0x006AE29F
		// (set) Token: 0x060314ED RID: 201965 RVA: 0x006B00A7 File Offset: 0x006AE2A7
		public IMovieBackgroundFadeDataT BackgroundFade { get; set; }

		// Token: 0x1700D038 RID: 53304
		// (get) Token: 0x060314EE RID: 201966 RVA: 0x006B00B0 File Offset: 0x006AE2B0
		// (set) Token: 0x060314EF RID: 201967 RVA: 0x006B00B8 File Offset: 0x006AE2B8
		public IMp4UiReplaceMaterialT ProgramSpecialConfig { get; set; }

		// Token: 0x1700D039 RID: 53305
		// (get) Token: 0x060314F0 RID: 201968 RVA: 0x006B00C1 File Offset: 0x006AE2C1
		// (set) Token: 0x060314F1 RID: 201969 RVA: 0x006B00C9 File Offset: 0x006AE2C9
		public float Mp4FadeOutTime { get; set; }

		// Token: 0x1700D03A RID: 53306
		// (get) Token: 0x060314F2 RID: 201970 RVA: 0x006B00D2 File Offset: 0x006AE2D2
		// (set) Token: 0x060314F3 RID: 201971 RVA: 0x006B00DA File Offset: 0x006AE2DA
		public float BlackBorderFadeOutTime { get; set; }

		// Token: 0x1700D03B RID: 53307
		// (get) Token: 0x060314F4 RID: 201972 RVA: 0x006B00E3 File Offset: 0x006AE2E3
		// (set) Token: 0x060314F5 RID: 201973 RVA: 0x006B00EB File Offset: 0x006AE2EB
		public List<IMp4FrameEventT> Mp4FrameEvents { get; set; }

		// Token: 0x1700D03C RID: 53308
		// (get) Token: 0x060314F6 RID: 201974 RVA: 0x006B00F4 File Offset: 0x006AE2F4
		// (set) Token: 0x060314F7 RID: 201975 RVA: 0x006B00FC File Offset: 0x006AE2FC
		public ISetBlendAnimT Mp4BlendAnim { get; set; }

		// Token: 0x1700D03D RID: 53309
		// (get) Token: 0x060314F8 RID: 201976 RVA: 0x006B0105 File Offset: 0x006AE305
		// (set) Token: 0x060314F9 RID: 201977 RVA: 0x006B010D File Offset: 0x006AE30D
		public byte NullMask { get; set; }

		// Token: 0x060314FA RID: 201978 RVA: 0x006B0118 File Offset: 0x006AE318
		public IPlayMovieT()
		{
			this.VideoName = null;
			this.BackgroundFade = new IMovieBackgroundFadeDataT();
			this.ProgramSpecialConfig = null;
			this.Mp4FadeOutTime = 0f;
			this.BlackBorderFadeOutTime = 0f;
			this.Mp4FrameEvents = null;
			this.Mp4BlendAnim = null;
			this.NullMask = 0;
		}
	}
}

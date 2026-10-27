using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6D RID: 27501
	public class IMovieBackgroundFadeDataT
	{
		// Token: 0x1700CC6B RID: 52331
		// (get) Token: 0x060304A8 RID: 197800 RVA: 0x0068FE04 File Offset: 0x0068E004
		// (set) Token: 0x060304A9 RID: 197801 RVA: 0x0068FE0C File Offset: 0x0068E00C
		public EMovieBackgroundType FadeInBackgroundType { get; set; }

		// Token: 0x1700CC6C RID: 52332
		// (get) Token: 0x060304AA RID: 197802 RVA: 0x0068FE15 File Offset: 0x0068E015
		// (set) Token: 0x060304AB RID: 197803 RVA: 0x0068FE1D File Offset: 0x0068E01D
		public EMovieBackgroundType FadeOutBackgroundType { get; set; }

		// Token: 0x060304AC RID: 197804 RVA: 0x0068FE26 File Offset: 0x0068E026
		public IMovieBackgroundFadeDataT()
		{
			this.FadeInBackgroundType = EMovieBackgroundType.White;
			this.FadeOutBackgroundType = EMovieBackgroundType.White;
		}
	}
}

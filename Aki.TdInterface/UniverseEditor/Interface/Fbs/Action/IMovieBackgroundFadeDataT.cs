using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B3 RID: 29363
	public class IMovieBackgroundFadeDataT
	{
		// Token: 0x1700D750 RID: 55120
		// (get) Token: 0x06033300 RID: 209664 RVA: 0x006E8424 File Offset: 0x006E6624
		// (set) Token: 0x06033301 RID: 209665 RVA: 0x006E842C File Offset: 0x006E662C
		public EMovieBackgroundType FadeInBackgroundType { get; set; }

		// Token: 0x1700D751 RID: 55121
		// (get) Token: 0x06033302 RID: 209666 RVA: 0x006E8435 File Offset: 0x006E6635
		// (set) Token: 0x06033303 RID: 209667 RVA: 0x006E843D File Offset: 0x006E663D
		public EMovieBackgroundType FadeOutBackgroundType { get; set; }

		// Token: 0x06033304 RID: 209668 RVA: 0x006E8446 File Offset: 0x006E6646
		public IMovieBackgroundFadeDataT()
		{
			this.FadeInBackgroundType = EMovieBackgroundType.White;
			this.FadeOutBackgroundType = EMovieBackgroundType.White;
		}
	}
}

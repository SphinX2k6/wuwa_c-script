using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007269 RID: 29289
	public class ISwitchSeasonT
	{
		// Token: 0x1700D950 RID: 55632
		// (get) Token: 0x06033F5E RID: 212830 RVA: 0x006FCE7E File Offset: 0x006FB07E
		// (set) Token: 0x06033F5F RID: 212831 RVA: 0x006FCE86 File Offset: 0x006FB086
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x1700D951 RID: 55633
		// (get) Token: 0x06033F60 RID: 212832 RVA: 0x006FCE8F File Offset: 0x006FB08F
		// (set) Token: 0x06033F61 RID: 212833 RVA: 0x006FCE97 File Offset: 0x006FB097
		public ESeason Season { get; set; }

		// Token: 0x1700D952 RID: 55634
		// (get) Token: 0x06033F62 RID: 212834 RVA: 0x006FCEA0 File Offset: 0x006FB0A0
		// (set) Token: 0x06033F63 RID: 212835 RVA: 0x006FCEA8 File Offset: 0x006FB0A8
		public float TransitionSpeed { get; set; }

		// Token: 0x06033F64 RID: 212836 RVA: 0x006FCEB1 File Offset: 0x006FB0B1
		public ISwitchSeasonT()
		{
			this.Type = EClientSetSeasonStateType.SwitchSeason;
			this.Season = ESeason.Spring;
			this.TransitionSpeed = 0f;
		}
	}
}

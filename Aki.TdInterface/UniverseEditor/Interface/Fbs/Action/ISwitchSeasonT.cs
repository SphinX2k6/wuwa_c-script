using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A3E RID: 31294
	public class ISwitchSeasonT
	{
		// Token: 0x1700E549 RID: 58697
		// (get) Token: 0x06037260 RID: 225888 RVA: 0x0075E1DE File Offset: 0x0075C3DE
		// (set) Token: 0x06037261 RID: 225889 RVA: 0x0075E1E6 File Offset: 0x0075C3E6
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x1700E54A RID: 58698
		// (get) Token: 0x06037262 RID: 225890 RVA: 0x0075E1EF File Offset: 0x0075C3EF
		// (set) Token: 0x06037263 RID: 225891 RVA: 0x0075E1F7 File Offset: 0x0075C3F7
		public ESeason Season { get; set; }

		// Token: 0x1700E54B RID: 58699
		// (get) Token: 0x06037264 RID: 225892 RVA: 0x0075E200 File Offset: 0x0075C400
		// (set) Token: 0x06037265 RID: 225893 RVA: 0x0075E208 File Offset: 0x0075C408
		public float TransitionSpeed { get; set; }

		// Token: 0x06037266 RID: 225894 RVA: 0x0075E211 File Offset: 0x0075C411
		public ISwitchSeasonT()
		{
			this.Type = EClientSetSeasonStateType.SwitchSeason;
			this.Season = ESeason.Spring;
			this.TransitionSpeed = 0f;
		}
	}
}

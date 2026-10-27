using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691F RID: 26911
	public class IHonamiStoryCustomLoadingT
	{
		// Token: 0x1700C7AB RID: 51115
		// (get) Token: 0x0602EFAD RID: 192429 RVA: 0x00667EBC File Offset: 0x006660BC
		// (set) Token: 0x0602EFAE RID: 192430 RVA: 0x00667EC4 File Offset: 0x006660C4
		public ESpecialCustomLoadingType Type { get; set; }

		// Token: 0x1700C7AC RID: 51116
		// (get) Token: 0x0602EFAF RID: 192431 RVA: 0x00667ECD File Offset: 0x006660CD
		// (set) Token: 0x0602EFB0 RID: 192432 RVA: 0x00667ED5 File Offset: 0x006660D5
		public int LoadingId { get; set; }

		// Token: 0x0602EFB1 RID: 192433 RVA: 0x00667EDE File Offset: 0x006660DE
		public IHonamiStoryCustomLoadingT()
		{
			this.Type = ESpecialCustomLoadingType.HonamiStory;
			this.LoadingId = 0;
		}
	}
}

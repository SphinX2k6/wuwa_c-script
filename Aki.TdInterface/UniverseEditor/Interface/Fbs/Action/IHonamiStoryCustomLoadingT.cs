using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD2 RID: 28626
	public class IHonamiStoryCustomLoadingT
	{
		// Token: 0x1700D1AE RID: 53678
		// (get) Token: 0x0603197D RID: 203133 RVA: 0x006B83A4 File Offset: 0x006B65A4
		// (set) Token: 0x0603197E RID: 203134 RVA: 0x006B83AC File Offset: 0x006B65AC
		public ESpecialCustomLoadingType Type { get; set; }

		// Token: 0x1700D1AF RID: 53679
		// (get) Token: 0x0603197F RID: 203135 RVA: 0x006B83B5 File Offset: 0x006B65B5
		// (set) Token: 0x06031980 RID: 203136 RVA: 0x006B83BD File Offset: 0x006B65BD
		public int LoadingId { get; set; }

		// Token: 0x06031981 RID: 203137 RVA: 0x006B83C6 File Offset: 0x006B65C6
		public IHonamiStoryCustomLoadingT()
		{
			this.Type = ESpecialCustomLoadingType.HonamiStory;
			this.LoadingId = 0;
		}
	}
}

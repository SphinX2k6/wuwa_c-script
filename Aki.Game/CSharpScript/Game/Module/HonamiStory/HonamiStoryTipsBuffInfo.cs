using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004924 RID: 18724
	public class HonamiStoryTipsBuffInfo : IHonamiStoryTipsBuffInfo
	{
		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x0602EF63 RID: 192355 RVA: 0x00D19908 File Offset: 0x00D17B08
		// (set) Token: 0x0602EF64 RID: 192356 RVA: 0x00D19910 File Offset: 0x00D17B10
		public int BuffId { get; set; }

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x0602EF65 RID: 192357 RVA: 0x00D19919 File Offset: 0x00D17B19
		// (set) Token: 0x0602EF66 RID: 192358 RVA: 0x00D19921 File Offset: 0x00D17B21
		public int? TagId { get; set; }

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x0602EF67 RID: 192359 RVA: 0x00D1992A File Offset: 0x00D17B2A
		// (set) Token: 0x0602EF68 RID: 192360 RVA: 0x00D19932 File Offset: 0x00D17B32
		public int? RoleId { get; set; }

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x0602EF69 RID: 192361 RVA: 0x00D1993B File Offset: 0x00D17B3B
		// (set) Token: 0x0602EF6A RID: 192362 RVA: 0x00D19943 File Offset: 0x00D17B43
		public bool FromTeamView { get; set; }
	}
}

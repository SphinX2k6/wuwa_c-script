using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1A RID: 23834
	public class IAvgSolarSchoolExpressionT
	{
		// Token: 0x1700B29F RID: 45727
		// (get) Token: 0x06028B9D RID: 166813 RVA: 0x00597F83 File Offset: 0x00596183
		// (set) Token: 0x06028B9E RID: 166814 RVA: 0x00597F8B File Offset: 0x0059618B
		public int Id { get; set; }

		// Token: 0x1700B2A0 RID: 45728
		// (get) Token: 0x06028B9F RID: 166815 RVA: 0x00597F94 File Offset: 0x00596194
		// (set) Token: 0x06028BA0 RID: 166816 RVA: 0x00597F9C File Offset: 0x0059619C
		public string Name { get; set; }

		// Token: 0x1700B2A1 RID: 45729
		// (get) Token: 0x06028BA1 RID: 166817 RVA: 0x00597FA5 File Offset: 0x005961A5
		// (set) Token: 0x06028BA2 RID: 166818 RVA: 0x00597FAD File Offset: 0x005961AD
		public string BodyAnimation { get; set; }

		// Token: 0x1700B2A2 RID: 45730
		// (get) Token: 0x06028BA3 RID: 166819 RVA: 0x00597FB6 File Offset: 0x005961B6
		// (set) Token: 0x06028BA4 RID: 166820 RVA: 0x00597FBE File Offset: 0x005961BE
		public string MouthAnimation { get; set; }

		// Token: 0x1700B2A3 RID: 45731
		// (get) Token: 0x06028BA5 RID: 166821 RVA: 0x00597FC7 File Offset: 0x005961C7
		// (set) Token: 0x06028BA6 RID: 166822 RVA: 0x00597FCF File Offset: 0x005961CF
		public string MouthOpenSmallAnimation { get; set; }

		// Token: 0x1700B2A4 RID: 45732
		// (get) Token: 0x06028BA7 RID: 166823 RVA: 0x00597FD8 File Offset: 0x005961D8
		// (set) Token: 0x06028BA8 RID: 166824 RVA: 0x00597FE0 File Offset: 0x005961E0
		public string MouthOpenLargeAnimation { get; set; }

		// Token: 0x1700B2A5 RID: 45733
		// (get) Token: 0x06028BA9 RID: 166825 RVA: 0x00597FE9 File Offset: 0x005961E9
		// (set) Token: 0x06028BAA RID: 166826 RVA: 0x00597FF1 File Offset: 0x005961F1
		public string EyeAnimation { get; set; }

		// Token: 0x1700B2A6 RID: 45734
		// (get) Token: 0x06028BAB RID: 166827 RVA: 0x00597FFA File Offset: 0x005961FA
		// (set) Token: 0x06028BAC RID: 166828 RVA: 0x00598002 File Offset: 0x00596202
		public string BlinkAnimation { get; set; }

		// Token: 0x06028BAD RID: 166829 RVA: 0x0059800B File Offset: 0x0059620B
		public IAvgSolarSchoolExpressionT()
		{
			this.Id = 0;
			this.Name = null;
			this.BodyAnimation = null;
			this.MouthAnimation = null;
			this.MouthOpenSmallAnimation = null;
			this.MouthOpenLargeAnimation = null;
			this.EyeAnimation = null;
			this.BlinkAnimation = null;
		}
	}
}

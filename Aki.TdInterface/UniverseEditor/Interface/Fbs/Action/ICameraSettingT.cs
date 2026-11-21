using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006911 RID: 26897
	public class ICameraSettingT
	{
		// Token: 0x1700C600 RID: 50688
		// (get) Token: 0x0602E162 RID: 188770 RVA: 0x0064C56C File Offset: 0x0064A76C
		// (set) Token: 0x0602E163 RID: 188771 RVA: 0x0064C574 File Offset: 0x0064A774
		public float Aperture { get; set; }

		// Token: 0x1700C601 RID: 50689
		// (get) Token: 0x0602E164 RID: 188772 RVA: 0x0064C57D File Offset: 0x0064A77D
		// (set) Token: 0x0602E165 RID: 188773 RVA: 0x0064C585 File Offset: 0x0064A785
		public float FocalLength { get; set; }

		// Token: 0x1700C602 RID: 50690
		// (get) Token: 0x0602E166 RID: 188774 RVA: 0x0064C58E File Offset: 0x0064A78E
		// (set) Token: 0x0602E167 RID: 188775 RVA: 0x0064C596 File Offset: 0x0064A796
		public float FocusDistance { get; set; }

		// Token: 0x1700C603 RID: 50691
		// (get) Token: 0x0602E168 RID: 188776 RVA: 0x0064C59F File Offset: 0x0064A79F
		// (set) Token: 0x0602E169 RID: 188777 RVA: 0x0064C5A7 File Offset: 0x0064A7A7
		public float FocalRegion { get; set; }

		// Token: 0x1700C604 RID: 50692
		// (get) Token: 0x0602E16A RID: 188778 RVA: 0x0064C5B0 File Offset: 0x0064A7B0
		// (set) Token: 0x0602E16B RID: 188779 RVA: 0x0064C5B8 File Offset: 0x0064A7B8
		public float Fov { get; set; }

		// Token: 0x1700C605 RID: 50693
		// (get) Token: 0x0602E16C RID: 188780 RVA: 0x0064C5C1 File Offset: 0x0064A7C1
		// (set) Token: 0x0602E16D RID: 188781 RVA: 0x0064C5C9 File Offset: 0x0064A7C9
		public byte NullMask { get; set; }

		// Token: 0x0602E16E RID: 188782 RVA: 0x0064C5D4 File Offset: 0x0064A7D4
		public ICameraSettingT()
		{
			this.Aperture = 0f;
			this.FocalLength = 0f;
			this.FocusDistance = 0f;
			this.FocalRegion = 0f;
			this.Fov = 0f;
			this.NullMask = 0;
		}
	}
}

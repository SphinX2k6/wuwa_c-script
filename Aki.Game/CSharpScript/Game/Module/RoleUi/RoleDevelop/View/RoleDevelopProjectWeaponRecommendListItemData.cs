using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D16 RID: 15638
	public class RoleDevelopProjectWeaponRecommendListItemData : IRoleDevelopProjectWeaponRecommendListItemData
	{
		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x06028071 RID: 163953 RVA: 0x00B35364 File Offset: 0x00B33564
		// (set) Token: 0x06028072 RID: 163954 RVA: 0x00B3536C File Offset: 0x00B3356C
		public int DevelopRoleId { get; set; }

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x06028073 RID: 163955 RVA: 0x00B35375 File Offset: 0x00B33575
		// (set) Token: 0x06028074 RID: 163956 RVA: 0x00B3537D File Offset: 0x00B3357D
		public int RecommendWeaponId { get; set; }

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x06028075 RID: 163957 RVA: 0x00B35386 File Offset: 0x00B33586
		// (set) Token: 0x06028076 RID: 163958 RVA: 0x00B3538E File Offset: 0x00B3358E
		public int? LogRoleId { get; set; }

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x06028077 RID: 163959 RVA: 0x00B35397 File Offset: 0x00B33597
		// (set) Token: 0x06028078 RID: 163960 RVA: 0x00B3539F File Offset: 0x00B3359F
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x06028079 RID: 163961 RVA: 0x00B353A8 File Offset: 0x00B335A8
		// (set) Token: 0x0602807A RID: 163962 RVA: 0x00B353B0 File Offset: 0x00B335B0
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}

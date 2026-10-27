using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D4D RID: 19789
	public class RoleDevelopProjectWeaponRecommendListItemData : IRoleDevelopProjectWeaponRecommendListItemData
	{
		// Token: 0x17007E5B RID: 32347
		// (get) Token: 0x0603320E RID: 209422 RVA: 0x00BEBFF0 File Offset: 0x00BEA1F0
		// (set) Token: 0x0603320F RID: 209423 RVA: 0x00BEBFF8 File Offset: 0x00BEA1F8
		public int DevelopRoleId { get; set; }

		// Token: 0x17007E5C RID: 32348
		// (get) Token: 0x06033210 RID: 209424 RVA: 0x00BEC001 File Offset: 0x00BEA201
		// (set) Token: 0x06033211 RID: 209425 RVA: 0x00BEC009 File Offset: 0x00BEA209
		public int RecommendWeaponId { get; set; }

		// Token: 0x17007E5D RID: 32349
		// (get) Token: 0x06033212 RID: 209426 RVA: 0x00BEC012 File Offset: 0x00BEA212
		// (set) Token: 0x06033213 RID: 209427 RVA: 0x00BEC01A File Offset: 0x00BEA21A
		public int? LogRoleId { get; set; }

		// Token: 0x17007E5E RID: 32350
		// (get) Token: 0x06033214 RID: 209428 RVA: 0x00BEC023 File Offset: 0x00BEA223
		// (set) Token: 0x06033215 RID: 209429 RVA: 0x00BEC02B File Offset: 0x00BEA22B
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E5F RID: 32351
		// (get) Token: 0x06033216 RID: 209430 RVA: 0x00BEC034 File Offset: 0x00BEA234
		// (set) Token: 0x06033217 RID: 209431 RVA: 0x00BEC03C File Offset: 0x00BEA23C
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}

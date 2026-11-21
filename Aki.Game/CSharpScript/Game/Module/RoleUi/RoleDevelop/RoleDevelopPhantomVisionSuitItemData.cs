using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CDA RID: 15578
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopPhantomVisionSuitItemData : IRoleDevelopPhantomVisionSuitItemData
	{
		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x06027E3D RID: 163389 RVA: 0x00B27611 File Offset: 0x00B25811
		// (set) Token: 0x06027E3E RID: 163390 RVA: 0x00B27619 File Offset: 0x00B25819
		public string Name { get; set; }

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x06027E3F RID: 163391 RVA: 0x00B27622 File Offset: 0x00B25822
		// (set) Token: 0x06027E40 RID: 163392 RVA: 0x00B2762A File Offset: 0x00B2582A
		public string ButtonName { get; set; }

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x06027E41 RID: 163393 RVA: 0x00B27633 File Offset: 0x00B25833
		// (set) Token: 0x06027E42 RID: 163394 RVA: 0x00B2763B File Offset: 0x00B2583B
		public EPhantomSuitItemType ItemType { get; set; }

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x06027E43 RID: 163395 RVA: 0x00B27644 File Offset: 0x00B25844
		// (set) Token: 0x06027E44 RID: 163396 RVA: 0x00B2764C File Offset: 0x00B2584C
		public string TypeIcon { get; set; }

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x06027E45 RID: 163397 RVA: 0x00B27655 File Offset: 0x00B25855
		// (set) Token: 0x06027E46 RID: 163398 RVA: 0x00B2765D File Offset: 0x00B2585D
		public List<PhantomMonsterItemData> MonsterDataList { get; set; }

		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x06027E47 RID: 163399 RVA: 0x00B27666 File Offset: 0x00B25866
		// (set) Token: 0x06027E48 RID: 163400 RVA: 0x00B2766E File Offset: 0x00B2586E
		public List<DropRewardItemData> RewardDataList { get; set; }

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x06027E49 RID: 163401 RVA: 0x00B27677 File Offset: 0x00B25877
		// (set) Token: 0x06027E4A RID: 163402 RVA: 0x00B2767F File Offset: 0x00B2587F
		public int DungeonId { get; set; }

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x06027E4B RID: 163403 RVA: 0x00B27688 File Offset: 0x00B25888
		// (set) Token: 0x06027E4C RID: 163404 RVA: 0x00B27690 File Offset: 0x00B25890
		public int FetterGroupId { get; set; }

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x06027E4D RID: 163405 RVA: 0x00B27699 File Offset: 0x00B25899
		// (set) Token: 0x06027E4E RID: 163406 RVA: 0x00B276A1 File Offset: 0x00B258A1
		public int RoleId { get; set; }

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x06027E4F RID: 163407 RVA: 0x00B276AA File Offset: 0x00B258AA
		// (set) Token: 0x06027E50 RID: 163408 RVA: 0x00B276B2 File Offset: 0x00B258B2
		public int? LogRoleId { get; set; }

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x06027E51 RID: 163409 RVA: 0x00B276BB File Offset: 0x00B258BB
		// (set) Token: 0x06027E52 RID: 163410 RVA: 0x00B276C3 File Offset: 0x00B258C3
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x06027E53 RID: 163411 RVA: 0x00B276CC File Offset: 0x00B258CC
		// (set) Token: 0x06027E54 RID: 163412 RVA: 0x00B276D4 File Offset: 0x00B258D4
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}

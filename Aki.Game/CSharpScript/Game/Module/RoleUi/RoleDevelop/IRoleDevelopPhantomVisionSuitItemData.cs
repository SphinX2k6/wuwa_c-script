using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D20 RID: 19744
	[NullableContext(1)]
	public interface IRoleDevelopPhantomVisionSuitItemData
	{
		// Token: 0x17007E19 RID: 32281
		// (get) Token: 0x0603303A RID: 208954
		// (set) Token: 0x0603303B RID: 208955
		string Name { get; set; }

		// Token: 0x17007E1A RID: 32282
		// (get) Token: 0x0603303C RID: 208956
		// (set) Token: 0x0603303D RID: 208957
		string ButtonName { get; set; }

		// Token: 0x17007E1B RID: 32283
		// (get) Token: 0x0603303E RID: 208958
		// (set) Token: 0x0603303F RID: 208959
		EPhantomSuitItemType ItemType { get; set; }

		// Token: 0x17007E1C RID: 32284
		// (get) Token: 0x06033040 RID: 208960
		// (set) Token: 0x06033041 RID: 208961
		string TypeIcon { get; set; }

		// Token: 0x17007E1D RID: 32285
		// (get) Token: 0x06033042 RID: 208962
		// (set) Token: 0x06033043 RID: 208963
		List<PhantomMonsterItemData> MonsterDataList { get; set; }

		// Token: 0x17007E1E RID: 32286
		// (get) Token: 0x06033044 RID: 208964
		// (set) Token: 0x06033045 RID: 208965
		List<DropRewardItemData> RewardDataList { get; set; }

		// Token: 0x17007E1F RID: 32287
		// (get) Token: 0x06033046 RID: 208966
		// (set) Token: 0x06033047 RID: 208967
		int DungeonId { get; set; }

		// Token: 0x17007E20 RID: 32288
		// (get) Token: 0x06033048 RID: 208968
		// (set) Token: 0x06033049 RID: 208969
		int FetterGroupId { get; set; }

		// Token: 0x17007E21 RID: 32289
		// (get) Token: 0x0603304A RID: 208970
		// (set) Token: 0x0603304B RID: 208971
		int RoleId { get; set; }

		// Token: 0x17007E22 RID: 32290
		// (get) Token: 0x0603304C RID: 208972
		// (set) Token: 0x0603304D RID: 208973
		int? LogRoleId { get; set; }

		// Token: 0x17007E23 RID: 32291
		// (get) Token: 0x0603304E RID: 208974
		// (set) Token: 0x0603304F RID: 208975
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E24 RID: 32292
		// (get) Token: 0x06033050 RID: 208976
		// (set) Token: 0x06033051 RID: 208977
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}

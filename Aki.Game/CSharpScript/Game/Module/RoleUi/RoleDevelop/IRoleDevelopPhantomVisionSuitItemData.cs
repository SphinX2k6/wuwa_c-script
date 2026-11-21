using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CD9 RID: 15577
	[NullableContext(1)]
	public interface IRoleDevelopPhantomVisionSuitItemData
	{
		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x06027E25 RID: 163365
		// (set) Token: 0x06027E26 RID: 163366
		string Name { get; set; }

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x06027E27 RID: 163367
		// (set) Token: 0x06027E28 RID: 163368
		string ButtonName { get; set; }

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x06027E29 RID: 163369
		// (set) Token: 0x06027E2A RID: 163370
		EPhantomSuitItemType ItemType { get; set; }

		// Token: 0x170051CC RID: 20940
		// (get) Token: 0x06027E2B RID: 163371
		// (set) Token: 0x06027E2C RID: 163372
		string TypeIcon { get; set; }

		// Token: 0x170051CD RID: 20941
		// (get) Token: 0x06027E2D RID: 163373
		// (set) Token: 0x06027E2E RID: 163374
		List<PhantomMonsterItemData> MonsterDataList { get; set; }

		// Token: 0x170051CE RID: 20942
		// (get) Token: 0x06027E2F RID: 163375
		// (set) Token: 0x06027E30 RID: 163376
		List<DropRewardItemData> RewardDataList { get; set; }

		// Token: 0x170051CF RID: 20943
		// (get) Token: 0x06027E31 RID: 163377
		// (set) Token: 0x06027E32 RID: 163378
		int DungeonId { get; set; }

		// Token: 0x170051D0 RID: 20944
		// (get) Token: 0x06027E33 RID: 163379
		// (set) Token: 0x06027E34 RID: 163380
		int FetterGroupId { get; set; }

		// Token: 0x170051D1 RID: 20945
		// (get) Token: 0x06027E35 RID: 163381
		// (set) Token: 0x06027E36 RID: 163382
		int RoleId { get; set; }

		// Token: 0x170051D2 RID: 20946
		// (get) Token: 0x06027E37 RID: 163383
		// (set) Token: 0x06027E38 RID: 163384
		int? LogRoleId { get; set; }

		// Token: 0x170051D3 RID: 20947
		// (get) Token: 0x06027E39 RID: 163385
		// (set) Token: 0x06027E3A RID: 163386
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x170051D4 RID: 20948
		// (get) Token: 0x06027E3B RID: 163387
		// (set) Token: 0x06027E3C RID: 163388
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CDB RID: 15579
	[NullableContext(2)]
	public interface IRoleDevelopPhantomVisionSuitListItemData
	{
		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x06027E56 RID: 163414
		// (set) Token: 0x06027E57 RID: 163415
		PhantomMonsterItemData MonsterData { get; set; }

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x06027E58 RID: 163416
		// (set) Token: 0x06027E59 RID: 163417
		DropRewardItemData RewardData { get; set; }
	}
}

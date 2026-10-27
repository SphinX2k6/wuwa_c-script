using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D22 RID: 19746
	[NullableContext(2)]
	public interface IRoleDevelopPhantomVisionSuitListItemData
	{
		// Token: 0x17007E31 RID: 32305
		// (get) Token: 0x0603306B RID: 209003
		// (set) Token: 0x0603306C RID: 209004
		PhantomMonsterItemData MonsterData { get; set; }

		// Token: 0x17007E32 RID: 32306
		// (get) Token: 0x0603306D RID: 209005
		// (set) Token: 0x0603306E RID: 209006
		DropRewardItemData RewardData { get; set; }
	}
}

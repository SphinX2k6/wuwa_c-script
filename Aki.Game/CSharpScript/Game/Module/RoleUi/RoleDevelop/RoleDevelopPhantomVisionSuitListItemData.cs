using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CDC RID: 15580
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevelopPhantomVisionSuitListItemData : IRoleDevelopPhantomVisionSuitListItemData
	{
		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x06027E5A RID: 163418 RVA: 0x00B276E5 File Offset: 0x00B258E5
		// (set) Token: 0x06027E5B RID: 163419 RVA: 0x00B276ED File Offset: 0x00B258ED
		public PhantomMonsterItemData MonsterData { get; set; }

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x06027E5C RID: 163420 RVA: 0x00B276F6 File Offset: 0x00B258F6
		// (set) Token: 0x06027E5D RID: 163421 RVA: 0x00B276FE File Offset: 0x00B258FE
		public DropRewardItemData RewardData { get; set; }
	}
}

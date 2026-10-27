using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D23 RID: 19747
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevelopPhantomVisionSuitListItemData : IRoleDevelopPhantomVisionSuitListItemData
	{
		// Token: 0x17007E33 RID: 32307
		// (get) Token: 0x0603306F RID: 209007 RVA: 0x00BE1D74 File Offset: 0x00BDFF74
		// (set) Token: 0x06033070 RID: 209008 RVA: 0x00BE1D7C File Offset: 0x00BDFF7C
		public PhantomMonsterItemData MonsterData { get; set; }

		// Token: 0x17007E34 RID: 32308
		// (get) Token: 0x06033071 RID: 209009 RVA: 0x00BE1D85 File Offset: 0x00BDFF85
		// (set) Token: 0x06033072 RID: 209010 RVA: 0x00BE1D8D File Offset: 0x00BDFF8D
		public DropRewardItemData RewardData { get; set; }
	}
}

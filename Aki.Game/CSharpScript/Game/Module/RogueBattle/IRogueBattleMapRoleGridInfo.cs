using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E94 RID: 16020
	public interface IRogueBattleMapRoleGridInfo
	{
		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x06028B00 RID: 166656
		// (set) Token: 0x06028B01 RID: 166657
		int ConfigId { get; set; }

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x06028B02 RID: 166658
		// (set) Token: 0x06028B03 RID: 166659
		bool IsGain { get; set; }

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x06028B04 RID: 166660
		// (set) Token: 0x06028B05 RID: 166661
		bool NeedLevel { get; set; }
	}
}

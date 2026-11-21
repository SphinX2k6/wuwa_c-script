using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E92 RID: 16018
	public interface IRogueBattleMapAttrFettersInfo
	{
		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x06028AEF RID: 166639
		// (set) Token: 0x06028AF0 RID: 166640
		int ConfigId { get; set; }

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x06028AF1 RID: 166641
		// (set) Token: 0x06028AF2 RID: 166642
		bool IsUnlock { get; set; }

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x06028AF3 RID: 166643
		// (set) Token: 0x06028AF4 RID: 166644
		int Level { get; set; }

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x06028AF5 RID: 166645
		// (set) Token: 0x06028AF6 RID: 166646
		bool? IsMaxLevel { get; set; }
	}
}

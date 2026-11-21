using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E1F RID: 15903
	public interface IFetterData
	{
		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x0602892E RID: 166190
		// (set) Token: 0x0602892F RID: 166191
		int Id { get; set; }

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x06028930 RID: 166192
		// (set) Token: 0x06028931 RID: 166193
		int Lv { get; set; }

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x06028932 RID: 166194
		// (set) Token: 0x06028933 RID: 166195
		int Star { get; set; }

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x06028934 RID: 166196
		// (set) Token: 0x06028935 RID: 166197
		bool IsLevelUp { get; set; }
	}
}

using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E56 RID: 20054
	public interface IFetterData
	{
		// Token: 0x17007ED5 RID: 32469
		// (get) Token: 0x06033AC3 RID: 211651
		// (set) Token: 0x06033AC4 RID: 211652
		int Id { get; set; }

		// Token: 0x17007ED6 RID: 32470
		// (get) Token: 0x06033AC5 RID: 211653
		// (set) Token: 0x06033AC6 RID: 211654
		int Lv { get; set; }

		// Token: 0x17007ED7 RID: 32471
		// (get) Token: 0x06033AC7 RID: 211655
		// (set) Token: 0x06033AC8 RID: 211656
		int Star { get; set; }

		// Token: 0x17007ED8 RID: 32472
		// (get) Token: 0x06033AC9 RID: 211657
		// (set) Token: 0x06033ACA RID: 211658
		bool IsLevelUp { get; set; }
	}
}

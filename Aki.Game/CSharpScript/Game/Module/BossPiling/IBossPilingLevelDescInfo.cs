using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE1 RID: 19425
	[NullableContext(1)]
	public interface IBossPilingLevelDescInfo
	{
		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x060307C0 RID: 198592
		// (set) Token: 0x060307C1 RID: 198593
		bool IsFirstLevel { get; set; }

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x060307C2 RID: 198594
		// (set) Token: 0x060307C3 RID: 198595
		int LevelId { get; set; }

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x060307C4 RID: 198596
		// (set) Token: 0x060307C5 RID: 198597
		string LevelMechanism { get; set; }

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x060307C6 RID: 198598
		// (set) Token: 0x060307C7 RID: 198599
		string MonsterDesc { get; set; }

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x060307C8 RID: 198600
		// (set) Token: 0x060307C9 RID: 198601
		string LevelDesc { get; set; }
	}
}

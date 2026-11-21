using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E4 RID: 20964
	public interface IRealmBetweenLevelData
	{
		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x060343D4 RID: 213972
		// (set) Token: 0x060343D5 RID: 213973
		int Id { get; set; }

		// Token: 0x170065C4 RID: 26052
		// (get) Token: 0x060343D6 RID: 213974
		// (set) Token: 0x060343D7 RID: 213975
		int Level { get; set; }

		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x060343D8 RID: 213976
		// (set) Token: 0x060343D9 RID: 213977
		int AccumulateExp { get; set; }

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x060343DA RID: 213978
		// (set) Token: 0x060343DB RID: 213979
		int TargetExp { get; set; }
	}
}

using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EBF RID: 20159
	public interface IRogueBattleElementInfo
	{
		// Token: 0x17007EE1 RID: 32481
		// (get) Token: 0x06033C50 RID: 212048
		// (set) Token: 0x06033C51 RID: 212049
		int ElementId { get; set; }

		// Token: 0x17007EE2 RID: 32482
		// (get) Token: 0x06033C52 RID: 212050
		// (set) Token: 0x06033C53 RID: 212051
		int Count { get; set; }

		// Token: 0x17007EE3 RID: 32483
		// (get) Token: 0x06033C54 RID: 212052
		// (set) Token: 0x06033C55 RID: 212053
		bool IsPreview { get; set; }
	}
}

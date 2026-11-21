using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039FC RID: 14844
	public interface ITrapDefensePauseInfo
	{
		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x06026360 RID: 156512
		// (set) Token: 0x06026361 RID: 156513
		ETrapDefensePauseInfoType Type { get; set; }

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x06026362 RID: 156514
		// (set) Token: 0x06026363 RID: 156515
		int? Value { get; set; }

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x06026364 RID: 156516
		// (set) Token: 0x06026365 RID: 156517
		int? MaxBatch { get; set; }
	}
}

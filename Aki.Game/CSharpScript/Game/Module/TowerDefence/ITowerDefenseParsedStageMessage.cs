using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE1 RID: 15073
	[NullableContext(1)]
	public interface ITowerDefenseParsedStageMessage
	{
		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x06026B8A RID: 158602
		// (set) Token: 0x06026B8B RID: 158603
		TowerDefenceInstanceInfo Meta { get; set; }

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x06026B8C RID: 158604
		// (set) Token: 0x06026B8D RID: 158605
		int Id { get; set; }

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x06026B8E RID: 158606
		// (set) Token: 0x06026B8F RID: 158607
		long UnlockTime { get; set; }

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06026B90 RID: 158608
		// (set) Token: 0x06026B91 RID: 158609
		bool Passed { get; set; }

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06026B92 RID: 158610
		// (set) Token: 0x06026B93 RID: 158611
		double PassTime { get; set; }

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06026B94 RID: 158612
		// (set) Token: 0x06026B95 RID: 158613
		bool Rewarded { get; set; }

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06026B96 RID: 158614
		// (set) Token: 0x06026B97 RID: 158615
		int Record { get; set; }

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06026B98 RID: 158616
		// (set) Token: 0x06026B99 RID: 158617
		bool RecordOverThreshold { get; set; }
	}
}

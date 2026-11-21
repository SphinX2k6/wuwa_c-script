using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004581 RID: 17793
	[NullableContext(1)]
	public interface IGameInfoInitData
	{
		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x0602CD29 RID: 183593
		// (set) Token: 0x0602CD2A RID: 183594
		int InstanceId { get; set; }

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x0602CD2B RID: 183595
		// (set) Token: 0x0602CD2C RID: 183596
		int RandomSeed { get; set; }

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x0602CD2D RID: 183597
		// (set) Token: 0x0602CD2E RID: 183598
		int MoodMin { get; set; }

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x0602CD2F RID: 183599
		// (set) Token: 0x0602CD30 RID: 183600
		int MoodMax { get; set; }

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x0602CD31 RID: 183601
		// (set) Token: 0x0602CD32 RID: 183602
		int InitMood { get; set; }

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x0602CD33 RID: 183603
		// (set) Token: 0x0602CD34 RID: 183604
		List<MapGridData> MapGrids { get; set; }

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x0602CD35 RID: 183605
		// (set) Token: 0x0602CD36 RID: 183606
		int MapWidth { get; set; }

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x0602CD37 RID: 183607
		// (set) Token: 0x0602CD38 RID: 183608
		int MapHeight { get; set; }

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x0602CD39 RID: 183609
		// (set) Token: 0x0602CD3A RID: 183610
		int PlayerGridIndex { get; set; }

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x0602CD3B RID: 183611
		// (set) Token: 0x0602CD3C RID: 183612
		int TeamLv { get; set; }

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x0602CD3D RID: 183613
		// (set) Token: 0x0602CD3E RID: 183614
		bool InBattle { get; set; }

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x0602CD3F RID: 183615
		// (set) Token: 0x0602CD40 RID: 183616
		int CurrencyItemId { get; set; }

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x0602CD41 RID: 183617
		// (set) Token: 0x0602CD42 RID: 183618
		int MoodRuleId { get; set; }

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x0602CD43 RID: 183619
		// (set) Token: 0x0602CD44 RID: 183620
		int RoleMaxStar { get; set; }

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x0602CD45 RID: 183621
		// (set) Token: 0x0602CD46 RID: 183622
		int RoleLevel { get; set; }
	}
}

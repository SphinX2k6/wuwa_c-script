using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005351 RID: 21329
	[NullableContext(1)]
	public interface IMowingRiskNewBasicBuffTipsData
	{
		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x0603511C RID: 217372
		// (set) Token: 0x0603511D RID: 217373
		bool IsGolden { get; set; }

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x0603511E RID: 217374
		// (set) Token: 0x0603511F RID: 217375
		string NameTextId { get; set; }

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x06035120 RID: 217376
		// (set) Token: 0x06035121 RID: 217377
		string NameHexColor { get; set; }

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x06035122 RID: 217378
		// (set) Token: 0x06035123 RID: 217379
		string IconPath { get; set; }

		// Token: 0x1700675F RID: 26463
		// (get) Token: 0x06035124 RID: 217380
		// (set) Token: 0x06035125 RID: 217381
		string DescriptionTextId { get; set; }

		// Token: 0x17006760 RID: 26464
		// (get) Token: 0x06035126 RID: 217382
		// (set) Token: 0x06035127 RID: 217383
		string[] DescriptionArgs { get; set; }

		// Token: 0x17006761 RID: 26465
		// (get) Token: 0x06035128 RID: 217384
		// (set) Token: 0x06035129 RID: 217385
		string QualityTexPath { get; set; }

		// Token: 0x17006762 RID: 26466
		// (get) Token: 0x0603512A RID: 217386
		// (set) Token: 0x0603512B RID: 217387
		string QualityFlowPath { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D3 RID: 25555
	[NullableContext(1)]
	public interface IMowingRiskNewBasicBuffTipsData
	{
		// Token: 0x170093F9 RID: 37881
		// (get) Token: 0x0604045B RID: 263259
		// (set) Token: 0x0604045C RID: 263260
		bool IsGolden { get; set; }

		// Token: 0x170093FA RID: 37882
		// (get) Token: 0x0604045D RID: 263261
		// (set) Token: 0x0604045E RID: 263262
		string NameTextId { get; set; }

		// Token: 0x170093FB RID: 37883
		// (get) Token: 0x0604045F RID: 263263
		// (set) Token: 0x06040460 RID: 263264
		string NameHexColor { get; set; }

		// Token: 0x170093FC RID: 37884
		// (get) Token: 0x06040461 RID: 263265
		// (set) Token: 0x06040462 RID: 263266
		string IconPath { get; set; }

		// Token: 0x170093FD RID: 37885
		// (get) Token: 0x06040463 RID: 263267
		// (set) Token: 0x06040464 RID: 263268
		string DescriptionTextId { get; set; }

		// Token: 0x170093FE RID: 37886
		// (get) Token: 0x06040465 RID: 263269
		// (set) Token: 0x06040466 RID: 263270
		string[] DescriptionArgs { get; set; }

		// Token: 0x170093FF RID: 37887
		// (get) Token: 0x06040467 RID: 263271
		// (set) Token: 0x06040468 RID: 263272
		string QualityTexPath { get; set; }

		// Token: 0x17009400 RID: 37888
		// (get) Token: 0x06040469 RID: 263273
		// (set) Token: 0x0604046A RID: 263274
		string QualityFlowPath { get; set; }
	}
}

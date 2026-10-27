using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C4 RID: 25540
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceRecommendData : IMowingRiskInstanceRecommendData
	{
		// Token: 0x170093D0 RID: 37840
		// (get) Token: 0x06040401 RID: 263169 RVA: 0x00F8B875 File Offset: 0x00F89A75
		// (set) Token: 0x06040402 RID: 263170 RVA: 0x00F8B87D File Offset: 0x00F89A7D
		public string TextId { get; set; }

		// Token: 0x170093D1 RID: 37841
		// (get) Token: 0x06040403 RID: 263171 RVA: 0x00F8B886 File Offset: 0x00F89A86
		// (set) Token: 0x06040404 RID: 263172 RVA: 0x00F8B88E File Offset: 0x00F89A8E
		public string[] TextArgs { get; set; }

		// Token: 0x170093D2 RID: 37842
		// (get) Token: 0x06040405 RID: 263173 RVA: 0x00F8B897 File Offset: 0x00F89A97
		// (set) Token: 0x06040406 RID: 263174 RVA: 0x00F8B89F File Offset: 0x00F89A9F
		public int RecommendLevel { get; set; }
	}
}

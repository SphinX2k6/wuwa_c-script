using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D8 RID: 22488
	[NullableContext(1)]
	[Nullable(0)]
	public class AccumulatedScoreLineData : IAccumulatedScoreLineData
	{
		// Token: 0x170089DE RID: 35294
		// (get) Token: 0x060392CC RID: 234188 RVA: 0x00D902E5 File Offset: 0x00D8E4E5
		// (set) Token: 0x060392CD RID: 234189 RVA: 0x00D902ED File Offset: 0x00D8E4ED
		public string DescTextId { get; set; }

		// Token: 0x170089DF RID: 35295
		// (get) Token: 0x060392CE RID: 234190 RVA: 0x00D902F6 File Offset: 0x00D8E4F6
		// (set) Token: 0x060392CF RID: 234191 RVA: 0x00D902FE File Offset: 0x00D8E4FE
		public string ScoreText { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D7 RID: 22487
	[NullableContext(1)]
	public interface IAccumulatedScoreLineData
	{
		// Token: 0x170089DC RID: 35292
		// (get) Token: 0x060392C8 RID: 234184
		// (set) Token: 0x060392C9 RID: 234185
		string DescTextId { get; set; }

		// Token: 0x170089DD RID: 35293
		// (get) Token: 0x060392CA RID: 234186
		// (set) Token: 0x060392CB RID: 234187
		string ScoreText { get; set; }
	}
}

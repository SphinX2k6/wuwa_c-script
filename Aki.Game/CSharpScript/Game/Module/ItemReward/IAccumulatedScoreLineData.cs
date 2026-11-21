using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AE RID: 18350
	[NullableContext(1)]
	public interface IAccumulatedScoreLineData
	{
		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x0602E1DC RID: 188892
		// (set) Token: 0x0602E1DD RID: 188893
		string DescTextId { get; set; }

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x0602E1DE RID: 188894
		// (set) Token: 0x0602E1DF RID: 188895
		string ScoreText { get; set; }
	}
}

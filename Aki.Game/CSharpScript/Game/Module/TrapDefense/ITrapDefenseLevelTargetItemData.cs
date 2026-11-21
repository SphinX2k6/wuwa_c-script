using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A10 RID: 14864
	[NullableContext(1)]
	public interface ITrapDefenseLevelTargetItemData
	{
		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x060263D5 RID: 156629
		ITrapDefenseLevelTargetInfo Info { get; }

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x060263D6 RID: 156630
		int TargetValue { get; }

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x060263D7 RID: 156631
		int TargetStar { get; }

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x060263D8 RID: 156632
		bool IsFinish { get; }
	}
}

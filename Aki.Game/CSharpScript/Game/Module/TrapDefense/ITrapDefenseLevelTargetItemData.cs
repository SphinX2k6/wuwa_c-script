using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A68 RID: 19048
	[NullableContext(1)]
	public interface ITrapDefenseLevelTargetItemData
	{
		// Token: 0x17007AA8 RID: 31400
		// (get) Token: 0x06031645 RID: 202309
		ITrapDefenseLevelTargetInfo Info { get; }

		// Token: 0x17007AA9 RID: 31401
		// (get) Token: 0x06031646 RID: 202310
		int TargetValue { get; }

		// Token: 0x17007AAA RID: 31402
		// (get) Token: 0x06031647 RID: 202311
		int TargetStar { get; }

		// Token: 0x17007AAB RID: 31403
		// (get) Token: 0x06031648 RID: 202312
		bool IsFinish { get; }
	}
}

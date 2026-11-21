using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A08 RID: 14856
	[NullableContext(1)]
	public interface ITrapDefenseBdProgressInfo
	{
		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x060263A5 RID: 156581
		TrapDefenseBdData BdData { get; }

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x060263A6 RID: 156582
		bool IsActive { get; }

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x060263A7 RID: 156583
		bool IsShowQualityArrow { get; }

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x060263A8 RID: 156584
		ETrapDefenseResKey QualityArrowRes { get; }
	}
}

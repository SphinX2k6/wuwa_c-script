using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005929 RID: 22825
	public interface ISolarSchoolPrizeAwardData
	{
		// Token: 0x17006BC6 RID: 27590
		// (get) Token: 0x060383F4 RID: 230388
		int ItemId { get; }

		// Token: 0x17006BC7 RID: 27591
		// (get) Token: 0x060383F5 RID: 230389
		int Count { get; }

		// Token: 0x17006BC8 RID: 27592
		// (get) Token: 0x060383F6 RID: 230390
		int Times { get; }

		// Token: 0x17006BC9 RID: 27593
		// (get) Token: 0x060383F7 RID: 230391
		int Rare { get; }
	}
}

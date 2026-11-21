using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02005F78 RID: 24440
	[NullableContext(2)]
	public interface IQteHourglassCompletedQteInfo
	{
		// Token: 0x17006EDE RID: 28382
		// (get) Token: 0x0603AC35 RID: 240693
		// (set) Token: 0x0603AC36 RID: 240694
		int HandleId { get; set; }

		// Token: 0x17006EDF RID: 28383
		// (get) Token: 0x0603AC37 RID: 240695
		// (set) Token: 0x0603AC38 RID: 240696
		int QteId { get; set; }

		// Token: 0x17006EE0 RID: 28384
		// (get) Token: 0x0603AC39 RID: 240697
		// (set) Token: 0x0603AC3A RID: 240698
		bool IsSuccess { get; set; }

		// Token: 0x17006EE1 RID: 28385
		// (get) Token: 0x0603AC3B RID: 240699
		// (set) Token: 0x0603AC3C RID: 240700
		bool IsFail { get; set; }

		// Token: 0x17006EE2 RID: 28386
		// (get) Token: 0x0603AC3D RID: 240701
		// (set) Token: 0x0603AC3E RID: 240702
		Vector StartPos { get; set; }
	}
}

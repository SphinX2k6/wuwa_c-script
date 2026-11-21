using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F85 RID: 24453
	[NullableContext(2)]
	public interface IGuaranteeStopEffectParams
	{
		// Token: 0x17006EEF RID: 28399
		// (get) Token: 0x0603ACA1 RID: 240801
		// (set) Token: 0x0603ACA2 RID: 240802
		int? EffectId { get; set; }

		// Token: 0x17006EF0 RID: 28400
		// (get) Token: 0x0603ACA3 RID: 240803
		// (set) Token: 0x0603ACA4 RID: 240804
		int? ScreenEffectHandle { get; set; }

		// Token: 0x17006EF1 RID: 28401
		// (get) Token: 0x0603ACA5 RID: 240805
		// (set) Token: 0x0603ACA6 RID: 240806
		string Mp4Name { get; set; }
	}
}

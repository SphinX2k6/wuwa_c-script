using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02005F7B RID: 24443
	[NullableContext(1)]
	public interface IHourglassOpenParam
	{
		// Token: 0x17006EE9 RID: 28393
		// (get) Token: 0x0603AC5F RID: 240735
		// (set) Token: 0x0603AC60 RID: 240736
		IQteHourglass Config { get; set; }

		// Token: 0x17006EEA RID: 28394
		// (get) Token: 0x0603AC61 RID: 240737
		// (set) Token: 0x0603AC62 RID: 240738
		bool? AutoStartQte { get; set; }
	}
}

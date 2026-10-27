using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DFC RID: 28156
	[NullableContext(1)]
	public interface IHourglassOpenParam
	{
		// Token: 0x170099E6 RID: 39398
		// (get) Token: 0x06044AFB RID: 281339
		// (set) Token: 0x06044AFC RID: 281340
		IQteHourglass Config { get; set; }

		// Token: 0x170099E7 RID: 39399
		// (get) Token: 0x06044AFD RID: 281341
		// (set) Token: 0x06044AFE RID: 281342
		bool? AutoStartQte { get; set; }
	}
}

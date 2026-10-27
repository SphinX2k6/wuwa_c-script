using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C81 RID: 19585
	[NullableContext(2)]
	public interface ISeasonSwitchJob
	{
		// Token: 0x17007CDD RID: 31965
		// (get) Token: 0x060329CD RID: 207309
		// (set) Token: 0x060329CE RID: 207310
		ESeason TargetSeason { get; set; }

		// Token: 0x17007CDE RID: 31966
		// (get) Token: 0x060329CF RID: 207311
		// (set) Token: 0x060329D0 RID: 207312
		double TargetValue { get; set; }

		// Token: 0x17007CDF RID: 31967
		// (get) Token: 0x060329D1 RID: 207313
		// (set) Token: 0x060329D2 RID: 207314
		double Speed { get; set; }

		// Token: 0x17007CE0 RID: 31968
		// (get) Token: 0x060329D3 RID: 207315
		// (set) Token: 0x060329D4 RID: 207316
		double RemainDistance { get; set; }

		// Token: 0x17007CE1 RID: 31969
		// (get) Token: 0x060329D5 RID: 207317
		// (set) Token: 0x060329D6 RID: 207318
		TSeasonSwitchCallback OnComplete { get; set; }
	}
}

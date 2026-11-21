using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C32 RID: 15410
	[NullableContext(2)]
	public interface ISeasonSwitchJob
	{
		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x06027780 RID: 161664
		// (set) Token: 0x06027781 RID: 161665
		ESeason TargetSeason { get; set; }

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x06027782 RID: 161666
		// (set) Token: 0x06027783 RID: 161667
		double TargetValue { get; set; }

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x06027784 RID: 161668
		// (set) Token: 0x06027785 RID: 161669
		double Speed { get; set; }

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x06027786 RID: 161670
		// (set) Token: 0x06027787 RID: 161671
		double RemainDistance { get; set; }

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x06027788 RID: 161672
		// (set) Token: 0x06027789 RID: 161673
		TSeasonSwitchCallback OnComplete { get; set; }
	}
}

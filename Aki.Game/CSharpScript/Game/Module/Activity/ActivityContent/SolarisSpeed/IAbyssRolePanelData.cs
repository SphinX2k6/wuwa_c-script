using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005042 RID: 20546
	[NullableContext(1)]
	public interface IAbyssRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x060336DE RID: 210654
		// (set) Token: 0x060336DF RID: 210655
		List<IAbyssDescData> MainDescData { get; set; }

		// Token: 0x1700647C RID: 25724
		// (get) Token: 0x060336E0 RID: 210656
		// (set) Token: 0x060336E1 RID: 210657
		List<IAbyssDescData> SubDescData { get; set; }

		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x060336E2 RID: 210658
		// (set) Token: 0x060336E3 RID: 210659
		int LikeCount { get; set; }

		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x060336E4 RID: 210660
		// (set) Token: 0x060336E5 RID: 210661
		int? PlayerTitle { get; set; }

		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x060336E6 RID: 210662
		// (set) Token: 0x060336E7 RID: 210663
		int? PlayerTitleStarLevel { get; set; }

		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x060336E8 RID: 210664
		// (set) Token: 0x060336E9 RID: 210665
		int Sex { get; set; }
	}
}

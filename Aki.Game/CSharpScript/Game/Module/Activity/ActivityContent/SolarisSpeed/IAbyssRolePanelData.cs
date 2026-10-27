using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060C4 RID: 24772
	[NullableContext(1)]
	public interface IAbyssRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x17009119 RID: 37145
		// (get) Token: 0x0603EA1A RID: 256538
		// (set) Token: 0x0603EA1B RID: 256539
		List<IAbyssDescData> MainDescData { get; set; }

		// Token: 0x1700911A RID: 37146
		// (get) Token: 0x0603EA1C RID: 256540
		// (set) Token: 0x0603EA1D RID: 256541
		List<IAbyssDescData> SubDescData { get; set; }

		// Token: 0x1700911B RID: 37147
		// (get) Token: 0x0603EA1E RID: 256542
		// (set) Token: 0x0603EA1F RID: 256543
		int LikeCount { get; set; }

		// Token: 0x1700911C RID: 37148
		// (get) Token: 0x0603EA20 RID: 256544
		// (set) Token: 0x0603EA21 RID: 256545
		int? PlayerTitle { get; set; }

		// Token: 0x1700911D RID: 37149
		// (get) Token: 0x0603EA22 RID: 256546
		// (set) Token: 0x0603EA23 RID: 256547
		int? PlayerTitleStarLevel { get; set; }

		// Token: 0x1700911E RID: 37150
		// (get) Token: 0x0603EA24 RID: 256548
		// (set) Token: 0x0603EA25 RID: 256549
		int Sex { get; set; }
	}
}

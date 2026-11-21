using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200490E RID: 18702
	[NullableContext(1)]
	[Nullable(0)]
	public class MascotCollectInfoData : IMascotCollectInfoData
	{
		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x0602EF19 RID: 192281 RVA: 0x00D197A7 File Offset: 0x00D179A7
		// (set) Token: 0x0602EF1A RID: 192282 RVA: 0x00D197AF File Offset: 0x00D179AF
		public HonamiStoryAreaData AreaData { get; set; }

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x0602EF1B RID: 192283 RVA: 0x00D197B8 File Offset: 0x00D179B8
		// (set) Token: 0x0602EF1C RID: 192284 RVA: 0x00D197C0 File Offset: 0x00D179C0
		public List<HonamiStoryMascotData> MascotDataList { get; set; } = new List<HonamiStoryMascotData>();
	}
}

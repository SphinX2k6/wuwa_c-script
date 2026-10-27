using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005935 RID: 22837
	[NullableContext(1)]
	[Nullable(0)]
	public class MascotCollectInfoData : IMascotCollectInfoData
	{
		// Token: 0x17008AF4 RID: 35572
		// (get) Token: 0x06039FF6 RID: 237558 RVA: 0x00DCA4F3 File Offset: 0x00DC86F3
		// (set) Token: 0x06039FF7 RID: 237559 RVA: 0x00DCA4FB File Offset: 0x00DC86FB
		public HonamiStoryAreaData AreaData { get; set; }

		// Token: 0x17008AF5 RID: 35573
		// (get) Token: 0x06039FF8 RID: 237560 RVA: 0x00DCA504 File Offset: 0x00DC8704
		// (set) Token: 0x06039FF9 RID: 237561 RVA: 0x00DCA50C File Offset: 0x00DC870C
		public List<HonamiStoryMascotData> MascotDataList { get; set; } = new List<HonamiStoryMascotData>();
	}
}

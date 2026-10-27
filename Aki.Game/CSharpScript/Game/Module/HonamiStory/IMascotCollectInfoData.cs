using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005934 RID: 22836
	[NullableContext(1)]
	public interface IMascotCollectInfoData
	{
		// Token: 0x17008AF2 RID: 35570
		// (get) Token: 0x06039FF2 RID: 237554
		// (set) Token: 0x06039FF3 RID: 237555
		HonamiStoryAreaData AreaData { get; set; }

		// Token: 0x17008AF3 RID: 35571
		// (get) Token: 0x06039FF4 RID: 237556
		// (set) Token: 0x06039FF5 RID: 237557
		List<HonamiStoryMascotData> MascotDataList { get; set; }
	}
}

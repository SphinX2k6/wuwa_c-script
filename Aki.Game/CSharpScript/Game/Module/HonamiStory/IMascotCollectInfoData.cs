using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200490D RID: 18701
	[NullableContext(1)]
	public interface IMascotCollectInfoData
	{
		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x0602EF15 RID: 192277
		// (set) Token: 0x0602EF16 RID: 192278
		HonamiStoryAreaData AreaData { get; set; }

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x0602EF17 RID: 192279
		// (set) Token: 0x0602EF18 RID: 192280
		List<HonamiStoryMascotData> MascotDataList { get; set; }
	}
}

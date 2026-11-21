using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004921 RID: 18721
	[NullableContext(1)]
	public interface IHonamiStoryAttrData
	{
		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x0602EF46 RID: 192326
		// (set) Token: 0x0602EF47 RID: 192327
		string Name { get; set; }

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x0602EF48 RID: 192328
		// (set) Token: 0x0602EF49 RID: 192329
		string IconPath { get; set; }

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x0602EF4A RID: 192330
		// (set) Token: 0x0602EF4B RID: 192331
		int OldValue { get; set; }

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x0602EF4C RID: 192332
		// (set) Token: 0x0602EF4D RID: 192333
		int NewValue { get; set; }

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x0602EF4E RID: 192334
		// (set) Token: 0x0602EF4F RID: 192335
		bool IsPercent { get; set; }
	}
}

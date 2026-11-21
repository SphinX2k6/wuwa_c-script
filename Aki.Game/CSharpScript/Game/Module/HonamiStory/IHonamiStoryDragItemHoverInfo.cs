using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004909 RID: 18697
	[NullableContext(1)]
	public interface IHonamiStoryDragItemHoverInfo
	{
		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x0602EEFC RID: 192252
		// (set) Token: 0x0602EEFD RID: 192253
		bool IsValid { get; set; }

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x0602EEFE RID: 192254
		// (set) Token: 0x0602EEFF RID: 192255
		int StartPosition { get; set; }

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x0602EF00 RID: 192256
		// (set) Token: 0x0602EF01 RID: 192257
		int EndPosition { get; set; }

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x0602EF02 RID: 192258
		// (set) Token: 0x0602EF03 RID: 192259
		int Height { get; set; }

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x0602EF04 RID: 192260
		// (set) Token: 0x0602EF05 RID: 192261
		int Width { get; set; }

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x0602EF06 RID: 192262
		// (set) Token: 0x0602EF07 RID: 192263
		List<int> FillPosList { get; set; }
	}
}

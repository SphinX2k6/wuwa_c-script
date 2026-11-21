using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02005F5F RID: 24415
	[NullableContext(1)]
	public interface IItemInspectVisiblePointData
	{
		// Token: 0x17006ED6 RID: 28374
		// (get) Token: 0x0603AB36 RID: 240438
		// (set) Token: 0x0603AB37 RID: 240439
		int TagId { get; set; }

		// Token: 0x17006ED7 RID: 28375
		// (get) Token: 0x0603AB38 RID: 240440
		// (set) Token: 0x0603AB39 RID: 240441
		Vector Location { get; set; }

		// Token: 0x17006ED8 RID: 28376
		// (get) Token: 0x0603AB3A RID: 240442
		// (set) Token: 0x0603AB3B RID: 240443
		bool IsChecked { get; set; }
	}
}

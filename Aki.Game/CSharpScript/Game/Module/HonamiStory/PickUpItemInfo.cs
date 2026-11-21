using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004927 RID: 18727
	[NullableContext(1)]
	[Nullable(0)]
	public class PickUpItemInfo : IPickUpItemInfo
	{
		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x0602EF70 RID: 192368 RVA: 0x00D19954 File Offset: 0x00D17B54
		// (set) Token: 0x0602EF71 RID: 192369 RVA: 0x00D1995C File Offset: 0x00D17B5C
		public HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x0602EF72 RID: 192370 RVA: 0x00D19965 File Offset: 0x00D17B65
		// (set) Token: 0x0602EF73 RID: 192371 RVA: 0x00D1996D File Offset: 0x00D17B6D
		public Entity EntitySelf { get; set; }
	}
}

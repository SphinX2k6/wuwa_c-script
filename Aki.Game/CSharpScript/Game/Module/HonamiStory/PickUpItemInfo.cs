using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200594E RID: 22862
	[NullableContext(1)]
	[Nullable(0)]
	public class PickUpItemInfo : IPickUpItemInfo
	{
		// Token: 0x17008B1C RID: 35612
		// (get) Token: 0x0603A04D RID: 237645 RVA: 0x00DCA6A0 File Offset: 0x00DC88A0
		// (set) Token: 0x0603A04E RID: 237646 RVA: 0x00DCA6A8 File Offset: 0x00DC88A8
		public HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17008B1D RID: 35613
		// (get) Token: 0x0603A04F RID: 237647 RVA: 0x00DCA6B1 File Offset: 0x00DC88B1
		// (set) Token: 0x0603A050 RID: 237648 RVA: 0x00DCA6B9 File Offset: 0x00DC88B9
		public Entity EntitySelf { get; set; }
	}
}

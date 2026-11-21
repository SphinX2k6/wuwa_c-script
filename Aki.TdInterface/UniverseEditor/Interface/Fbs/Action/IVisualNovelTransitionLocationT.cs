using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF5 RID: 32245
	public class IVisualNovelTransitionLocationT
	{
		// Token: 0x1700F189 RID: 61833
		// (get) Token: 0x0603A457 RID: 238679 RVA: 0x007DA030 File Offset: 0x007D8230
		// (set) Token: 0x0603A458 RID: 238680 RVA: 0x007DA038 File Offset: 0x007D8238
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x1700F18A RID: 61834
		// (get) Token: 0x0603A459 RID: 238681 RVA: 0x007DA041 File Offset: 0x007D8241
		// (set) Token: 0x0603A45A RID: 238682 RVA: 0x007DA049 File Offset: 0x007D8249
		public int LocationId { get; set; }

		// Token: 0x1700F18B RID: 61835
		// (get) Token: 0x0603A45B RID: 238683 RVA: 0x007DA052 File Offset: 0x007D8252
		// (set) Token: 0x0603A45C RID: 238684 RVA: 0x007DA05A File Offset: 0x007D825A
		public int TransitionBackgroundId { get; set; }

		// Token: 0x1700F18C RID: 61836
		// (get) Token: 0x0603A45D RID: 238685 RVA: 0x007DA063 File Offset: 0x007D8263
		// (set) Token: 0x0603A45E RID: 238686 RVA: 0x007DA06B File Offset: 0x007D826B
		public byte NullMask { get; set; }

		// Token: 0x0603A45F RID: 238687 RVA: 0x007DA074 File Offset: 0x007D8274
		public IVisualNovelTransitionLocationT()
		{
			this.Type = EVisualNovelTransitionType.Location;
			this.LocationId = 0;
			this.TransitionBackgroundId = 0;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB2 RID: 16306
	public enum IShowTimelineBase_Union : byte
	{
		// Token: 0x0400BA9E RID: 47774
		NONE,
		// Token: 0x0400BA9F RID: 47775
		IShowTimelineBase,
		// Token: 0x0400BAA0 RID: 47776
		IShowTimelineCheckpoint,
		// Token: 0x0400BAA1 RID: 47777
		IShowTimelineInput,
		// Token: 0x0400BAA2 RID: 47778
		IShowTimelineAction,
		// Token: 0x0400BAA3 RID: 47779
		IShowTimelineBuff,
		// Token: 0x0400BAA4 RID: 47780
		IShowTimelineGuide
	}
}

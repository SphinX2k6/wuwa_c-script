using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAA RID: 15274
	public enum IShowTimelineBase_Union : byte
	{
		// Token: 0x0400B121 RID: 45345
		NONE,
		// Token: 0x0400B122 RID: 45346
		IShowTimelineBase,
		// Token: 0x0400B123 RID: 45347
		IShowTimelineCheckpoint,
		// Token: 0x0400B124 RID: 45348
		IShowTimelineInput,
		// Token: 0x0400B125 RID: 45349
		IShowTimelineAction,
		// Token: 0x0400B126 RID: 45350
		IShowTimelineBuff,
		// Token: 0x0400B127 RID: 45351
		IShowTimelineGuide
	}
}

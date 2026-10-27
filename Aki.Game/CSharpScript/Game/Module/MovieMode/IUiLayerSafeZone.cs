using System;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200538B RID: 21387
	public interface IUiLayerSafeZone
	{
		// Token: 0x17008397 RID: 33687
		// (get) Token: 0x06036A26 RID: 223782
		// (set) Token: 0x06036A27 RID: 223783
		float StretchLeft { get; set; }

		// Token: 0x17008398 RID: 33688
		// (get) Token: 0x06036A28 RID: 223784
		// (set) Token: 0x06036A29 RID: 223785
		float StretchRight { get; set; }

		// Token: 0x17008399 RID: 33689
		// (get) Token: 0x06036A2A RID: 223786
		// (set) Token: 0x06036A2B RID: 223787
		float StretchTop { get; set; }

		// Token: 0x1700839A RID: 33690
		// (get) Token: 0x06036A2C RID: 223788
		// (set) Token: 0x06036A2D RID: 223789
		float StretchBottom { get; set; }
	}
}

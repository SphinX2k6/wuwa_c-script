using System;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02005097 RID: 20631
	[Flags]
	public enum ESeamlessFinalizeFlag
	{
		// Token: 0x0401C28B RID: 115339
		None = 0,
		// Token: 0x0401C28C RID: 115340
		ActorAllStop = 1,
		// Token: 0x0401C28D RID: 115341
		ExitMovieMode = 2,
		// Token: 0x0401C28E RID: 115342
		ExitSequenceCamera = 4,
		// Token: 0x0401C28F RID: 115343
		UiRemoveAspectView = 8,
		// Token: 0x0401C290 RID: 115344
		TemplateResetCamera = 16
	}
}

using System;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004067 RID: 16487
	[Flags]
	public enum ESeamlessFinalizeFlag
	{
		// Token: 0x04016CBA RID: 93370
		None = 0,
		// Token: 0x04016CBB RID: 93371
		ActorAllStop = 1,
		// Token: 0x04016CBC RID: 93372
		ExitMovieMode = 2,
		// Token: 0x04016CBD RID: 93373
		ExitSequenceCamera = 4,
		// Token: 0x04016CBE RID: 93374
		UiRemoveAspectView = 8,
		// Token: 0x04016CBF RID: 93375
		TemplateResetCamera = 16
	}
}

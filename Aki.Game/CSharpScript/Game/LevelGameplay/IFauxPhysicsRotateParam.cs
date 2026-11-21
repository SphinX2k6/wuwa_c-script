using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005ACF RID: 23247
	public interface IFauxPhysicsRotateParam
	{
		// Token: 0x17006CEC RID: 27884
		// (get) Token: 0x06039359 RID: 234329
		// (set) Token: 0x0603935A RID: 234330
		EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17006CED RID: 27885
		// (get) Token: 0x0603935B RID: 234331
		// (set) Token: 0x0603935C RID: 234332
		FVector? Origin { get; set; }

		// Token: 0x17006CEE RID: 27886
		// (get) Token: 0x0603935D RID: 234333
		// (set) Token: 0x0603935E RID: 234334
		FVector? RelativeOffset { get; set; }

		// Token: 0x17006CEF RID: 27887
		// (get) Token: 0x0603935F RID: 234335
		// (set) Token: 0x06039360 RID: 234336
		FVector? Force { get; set; }

		// Token: 0x17006CF0 RID: 27888
		// (get) Token: 0x06039361 RID: 234337
		// (set) Token: 0x06039362 RID: 234338
		FVector? Impulse { get; set; }

		// Token: 0x17006CF1 RID: 27889
		// (get) Token: 0x06039363 RID: 234339
		// (set) Token: 0x06039364 RID: 234340
		FVector? Movement { get; set; }
	}
}

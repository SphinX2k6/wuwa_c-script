using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006973 RID: 26995
	public interface IFauxPhysicsRotateParam
	{
		// Token: 0x1700980C RID: 38924
		// (get) Token: 0x06043321 RID: 275233
		// (set) Token: 0x06043322 RID: 275234
		EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x1700980D RID: 38925
		// (get) Token: 0x06043323 RID: 275235
		// (set) Token: 0x06043324 RID: 275236
		FVector? Origin { get; set; }

		// Token: 0x1700980E RID: 38926
		// (get) Token: 0x06043325 RID: 275237
		// (set) Token: 0x06043326 RID: 275238
		FVector? RelativeOffset { get; set; }

		// Token: 0x1700980F RID: 38927
		// (get) Token: 0x06043327 RID: 275239
		// (set) Token: 0x06043328 RID: 275240
		FVector? Force { get; set; }

		// Token: 0x17009810 RID: 38928
		// (get) Token: 0x06043329 RID: 275241
		// (set) Token: 0x0604332A RID: 275242
		FVector? Impulse { get; set; }

		// Token: 0x17009811 RID: 38929
		// (get) Token: 0x0604332B RID: 275243
		// (set) Token: 0x0604332C RID: 275244
		FVector? Movement { get; set; }
	}
}

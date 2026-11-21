using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006026 RID: 24614
	[NullableContext(1)]
	public interface IElementalDebugDrawShapeInfo
	{
		// Token: 0x17006FB4 RID: 28596
		// (get) Token: 0x0603B1D4 RID: 242132
		// (set) Token: 0x0603B1D5 RID: 242133
		UObject Shape { get; set; }

		// Token: 0x17006FB5 RID: 28597
		// (get) Token: 0x0603B1D6 RID: 242134
		// (set) Token: 0x0603B1D7 RID: 242135
		EElementalFieldDebugShapeRole Role { get; set; }
	}
}

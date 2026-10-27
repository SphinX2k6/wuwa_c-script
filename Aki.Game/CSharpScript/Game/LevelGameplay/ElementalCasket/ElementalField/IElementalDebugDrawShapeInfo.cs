using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA6 RID: 28326
	[NullableContext(1)]
	public interface IElementalDebugDrawShapeInfo
	{
		// Token: 0x17009A7D RID: 39549
		// (get) Token: 0x06045033 RID: 282675
		// (set) Token: 0x06045034 RID: 282676
		UObject Shape { get; set; }

		// Token: 0x17009A7E RID: 39550
		// (get) Token: 0x06045035 RID: 282677
		// (set) Token: 0x06045036 RID: 282678
		EElementalFieldDebugShapeRole Role { get; set; }
	}
}

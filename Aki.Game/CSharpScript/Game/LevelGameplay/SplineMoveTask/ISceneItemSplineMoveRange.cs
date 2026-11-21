using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B7B RID: 23419
	[NullableContext(1)]
	internal interface ISceneItemSplineMoveRange<[Nullable(0)] T> where T : Enum
	{
		// Token: 0x17006D99 RID: 28057
		// (get) Token: 0x0603997D RID: 235901
		// (set) Token: 0x0603997E RID: 235902
		T Type { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A1E RID: 27166
	[NullableContext(1)]
	internal interface ISceneItemSplineMoveRange<[Nullable(0)] T> where T : Enum
	{
		// Token: 0x170098B4 RID: 39092
		// (get) Token: 0x0604392F RID: 276783
		// (set) Token: 0x06043930 RID: 276784
		T Type { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BC7 RID: 23495
	[NullableContext(1)]
	public interface IBoxDesc
	{
		// Token: 0x17006E0A RID: 28170
		// (get) Token: 0x06039C04 RID: 236548
		Vector LocationOffset { get; }

		// Token: 0x17006E0B RID: 28171
		// (get) Token: 0x06039C05 RID: 236549
		Vector HalfExtent { get; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6A RID: 27242
	[NullableContext(1)]
	public interface IBoxDesc
	{
		// Token: 0x17009925 RID: 39205
		// (get) Token: 0x06043BB6 RID: 277430
		Vector LocationOffset { get; }

		// Token: 0x17009926 RID: 39206
		// (get) Token: 0x06043BB7 RID: 277431
		Vector HalfExtent { get; }
	}
}

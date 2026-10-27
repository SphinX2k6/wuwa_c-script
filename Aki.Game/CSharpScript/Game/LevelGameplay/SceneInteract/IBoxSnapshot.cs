using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6C RID: 27244
	[NullableContext(1)]
	public interface IBoxSnapshot
	{
		// Token: 0x17009929 RID: 39209
		// (get) Token: 0x06043BBD RID: 277437
		Vector WorldPosition { get; }

		// Token: 0x1700992A RID: 39210
		// (get) Token: 0x06043BBE RID: 277438
		Quat Rotation { get; }

		// Token: 0x1700992B RID: 39211
		// (get) Token: 0x06043BBF RID: 277439
		Vector HalfExtent { get; }
	}
}

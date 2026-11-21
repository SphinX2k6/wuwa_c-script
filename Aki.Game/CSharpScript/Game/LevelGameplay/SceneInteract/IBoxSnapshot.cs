using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BC9 RID: 23497
	[NullableContext(1)]
	public interface IBoxSnapshot
	{
		// Token: 0x17006E0E RID: 28174
		// (get) Token: 0x06039C0B RID: 236555
		Vector WorldPosition { get; }

		// Token: 0x17006E0F RID: 28175
		// (get) Token: 0x06039C0C RID: 236556
		Quat Rotation { get; }

		// Token: 0x17006E10 RID: 28176
		// (get) Token: 0x06039C0D RID: 236557
		Vector HalfExtent { get; }
	}
}

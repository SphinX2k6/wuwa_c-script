using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7E RID: 27262
	public abstract class SceneInteractSearchStrategy
	{
		// Token: 0x17009939 RID: 39225
		// (get) Token: 0x06043C2A RID: 277546
		public abstract int Priority { get; }

		// Token: 0x06043C2B RID: 277547
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract ISceneInteractPoint SelectBest(IReadOnlyList<ISceneInteractPoint> points, ISceneInteractSearchParams searchParams);

		// Token: 0x06043C2C RID: 277548 RVA: 0x01095F6A File Offset: 0x0109416A
		public virtual void Dispose()
		{
		}
	}
}

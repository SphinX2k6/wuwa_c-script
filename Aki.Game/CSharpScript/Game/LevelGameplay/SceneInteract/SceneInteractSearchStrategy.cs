using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BDB RID: 23515
	public abstract class SceneInteractSearchStrategy
	{
		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x06039C78 RID: 236664
		public abstract int Priority { get; }

		// Token: 0x06039C79 RID: 236665
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract ISceneInteractPoint SelectBest(IReadOnlyList<ISceneInteractPoint> points, ISceneInteractSearchParams searchParams);

		// Token: 0x06039C7A RID: 236666 RVA: 0x0103A7AA File Offset: 0x010389AA
		public virtual void Dispose()
		{
		}
	}
}

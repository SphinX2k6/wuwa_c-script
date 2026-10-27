using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02006A93 RID: 27283
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ExploreInteractPointFactory : SceneInteractPointFactory<ExploreInteractPointContext>
	{
		// Token: 0x06043C9B RID: 277659 RVA: 0x01097B35 File Offset: 0x01095D35
		protected override ISceneInteractPoint CreateTyped(ExploreInteractPointContext context)
		{
			return new ExploreInteractPoint(context);
		}
	}
}

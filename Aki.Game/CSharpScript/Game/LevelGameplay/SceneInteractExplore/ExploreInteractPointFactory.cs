using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02005BF0 RID: 23536
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ExploreInteractPointFactory : SceneInteractPointFactory<ExploreInteractPointContext>
	{
		// Token: 0x06039CE9 RID: 236777 RVA: 0x0103C389 File Offset: 0x0103A589
		protected override ISceneInteractPoint CreateTyped(ExploreInteractPointContext context)
		{
			return new ExploreInteractPoint(context);
		}
	}
}

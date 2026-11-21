using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF7 RID: 23543
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PlacedExploreInteractPointFactory : SceneInteractPointFactory<PlacedExploreInteractSkillPointContext>
	{
		// Token: 0x06039D2D RID: 236845 RVA: 0x0103D044 File Offset: 0x0103B244
		protected override ISceneInteractPoint CreateTyped(PlacedExploreInteractSkillPointContext context)
		{
			return new PlacedExploreInteractPoint(context);
		}
	}
}

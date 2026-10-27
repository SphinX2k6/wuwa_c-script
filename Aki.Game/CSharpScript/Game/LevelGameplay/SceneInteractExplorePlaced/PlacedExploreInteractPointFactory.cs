using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02006A9A RID: 27290
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PlacedExploreInteractPointFactory : SceneInteractPointFactory<PlacedExploreInteractSkillPointContext>
	{
		// Token: 0x06043CDF RID: 277727 RVA: 0x010987FC File Offset: 0x010969FC
		protected override ISceneInteractPoint CreateTyped(PlacedExploreInteractSkillPointContext context)
		{
			return new PlacedExploreInteractPoint(context);
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200717F RID: 29055
	public class SceneItemGroupAiComponent : EntityComponent
	{
		// Token: 0x06047017 RID: 290839 RVA: 0x011FAA15 File Offset: 0x011F8C15
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemGroupAiComponent sceneItemGroupAiComponent = (SceneItemGroupAiComponent)componentTemplate;
			return true;
		}
	}
}

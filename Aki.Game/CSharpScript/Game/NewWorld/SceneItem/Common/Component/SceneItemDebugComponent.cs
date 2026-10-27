using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x02007218 RID: 29208
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDebugComponent : EntityComponent
	{
		// Token: 0x06047813 RID: 292883 RVA: 0x01239EE0 File Offset: 0x012380E0
		public string GetTagDebugStrings()
		{
			return base.Entity.GetComponent<LevelTagComponent>().GetTagDebugStrings();
		}

		// Token: 0x06047814 RID: 292884 RVA: 0x01239EF2 File Offset: 0x012380F2
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDebugComponent sceneItemDebugComponent = (SceneItemDebugComponent)componentTemplate;
			return true;
		}
	}
}

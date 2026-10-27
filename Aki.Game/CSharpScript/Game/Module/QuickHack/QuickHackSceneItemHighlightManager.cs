using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F68 RID: 20328
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSceneItemHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x06034134 RID: 213300 RVA: 0x00C36C7C File Offset: 0x00C34E7C
		public override void RefreshTargetsHighlight(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets)
		{
			foreach (EntityHandle entityHandle in lockTargets)
			{
				this.ShowGuideLine(entityHandle);
			}
			foreach (EntityHandle entityHandle2 in onScreenTargets)
			{
				this.ShowGuideLine(entityHandle2);
			}
		}

		// Token: 0x06034135 RID: 213301 RVA: 0x00C36CFC File Offset: 0x00C34EFC
		public override void RemoveAllHighlight()
		{
			foreach (EntityHandle entityHandle in this.ShowGuideLineEntitySet)
			{
				if (entityHandle != null)
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity != null)
					{
						SceneItemQuickHackComponent component = entity.GetComponent<SceneItemQuickHackComponent>();
						if (component != null)
						{
							component.StopGuideLine();
						}
					}
				}
			}
			this.ShowGuideLineEntitySet.Clear();
			this.CheckedEntityIdSet.Clear();
		}

		// Token: 0x06034136 RID: 213302 RVA: 0x00C36D80 File Offset: 0x00C34F80
		private void ShowGuideLine(EntityHandle entityHandle)
		{
			int id = entityHandle.Id;
			if (this.CheckedEntityIdSet.Contains(id))
			{
				return;
			}
			this.CheckedEntityIdSet.Add(id);
			SceneItemQuickHackComponent sceneItemQuickHackComponent;
			if (entityHandle == null)
			{
				sceneItemQuickHackComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				sceneItemQuickHackComponent = ((entity != null) ? entity.GetComponent<SceneItemQuickHackComponent>() : null);
			}
			SceneItemQuickHackComponent sceneItemQuickHackComponent2 = sceneItemQuickHackComponent;
			if (sceneItemQuickHackComponent2 == null)
			{
				return;
			}
			if (sceneItemQuickHackComponent2.ShowGuideLine())
			{
				this.ShowGuideLineEntitySet.Add(entityHandle);
			}
		}

		// Token: 0x0401BAA5 RID: 113317
		private readonly HashSet<int> CheckedEntityIdSet = new HashSet<int>();

		// Token: 0x0401BAA6 RID: 113318
		private readonly HashSet<EntityHandle> ShowGuideLineEntitySet = new HashSet<EntityHandle>();
	}
}

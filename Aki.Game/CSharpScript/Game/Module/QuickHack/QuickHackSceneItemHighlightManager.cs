using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F31 RID: 16177
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSceneItemHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x06028FA2 RID: 167842 RVA: 0x00B8041C File Offset: 0x00B7E61C
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

		// Token: 0x06028FA3 RID: 167843 RVA: 0x00B8049C File Offset: 0x00B7E69C
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

		// Token: 0x06028FA4 RID: 167844 RVA: 0x00B80520 File Offset: 0x00B7E720
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

		// Token: 0x0401647A RID: 91258
		private readonly HashSet<int> CheckedEntityIdSet = new HashSet<int>();

		// Token: 0x0401647B RID: 91259
		private readonly HashSet<EntityHandle> ShowGuideLineEntitySet = new HashSet<EntityHandle>();
	}
}

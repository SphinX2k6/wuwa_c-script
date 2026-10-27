using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7E RID: 20350
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSceneItemOnScreenTargetSelector : QuickHackBaseOnScreenTargetSelector
	{
		// Token: 0x060341D6 RID: 213462 RVA: 0x00C3B394 File Offset: 0x00C39594
		protected override void OnInit()
		{
			this.EntityTypeQuery = EEntityTypeQuery.SceneItem;
			this.TargetHackType = EQuickHackTargetType.SceneItem;
		}

		// Token: 0x060341D7 RID: 213463 RVA: 0x00C3B3A8 File Offset: 0x00C395A8
		protected override bool CheckEntityValid(EntityHandle entityHandle)
		{
			if (!entityHandle.IsInit)
			{
				return false;
			}
			WorldEntity entity = entityHandle.Entity;
			return !entity.GetComponent<CreatureDataComponent>().GetRemoveState() && entity.Active && entity.GetComponent<SceneItemQuickHackComponent>() != null && entity.GetComponent<SceneItemActorComponent>() != null;
		}

		// Token: 0x060341D8 RID: 213464 RVA: 0x00C3B3F4 File Offset: 0x00C395F4
		protected override bool CheckEntityRendered(EntityHandle entityHandle)
		{
			SceneItemActorComponent component = entityHandle.Entity.GetComponent<SceneItemActorComponent>();
			component.TryRefreshShowActor();
			AActor curLevelPrefabShowActor = component.CurLevelPrefabShowActor;
			return curLevelPrefabShowActor != null && curLevelPrefabShowActor.IsValid() && curLevelPrefabShowActor.WasRecentlyRenderedOnScreen(0.2f);
		}

		// Token: 0x060341D9 RID: 213465 RVA: 0x00C3B430 File Offset: 0x00C39630
		protected override FVectorDouble GetEntityLocation(EntityHandle entityHandle)
		{
			SceneItemActorComponent component = entityHandle.Entity.GetComponent<SceneItemActorComponent>();
			AActor referenceActor = component.GetReferenceActor("Center");
			if (referenceActor == null || !referenceActor.IsValid())
			{
				return component.ActorLocation;
			}
			return referenceActor.D_K2_GetActorLocation();
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F47 RID: 16199
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSceneItemOnScreenTargetSelector : QuickHackBaseOnScreenTargetSelector
	{
		// Token: 0x06029044 RID: 168004 RVA: 0x00B84B40 File Offset: 0x00B82D40
		protected override void OnInit()
		{
			this.EntityTypeQuery = EEntityTypeQuery.SceneItem;
			this.TargetHackType = EQuickHackTargetType.SceneItem;
		}

		// Token: 0x06029045 RID: 168005 RVA: 0x00B84B54 File Offset: 0x00B82D54
		protected override bool CheckEntityValid(EntityHandle entityHandle)
		{
			if (!entityHandle.IsInit)
			{
				return false;
			}
			WorldEntity entity = entityHandle.Entity;
			return !entity.GetComponent<CreatureDataComponent>().GetRemoveState() && entity.Active && entity.GetComponent<SceneItemQuickHackComponent>() != null && entity.GetComponent<SceneItemActorComponent>() != null;
		}

		// Token: 0x06029046 RID: 168006 RVA: 0x00B84BA0 File Offset: 0x00B82DA0
		protected override bool CheckEntityRendered(EntityHandle entityHandle)
		{
			SceneItemActorComponent component = entityHandle.Entity.GetComponent<SceneItemActorComponent>();
			component.TryRefreshShowActor();
			AActor curLevelPrefabShowActor = component.CurLevelPrefabShowActor;
			return curLevelPrefabShowActor != null && curLevelPrefabShowActor.IsValid() && curLevelPrefabShowActor.WasRecentlyRenderedOnScreen(0.2f);
		}

		// Token: 0x06029047 RID: 168007 RVA: 0x00B84BDC File Offset: 0x00B82DDC
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

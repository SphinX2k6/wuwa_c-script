using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007185 RID: 29061
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMonsterGachaItemComponent : EntityComponent
	{
		// Token: 0x060470EE RID: 291054 RVA: 0x01203EFC File Offset: 0x012020FC
		protected override bool OnInitData(IEntityArgs args = null)
		{
			MonsterGachaItemComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemMonsterGachaItemComponent>() as MonsterGachaItemComponent;
			this.Config = config;
			return true;
		}

		// Token: 0x060470EF RID: 291055 RVA: 0x01203F22 File Offset: 0x01202122
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			return true;
		}

		// Token: 0x060470F0 RID: 291056 RVA: 0x01203F58 File Offset: 0x01202158
		private void OnSceneInteractionLoadCompleted()
		{
			ResourceSystem.Instance.LoadAsync<ItemMaterialControllerActorData>(this.Config.MaterialDataPath, delegate([Nullable(2)] ItemMaterialControllerActorData result, string _)
			{
				if (result == null)
				{
					return;
				}
				TArray<AActor> sceneInteractionAllActorsInLevel = SceneInteractionManager.Get().GetSceneInteractionAllActorsInLevel(this.ActorComp.GetSceneInteractionLevelHandleId());
				for (int i = 0; i < sceneInteractionAllActorsInLevel.Num(); i++)
				{
					AActor actor = sceneInteractionAllActorsInLevel.Get(i);
					ItemMaterialManager.Instance.AddMaterialData(actor, result);
				}
			}, 100, "js_undefined");
		}

		// Token: 0x060470F1 RID: 291057 RVA: 0x01203F84 File Offset: 0x01202184
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMonsterGachaItemComponent sceneItemMonsterGachaItemComponent = (SceneItemMonsterGachaItemComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemMonsterGachaItemComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MonsterGachaItemComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemMonsterGachaItemComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040255B3 RID: 153011
		private MonsterGachaItemComponent Config;

		// Token: 0x040255B4 RID: 153012
		private SceneItemActorComponent ActorComp;
	}
}

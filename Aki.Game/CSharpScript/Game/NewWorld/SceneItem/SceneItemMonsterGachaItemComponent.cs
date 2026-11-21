using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006239 RID: 25145
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemMonsterGachaItemComponent : EntityComponent
	{
		// Token: 0x0603C995 RID: 248213 RVA: 0x0115E0A0 File Offset: 0x0115C2A0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			MonsterGachaItemComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemMonsterGachaItemComponent>() as MonsterGachaItemComponent;
			this.Config = config;
			return true;
		}

		// Token: 0x0603C996 RID: 248214 RVA: 0x0115E0C6 File Offset: 0x0115C2C6
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			return true;
		}

		// Token: 0x0603C997 RID: 248215 RVA: 0x0115E0FC File Offset: 0x0115C2FC
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

		// Token: 0x0603C998 RID: 248216 RVA: 0x0115E128 File Offset: 0x0115C328
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMonsterGachaItemComponent sceneItemMonsterGachaItemComponent = (SceneItemMonsterGachaItemComponent)componentTemplate;
			if (sceneItemMonsterGachaItemComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemMonsterGachaItemComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700728F RID: 29327
		// (get) Token: 0x0603C999 RID: 248217 RVA: 0x0115E19E File Offset: 0x0115C39E
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402021A RID: 131610
		private MonsterGachaItemComponent Config;

		// Token: 0x0402021B RID: 131611
		private SceneItemActorComponent ActorComp;
	}
}

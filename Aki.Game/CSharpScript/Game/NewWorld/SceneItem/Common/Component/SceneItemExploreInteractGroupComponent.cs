using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x0200721B RID: 29211
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemExploreInteractGroupComponent : EntityComponent, ISceneInteractPointSource
	{
		// Token: 0x06047836 RID: 292918 RVA: 0x0123BEBE File Offset: 0x0123A0BE
		public IReadOnlyList<ISceneInteractPoint> GetInteractPoints()
		{
			return this.InteractPoints;
		}

		// Token: 0x06047837 RID: 292919 RVA: 0x0123BEC8 File Offset: 0x0123A0C8
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData createEntityData = (args != null) ? args.GetP1<CreateEntityData>() : null;
			this.Config = (((createEntityData != null) ? createEntityData.GetParam<SceneItemExploreInteractGroupComponent>() : null) as ExploreSkillInteractGroupComponent);
			return this.Config != null;
		}

		// Token: 0x06047838 RID: 292920 RVA: 0x0123BF02 File Offset: 0x0123A102
		protected override bool OnStart()
		{
			this.CreateInteractPoints();
			SceneInteractPointManager.Instance.Register(this);
			return true;
		}

		// Token: 0x06047839 RID: 292921 RVA: 0x0123BF18 File Offset: 0x0123A118
		protected override void OnActivate()
		{
			foreach (IExploreInteractPointSource exploreInteractPointSource in this.ExtraSource)
			{
				exploreInteractPointSource.Activate();
			}
		}

		// Token: 0x0604783A RID: 292922 RVA: 0x0123BF68 File Offset: 0x0123A168
		protected override bool OnEnd()
		{
			SceneInteractPointManager.Instance.Unregister(this);
			this.InteractPoints.Clear();
			foreach (IExploreInteractPointSource exploreInteractPointSource in this.ExtraSource)
			{
				exploreInteractPointSource.Dispose();
			}
			this.ExtraSource.Clear();
			return true;
		}

		// Token: 0x0604783B RID: 292923 RVA: 0x0123BFDC File Offset: 0x0123A1DC
		private void CreateInteractPoints()
		{
			ExploreSkillInteractGroupComponent config = this.Config;
			List<IExploreSkillInteract> list = (config != null) ? config.ExploreSkillInteractList : null;
			if (list == null)
			{
				return;
			}
			this.InteractPoints.Clear();
			this.ExtraSource.Clear();
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(base.Entity.Id);
			if (entityById == null)
			{
				return;
			}
			foreach (IExploreSkillInteract exploreSkillInteract in list)
			{
				IExploreSkillInteractType option = exploreSkillInteract.Option;
				if (option.Type == EExploreSkillInteractType.FoxJumpInteractPoint && (option as IFoxJumpInteractPoint).PositionConfig.Type == EFoxJumpInteractPointRelationType.PathDrivenSpawnedActor)
				{
					this.ExtraSource.Add(new PathDrivenPlaceExploreInteractSource(entityById, exploreSkillInteract, (IFoxJumpPositionOnPathDrivenSpawnedActor)(option as IFoxJumpInteractPoint).PositionConfig));
				}
				else
				{
					ISceneInteractPoint sceneInteractPoint = SceneInteractPointFactoryRegistry.Instance.Create(new ExploreInteractPointContext(exploreSkillInteract, entityById));
					if (sceneInteractPoint != null)
					{
						this.InteractPoints.Add(sceneInteractPoint);
					}
				}
			}
		}

		// Token: 0x0604783C RID: 292924 RVA: 0x0123C0E0 File Offset: 0x0123A2E0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemExploreInteractGroupComponent sceneItemExploreInteractGroupComponent = (SceneItemExploreInteractGroupComponent)componentTemplate;
			if (base.CanResetComponentProperty("InteractPoints") && sceneItemExploreInteractGroupComponent.InteractPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ISceneInteractPoint>>(this.InteractPoints), "InteractPoints"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ExtraSource") && sceneItemExploreInteractGroupComponent.ExtraSource != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<IExploreInteractPointSource>>(this.ExtraSource), "ExtraSource"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemExploreInteractGroupComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ExploreSkillInteractGroupComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040259FA RID: 154106
		private readonly List<ISceneInteractPoint> InteractPoints = new List<ISceneInteractPoint>();

		// Token: 0x040259FB RID: 154107
		private readonly List<IExploreInteractPointSource> ExtraSource = new List<IExploreInteractPointSource>();

		// Token: 0x040259FC RID: 154108
		[Nullable(2)]
		private ExploreSkillInteractGroupComponent Config;
	}
}

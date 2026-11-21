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
	// Token: 0x020062D0 RID: 25296
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemExploreInteractGroupComponent : EntityComponent, ISceneInteractPointSource
	{
		// Token: 0x0603D15E RID: 250206 RVA: 0x0119554A File Offset: 0x0119374A
		public IReadOnlyList<ISceneInteractPoint> GetInteractPoints()
		{
			return this.InteractPoints;
		}

		// Token: 0x0603D15F RID: 250207 RVA: 0x01195554 File Offset: 0x01193754
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData createEntityData = (args != null) ? args.GetP1<CreateEntityData>() : null;
			this.Config = (((createEntityData != null) ? createEntityData.GetParam<SceneItemExploreInteractGroupComponent>() : null) as ExploreSkillInteractGroupComponent);
			return this.Config != null;
		}

		// Token: 0x0603D160 RID: 250208 RVA: 0x0119558E File Offset: 0x0119378E
		protected override bool OnStart()
		{
			this.CreateInteractPoints();
			SceneInteractPointManager.Instance.Register(this);
			return true;
		}

		// Token: 0x0603D161 RID: 250209 RVA: 0x011955A4 File Offset: 0x011937A4
		protected override void OnActivate()
		{
			foreach (IExploreInteractPointSource exploreInteractPointSource in this.ExtraSource)
			{
				exploreInteractPointSource.Activate();
			}
		}

		// Token: 0x0603D162 RID: 250210 RVA: 0x011955F4 File Offset: 0x011937F4
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

		// Token: 0x0603D163 RID: 250211 RVA: 0x01195668 File Offset: 0x01193868
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

		// Token: 0x0603D164 RID: 250212 RVA: 0x0119576C File Offset: 0x0119396C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemExploreInteractGroupComponent sceneItemExploreInteractGroupComponent = (SceneItemExploreInteractGroupComponent)componentTemplate;
			if (sceneItemExploreInteractGroupComponent.InteractPoints != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractPoints), "InteractPoints"))
			{
				return false;
			}
			if (sceneItemExploreInteractGroupComponent.ExtraSource != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExtraSource), "ExtraSource"))
			{
				return false;
			}
			if (sceneItemExploreInteractGroupComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170073A5 RID: 29605
		// (get) Token: 0x0603D165 RID: 250213 RVA: 0x011957FB File Offset: 0x011939FB
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073A6 RID: 29606
		// (get) Token: 0x0603D166 RID: 250214 RVA: 0x011957FE File Offset: 0x011939FE
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073A7 RID: 29607
		// (get) Token: 0x0603D167 RID: 250215 RVA: 0x01195801 File Offset: 0x01193A01
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020669 RID: 132713
		private readonly List<ISceneInteractPoint> InteractPoints = new List<ISceneInteractPoint>();

		// Token: 0x0402066A RID: 132714
		private readonly List<IExploreInteractPointSource> ExtraSource = new List<IExploreInteractPointSource>();

		// Token: 0x0402066B RID: 132715
		[Nullable(2)]
		private ExploreSkillInteractGroupComponent Config;
	}
}

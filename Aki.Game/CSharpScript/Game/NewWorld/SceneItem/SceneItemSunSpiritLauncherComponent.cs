using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SunSpirit;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007194 RID: 29076
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemSunSpiritLauncherComponent : EntityComponent
	{
		// Token: 0x0604723A RID: 291386 RVA: 0x01211374 File Offset: 0x0120F574
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData p = args.GetP1<CreateEntityData>();
			this.LauncherConfig = (p.GetParam<SceneItemSunSpiritLauncherComponent>() as SunSpiritLauncherComponent);
			return true;
		}

		// Token: 0x0604723B RID: 291387 RVA: 0x0121139A File Offset: 0x0120F59A
		protected override bool OnInit()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			return true;
		}

		// Token: 0x0604723C RID: 291388 RVA: 0x012113B0 File Offset: 0x0120F5B0
		public bool GetHintViewLocation(Vector outVec)
		{
			if (this.ActorComp == null)
			{
				return false;
			}
			AActor referenceActor = this.ActorComp.GetReferenceActor("HintViewAnchor");
			if (referenceActor != null)
			{
				FVectorDouble fvectorDouble = referenceActor.D_K2_GetActorLocation();
				outVec.FromUeVector(fvectorDouble);
			}
			else
			{
				outVec.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			return true;
		}

		// Token: 0x0604723D RID: 291389 RVA: 0x012113FE File Offset: 0x0120F5FE
		public bool GetCanBeWatchSelect()
		{
			if (this.ActorComp != null)
			{
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp == null || !actorComp.GetIsSceneInteractionLoadCompleted())
				{
					return false;
				}
			}
			return this.GetTargetGear() != null;
		}

		// Token: 0x0604723E RID: 291390 RVA: 0x0121142C File Offset: 0x0120F62C
		public int GetNumOfNeededSunSpirit()
		{
			SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
			if (launcherConfig == null)
			{
				return 0;
			}
			return launcherConfig.NeedsCount;
		}

		// Token: 0x0604723F RID: 291391 RVA: 0x01211440 File Offset: 0x0120F640
		[NullableContext(2)]
		public SceneItemSunSpiritGearComponent GetTargetGear()
		{
			SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
			bool flag = (((launcherConfig != null) ? new int?(launcherConfig.SunSpiritGearId) : null) ?? 0) == 0;
			if (flag)
			{
				return null;
			}
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.LauncherConfig.SunSpiritGearId) : null;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return null;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<SceneItemSunSpiritGearComponent>();
		}

		// Token: 0x06047240 RID: 291392 RVA: 0x012114CC File Offset: 0x0120F6CC
		public bool CheckIsSunSpiritOccupiedByTargetGear(SunSpiritData sunSpiritData)
		{
			SunSpiritOccupiedByGearState sunSpiritOccupiedByGearState = sunSpiritData.GetSunSpiritState() as SunSpiritOccupiedByGearState;
			if (sunSpiritOccupiedByGearState != null)
			{
				int gearConfigId = sunSpiritOccupiedByGearState.GearConfigId;
				SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
				int? num = (launcherConfig != null) ? new int?(launcherConfig.SunSpiritGearId) : null;
				if (gearConfigId == num.GetValueOrDefault() & num != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06047241 RID: 291393 RVA: 0x01211524 File Offset: 0x0120F724
		public bool CheckIsSunSpiritFlyingFromPlayerToTargetGear(SunSpiritData sunSpiritData)
		{
			SunSpiritFlyingToGearState sunSpiritFlyingToGearState = sunSpiritData.GetSunSpiritState() as SunSpiritFlyingToGearState;
			if (sunSpiritFlyingToGearState != null)
			{
				int gearConfigId = sunSpiritFlyingToGearState.GearConfigId;
				SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
				int? num = (launcherConfig != null) ? new int?(launcherConfig.SunSpiritGearId) : null;
				if (gearConfigId == num.GetValueOrDefault() & num != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06047242 RID: 291394 RVA: 0x0121157C File Offset: 0x0120F77C
		public bool CheckIsSunSpiritOccupiedByPlayer(SunSpiritData sunSpiritData)
		{
			return sunSpiritData.GetSunSpiritState() is SunSpiritOccupiedByPlayerState;
		}

		// Token: 0x06047243 RID: 291395 RVA: 0x01211590 File Offset: 0x0120F790
		public bool CheckIsSunSpiritFlyingFromTargetGearToPlayer(SunSpiritData sunSpiritData)
		{
			SunSpiritFlyingToPlayerState sunSpiritFlyingToPlayerState = sunSpiritData.GetSunSpiritState() as SunSpiritFlyingToPlayerState;
			if (sunSpiritFlyingToPlayerState != null)
			{
				int gearConfigId = sunSpiritFlyingToPlayerState.GearConfigId;
				SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
				int? num = (launcherConfig != null) ? new int?(launcherConfig.SunSpiritGearId) : null;
				if (gearConfigId == num.GetValueOrDefault() & num != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06047244 RID: 291396 RVA: 0x012115E8 File Offset: 0x0120F7E8
		public int GetNumOfSunSpiritRelatedToLauncher(bool bIncludeSunSpiritOccupiedByTargetGear, bool bIncludeSunSpiritOccupiedByPlayer, bool bIncludeSunSpiritFlyingFromPlayerToTargetGear, bool bIncludeSunSpiritFlyingFromTargetGearToPlayer)
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			int playerId = CreatureModel.Instance.GetPlayerId();
			SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
			return instance.GetSunSpiritNumByPlayerIdAndAreaId(playerId, (launcherConfig != null) ? launcherConfig.AreaId : 0, true, (SunSpiritData sunSpiritData) => (bIncludeSunSpiritOccupiedByTargetGear && this.CheckIsSunSpiritOccupiedByTargetGear(sunSpiritData)) || (bIncludeSunSpiritOccupiedByPlayer && this.CheckIsSunSpiritOccupiedByPlayer(sunSpiritData)) || (bIncludeSunSpiritFlyingFromPlayerToTargetGear && this.CheckIsSunSpiritFlyingFromPlayerToTargetGear(sunSpiritData)) || (bIncludeSunSpiritFlyingFromTargetGearToPlayer && this.CheckIsSunSpiritFlyingFromTargetGearToPlayer(sunSpiritData)));
		}

		// Token: 0x06047245 RID: 291397 RVA: 0x01211654 File Offset: 0x0120F854
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemSunSpiritLauncherComponent sceneItemSunSpiritLauncherComponent = (SceneItemSunSpiritLauncherComponent)componentTemplate;
			if (base.CanResetComponentProperty("LauncherConfig"))
			{
				if (sceneItemSunSpiritLauncherComponent.LauncherConfig == null)
				{
					this.LauncherConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SunSpiritLauncherComponent>(this.LauncherConfig), "LauncherConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemSunSpiritLauncherComponent.ActorComp == null)
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

		// Token: 0x0402566C RID: 153196
		[Nullable(2)]
		private SunSpiritLauncherComponent LauncherConfig;

		// Token: 0x0402566D RID: 153197
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;
	}
}

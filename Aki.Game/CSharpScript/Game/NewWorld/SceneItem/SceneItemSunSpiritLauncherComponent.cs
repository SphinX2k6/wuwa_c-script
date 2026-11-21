using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SunSpirit;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006248 RID: 25160
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemSunSpiritLauncherComponent : EntityComponent
	{
		// Token: 0x0603CB0D RID: 248589 RVA: 0x0116ADA4 File Offset: 0x01168FA4
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData p = args.GetP1<CreateEntityData>();
			this.LauncherConfig = (p.GetParam<SceneItemSunSpiritLauncherComponent>() as SunSpiritLauncherComponent);
			return true;
		}

		// Token: 0x0603CB0E RID: 248590 RVA: 0x0116ADCA File Offset: 0x01168FCA
		protected override bool OnInit()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			return true;
		}

		// Token: 0x0603CB0F RID: 248591 RVA: 0x0116ADE0 File Offset: 0x01168FE0
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

		// Token: 0x0603CB10 RID: 248592 RVA: 0x0116AE2E File Offset: 0x0116902E
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

		// Token: 0x0603CB11 RID: 248593 RVA: 0x0116AE5C File Offset: 0x0116905C
		public int GetNumOfNeededSunSpirit()
		{
			SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
			if (launcherConfig == null)
			{
				return 0;
			}
			return launcherConfig.NeedsCount;
		}

		// Token: 0x0603CB12 RID: 248594 RVA: 0x0116AE70 File Offset: 0x01169070
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

		// Token: 0x0603CB13 RID: 248595 RVA: 0x0116AEFC File Offset: 0x011690FC
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

		// Token: 0x0603CB14 RID: 248596 RVA: 0x0116AF54 File Offset: 0x01169154
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

		// Token: 0x0603CB15 RID: 248597 RVA: 0x0116AFAC File Offset: 0x011691AC
		public bool CheckIsSunSpiritOccupiedByPlayer(SunSpiritData sunSpiritData)
		{
			return sunSpiritData.GetSunSpiritState() is SunSpiritOccupiedByPlayerState;
		}

		// Token: 0x0603CB16 RID: 248598 RVA: 0x0116AFC0 File Offset: 0x011691C0
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

		// Token: 0x0603CB17 RID: 248599 RVA: 0x0116B018 File Offset: 0x01169218
		public int GetNumOfSunSpiritRelatedToLauncher(bool bIncludeSunSpiritOccupiedByTargetGear, bool bIncludeSunSpiritOccupiedByPlayer, bool bIncludeSunSpiritFlyingFromPlayerToTargetGear, bool bIncludeSunSpiritFlyingFromTargetGearToPlayer)
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			int playerId = CreatureModel.Instance.GetPlayerId();
			SunSpiritLauncherComponent launcherConfig = this.LauncherConfig;
			return instance.GetSunSpiritNumByPlayerIdAndAreaId(playerId, (launcherConfig != null) ? launcherConfig.AreaId : 0, true, (SunSpiritData sunSpiritData) => (bIncludeSunSpiritOccupiedByTargetGear && this.CheckIsSunSpiritOccupiedByTargetGear(sunSpiritData)) || (bIncludeSunSpiritOccupiedByPlayer && this.CheckIsSunSpiritOccupiedByPlayer(sunSpiritData)) || (bIncludeSunSpiritFlyingFromPlayerToTargetGear && this.CheckIsSunSpiritFlyingFromPlayerToTargetGear(sunSpiritData)) || (bIncludeSunSpiritFlyingFromTargetGearToPlayer && this.CheckIsSunSpiritFlyingFromTargetGearToPlayer(sunSpiritData)));
		}

		// Token: 0x0603CB18 RID: 248600 RVA: 0x0116B084 File Offset: 0x01169284
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemSunSpiritLauncherComponent sceneItemSunSpiritLauncherComponent = (SceneItemSunSpiritLauncherComponent)componentTemplate;
			if (sceneItemSunSpiritLauncherComponent.LauncherConfig == null)
			{
				this.LauncherConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LauncherConfig), "LauncherConfig"))
			{
				return false;
			}
			if (sceneItemSunSpiritLauncherComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x0603CB19 RID: 248601 RVA: 0x0116B0FA File Offset: 0x011692FA
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202D3 RID: 131795
		[Nullable(2)]
		private SunSpiritLauncherComponent LauncherConfig;

		// Token: 0x040202D4 RID: 131796
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;
	}
}

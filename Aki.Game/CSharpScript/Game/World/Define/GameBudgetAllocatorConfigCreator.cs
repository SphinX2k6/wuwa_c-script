using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02004532 RID: 17714
	[NullableContext(1)]
	[Nullable(0)]
	public class GameBudgetAllocatorConfigCreator : Singleton
	{
		// Token: 0x1700751C RID: 29980
		// (get) Token: 0x0602DC19 RID: 187417 RVA: 0x00A8318D File Offset: 0x00A8138D
		public TsGameBudgetGroupConfigCache TsNormalEntityGroupConfig
		{
			get
			{
				return this.TsNormalEntityGroupConfigInternal;
			}
		}

		// Token: 0x1700751D RID: 29981
		// (get) Token: 0x0602DC1A RID: 187418 RVA: 0x00A83195 File Offset: 0x00A81395
		public TsGameBudgetGroupConfigCache TsBossEntityGroupConfig
		{
			get
			{
				return this.TsBossEntityGroupConfigInternal;
			}
		}

		// Token: 0x1700751E RID: 29982
		// (get) Token: 0x0602DC1B RID: 187419 RVA: 0x00A8319D File Offset: 0x00A8139D
		public TsGameBudgetGroupConfigCache TsCharacterEntityGroupConfig
		{
			get
			{
				return this.TsCharacterEntityGroupConfigInternal;
			}
		}

		// Token: 0x1700751F RID: 29983
		// (get) Token: 0x0602DC1C RID: 187420 RVA: 0x00A831A5 File Offset: 0x00A813A5
		public TsGameBudgetGroupConfigCache TsNormalNpcEntityGroupConfig
		{
			get
			{
				return this.TsNormalNpcEntityGroupConfigInternal;
			}
		}

		// Token: 0x17007520 RID: 29984
		// (get) Token: 0x0602DC1D RID: 187421 RVA: 0x00A831AD File Offset: 0x00A813AD
		public TsGameBudgetGroupConfigCache TsSimpleNpcEntityGroupConfig
		{
			get
			{
				return this.TsSimpleNpcEntityGroupConfigInternal;
			}
		}

		// Token: 0x17007521 RID: 29985
		// (get) Token: 0x0602DC1E RID: 187422 RVA: 0x00A831B5 File Offset: 0x00A813B5
		public TsGameBudgetGroupConfigCache TsFightEffectGroupConfig
		{
			get
			{
				return this.TsFightEffectGroupConfigInternal;
			}
		}

		// Token: 0x17007522 RID: 29986
		// (get) Token: 0x0602DC1F RID: 187423 RVA: 0x00A831BD File Offset: 0x00A813BD
		public TsGameBudgetGroupConfigCache TsEffectGroupConfig
		{
			get
			{
				return this.TsEffectGroupConfigInternal;
			}
		}

		// Token: 0x17007523 RID: 29987
		// (get) Token: 0x0602DC20 RID: 187424 RVA: 0x00A831C5 File Offset: 0x00A813C5
		public TsGameBudgetGroupConfigCache TsEffectInportanceGroupConfig
		{
			get
			{
				return this.TsEffectInportanceGroupConfigInternal;
			}
		}

		// Token: 0x17007524 RID: 29988
		// (get) Token: 0x0602DC21 RID: 187425 RVA: 0x00A831CD File Offset: 0x00A813CD
		public TsGameBudgetGroupConfigCache TsAlwaysTickConfig
		{
			get
			{
				return this.TsAlwaysTickConfigInternal;
			}
		}

		// Token: 0x17007525 RID: 29989
		// (get) Token: 0x0602DC22 RID: 187426 RVA: 0x00A831D5 File Offset: 0x00A813D5
		public TsGameBudgetGroupConfigCache TsPlayerAlwaysTickConfig
		{
			get
			{
				return this.TsPlayerAlwaysTickConfigInternal;
			}
		}

		// Token: 0x17007526 RID: 29990
		// (get) Token: 0x0602DC23 RID: 187427 RVA: 0x00A831DD File Offset: 0x00A813DD
		public TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickConfig
		{
			get
			{
				return this.TsNormalEntityAlwaysTickConfigInternal;
			}
		}

		// Token: 0x17007527 RID: 29991
		// (get) Token: 0x0602DC24 RID: 187428 RVA: 0x00A831E5 File Offset: 0x00A813E5
		public TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickWithoutNotRenderedConfig
		{
			get
			{
				return this.TsNormalEntityAlwaysTickWithoutNotRenderedConfigInternal;
			}
		}

		// Token: 0x17007528 RID: 29992
		// (get) Token: 0x0602DC25 RID: 187429 RVA: 0x00A831ED File Offset: 0x00A813ED
		public TsGameBudgetGroupConfigCache TsIdleExecConfig
		{
			get
			{
				return this.TsIdleExecConfigInternal;
			}
		}

		// Token: 0x17007529 RID: 29993
		// (get) Token: 0x0602DC26 RID: 187430 RVA: 0x00A831F5 File Offset: 0x00A813F5
		public TsGameBudgetGroupConfigCache TsAlwaysTick2Config
		{
			get
			{
				return this.TsAlwaysTick2ConfigInternal;
			}
		}

		// Token: 0x1700752A RID: 29994
		// (get) Token: 0x0602DC27 RID: 187431 RVA: 0x00A831FD File Offset: 0x00A813FD
		public TsGameBudgetGroupConfigCache TsHUDTickConfig
		{
			get
			{
				return this.TsHUDTickConfigInternal;
			}
		}

		// Token: 0x1700752B RID: 29995
		// (get) Token: 0x0602DC28 RID: 187432 RVA: 0x00A83205 File Offset: 0x00A81405
		public TsGameBudgetGroupConfigCache TsCharacterRenderConfig
		{
			get
			{
				return this.TsCharacterRenderConfigInternal;
			}
		}

		// Token: 0x1700752C RID: 29996
		// (get) Token: 0x0602DC29 RID: 187433 RVA: 0x00A8320D File Offset: 0x00A8140D
		public TsGameBudgetGroupConfigCache TsNpcRenderConfig
		{
			get
			{
				return this.TsNpcRenderConfigInternal;
			}
		}

		// Token: 0x1700752D RID: 29997
		// (get) Token: 0x0602DC2A RID: 187434 RVA: 0x00A83215 File Offset: 0x00A81415
		public TsGameBudgetGroupConfigCache TsStabilizeLowEntityGroupConfig
		{
			get
			{
				return this.TsStabilizeLowEntityGroupConfigInternal;
			}
		}

		// Token: 0x1700752E RID: 29998
		// (get) Token: 0x0602DC2B RID: 187435 RVA: 0x00A8321D File Offset: 0x00A8141D
		public TsGameBudgetGroupConfigCache TsBattleHeadStateViewConfig
		{
			get
			{
				return this.TsBattleHeadStateViewConfigInternal;
			}
		}

		// Token: 0x1700752F RID: 29999
		// (get) Token: 0x0602DC2C RID: 187436 RVA: 0x00A83225 File Offset: 0x00A81425
		public GameBudgetAllocatorConfig TsCharacterDtailConfig
		{
			get
			{
				return this.TsCharacterDtailConfigInternal;
			}
		}

		// Token: 0x17007530 RID: 30000
		// (get) Token: 0x0602DC2D RID: 187437 RVA: 0x00A8322D File Offset: 0x00A8142D
		public TsGameBudgetGroupConfigCache TsAlwaysTickHotFixConfig
		{
			get
			{
				return this.TsAlwaysTickHotFixConfigInternal;
			}
		}

		// Token: 0x17007531 RID: 30001
		// (get) Token: 0x0602DC2E RID: 187438 RVA: 0x00A83235 File Offset: 0x00A81435
		public TsGameBudgetGroupConfigCache TsMoveSceneItemEntityConfig
		{
			get
			{
				return this.TsMoveSceneItemEntityConfigInternal;
			}
		}

		// Token: 0x17007532 RID: 30002
		// (get) Token: 0x0602DC2F RID: 187439 RVA: 0x00A8323D File Offset: 0x00A8143D
		public TsGameBudgetGroupConfigCache TsCollisionPlantConfig
		{
			get
			{
				return this.TsCollisionPlantConfigInternal;
			}
		}

		// Token: 0x17007533 RID: 30003
		// (get) Token: 0x0602DC30 RID: 187440 RVA: 0x00A83245 File Offset: 0x00A81445
		public TsGameBudgetGroupConfigCache TsBlueprintSingletonConfig
		{
			get
			{
				return this.TsBlueprintSingletonConfigInternal;
			}
		}

		// Token: 0x17007534 RID: 30004
		// (get) Token: 0x0602DC31 RID: 187441 RVA: 0x00A8324D File Offset: 0x00A8144D
		public TsGameBudgetGroupConfigCache TsSceneBlueprintActorConfig
		{
			get
			{
				return this.TsSceneBlueprintActorConfigInternal;
			}
		}

		// Token: 0x17007535 RID: 30005
		// (get) Token: 0x0602DC32 RID: 187442 RVA: 0x00A83255 File Offset: 0x00A81455
		public TsGameBudgetGroupConfigCache TsFarBlueprintActorConfig
		{
			get
			{
				return this.TsFarBlueprintActorConfigInternal;
			}
		}

		// Token: 0x17007536 RID: 30006
		// (get) Token: 0x0602DC33 RID: 187443 RVA: 0x00A8325D File Offset: 0x00A8145D
		public TsGameBudgetGroupConfigCache TsSuperFarBlueprintActorConfig
		{
			get
			{
				return this.TsSuperFarBlueprintActorConfigInternal;
			}
		}

		// Token: 0x17007537 RID: 30007
		// (get) Token: 0x0602DC34 RID: 187444 RVA: 0x00A83265 File Offset: 0x00A81465
		public TsGameBudgetGroupConfigCache TsDynamicPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsDynamicPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x17007538 RID: 30008
		// (get) Token: 0x0602DC35 RID: 187445 RVA: 0x00A8326D File Offset: 0x00A8146D
		public TsGameBudgetGroupConfigCache TsStaticPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsStaticPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x17007539 RID: 30009
		// (get) Token: 0x0602DC36 RID: 187446 RVA: 0x00A83275 File Offset: 0x00A81475
		public TsGameBudgetGroupConfigCache TsHighPriorityPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsHighPriorityPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x1700753A RID: 30010
		// (get) Token: 0x0602DC37 RID: 187447 RVA: 0x00A8327D File Offset: 0x00A8147D
		public TsGameBudgetGroupConfigCache TsSpecialBlueprintActorConfig
		{
			get
			{
				return this.TsSpecialBlueprintActorConfigInternal;
			}
		}

		// Token: 0x1700753B RID: 30011
		// (get) Token: 0x0602DC38 RID: 187448 RVA: 0x00A83285 File Offset: 0x00A81485
		public TsGameBudgetGroupConfigCache TsSparseGridPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsSparseGridPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x0602DC39 RID: 187449 RVA: 0x00A8328D File Offset: 0x00A8148D
		public void CreateCharacterEntityConfigOnly()
		{
			this.TsCharacterDtailConfigInternal = this.CreateCharacterEntityConfig(new GameBudgetAllocatorConfigMobileCreator(), false);
		}

		// Token: 0x0602DC3A RID: 187450 RVA: 0x00A832A4 File Offset: 0x00A814A4
		public void CreateConfigs()
		{
			IGamebudgetAllocatorConfigPlatformCreator creator;
			if (Info.Instance.IsPcPlatform())
			{
				creator = new GameBudgetAllocatorConfigPcCreator();
			}
			else
			{
				creator = new GameBudgetAllocatorConfigMobileCreator();
			}
			this.CreateNormalEntityConfig(creator);
			this.CreateBossEntityConfig(creator, true);
			this.CreateCharacterEntityConfig(creator, true);
			this.CreateNormalNpcEntityConfig(creator, true);
			this.CreateSimpleNpcEntityConfig(creator, true);
			this.CreateFightEffectConfig(creator);
			this.CreateEffectConfig(creator);
			this.CreateEffectImportanceConfig(creator);
			this.CreateStabilizeLowEntityConfig(creator);
			this.CreateAlwaysTickHotfixConfig(creator);
			this.CreateMoveSceneItemEntityConfig(creator);
			this.CreatePlayerAlwaysTickConfig(creator);
			this.CreateNormalEntityAlwaysTickConfig(creator);
			this.CreateNormalEntityAlwaysTickWithoutNotRenderedConfig(creator);
			this.CreateAlwaysTickConfig(creator);
			this.CreateCameraAlwaysTickConfig(creator);
			this.CreateIdleExecConfig(creator);
			this.CreateHUDTickConfig(creator);
			this.CreateCharacterRenderConfig(creator);
			this.CreateNpcRenderConfig(creator);
			this.CreateBattleHeadViewConfig(creator);
			this.CreateCollisionPlantConfig(creator);
			this.CreateBlueprintSingletonConfig(creator);
			this.CreateSceneBlueprintActorConfig(creator);
			this.CreateFarBlueprintActorConfig(creator);
			this.CreateSuperFarBlueprintActorConfig(creator);
			this.CreateDynamicPhysicsInteractionActorConfig(creator);
			this.CreateStaticPhysicsInteractionActorConfig(creator);
			this.CreateHighPriorityPhysicsInteractionActorConfig(creator);
			this.CreateSpecialBlueprintActorConfig(creator);
			this.CreateSparseGridPhysicsInteractionActorConfig(creator);
		}

		// Token: 0x0602DC3B RID: 187451 RVA: 0x00A833AE File Offset: 0x00A815AE
		public void UpdateGroupConfigTickStrategy(TsGameBudgetGroupConfigCache tsGroupConfig, int tickStrategy, uint distance)
		{
			tsGroupConfig.ueGroupConfig.DisableActorTickStrategy = (EDisableActorTickStrategy)tickStrategy;
			tsGroupConfig.ueGroupConfig.DisableActorTickDistance = distance;
		}

		// Token: 0x0602DC3C RID: 187452 RVA: 0x00A833C9 File Offset: 0x00A815C9
		public void RestoreGroupConfigTickStrategy(TsGameBudgetGroupConfigCache tsGroupConfig)
		{
			tsGroupConfig.ueGroupConfig.DisableActorTickStrategy = tsGroupConfig.DefaultDisableActorTickStrategy;
			tsGroupConfig.ueGroupConfig.DisableActorTickDistance = tsGroupConfig.DefaultDisableActorTickDistance;
		}

		// Token: 0x0602DC3D RID: 187453 RVA: 0x00A833F0 File Offset: 0x00A815F0
		private void ApplyGroupConfig(FGameBudgetAllocatorGroupConfig groupConfig, GameBudgetAllocatorConfig detailConfigs)
		{
			FName groupName;
			foreach (string text in detailConfigs.Keys)
			{
				TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = detailConfigs[text];
				if (text == "Default")
				{
					if (tsGameBudgetAllocatorTickIntervalDetailConfig == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Game;
						ELogAuthor author = ELogAuthor.WY;
						string message = "Missing default config!";
						string item = "GroupName";
						groupName = groupConfig.GroupName;
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, groupName.ToString());
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref groupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
					if (tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartScreenRatio > 0f)
					{
						UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailScreenRadiusConfig(ref groupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartScreenRatio, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalScreenRatio);
					}
				}
				else if (tsGameBudgetAllocatorTickIntervalDetailConfig != null)
				{
					UKuroGameBudgetAllocatorCSharpInterface.SetTickIntervalDetailConfig(ref groupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.GlobalMode, tsGameBudgetAllocatorTickIntervalDetailConfig.ActorMode, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
					if (tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartScreenRatio > 0f)
					{
						UKuroGameBudgetAllocatorCSharpInterface.SetTickIntervalDetailScreenRadiusConfig(ref groupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.GlobalMode, tsGameBudgetAllocatorTickIntervalDetailConfig.ActorMode, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartScreenRatio, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalScreenRatio);
					}
				}
			}
			groupName = groupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, groupConfig);
		}

		// Token: 0x0602DC3E RID: 187454 RVA: 0x00A83534 File Offset: 0x00A81734
		private void CreateIdleExecConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateIdleExecConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = (FNameUtil.GetDynamicFName("IdleExecGroup") ?? FName.NAME_None);
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Idle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 100U;
			this.TsIdleExecConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC3F RID: 187455 RVA: 0x00A835BC File Offset: 0x00A817BC
		private GameBudgetAllocatorConfig CreateBossEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator, bool isApply = true)
		{
			GameBudgetAllocatorConfig gameBudgetAllocatorConfig = creator.CreateBossEntityConfig();
			if (isApply)
			{
				FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
				fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BossEntity").Value;
				fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
				fgameBudgetAllocatorGroupConfig.TickPriority = 8U;
				this.TsBossEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
				this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, gameBudgetAllocatorConfig);
			}
			return gameBudgetAllocatorConfig;
		}

		// Token: 0x0602DC40 RID: 187456 RVA: 0x00A83614 File Offset: 0x00A81814
		private GameBudgetAllocatorConfig CreateCharacterEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator, bool isApply = true)
		{
			GameBudgetAllocatorConfig gameBudgetAllocatorConfig = creator.CreateCharacterEntityConfig();
			if (isApply)
			{
				FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
				fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("CharacterEntity").Value;
				fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
				fgameBudgetAllocatorGroupConfig.TickPriority = 9U;
				this.TsCharacterEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
				this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, gameBudgetAllocatorConfig);
			}
			return gameBudgetAllocatorConfig;
		}

		// Token: 0x0602DC41 RID: 187457 RVA: 0x00A83670 File Offset: 0x00A81870
		private GameBudgetAllocatorConfig CreateNormalNpcEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator, bool isApply = true)
		{
			GameBudgetAllocatorConfig gameBudgetAllocatorConfig = creator.CreateNormalNpcEntityConfig();
			if (isApply)
			{
				FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
				fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("NormalNpcEntity").Value;
				fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
				fgameBudgetAllocatorGroupConfig.TickPriority = 10U;
				this.TsNormalNpcEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
				this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, gameBudgetAllocatorConfig);
			}
			return gameBudgetAllocatorConfig;
		}

		// Token: 0x0602DC42 RID: 187458 RVA: 0x00A836CC File Offset: 0x00A818CC
		private GameBudgetAllocatorConfig CreateSimpleNpcEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator, bool isApply = true)
		{
			GameBudgetAllocatorConfig gameBudgetAllocatorConfig = creator.CreateSimpleNpcEntityConfig();
			if (isApply)
			{
				FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
				fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("SimpleNpcEntity").Value;
				fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
				fgameBudgetAllocatorGroupConfig.TickPriority = 11U;
				fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
				fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 3000U;
				this.TsSimpleNpcEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
				this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, gameBudgetAllocatorConfig);
			}
			return gameBudgetAllocatorConfig;
		}

		// Token: 0x0602DC43 RID: 187459 RVA: 0x00A83738 File Offset: 0x00A81938
		private void CreateNormalEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateNormalEntityConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("NormalEntity").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			this.TsNormalEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC44 RID: 187460 RVA: 0x00A83790 File Offset: 0x00A81990
		private void CreateFightEffectConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateFightEffectConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("FightEffectGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Critical;
			fgameBudgetAllocatorGroupConfig.TickPriority = 7U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 30001U;
			this.TsFightEffectGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC45 RID: 187461 RVA: 0x00A83818 File Offset: 0x00A81A18
		private void CreateEffectConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateEffectConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("EffectGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 30001U;
			this.TsEffectGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC46 RID: 187462 RVA: 0x00A83880 File Offset: 0x00A81A80
		private void CreateEffectImportanceConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateEffectImportanceConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("EffectImportanceGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 1000000U;
			this.TsEffectInportanceGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC47 RID: 187463 RVA: 0x00A838E8 File Offset: 0x00A81AE8
		private void CreateStabilizeLowEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateStabilizeLowEntityConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("CustomStabilizeLow").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsStabilizeLowEntityGroupConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC48 RID: 187464 RVA: 0x00A83944 File Offset: 0x00A81B44
		private void CreateAlwaysTickHotfixConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateAlwaysTickHotfixConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("AlwaysTickHotFix").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsAlwaysTickHotFixConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC49 RID: 187465 RVA: 0x00A839A0 File Offset: 0x00A81BA0
		private void CreateMoveSceneItemEntityConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateMoveSceneItemEntityConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("MoveSceneItemEntity").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 3U;
			this.TsMoveSceneItemEntityConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC4A RID: 187466 RVA: 0x00A839F4 File Offset: 0x00A81BF4
		private void CreatePlayerAlwaysTickConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreatePlayerAlwaysTickConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("PlayerAlwaysTickGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Critical;
			fgameBudgetAllocatorGroupConfig.TickPriority = 4U;
			this.TsPlayerAlwaysTickConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC4B RID: 187467 RVA: 0x00A83A6C File Offset: 0x00A81C6C
		private void CreateNormalEntityAlwaysTickConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateNormalEntityAlwaysTickConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("NormalEntityAlwaysTickGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsNormalEntityAlwaysTickConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC4C RID: 187468 RVA: 0x00A83AC8 File Offset: 0x00A81CC8
		private void CreateNormalEntityAlwaysTickWithoutNotRenderedConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateNormalEntityAlwaysTickWithoutNotRenderedConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("NormalEntityAlwaysTickWhitoutNotRenderedGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsNormalEntityAlwaysTickWithoutNotRenderedConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC4D RID: 187469 RVA: 0x00A83B24 File Offset: 0x00A81D24
		private void CreateAlwaysTickConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateAlwaysTickConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("AlwaysTickGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Critical;
			fgameBudgetAllocatorGroupConfig.TickPriority = 5U;
			this.TsAlwaysTickConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC4E RID: 187470 RVA: 0x00A83B9C File Offset: 0x00A81D9C
		private void CreateCameraAlwaysTickConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateCameraAlwaysTickConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("CameraAlwaysTickGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Critical;
			fgameBudgetAllocatorGroupConfig.TickPriority = 90U;
			this.TsAlwaysTick2ConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC4F RID: 187471 RVA: 0x00A83C14 File Offset: 0x00A81E14
		private void CreateHUDTickConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateHUDTickConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("HUDGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 5000U;
			this.TsHUDTickConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC50 RID: 187472 RVA: 0x00A83C9C File Offset: 0x00A81E9C
		private void CreateBattleHeadViewConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateBattleHeadViewConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BattleHeadViewGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 5000U;
			this.TsBattleHeadStateViewConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC51 RID: 187473 RVA: 0x00A83D24 File Offset: 0x00A81F24
		public void CreateCharacterRenderConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateCharacterRenderConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("CharacterRenderGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 8U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 18000U;
			this.TsCharacterRenderConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC52 RID: 187474 RVA: 0x00A83D8C File Offset: 0x00A81F8C
		public void CreateNpcRenderConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateNpcRenderConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("NpcRenderGroup").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 11U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 18000U;
			this.TsNpcRenderConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC53 RID: 187475 RVA: 0x00A83DF4 File Offset: 0x00A81FF4
		private void CreateCollisionPlantConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateCollisionPlantConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("CollisionPlant").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 1000U;
			this.TsCollisionPlantConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC54 RID: 187476 RVA: 0x00A83E5C File Offset: 0x00A8205C
		private void CreateBlueprintSingletonConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			TsGameBudgetAllocatorTickIntervalDetailConfig tsGameBudgetAllocatorTickIntervalDetailConfig = creator.CreateBlueprintSingletonConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.BlueprintSingleton").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsBlueprintSingletonConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			UKuroGameBudgetAllocatorCSharpInterface.SetDefaultTickIntervalDetailConfig(ref fgameBudgetAllocatorGroupConfig, tsGameBudgetAllocatorTickIntervalDetailConfig.MaxInterval, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionStartSize, tsGameBudgetAllocatorTickIntervalDetailConfig.TickReductionIntervalSize);
			FName groupName = fgameBudgetAllocatorGroupConfig.GroupName;
			UKuroGameBudgetAllocatorCSharpInterface.SetGroupConfig(groupName, fgameBudgetAllocatorGroupConfig);
		}

		// Token: 0x0602DC55 RID: 187477 RVA: 0x00A83EDC File Offset: 0x00A820DC
		private void CreateSceneBlueprintActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateSceneBlueprintActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.SceneBlueprintActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 10000U;
			this.TsSceneBlueprintActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC56 RID: 187478 RVA: 0x00A83F44 File Offset: 0x00A82144
		private void CreateFarBlueprintActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateFarBlueprintActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.FarBlueprintActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 28000U;
			this.TsFarBlueprintActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC57 RID: 187479 RVA: 0x00A83FAC File Offset: 0x00A821AC
		private void CreateSuperFarBlueprintActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateSuperFarBlueprintActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.SuperFarBlueprintActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsSuperFarBlueprintActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC58 RID: 187480 RVA: 0x00A84008 File Offset: 0x00A82208
		private void CreateDynamicPhysicsInteractionActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateDynamicPhysicsInteractionActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.DynamicPhysicsInteractionActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 2500U;
			this.TsDynamicPhysicsInteractionActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC59 RID: 187481 RVA: 0x00A84070 File Offset: 0x00A82270
		private void CreateStaticPhysicsInteractionActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateStaticPhysicsInteractionActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.StaticPhysicsInteractionActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Low;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 1500U;
			this.TsStaticPhysicsInteractionActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC5A RID: 187482 RVA: 0x00A840D8 File Offset: 0x00A822D8
		private void CreateHighPriorityPhysicsInteractionActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateHighPriorityPhysicsInteractionActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.HighPriorityPhysicsInteractionActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = 5000U;
			this.TsHighPriorityPhysicsInteractionActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC5B RID: 187483 RVA: 0x00A84140 File Offset: 0x00A82340
		private void CreateSpecialBlueprintActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateSpecialBlueprintActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.SpecialBlueprintActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsSpecialBlueprintActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC5C RID: 187484 RVA: 0x00A8419C File Offset: 0x00A8239C
		private void CreateSparseGridPhysicsInteractionActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateDynamicPhysicsInteractionActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.SparseGridPhysicsInteractionActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsSparseGridPhysicsInteractionActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x0602DC5D RID: 187485 RVA: 0x00A841F8 File Offset: 0x00A823F8
		public TsGameBudgetGroupConfigCache GetEffectDynamicGroup(uint inMaxDistance)
		{
			uint num = inMaxDistance;
			if (num >= 200000U)
			{
				return this.TsEffectInportanceGroupConfig;
			}
			if (UKuroStaticLibrary.IsLowMemoryDevice() && LowMemoryScalabilityController.Instance.IsSpecialLowMemoryMap() && num > 3000U)
			{
				num = (uint)(num - (num - 3000U) * 0.8);
			}
			TsGameBudgetGroupConfigCache result;
			if (this.TsEffectDynamicGroupConfigMap.TryGetValue(num, out result))
			{
				return result;
			}
			double num2 = 0.1 * num;
			double num3 = 0.2 * num;
			double num4 = 0.05 * num;
			double num5 = 0.1 * num;
			double num6 = 0.02 * num;
			double num7 = 0.1 * num;
			double num8 = (num - num2) / 179.0;
			double num9 = (num - num3) / 59.0;
			double num10 = (num - num4) / 299.0;
			double num11 = (num - num5) / 299.0;
			double num12 = (num - num6) / 599.0;
			double num13 = (num - num7) / 299.0;
			GameBudgetAllocatorConfig detailConfigs = new GameBudgetAllocatorConfig
			{
				Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 180U, (uint)num2, (uint)num8, 0f, 0f),
				Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, (uint)num3, (uint)num9, 0f, 0f),
				Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, (uint)num4, (uint)num10, 0f, 0f),
				Normal_Fighting = null,
				Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 300U, (uint)num5, (uint)num11, 0f, 0f),
				Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 600U, (uint)num6, (uint)num12, 0f, 0f),
				Fighting_Fighting = null,
				Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, (uint)num3, (uint)num9, 0f, 0f),
				Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, (uint)num7, (uint)num13, 0f, 0f)
			};
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("EffectGroup_" + num.ToString()).Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.Middle;
			fgameBudgetAllocatorGroupConfig.TickPriority = 12U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_DistanceOnly;
			fgameBudgetAllocatorGroupConfig.DisableActorTickDistance = num;
			TsGameBudgetGroupConfigCache tsGameBudgetGroupConfigCache = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.TsEffectDynamicGroupConfigMap[num] = tsGameBudgetGroupConfigCache;
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
			return tsGameBudgetGroupConfigCache;
		}

		// Token: 0x1700753C RID: 30012
		// (get) Token: 0x0602DC5E RID: 187486 RVA: 0x00A84488 File Offset: 0x00A82688
		public static GameBudgetAllocatorConfigCreator Instance
		{
			get
			{
				if (GameBudgetAllocatorConfigCreator._instance == null)
				{
					GameBudgetAllocatorConfigCreator._instance = new GameBudgetAllocatorConfigCreator();
					GameBudgetAllocatorConfigCreator._instance.OnInit();
				}
				return GameBudgetAllocatorConfigCreator._instance;
			}
		}

		// Token: 0x0602DC5F RID: 187487 RVA: 0x00A844AB File Offset: 0x00A826AB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DC60 RID: 187488 RVA: 0x00A844AD File Offset: 0x00A826AD
		public static void ResetStaticDefaultValue()
		{
			GameBudgetAllocatorConfigCreator instance = GameBudgetAllocatorConfigCreator._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GameBudgetAllocatorConfigCreator._instance = null;
		}

		// Token: 0x0602DC61 RID: 187489 RVA: 0x00A844C6 File Offset: 0x00A826C6
		static GameBudgetAllocatorConfigCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetAllocatorConfigCreator.CreateStaticDefaultValue), new Action(GameBudgetAllocatorConfigCreator.ResetStaticDefaultValue));
		}

		// Token: 0x040186DA RID: 100058
		private const int PRE_PLAYER_MOVE_TICK_PRIORITY = 3;

		// Token: 0x040186DB RID: 100059
		private const int PLAYER_ALWAYS_TICK_PRIORITY = 4;

		// Token: 0x040186DC RID: 100060
		private const int ALWAYS_TICK_PRIORITY = 5;

		// Token: 0x040186DD RID: 100061
		private const int FIGHT_EFFECT_PRIPRITY = 7;

		// Token: 0x040186DE RID: 100062
		private const int Boss_PRIORITY = 8;

		// Token: 0x040186DF RID: 100063
		private const int ROLE_PRIORITY = 9;

		// Token: 0x040186E0 RID: 100064
		private const int NPC_PRIORITY = 10;

		// Token: 0x040186E1 RID: 100065
		private const int SIMPLE_NPC_PRIORITY = 11;

		// Token: 0x040186E2 RID: 100066
		private const int HUD_PRIORITY = 12;

		// Token: 0x040186E3 RID: 100067
		private const int BATTLE_HEAD_STATE_VIEW_PRIORITY = 12;

		// Token: 0x040186E4 RID: 100068
		private const int OTHER_PRIORITY = 12;

		// Token: 0x040186E5 RID: 100069
		private const int CAMERA_PRIORITY = 90;

		// Token: 0x040186E6 RID: 100070
		private const int IDLE_EXEC_PRIORITY = 100;

		// Token: 0x040186E7 RID: 100071
		public const int EFFECT_ENABLE_RANGE = 30001;

		// Token: 0x040186E8 RID: 100072
		public const int EFFECT_USE_BOUNDS_RANGE = 10000;

		// Token: 0x040186E9 RID: 100073
		public const int EFFECT_IMPORTANCE_ENABLE_RANGE = 200000;

		// Token: 0x040186EA RID: 100074
		private const int EFFECT_IMPORTANCE_ENABLE_MAX_RANGE = 1000000;

		// Token: 0x040186EB RID: 100075
		private const int HUD_ENABLE_RANGE = 5000;

		// Token: 0x040186EC RID: 100076
		private const int BATTLE_HEAD_STATE_VIEW_RANGE = 5000;

		// Token: 0x040186ED RID: 100077
		private const int CHARCTER_RENDER_ENABLE_MAX_RANGE = 18000;

		// Token: 0x040186EE RID: 100078
		private const int COLLISION_PLANT_RANGE = 1000;

		// Token: 0x040186EF RID: 100079
		private const int SCENE_BLUEPRINT_ACTOR_RANGE = 10000;

		// Token: 0x040186F0 RID: 100080
		private const int FAR_BLUEPRINT_ACTOR_RANGE = 28000;

		// Token: 0x040186F1 RID: 100081
		private const int HIGH_PRIORITY_PHYSICS_INTERACTION_ACTOR_RANGE = 5000;

		// Token: 0x040186F2 RID: 100082
		private const int DYNAMIC_PHYSICS_INTERACTION_ACTOR_RANGE = 2500;

		// Token: 0x040186F3 RID: 100083
		private const int STATIC_PHYSICS_INTERACTION_ACTOR_RANGE = 1500;

		// Token: 0x040186F4 RID: 100084
		private TsGameBudgetGroupConfigCache TsNormalEntityGroupConfigInternal;

		// Token: 0x040186F5 RID: 100085
		private TsGameBudgetGroupConfigCache TsBossEntityGroupConfigInternal;

		// Token: 0x040186F6 RID: 100086
		private TsGameBudgetGroupConfigCache TsCharacterEntityGroupConfigInternal;

		// Token: 0x040186F7 RID: 100087
		private TsGameBudgetGroupConfigCache TsNormalNpcEntityGroupConfigInternal;

		// Token: 0x040186F8 RID: 100088
		private TsGameBudgetGroupConfigCache TsSimpleNpcEntityGroupConfigInternal;

		// Token: 0x040186F9 RID: 100089
		private TsGameBudgetGroupConfigCache TsFightEffectGroupConfigInternal;

		// Token: 0x040186FA RID: 100090
		private TsGameBudgetGroupConfigCache TsEffectGroupConfigInternal;

		// Token: 0x040186FB RID: 100091
		private TsGameBudgetGroupConfigCache TsEffectInportanceGroupConfigInternal;

		// Token: 0x040186FC RID: 100092
		private TsGameBudgetGroupConfigCache TsAlwaysTickConfigInternal;

		// Token: 0x040186FD RID: 100093
		private TsGameBudgetGroupConfigCache TsPlayerAlwaysTickConfigInternal;

		// Token: 0x040186FE RID: 100094
		private TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickConfigInternal;

		// Token: 0x040186FF RID: 100095
		private TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickWithoutNotRenderedConfigInternal;

		// Token: 0x04018700 RID: 100096
		private TsGameBudgetGroupConfigCache TsIdleExecConfigInternal;

		// Token: 0x04018701 RID: 100097
		private TsGameBudgetGroupConfigCache TsAlwaysTick2ConfigInternal;

		// Token: 0x04018702 RID: 100098
		private TsGameBudgetGroupConfigCache TsHUDTickConfigInternal;

		// Token: 0x04018703 RID: 100099
		private TsGameBudgetGroupConfigCache TsCharacterRenderConfigInternal;

		// Token: 0x04018704 RID: 100100
		private TsGameBudgetGroupConfigCache TsNpcRenderConfigInternal;

		// Token: 0x04018705 RID: 100101
		private TsGameBudgetGroupConfigCache TsStabilizeLowEntityGroupConfigInternal;

		// Token: 0x04018706 RID: 100102
		private TsGameBudgetGroupConfigCache TsBattleHeadStateViewConfigInternal;

		// Token: 0x04018707 RID: 100103
		private GameBudgetAllocatorConfig TsCharacterDtailConfigInternal;

		// Token: 0x04018708 RID: 100104
		private TsGameBudgetGroupConfigCache TsAlwaysTickHotFixConfigInternal;

		// Token: 0x04018709 RID: 100105
		private TsGameBudgetGroupConfigCache TsMoveSceneItemEntityConfigInternal;

		// Token: 0x0401870A RID: 100106
		private TsGameBudgetGroupConfigCache TsCollisionPlantConfigInternal;

		// Token: 0x0401870B RID: 100107
		private TsGameBudgetGroupConfigCache TsBlueprintSingletonConfigInternal;

		// Token: 0x0401870C RID: 100108
		private TsGameBudgetGroupConfigCache TsSceneBlueprintActorConfigInternal;

		// Token: 0x0401870D RID: 100109
		private TsGameBudgetGroupConfigCache TsFarBlueprintActorConfigInternal;

		// Token: 0x0401870E RID: 100110
		private TsGameBudgetGroupConfigCache TsSuperFarBlueprintActorConfigInternal;

		// Token: 0x0401870F RID: 100111
		private TsGameBudgetGroupConfigCache TsDynamicPhysicsInteractionActorConfigInternal;

		// Token: 0x04018710 RID: 100112
		private TsGameBudgetGroupConfigCache TsStaticPhysicsInteractionActorConfigInternal;

		// Token: 0x04018711 RID: 100113
		private TsGameBudgetGroupConfigCache TsHighPriorityPhysicsInteractionActorConfigInternal;

		// Token: 0x04018712 RID: 100114
		private TsGameBudgetGroupConfigCache TsSpecialBlueprintActorConfigInternal;

		// Token: 0x04018713 RID: 100115
		private TsGameBudgetGroupConfigCache TsSparseGridPhysicsInteractionActorConfigInternal;

		// Token: 0x04018714 RID: 100116
		public readonly Dictionary<uint, TsGameBudgetGroupConfigCache> TsEffectDynamicGroupConfigMap = new Dictionary<uint, TsGameBudgetGroupConfigCache>();

		// Token: 0x04018715 RID: 100117
		[Nullable(2)]
		private static GameBudgetAllocatorConfigCreator _instance;
	}
}

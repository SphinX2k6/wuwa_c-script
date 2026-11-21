using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x0200345A RID: 13402
	[NullableContext(1)]
	[Nullable(0)]
	public class GameBudgetAllocatorConfigCreator : Singleton
	{
		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x060222F4 RID: 140020 RVA: 0x009AE613 File Offset: 0x009AC813
		public TsGameBudgetGroupConfigCache TsNormalEntityGroupConfig
		{
			get
			{
				return this.TsNormalEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x060222F5 RID: 140021 RVA: 0x009AE61B File Offset: 0x009AC81B
		public TsGameBudgetGroupConfigCache TsBossEntityGroupConfig
		{
			get
			{
				return this.TsBossEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x060222F6 RID: 140022 RVA: 0x009AE623 File Offset: 0x009AC823
		public TsGameBudgetGroupConfigCache TsCharacterEntityGroupConfig
		{
			get
			{
				return this.TsCharacterEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x060222F7 RID: 140023 RVA: 0x009AE62B File Offset: 0x009AC82B
		public TsGameBudgetGroupConfigCache TsNormalNpcEntityGroupConfig
		{
			get
			{
				return this.TsNormalNpcEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x060222F8 RID: 140024 RVA: 0x009AE633 File Offset: 0x009AC833
		public TsGameBudgetGroupConfigCache TsSimpleNpcEntityGroupConfig
		{
			get
			{
				return this.TsSimpleNpcEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x060222F9 RID: 140025 RVA: 0x009AE63B File Offset: 0x009AC83B
		public TsGameBudgetGroupConfigCache TsFightEffectGroupConfig
		{
			get
			{
				return this.TsFightEffectGroupConfigInternal;
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x060222FA RID: 140026 RVA: 0x009AE643 File Offset: 0x009AC843
		public TsGameBudgetGroupConfigCache TsEffectGroupConfig
		{
			get
			{
				return this.TsEffectGroupConfigInternal;
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x060222FB RID: 140027 RVA: 0x009AE64B File Offset: 0x009AC84B
		public TsGameBudgetGroupConfigCache TsEffectInportanceGroupConfig
		{
			get
			{
				return this.TsEffectInportanceGroupConfigInternal;
			}
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x060222FC RID: 140028 RVA: 0x009AE653 File Offset: 0x009AC853
		public TsGameBudgetGroupConfigCache TsAlwaysTickConfig
		{
			get
			{
				return this.TsAlwaysTickConfigInternal;
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x060222FD RID: 140029 RVA: 0x009AE65B File Offset: 0x009AC85B
		public TsGameBudgetGroupConfigCache TsPlayerAlwaysTickConfig
		{
			get
			{
				return this.TsPlayerAlwaysTickConfigInternal;
			}
		}

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x060222FE RID: 140030 RVA: 0x009AE663 File Offset: 0x009AC863
		public TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickConfig
		{
			get
			{
				return this.TsNormalEntityAlwaysTickConfigInternal;
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x060222FF RID: 140031 RVA: 0x009AE66B File Offset: 0x009AC86B
		public TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickWithoutNotRenderedConfig
		{
			get
			{
				return this.TsNormalEntityAlwaysTickWithoutNotRenderedConfigInternal;
			}
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x06022300 RID: 140032 RVA: 0x009AE673 File Offset: 0x009AC873
		public TsGameBudgetGroupConfigCache TsIdleExecConfig
		{
			get
			{
				return this.TsIdleExecConfigInternal;
			}
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x06022301 RID: 140033 RVA: 0x009AE67B File Offset: 0x009AC87B
		public TsGameBudgetGroupConfigCache TsAlwaysTick2Config
		{
			get
			{
				return this.TsAlwaysTick2ConfigInternal;
			}
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x06022302 RID: 140034 RVA: 0x009AE683 File Offset: 0x009AC883
		public TsGameBudgetGroupConfigCache TsHUDTickConfig
		{
			get
			{
				return this.TsHUDTickConfigInternal;
			}
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x06022303 RID: 140035 RVA: 0x009AE68B File Offset: 0x009AC88B
		public TsGameBudgetGroupConfigCache TsCharacterRenderConfig
		{
			get
			{
				return this.TsCharacterRenderConfigInternal;
			}
		}

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x06022304 RID: 140036 RVA: 0x009AE693 File Offset: 0x009AC893
		public TsGameBudgetGroupConfigCache TsNpcRenderConfig
		{
			get
			{
				return this.TsNpcRenderConfigInternal;
			}
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x06022305 RID: 140037 RVA: 0x009AE69B File Offset: 0x009AC89B
		public TsGameBudgetGroupConfigCache TsStabilizeLowEntityGroupConfig
		{
			get
			{
				return this.TsStabilizeLowEntityGroupConfigInternal;
			}
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x06022306 RID: 140038 RVA: 0x009AE6A3 File Offset: 0x009AC8A3
		public TsGameBudgetGroupConfigCache TsBattleHeadStateViewConfig
		{
			get
			{
				return this.TsBattleHeadStateViewConfigInternal;
			}
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x06022307 RID: 140039 RVA: 0x009AE6AB File Offset: 0x009AC8AB
		public GameBudgetAllocatorConfig TsCharacterDtailConfig
		{
			get
			{
				return this.TsCharacterDtailConfigInternal;
			}
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x06022308 RID: 140040 RVA: 0x009AE6B3 File Offset: 0x009AC8B3
		public TsGameBudgetGroupConfigCache TsAlwaysTickHotFixConfig
		{
			get
			{
				return this.TsAlwaysTickHotFixConfigInternal;
			}
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x06022309 RID: 140041 RVA: 0x009AE6BB File Offset: 0x009AC8BB
		public TsGameBudgetGroupConfigCache TsMoveSceneItemEntityConfig
		{
			get
			{
				return this.TsMoveSceneItemEntityConfigInternal;
			}
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x0602230A RID: 140042 RVA: 0x009AE6C3 File Offset: 0x009AC8C3
		public TsGameBudgetGroupConfigCache TsCollisionPlantConfig
		{
			get
			{
				return this.TsCollisionPlantConfigInternal;
			}
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x0602230B RID: 140043 RVA: 0x009AE6CB File Offset: 0x009AC8CB
		public TsGameBudgetGroupConfigCache TsBlueprintSingletonConfig
		{
			get
			{
				return this.TsBlueprintSingletonConfigInternal;
			}
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x0602230C RID: 140044 RVA: 0x009AE6D3 File Offset: 0x009AC8D3
		public TsGameBudgetGroupConfigCache TsSceneBlueprintActorConfig
		{
			get
			{
				return this.TsSceneBlueprintActorConfigInternal;
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x0602230D RID: 140045 RVA: 0x009AE6DB File Offset: 0x009AC8DB
		public TsGameBudgetGroupConfigCache TsFarBlueprintActorConfig
		{
			get
			{
				return this.TsFarBlueprintActorConfigInternal;
			}
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x0602230E RID: 140046 RVA: 0x009AE6E3 File Offset: 0x009AC8E3
		public TsGameBudgetGroupConfigCache TsSuperFarBlueprintActorConfig
		{
			get
			{
				return this.TsSuperFarBlueprintActorConfigInternal;
			}
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x0602230F RID: 140047 RVA: 0x009AE6EB File Offset: 0x009AC8EB
		public TsGameBudgetGroupConfigCache TsDynamicPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsDynamicPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x06022310 RID: 140048 RVA: 0x009AE6F3 File Offset: 0x009AC8F3
		public TsGameBudgetGroupConfigCache TsStaticPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsStaticPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x06022311 RID: 140049 RVA: 0x009AE6FB File Offset: 0x009AC8FB
		public TsGameBudgetGroupConfigCache TsHighPriorityPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsHighPriorityPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x06022312 RID: 140050 RVA: 0x009AE703 File Offset: 0x009AC903
		public TsGameBudgetGroupConfigCache TsSpecialBlueprintActorConfig
		{
			get
			{
				return this.TsSpecialBlueprintActorConfigInternal;
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x06022313 RID: 140051 RVA: 0x009AE70B File Offset: 0x009AC90B
		public TsGameBudgetGroupConfigCache TsSparseGridPhysicsInteractionActorConfig
		{
			get
			{
				return this.TsSparseGridPhysicsInteractionActorConfigInternal;
			}
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x06022314 RID: 140052 RVA: 0x009AE713 File Offset: 0x009AC913
		public TsGameBudgetGroupConfigCache TsScreenDecalActorConfig
		{
			get
			{
				return this.TsScreenDecalActorConfigInternal;
			}
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x009AE71B File Offset: 0x009AC91B
		public void CreateCharacterEntityConfigOnly()
		{
			this.TsCharacterDtailConfigInternal = this.CreateCharacterEntityConfig(new GameBudgetAllocatorConfigMobileCreator(), false);
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x009AE730 File Offset: 0x009AC930
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
			this.CreateScreenDecalActorConfig(creator);
		}

		// Token: 0x06022317 RID: 140055 RVA: 0x009AE844 File Offset: 0x009ACA44
		private void CreateScreenDecalActorConfig(IGamebudgetAllocatorConfigPlatformCreator creator)
		{
			GameBudgetAllocatorConfig detailConfigs = creator.CreateScreenDecalActorConfig();
			FGameBudgetAllocatorGroupConfig fgameBudgetAllocatorGroupConfig = new FGameBudgetAllocatorGroupConfig();
			fgameBudgetAllocatorGroupConfig.GroupName = FNameUtil.GetDynamicFName("BlueprintTick.ScreenDecalActor").Value;
			fgameBudgetAllocatorGroupConfig.SignificanceGroup = ESignificanceGroup.High;
			fgameBudgetAllocatorGroupConfig.TickPriority = 2U;
			fgameBudgetAllocatorGroupConfig.DisableActorTickStrategy = EDisableActorTickStrategy.DisableActorTickStrategy_None;
			this.TsScreenDecalActorConfigInternal = new TsGameBudgetGroupConfigCache(fgameBudgetAllocatorGroupConfig);
			this.ApplyGroupConfig(fgameBudgetAllocatorGroupConfig, detailConfigs);
		}

		// Token: 0x06022318 RID: 140056 RVA: 0x009AE89F File Offset: 0x009ACA9F
		public void UpdateGroupConfigTickStrategy(TsGameBudgetGroupConfigCache tsGroupConfig, int tickStrategy, uint distance)
		{
			tsGroupConfig.ueGroupConfig.DisableActorTickStrategy = (EDisableActorTickStrategy)tickStrategy;
			tsGroupConfig.ueGroupConfig.DisableActorTickDistance = distance;
		}

		// Token: 0x06022319 RID: 140057 RVA: 0x009AE8BA File Offset: 0x009ACABA
		public void RestoreGroupConfigTickStrategy(TsGameBudgetGroupConfigCache tsGroupConfig)
		{
			tsGroupConfig.ueGroupConfig.DisableActorTickStrategy = tsGroupConfig.DefaultDisableActorTickStrategy;
			tsGroupConfig.ueGroupConfig.DisableActorTickDistance = tsGroupConfig.DefaultDisableActorTickDistance;
		}

		// Token: 0x0602231A RID: 140058 RVA: 0x009AE8E0 File Offset: 0x009ACAE0
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

		// Token: 0x0602231B RID: 140059 RVA: 0x009AEA24 File Offset: 0x009ACC24
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

		// Token: 0x0602231C RID: 140060 RVA: 0x009AEAAC File Offset: 0x009ACCAC
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

		// Token: 0x0602231D RID: 140061 RVA: 0x009AEB04 File Offset: 0x009ACD04
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

		// Token: 0x0602231E RID: 140062 RVA: 0x009AEB60 File Offset: 0x009ACD60
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

		// Token: 0x0602231F RID: 140063 RVA: 0x009AEBBC File Offset: 0x009ACDBC
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

		// Token: 0x06022320 RID: 140064 RVA: 0x009AEC28 File Offset: 0x009ACE28
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

		// Token: 0x06022321 RID: 140065 RVA: 0x009AEC80 File Offset: 0x009ACE80
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

		// Token: 0x06022322 RID: 140066 RVA: 0x009AED08 File Offset: 0x009ACF08
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

		// Token: 0x06022323 RID: 140067 RVA: 0x009AED70 File Offset: 0x009ACF70
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

		// Token: 0x06022324 RID: 140068 RVA: 0x009AEDD8 File Offset: 0x009ACFD8
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

		// Token: 0x06022325 RID: 140069 RVA: 0x009AEE34 File Offset: 0x009AD034
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

		// Token: 0x06022326 RID: 140070 RVA: 0x009AEE90 File Offset: 0x009AD090
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

		// Token: 0x06022327 RID: 140071 RVA: 0x009AEEE4 File Offset: 0x009AD0E4
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

		// Token: 0x06022328 RID: 140072 RVA: 0x009AEF5C File Offset: 0x009AD15C
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

		// Token: 0x06022329 RID: 140073 RVA: 0x009AEFB8 File Offset: 0x009AD1B8
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

		// Token: 0x0602232A RID: 140074 RVA: 0x009AF014 File Offset: 0x009AD214
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

		// Token: 0x0602232B RID: 140075 RVA: 0x009AF08C File Offset: 0x009AD28C
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

		// Token: 0x0602232C RID: 140076 RVA: 0x009AF104 File Offset: 0x009AD304
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

		// Token: 0x0602232D RID: 140077 RVA: 0x009AF18C File Offset: 0x009AD38C
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

		// Token: 0x0602232E RID: 140078 RVA: 0x009AF214 File Offset: 0x009AD414
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

		// Token: 0x0602232F RID: 140079 RVA: 0x009AF27C File Offset: 0x009AD47C
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

		// Token: 0x06022330 RID: 140080 RVA: 0x009AF2E4 File Offset: 0x009AD4E4
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

		// Token: 0x06022331 RID: 140081 RVA: 0x009AF34C File Offset: 0x009AD54C
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

		// Token: 0x06022332 RID: 140082 RVA: 0x009AF3CC File Offset: 0x009AD5CC
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

		// Token: 0x06022333 RID: 140083 RVA: 0x009AF434 File Offset: 0x009AD634
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

		// Token: 0x06022334 RID: 140084 RVA: 0x009AF49C File Offset: 0x009AD69C
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

		// Token: 0x06022335 RID: 140085 RVA: 0x009AF4F8 File Offset: 0x009AD6F8
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

		// Token: 0x06022336 RID: 140086 RVA: 0x009AF560 File Offset: 0x009AD760
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

		// Token: 0x06022337 RID: 140087 RVA: 0x009AF5C8 File Offset: 0x009AD7C8
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

		// Token: 0x06022338 RID: 140088 RVA: 0x009AF630 File Offset: 0x009AD830
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

		// Token: 0x06022339 RID: 140089 RVA: 0x009AF68C File Offset: 0x009AD88C
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

		// Token: 0x0602233A RID: 140090 RVA: 0x009AF6E8 File Offset: 0x009AD8E8
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

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x0602233B RID: 140091 RVA: 0x009AF978 File Offset: 0x009ADB78
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

		// Token: 0x0602233C RID: 140092 RVA: 0x009AF99B File Offset: 0x009ADB9B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602233D RID: 140093 RVA: 0x009AF99D File Offset: 0x009ADB9D
		public static void ResetStaticDefaultValue()
		{
			GameBudgetAllocatorConfigCreator instance = GameBudgetAllocatorConfigCreator._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GameBudgetAllocatorConfigCreator._instance = null;
		}

		// Token: 0x0602233E RID: 140094 RVA: 0x009AF9B6 File Offset: 0x009ADBB6
		static GameBudgetAllocatorConfigCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameBudgetAllocatorConfigCreator.CreateStaticDefaultValue), new Action(GameBudgetAllocatorConfigCreator.ResetStaticDefaultValue));
		}

		// Token: 0x04012D0B RID: 77067
		private const int SCREEN_DECAL_PRIORITY = 2;

		// Token: 0x04012D0C RID: 77068
		private const int PRE_PLAYER_MOVE_TICK_PRIORITY = 3;

		// Token: 0x04012D0D RID: 77069
		private const int PLAYER_ALWAYS_TICK_PRIORITY = 4;

		// Token: 0x04012D0E RID: 77070
		private const int ALWAYS_TICK_PRIORITY = 5;

		// Token: 0x04012D0F RID: 77071
		private const int FIGHT_EFFECT_PRIPRITY = 7;

		// Token: 0x04012D10 RID: 77072
		private const int Boss_PRIORITY = 8;

		// Token: 0x04012D11 RID: 77073
		private const int ROLE_PRIORITY = 9;

		// Token: 0x04012D12 RID: 77074
		private const int NPC_PRIORITY = 10;

		// Token: 0x04012D13 RID: 77075
		private const int SIMPLE_NPC_PRIORITY = 11;

		// Token: 0x04012D14 RID: 77076
		private const int HUD_PRIORITY = 12;

		// Token: 0x04012D15 RID: 77077
		private const int BATTLE_HEAD_STATE_VIEW_PRIORITY = 12;

		// Token: 0x04012D16 RID: 77078
		private const int OTHER_PRIORITY = 12;

		// Token: 0x04012D17 RID: 77079
		private const int CAMERA_PRIORITY = 90;

		// Token: 0x04012D18 RID: 77080
		private const int IDLE_EXEC_PRIORITY = 100;

		// Token: 0x04012D19 RID: 77081
		public const int EFFECT_ENABLE_RANGE = 30001;

		// Token: 0x04012D1A RID: 77082
		public const int EFFECT_USE_BOUNDS_RANGE = 10000;

		// Token: 0x04012D1B RID: 77083
		public const int EFFECT_IMPORTANCE_ENABLE_RANGE = 200000;

		// Token: 0x04012D1C RID: 77084
		private const int EFFECT_IMPORTANCE_ENABLE_MAX_RANGE = 1000000;

		// Token: 0x04012D1D RID: 77085
		private const int HUD_ENABLE_RANGE = 5000;

		// Token: 0x04012D1E RID: 77086
		private const int BATTLE_HEAD_STATE_VIEW_RANGE = 5000;

		// Token: 0x04012D1F RID: 77087
		private const int CHARCTER_RENDER_ENABLE_MAX_RANGE = 18000;

		// Token: 0x04012D20 RID: 77088
		private const int COLLISION_PLANT_RANGE = 1000;

		// Token: 0x04012D21 RID: 77089
		private const int SCENE_BLUEPRINT_ACTOR_RANGE = 10000;

		// Token: 0x04012D22 RID: 77090
		private const int FAR_BLUEPRINT_ACTOR_RANGE = 28000;

		// Token: 0x04012D23 RID: 77091
		private const int HIGH_PRIORITY_PHYSICS_INTERACTION_ACTOR_RANGE = 5000;

		// Token: 0x04012D24 RID: 77092
		private const int DYNAMIC_PHYSICS_INTERACTION_ACTOR_RANGE = 2500;

		// Token: 0x04012D25 RID: 77093
		private const int STATIC_PHYSICS_INTERACTION_ACTOR_RANGE = 1500;

		// Token: 0x04012D26 RID: 77094
		private TsGameBudgetGroupConfigCache TsNormalEntityGroupConfigInternal;

		// Token: 0x04012D27 RID: 77095
		private TsGameBudgetGroupConfigCache TsBossEntityGroupConfigInternal;

		// Token: 0x04012D28 RID: 77096
		private TsGameBudgetGroupConfigCache TsCharacterEntityGroupConfigInternal;

		// Token: 0x04012D29 RID: 77097
		private TsGameBudgetGroupConfigCache TsNormalNpcEntityGroupConfigInternal;

		// Token: 0x04012D2A RID: 77098
		private TsGameBudgetGroupConfigCache TsSimpleNpcEntityGroupConfigInternal;

		// Token: 0x04012D2B RID: 77099
		private TsGameBudgetGroupConfigCache TsFightEffectGroupConfigInternal;

		// Token: 0x04012D2C RID: 77100
		private TsGameBudgetGroupConfigCache TsEffectGroupConfigInternal;

		// Token: 0x04012D2D RID: 77101
		private TsGameBudgetGroupConfigCache TsEffectInportanceGroupConfigInternal;

		// Token: 0x04012D2E RID: 77102
		private TsGameBudgetGroupConfigCache TsAlwaysTickConfigInternal;

		// Token: 0x04012D2F RID: 77103
		private TsGameBudgetGroupConfigCache TsPlayerAlwaysTickConfigInternal;

		// Token: 0x04012D30 RID: 77104
		private TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickConfigInternal;

		// Token: 0x04012D31 RID: 77105
		private TsGameBudgetGroupConfigCache TsNormalEntityAlwaysTickWithoutNotRenderedConfigInternal;

		// Token: 0x04012D32 RID: 77106
		private TsGameBudgetGroupConfigCache TsIdleExecConfigInternal;

		// Token: 0x04012D33 RID: 77107
		private TsGameBudgetGroupConfigCache TsAlwaysTick2ConfigInternal;

		// Token: 0x04012D34 RID: 77108
		private TsGameBudgetGroupConfigCache TsHUDTickConfigInternal;

		// Token: 0x04012D35 RID: 77109
		private TsGameBudgetGroupConfigCache TsCharacterRenderConfigInternal;

		// Token: 0x04012D36 RID: 77110
		private TsGameBudgetGroupConfigCache TsNpcRenderConfigInternal;

		// Token: 0x04012D37 RID: 77111
		private TsGameBudgetGroupConfigCache TsStabilizeLowEntityGroupConfigInternal;

		// Token: 0x04012D38 RID: 77112
		private TsGameBudgetGroupConfigCache TsBattleHeadStateViewConfigInternal;

		// Token: 0x04012D39 RID: 77113
		private GameBudgetAllocatorConfig TsCharacterDtailConfigInternal;

		// Token: 0x04012D3A RID: 77114
		private TsGameBudgetGroupConfigCache TsAlwaysTickHotFixConfigInternal;

		// Token: 0x04012D3B RID: 77115
		private TsGameBudgetGroupConfigCache TsMoveSceneItemEntityConfigInternal;

		// Token: 0x04012D3C RID: 77116
		private TsGameBudgetGroupConfigCache TsCollisionPlantConfigInternal;

		// Token: 0x04012D3D RID: 77117
		private TsGameBudgetGroupConfigCache TsBlueprintSingletonConfigInternal;

		// Token: 0x04012D3E RID: 77118
		private TsGameBudgetGroupConfigCache TsSceneBlueprintActorConfigInternal;

		// Token: 0x04012D3F RID: 77119
		private TsGameBudgetGroupConfigCache TsFarBlueprintActorConfigInternal;

		// Token: 0x04012D40 RID: 77120
		private TsGameBudgetGroupConfigCache TsSuperFarBlueprintActorConfigInternal;

		// Token: 0x04012D41 RID: 77121
		private TsGameBudgetGroupConfigCache TsDynamicPhysicsInteractionActorConfigInternal;

		// Token: 0x04012D42 RID: 77122
		private TsGameBudgetGroupConfigCache TsStaticPhysicsInteractionActorConfigInternal;

		// Token: 0x04012D43 RID: 77123
		private TsGameBudgetGroupConfigCache TsHighPriorityPhysicsInteractionActorConfigInternal;

		// Token: 0x04012D44 RID: 77124
		private TsGameBudgetGroupConfigCache TsSpecialBlueprintActorConfigInternal;

		// Token: 0x04012D45 RID: 77125
		private TsGameBudgetGroupConfigCache TsSparseGridPhysicsInteractionActorConfigInternal;

		// Token: 0x04012D46 RID: 77126
		private TsGameBudgetGroupConfigCache TsScreenDecalActorConfigInternal;

		// Token: 0x04012D47 RID: 77127
		public readonly Dictionary<uint, TsGameBudgetGroupConfigCache> TsEffectDynamicGroupConfigMap = new Dictionary<uint, TsGameBudgetGroupConfigCache>();

		// Token: 0x04012D48 RID: 77128
		[Nullable(2)]
		private static GameBudgetAllocatorConfigCreator _instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x020034AA RID: 13482
	public class ServerStorageDefine
	{
		// Token: 0x04012E7C RID: 77436
		public const int SERVER_STORAGE_SAVE_DELAY = 3000;

		// Token: 0x04012E7D RID: 77437
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static IReadOnlyDictionary<EClientStorageSystemIdType, Func<EClientStorageSystemIdType, ServerStorageEntryBase>> ServerStorageEntryRegistry = new Dictionary<EClientStorageSystemIdType, Func<EClientStorageSystemIdType, ServerStorageEntryBase>>
		{
			{
				EClientStorageSystemIdType.Default,
				delegate(EClientStorageSystemIdType key)
				{
					throw new InvalidOperationException("None key is not valid");
				}
			},
			{
				EClientStorageSystemIdType.Activity,
				(EClientStorageSystemIdType key) => new ServerStorageMapMap(key)
			},
			{
				EClientStorageSystemIdType.VisionSkin,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.LoopTowerIsClickSeason,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.LoopTowerIsClickShop,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.TowerOverLockArea,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.WeaponSkinRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FlySkinRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.CalabashSkinRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.MailBindNextShowRedDotTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.RedDotAdventureNewSoundAreaTabLastUpdateTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.SuitWeaponFirstWearRecord,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RoleSkinRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FirstOpenVisionGroup,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ShipTowerSeason,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.AdventrueShipTowerSeason,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.AdventrueWeeklyRogue,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.AdventrueTower,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.IntroductionVersion,
				(EClientStorageSystemIdType key) => new ServerStorageString(key)
			},
			{
				EClientStorageSystemIdType.DetectionRedDotRecord,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.ExploreActivityFirstUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.FilterRedPoint,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.VisionRecoveryBatchTip,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.VisionRecoveryBatchAimTip,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.MotorDiyNewUnlockId,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.MotorSceneHadCheck,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.MotorDevelopNewUnlockTree,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.PhantomBattleConfigApplyPlanWhenSaved,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.FeiXuePreheatSubViewRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.DropCatchRoleClickDetail,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FlagChallengeNewlyUnlockedLevelIds,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuff,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.PeriodicActivityRedLogReport,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.CoopRolePhotoRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.CoopRoleNewLevelRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuffIds,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RoguelikeNewPhantomUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RoguelikeNewCharacterUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RoguelikeNewEntriesGroupUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.AnniversaryActivityFirstClick,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.VisionRefineTip,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.Ornament,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.GetOrnament,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.GolemCrack,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.GachaAccumulateFirstOpen,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.Photography,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.PhoneMsgChatShowRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.ItemBackpackFirstCheck,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.QuestBranchSystem,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.WheelTowerSeasonReview,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.ThroughTrainFirstCheck,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.VersionPayGiftRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.NormalPayGiftRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.FightPhotoTab,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.FirstOpenDailyActivityTab,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.ActivityRecommend,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.RoleLangCustomFuncClicked,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.RoleLangCustomRecord,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.ActivityRecommend2,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.PhoneMsgLastOpenBigPanelTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.TrialRoleGroupUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.ActivityRecallSplashFirstShowTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.ActivityRecallWatchFirstShowTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressSignLastDailyFirstShowTimeStamp,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressShopRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressQuestionnaireRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressDoubleDropReminderLastShowTime,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressDoubleDropFirstRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressBpPayButtonRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressTrialRoleRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressDoubleDropRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressRecommendRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.RogueResDungeonNewest,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.RogueResSkillTreeOpen,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RogueResEndingOpen,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.RogueResTaskOpen,
				(EClientStorageSystemIdType key) => new ServerStorageLong(key)
			},
			{
				EClientStorageSystemIdType.RogueResTrialOpen,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.RogueResNewRoleFlag,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.RogueResDungeonSelected,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.RogueResShopRefresh,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.RogueResShopNewGoods,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.ShowPersonalTip,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.FragmentMemoryOpened,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.PlayerTitleUnlockRedDot,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaEntranceShopRefresh,
				(EClientStorageSystemIdType key) => new ServerStorageString(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaEntranceGymCheck,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaRepeatLastIndex,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaEntranceGymRedDotCheck,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaChallengeUnlockRedDotCheck,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.PhantomArenaMapUnlockRedDotCheck,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseLevelReachOpenTime,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseRougeModeOpen,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseRougeModeOpenSub,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseBdBuffUnlock,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseBuildingClicked,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.TrapDefenseAuxiliaryClicked,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.DangoMonopolyNewTask,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.AbyssDangoRoleNew,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.AbyssDangoFormationNew,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.AbyssDangoLevelCheck,
				(EClientStorageSystemIdType key) => new ServerStorageMap(key)
			},
			{
				EClientStorageSystemIdType.AbyssDangoEnterNew,
				(EClientStorageSystemIdType key) => new ServerStorageBoolean(key)
			},
			{
				EClientStorageSystemIdType.InfrRecordObservatoryLevel,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.InfrRoadMarkUnlockRecord,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			},
			{
				EClientStorageSystemIdType.InfrObservatoryLevelUpSeq,
				(EClientStorageSystemIdType key) => new ServerStorageNumber(key)
			},
			{
				EClientStorageSystemIdType.WeatherCentralClicked,
				(EClientStorageSystemIdType key) => new ServerStorageSet(key)
			}
		};
	}
}

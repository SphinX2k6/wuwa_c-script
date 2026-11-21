using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.VillageInfr;

namespace CSharpScript.Game.Module.Map.Marks
{
	// Token: 0x020044A5 RID: 17573
	[NullableContext(2)]
	[Nullable(0)]
	public static class MarkItemDataUtil
	{
		// Token: 0x0602C5B1 RID: 181681 RVA: 0x00C78498 File Offset: 0x00C76698
		public static EMarkType TransformMarkTypeToClient(int markType)
		{
			return MarkItemDataUtil.TransformMarkTypeMap.GetValueOrDefault((PbMapMarkType.Types.ENUMS)markType, EMarkType.None);
		}

		// Token: 0x0602C5B2 RID: 181682 RVA: 0x00C784B4 File Offset: 0x00C766B4
		public static string GetMarkIcon(int markConfigId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markConfigId);
			if (configMark == null)
			{
				return null;
			}
			EMarkType objectType = (EMarkType)configMark.Value.ObjectType;
			if (objectType != EMarkType.SceneGameplay && objectType != EMarkType.FixedSceneGameplay)
			{
				if (objectType - EMarkType.HonamiScan > 1)
				{
					return configMark.Value.LockMarkPic;
				}
				if (MapModel.Instance.IsConfigMarkIdUnlock(markConfigId))
				{
					return configMark.Value.UnlockMarkPic;
				}
				return configMark.Value.LockMarkPic;
			}
			else
			{
				global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(configMark.Value.RelativeId);
				if (levelPlayInfo == null || levelPlayInfo.IsClose)
				{
					return configMark.Value.LockMarkPic;
				}
				return configMark.Value.UnlockMarkPic;
			}
		}

		// Token: 0x0602C5B3 RID: 181683 RVA: 0x00C7857C File Offset: 0x00C7677C
		public static string GetMarkTopRightIconPath(int markId, EMarkType markType, bool isDisable, bool isGameplayFinish)
		{
			if (isDisable)
			{
				return UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
			}
			if (MapModel.Instance.IsCompleteMark(markId))
			{
				return UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (isGameplayFinish && (!MapDefine.CanDisableGameplayFinishMarkType.Contains(markType) || configMark == null || !configMark.GetValueOrDefault().IsDisableGameplayFinishIcon))
			{
				return UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
			}
			if (configMark != null)
			{
				MapMark value = configMark.Value;
				int relativeSubType = value.RelativeSubType;
				if (relativeSubType == 9 || relativeSubType == 10)
				{
					ValueTuple<int, int> nightMareTarget = AdventureGuideModel.Instance.GetNightMareTarget(new int?(value.MapId), new int?(value.RelativeId));
					if (nightMareTarget.Item1 == nightMareTarget.Item2 && nightMareTarget.Item2 > 0)
					{
						return UiResourceConfig.Instance.GetResourcePath("SP_MarkTimeLimit");
					}
				}
				if (relativeSubType == 7)
				{
					int activityId = FlagChallengeBattleModel.Instance.ActivityId;
					FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
					FlagChallengeStrongholdData flagChallengeStrongholdData = (flagChallengeData != null) ? flagChallengeData.GetStrongholdDataByMarkId(markId) : null;
					if (flagChallengeStrongholdData != null && flagChallengeStrongholdData.IsPass)
					{
						return UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
					}
				}
			}
			if (markType == EMarkType.InfrRoad)
			{
				InfrRoadBuild? roadConfigByMarkId = InfrastructureConfig.Instance.GetRoadConfigByMarkId(markId);
				if (InfrastructureModel.Instance.GetRoadMaterialEnough(roadConfigByMarkId.Value.Id))
				{
					return UiResourceConfig.Instance.GetResourcePath("SP_InfrastructureUpgradeIcon");
				}
			}
			if (markType == EMarkType.VillageInfr && VillageInfrModel.Instance.GetCanVillageLevelUp())
			{
				return UiResourceConfig.Instance.GetResourcePath("SP_InfrastructureUpgradeIcon");
			}
			if (markType == EMarkType.VillageInfrTree)
			{
				InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(markId);
				if (treeConfigByMarkId != null)
				{
					InfrV2TreeBuild valueOrDefault = treeConfigByMarkId.GetValueOrDefault();
					if (VillageInfrModel.Instance.GetCanTreeLevelUp(valueOrDefault.Id))
					{
						return UiResourceConfig.Instance.GetResourcePath("SP_InfrastructureUpgradeIcon");
					}
				}
			}
			return null;
		}

		// Token: 0x0602C5B4 RID: 181684 RVA: 0x00C78768 File Offset: 0x00C76968
		public static bool IsCommonGamePlayMarkComplete(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null)
			{
				return false;
			}
			LevelPlayReportModel instance = LevelPlayReportModel.Instance;
			if (instance.IsCommonLevelPlayComplete(configMark.Value.RelativeDungeonId, configMark.Value.RelativeId))
			{
				return true;
			}
			if (configMark.Value.ObjectType != 29)
			{
				return false;
			}
			for (int i = 0; i < configMark.Value.AssociatedGameplayMarksLength; i++)
			{
				int markId2 = configMark.Value.AssociatedGameplayMarks(i);
				MapMark? configMark2 = MapConfig.Instance.GetConfigMark(markId2);
				if (configMark2 != null && instance.IsCommonLevelPlayComplete(configMark2.Value.RelativeDungeonId, configMark2.Value.RelativeId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602C5B5 RID: 181685 RVA: 0x00C7883C File Offset: 0x00C76A3C
		// Note: this type is marked as 'beforefieldinit'.
		static MarkItemDataUtil()
		{
			Dictionary<PbMapMarkType.Types.ENUMS, EMarkType> dictionary = new Dictionary<PbMapMarkType.Types.ENUMS, EMarkType>();
			dictionary[PbMapMarkType.Types.ENUMS.None] = EMarkType.None;
			dictionary[PbMapMarkType.Types.ENUMS.Custom] = EMarkType.Custom;
			dictionary[PbMapMarkType.Types.ENUMS.Quest] = EMarkType.Quest;
			dictionary[PbMapMarkType.Types.ENUMS.TemporaryTeleport] = EMarkType.TemporaryTeleport;
			dictionary[PbMapMarkType.Types.ENUMS.SoundBox] = EMarkType.SoundBox;
			dictionary[PbMapMarkType.Types.ENUMS.HookLockSoundBox] = EMarkType.SoundBox;
			dictionary[PbMapMarkType.Types.ENUMS.TreasureBoxPoint] = EMarkType.TreasureBoxDetector;
			dictionary[PbMapMarkType.Types.ENUMS.TreasureBox] = EMarkType.TreasureBox;
			dictionary[PbMapMarkType.Types.ENUMS.CalmingWindBell] = EMarkType.CalmingWindBell;
			dictionary[PbMapMarkType.Types.ENUMS.EnrichmentArea] = EMarkType.EnrichmentArea;
			dictionary[PbMapMarkType.Types.ENUMS.EnrichmentAreaChild] = EMarkType.EnrichmentCollectProduct;
			dictionary[PbMapMarkType.Types.ENUMS.HonamiStory] = EMarkType.HonamiScan;
			dictionary[PbMapMarkType.Types.ENUMS.HonamiStoryChild] = EMarkType.HonamiScanItem;
			dictionary[PbMapMarkType.Types.ENUMS.LahairoHookLock] = EMarkType.SoundBox;
			dictionary[PbMapMarkType.Types.ENUMS.LiangYuanSoundBox] = EMarkType.SoundBox;
			MarkItemDataUtil.TransformMarkTypeMap = dictionary;
		}

		// Token: 0x04017E02 RID: 97794
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<PbMapMarkType.Types.ENUMS, EMarkType> TransformMarkTypeMap;
	}
}

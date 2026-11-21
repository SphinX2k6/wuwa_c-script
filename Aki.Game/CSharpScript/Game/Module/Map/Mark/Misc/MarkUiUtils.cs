using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.Mark.Misc
{
	// Token: 0x020044A1 RID: 17569
	[NullableContext(1)]
	[Nullable(0)]
	public static class MarkUiUtils
	{
		// Token: 0x0602C5A6 RID: 181670 RVA: 0x00C779D0 File Offset: 0x00C75BD0
		public static bool IsShowGoto(MarkItem markItem)
		{
			TeleportMarkItem teleportMarkItem = markItem as TeleportMarkItem;
			if (teleportMarkItem != null && !teleportMarkItem.IsActivity)
			{
				return teleportMarkItem.IsLocked;
			}
			HonamiScanMarkItem honamiScanMarkItem = markItem as HonamiScanMarkItem;
			if (honamiScanMarkItem != null)
			{
				return honamiScanMarkItem.IsLocked;
			}
			if (markItem.MarkType != EMarkType.CorniceMeeting)
			{
				SceneGameplayMarkItem sceneGameplayMarkItem = markItem as SceneGameplayMarkItem;
				if (sceneGameplayMarkItem != null)
				{
					if (sceneGameplayMarkItem.IsLocked)
					{
						return true;
					}
					MapMark? mapMark;
					LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo((sceneGameplayMarkItem.MarkConfig != null) ? mapMark.GetValueOrDefault().RelativeId : 0);
					return levelPlayInfo == null || levelPlayInfo.IsClose;
				}
				else
				{
					FixedSceneGameplayMarkItem fixedSceneGameplayMarkItem = markItem as FixedSceneGameplayMarkItem;
					if (fixedSceneGameplayMarkItem != null)
					{
						return fixedSceneGameplayMarkItem.IsLocked;
					}
				}
			}
			if (markItem is TaskMarkItem)
			{
				return true;
			}
			if (markItem.MarkType == EMarkType.PunishReport || markItem.MarkType == EMarkType.LevelPlayReport)
			{
				ConfigMarkItem configMarkItem = markItem as ConfigMarkItem;
				return configMarkItem != null && configMarkItem.IsLocked;
			}
			if (MarkUiUtils.ShowGotoMarkTypeSet.Contains(markItem.MarkType))
			{
				return true;
			}
			DynamicEntityMarkItem dynamicEntityMarkItem = markItem as DynamicEntityMarkItem;
			if (dynamicEntityMarkItem != null)
			{
				MonsterDetection? monsterDetectionConfig = MapConfig.Instance.GetMonsterDetectionConfig(dynamicEntityMarkItem.MarkConfigId);
				if (monsterDetectionConfig != null)
				{
					EDangerType dangerType = (EDangerType)monsterDetectionConfig.Value.DangerType;
					if (MarkUiUtils.DangerFullOpenGoToMap.GetValueOrDefault(dangerType, false))
					{
						return true;
					}
				}
				TTrackTarget_Int ttrackTarget_Int = dynamicEntityMarkItem.TrackTarget as TTrackTarget_Int;
				return ttrackTarget_Int == null || !CreatureModel.Instance.CheckEntityVisible(ttrackTarget_Int);
			}
			return WorldMapSecondaryUiDefine.MarkPanelTypeMap.GetValueOrDefault(markItem.MarkType, ESecondaryPanel.GeneralPanel) == ESecondaryPanel.GeneralPanel;
		}

		// Token: 0x0602C5A7 RID: 181671 RVA: 0x00C77B44 File Offset: 0x00C75D44
		[return: Nullable(2)]
		public static MarkItem FindNearbyValidGotoMark(BaseMap map, MarkItem markItem)
		{
			float searchRadius = (float)(ConfigCommonParamById.GetIntConfig("QuickTransferRange").GetValueOrDefault() * 100);
			int targetMultiMapId = markItem.GetMultiMapId();
			bool flag = targetMultiMapId != 0;
			List<ValueTuple<MarkItem, double>> list = map.FindNearbyMarkItems(markItem, searchRadius, delegate(MarkItem result)
			{
				if (MapHelper.IsRecallContextMismatched(result.MarkId))
				{
					return false;
				}
				EMapGravityDirection gravity = result.Gravity;
				if (!WorldMapModel.Instance.IsMarkInGravityLayer(result.MarkId, gravity))
				{
					return false;
				}
				EMapGravityDirection gravity2 = markItem.Gravity;
				if (gravity2 == EMapGravityDirection.All)
				{
					return result != markItem;
				}
				return result != markItem && gravity == gravity2;
			});
			if (flag)
			{
				float num = (float)(ConfigCommonParamById.GetIntConfig("SameLayerQuickTransferRange").GetValueOrDefault() * 100);
				double sameLayerRangeSquared = (double)(num * num);
				list.Sort(delegate([Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> a, [Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MarkItem, double> b)
				{
					int num2 = (a.Item2 <= sameLayerRangeSquared && a.Item1.GetMultiMapId() == targetMultiMapId) ? 0 : 1;
					int num3 = (b.Item2 <= sameLayerRangeSquared && b.Item1.GetMultiMapId() == targetMultiMapId) ? 0 : 1;
					if (num2 != num3)
					{
						return num2 - num3;
					}
					return a.Item2.CompareTo(b.Item2);
				});
			}
			foreach (ValueTuple<MarkItem, double> valueTuple in list)
			{
				MarkItem item = new ValueTuple<MarkItem, float>(valueTuple.Item1, (float)valueTuple.Item2).Item1;
				TeleportMarkItem teleportMarkItem = item as TeleportMarkItem;
				if (teleportMarkItem != null && !teleportMarkItem.IsLocked && teleportMarkItem.CanConditionShowView())
				{
					return teleportMarkItem;
				}
				TemporaryTeleportMarkItem temporaryTeleportMarkItem = item as TemporaryTeleportMarkItem;
				if (temporaryTeleportMarkItem != null)
				{
					return temporaryTeleportMarkItem;
				}
				if (item is FixedSceneGameplayMarkItem || item is SceneGameplayMarkItem)
				{
					ConfigMarkItem configMarkItem = (ConfigMarkItem)item;
					if (!configMarkItem.IsLocked && !configMarkItem.IsLordGym())
					{
						LevelPlayModel instance = LevelPlayModel.Instance;
						MapMark? markConfig = configMarkItem.MarkConfig;
						LevelPlayInfo levelPlayInfo = instance.GetLevelPlayInfo((markConfig != null) ? markConfig.GetValueOrDefault().RelativeId : 0);
						if (levelPlayInfo != null && !levelPlayInfo.IsClose && !MapModel.Instance.IsLevelPlayOccupied(levelPlayInfo.Id).IsOccupied)
						{
							return item;
						}
					}
				}
				ConfigMarkItem configMarkItem2 = item as ConfigMarkItem;
				if (configMarkItem2 != null)
				{
					MapMark? markConfig = configMarkItem2.MarkConfig;
					if (markConfig != null && markConfig.GetValueOrDefault().EnableQuickTransfer == 1 && !configMarkItem2.IsLocked && configMarkItem2.CanConditionShowView())
					{
						return configMarkItem2;
					}
				}
			}
			return null;
		}

		// Token: 0x0602C5A8 RID: 181672 RVA: 0x00C77D78 File Offset: 0x00C75F78
		public static int? FindNearbyValidGotoMarkByPosition(BaseMap map, global::Vector position)
		{
			int? result = ConfigCommonParamById.GetIntConfig("QuickTransferRange");
			float searchRadius = (float)(result.GetValueOrDefault() * 100);
			List<ValueTuple<MarkItem, double>> list = map.FindNearbyMarkItemsByPosition(position, searchRadius, null);
			if (list == null)
			{
				result = null;
				return result;
			}
			foreach (ValueTuple<MarkItem, double> valueTuple in list)
			{
				MarkItem item = valueTuple.Item1;
				TeleportMarkItem teleportMarkItem = item as TeleportMarkItem;
				if (teleportMarkItem != null && !teleportMarkItem.IsLocked && teleportMarkItem.CanConditionShowView())
				{
					return new int?(teleportMarkItem.MarkConfigId);
				}
				if (item is FixedSceneGameplayMarkItem || item is SceneGameplayMarkItem)
				{
					ConfigMarkItem configMarkItem = (ConfigMarkItem)item;
					if (!configMarkItem.IsLocked && !configMarkItem.IsLordGym())
					{
						LevelPlayModel instance = LevelPlayModel.Instance;
						MapMark? markConfig = configMarkItem.MarkConfig;
						LevelPlayInfo levelPlayInfo = instance.GetLevelPlayInfo((markConfig != null) ? markConfig.GetValueOrDefault().RelativeId : 0);
						if (levelPlayInfo != null && !levelPlayInfo.IsClose && !MapModel.Instance.IsLevelPlayOccupied(levelPlayInfo.Id).IsOccupied)
						{
							return new int?(item.MarkId);
						}
					}
				}
				ConfigMarkItem configMarkItem2 = item as ConfigMarkItem;
				if (configMarkItem2 != null)
				{
					MapMark? markConfig = configMarkItem2.MarkConfig;
					if (markConfig != null && markConfig.GetValueOrDefault().EnableQuickTransfer == 1 && !configMarkItem2.IsLocked && configMarkItem2.CanConditionShowView())
					{
						return new int?(configMarkItem2.MarkConfigId);
					}
				}
			}
			return null;
		}

		// Token: 0x0602C5A9 RID: 181673 RVA: 0x00C77F30 File Offset: 0x00C76130
		public static void QuickGotoTeleport(MarkItem markItem, MarkItem teleportMarkItem, [Nullable(2)] TOnTelSuccessCallBack successTelAction = null)
		{
			MarkUiUtils.<>c__DisplayClass5_0 CS$<>8__locals1 = new MarkUiUtils.<>c__DisplayClass5_0();
			CS$<>8__locals1.markItem = markItem;
			CS$<>8__locals1.teleportMarkItem = teleportMarkItem;
			CS$<>8__locals1.successTelAction = successTelAction;
			CS$<>8__locals1.playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (CS$<>8__locals1.playerLocation == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[地图系统]MarkUiUtils->没有玩家坐标，快速前往失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", CS$<>8__locals1.teleportMarkItem.MarkId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool flag = true;
			TeleportMarkItem teleportMarkItem2 = CS$<>8__locals1.teleportMarkItem as TeleportMarkItem;
			if (teleportMarkItem2 != null)
			{
				flag = !teleportMarkItem2.IsLocked;
			}
			if (flag)
			{
				if (WorldMapModel.Instance.HideQuickTransferConfirmBox)
				{
					CS$<>8__locals1.<QuickGotoTeleport>g__DistanceCheckConfirmBoxFunc|3();
					return;
				}
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuickTranser);
				confirmBoxDataNew.HasToggle = true;
				confirmBoxDataNew.ToggleTextKey = "Text_FastTravelConfirmToggle_text";
				confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
				{
					WorldMapModel.Instance.HideQuickTransferConfirmBox = isSelectOn;
				});
				confirmBoxDataNew.FunctionMap[1] = new Action(MarkUiUtils.<QuickGotoTeleport>g__CloseFunction|5_5);
				confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<QuickGotoTeleport>g__DistanceCheckConfirmBoxFunc|3);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x0602C5AA RID: 181674 RVA: 0x00C78064 File Offset: 0x00C76264
		public static bool IsDungeonBelongDiffMap(int srcDungeonId, int dstDungeonId)
		{
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(srcDungeonId);
			InstanceDungeon? dungeonConfig2 = WorldMapConfig.Instance.GetDungeonConfig(dstDungeonId);
			int num = (dungeonConfig != null) ? dungeonConfig.GetValueOrDefault().MapConfigId : srcDungeonId;
			int num2 = (dungeonConfig2 != null) ? dungeonConfig2.GetValueOrDefault().MapConfigId : dstDungeonId;
			return num != num2;
		}

		// Token: 0x0602C5AB RID: 181675 RVA: 0x00C780C6 File Offset: 0x00C762C6
		// Note: this type is marked as 'beforefieldinit'.
		static MarkUiUtils()
		{
			Dictionary<EDangerType, bool> dictionary = new Dictionary<EDangerType, bool>();
			dictionary[EDangerType.VeryLow] = true;
			dictionary[EDangerType.Low] = true;
			dictionary[EDangerType.Middle] = false;
			dictionary[EDangerType.High] = false;
			MarkUiUtils.DangerFullOpenGoToMap = dictionary;
			MarkUiUtils.ShowGotoMarkTypeSet = new HashSet<EMarkType>
			{
				EMarkType.CaveHole
			};
		}

		// Token: 0x0602C5AC RID: 181676 RVA: 0x00C78105 File Offset: 0x00C76305
		[CompilerGenerated]
		internal static void <QuickGotoTeleport>g__CloseFunction|5_5()
		{
			WorldMapModel.Instance.HideQuickTransferConfirmBox = false;
		}

		// Token: 0x04017DD4 RID: 97748
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EDangerType, bool> DangerFullOpenGoToMap;

		// Token: 0x04017DD5 RID: 97749
		[StaticVariableRuleIgnore]
		private static readonly HashSet<EMarkType> ShowGotoMarkTypeSet;
	}
}

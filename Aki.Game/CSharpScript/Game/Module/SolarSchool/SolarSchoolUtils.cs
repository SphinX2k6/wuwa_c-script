using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005986 RID: 22918
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolUtils
	{
		// Token: 0x060387E2 RID: 231394 RVA: 0x00FCD980 File Offset: 0x00FCBB80
		internal static SolarSchoolSlotLocalData LoadLocalSlot(int activityId, int slotId)
		{
			SolarSchoolLocalStorageData player = LocalStorage.GetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, null);
			SolarSchoolActivityLocalData solarSchoolActivityLocalData;
			SolarSchoolSlotLocalData source;
			if (player == null || !player.Activities.TryGetValue(activityId, out solarSchoolActivityLocalData) || !solarSchoolActivityLocalData.Slots.TryGetValue(slotId, out source))
			{
				return new SolarSchoolSlotLocalData();
			}
			return SolarSchoolUtils.CloneLocalSlot(source);
		}

		// Token: 0x060387E3 RID: 231395 RVA: 0x00FCD9C8 File Offset: 0x00FCBBC8
		internal unsafe static bool SaveLocalSlot(int activityId, int slotId, SolarSchoolSlotLocalData slotData)
		{
			if (activityId <= 0 || slotId < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 保存本地记录失败：存档定位参数非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slotId", slotId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			SolarSchoolLocalStorageData solarSchoolLocalStorageData = LocalStorage.GetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, null) ?? new SolarSchoolLocalStorageData();
			Dictionary<int, SolarSchoolActivityLocalData> dictionary = SolarSchoolUtils.CloneLocalActivities(solarSchoolLocalStorageData.Activities);
			SolarSchoolActivityLocalData solarSchoolActivityLocalData;
			if (!dictionary.TryGetValue(activityId, out solarSchoolActivityLocalData))
			{
				solarSchoolActivityLocalData = new SolarSchoolActivityLocalData();
			}
			Dictionary<int, SolarSchoolSlotLocalData> dictionary2 = SolarSchoolUtils.CloneLocalSlots(solarSchoolActivityLocalData.Slots);
			dictionary2[slotId] = SolarSchoolUtils.CloneLocalSlot(slotData);
			dictionary[activityId] = new SolarSchoolActivityLocalData
			{
				Slots = dictionary2
			};
			SolarSchoolLocalStorageData value = new SolarSchoolLocalStorageData
			{
				Activities = dictionary,
				RedDots = SolarSchoolUtils.CloneRedDotMap(solarSchoolLocalStorageData.RedDots)
			};
			if (LocalStorage.SetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, value))
			{
				return true;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] 保存本地记录失败：LocalStorage 写入失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("slotId", slotId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}

		// Token: 0x060387E4 RID: 231396 RVA: 0x00FCDB30 File Offset: 0x00FCBD30
		internal static SolarSchoolSlotLocalData AddLocalRecord(SolarSchoolSlotLocalData source, ESolarSchoolLocalRecordType recordType, int recordId)
		{
			Dictionary<ESolarSchoolLocalRecordType, HashSet<int>> dictionary = SolarSchoolUtils.CloneLocalRecords(source.Records);
			HashSet<int> collection;
			HashSet<int> hashSet = dictionary.TryGetValue(recordType, out collection) ? new HashSet<int>(collection) : new HashSet<int>();
			hashSet.Add(recordId);
			dictionary[recordType] = hashSet;
			return new SolarSchoolSlotLocalData
			{
				Records = dictionary
			};
		}

		// Token: 0x060387E5 RID: 231397 RVA: 0x00FCDB7E File Offset: 0x00FCBD7E
		internal static SolarSchoolSlotLocalData CloneLocalSlot(SolarSchoolSlotLocalData source)
		{
			return new SolarSchoolSlotLocalData
			{
				Records = SolarSchoolUtils.CloneLocalRecords(source.Records)
			};
		}

		// Token: 0x060387E6 RID: 231398 RVA: 0x00FCDB98 File Offset: 0x00FCBD98
		private static Dictionary<int, SolarSchoolActivityLocalData> CloneLocalActivities(IReadOnlyDictionary<int, SolarSchoolActivityLocalData> source)
		{
			Dictionary<int, SolarSchoolActivityLocalData> dictionary = new Dictionary<int, SolarSchoolActivityLocalData>(source.Count);
			foreach (KeyValuePair<int, SolarSchoolActivityLocalData> keyValuePair in source)
			{
				int num;
				SolarSchoolActivityLocalData solarSchoolActivityLocalData;
				keyValuePair.Deconstruct(out num, out solarSchoolActivityLocalData);
				int key = num;
				SolarSchoolActivityLocalData solarSchoolActivityLocalData2 = solarSchoolActivityLocalData;
				dictionary[key] = new SolarSchoolActivityLocalData
				{
					Slots = SolarSchoolUtils.CloneLocalSlots(solarSchoolActivityLocalData2.Slots)
				};
			}
			return dictionary;
		}

		// Token: 0x060387E7 RID: 231399 RVA: 0x00FCDC18 File Offset: 0x00FCBE18
		private static Dictionary<int, SolarSchoolSlotLocalData> CloneLocalSlots(IReadOnlyDictionary<int, SolarSchoolSlotLocalData> source)
		{
			Dictionary<int, SolarSchoolSlotLocalData> dictionary = new Dictionary<int, SolarSchoolSlotLocalData>(source.Count);
			foreach (KeyValuePair<int, SolarSchoolSlotLocalData> keyValuePair in source)
			{
				int num;
				SolarSchoolSlotLocalData solarSchoolSlotLocalData;
				keyValuePair.Deconstruct(out num, out solarSchoolSlotLocalData);
				int key = num;
				SolarSchoolSlotLocalData source2 = solarSchoolSlotLocalData;
				dictionary[key] = SolarSchoolUtils.CloneLocalSlot(source2);
			}
			return dictionary;
		}

		// Token: 0x060387E8 RID: 231400 RVA: 0x00FCDC88 File Offset: 0x00FCBE88
		private static Dictionary<ESolarSchoolLocalRecordType, HashSet<int>> CloneLocalRecords(IReadOnlyDictionary<ESolarSchoolLocalRecordType, HashSet<int>> source)
		{
			Dictionary<ESolarSchoolLocalRecordType, HashSet<int>> dictionary = new Dictionary<ESolarSchoolLocalRecordType, HashSet<int>>(source.Count);
			foreach (KeyValuePair<ESolarSchoolLocalRecordType, HashSet<int>> keyValuePair in source)
			{
				ESolarSchoolLocalRecordType esolarSchoolLocalRecordType;
				HashSet<int> hashSet;
				keyValuePair.Deconstruct(out esolarSchoolLocalRecordType, out hashSet);
				ESolarSchoolLocalRecordType key = esolarSchoolLocalRecordType;
				HashSet<int> collection = hashSet;
				dictionary[key] = new HashSet<int>(collection);
			}
			return dictionary;
		}

		// Token: 0x060387E9 RID: 231401 RVA: 0x00FCDCF8 File Offset: 0x00FCBEF8
		internal static SolarSchoolRedDotLocalData LoadRedDotData(int activityId)
		{
			SolarSchoolLocalStorageData player = LocalStorage.GetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, null);
			SolarSchoolRedDotLocalData solarSchoolRedDotLocalData;
			if (player == null || !player.RedDots.TryGetValue(activityId, out solarSchoolRedDotLocalData) || solarSchoolRedDotLocalData == null)
			{
				return new SolarSchoolRedDotLocalData();
			}
			return SolarSchoolUtils.CloneRedDotData(solarSchoolRedDotLocalData);
		}

		// Token: 0x060387EA RID: 231402 RVA: 0x00FCDD34 File Offset: 0x00FCBF34
		internal static bool SaveRedDotData(int activityId, SolarSchoolRedDotLocalData data)
		{
			if (activityId <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 保存红点记录失败：活动 id 非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			SolarSchoolLocalStorageData solarSchoolLocalStorageData = LocalStorage.GetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, null) ?? new SolarSchoolLocalStorageData();
			Dictionary<int, SolarSchoolRedDotLocalData> dictionary = SolarSchoolUtils.CloneRedDotMap(solarSchoolLocalStorageData.RedDots);
			dictionary[activityId] = SolarSchoolUtils.CloneRedDotData(data);
			if (LocalStorage.SetPlayer<SolarSchoolLocalStorageData>(ELocalStoragePlayerKey.SolarSchoolLocalRecords, new SolarSchoolLocalStorageData
			{
				Activities = SolarSchoolUtils.CloneLocalActivities(solarSchoolLocalStorageData.Activities),
				RedDots = dictionary
			}))
			{
				return true;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] 保存红点记录失败：LocalStorage 写入失败";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("activityId", activityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}

		// Token: 0x060387EB RID: 231403 RVA: 0x00FCDDFF File Offset: 0x00FCBFFF
		private static SolarSchoolRedDotLocalData CloneRedDotData(SolarSchoolRedDotLocalData source)
		{
			return new SolarSchoolRedDotLocalData
			{
				GoEntranceRedDotConsumed = source.GoEntranceRedDotConsumed,
				ViewedGalleryIds = new HashSet<int>(source.ViewedGalleryIds),
				TabAckedGalleryIds = new HashSet<int>(source.TabAckedGalleryIds)
			};
		}

		// Token: 0x060387EC RID: 231404 RVA: 0x00FCDE34 File Offset: 0x00FCC034
		private static Dictionary<int, SolarSchoolRedDotLocalData> CloneRedDotMap(IReadOnlyDictionary<int, SolarSchoolRedDotLocalData> source)
		{
			Dictionary<int, SolarSchoolRedDotLocalData> dictionary = new Dictionary<int, SolarSchoolRedDotLocalData>(source.Count);
			foreach (KeyValuePair<int, SolarSchoolRedDotLocalData> keyValuePair in source)
			{
				int num;
				SolarSchoolRedDotLocalData solarSchoolRedDotLocalData;
				keyValuePair.Deconstruct(out num, out solarSchoolRedDotLocalData);
				int key = num;
				SolarSchoolRedDotLocalData source2 = solarSchoolRedDotLocalData;
				dictionary[key] = SolarSchoolUtils.CloneRedDotData(source2);
			}
			return dictionary;
		}

		// Token: 0x060387ED RID: 231405 RVA: 0x00FCDEA4 File Offset: 0x00FCC0A4
		public static float CalcSuccessRate(int activityId, int[] attrValues, int[] lowers, int[] uppers, float[] weights, int p)
		{
			float num = 0f;
			for (int i = 1; i <= 5; i++)
			{
				int num2 = i - 1;
				num += weights[num2] * SolarSchoolUtils.CalcAttrHitRatio(attrValues[num2], lowers[num2], uppers[num2]);
			}
			int paramNumber = SolarSchoolConfig.Instance.GetParamNumber(activityId, "TiredThreshold", 0);
			int paramNumber2 = SolarSchoolConfig.Instance.GetParamNumber(activityId, "SickThreshold", 0);
			return Math.Min(Math.Max(num, 0.5f) * SolarSchoolUtils.CalcFatigueFactor(p, paramNumber, paramNumber2), 1f);
		}

		// Token: 0x060387EE RID: 231406 RVA: 0x00FCDF25 File Offset: 0x00FCC125
		public static float CalcAttrHitRatio(int value, int lower, int upper)
		{
			if (value <= lower)
			{
				return 0f;
			}
			if (value >= upper)
			{
				return 1f;
			}
			return (float)(value - lower) / (float)(upper - lower);
		}

		// Token: 0x060387EF RID: 231407 RVA: 0x00FCDF44 File Offset: 0x00FCC144
		public static float CalcFatigueFactor(int p, int a, int b)
		{
			ESolarSchoolFatigueStage esolarSchoolFatigueStage = SolarSchoolUtils.CalcFatigueStage(p, a, b);
			float result;
			if (esolarSchoolFatigueStage != ESolarSchoolFatigueStage.Healthy)
			{
				if (esolarSchoolFatigueStage != ESolarSchoolFatigueStage.Tired)
				{
					result = 0f;
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				result = 2f;
			}
			return result;
		}

		// Token: 0x060387F0 RID: 231408 RVA: 0x00FCDF7A File Offset: 0x00FCC17A
		public static ESolarSchoolFatigueStage CalcFatigueStage(int p, int a, int b)
		{
			if (p < a)
			{
				return ESolarSchoolFatigueStage.Healthy;
			}
			if (p < b)
			{
				return ESolarSchoolFatigueStage.Tired;
			}
			return ESolarSchoolFatigueStage.Sick;
		}

		// Token: 0x060387F1 RID: 231409 RVA: 0x00FCDF8C File Offset: 0x00FCC18C
		public static string GetAttrValueText(ESolarSchoolSecondAttr attr, int value)
		{
			if (attr != ESolarSchoolSecondAttr.Fatigue)
			{
				return value.ToString();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060387F2 RID: 231410 RVA: 0x00FCDFCC File Offset: 0x00FCC1CC
		public static string GetAttrDeltaText(ESolarSchoolSecondAttr attr, int delta)
		{
			string attrValueText = SolarSchoolUtils.GetAttrValueText(attr, delta);
			if (delta <= 0)
			{
				return attrValueText;
			}
			return "+" + attrValueText;
		}

		// Token: 0x060387F3 RID: 231411 RVA: 0x00FCDFF4 File Offset: 0x00FCC1F4
		public static int CalcAttrRankTier(SolarSchoolAttr config, int value)
		{
			int[] ranksArray = config.GetRanksArray();
			int result = 0;
			int num = 0;
			while (num < ranksArray.Length && value >= ranksArray[num])
			{
				result = num + 1;
				num++;
			}
			return result;
		}

		// Token: 0x060387F4 RID: 231412 RVA: 0x00FCE024 File Offset: 0x00FCC224
		public static float CalcAttrRankRatio(SolarSchoolAttr config, int value)
		{
			int[] ranksArray = config.GetRanksArray();
			if (ranksArray.Length == 0)
			{
				return SolarSchoolUtils.CalcRatio(value, config.MinValue, config.MaxValue);
			}
			int num = SolarSchoolUtils.CalcAttrRankTier(config, value);
			if (num >= ranksArray.Length)
			{
				return 1f;
			}
			return SolarSchoolUtils.CalcRatio(value, (num == 0) ? config.MinValue : ranksArray[num - 1], ranksArray[num]);
		}

		// Token: 0x060387F5 RID: 231413 RVA: 0x00FCE080 File Offset: 0x00FCC280
		private static float CalcRatio(int value, int lower, int upper)
		{
			if (upper > lower)
			{
				return Math.Clamp((float)(value - lower) / (float)(upper - lower), 0f, 1f);
			}
			if (value < upper)
			{
				return 0f;
			}
			return 1f;
		}

		// Token: 0x060387F6 RID: 231414 RVA: 0x00FCE0B0 File Offset: 0x00FCC2B0
		public static void CollectOptionRows(int activityId, int instanceId, ESolarSchoolOptionOwnerType ownerType, Dictionary<int, List<SolarSchoolOptions>> result)
		{
			result.Clear();
			foreach (SolarSchoolOptions item in SolarSchoolConfig.Instance.GetOptionList(activityId, instanceId, (int)ownerType))
			{
				List<SolarSchoolOptions> list;
				if (!result.TryGetValue(item.OwnerId, out list))
				{
					list = new List<SolarSchoolOptions>();
					result[item.OwnerId] = list;
				}
				list.Add(item);
			}
			using (Dictionary<int, List<SolarSchoolOptions>>.ValueCollection.Enumerator enumerator2 = result.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Sort((SolarSchoolOptions a, SolarSchoolOptions b) => a.Sort.CompareTo(b.Sort));
				}
			}
		}

		// Token: 0x060387F7 RID: 231415 RVA: 0x00FCE194 File Offset: 0x00FCC394
		public static List<SolarSchoolOptionInfo> CheckOptions([Nullable(2)] List<SolarSchoolOptions> rows)
		{
			List<SolarSchoolOptionInfo> list = new List<SolarSchoolOptionInfo>();
			if (rows == null)
			{
				return list;
			}
			foreach (SolarSchoolOptions row in rows)
			{
				if (row.ConditionId == 0 || ActivityConditionCenter.Instance.CheckGroup(row.ConditionId))
				{
					list.Add(new SolarSchoolOptionInfo(row, true));
				}
				else if (row.LockMode == 1)
				{
					list.Add(new SolarSchoolOptionInfo(row, false));
				}
			}
			return list;
		}

		// Token: 0x060387F8 RID: 231416 RVA: 0x00FCE22C File Offset: 0x00FCC42C
		public static string GetConditionHintText(int conditionGroupId)
		{
			if (conditionGroupId == 0)
			{
				return string.Empty;
			}
			ActivityConditionConfig instance = ActivityConditionConfig.Instance;
			Aki.Config.ActivityConditionGroup? activityConditionGroup = (instance != null) ? instance.GetConditionGroupConfig(conditionGroupId) : null;
			return SolarSchoolUtils.GetTextWithPlaceholder((activityConditionGroup != null) ? activityConditionGroup.GetValueOrDefault().HintText : null);
		}

		// Token: 0x060387F9 RID: 231417 RVA: 0x00FCE280 File Offset: 0x00FCC480
		public static List<SolarSchoolJumpAccessInfo> CollectQuestRewardJumps(int rewardId)
		{
			List<SolarSchoolJumpAccessInfo> list = new List<SolarSchoolJumpAccessInfo>();
			SolarSchoolQuestReward? questReward = SolarSchoolConfig.Instance.GetQuestReward(rewardId);
			if (questReward == null)
			{
				return list;
			}
			if (questReward.Value.JumpMap >= 0)
			{
				list.Add(new SolarSchoolJumpAccessInfo(ESolarSchoolJumpAccess.Map, questReward.Value.JumpMap));
			}
			if (questReward.Value.JumpSchedule >= 0)
			{
				list.Add(new SolarSchoolJumpAccessInfo(ESolarSchoolJumpAccess.Schedule, questReward.Value.JumpSchedule));
			}
			if (questReward.Value.JumpFriend >= 0)
			{
				list.Add(new SolarSchoolJumpAccessInfo(ESolarSchoolJumpAccess.Friend, questReward.Value.JumpFriend));
			}
			return list;
		}

		// Token: 0x060387FA RID: 231418 RVA: 0x00FCE334 File Offset: 0x00FCC534
		public static void RunQuestRewardJump(SolarSchoolJumpAccessInfo info)
		{
			switch (info.Access)
			{
			case ESolarSchoolJumpAccess.Map:
				if (info.Param == 0)
				{
					SolarSchoolGamePlayModel.Instance.OpenMapView(null);
					return;
				}
				SolarSchoolGamePlayModel.Instance.OpenMapView(new SolarSchoolMapPanelParam
				{
					FocusLocationId = info.Param
				});
				return;
			case ESolarSchoolJumpAccess.Schedule:
				SolarSchoolGamePlayModel.Instance.TryOpenScheduleView();
				return;
			case ESolarSchoolJumpAccess.Friend:
				UiManager.Instance.OpenView(EUiViewName.SolarSchoolInfoOverviewView, new SolarSchoolInfoOverviewViewParam
				{
					TargetTabViewName = new EUiTabViewName?(EUiTabViewName.SolarSchoolInfoFriendTabView),
					TargetRoleId = info.Param
				}, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060387FB RID: 231419 RVA: 0x00FCE3C8 File Offset: 0x00FCC5C8
		public static string GetJumpAccessTextKey(SolarSchoolJumpAccessInfo info)
		{
			ESolarSchoolJumpAccess access = info.Access;
			int param = info.Param;
			string result;
			switch (access)
			{
			case ESolarSchoolJumpAccess.Map:
				result = ((param == 0) ? "SolarSchool_QuestTree_Jump4" : "SolarSchool_QuestTree_Jump1");
				break;
			case ESolarSchoolJumpAccess.Schedule:
				result = "SolarSchool_QuestTree_Jump2";
				break;
			case ESolarSchoolJumpAccess.Friend:
				result = ((param == 0) ? "SolarSchool_QuestTree_Jump5" : "SolarSchool_QuestTree_Jump3");
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x060387FC RID: 231420 RVA: 0x00FCE42C File Offset: 0x00FCC62C
		public static string GetJumpAccessNameTextId(SolarSchoolJumpAccessInfo info)
		{
			if (info.Param <= 0)
			{
				return string.Empty;
			}
			ESolarSchoolJumpAccess access = info.Access;
			string text;
			if (access != ESolarSchoolJumpAccess.Map)
			{
				if (access != ESolarSchoolJumpAccess.Friend)
				{
					text = string.Empty;
				}
				else
				{
					SolarSchoolRole? solarSchoolRole;
					text = ((info.Param == 0) ? string.Empty : ((SolarSchoolConfig.Instance.GetRole(info.Param) != null) ? solarSchoolRole.GetValueOrDefault().Name : null));
				}
			}
			else
			{
				SolarSchoolLocation? solarSchoolLocation;
				text = ((info.Param == 0) ? string.Empty : ((SolarSchoolConfig.Instance.GetLocation(info.Param) != null) ? solarSchoolLocation.GetValueOrDefault().Name : null));
			}
			return text ?? string.Empty;
		}

		// Token: 0x060387FD RID: 231421 RVA: 0x00FCE4E6 File Offset: 0x00FCC6E6
		[NullableContext(2)]
		public static void ShowTipsPopup(int itemId, int count = 0, Action onClose = null)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolTipsPopupView, new SolarSchoolTipsPopupParam
			{
				ItemId = itemId,
				Count = count,
				CloseCallback = onClose
			}, null);
		}

		// Token: 0x060387FE RID: 231422 RVA: 0x00FCE512 File Offset: 0x00FCC712
		[NullableContext(2)]
		public static void ShowItemDetailPopup(int itemId, int count = 0, Action onClose = null)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolTipsPopupView, new SolarSchoolTipsPopupParam
			{
				ItemId = itemId,
				Count = count,
				ShowTitle = false,
				CloseCallback = onClose
			}, null);
		}

		// Token: 0x060387FF RID: 231423 RVA: 0x00FCE548 File Offset: 0x00FCC748
		public static void ShowCostConfirmPopup(int confirmConfigId, int costNum, Action onConfirm)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)confirmConfigId);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				costNum.ToString()
			});
			confirmBoxDataNew.FunctionMap[2] = onConfirm;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038800 RID: 231424 RVA: 0x00FCE58C File Offset: 0x00FCC78C
		public static void ShowNotEnoughPopup(int confirmConfigId)
		{
			if (confirmConfigId <= 0)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)confirmConfigId);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038801 RID: 231425 RVA: 0x00FCE5B1 File Offset: 0x00FCC7B1
		public static void ShowBuildPopup(string tipsKey, string iconPath, [Nullable(2)] Action onConfirm = null, [Nullable(2)] Action onClose = null, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] tipsArgs)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolBuildPopupView, new SolarSchoolBuildPopupParam
			{
				TipsKey = tipsKey,
				TipsArgs = tipsArgs,
				IconPath = iconPath,
				OnConfirm = onConfirm,
				CloseCallback = onClose
			}, null);
		}

		// Token: 0x06038802 RID: 231426 RVA: 0x00FCE5EC File Offset: 0x00FCC7EC
		[NullableContext(2)]
		public static void ShowFavorLevelUpPopup(int roleId, int previousLevel, int finalLevel, Action onClose = null, Action onOpenFailed = null)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolFavorLevelUpPopupView, new SolarSchoolFavorLevelUpPopupParam
			{
				RoleId = roleId,
				PreviousLevel = previousLevel,
				FinalLevel = finalLevel,
				CloseCallback = onClose
			}, delegate(bool success, int _)
			{
				if (!success)
				{
					Action onOpenFailed2 = onOpenFailed;
					if (onOpenFailed2 == null)
					{
						return;
					}
					onOpenFailed2();
				}
			});
		}

		// Token: 0x06038803 RID: 231427 RVA: 0x00FCE643 File Offset: 0x00FCC843
		[NullableContext(2)]
		public static void ShowBehaviorDonePopup(int behaviorId, Action onClose = null, string textKey = null, bool showAttrList = true)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolBehaviorDonePopupView, new SolarSchoolBehaviorDonePopupParam
			{
				BehaviorId = behaviorId,
				CloseCallback = onClose,
				TextKey = (textKey ?? string.Empty),
				ShowAttrList = showAttrList
			}, null);
		}

		// Token: 0x06038804 RID: 231428 RVA: 0x00FCE680 File Offset: 0x00FCC880
		[NullableContext(2)]
		public static void ShowBehaviorLevelUpPopup(int behaviorId, Action onClose = null)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolBehaviorLevelUp)
			{
				DestroyFunction = onClose
			};
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				SolarSchoolGamePlayModel.Instance.PlayerData.GetBehaviorName(behaviorId) ?? string.Empty
			});
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolConfirmPopupView, confirmBoxDataNew, null);
		}

		// Token: 0x06038805 RID: 231429 RVA: 0x00FCE6D8 File Offset: 0x00FCC8D8
		public static List<IActivityConditionData> BuildConditionDataList(int conditionGroupId, [TupleElementNames(new string[]
		{
			"TitleId",
			"IconPath"
		})] [Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})] Dictionary<int, ValueTuple<string, string>> extraMap = null)
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			IReadOnlyList<int> readOnlyList;
			if (!ActivityConditionCenter.Instance.TryGetGroupConditionIds(conditionGroupId, out readOnlyList))
			{
				return list;
			}
			foreach (int num in readOnlyList)
			{
				ActivityCondition? conditionConfig = ActivityConditionConfig.Instance.GetConditionConfig(num);
				if (conditionConfig != null && !string.IsNullOrEmpty(conditionConfig.Value.Description))
				{
					ValueTuple<string, string> valueTuple2;
					ValueTuple<string, string> valueTuple = (extraMap != null && extraMap.TryGetValue(num, out valueTuple2)) ? valueTuple2 : new ValueTuple<string, string>(string.Empty, string.Empty);
					list.Add(new SolarSchoolUnlockConditionData
					{
						ConditionId = num,
						ConditionTextId = conditionConfig.Value.Description,
						IsFinished = ActivityConditionCenter.Instance.CheckCondition(num, null),
						TitleId = valueTuple.Item1,
						IconPath = valueTuple.Item2
					});
				}
			}
			return list;
		}

		// Token: 0x06038806 RID: 231430 RVA: 0x00FCE7E0 File Offset: 0x00FCC9E0
		[NullableContext(2)]
		public static void ShowUnlockItemPopup(int conditionGroupId, string titleId = null, [TupleElementNames(new string[]
		{
			"TitleId",
			"IconPath"
		})] [Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})] Dictionary<int, ValueTuple<string, string>> extraMap = null, Action onClose = null)
		{
			IReadOnlyList<int> readOnlyList;
			if (!ActivityConditionCenter.Instance.TryGetGroupConditionIds(conditionGroupId, out readOnlyList))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 解锁弹窗的条件组不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionGroupId", conditionGroupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolUnlockItemPopupView, new SolarSchoolUnlockItemPopupParam(conditionGroupId, SolarSchoolUtils.BuildConditionDataList(conditionGroupId, extraMap), titleId, onClose), null);
		}

		// Token: 0x06038807 RID: 231431 RVA: 0x00FCE84C File Offset: 0x00FCCA4C
		public static void ShowJumpAccessPopup(List<SolarSchoolJumpAccessInfo> jumps, Action<SolarSchoolJumpAccessInfo> onSelected, [Nullable(2)] Action onClose = null)
		{
			if (jumps.Count == 0)
			{
				return;
			}
			SolarSchoolJumpAccessPopupParam solarSchoolJumpAccessPopupParam = new SolarSchoolJumpAccessPopupParam
			{
				TitleId = "SolarSchool_QuestTree_NodeTitle",
				TipsId = "SolarSchool_QuestTree_NodeDesc",
				CloseCallback = onClose
			};
			using (List<SolarSchoolJumpAccessInfo>.Enumerator enumerator = jumps.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SolarSchoolJumpAccessInfo jump = enumerator.Current;
					solarSchoolJumpAccessPopupParam.DataList.Add(new SolarSchoolJumpAccessItemData
					{
						Info = jump,
						TextId = SolarSchoolUtils.GetJumpAccessTextKey(jump),
						TextParam = SolarSchoolUtils.GetJumpAccessNameTextId(jump),
						OnJump = delegate()
						{
							onSelected(jump);
						}
					});
				}
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolJumpAccessPopupView, solarSchoolJumpAccessPopupParam, null);
		}

		// Token: 0x06038808 RID: 231432 RVA: 0x00FCE940 File Offset: 0x00FCCB40
		public unsafe static int CalcExamBaseScore(int examId, int[] attrValues)
		{
			SolarSchoolExam? exam = SolarSchoolConfig.Instance.GetExam(examId);
			if (exam == null)
			{
				return 0;
			}
			int[] attrMaxArray = exam.Value.GetAttrMaxArray();
			int[] attrWeightArray = exam.Value.GetAttrWeightArray();
			float num = 0f;
			int num2 = 0;
			for (int i = 1; i <= 5; i++)
			{
				int num3 = i - 1;
				if (num3 >= attrWeightArray.Length || num3 >= attrMaxArray.Length || num3 >= attrValues.Length)
				{
					break;
				}
				int num4 = attrWeightArray[num3];
				if (num4 != 0)
				{
					int num5 = attrMaxArray[num3];
					if (num5 <= 0)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.YYZ;
						string message = "[SolarSchool][Exam] 考验属性配了权重但没配属性值，跳过该维";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("examId", examId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("attrType", i);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("weight", num4);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					else
					{
						num += Math.Min((float)attrValues[num3] / (float)num5, 1f) * (float)num4;
						num2 += num4;
					}
				}
			}
			if (num2 <= 0)
			{
				return 0;
			}
			return (int)Math.Round((double)((float)exam.Value.ScoreMax * num / (float)num2));
		}

		// Token: 0x06038809 RID: 231433 RVA: 0x00FCEAAC File Offset: 0x00FCCCAC
		public static bool CanPlaceInSlot(SolarSchoolBehavior behavior, ESolarSchoolTimeSlot slot)
		{
			for (int i = 0; i < behavior.AvailableTimeSlotLength; i++)
			{
				if (behavior.AvailableTimeSlot(i) == (int)slot)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603880A RID: 231434 RVA: 0x00FCEADC File Offset: 0x00FCCCDC
		public static ESolarSchoolTimeSlot[] GetAvailableSlots(SolarSchoolBehavior behavior)
		{
			ESolarSchoolTimeSlot[] array = new ESolarSchoolTimeSlot[behavior.AvailableTimeSlotLength];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (ESolarSchoolTimeSlot)behavior.AvailableTimeSlot(i);
			}
			return array;
		}

		// Token: 0x0603880B RID: 231435 RVA: 0x00FCEB10 File Offset: 0x00FCCD10
		public static string GetOccupyTagText(ESolarSchoolTimeSlot slot)
		{
			SolarSchoolTimeSlot? solarSchoolTimeSlot;
			string text = ((SolarSchoolConfig.Instance.GetTimeSlot(slot) != null) ? solarSchoolTimeSlot.GetValueOrDefault().ShortName : null) ?? string.Empty;
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			return string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_OptionOccupiedTime", null) ?? string.Empty, ConfigMultiTextLang.GetLocalTextNew(text, null) ?? string.Empty);
		}

		// Token: 0x0603880C RID: 231436 RVA: 0x00FCEB88 File Offset: 0x00FCCD88
		public static string GetWeekdayText(DayOfWeek dayOfWeek)
		{
			string id;
			switch (dayOfWeek)
			{
			case DayOfWeek.Monday:
				id = "SolarSchool_WeekdayMonday";
				break;
			case DayOfWeek.Tuesday:
				id = "SolarSchool_WeekdayTuesday";
				break;
			case DayOfWeek.Wednesday:
				id = "SolarSchool_WeekdayWednesday";
				break;
			case DayOfWeek.Thursday:
				id = "SolarSchool_WeekdayThursday";
				break;
			case DayOfWeek.Friday:
				id = "SolarSchool_WeekdayFriday";
				break;
			case DayOfWeek.Saturday:
				id = "SolarSchool_WeekdaySaturday";
				break;
			default:
				id = "SolarSchool_WeekdaySunday";
				break;
			}
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? string.Empty;
		}

		// Token: 0x0603880D RID: 231437 RVA: 0x00FCEC00 File Offset: 0x00FCCE00
		public static string GetLoadingWeekdayText(DayOfWeek dayOfWeek)
		{
			string id;
			switch (dayOfWeek)
			{
			case DayOfWeek.Monday:
				id = "SolarSchool_WeekdayMonday2";
				break;
			case DayOfWeek.Tuesday:
				id = "SolarSchool_WeekdayTuesday2";
				break;
			case DayOfWeek.Wednesday:
				id = "SolarSchool_WeekdayWednesday2";
				break;
			case DayOfWeek.Thursday:
				id = "SolarSchool_WeekdayThursday2";
				break;
			case DayOfWeek.Friday:
				id = "SolarSchool_WeekdayFriday2";
				break;
			case DayOfWeek.Saturday:
				id = "SolarSchool_WeekdaySaturday2";
				break;
			default:
				id = "SolarSchool_WeekdaySunday2";
				break;
			}
			return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? string.Empty;
		}

		// Token: 0x0603880E RID: 231438 RVA: 0x00FCEC75 File Offset: 0x00FCCE75
		public static string GetDayTransitionSequenceName(ESolarSchoolMapTimePhase phase)
		{
			if (phase != ESolarSchoolMapTimePhase.Dusk)
			{
				return "Day_To_Day";
			}
			return "Dusk_To_Day";
		}

		// Token: 0x0603880F RID: 231439 RVA: 0x00FCEC88 File Offset: 0x00FCCE88
		public static string GetTimeSlotText(ESolarSchoolTimeSlot slot)
		{
			SolarSchoolTimeSlot? solarSchoolTimeSlot;
			string text = ((SolarSchoolConfig.Instance.GetTimeSlot(slot) != null) ? solarSchoolTimeSlot.GetValueOrDefault().Name : null) ?? string.Empty;
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			return ConfigMultiTextLang.GetLocalTextNew(text, null) ?? string.Empty;
		}

		// Token: 0x06038810 RID: 231440 RVA: 0x00FCECE4 File Offset: 0x00FCCEE4
		public static string GetTextWithPlaceholder([Nullable(2)] string textId)
		{
			if (string.IsNullOrEmpty(textId))
			{
				return string.Empty;
			}
			return SolarSchoolUtils.ReplacePlaceholder(ConfigMultiTextLang.GetLocalTextNew(textId, null));
		}

		// Token: 0x06038811 RID: 231441 RVA: 0x00FCED00 File Offset: 0x00FCCF00
		public static string ReplacePlaceholder([Nullable(2)] string content)
		{
			if (string.IsNullOrEmpty(content))
			{
				return string.Empty;
			}
			return Regex.Replace(content, "\\{(?<Key>\\w+)(?::(?<Param>[^}]*))?\\}", (Match match) => SolarSchoolUtils.GetPlaceholderText(match.Groups["Key"].Value, match.Groups["Param"].Value) ?? match.Value);
		}

		// Token: 0x06038812 RID: 231442 RVA: 0x00FCED3C File Offset: 0x00FCCF3C
		[return: Nullable(2)]
		private unsafe static string GetPlaceholderText(string key, string param)
		{
			ESolarSchoolTextPlaceholder esolarSchoolTextPlaceholder;
			if (!Enum.TryParse<ESolarSchoolTextPlaceholder>(key, out esolarSchoolTextPlaceholder))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Text] 未知的文本占位符 Key";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("param", param);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			if (esolarSchoolTextPlaceholder != ESolarSchoolTextPlaceholder.Rank)
			{
				if (esolarSchoolTextPlaceholder != ESolarSchoolTextPlaceholder.Score)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SolarSchool;
					ELogAuthor author2 = ELogAuthor.YYZ;
					string message2 = "[SolarSchool][Text] 文本占位符没有对应的取值实现";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("placeholder", esolarSchoolTextPlaceholder);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("param", param);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return null;
				}
				SolarSchoolExamResult solarSchoolExamResult;
				if (!SolarSchoolUtils.TryGetExamResult(esolarSchoolTextPlaceholder, param, out solarSchoolExamResult))
				{
					return null;
				}
				string rankIcon = solarSchoolExamResult.GetRankIcon();
				if (!string.IsNullOrEmpty(rankIcon))
				{
					return SolarSchoolUtils.BuildScoreIconRichText(rankIcon);
				}
				return null;
			}
			else
			{
				SolarSchoolExamResult solarSchoolExamResult2;
				if (!SolarSchoolUtils.TryGetExamResult(esolarSchoolTextPlaceholder, param, out solarSchoolExamResult2))
				{
					return null;
				}
				return solarSchoolExamResult2.Rank.ToString();
			}
		}

		// Token: 0x06038813 RID: 231443 RVA: 0x00FCEE54 File Offset: 0x00FCD054
		private static string BuildScoreIconRichText(string iconPath)
		{
			int num = SolarSchoolConfig.Instance.GetParamNumber(SolarSchoolGamePlayModel.Instance.GetActivityId(), "ScoreTexInTxtRate", 10000);
			if (num <= 0)
			{
				num = 10000;
			}
			string value = ((float)num / 10000f).ToString("0.####");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<texture=");
			defaultInterpolatedStringHandler.AppendFormatted(iconPath);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("/>");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06038814 RID: 231444 RVA: 0x00FCEEE8 File Offset: 0x00FCD0E8
		private static bool TryGetExamResult(ESolarSchoolTextPlaceholder placeholder, string param, [Nullable(2)] [NotNullWhen(true)] out SolarSchoolExamResult result)
		{
			result = null;
			int num;
			return int.TryParse(param, out num) && num > 0 && SolarSchoolGamePlayModel.Instance.PlayerData.TryGetExamResult(num, out result);
		}

		// Token: 0x06038815 RID: 231445 RVA: 0x00FCEF1E File Offset: 0x00FCD11E
		[NullableContext(2)]
		public static void PlayAudio(string audioId)
		{
			if (StringUtils.IsEmpty(audioId))
			{
				return;
			}
			AudioSystem.Instance.PostEvent(audioId);
		}

		// Token: 0x06038816 RID: 231446 RVA: 0x00FCEF38 File Offset: 0x00FCD138
		public static int GetRoleSpineIdByScene(ESolarSchoolSpineScene scene)
		{
			bool flag = SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			string text;
			switch (scene)
			{
			case ESolarSchoolSpineScene.ChoiceEnter:
				text = (flag ? "HeroChoiceEnterSpineIdList" : "HeroineChoiceEnterSpineIdList");
				break;
			case ESolarSchoolSpineScene.ChoiceCorrect:
				text = (flag ? "HeroChoiceCorrectSpineIdList" : "HeroineChoiceCorrectSpineIdList");
				break;
			case ESolarSchoolSpineScene.ChoiceFail:
				text = (flag ? "HeroChoiceFailSpineIdList" : "HeroineChoiceFailSpineIdList");
				break;
			case ESolarSchoolSpineScene.Shop:
				text = "ShopSpineIdList";
				break;
			case ESolarSchoolSpineScene.ShopBuy:
				text = "ShopSpineIdListBuy";
				break;
			default:
				text = string.Empty;
				break;
			}
			string text2 = text;
			if (StringUtils.IsEmpty(text2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 角色场景没有对应的活动参数键";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scene", scene);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			IReadOnlyList<int> paramIntArray = SolarSchoolConfig.Instance.GetParamIntArray(SolarSchoolGamePlayModel.Instance.GetActivityId(), text2);
			if (paramIntArray.Count == 0)
			{
				return 0;
			}
			return paramIntArray[RandomSystem.GetRandomInteger() % paramIntArray.Count];
		}

		// Token: 0x06038817 RID: 231447 RVA: 0x00FCF030 File Offset: 0x00FCD230
		public static List<SolarSchoolEnding> FilterAvailableEndings(IEnumerable<SolarSchoolEnding> source, ESolarSchoolEndingType endingType)
		{
			List<SolarSchoolEnding> list = new List<SolarSchoolEnding>();
			foreach (SolarSchoolEnding item in source)
			{
				if (item.EndingType == (int)endingType && (item.ConditionId == 0 || ActivityConditionCenter.Instance.CheckGroup(item.ConditionId)))
				{
					list.Add(item);
				}
			}
			NoLinq.SortStable<SolarSchoolEnding>(list, delegate(SolarSchoolEnding left, SolarSchoolEnding right)
			{
				int num = left.Sort.CompareTo(right.Sort);
				if (num == 0)
				{
					return left.Id.CompareTo(right.Id);
				}
				return num;
			});
			return list;
		}

		// Token: 0x06038818 RID: 231448 RVA: 0x00FCF0CC File Offset: 0x00FCD2CC
		public static int ToMonthDay(int month, int day)
		{
			return month * 100 + day;
		}

		// Token: 0x06038819 RID: 231449 RVA: 0x00FCF0D4 File Offset: 0x00FCD2D4
		public static DateTime GetDate(int dayIndex)
		{
			return SolarSchoolUtils.CalendarAnchor.AddDays((double)(dayIndex - 1));
		}

		// Token: 0x0603881A RID: 231450 RVA: 0x00FCF0E4 File Offset: 0x00FCD2E4
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Month",
			"Day"
		})]
		public static ValueTuple<int, int> GetMonthDay(int dayIndex)
		{
			DateTime date = SolarSchoolUtils.GetDate(dayIndex);
			return new ValueTuple<int, int>(date.Month, date.Day);
		}

		// Token: 0x0603881B RID: 231451 RVA: 0x00FCF10C File Offset: 0x00FCD30C
		public unsafe static DayOfWeek? GetDayOfWeek(int month, int day)
		{
			int year = (SolarSchoolUtils.ToMonthDay(month, day) < SolarSchoolUtils.ToMonthDay(SolarSchoolUtils.CalendarAnchor.Month, SolarSchoolUtils.CalendarAnchor.Day)) ? (SolarSchoolUtils.CalendarAnchor.Year + 1) : SolarSchoolUtils.CalendarAnchor.Year;
			bool flag = month < 1 || month > 12;
			if (flag || day < 1 || day > DateTime.DaysInMonth(year, month))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 日期非法，无法计算周几";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("month", month);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("day", day);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			return new DayOfWeek?(new DateTime(year, month, day).DayOfWeek);
		}

		// Token: 0x0603881C RID: 231452 RVA: 0x00FCF1F4 File Offset: 0x00FCD3F4
		public static int GetWeekday(int dayIndex)
		{
			DayOfWeek dayOfWeek = SolarSchoolUtils.GetDate(dayIndex).DayOfWeek;
			if (dayOfWeek != DayOfWeek.Sunday)
			{
				return (int)dayOfWeek;
			}
			return 7;
		}

		// Token: 0x0603881D RID: 231453 RVA: 0x00FCF216 File Offset: 0x00FCD416
		public static int GetMondayDayIndex(int dayIndex)
		{
			return dayIndex - (SolarSchoolUtils.GetWeekday(dayIndex) - 1);
		}

		// Token: 0x0603881E RID: 231454 RVA: 0x00FCF224 File Offset: 0x00FCD424
		public static int GetFirstMondayDayIndex()
		{
			int mondayDayIndex = SolarSchoolUtils.GetMondayDayIndex(1);
			if (mondayDayIndex < 1)
			{
				return mondayDayIndex + 7;
			}
			return mondayDayIndex;
		}

		// Token: 0x0603881F RID: 231455 RVA: 0x00FCF244 File Offset: 0x00FCD444
		public static ESolarSchoolDayType GetDayType(int dayIndex)
		{
			DayOfWeek dayOfWeek = SolarSchoolUtils.GetDate(dayIndex).DayOfWeek;
			if (dayOfWeek != DayOfWeek.Sunday && dayOfWeek != DayOfWeek.Saturday)
			{
				return ESolarSchoolDayType.Weekday;
			}
			return ESolarSchoolDayType.Weekend;
		}

		// Token: 0x06038820 RID: 231456 RVA: 0x00FCF274 File Offset: 0x00FCD474
		public static void SetSaveBit(RepeatedField<long> bits, int bitFlag)
		{
			if (bitFlag < 0)
			{
				return;
			}
			int num = bitFlag / 64;
			while (bits.Count <= num)
			{
				bits.Add(0L);
			}
			int index = num;
			bits[index] |= 1L << bitFlag % 64;
		}

		// Token: 0x06038821 RID: 231457 RVA: 0x00FCF2BC File Offset: 0x00FCD4BC
		public static bool GetSaveBit(RepeatedField<long> bits, int bitFlag)
		{
			if (bitFlag < 0)
			{
				return false;
			}
			int num = bitFlag / 64;
			return num < bits.Count && (bits[num] & 1L << bitFlag % 64) != 0L;
		}

		// Token: 0x06038822 RID: 231458 RVA: 0x00FCF2F8 File Offset: 0x00FCD4F8
		public static long SetSaveBit(long bits, int bitFlag)
		{
			if (bitFlag < 0)
			{
				return bits;
			}
			if (bitFlag >= 64)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 单字位图 BitFlag 越界，该位丢失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bitFlag", bitFlag);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return bits;
			}
			return bits | 1L << bitFlag;
		}

		// Token: 0x06038823 RID: 231459 RVA: 0x00FCF34A File Offset: 0x00FCD54A
		public static bool GetSaveBit(long bits, int bitFlag)
		{
			return bitFlag >= 0 && bitFlag < 64 && (bits & 1L << bitFlag) != 0L;
		}

		// Token: 0x0401DC4E RID: 121934
		private const float MinRate = 0.5f;

		// Token: 0x0401DC4F RID: 121935
		private const float MaxRate = 1f;

		// Token: 0x0401DC50 RID: 121936
		private const int FiveAttrStart = 1;

		// Token: 0x0401DC51 RID: 121937
		private const int FiveAttrEnd = 5;

		// Token: 0x0401DC52 RID: 121938
		private const string PlaceholderPattern = "\\{(?<Key>\\w+)(?::(?<Param>[^}]*))?\\}";

		// Token: 0x0401DC53 RID: 121939
		private const int ScoreTexRateBase = 10000;

		// Token: 0x0401DC54 RID: 121940
		private static readonly DateTime CalendarAnchor = new DateTime(2024, 3, 15);

		// Token: 0x0401DC55 RID: 121941
		private const int BitsPerWord = 64;
	}
}

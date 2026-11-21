using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D6 RID: 22742
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolPlayerData : SolarSchoolRecordBase
	{
		// Token: 0x06038009 RID: 229385 RVA: 0x00FA75FC File Offset: 0x00FA57FC
		private SolarSchoolAttrData GetOrCreateAttrData(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolAttrData solarSchoolAttrData;
			if (!this.AttrMap.TryGetValue(attr, out solarSchoolAttrData))
			{
				solarSchoolAttrData = new SolarSchoolAttrData(attr);
				this.AttrMap[attr] = solarSchoolAttrData;
			}
			return solarSchoolAttrData;
		}

		// Token: 0x0603800A RID: 229386 RVA: 0x00FA7630 File Offset: 0x00FA5830
		public void InitAttr()
		{
			this.AttrMap.Clear();
			this.ClearBuffs();
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in Enum.GetValues<ESolarSchoolSecondAttr>())
			{
				if (esolarSchoolSecondAttr != ESolarSchoolSecondAttr.None)
				{
					SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(esolarSchoolSecondAttr);
					if (attrConfig == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] 属性初始化失败：SolarSchoolAttr 表缺该维度配置";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attr", esolarSchoolSecondAttr);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						this.GetOrCreateAttrData(esolarSchoolSecondAttr).BaseValue = attrConfig.Value.InitValue;
					}
				}
			}
		}

		// Token: 0x0603800B RID: 229387 RVA: 0x00FA76CC File Offset: 0x00FA58CC
		public int GetBaseAttr(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolAttrData valueOrDefault = this.AttrMap.GetValueOrDefault(attr);
			if (valueOrDefault == null)
			{
				return 0;
			}
			return valueOrDefault.BaseValue;
		}

		// Token: 0x0603800C RID: 229388 RVA: 0x00FA76E5 File Offset: 0x00FA58E5
		public bool IsAttrImportant(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolAttrData valueOrDefault = this.AttrMap.GetValueOrDefault(attr);
			return valueOrDefault != null && valueOrDefault.IsImportant;
		}

		// Token: 0x0603800D RID: 229389 RVA: 0x00FA7700 File Offset: 0x00FA5900
		public void ReplaceImportantAttrs(IReadOnlyCollection<ESolarSchoolSecondAttr> attrs)
		{
			HashSet<ESolarSchoolSecondAttr> hashSet = new HashSet<ESolarSchoolSecondAttr>(attrs);
			foreach (SolarSchoolAttrData solarSchoolAttrData in this.AttrMap.Values)
			{
				if (solarSchoolAttrData.SetImportant(hashSet.Contains(solarSchoolAttrData.Attr)))
				{
					EventSystem.Instance.Emit<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrImportantChanged, solarSchoolAttrData.Attr);
				}
			}
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportImportantAttrSelect(hashSet);
		}

		// Token: 0x0603800E RID: 229390 RVA: 0x00FA7794 File Offset: 0x00FA5994
		public int GetAttrBonus(ESolarSchoolSecondAttr attr)
		{
			return this.GetAttrBonusValue(attr) + this.GetBuffEffectValue((int)attr, 0);
		}

		// Token: 0x0603800F RID: 229391 RVA: 0x00FA77A6 File Offset: 0x00FA59A6
		public int GetAttr(ESolarSchoolSecondAttr attr)
		{
			return this.ClampAttr(attr, (long)this.GetBaseAttr(attr) + (long)this.GetAttrBonus(attr));
		}

		// Token: 0x06038010 RID: 229392 RVA: 0x00FA77C0 File Offset: 0x00FA59C0
		private int ClampAttr(ESolarSchoolSecondAttr attr, long value)
		{
			SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(attr);
			long min = (long)((attrConfig != null) ? attrConfig.GetValueOrDefault().MinValue : int.MinValue);
			long max = (long)((attrConfig != null) ? attrConfig.GetValueOrDefault().MaxValue : int.MaxValue);
			return (int)Math.Clamp(value, min, max);
		}

		// Token: 0x06038011 RID: 229393 RVA: 0x00FA7824 File Offset: 0x00FA5A24
		public int[] GetAttrList()
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			int[] array = new int[attrsShowList.Length];
			for (int i = 0; i < attrsShowList.Length; i++)
			{
				array[i] = this.GetAttr(attrsShowList[i]);
			}
			return array;
		}

		// Token: 0x06038012 RID: 229394 RVA: 0x00FA785C File Offset: 0x00FA5A5C
		public unsafe void SetAttr(ESolarSchoolSecondAttr attr, int value)
		{
			int attr2 = this.GetAttr(attr);
			int baseAttr = this.GetBaseAttr(attr);
			int requestedDelta = value - baseAttr;
			int num = this.ClampAttr(attr, (long)value);
			if (baseAttr == num)
			{
				this.EmitAttrChanged(attr, attr2, attr2, requestedDelta);
				return;
			}
			this.GetOrCreateAttrData(attr).BaseValue = num;
			int attr3 = this.GetAttr(attr);
			SolarSchoolGamePlayModel.Instance.SummaryRecordData.RecordAttrChange(attr, attr3 - attr2);
			SolarSchoolController.Instance.EnqueueAttrChange(attr, attr2, attr3);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 基础属性变化";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attr", attr);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldBase", baseAttr);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("newBase", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("old", attr2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("new", attr3);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			this.EmitAttrChanged(attr, attr2, attr3, requestedDelta);
		}

		// Token: 0x06038013 RID: 229395 RVA: 0x00FA7991 File Offset: 0x00FA5B91
		public void AddAttr(ESolarSchoolSecondAttr attr, int delta)
		{
			this.SetAttr(attr, this.GetBaseAttr(attr) + delta);
		}

		// Token: 0x06038014 RID: 229396 RVA: 0x00FA79A4 File Offset: 0x00FA5BA4
		public unsafe void AddAttrBonus(ESolarSchoolSecondAttr attr, int delta)
		{
			if (delta == 0)
			{
				return;
			}
			int attr2 = this.GetAttr(attr);
			int attrBonus = this.GetAttrBonus(attr);
			this.GetOrCreateAttrData(attr).BonusValue = this.GetAttrBonusValue(attr) + delta;
			int attr3 = this.GetAttr(attr);
			SolarSchoolGamePlayModel.Instance.SummaryRecordData.RecordAttrChange(attr, attr3 - attr2);
			SolarSchoolController.Instance.EnqueueAttrChange(attr, attr2, attr3);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 属性加成变化";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attr", attr);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldBonus", attrBonus);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("newBonus", this.GetAttrBonus(attr));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("old", attr2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("new", attr3);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			this.EmitAttrChanged(attr, attr2, attr3, delta);
		}

		// Token: 0x06038015 RID: 229397 RVA: 0x00FA7AC9 File Offset: 0x00FA5CC9
		private int GetAttrBonusValue(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolAttrData valueOrDefault = this.AttrMap.GetValueOrDefault(attr);
			if (valueOrDefault == null)
			{
				return 0;
			}
			return valueOrDefault.BonusValue;
		}

		// Token: 0x06038016 RID: 229398 RVA: 0x00FA7AE4 File Offset: 0x00FA5CE4
		public void ReplaceAttrBonuses(IReadOnlyDictionary<ESolarSchoolSecondAttr, int> bonusValues)
		{
			foreach (SolarSchoolAttrData solarSchoolAttrData in this.AttrMap.Values)
			{
				solarSchoolAttrData.BonusValue = 0;
			}
			foreach (KeyValuePair<ESolarSchoolSecondAttr, int> keyValuePair in bonusValues)
			{
				if (keyValuePair.Value != 0)
				{
					this.GetOrCreateAttrData(keyValuePair.Key).BonusValue = keyValuePair.Value;
				}
			}
		}

		// Token: 0x06038017 RID: 229399 RVA: 0x00FA7B8C File Offset: 0x00FA5D8C
		public int GetBuffEffectValue(int type, int behaviorId = 0)
		{
			int num = this.BuffEffectValues.GetValueOrDefault(new ValueTuple<int, int>(type, 0), 0);
			if (behaviorId > 0)
			{
				num += this.BuffEffectValues.GetValueOrDefault(new ValueTuple<int, int>(type, behaviorId), 0);
			}
			return num;
		}

		// Token: 0x06038018 RID: 229400 RVA: 0x00FA7BC8 File Offset: 0x00FA5DC8
		public int GetBehaviorBuffEffectValue(int type, int behaviorId)
		{
			if (behaviorId <= 0)
			{
				return 0;
			}
			return this.BuffEffectValues.GetValueOrDefault(new ValueTuple<int, int>(type, behaviorId), 0);
		}

		// Token: 0x06038019 RID: 229401 RVA: 0x00FA7BE4 File Offset: 0x00FA5DE4
		public void ReplaceBuffEffects([TupleElementNames(new string[]
		{
			"Type",
			"BehaviorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] Dictionary<ValueTuple<int, int>, int> effectValues, bool silentAttributeChanges)
		{
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = silentAttributeChanges ? null : this.CaptureAttrValues();
			Dictionary<ESolarSchoolSecondAttr, int> dictionary2 = null;
			if (dictionary != null)
			{
				dictionary2 = new Dictionary<ESolarSchoolSecondAttr, int>();
				foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in dictionary.Keys)
				{
					dictionary2[esolarSchoolSecondAttr] = this.GetAttrBonus(esolarSchoolSecondAttr);
				}
			}
			this.BuffEffectValues.Clear();
			foreach (KeyValuePair<ValueTuple<int, int>, int> keyValuePair in effectValues)
			{
				if (keyValuePair.Value != 0)
				{
					this.BuffEffectValues[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			if (dictionary == null)
			{
				return;
			}
			foreach (KeyValuePair<ESolarSchoolSecondAttr, int> keyValuePair2 in dictionary)
			{
				int attr = this.GetAttr(keyValuePair2.Key);
				SolarSchoolController.Instance.EnqueueAttrChange(keyValuePair2.Key, keyValuePair2.Value, attr);
				this.EmitAttrChanged(keyValuePair2.Key, keyValuePair2.Value, attr, this.GetAttrBonus(keyValuePair2.Key) - dictionary2[keyValuePair2.Key]);
			}
		}

		// Token: 0x0603801A RID: 229402 RVA: 0x00FA7D54 File Offset: 0x00FA5F54
		private Dictionary<ESolarSchoolSecondAttr, int> CaptureAttrValues()
		{
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in Enum.GetValues<ESolarSchoolSecondAttr>())
			{
				if (esolarSchoolSecondAttr != ESolarSchoolSecondAttr.None)
				{
					dictionary[esolarSchoolSecondAttr] = this.GetAttr(esolarSchoolSecondAttr);
				}
			}
			return dictionary;
		}

		// Token: 0x0603801B RID: 229403 RVA: 0x00FA7D94 File Offset: 0x00FA5F94
		private void EmitAttrChanged(ESolarSchoolSecondAttr attr, int oldValue, int newValue, int requestedDelta)
		{
			if (oldValue != newValue)
			{
				EventSystem.Instance.Emit<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, attr);
			}
			SolarSchoolAttr? attrConfig = SolarSchoolGamePlayModel.Instance.GetAttrConfig(attr);
			if (attrConfig != null)
			{
				SolarSchoolGamePlayModel.Instance.EnqueueRewardTip(ESolarSchoolRewardTipType.Attr, attrConfig.Value.Id, requestedDelta);
				if (oldValue != newValue)
				{
					int num = SolarSchoolUtils.CalcAttrRankTier(attrConfig.Value, oldValue);
					if (SolarSchoolUtils.CalcAttrRankTier(attrConfig.Value, newValue) > num)
					{
						SolarSchoolGamePlayModel.Instance.EnqueueAttrRankUp(new SolarSchoolAttrRankUpInfo
						{
							Attr = attr,
							OldValue = oldValue,
							NewValue = newValue
						});
					}
				}
			}
		}

		// Token: 0x17006B6D RID: 27501
		// (get) Token: 0x0603801C RID: 229404 RVA: 0x00FA7E34 File Offset: 0x00FA6034
		// (set) Token: 0x0603801D RID: 229405 RVA: 0x00FA7E3C File Offset: 0x00FA603C
		public int LastWeeklyRewardDayIndex { get; private set; } = -1;

		// Token: 0x0603801E RID: 229406 RVA: 0x00FA7E45 File Offset: 0x00FA6045
		public static bool IsValidBuffDuration(int durationDays)
		{
			return durationDays == -1 || durationDays > 0;
		}

		// Token: 0x0603801F RID: 229407 RVA: 0x00FA7E51 File Offset: 0x00FA6051
		public bool HasBuff(int buffId)
		{
			return this.Buffs.ContainsKey(buffId);
		}

		// Token: 0x06038020 RID: 229408 RVA: 0x00FA7E60 File Offset: 0x00FA6060
		public int GetBuffRemainingDays(int buffId)
		{
			int result;
			if (!this.Buffs.TryGetValue(buffId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06038021 RID: 229409 RVA: 0x00FA7E80 File Offset: 0x00FA6080
		public IReadOnlyList<int> GetActiveBuffIds()
		{
			int[] array = new int[this.Buffs.Count];
			this.Buffs.Keys.CopyTo(array, 0);
			Array.Sort<int>(array);
			return Array.AsReadOnly<int>(array);
		}

		// Token: 0x06038022 RID: 229410 RVA: 0x00FA7EBC File Offset: 0x00FA60BC
		public bool TryAddBuff(int buffId, int durationDays, out bool isNew)
		{
			isNew = false;
			if (buffId <= 0 || !SolarSchoolPlayerData.IsValidBuffDuration(durationDays))
			{
				return false;
			}
			int num;
			if (!this.Buffs.TryGetValue(buffId, out num))
			{
				this.Buffs.Add(buffId, durationDays);
				isNew = true;
				return true;
			}
			if (num == -1 || durationDays == -1)
			{
				this.Buffs[buffId] = -1;
			}
			else if (durationDays > num)
			{
				this.Buffs[buffId] = durationDays;
			}
			return true;
		}

		// Token: 0x06038023 RID: 229411 RVA: 0x00FA7F25 File Offset: 0x00FA6125
		public bool RemoveBuff(int buffId)
		{
			return this.Buffs.Remove(buffId);
		}

		// Token: 0x06038024 RID: 229412 RVA: 0x00FA7F34 File Offset: 0x00FA6134
		public List<int> AdvanceBuffDays()
		{
			List<int> list = new List<int>();
			int[] array = new int[this.Buffs.Count];
			this.Buffs.Keys.CopyTo(array, 0);
			foreach (int num in array)
			{
				int num2 = this.Buffs[num];
				if (num2 != -1)
				{
					num2--;
					if (num2 <= 0)
					{
						this.Buffs.Remove(num);
						list.Add(num);
					}
					else
					{
						this.Buffs[num] = num2;
					}
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x06038025 RID: 229413 RVA: 0x00FA7FCC File Offset: 0x00FA61CC
		public bool IsWeeklyRewardSettled(int mondayDayIndex)
		{
			return mondayDayIndex >= 0 && this.LastWeeklyRewardDayIndex == mondayDayIndex;
		}

		// Token: 0x06038026 RID: 229414 RVA: 0x00FA7FDD File Offset: 0x00FA61DD
		public bool MarkWeeklyRewardSettled(int mondayDayIndex)
		{
			if (mondayDayIndex < 0 || mondayDayIndex <= this.LastWeeklyRewardDayIndex)
			{
				return false;
			}
			this.LastWeeklyRewardDayIndex = mondayDayIndex;
			return true;
		}

		// Token: 0x06038027 RID: 229415 RVA: 0x00FA7FF6 File Offset: 0x00FA61F6
		public void ClearBuffs()
		{
			this.Buffs.Clear();
			this.BuffEffectValues.Clear();
			this.LastWeeklyRewardDayIndex = -1;
		}

		// Token: 0x06038028 RID: 229416 RVA: 0x00FA8018 File Offset: 0x00FA6218
		private SolarSchoolBehaviorData EnsureBehaviorData(int behaviorId)
		{
			SolarSchoolBehaviorData solarSchoolBehaviorData;
			if (!this.BehaviorMap.TryGetValue(behaviorId, out solarSchoolBehaviorData))
			{
				solarSchoolBehaviorData = new SolarSchoolBehaviorData(behaviorId);
				this.BehaviorMap[behaviorId] = solarSchoolBehaviorData;
			}
			return solarSchoolBehaviorData;
		}

		// Token: 0x06038029 RID: 229417 RVA: 0x00FA804A File Offset: 0x00FA624A
		[NullableContext(2)]
		public SolarSchoolBehaviorData GetBehaviorData(int behaviorId)
		{
			return this.BehaviorMap.GetValueOrDefault(behaviorId);
		}

		// Token: 0x0603802A RID: 229418 RVA: 0x00FA8058 File Offset: 0x00FA6258
		public int GetCompletedCount(int behaviorId)
		{
			SolarSchoolBehaviorData behaviorData = this.GetBehaviorData(behaviorId);
			if (behaviorData == null)
			{
				return 0;
			}
			return behaviorData.CompletedCount;
		}

		// Token: 0x0603802B RID: 229419 RVA: 0x00FA806C File Offset: 0x00FA626C
		public int GetSuccessCount(int behaviorId)
		{
			SolarSchoolBehaviorData behaviorData = this.GetBehaviorData(behaviorId);
			if (behaviorData == null)
			{
				return 0;
			}
			return behaviorData.SuccessCount;
		}

		// Token: 0x0603802C RID: 229420 RVA: 0x00FA8080 File Offset: 0x00FA6280
		public void WatchBehaviorsUnlock(int activityId)
		{
			this.UnwatchBehaviorsUnlock();
			IReadOnlyList<SolarSchoolBehavior> behaviorListByActivityId = SolarSchoolConfig.Instance.GetBehaviorListByActivityId(activityId);
			if (behaviorListByActivityId == null)
			{
				return;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SolarSchoolBehavior solarSchoolBehavior in behaviorListByActivityId)
			{
				if (hashSet.Add(solarSchoolBehavior.BehaviorId))
				{
					this.WatchBehaviorUnlock(solarSchoolBehavior.BehaviorId);
				}
			}
		}

		// Token: 0x0603802D RID: 229421 RVA: 0x00FA80FC File Offset: 0x00FA62FC
		public void UnwatchBehaviorsUnlock()
		{
			long[] array = new long[this.BehaviorUnlockHandleMap.Count];
			this.BehaviorUnlockHandleMap.Values.CopyTo(array, 0);
			this.BehaviorUnlockHandleMap.Clear();
			foreach (long uniqueId in array)
			{
				ActivityConditionCenter.Instance.Unregister(uniqueId);
			}
			this.UnlockedBehaviorNotifyQueue.Clear();
			this.NotifyingBehaviorUnlocked = false;
		}

		// Token: 0x0603802E RID: 229422 RVA: 0x00FA8168 File Offset: 0x00FA6368
		private unsafe void WatchBehaviorUnlock(int behaviorId)
		{
			if (this.BehaviorUnlockHandleMap.ContainsKey(behaviorId))
			{
				return;
			}
			SolarSchoolBehavior? currentLevelRow = this.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null || currentLevelRow.Value.ShowConditionGroupId == 0)
			{
				return;
			}
			int showConditionGroupId = currentLevelRow.Value.ShowConditionGroupId;
			if (this.HasBehaviorUnlockedCondition(showConditionGroupId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为显示条件禁止包含行为已解锁条件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("showConditionGroupId", showConditionGroupId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (SolarSchoolGamePlayModel.Instance.IsBehaviorUnlocked(behaviorId))
			{
				return;
			}
			long num = ActivityConditionCenter.Instance.RegisterGroup(showConditionGroupId, delegate
			{
				this.OnBehaviorUnlockConditionReached(behaviorId);
			});
			if (num == 0L)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 行为注册解锁监听失败，请检查显示条件是否可监听及条件构建日志";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("showConditionGroupId", showConditionGroupId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			this.BehaviorUnlockHandleMap[behaviorId] = num;
		}

		// Token: 0x0603802F RID: 229423 RVA: 0x00FA82EC File Offset: 0x00FA64EC
		private bool HasBehaviorUnlockedCondition(int conditionGroupId)
		{
			Aki.Config.ActivityConditionGroup? conditionGroupConfig = ActivityConditionConfig.Instance.GetConditionGroupConfig(conditionGroupId);
			if (conditionGroupConfig == null)
			{
				return false;
			}
			foreach (int conditionId in conditionGroupConfig.Value.GetGroupIdArray())
			{
				ActivityCondition? conditionConfig = ActivityConditionConfig.Instance.GetConditionConfig(conditionId);
				if (conditionConfig != null && conditionConfig.Value.Type == 22)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038030 RID: 229424 RVA: 0x00FA8364 File Offset: 0x00FA6564
		private void OnBehaviorUnlockConditionReached(int behaviorId)
		{
			this.BehaviorUnlockHandleMap.Remove(behaviorId);
			if (!SolarSchoolGamePlayModel.Instance.IsBehaviorUnlocked(behaviorId))
			{
				this.WatchBehaviorUnlock(behaviorId);
				return;
			}
			this.UnlockedBehaviorNotifyQueue.Add(behaviorId);
			if (this.NotifyingBehaviorUnlocked)
			{
				return;
			}
			this.NotifyingBehaviorUnlocked = true;
			try
			{
				for (int i = 0; i < this.UnlockedBehaviorNotifyQueue.Count; i++)
				{
					EventSystem.Instance.Emit<int>(EEventName.SolarSchoolBehaviorUnlocked, this.UnlockedBehaviorNotifyQueue[i]);
				}
			}
			finally
			{
				this.UnlockedBehaviorNotifyQueue.Clear();
				this.NotifyingBehaviorUnlocked = false;
			}
		}

		// Token: 0x06038031 RID: 229425 RVA: 0x00FA8408 File Offset: 0x00FA6608
		public void OnBehaviorExecuted(int behaviorId, bool success)
		{
			this.EnsureBehaviorData(behaviorId).OnExecuted(success);
			EventSystem.Instance.Emit<int, bool>(EEventName.SolarSchoolBehaviorSettled, behaviorId, success);
		}

		// Token: 0x06038032 RID: 229426 RVA: 0x00FA8429 File Offset: 0x00FA6629
		public void GmAddBehaviorCount(int behaviorId, int delta)
		{
			this.EnsureBehaviorData(behaviorId).AddCount(delta);
			EventSystem.Instance.Emit<int, bool>(EEventName.SolarSchoolBehaviorSettled, behaviorId, true);
		}

		// Token: 0x06038033 RID: 229427 RVA: 0x00FA844A File Offset: 0x00FA664A
		public SolarSchoolBehavior? GetCurrentLevelRow(int behaviorId)
		{
			return SolarSchoolConfig.Instance.SelectBehaviorRow(SolarSchoolGamePlayModel.Instance.ActivityId, behaviorId, this.GetCompletedCount(behaviorId));
		}

		// Token: 0x06038034 RID: 229428 RVA: 0x00FA8468 File Offset: 0x00FA6668
		public string GetBehaviorName(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				return string.Empty;
			}
			return SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.Name);
		}

		// Token: 0x06038035 RID: 229429 RVA: 0x00FA84A0 File Offset: 0x00FA66A0
		public string GetBehaviorNameWithLevel(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				return string.Empty;
			}
			string textWithPlaceholder = SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.Name);
			if (currentLevelRow.Value.BehaviorType == 4 || currentLevelRow.Value.Level <= 0)
			{
				return textWithPlaceholder;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendFormatted(textWithPlaceholder);
			defaultInterpolatedStringHandler.AppendLiteral(" Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentLevelRow.Value.Level);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06038036 RID: 229430 RVA: 0x00FA8539 File Offset: 0x00FA6739
		public ESolarSchoolSpecialState GetSpecialState(int behaviorId)
		{
			SolarSchoolBehaviorData behaviorData = this.GetBehaviorData(behaviorId);
			if (behaviorData == null)
			{
				return ESolarSchoolSpecialState.None;
			}
			return behaviorData.SpecialState;
		}

		// Token: 0x06038037 RID: 229431 RVA: 0x00FA854D File Offset: 0x00FA674D
		public void SetSpecialState(int behaviorId, ESolarSchoolSpecialState state)
		{
			if (this.EnsureBehaviorData(behaviorId).SetSpecialState(state))
			{
				EventSystem.Instance.Emit<int>(EEventName.SolarSchoolSpecialStateChanged, behaviorId);
			}
		}

		// Token: 0x06038038 RID: 229432 RVA: 0x00FA856F File Offset: 0x00FA676F
		public bool IsSpecialTalkViewed(int behaviorId)
		{
			SolarSchoolBehaviorData behaviorData = this.GetBehaviorData(behaviorId);
			return behaviorData != null && behaviorData.SpecialTalkViewed;
		}

		// Token: 0x06038039 RID: 229433 RVA: 0x00FA8583 File Offset: 0x00FA6783
		public void MarkSpecialTalkViewed(int behaviorId)
		{
			this.EnsureBehaviorData(behaviorId).MarkSpecialTalkViewed();
		}

		// Token: 0x0603803A RID: 229434 RVA: 0x00FA8594 File Offset: 0x00FA6794
		public int GetSpecialStateCount()
		{
			return this.CountSpecialState(null);
		}

		// Token: 0x0603803B RID: 229435 RVA: 0x00FA85B0 File Offset: 0x00FA67B0
		public int GetFinishedSpecialCount()
		{
			return this.CountSpecialState(new ESolarSchoolSpecialState?(ESolarSchoolSpecialState.Finished));
		}

		// Token: 0x0603803C RID: 229436 RVA: 0x00FA85C0 File Offset: 0x00FA67C0
		private int CountSpecialState(ESolarSchoolSpecialState? filter)
		{
			int num = 0;
			foreach (SolarSchoolBehaviorData solarSchoolBehaviorData in this.BehaviorMap.Values)
			{
				if (solarSchoolBehaviorData.SpecialState != ESolarSchoolSpecialState.None)
				{
					if (filter != null)
					{
						ESolarSchoolSpecialState specialState = solarSchoolBehaviorData.SpecialState;
						ESolarSchoolSpecialState? esolarSchoolSpecialState = filter;
						if (!(specialState == esolarSchoolSpecialState.GetValueOrDefault() & esolarSchoolSpecialState != null))
						{
							continue;
						}
					}
					num++;
				}
			}
			return num;
		}

		// Token: 0x0603803D RID: 229437 RVA: 0x00FA8644 File Offset: 0x00FA6844
		public int GetInfluenceLevel(ESolarSchoolInfluence influence)
		{
			return this.InfluenceLevels.GetValueOrDefault(influence, 0);
		}

		// Token: 0x0603803E RID: 229438 RVA: 0x00FA8653 File Offset: 0x00FA6853
		public bool HasInfluence(ESolarSchoolInfluence influence)
		{
			return this.GetInfluenceLevel(influence) > 0;
		}

		// Token: 0x0603803F RID: 229439 RVA: 0x00FA8660 File Offset: 0x00FA6860
		public IReadOnlyList<int> GetInfluenceIds()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<ESolarSchoolInfluence, int> keyValuePair in this.InfluenceLevels)
			{
				if (keyValuePair.Value > 0)
				{
					list.Add((int)keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x06038040 RID: 229440 RVA: 0x00FA86CC File Offset: 0x00FA68CC
		public unsafe bool SetInfluenceLevel(ESolarSchoolInfluence influence, int level)
		{
			if (influence == ESolarSchoolInfluence.None || !Enum.IsDefined(typeof(ESolarSchoolInfluence), influence) || level <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 设置阵营等级参数无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("influence", influence);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			int influenceLevel = this.GetInfluenceLevel(influence);
			if (level == influenceLevel)
			{
				return true;
			}
			this.InfluenceLevels[influence] = level;
			if (influenceLevel <= 0)
			{
				SolarSchoolController.Instance.EnqueueJoinInfluence((int)influence);
				SolarSchoolGamePlayModel.Instance.LogReporter.ReportInfluenceJoin(influence);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "[SolarSchool] 阵营等级变更";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("influence", influence);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("level", level);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			EventSystem.Instance.Emit(EEventName.SolarSchoolInfluenceChanged);
			return true;
		}

		// Token: 0x06038041 RID: 229441 RVA: 0x00FA8804 File Offset: 0x00FA6A04
		public int GetExamScore(int examId)
		{
			SolarSchoolExamResult solarSchoolExamResult;
			if (!this.TryGetExamResult(examId, out solarSchoolExamResult))
			{
				return 0;
			}
			return solarSchoolExamResult.Score;
		}

		// Token: 0x06038042 RID: 229442 RVA: 0x00FA8824 File Offset: 0x00FA6A24
		public void SetExamPublish(int examId, bool isPublished)
		{
			SolarSchoolExamResult solarSchoolExamResult;
			if (!this.TryGetExamResult(examId, out solarSchoolExamResult))
			{
				return;
			}
			solarSchoolExamResult.IsPublished = isPublished;
		}

		// Token: 0x06038043 RID: 229443 RVA: 0x00FA8844 File Offset: 0x00FA6A44
		public void InitExamResult(int examId)
		{
			this.ExamResults[examId] = new SolarSchoolExamResult(examId, 0, 0, false);
		}

		// Token: 0x06038044 RID: 229444 RVA: 0x00FA885C File Offset: 0x00FA6A5C
		public unsafe int AddExamScore(int examId, int value)
		{
			SolarSchoolExam? exam = SolarSchoolConfig.Instance.GetExam(examId);
			if (exam == null)
			{
				return -1;
			}
			SolarSchoolExamResult solarSchoolExamResult;
			if (!this.TryGetExamResult(examId, out solarSchoolExamResult))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Exam] 考试成绩未初始化";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("examId", examId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return -1;
			}
			solarSchoolExamResult.Score = (int)Math.Clamp((long)solarSchoolExamResult.Score + (long)value, (long)exam.Value.ScoreMin, (long)exam.Value.ScoreMax);
			return solarSchoolExamResult.Score;
		}

		// Token: 0x06038045 RID: 229445 RVA: 0x00FA8929 File Offset: 0x00FA6B29
		public IReadOnlyDictionary<int, SolarSchoolExamResult> GetExamResults()
		{
			return this.ExamResults;
		}

		// Token: 0x06038046 RID: 229446 RVA: 0x00FA8931 File Offset: 0x00FA6B31
		[NullableContext(2)]
		public bool TryGetExamResult(int examId, [NotNullWhen(true)] out SolarSchoolExamResult result)
		{
			return this.ExamResults.TryGetValue(examId, out result);
		}

		// Token: 0x06038047 RID: 229447 RVA: 0x00FA8940 File Offset: 0x00FA6B40
		[NullableContext(2)]
		public bool TryGetLatestExamResult(ESolarSchoolExamType examType, [NotNullWhen(true)] out SolarSchoolExamResult result)
		{
			result = null;
			int key;
			return this.LatestExamIds.TryGetValue(examType, out key) && this.ExamResults.TryGetValue(key, out result);
		}

		// Token: 0x06038048 RID: 229448 RVA: 0x00FA8970 File Offset: 0x00FA6B70
		public void SetExamResult(SolarSchoolExamResult result, ESolarSchoolExamType examType)
		{
			this.ExamResults[result.ExamId] = result;
			this.LatestExamIds[examType] = result.ExamId;
			SolarSchoolController.Instance.EnqueueExamFinish(result.ExamId, result.Score);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolExamScoreChanged, result.ExamId);
		}

		// Token: 0x06038049 RID: 229449 RVA: 0x00FA89D0 File Offset: 0x00FA6BD0
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolPlayerDataPb solarSchoolPlayerDataPb = SolarSchoolPlayerDataPb.Create();
			foreach (KeyValuePair<ESolarSchoolSecondAttr, SolarSchoolAttrData> keyValuePair in this.AttrMap)
			{
				SolarSchoolAttrPb solarSchoolAttrPb = SolarSchoolAttrPb.Create();
				solarSchoolAttrPb.AttrType = (SolarSchoolAttrType)keyValuePair.Key;
				solarSchoolAttrPb.Value = keyValuePair.Value.BaseValue;
				solarSchoolAttrPb.Important = keyValuePair.Value.IsImportant;
				solarSchoolPlayerDataPb.Attr.Add(solarSchoolAttrPb);
			}
			foreach (KeyValuePair<ESolarSchoolInfluence, int> keyValuePair2 in this.InfluenceLevels)
			{
				if (keyValuePair2.Value > 0)
				{
					SolarSchoolInfluenceLevelPb solarSchoolInfluenceLevelPb = SolarSchoolInfluenceLevelPb.Create();
					solarSchoolInfluenceLevelPb.InfluenceId = (int)keyValuePair2.Key;
					solarSchoolInfluenceLevelPb.Level = keyValuePair2.Value;
					solarSchoolPlayerDataPb.InfluenceLevels.Add(solarSchoolInfluenceLevelPb);
				}
			}
			foreach (KeyValuePair<int, SolarSchoolBehaviorData> keyValuePair3 in this.BehaviorMap)
			{
				SolarSchoolBehaviorCountPb solarSchoolBehaviorCountPb = SolarSchoolBehaviorCountPb.Create();
				solarSchoolBehaviorCountPb.BehaviorId = keyValuePair3.Key;
				solarSchoolBehaviorCountPb.TotalCount = keyValuePair3.Value.CompletedCount;
				solarSchoolBehaviorCountPb.SuccessCount = keyValuePair3.Value.SuccessCount;
				solarSchoolBehaviorCountPb.SpecialState = (int)keyValuePair3.Value.SpecialState;
				solarSchoolPlayerDataPb.Behavior.Add(solarSchoolBehaviorCountPb);
			}
			foreach (KeyValuePair<int, int> keyValuePair4 in this.Buffs)
			{
				SolarSchoolIdCountPb solarSchoolIdCountPb = SolarSchoolIdCountPb.Create();
				solarSchoolIdCountPb.Id = keyValuePair4.Key;
				solarSchoolIdCountPb.Count = keyValuePair4.Value;
				solarSchoolPlayerDataPb.Buff.Add(solarSchoolIdCountPb);
			}
			gameData.Player = solarSchoolPlayerDataPb;
			this.SerializeExam(gameData);
		}

		// Token: 0x0603804A RID: 229450 RVA: 0x00FA8BF0 File Offset: 0x00FA6DF0
		public unsafe override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.AttrMap.Clear();
			this.BuffEffectValues.Clear();
			this.Buffs.Clear();
			this.LastWeeklyRewardDayIndex = -1;
			this.BehaviorMap.Clear();
			this.InfluenceLevels.Clear();
			this.ExamResults.Clear();
			this.LatestExamIds.Clear();
			if (gameData.Player == null)
			{
				return;
			}
			foreach (SolarSchoolAttrPb solarSchoolAttrPb in gameData.Player.Attr)
			{
				ESolarSchoolSecondAttr attrType = (ESolarSchoolSecondAttr)solarSchoolAttrPb.AttrType;
				SolarSchoolAttrData orCreateAttrData = this.GetOrCreateAttrData(attrType);
				orCreateAttrData.BaseValue = this.ClampAttr(attrType, (long)solarSchoolAttrPb.Value);
				orCreateAttrData.SetImportant(solarSchoolAttrPb.Important);
			}
			foreach (SolarSchoolInfluenceLevelPb solarSchoolInfluenceLevelPb in gameData.Player.InfluenceLevels)
			{
				ESolarSchoolInfluence influenceId = (ESolarSchoolInfluence)solarSchoolInfluenceLevelPb.InfluenceId;
				if (influenceId != ESolarSchoolInfluence.None && Enum.IsDefined(typeof(ESolarSchoolInfluence), influenceId) && solarSchoolInfluenceLevelPb.Level > 0)
				{
					this.InfluenceLevels[influenceId] = solarSchoolInfluenceLevelPb.Level;
				}
			}
			foreach (SolarSchoolBehaviorCountPb solarSchoolBehaviorCountPb in gameData.Player.Behavior)
			{
				this.EnsureBehaviorData(solarSchoolBehaviorCountPb.BehaviorId).RestoreFromSave(solarSchoolBehaviorCountPb.TotalCount, solarSchoolBehaviorCountPb.SuccessCount, (ESolarSchoolSpecialState)solarSchoolBehaviorCountPb.SpecialState);
			}
			foreach (SolarSchoolIdCountPb solarSchoolIdCountPb in gameData.Player.Buff)
			{
				if (!SolarSchoolPlayerData.IsValidBuffDuration(solarSchoolIdCountPb.Count))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 存档 Buff 剩余天数非法，已丢弃";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", solarSchoolIdCountPb.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("remainingDays", solarSchoolIdCountPb.Count);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					this.Buffs[solarSchoolIdCountPb.Id] = solarSchoolIdCountPb.Count;
				}
			}
			this.DeserializeExam(gameData);
		}

		// Token: 0x0603804B RID: 229451 RVA: 0x00FA8E94 File Offset: 0x00FA7094
		private void SerializeExam(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolExamDataPb solarSchoolExamDataPb = SolarSchoolExamDataPb.Create();
			foreach (KeyValuePair<int, SolarSchoolExamResult> keyValuePair in this.ExamResults)
			{
				SolarSchoolExamResult solarSchoolExamResult = SolarSchoolExamResult.Create();
				solarSchoolExamResult.Id = keyValuePair.Key;
				solarSchoolExamResult.Score = keyValuePair.Value.Score;
				solarSchoolExamResult.Rank = keyValuePair.Value.Rank;
				solarSchoolExamResult.Published = keyValuePair.Value.IsPublished;
				solarSchoolExamDataPb.Exam.Add(solarSchoolExamResult);
			}
			gameData.Exam = solarSchoolExamDataPb;
		}

		// Token: 0x0603804C RID: 229452 RVA: 0x00FA8F44 File Offset: 0x00FA7144
		private void DeserializeExam(SolarSchoolSaveGamePb game)
		{
			if (game.Exam == null)
			{
				return;
			}
			foreach (SolarSchoolExamResult solarSchoolExamResult in game.Exam.Exam)
			{
				this.ExamResults[solarSchoolExamResult.Id] = new SolarSchoolExamResult(solarSchoolExamResult.Id, solarSchoolExamResult.Score, solarSchoolExamResult.Rank, solarSchoolExamResult.Published);
				SolarSchoolExam? exam = SolarSchoolConfig.Instance.GetExam(solarSchoolExamResult.Id);
				if (exam != null)
				{
					ESolarSchoolExamType examType = (ESolarSchoolExamType)exam.Value.ExamType;
					int num;
					if (!this.LatestExamIds.TryGetValue(examType, out num) || solarSchoolExamResult.Id > num)
					{
						this.LatestExamIds[examType] = solarSchoolExamResult.Id;
					}
				}
			}
		}

		// Token: 0x0401D888 RID: 120968
		public EPlayerGender Gender = EPlayerGender.None;

		// Token: 0x0401D889 RID: 120969
		private readonly Dictionary<ESolarSchoolSecondAttr, SolarSchoolAttrData> AttrMap = new Dictionary<ESolarSchoolSecondAttr, SolarSchoolAttrData>();

		// Token: 0x0401D88A RID: 120970
		[TupleElementNames(new string[]
		{
			"Type",
			"BehaviorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Dictionary<ValueTuple<int, int>, int> BuffEffectValues = new Dictionary<ValueTuple<int, int>, int>();

		// Token: 0x0401D88B RID: 120971
		public const int PermanentBuffDurationDays = -1;

		// Token: 0x0401D88C RID: 120972
		public const int UnsettledWeeklyRewardDayIndex = -1;

		// Token: 0x0401D88D RID: 120973
		private readonly Dictionary<int, int> Buffs = new Dictionary<int, int>();

		// Token: 0x0401D88F RID: 120975
		private readonly Dictionary<int, SolarSchoolBehaviorData> BehaviorMap = new Dictionary<int, SolarSchoolBehaviorData>();

		// Token: 0x0401D890 RID: 120976
		private readonly Dictionary<int, long> BehaviorUnlockHandleMap = new Dictionary<int, long>();

		// Token: 0x0401D891 RID: 120977
		private readonly List<int> UnlockedBehaviorNotifyQueue = new List<int>();

		// Token: 0x0401D892 RID: 120978
		private bool NotifyingBehaviorUnlocked;

		// Token: 0x0401D893 RID: 120979
		private readonly Dictionary<ESolarSchoolInfluence, int> InfluenceLevels = new Dictionary<ESolarSchoolInfluence, int>();

		// Token: 0x0401D894 RID: 120980
		private readonly Dictionary<int, SolarSchoolExamResult> ExamResults = new Dictionary<int, SolarSchoolExamResult>();

		// Token: 0x0401D895 RID: 120981
		private readonly Dictionary<ESolarSchoolExamType, int> LatestExamIds = new Dictionary<ESolarSchoolExamType, int>();
	}
}

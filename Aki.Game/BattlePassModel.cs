using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x0200180B RID: 6155
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattlePassModel : ModelBase
{
	// Token: 0x0600F16B RID: 61803 RVA: 0x0046E757 File Offset: 0x0046C957
	public bool GetInTimeRange()
	{
		return this.InTimeRange;
	}

	// Token: 0x0600F16C RID: 61804 RVA: 0x0046E75F File Offset: 0x0046C95F
	public void SetInTimeRange(bool value)
	{
		this.InTimeRange = value;
	}

	// Token: 0x0600F16D RID: 61805 RVA: 0x0046E768 File Offset: 0x0046C968
	public long GetDayEndTime()
	{
		return this.DayEndTime;
	}

	// Token: 0x0600F16E RID: 61806 RVA: 0x0046E770 File Offset: 0x0046C970
	public long GetWeekEndTime()
	{
		return this.WeekEndTime;
	}

	// Token: 0x0600F16F RID: 61807 RVA: 0x0046E778 File Offset: 0x0046C978
	public int GetGiftId()
	{
		return this.GiftId;
	}

	// Token: 0x170016F4 RID: 5876
	// (get) Token: 0x0600F170 RID: 61808 RVA: 0x0046E780 File Offset: 0x0046C980
	public int PrimaryItemId
	{
		get
		{
			return ConfigCommonParamById.GetIntArrayConfig("PrimaryGiftItem")[0];
		}
	}

	// Token: 0x170016F5 RID: 5877
	// (get) Token: 0x0600F171 RID: 61809 RVA: 0x0046E792 File Offset: 0x0046C992
	public int AdvanceItemId
	{
		get
		{
			return ConfigCommonParamById.GetIntArrayConfig("AdvancedGiftItem")[0];
		}
	}

	// Token: 0x170016F6 RID: 5878
	// (get) Token: 0x0600F172 RID: 61810 RVA: 0x0046E7A4 File Offset: 0x0046C9A4
	// (set) Token: 0x0600F173 RID: 61811 RVA: 0x0046E7AC File Offset: 0x0046C9AC
	public bool HadEnter
	{
		get
		{
			return this.HadEnterInternal;
		}
		set
		{
			if (this.HadEnterInternal != value)
			{
				this.HadEnterInternal = value;
				EventSystem.Instance.Emit(EEventName.BattlePassHadEnterUpdate);
			}
		}
	}

	// Token: 0x0600F174 RID: 61812 RVA: 0x0046E7D0 File Offset: 0x0046C9D0
	public List<WeaponDataBase> GetWeaponDataList()
	{
		if (this.WeaponDataList == null)
		{
			this.WeaponDataList = new List<WeaponDataBase>();
			foreach (int trialId in ConfigCommonParamById.GetIntArrayConfig("BattlePassUnlockWeapons"))
			{
				WeaponTrialData weaponTrialData = new WeaponTrialData();
				weaponTrialData.SetTrialId(trialId, true);
				this.WeaponDataList.Add(weaponTrialData);
			}
		}
		return this.WeaponDataList;
	}

	// Token: 0x0600F175 RID: 61813 RVA: 0x0046E850 File Offset: 0x0046CA50
	[NullableContext(2)]
	public BattlePassRewardData GetRewardData(int level)
	{
		if (level - 1 < 0 || level - 1 >= this.RewardDataList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "战令奖励数据 没有这个等级的";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("level", level);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		BattlePassRewardData battlePassRewardData = this.RewardDataList[level - 1];
		if (battlePassRewardData == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "战令奖励数据 没有这个等级的";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("level", level);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return battlePassRewardData;
	}

	// Token: 0x170016F7 RID: 5879
	// (get) Token: 0x0600F176 RID: 61814 RVA: 0x0046E8E0 File Offset: 0x0046CAE0
	// (set) Token: 0x0600F177 RID: 61815 RVA: 0x0046E910 File Offset: 0x0046CB10
	public bool PayButtonRedDotState
	{
		get
		{
			if (this.PayButtonRedDotStateInternal == null)
			{
				this.PayButtonRedDotStateInternal = new bool?(LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.BattlePassPayButton, true));
			}
			return this.PayButtonRedDotStateInternal.Value;
		}
		set
		{
			bool? payButtonRedDotStateInternal = this.PayButtonRedDotStateInternal;
			if (!(payButtonRedDotStateInternal.GetValueOrDefault() == value & payButtonRedDotStateInternal != null))
			{
				this.PayButtonRedDotStateInternal = new bool?(value);
				EventSystem.Instance.Emit(EEventName.BattlePassHadEnterUpdate);
				LocalStorage.SetPlayer<bool?>(ELocalStoragePlayerKey.BattlePassPayButton, this.PayButtonRedDotStateInternal);
			}
		}
	}

	// Token: 0x0600F178 RID: 61816 RVA: 0x0046E964 File Offset: 0x0046CB64
	public int GetMaxLevel()
	{
		return this.MaxLevel;
	}

	// Token: 0x0600F179 RID: 61817 RVA: 0x0046E96C File Offset: 0x0046CB6C
	public bool IsLevelMax()
	{
		return this.CurrentBattlePassLevel >= this.MaxLevel;
	}

	// Token: 0x0600F17A RID: 61818 RVA: 0x0046E97F File Offset: 0x0046CB7F
	public bool IsWeekMax()
	{
		return this.WeekExp >= this.MaxWeekExp;
	}

	// Token: 0x0600F17B RID: 61819 RVA: 0x0046E994 File Offset: 0x0046CB94
	public int GetNextStageLevel(int currentLevel)
	{
		if (currentLevel == 0)
		{
			return 0;
		}
		int result = 0;
		foreach (int num in this.StageLevelList)
		{
			if (num > currentLevel)
			{
				result = num;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600F17C RID: 61820 RVA: 0x0046E9F0 File Offset: 0x0046CBF0
	public void InitBattlePassConfigData()
	{
		int battlePassId = this.BattlePassId;
		this.RewardDataList.Clear();
		BattlePass? battlePassData = BattlePassConfig.Instance.GetBattlePassData(battlePassId);
		this.MaxLevel = battlePassData.Value.LevelLimit;
		foreach (BattlePassReward battlePassReward in BattlePassConfig.Instance.GetAllRewardData(battlePassData.Value.BattlePassRewardId))
		{
			if (battlePassReward.Level <= this.MaxLevel)
			{
				BattlePassRewardData battlePassRewardData = new BattlePassRewardData(new int?(battlePassReward.Level));
				foreach (KeyValuePair<int, int> keyValuePair in battlePassReward.FreeReward())
				{
					BattlePassRewardItem battlePassRewardItem = new BattlePassRewardItem(keyValuePair.Key, keyValuePair.Value, EBattlePassItemType.Locked);
					if (this.BattlePassLevel >= battlePassReward.Level)
					{
						battlePassRewardItem.ItemType = new EBattlePassItemType?(EBattlePassItemType.CanGet);
					}
					battlePassRewardData.FreeRewardItem.Add(battlePassRewardItem);
				}
				foreach (KeyValuePair<int, int> keyValuePair2 in battlePassReward.PayReward())
				{
					BattlePassRewardItem battlePassRewardItem2 = new BattlePassRewardItem(keyValuePair2.Key, keyValuePair2.Value, EBattlePassItemType.Locked);
					if (this.BattlePassLevel >= battlePassReward.Level && this.BattlePassType != BattlePassPayStatus.NoPaid)
					{
						battlePassRewardItem2.ItemType = new EBattlePassItemType?(EBattlePassItemType.CanGet);
					}
					battlePassRewardData.PayRewardItem.Add(battlePassRewardItem2);
				}
				if (battlePassReward.IsMilestone)
				{
					this.StageLevelList.Add(battlePassReward.Level);
				}
				this.RewardDataList.Add(battlePassRewardData);
			}
		}
		this.MaxWeekExp = battlePassData.Value.WeekExpLimit;
		this.MaxLevelExp = battlePassData.Value.LevelUpExp;
		this.UpdateLimitValue();
	}

	// Token: 0x0600F17D RID: 61821 RVA: 0x0046EC28 File Offset: 0x0046CE28
	private void UpdateLimitValue()
	{
		this.AllExpLimitValue = this.MaxLevelExp * (this.MaxLevel - this.CurrentBattlePassLevel) - this.LevelExp;
		this.WeekExpLimitValue = this.MaxWeekExp - this.WeekExp;
	}

	// Token: 0x0600F17E RID: 61822 RVA: 0x0046EC60 File Offset: 0x0046CE60
	[NullableContext(0)]
	private ValueTuple<int, int> GetTasksExp([Nullable(1)] List<int> taskIdList)
	{
		int num = 0;
		int num2 = 0;
		foreach (int id in taskIdList)
		{
			BattlePassTaskData taskData = this.GetTaskData(id);
			num += taskData.Exp;
			num2 += ((taskData.UpdateType == EBattlePassTaskUpdateState.Always) ? 0 : taskData.Exp);
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x0600F17F RID: 61823 RVA: 0x0046ECDC File Offset: 0x0046CEDC
	public void TryRequestTaskList(List<int> taskIdList)
	{
		ValueTuple<int, int> tasksExp = this.GetTasksExp(taskIdList);
		int item = tasksExp.Item1;
		int item2 = tasksExp.Item2;
		int num = item - Math.Max(0, item2 - this.WeekExpLimitValue);
		if (this.IsLevelMax() || num > this.AllExpLimitValue)
		{
			GenericPromptController.Instance.ShowPromptByCode("BattlePassExpMax", Array.Empty<object>());
			BattlePassController.Instance.RequestBattlePassTaskTake(taskIdList);
			return;
		}
		if (item2 > this.WeekExpLimitValue)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.IsWeekMax() ? EConfirmBoxConfigId.TakeExpSureTip : EConfirmBoxConfigId.TakeExpOverSureTip);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				GenericPromptController.Instance.ShowPromptByCode("BattlePassWeeklyExpMax", Array.Empty<object>());
				BattlePassController.Instance.RequestBattlePassTaskTake(taskIdList);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		BattlePassController.Instance.RequestBattlePassTaskTake(taskIdList);
	}

	// Token: 0x0600F180 RID: 61824 RVA: 0x0046EDB0 File Offset: 0x0046CFB0
	public void UpdateBattlePassRewardDataFromResponse([Nullable(new byte[]
	{
		2,
		1
	})] IList<PbBattlePassReward> responseDataList)
	{
		if (responseDataList == null || responseDataList.Count == 0)
		{
			return;
		}
		foreach (PbBattlePassReward pbBattlePassReward in responseDataList)
		{
			this.TakeReward(pbBattlePassReward.Type, pbBattlePassReward.Level, pbBattlePassReward.ItemId);
		}
	}

	// Token: 0x0600F181 RID: 61825 RVA: 0x0046EE18 File Offset: 0x0046D018
	public void UpdateRewardDataWithTargetLevel(int targetLevel)
	{
		for (int i = 1; i <= targetLevel; i++)
		{
			this.SetRewardCanGet(i, false);
		}
	}

	// Token: 0x0600F182 RID: 61826 RVA: 0x0046EE3C File Offset: 0x0046D03C
	private void SetRewardCanGet(int level, bool force = false)
	{
		if (level - 1 >= 0 && level - 1 < this.RewardDataList.Count)
		{
			BattlePassRewardData battlePassRewardData = this.RewardDataList[level - 1];
			if (battlePassRewardData != null)
			{
				foreach (BattlePassRewardItem battlePassRewardItem in battlePassRewardData.FreeRewardItem)
				{
					EBattlePassItemType? itemType = battlePassRewardItem.ItemType;
					EBattlePassItemType ebattlePassItemType = EBattlePassItemType.Locked;
					if ((itemType.GetValueOrDefault() == ebattlePassItemType & itemType != null) || force)
					{
						battlePassRewardItem.ItemType = new EBattlePassItemType?(EBattlePassItemType.CanGet);
					}
				}
				if (this.PayType != BattlePassPayStatus.NoPaid)
				{
					foreach (BattlePassRewardItem battlePassRewardItem2 in battlePassRewardData.PayRewardItem)
					{
						EBattlePassItemType? itemType = battlePassRewardItem2.ItemType;
						EBattlePassItemType ebattlePassItemType = EBattlePassItemType.Locked;
						if ((itemType.GetValueOrDefault() == ebattlePassItemType & itemType != null) || force)
						{
							battlePassRewardItem2.ItemType = new EBattlePassItemType?(EBattlePassItemType.CanGet);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600F183 RID: 61827 RVA: 0x0046EF5C File Offset: 0x0046D15C
	public unsafe void TakeReward(BattlePassType battlePassType, int level, int itemId)
	{
		BattlePassRewardData rewardData = this.GetRewardData(level);
		BattlePassRewardItem battlePassRewardItem;
		if (battlePassType == Aki.Protocol.BattlePassType.Free)
		{
			battlePassRewardItem = rewardData.GetFreeRewardItem(itemId);
		}
		else
		{
			battlePassRewardItem = rewardData.GetPayRewardItem(itemId);
		}
		if (battlePassRewardItem != null)
		{
			battlePassRewardItem.ItemType = new EBattlePassItemType?(EBattlePassItemType.HasGet);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "【TakeReward】战令奖励数据 没有这个奖励的配置";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("battlePassType", battlePassType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("itemId from server", itemId);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0600F184 RID: 61828 RVA: 0x0046F011 File Offset: 0x0046D211
	public void OnResponseTakeReward(BattlePassType battlePassType, int level, int itemId, int gridIndex)
	{
		this.TakeReward(battlePassType, level, itemId);
		EventSystem.Instance.Emit<int?>(EEventName.GetBattlePassRewardEvent, new int?(gridIndex));
	}

	// Token: 0x170016F8 RID: 5880
	// (get) Token: 0x0600F185 RID: 61829 RVA: 0x0046F033 File Offset: 0x0046D233
	// (set) Token: 0x0600F186 RID: 61830 RVA: 0x0046F03B File Offset: 0x0046D23B
	public int BattlePassLevel
	{
		get
		{
			return this.CurrentBattlePassLevel;
		}
		set
		{
			this.CurrentBattlePassLevel = value;
		}
	}

	// Token: 0x170016F9 RID: 5881
	// (get) Token: 0x0600F187 RID: 61831 RVA: 0x0046F044 File Offset: 0x0046D244
	// (set) Token: 0x0600F188 RID: 61832 RVA: 0x0046F04C File Offset: 0x0046D24C
	public int WeekExp
	{
		get
		{
			return this.CurrentWeekExp;
		}
		set
		{
			this.CurrentWeekExp = value;
		}
	}

	// Token: 0x170016FA RID: 5882
	// (get) Token: 0x0600F189 RID: 61833 RVA: 0x0046F055 File Offset: 0x0046D255
	// (set) Token: 0x0600F18A RID: 61834 RVA: 0x0046F05D File Offset: 0x0046D25D
	public int LevelExp
	{
		get
		{
			return this.CurrentLevelExp;
		}
		set
		{
			this.CurrentLevelExp = value;
		}
	}

	// Token: 0x170016FB RID: 5883
	// (get) Token: 0x0600F18B RID: 61835 RVA: 0x0046F066 File Offset: 0x0046D266
	// (set) Token: 0x0600F18C RID: 61836 RVA: 0x0046F06E File Offset: 0x0046D26E
	public BattlePassPayStatus PayType
	{
		get
		{
			return this.BattlePassType;
		}
		set
		{
			this.BattlePassType = value;
		}
	}

	// Token: 0x0600F18D RID: 61837 RVA: 0x0046F077 File Offset: 0x0046D277
	public long GetBattlePassStartTime()
	{
		return this.BattlePassStartTime;
	}

	// Token: 0x0600F18E RID: 61838 RVA: 0x0046F07F File Offset: 0x0046D27F
	public long GetBattlePassEndTime()
	{
		return this.BattlePassEndTime;
	}

	// Token: 0x0600F18F RID: 61839 RVA: 0x0046F087 File Offset: 0x0046D287
	public bool InBattlePassInWarningTime()
	{
		return TimeUtil.Instance.GetServerTime() > (double)this.WarningTime;
	}

	// Token: 0x0600F190 RID: 61840 RVA: 0x0046F09C File Offset: 0x0046D29C
	private void SetBattlePassStartTime(long value)
	{
		this.BattlePassStartTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x0600F191 RID: 61841 RVA: 0x0046F0B0 File Offset: 0x0046D2B0
	private void SetBattlePassEndTime(long value)
	{
		this.BattlePassEndTime = MathUtils.Instance.LongToBigInt(value);
		this.WarningTime = this.BattlePassEndTime - (long)(ConfigCommonParamById.GetIntConfig("BattlePassSettleBugTime").Value * 3600);
	}

	// Token: 0x0600F192 RID: 61842 RVA: 0x0046F0F4 File Offset: 0x0046D2F4
	public void SetDayEndTime(long value)
	{
		this.DayEndTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x0600F193 RID: 61843 RVA: 0x0046F107 File Offset: 0x0046D307
	public void SetWeekEndTime(long value)
	{
		this.WeekEndTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x0600F194 RID: 61844 RVA: 0x0046F11A File Offset: 0x0046D31A
	public int GetMaxWeekExp()
	{
		return this.MaxWeekExp;
	}

	// Token: 0x0600F195 RID: 61845 RVA: 0x0046F122 File Offset: 0x0046D322
	public int GetMaxLevelExp()
	{
		return this.MaxLevelExp;
	}

	// Token: 0x0600F196 RID: 61846 RVA: 0x0046F12C File Offset: 0x0046D32C
	public string GetPassPayBtnKey()
	{
		switch (this.BattlePassType)
		{
		case BattlePassPayStatus.NoPaid:
			return "Text_BattlePassBuyButton1_Text";
		case BattlePassPayStatus.Paid:
			return "Text_BattlePassBuyButton2_Text";
		case BattlePassPayStatus.Advanced:
			return "Text_BattlePassBuyButton3_Text";
		default:
			return "";
		}
	}

	// Token: 0x0600F197 RID: 61847 RVA: 0x0046F16B File Offset: 0x0046D36B
	protected override bool OnInit()
	{
		this.GiftId = 301;
		this.RewardDataList = new List<BattlePassRewardData>();
		this.StageLevelList = new List<int>();
		this.BattlePassTaskMap = new Dictionary<int, BattlePassTaskData>();
		this.HadEnterInternal = true;
		this.BattlePassType = BattlePassPayStatus.NoPaid;
		return true;
	}

	// Token: 0x0600F198 RID: 61848 RVA: 0x0046F1A8 File Offset: 0x0046D3A8
	public int GetBattlePassRemainTime()
	{
		return (int)TimeUtil.Instance.CalculateHourGapBetweenNow((double)this.BattlePassEndTime, true);
	}

	// Token: 0x0600F199 RID: 61849 RVA: 0x0046F1C0 File Offset: 0x0046D3C0
	public double GetBattlePassRemainTimeSecond()
	{
		double num = TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond;
		return (double)this.BattlePassEndTime - num;
	}

	// Token: 0x0600F19A RID: 61850 RVA: 0x0046F1F0 File Offset: 0x0046D3F0
	public void GetTargetLevelRewardList(int targetLevel, List<TItem> rewardList)
	{
		rewardList.Clear();
		int currentBattlePassLevel = this.CurrentBattlePassLevel;
		Dictionary<int, TItem> dictionary = new Dictionary<int, TItem>();
		for (int i = currentBattlePassLevel + 1; i <= targetLevel; i++)
		{
			BattlePassRewardData rewardData = this.GetRewardData(i);
			if (rewardData != null)
			{
				List<BattlePassRewardItem> list = new List<BattlePassRewardItem>();
				if (this.BattlePassType == BattlePassPayStatus.NoPaid)
				{
					list.AddRange(rewardData.FreeRewardItem);
				}
				else
				{
					list.AddRange(rewardData.FreeRewardItem);
					list.AddRange(rewardData.PayRewardItem);
				}
				foreach (BattlePassRewardItem battlePassRewardItem in list)
				{
					int itemId = battlePassRewardItem.Item.Value.ItemData.ItemId;
					int count = battlePassRewardItem.Item.Value.Count;
					TItem titem;
					if (dictionary.TryGetValue(itemId, out titem))
					{
						dictionary[itemId] = new TItem(titem.ItemData, titem.Count + count);
					}
					else
					{
						dictionary.Add(itemId, new TItem(new InventoryDefine.GetItemData(itemId, 0), count));
					}
				}
			}
		}
		foreach (KeyValuePair<int, TItem> keyValuePair in dictionary)
		{
			rewardList.Add(keyValuePair.Value);
		}
		rewardList.Sort(new Comparison<TItem>(BattlePassModel.<GetTargetLevelRewardList>g__compare|80_0));
	}

	// Token: 0x0600F19B RID: 61851 RVA: 0x0046F360 File Offset: 0x0046D560
	[NullableContext(2)]
	public BattlePassTaskData GetTaskData(int id)
	{
		BattlePassTaskData result;
		if (this.BattlePassTaskMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600F19C RID: 61852 RVA: 0x0046F380 File Offset: 0x0046D580
	public void GetTaskList(EBattlePassTaskUpdateState updateState, List<BattlePassTaskData> outArray)
	{
		outArray.Clear();
		foreach (KeyValuePair<int, BattlePassTaskData> keyValuePair in this.BattlePassTaskMap)
		{
			if (keyValuePair.Value.UpdateType == updateState)
			{
				outArray.Add(keyValuePair.Value);
			}
		}
		outArray.Sort(new Comparison<BattlePassTaskData>(BattlePassModel.<GetTaskList>g__compare|83_0));
	}

	// Token: 0x0600F19D RID: 61853 RVA: 0x0046F400 File Offset: 0x0046D600
	public EBattlePassTaskUpdateState[] GetTaskTypeList()
	{
		EBattlePassTaskUpdateState[] array = new EBattlePassTaskUpdateState[3];
		array[0] = EBattlePassTaskUpdateState.EveryDay;
		array[1] = EBattlePassTaskUpdateState.EveryWeek;
		return array;
	}

	// Token: 0x0600F19E RID: 61854 RVA: 0x0046F410 File Offset: 0x0046D610
	public int GetPrimaryBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("PrimaryBattlePassShopId").Value;
	}

	// Token: 0x0600F19F RID: 61855 RVA: 0x0046F430 File Offset: 0x0046D630
	public int GetHighBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("AdvancedWithActive").Value;
	}

	// Token: 0x0600F1A0 RID: 61856 RVA: 0x0046F450 File Offset: 0x0046D650
	public int GetSupplyBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("AdvancedWithoutActive").Value;
	}

	// Token: 0x0600F1A1 RID: 61857 RVA: 0x0046F470 File Offset: 0x0046D670
	public List<int> GetAllFinishedTask()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, BattlePassTaskData> keyValuePair in this.BattlePassTaskMap)
		{
			if (keyValuePair.Value.TaskState == EBattlePassTaskState.WaitTakeReward)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0600F1A2 RID: 61858 RVA: 0x0046F4E0 File Offset: 0x0046D6E0
	public bool CheckHasRewardWaitTake()
	{
		if (!this.GetInTimeRange())
		{
			return false;
		}
		foreach (BattlePassRewardData battlePassRewardData in this.RewardDataList)
		{
			using (List<BattlePassRewardItem>.Enumerator enumerator2 = battlePassRewardData.FreeRewardItem.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.ItemType.GetValueOrDefault() == EBattlePassItemType.CanGet)
					{
						return true;
					}
				}
			}
			using (List<BattlePassRewardItem>.Enumerator enumerator2 = battlePassRewardData.PayRewardItem.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.ItemType.GetValueOrDefault() == EBattlePassItemType.CanGet)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600F1A3 RID: 61859 RVA: 0x0046F5D8 File Offset: 0x0046D7D8
	public bool CheckHasTaskWaitTake()
	{
		if (this.MaxLevel == this.BattlePassLevel)
		{
			return false;
		}
		foreach (KeyValuePair<int, BattlePassTaskData> keyValuePair in this.BattlePassTaskMap)
		{
			if (keyValuePair.Value.TaskState == EBattlePassTaskState.WaitTakeReward)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F1A4 RID: 61860 RVA: 0x0046F64C File Offset: 0x0046D84C
	public bool CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState type)
	{
		if (!this.GetInTimeRange())
		{
			return false;
		}
		if (this.CurrentBattlePassLevel == this.MaxLevel)
		{
			return false;
		}
		foreach (KeyValuePair<int, BattlePassTaskData> keyValuePair in this.BattlePassTaskMap)
		{
			if (type == keyValuePair.Value.UpdateType && keyValuePair.Value.TaskState == EBattlePassTaskState.WaitTakeReward)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F1A5 RID: 61861 RVA: 0x0046F6D8 File Offset: 0x0046D8D8
	public void AddTaskDataFromProtocol(PbBattlePassTask task)
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("BattlePassExp");
		Dictionary<int, BattlePassTaskData> battlePassTaskMap = this.BattlePassTaskMap;
		BattlePassTaskData battlePassTaskData = new BattlePassTaskData();
		battlePassTaskData.TaskId = task.Id;
		BattlePassTask? battlePassTask = BattlePassConfig.Instance.GetBattlePassTask(task.Id);
		foreach (KeyValuePair<int, int> keyValuePair in battlePassTask.Value.TaskReward())
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			int key = keyValuePair.Key;
			int? num = intConfig;
			if (key == num.GetValueOrDefault() & num != null)
			{
				battlePassTaskData.Exp += keyValuePair.Value;
			}
			battlePassTaskData.RewardItemList.Add(item);
		}
		battlePassTaskData.CurrentProgress = task.Current;
		battlePassTaskData.TargetProgress = task.Target;
		battlePassTaskData.UpdateType = (EBattlePassTaskUpdateState)battlePassTask.Value.UpdateType;
		battlePassTaskData.SkipId = ((battlePassTask.Value.JumpId == 0) ? null : new int?(battlePassTask.Value.JumpId));
		if (!task.IsFinished)
		{
			battlePassTaskData.TaskState = EBattlePassTaskState.Running;
		}
		else if (task.IsTaken)
		{
			battlePassTaskData.TaskState = EBattlePassTaskState.FinishedAndHasTaken;
		}
		else
		{
			battlePassTaskData.TaskState = EBattlePassTaskState.WaitTakeReward;
		}
		battlePassTaskMap[task.Id] = battlePassTaskData;
	}

	// Token: 0x0600F1A6 RID: 61862 RVA: 0x0046F85C File Offset: 0x0046DA5C
	public void SetDataFromBattlePassResponse(BattlePassResponse response)
	{
		PbBattlePass battlePass = response.BattlePass;
		this.InTimeRange = battlePass.InTimeRange;
		if (!this.InTimeRange)
		{
			this.PayButtonRedDotState = false;
			return;
		}
		this.HadEnter = battlePass.HadEnter;
		this.BattlePassId = battlePass.Id;
		this.PayType = battlePass.PayStatus;
		this.BattlePassLevel = battlePass.Level;
		this.LevelExp = battlePass.Exp;
		this.WeekExp = battlePass.WeeklyTotalExp;
		this.SetBattlePassEndTime(battlePass.EndTime);
		this.SetBattlePassStartTime(battlePass.BeginTime);
		this.InitBattlePassConfigData();
		this.UpdateBattlePassRewardDataFromResponse(response.BattlePass.TakenRewards ?? null);
		if (!battlePass.HadEnter && battlePass.InTimeRange)
		{
			this.PayButtonRedDotState = true;
		}
		EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
	}

	// Token: 0x0600F1A7 RID: 61863 RVA: 0x0046F930 File Offset: 0x0046DB30
	public void UpdateTaskDataFromBattlePassTaskTakeResponse(IReadOnlyList<int> ids)
	{
		Dictionary<int, BattlePassTaskData> battlePassTaskMap = this.BattlePassTaskMap;
		foreach (int key in ids)
		{
			BattlePassTaskData battlePassTaskData;
			if (battlePassTaskMap.TryGetValue(key, out battlePassTaskData))
			{
				battlePassTaskData.TaskState = EBattlePassTaskState.FinishedAndHasTaken;
			}
		}
		EventSystem.Instance.Emit(EEventName.UpdateBattlePassTaskEvent);
	}

	// Token: 0x0600F1A8 RID: 61864 RVA: 0x0046F99C File Offset: 0x0046DB9C
	public void UpdateExpDataFromBattlePassExpUpdateNotify(int level, int exp, int weekExp)
	{
		this.UpdateRewardDataWithTargetLevel(level);
		bool flag = level > this.BattlePassLevel;
		if (flag)
		{
			this.IncreasedLevelToShow += level - this.BattlePassLevel;
		}
		this.BattlePassLevel = level;
		if (flag)
		{
			EventSystem.Instance.Emit(EEventName.OnBattlePassLevelUpEvent);
		}
		this.LevelExp = exp;
		this.WeekExp = weekExp;
		this.UpdateLimitValue();
		EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
	}

	// Token: 0x0600F1A9 RID: 61865 RVA: 0x0046FA10 File Offset: 0x0046DC10
	public void UpdateRewardDataFromBattlePassTakeAllRewardResponse(BattlePassTakeAllRewardResponse response)
	{
		foreach (PbBattlePassReward pbBattlePassReward in response.TakenRewards)
		{
			this.TakeReward(pbBattlePassReward.Type, pbBattlePassReward.Level, pbBattlePassReward.ItemId);
		}
		EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
	}

	// Token: 0x0600F1AA RID: 61866 RVA: 0x0046FA80 File Offset: 0x0046DC80
	public void UpdateRewardDataFormFreeToPay()
	{
		for (int i = 1; i <= this.CurrentBattlePassLevel; i++)
		{
			BattlePassRewardData rewardData = this.GetRewardData(i);
			if (rewardData != null)
			{
				foreach (BattlePassRewardItem battlePassRewardItem in rewardData.PayRewardItem)
				{
					battlePassRewardItem.ItemType = new EBattlePassItemType?(EBattlePassItemType.CanGet);
				}
			}
		}
	}

	// Token: 0x0600F1AB RID: 61867 RVA: 0x0046FAF4 File Offset: 0x0046DCF4
	[NullableContext(2)]
	public string GetBattlePassIconPath()
	{
		BattlePass? battlePassData = BattlePassConfig.Instance.GetBattlePassData(this.BattlePassId);
		if (battlePassData != null)
		{
			return battlePassData.Value.ExclusiveRewardPath;
		}
		return null;
	}

	// Token: 0x0600F1AC RID: 61868 RVA: 0x0046FB2C File Offset: 0x0046DD2C
	public int GetCurrentShowLevel()
	{
		int num = 0;
		foreach (BattlePassRewardData battlePassRewardData in this.RewardDataList)
		{
			if (battlePassRewardData.IsThisType(EBattlePassItemType.CanGet))
			{
				num = battlePassRewardData.Level.Value;
				break;
			}
		}
		if (num == 0)
		{
			foreach (BattlePassRewardData battlePassRewardData2 in this.RewardDataList)
			{
				if (battlePassRewardData2.IsThisType(EBattlePassItemType.HasGet))
				{
					num = battlePassRewardData2.Level.Value;
				}
			}
		}
		if (num == 0)
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x0600F1AD RID: 61869 RVA: 0x0046FBEC File Offset: 0x0046DDEC
	public string GetHighBattlePassOriginalPrice()
	{
		int primaryBattlePassGoodsId = this.GetPrimaryBattlePassGoodsId();
		int? intConfig = ConfigCommonParamById.GetIntConfig("AdvancedWithoutActive");
		int payId = PayShopConfig.Instance.GetPayShopDirectGoods(primaryBattlePassGoodsId).PayId;
		float amount = PayItemConfig.Instance.GetPayConf(payId).Value.Amount;
		int payId2 = PayShopConfig.Instance.GetPayShopDirectGoods(intConfig.Value).PayId;
		float amount2 = PayItemConfig.Instance.GetPayConf(payId2).Value.Amount;
		StringBuilder stringBuilder = new StringBuilder();
		string payShow = PayItemConfig.Instance.GetPayShow(payId2);
		stringBuilder.Append(PayItemConfig.Instance.GetPayShowCurrency());
		stringBuilder.Append(amount + amount2);
		return payShow;
	}

	// Token: 0x0600F1AE RID: 61870 RVA: 0x0046FCAC File Offset: 0x0046DEAC
	public EConfirmBoxConfigId GetBattlePassItemConfirmId(int itemId)
	{
		if (!FunctionModel.Instance.IsOpen(10040))
		{
			return EConfirmBoxConfigId.BattlePassLock;
		}
		if (!this.GetInTimeRange())
		{
			return EConfirmBoxConfigId.BattlePassOutTime;
		}
		if (itemId == this.PrimaryItemId)
		{
			if (BattlePassModel.Instance.PayType != BattlePassPayStatus.NoPaid)
			{
				return EConfirmBoxConfigId.BattlePassPrimaryRepeat;
			}
			if (BattlePassModel.Instance.InBattlePassInWarningTime())
			{
				return EConfirmBoxConfigId.BattlePassPrimaryTimeWarning;
			}
			return EConfirmBoxConfigId.BattlePassUsePrimary;
		}
		else
		{
			if (BattlePassModel.Instance.PayType == BattlePassPayStatus.Advanced)
			{
				return EConfirmBoxConfigId.BattlePassAdvanceRepeat;
			}
			if (BattlePassModel.Instance.PayType == BattlePassPayStatus.Paid)
			{
				return EConfirmBoxConfigId.BattlePassUseUpgrade;
			}
			if (BattlePassModel.Instance.InBattlePassInWarningTime())
			{
				return EConfirmBoxConfigId.BattlePassAdvanceTimeWarning;
			}
			return EConfirmBoxConfigId.BattlePassUseAdvance;
		}
	}

	// Token: 0x170016FC RID: 5884
	// (get) Token: 0x0600F1AF RID: 61871 RVA: 0x0046FD4E File Offset: 0x0046DF4E
	public int? RemindLevel
	{
		get
		{
			return this.RemindLevelInternal;
		}
	}

	// Token: 0x0600F1B0 RID: 61872 RVA: 0x0046FD58 File Offset: 0x0046DF58
	public void TryAssignRemindLevel(int? level = null)
	{
		if (this.PayType > BattlePassPayStatus.NoPaid)
		{
			this.RemindLevelInternal = null;
			return;
		}
		BattlePass? battlePass;
		int battlePassId = (BattlePassConfig.Instance.GetBattlePassData(this.BattlePassId) != null) ? battlePass.GetValueOrDefault().BattlePassRewardId : 0;
		if (level == null)
		{
			using (IEnumerator<BattlePassReward> enumerator = BattlePassConfig.Instance.GetAllRewardData(battlePassId).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BattlePassReward battlePassReward = enumerator.Current;
					if (battlePassReward.IsRemind && this.GetRewardData(battlePassReward.Level).IsThisType(EBattlePassItemType.CanGet))
					{
						this.RemindLevelInternal = new int?(this.BattlePassLevel);
						return;
					}
				}
				goto IL_142;
			}
		}
		BattlePassRewardData rewardData = this.GetRewardData(level.Value);
		if (rewardData != null && rewardData.IsThisType(EBattlePassItemType.CanGet))
		{
			foreach (BattlePassReward battlePassReward2 in BattlePassConfig.Instance.GetAllRewardData(battlePassId))
			{
				int level2 = battlePassReward2.Level;
				int? num = level;
				if (level2 == num.GetValueOrDefault() & num != null)
				{
					this.RemindLevelInternal = (battlePassReward2.IsRemind ? new int?(this.BattlePassLevel) : null);
					return;
				}
			}
		}
		IL_142:
		this.RemindLevelInternal = null;
	}

	// Token: 0x0600F1B1 RID: 61873 RVA: 0x0046FED0 File Offset: 0x0046E0D0
	public RewardItemData[] GetExtraRewardItems()
	{
		if (this.RemindLevelInternal == null)
		{
			return new RewardItemData[0];
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		List<RewardItemData> list = new List<RewardItemData>();
		BattlePass? battlePass;
		int battlePassId = (BattlePassConfig.Instance.GetBattlePassData(this.BattlePassId) != null) ? battlePass.GetValueOrDefault().BattlePassRewardId : 0;
		foreach (BattlePassReward battlePassReward in BattlePassConfig.Instance.GetAllRewardData(battlePassId))
		{
			int level = battlePassReward.Level;
			int? remindLevelInternal = this.RemindLevelInternal;
			if (level <= remindLevelInternal.GetValueOrDefault() & remindLevelInternal != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in battlePassReward.PayReward())
				{
					int num;
					if (dictionary.TryGetValue(keyValuePair.Key, out num))
					{
						dictionary[keyValuePair.Key] = num + keyValuePair.Value;
					}
					else
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
		{
			list.Add(new RewardItemData(keyValuePair2.Key, keyValuePair2.Value, null, EDropItemType.Normal));
		}
		list.Sort(delegate(RewardItemData a, RewardItemData b)
		{
			int qualityId = InventoryConfig.Instance.GetItemConfig(a.ConfigId).Value.QualityId;
			int qualityId2 = InventoryConfig.Instance.GetItemConfig(b.ConfigId).Value.QualityId;
			if (qualityId == qualityId2)
			{
				return a.Count - b.Count;
			}
			return qualityId2 - qualityId;
		});
		return list.ToArray();
	}

	// Token: 0x170016FD RID: 5885
	// (get) Token: 0x0600F1B2 RID: 61874 RVA: 0x004700A0 File Offset: 0x0046E2A0
	public static BattlePassModel Instance
	{
		get
		{
			return BattlePassModel._Instance;
		}
	}

	// Token: 0x0600F1B3 RID: 61875 RVA: 0x004700A7 File Offset: 0x0046E2A7
	public static BattlePassModel GetOrCreateInstance()
	{
		if (BattlePassModel._Instance == null)
		{
			BattlePassModel.CreateInstance();
		}
		return BattlePassModel._Instance;
	}

	// Token: 0x0600F1B4 RID: 61876 RVA: 0x004700BB File Offset: 0x0046E2BB
	public static bool CreateInstance()
	{
		if (BattlePassModel._Instance != null)
		{
			return true;
		}
		BattlePassModel._Instance = new BattlePassModel();
		return true;
	}

	// Token: 0x0600F1B5 RID: 61877 RVA: 0x004700D1 File Offset: 0x0046E2D1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F1B6 RID: 61878 RVA: 0x004700D3 File Offset: 0x0046E2D3
	public static void ResetStaticDefaultValue()
	{
		BattlePassModel._Instance = null;
	}

	// Token: 0x0600F1B7 RID: 61879 RVA: 0x004700DB File Offset: 0x0046E2DB
	static BattlePassModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassModel.CreateStaticDefaultValue), new Action(BattlePassModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600F1B9 RID: 61881 RVA: 0x00470104 File Offset: 0x0046E304
	[CompilerGenerated]
	internal static int <GetTargetLevelRewardList>g__compare|80_0(TItem a, TItem b)
	{
		int qualityId = InventoryConfig.Instance.GetItemConfig(a.ItemData.ItemId).Value.QualityId;
		int qualityId2 = InventoryConfig.Instance.GetItemConfig(b.ItemData.ItemId).Value.QualityId;
		if (qualityId == qualityId2)
		{
			return a.Count - b.Count;
		}
		return qualityId2 - qualityId;
	}

	// Token: 0x0600F1BA RID: 61882 RVA: 0x00470172 File Offset: 0x0046E372
	[CompilerGenerated]
	internal static int <GetTaskList>g__compare|83_0(BattlePassTaskData a, BattlePassTaskData b)
	{
		if (a.TaskState == EBattlePassTaskState.WaitTakeReward || b.TaskState == EBattlePassTaskState.FinishedAndHasTaken)
		{
			return -1;
		}
		if (a.TaskState == EBattlePassTaskState.FinishedAndHasTaken || b.TaskState == EBattlePassTaskState.WaitTakeReward)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0400882C RID: 34860
	private const int GIFT_ID = 301;

	// Token: 0x0400882D RID: 34861
	public bool IsRequiringViewData;

	// Token: 0x0400882E RID: 34862
	private bool InTimeRange;

	// Token: 0x0400882F RID: 34863
	public int IncreasedLevelToShow;

	// Token: 0x04008830 RID: 34864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<WeaponDataBase> WeaponDataList;

	// Token: 0x04008831 RID: 34865
	private long WarningTime;

	// Token: 0x04008832 RID: 34866
	private bool HadEnterInternal;

	// Token: 0x04008833 RID: 34867
	private bool? PayButtonRedDotStateInternal;

	// Token: 0x04008834 RID: 34868
	private int WeekExpLimitValue;

	// Token: 0x04008835 RID: 34869
	private int AllExpLimitValue;

	// Token: 0x04008836 RID: 34870
	private int GiftId;

	// Token: 0x04008837 RID: 34871
	private long DayEndTime;

	// Token: 0x04008838 RID: 34872
	private long WeekEndTime;

	// Token: 0x04008839 RID: 34873
	public List<BattlePassRewardData> RewardDataList;

	// Token: 0x0400883A RID: 34874
	public int BattlePassId;

	// Token: 0x0400883B RID: 34875
	private int MaxLevel;

	// Token: 0x0400883C RID: 34876
	public List<int> StageLevelList;

	// Token: 0x0400883D RID: 34877
	private int CurrentBattlePassLevel;

	// Token: 0x0400883E RID: 34878
	private int CurrentWeekExp;

	// Token: 0x0400883F RID: 34879
	private int CurrentLevelExp;

	// Token: 0x04008840 RID: 34880
	private BattlePassPayStatus BattlePassType;

	// Token: 0x04008841 RID: 34881
	private long BattlePassStartTime;

	// Token: 0x04008842 RID: 34882
	private long BattlePassEndTime;

	// Token: 0x04008843 RID: 34883
	private int MaxWeekExp;

	// Token: 0x04008844 RID: 34884
	private int MaxLevelExp;

	// Token: 0x04008845 RID: 34885
	public Dictionary<int, BattlePassTaskData> BattlePassTaskMap;

	// Token: 0x04008846 RID: 34886
	private int? RemindLevelInternal;

	// Token: 0x04008847 RID: 34887
	[Nullable(2)]
	private static BattlePassModel _Instance;
}

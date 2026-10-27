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

// Token: 0x02002326 RID: 8998
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattlePassModel : ModelBase
{
	// Token: 0x06011CBB RID: 72891 RVA: 0x004616B3 File Offset: 0x0045F8B3
	public bool GetInTimeRange()
	{
		return this.InTimeRange;
	}

	// Token: 0x06011CBC RID: 72892 RVA: 0x004616BB File Offset: 0x0045F8BB
	public void SetInTimeRange(bool value)
	{
		this.InTimeRange = value;
	}

	// Token: 0x06011CBD RID: 72893 RVA: 0x004616C4 File Offset: 0x0045F8C4
	public long GetDayEndTime()
	{
		return this.DayEndTime;
	}

	// Token: 0x06011CBE RID: 72894 RVA: 0x004616CC File Offset: 0x0045F8CC
	public long GetWeekEndTime()
	{
		return this.WeekEndTime;
	}

	// Token: 0x06011CBF RID: 72895 RVA: 0x004616D4 File Offset: 0x0045F8D4
	public int GetGiftId()
	{
		return this.GiftId;
	}

	// Token: 0x170016BA RID: 5818
	// (get) Token: 0x06011CC0 RID: 72896 RVA: 0x004616DC File Offset: 0x0045F8DC
	public int PrimaryItemId
	{
		get
		{
			return ConfigCommonParamById.GetIntArrayConfig("PrimaryGiftItem")[0];
		}
	}

	// Token: 0x170016BB RID: 5819
	// (get) Token: 0x06011CC1 RID: 72897 RVA: 0x004616EE File Offset: 0x0045F8EE
	public int AdvanceItemId
	{
		get
		{
			return ConfigCommonParamById.GetIntArrayConfig("AdvancedGiftItem")[0];
		}
	}

	// Token: 0x170016BC RID: 5820
	// (get) Token: 0x06011CC2 RID: 72898 RVA: 0x00461700 File Offset: 0x0045F900
	// (set) Token: 0x06011CC3 RID: 72899 RVA: 0x00461708 File Offset: 0x0045F908
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

	// Token: 0x06011CC4 RID: 72900 RVA: 0x0046172C File Offset: 0x0045F92C
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

	// Token: 0x06011CC5 RID: 72901 RVA: 0x004617AC File Offset: 0x0045F9AC
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

	// Token: 0x170016BD RID: 5821
	// (get) Token: 0x06011CC6 RID: 72902 RVA: 0x0046183C File Offset: 0x0045FA3C
	// (set) Token: 0x06011CC7 RID: 72903 RVA: 0x0046186C File Offset: 0x0045FA6C
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

	// Token: 0x06011CC8 RID: 72904 RVA: 0x004618C0 File Offset: 0x0045FAC0
	public int GetMaxLevel()
	{
		return this.MaxLevel;
	}

	// Token: 0x06011CC9 RID: 72905 RVA: 0x004618C8 File Offset: 0x0045FAC8
	public bool IsLevelMax()
	{
		return this.CurrentBattlePassLevel >= this.MaxLevel;
	}

	// Token: 0x06011CCA RID: 72906 RVA: 0x004618DB File Offset: 0x0045FADB
	public bool IsWeekMax()
	{
		return this.WeekExp >= this.MaxWeekExp;
	}

	// Token: 0x06011CCB RID: 72907 RVA: 0x004618F0 File Offset: 0x0045FAF0
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

	// Token: 0x06011CCC RID: 72908 RVA: 0x0046194C File Offset: 0x0045FB4C
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

	// Token: 0x06011CCD RID: 72909 RVA: 0x00461B84 File Offset: 0x0045FD84
	private void UpdateLimitValue()
	{
		this.AllExpLimitValue = this.MaxLevelExp * (this.MaxLevel - this.CurrentBattlePassLevel) - this.LevelExp;
		this.WeekExpLimitValue = this.MaxWeekExp - this.WeekExp;
	}

	// Token: 0x06011CCE RID: 72910 RVA: 0x00461BBC File Offset: 0x0045FDBC
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

	// Token: 0x06011CCF RID: 72911 RVA: 0x00461C38 File Offset: 0x0045FE38
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

	// Token: 0x06011CD0 RID: 72912 RVA: 0x00461D0C File Offset: 0x0045FF0C
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

	// Token: 0x06011CD1 RID: 72913 RVA: 0x00461D74 File Offset: 0x0045FF74
	public void UpdateRewardDataWithTargetLevel(int targetLevel)
	{
		for (int i = 1; i <= targetLevel; i++)
		{
			this.SetRewardCanGet(i, false);
		}
	}

	// Token: 0x06011CD2 RID: 72914 RVA: 0x00461D98 File Offset: 0x0045FF98
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

	// Token: 0x06011CD3 RID: 72915 RVA: 0x00461EB8 File Offset: 0x004600B8
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

	// Token: 0x06011CD4 RID: 72916 RVA: 0x00461F6D File Offset: 0x0046016D
	public void OnResponseTakeReward(BattlePassType battlePassType, int level, int itemId, int gridIndex)
	{
		this.TakeReward(battlePassType, level, itemId);
		EventSystem.Instance.Emit<int?>(EEventName.GetBattlePassRewardEvent, new int?(gridIndex));
	}

	// Token: 0x170016BE RID: 5822
	// (get) Token: 0x06011CD5 RID: 72917 RVA: 0x00461F8F File Offset: 0x0046018F
	// (set) Token: 0x06011CD6 RID: 72918 RVA: 0x00461F97 File Offset: 0x00460197
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

	// Token: 0x170016BF RID: 5823
	// (get) Token: 0x06011CD7 RID: 72919 RVA: 0x00461FA0 File Offset: 0x004601A0
	// (set) Token: 0x06011CD8 RID: 72920 RVA: 0x00461FA8 File Offset: 0x004601A8
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

	// Token: 0x170016C0 RID: 5824
	// (get) Token: 0x06011CD9 RID: 72921 RVA: 0x00461FB1 File Offset: 0x004601B1
	// (set) Token: 0x06011CDA RID: 72922 RVA: 0x00461FB9 File Offset: 0x004601B9
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

	// Token: 0x170016C1 RID: 5825
	// (get) Token: 0x06011CDB RID: 72923 RVA: 0x00461FC2 File Offset: 0x004601C2
	// (set) Token: 0x06011CDC RID: 72924 RVA: 0x00461FCA File Offset: 0x004601CA
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

	// Token: 0x06011CDD RID: 72925 RVA: 0x00461FD3 File Offset: 0x004601D3
	public long GetBattlePassStartTime()
	{
		return this.BattlePassStartTime;
	}

	// Token: 0x06011CDE RID: 72926 RVA: 0x00461FDB File Offset: 0x004601DB
	public long GetBattlePassEndTime()
	{
		return this.BattlePassEndTime;
	}

	// Token: 0x06011CDF RID: 72927 RVA: 0x00461FE3 File Offset: 0x004601E3
	public bool InBattlePassInWarningTime()
	{
		return TimeUtil.Instance.GetServerTime() > (double)this.WarningTime;
	}

	// Token: 0x06011CE0 RID: 72928 RVA: 0x00461FF8 File Offset: 0x004601F8
	private void SetBattlePassStartTime(long value)
	{
		this.BattlePassStartTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x06011CE1 RID: 72929 RVA: 0x0046200C File Offset: 0x0046020C
	private void SetBattlePassEndTime(long value)
	{
		this.BattlePassEndTime = MathUtils.Instance.LongToBigInt(value);
		this.WarningTime = this.BattlePassEndTime - (long)(ConfigCommonParamById.GetIntConfig("BattlePassSettleBugTime").Value * 3600);
	}

	// Token: 0x06011CE2 RID: 72930 RVA: 0x00462050 File Offset: 0x00460250
	public void SetDayEndTime(long value)
	{
		this.DayEndTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x06011CE3 RID: 72931 RVA: 0x00462063 File Offset: 0x00460263
	public void SetWeekEndTime(long value)
	{
		this.WeekEndTime = MathUtils.Instance.LongToBigInt(value);
	}

	// Token: 0x06011CE4 RID: 72932 RVA: 0x00462076 File Offset: 0x00460276
	public int GetMaxWeekExp()
	{
		return this.MaxWeekExp;
	}

	// Token: 0x06011CE5 RID: 72933 RVA: 0x0046207E File Offset: 0x0046027E
	public int GetMaxLevelExp()
	{
		return this.MaxLevelExp;
	}

	// Token: 0x06011CE6 RID: 72934 RVA: 0x00462088 File Offset: 0x00460288
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

	// Token: 0x06011CE7 RID: 72935 RVA: 0x004620C7 File Offset: 0x004602C7
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

	// Token: 0x06011CE8 RID: 72936 RVA: 0x00462104 File Offset: 0x00460304
	public int GetBattlePassRemainTime()
	{
		return (int)TimeUtil.Instance.CalculateHourGapBetweenNow((double)this.BattlePassEndTime, true);
	}

	// Token: 0x06011CE9 RID: 72937 RVA: 0x0046211C File Offset: 0x0046031C
	public double GetBattlePassRemainTimeSecond()
	{
		double num = TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond;
		return (double)this.BattlePassEndTime - num;
	}

	// Token: 0x06011CEA RID: 72938 RVA: 0x0046214C File Offset: 0x0046034C
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

	// Token: 0x06011CEB RID: 72939 RVA: 0x004622BC File Offset: 0x004604BC
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

	// Token: 0x06011CEC RID: 72940 RVA: 0x004622DC File Offset: 0x004604DC
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

	// Token: 0x06011CED RID: 72941 RVA: 0x0046235C File Offset: 0x0046055C
	public EBattlePassTaskUpdateState[] GetTaskTypeList()
	{
		EBattlePassTaskUpdateState[] array = new EBattlePassTaskUpdateState[3];
		array[0] = EBattlePassTaskUpdateState.EveryDay;
		array[1] = EBattlePassTaskUpdateState.EveryWeek;
		return array;
	}

	// Token: 0x06011CEE RID: 72942 RVA: 0x0046236C File Offset: 0x0046056C
	public int GetPrimaryBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("PrimaryBattlePassShopId").Value;
	}

	// Token: 0x06011CEF RID: 72943 RVA: 0x0046238C File Offset: 0x0046058C
	public int GetHighBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("AdvancedWithActive").Value;
	}

	// Token: 0x06011CF0 RID: 72944 RVA: 0x004623AC File Offset: 0x004605AC
	public int GetSupplyBattlePassGoodsId()
	{
		return ConfigCommonParamById.GetIntConfig("AdvancedWithoutActive").Value;
	}

	// Token: 0x06011CF1 RID: 72945 RVA: 0x004623CC File Offset: 0x004605CC
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

	// Token: 0x06011CF2 RID: 72946 RVA: 0x0046243C File Offset: 0x0046063C
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

	// Token: 0x06011CF3 RID: 72947 RVA: 0x00462534 File Offset: 0x00460734
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

	// Token: 0x06011CF4 RID: 72948 RVA: 0x004625A8 File Offset: 0x004607A8
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

	// Token: 0x06011CF5 RID: 72949 RVA: 0x00462634 File Offset: 0x00460834
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

	// Token: 0x06011CF6 RID: 72950 RVA: 0x004627B8 File Offset: 0x004609B8
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

	// Token: 0x06011CF7 RID: 72951 RVA: 0x0046288C File Offset: 0x00460A8C
	public void UpdateTaskDataFromBattlePassTaskTakeResponse(int[] ids)
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

	// Token: 0x06011CF8 RID: 72952 RVA: 0x004628D8 File Offset: 0x00460AD8
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

	// Token: 0x06011CF9 RID: 72953 RVA: 0x0046294C File Offset: 0x00460B4C
	public void UpdateRewardDataFromBattlePassTakeAllRewardResponse(BattlePassTakeAllRewardResponse response)
	{
		foreach (PbBattlePassReward pbBattlePassReward in response.TakenRewards)
		{
			this.TakeReward(pbBattlePassReward.Type, pbBattlePassReward.Level, pbBattlePassReward.ItemId);
		}
		EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
	}

	// Token: 0x06011CFA RID: 72954 RVA: 0x004629BC File Offset: 0x00460BBC
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

	// Token: 0x06011CFB RID: 72955 RVA: 0x00462A30 File Offset: 0x00460C30
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

	// Token: 0x06011CFC RID: 72956 RVA: 0x00462A68 File Offset: 0x00460C68
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

	// Token: 0x06011CFD RID: 72957 RVA: 0x00462B28 File Offset: 0x00460D28
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

	// Token: 0x06011CFE RID: 72958 RVA: 0x00462BE8 File Offset: 0x00460DE8
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

	// Token: 0x170016C2 RID: 5826
	// (get) Token: 0x06011CFF RID: 72959 RVA: 0x00462C8A File Offset: 0x00460E8A
	public int? RemindLevel
	{
		get
		{
			return this.RemindLevelInternal;
		}
	}

	// Token: 0x06011D00 RID: 72960 RVA: 0x00462C94 File Offset: 0x00460E94
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

	// Token: 0x06011D01 RID: 72961 RVA: 0x00462E0C File Offset: 0x0046100C
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

	// Token: 0x170016C3 RID: 5827
	// (get) Token: 0x06011D02 RID: 72962 RVA: 0x00462FDC File Offset: 0x004611DC
	public static BattlePassModel Instance
	{
		get
		{
			return BattlePassModel._Instance;
		}
	}

	// Token: 0x06011D03 RID: 72963 RVA: 0x00462FE3 File Offset: 0x004611E3
	public static BattlePassModel GetOrCreateInstance()
	{
		if (BattlePassModel._Instance == null)
		{
			BattlePassModel.CreateInstance();
		}
		return BattlePassModel._Instance;
	}

	// Token: 0x06011D04 RID: 72964 RVA: 0x00462FF7 File Offset: 0x004611F7
	public static bool CreateInstance()
	{
		if (BattlePassModel._Instance != null)
		{
			return true;
		}
		BattlePassModel._Instance = new BattlePassModel();
		return true;
	}

	// Token: 0x06011D05 RID: 72965 RVA: 0x0046300D File Offset: 0x0046120D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011D06 RID: 72966 RVA: 0x0046300F File Offset: 0x0046120F
	public static void ResetStaticDefaultValue()
	{
		BattlePassModel._Instance = null;
	}

	// Token: 0x06011D07 RID: 72967 RVA: 0x00463017 File Offset: 0x00461217
	static BattlePassModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassModel.CreateStaticDefaultValue), new Action(BattlePassModel.ResetStaticDefaultValue));
	}

	// Token: 0x06011D09 RID: 72969 RVA: 0x00463040 File Offset: 0x00461240
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

	// Token: 0x06011D0A RID: 72970 RVA: 0x004630AE File Offset: 0x004612AE
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

	// Token: 0x040086E9 RID: 34537
	private const int GIFT_ID = 301;

	// Token: 0x040086EA RID: 34538
	public bool IsRequiringViewData;

	// Token: 0x040086EB RID: 34539
	private bool InTimeRange;

	// Token: 0x040086EC RID: 34540
	public int IncreasedLevelToShow;

	// Token: 0x040086ED RID: 34541
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<WeaponDataBase> WeaponDataList;

	// Token: 0x040086EE RID: 34542
	private long WarningTime;

	// Token: 0x040086EF RID: 34543
	private bool HadEnterInternal;

	// Token: 0x040086F0 RID: 34544
	private bool? PayButtonRedDotStateInternal;

	// Token: 0x040086F1 RID: 34545
	private int WeekExpLimitValue;

	// Token: 0x040086F2 RID: 34546
	private int AllExpLimitValue;

	// Token: 0x040086F3 RID: 34547
	private int GiftId;

	// Token: 0x040086F4 RID: 34548
	private long DayEndTime;

	// Token: 0x040086F5 RID: 34549
	private long WeekEndTime;

	// Token: 0x040086F6 RID: 34550
	public List<BattlePassRewardData> RewardDataList;

	// Token: 0x040086F7 RID: 34551
	public int BattlePassId;

	// Token: 0x040086F8 RID: 34552
	private int MaxLevel;

	// Token: 0x040086F9 RID: 34553
	public List<int> StageLevelList;

	// Token: 0x040086FA RID: 34554
	private int CurrentBattlePassLevel;

	// Token: 0x040086FB RID: 34555
	private int CurrentWeekExp;

	// Token: 0x040086FC RID: 34556
	private int CurrentLevelExp;

	// Token: 0x040086FD RID: 34557
	private BattlePassPayStatus BattlePassType;

	// Token: 0x040086FE RID: 34558
	private long BattlePassStartTime;

	// Token: 0x040086FF RID: 34559
	private long BattlePassEndTime;

	// Token: 0x04008700 RID: 34560
	private int MaxWeekExp;

	// Token: 0x04008701 RID: 34561
	private int MaxLevelExp;

	// Token: 0x04008702 RID: 34562
	public Dictionary<int, BattlePassTaskData> BattlePassTaskMap;

	// Token: 0x04008703 RID: 34563
	private int? RemindLevelInternal;

	// Token: 0x04008704 RID: 34564
	[Nullable(2)]
	private static BattlePassModel _Instance;
}

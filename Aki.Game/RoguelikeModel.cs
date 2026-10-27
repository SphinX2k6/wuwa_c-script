using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Roguelike;

// Token: 0x0200277C RID: 10108
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class RoguelikeModel : ModelBase
{
	// Token: 0x06014BA2 RID: 84898 RVA: 0x0053EE88 File Offset: 0x0053D088
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06014BA3 RID: 84899 RVA: 0x0053EE8B File Offset: 0x0053D08B
	protected override bool OnClear()
	{
		this.RoguelikeChooseDataMap.Clear();
		this.RogueInfoInternal = null;
		return true;
	}

	// Token: 0x17001B14 RID: 6932
	// (get) Token: 0x06014BA4 RID: 84900 RVA: 0x0053EEA0 File Offset: 0x0053D0A0
	// (set) Token: 0x06014BA5 RID: 84901 RVA: 0x0053EEA8 File Offset: 0x0053D0A8
	public List<int> EditFormationRoleList
	{
		get
		{
			return this.EditFormationRoleListInternal;
		}
		set
		{
			this.EditFormationRoleListInternal = value;
		}
	}

	// Token: 0x17001B15 RID: 6933
	// (get) Token: 0x06014BA6 RID: 84902 RVA: 0x0053EEB1 File Offset: 0x0053D0B1
	// (set) Token: 0x06014BA7 RID: 84903 RVA: 0x0053EEB9 File Offset: 0x0053D0B9
	public int CurIndex
	{
		get
		{
			return this.CurIndexInternal;
		}
		set
		{
			this.CurIndexInternal = value;
		}
	}

	// Token: 0x17001B16 RID: 6934
	// (get) Token: 0x06014BA8 RID: 84904 RVA: 0x0053EEC2 File Offset: 0x0053D0C2
	// (set) Token: 0x06014BA9 RID: 84905 RVA: 0x0053EECA File Offset: 0x0053D0CA
	public CSharpScript.Game.Module.Roguelike.RogueGainEntry CurrentRogueGainEntry
	{
		get
		{
			return this.CurrentRogueGainEntryInternal;
		}
		set
		{
			this.CurrentRogueGainEntryInternal = value;
		}
	}

	// Token: 0x17001B17 RID: 6935
	// (get) Token: 0x06014BAA RID: 84906 RVA: 0x0053EED3 File Offset: 0x0053D0D3
	// (set) Token: 0x06014BAB RID: 84907 RVA: 0x0053EEDB File Offset: 0x0053D0DB
	public RoguelikeInfo RogueInfo
	{
		get
		{
			return this.RogueInfoInternal;
		}
		set
		{
			this.RogueInfoInternal = value;
		}
	}

	// Token: 0x17001B18 RID: 6936
	// (get) Token: 0x06014BAC RID: 84908 RVA: 0x0053EEE4 File Offset: 0x0053D0E4
	// (set) Token: 0x06014BAD RID: 84909 RVA: 0x0053EEEC File Offset: 0x0053D0EC
	public int CurRoomCount
	{
		get
		{
			return this.CurRoomCountInternal;
		}
		set
		{
			this.CurRoomCountInternal = value;
		}
	}

	// Token: 0x17001B19 RID: 6937
	// (get) Token: 0x06014BAE RID: 84910 RVA: 0x0053EEF5 File Offset: 0x0053D0F5
	// (set) Token: 0x06014BAF RID: 84911 RVA: 0x0053EEFD File Offset: 0x0053D0FD
	public int TotalRoomCount
	{
		get
		{
			return this.TotalRoomCountInternal;
		}
		set
		{
			this.TotalRoomCountInternal = value;
		}
	}

	// Token: 0x17001B1A RID: 6938
	// (get) Token: 0x06014BB0 RID: 84912 RVA: 0x0053EF06 File Offset: 0x0053D106
	// (set) Token: 0x06014BB1 RID: 84913 RVA: 0x0053EF0E File Offset: 0x0053D10E
	public RoguelikeRoomType? CurRoomType
	{
		get
		{
			return this.CurRoomTypeInternal;
		}
		set
		{
			this.CurRoomTypeInternal = value;
		}
	}

	// Token: 0x17001B1B RID: 6939
	// (get) Token: 0x06014BB2 RID: 84914 RVA: 0x0053EF17 File Offset: 0x0053D117
	// (set) Token: 0x06014BB3 RID: 84915 RVA: 0x0053EF24 File Offset: 0x0053D124
	[Nullable(1)]
	public string CurRoomMusicState
	{
		[NullableContext(1)]
		get
		{
			return this.CurRoomMusicStateInternal.State;
		}
		[NullableContext(1)]
		set
		{
			this.CurRoomMusicStateInternal.State = (value ?? "none");
		}
	}

	// Token: 0x17001B1C RID: 6940
	// (get) Token: 0x06014BB4 RID: 84916 RVA: 0x0053EF3B File Offset: 0x0053D13B
	[Nullable(1)]
	public Dictionary<int, int> RoguelikeCurrencyDictMap
	{
		[NullableContext(1)]
		get
		{
			return this.RoguelikeCurrencyDict;
		}
	}

	// Token: 0x06014BB5 RID: 84917 RVA: 0x0053EF44 File Offset: 0x0053D144
	public RoleDataBase GetRoguelikeRoleData(int rogueRoleId)
	{
		RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(rogueRoleId);
		if (rogueCharacterConfig == null)
		{
			return null;
		}
		int roleId = rogueCharacterConfig.Value.RoleId;
		int trialRoleId = rogueCharacterConfig.Value.TrialRoleId;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			return roleInstanceById;
		}
		if (trialRoleId == 0)
		{
			return null;
		}
		RoleRobotData roleRobotData = RoleModel.Instance.GetRoleRobotData(trialRoleId);
		if (roleRobotData != null)
		{
			return roleRobotData;
		}
		return null;
	}

	// Token: 0x06014BB6 RID: 84918 RVA: 0x0053EFB5 File Offset: 0x0053D1B5
	public void SetRoguelikeCurrency(int id, int count)
	{
		this.RoguelikeCurrencyDict[id] = count;
	}

	// Token: 0x06014BB7 RID: 84919 RVA: 0x0053EFC4 File Offset: 0x0053D1C4
	public void UpdateRoguelikeCurrency(int id, int addCount)
	{
		int roguelikeCurrency = this.GetRoguelikeCurrency(id);
		this.RoguelikeCurrencyDict[id] = roguelikeCurrency + addCount;
		EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, id);
	}

	// Token: 0x06014BB8 RID: 84920 RVA: 0x0053EFFC File Offset: 0x0053D1FC
	public int GetRoguelikeCurrency(int currencyId)
	{
		int result;
		if (!this.RoguelikeCurrencyDict.TryGetValue(currencyId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06014BB9 RID: 84921 RVA: 0x0053F01C File Offset: 0x0053D21C
	public int GetRoguelikeInventoryCurrency(int currencyId)
	{
		if (currencyId == 80100000 && WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
		{
			return WeeklyRogueModel.Instance.GetCurrency(currencyId);
		}
		int result;
		if (!this.RoguelikeCurrencyDict.TryGetValue(currencyId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06014BBA RID: 84922 RVA: 0x0053F05C File Offset: 0x0053D25C
	public void UpdateDescModel(bool isSimple)
	{
		EDescModel descMode = isSimple ? EDescModel.SIMPLE : EDescModel.DETAIL;
		this.DescMode = descMode;
		EventSystem.Instance.Emit(EEventName.RoguelikeDataUpdate);
	}

	// Token: 0x06014BBB RID: 84923 RVA: 0x0053F088 File Offset: 0x0053D288
	public EDescModel GetDescModel()
	{
		return this.DescMode;
	}

	// Token: 0x06014BBC RID: 84924 RVA: 0x0053F090 File Offset: 0x0053D290
	public RoguelikeEntranceViewModel GetEntranceViewModel()
	{
		if (this.EntranceViewModel == null)
		{
			this.EntranceViewModel = new RoguelikeEntranceViewModel();
		}
		return this.EntranceViewModel;
	}

	// Token: 0x06014BBD RID: 84925 RVA: 0x0053F0AB File Offset: 0x0053D2AB
	public void ClearEntranceViewModel()
	{
		this.EntranceViewModel = null;
	}

	// Token: 0x06014BBE RID: 84926 RVA: 0x0053F0B4 File Offset: 0x0053D2B4
	[NullableContext(1)]
	public void SetRoguelikeChooseData(IReadOnlyList<Aki.Protocol.RoguelikeChooseData> roguelikeChooseData)
	{
		foreach (Aki.Protocol.RoguelikeChooseData roguelikeChooseData2 in roguelikeChooseData)
		{
			this.RoguelikeChooseDataMap[roguelikeChooseData2.Index] = new CSharpScript.Game.Module.Roguelike.RoguelikeChooseData(roguelikeChooseData2);
		}
	}

	// Token: 0x06014BBF RID: 84927 RVA: 0x0053F10C File Offset: 0x0053D30C
	public CSharpScript.Game.Module.Roguelike.RoguelikeChooseData GetRoguelikeChooseDataById(int bindId)
	{
		CSharpScript.Game.Module.Roguelike.RoguelikeChooseData result;
		this.RoguelikeChooseDataMap.TryGetValue(bindId, out result);
		return result;
	}

	// Token: 0x06014BC0 RID: 84928 RVA: 0x0053F12C File Offset: 0x0053D32C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	public ValueTuple<List<CSharpScript.Game.Module.Roguelike.ElementInfo>, Dictionary<EElementType, CSharpScript.Game.Module.Roguelike.ElementInfo>> GetSortElementInfoArrayMap(Dictionary<int, int> addElementDict = null)
	{
		int num = 9;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> keyValuePair in this.RogueInfo.ElementDict)
		{
			int num2;
			int num3;
			keyValuePair.Deconstruct(out num2, out num3);
			int num4 = num2;
			int value = num3;
			if (num4 != num)
			{
				dictionary[num4] = value;
			}
		}
		if (addElementDict != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in addElementDict)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num3, out num2);
				int num5 = num3;
				int num6 = num2;
				if (num5 != num)
				{
					int num8;
					int num7 = dictionary.TryGetValue(num5, out num8) ? num8 : 0;
					dictionary[num5] = num7 + num6;
				}
			}
		}
		List<CSharpScript.Game.Module.Roguelike.ElementInfo> list = new List<CSharpScript.Game.Module.Roguelike.ElementInfo>();
		Dictionary<EElementType, CSharpScript.Game.Module.Roguelike.ElementInfo> dictionary2 = new Dictionary<EElementType, CSharpScript.Game.Module.Roguelike.ElementInfo>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int num2;
			int num3;
			keyValuePair.Deconstruct(out num2, out num3);
			int num9 = num2;
			int count = num3;
			CSharpScript.Game.Module.Roguelike.ElementInfo elementInfo = new CSharpScript.Game.Module.Roguelike.ElementInfo(num9, count, null);
			if (addElementDict != null)
			{
				int num10;
				elementInfo.IsPreview = ((addElementDict.TryGetValue(num9, out num10) ? num10 : 0) > 0);
			}
			list.Add(elementInfo);
			dictionary2[(EElementType)elementInfo.ElementId] = elementInfo;
		}
		list.Sort((CSharpScript.Game.Module.Roguelike.ElementInfo a, CSharpScript.Game.Module.Roguelike.ElementInfo b) => b.Count - a.Count);
		return new ValueTuple<List<CSharpScript.Game.Module.Roguelike.ElementInfo>, Dictionary<EElementType, CSharpScript.Game.Module.Roguelike.ElementInfo>>(list, dictionary2);
	}

	// Token: 0x06014BC1 RID: 84929 RVA: 0x0053F2E4 File Offset: 0x0053D4E4
	public bool CheckInRoguelike()
	{
		DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
		InstanceDungeon? instanceDungeon;
		return (currentActivityData == null || !currentActivityData.IsDreamLinkInst(CreatureModel.Instance.GetInstanceId())) && InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 15 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x06014BC2 RID: 84930 RVA: 0x0053F358 File Offset: 0x0053D558
	public bool CheckInRoguelikeOnly()
	{
		InstanceDungeon? instanceDungeon;
		return InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 15 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x06014BC3 RID: 84931 RVA: 0x0053F3A8 File Offset: 0x0053D5A8
	public bool CheckIsGuideDungeon()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && instanceDungeon != null && paramConfigBySeasonId.Value.GuideInstArrayLength > 0 && paramConfigBySeasonId.Value.GuideInstArray().Contains(instanceDungeon.Value.Id);
	}

	// Token: 0x06014BC4 RID: 84932 RVA: 0x0053F41C File Offset: 0x0053D61C
	public RoguelikeTalentTreeViewModel GetTalentTreeViewModel()
	{
		if (this.TalentTreeViewModel == null)
		{
			this.TalentTreeViewModel = new RoguelikeTalentTreeViewModel();
		}
		return this.TalentTreeViewModel;
	}

	// Token: 0x06014BC5 RID: 84933 RVA: 0x0053F437 File Offset: 0x0053D637
	public void ClearTalentTreeViewModel()
	{
		this.TalentTreeViewModel = null;
	}

	// Token: 0x17001B1D RID: 6941
	// (get) Token: 0x06014BC6 RID: 84934 RVA: 0x0053F440 File Offset: 0x0053D640
	[Nullable(1)]
	public Dictionary<int, int> RoguelikeSkillDataMap
	{
		[NullableContext(1)]
		get
		{
			return this.RoguelikeSkillData;
		}
	}

	// Token: 0x06014BC7 RID: 84935 RVA: 0x0053F448 File Offset: 0x0053D648
	public void SetRoguelikeSkillData(int skillId, int skillLevel)
	{
		this.RoguelikeSkillData[skillId] = skillLevel;
		RoguelikeTalentTreeViewModel talentTreeViewModel = this.TalentTreeViewModel;
		if (talentTreeViewModel == null)
		{
			return;
		}
		talentTreeViewModel.RefreshLineTypeMap();
	}

	// Token: 0x06014BC8 RID: 84936 RVA: 0x0053F468 File Offset: 0x0053D668
	public bool CheckHasCanUnlockSkill()
	{
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		if (paramConfigBySeasonId == null)
		{
			return false;
		}
		int roguelikeCurrency = this.GetRoguelikeCurrency(paramConfigBySeasonId.Value.SkillPoint);
		foreach (KeyValuePair<int, int> keyValuePair in this.RoguelikeSkillDataMap)
		{
			int num;
			int num2;
			keyValuePair.Deconstruct(out num, out num2);
			int id = num;
			if (num2 == 0)
			{
				RogueTalentTree? rogueTalentTreeById = RoguelikeConfig.Instance.GetRogueTalentTreeById(id);
				if (rogueTalentTreeById.Value.ConsuleLength > 0 && rogueTalentTreeById.Value.Consule(0) <= roguelikeCurrency)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06014BC9 RID: 84937 RVA: 0x0053F538 File Offset: 0x0053D738
	public bool CheckRoguelikeShopRedDot()
	{
		ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
		RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
		if (rogueSeasonData == null)
		{
			return false;
		}
		ActivityRogueData currentActivityData2 = ActivityRogueController.Instance.GetCurrentActivityData();
		if (currentActivityData2 == null)
		{
			return false;
		}
		RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
		if (rogueSeasonConfigById == null)
		{
			return false;
		}
		if (currentActivityData2.GetRogueActivityState() != ERogueActivityState.Open)
		{
			return false;
		}
		foreach (PayShopGoods payShopGoods in this.GetPayShopFirstTabGoods(rogueSeasonConfigById.Value.ShopId))
		{
			if (!payShopGoods.IsSoldOut() && !payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoguelikeShopItemChecked, payShopGoods.GetGoodsId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014BCA RID: 84938 RVA: 0x0053F624 File Offset: 0x0053D824
	public bool HasBlackFlowerExchanged(int dungeonId)
	{
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && paramConfigBySeasonId.Value.BlackFlowerInstList().Contains(dungeonId);
	}

	// Token: 0x06014BCB RID: 84939 RVA: 0x0053F664 File Offset: 0x0053D864
	public bool HasBlackFlowerDrop()
	{
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && paramConfigBySeasonId.Value.BlackFlowerDropId != 0;
	}

	// Token: 0x06014BCC RID: 84940 RVA: 0x0053F69E File Offset: 0x0053D89E
	public bool HasBossChallengeMode()
	{
		return this.GetBossChallengeInstId() != 0;
	}

	// Token: 0x06014BCD RID: 84941 RVA: 0x0053F6AC File Offset: 0x0053D8AC
	public int GetBossChallengeInstId()
	{
		ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
		RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
		if (rogueSeasonData == null)
		{
			return 0;
		}
		RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
		if (rogueSeasonConfigById == null)
		{
			return 0;
		}
		return rogueSeasonConfigById.GetValueOrDefault().ChallengeInstanceId;
	}

	// Token: 0x06014BCE RID: 84942 RVA: 0x0053F700 File Offset: 0x0053D900
	[NullableContext(1)]
	private List<PayShopGoods> GetPayShopFirstTabGoods(int shopId)
	{
		int payShopFirstTabId = PayShopModel.Instance.GetPayShopFirstTabId((PayShopDefine.EPayShopTabType)shopId);
		return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, payShopFirstTabId, false);
	}

	// Token: 0x06014BCF RID: 84943 RVA: 0x0053F726 File Offset: 0x0053D926
	public bool GetMapNoteShowState()
	{
		return false;
	}

	// Token: 0x06014BD0 RID: 84944 RVA: 0x0053F72C File Offset: 0x0053D92C
	public void RecordRoguelikeShopRedDot()
	{
		ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
		RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
		if (rogueSeasonData == null)
		{
			return;
		}
		RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
		if (rogueSeasonConfigById == null)
		{
			return;
		}
		List<PayShopGoods> payShopFirstTabGoods = this.GetPayShopFirstTabGoods(rogueSeasonConfigById.Value.ShopId);
		bool flag = false;
		foreach (PayShopGoods payShopGoods in payShopFirstTabGoods)
		{
			if (!payShopGoods.IsSoldOut() && !payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoguelikeShopItemChecked, payShopGoods.GetGoodsId()))
			{
				NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.RoguelikeShopItemChecked, payShopGoods.GetGoodsId());
				flag = true;
			}
		}
		if (flag)
		{
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoguelikeShopItemChecked);
			EventSystem.Instance.Emit(EEventName.RoguelikeDataUpdate);
		}
	}

	// Token: 0x06014BD1 RID: 84945 RVA: 0x0053F830 File Offset: 0x0053DA30
	public bool GetRoguelikeAchievementRedDot()
	{
		ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
		RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
		if (rogueSeasonData == null)
		{
			return false;
		}
		RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
		return AchievementModel.Instance.GetCategoryRedPointState(rogueSeasonConfigById.Value.Achievement);
	}

	// Token: 0x06014BD2 RID: 84946 RVA: 0x0053F888 File Offset: 0x0053DA88
	public bool CheckRogueIsOpen()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.Roguelike) && ActivityRogueController.Instance.GetCurrentActivityData() != null && ActivityRogueController.Instance.GetCurrentActivityData().GetRogueActivityState() != ERogueActivityState.Close;
	}

	// Token: 0x06014BD3 RID: 84947 RVA: 0x0053F8C0 File Offset: 0x0053DAC0
	public RogueParam? GetParamConfigBySeasonId(int? seasonId = null)
	{
		if (seasonId != null && seasonId.GetValueOrDefault() != 0)
		{
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonId.Value);
			return RoguelikeConfig.Instance.GetRogueParamConfig(rogueSeasonConfigById.Value.ParamId);
		}
		ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
		RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
		if (rogueSeasonData != null)
		{
			RogueSeason? rogueSeasonConfigById2 = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
			return RoguelikeConfig.Instance.GetRogueParamConfig(rogueSeasonConfigById2.Value.ParamId);
		}
		return RoguelikeConfig.Instance.GetRogueParamConfig(1);
	}

	// Token: 0x17001B1E RID: 6942
	// (get) Token: 0x06014BD4 RID: 84948 RVA: 0x0053F95B File Offset: 0x0053DB5B
	[Nullable(1)]
	public static RoguelikeModel Instance
	{
		[NullableContext(1)]
		get
		{
			return RoguelikeModel._Instance;
		}
	}

	// Token: 0x06014BD5 RID: 84949 RVA: 0x0053F962 File Offset: 0x0053DB62
	[NullableContext(1)]
	public static RoguelikeModel GetOrCreateInstance()
	{
		if (RoguelikeModel._Instance == null)
		{
			RoguelikeModel.CreateInstance();
		}
		return RoguelikeModel._Instance;
	}

	// Token: 0x06014BD6 RID: 84950 RVA: 0x0053F976 File Offset: 0x0053DB76
	public static bool CreateInstance()
	{
		if (RoguelikeModel._Instance != null)
		{
			return true;
		}
		RoguelikeModel._Instance = new RoguelikeModel();
		return true;
	}

	// Token: 0x06014BD7 RID: 84951 RVA: 0x0053F98C File Offset: 0x0053DB8C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014BD8 RID: 84952 RVA: 0x0053F98E File Offset: 0x0053DB8E
	public static void ResetStaticDefaultValue()
	{
		RoguelikeModel._Instance = null;
	}

	// Token: 0x06014BD9 RID: 84953 RVA: 0x0053F996 File Offset: 0x0053DB96
	static RoguelikeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeModel.CreateStaticDefaultValue), new Action(RoguelikeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009BEC RID: 39916
	private RoguelikeInfo RogueInfoInternal;

	// Token: 0x04009BED RID: 39917
	public RogueChallengeModeType? RogueModeType;

	// Token: 0x04009BEE RID: 39918
	private int CurIndexInternal;

	// Token: 0x04009BEF RID: 39919
	private CSharpScript.Game.Module.Roguelike.RogueGainEntry CurrentRogueGainEntryInternal;

	// Token: 0x04009BF0 RID: 39920
	private int CurRoomCountInternal;

	// Token: 0x04009BF1 RID: 39921
	private int TotalRoomCountInternal;

	// Token: 0x04009BF2 RID: 39922
	private RoguelikeRoomType? CurRoomTypeInternal;

	// Token: 0x04009BF3 RID: 39923
	[Nullable(1)]
	private readonly StateRef CurRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

	// Token: 0x04009BF4 RID: 39924
	private List<int> EditFormationRoleListInternal;

	// Token: 0x04009BF5 RID: 39925
	[Nullable(1)]
	private readonly Dictionary<int, CSharpScript.Game.Module.Roguelike.RoguelikeChooseData> RoguelikeChooseDataMap = new Dictionary<int, CSharpScript.Game.Module.Roguelike.RoguelikeChooseData>();

	// Token: 0x04009BF6 RID: 39926
	[Nullable(1)]
	private readonly Dictionary<int, int> RoguelikeSkillData = new Dictionary<int, int>();

	// Token: 0x04009BF7 RID: 39927
	[Nullable(1)]
	private readonly Dictionary<int, int> RoguelikeCurrencyDict = new Dictionary<int, int>();

	// Token: 0x04009BF8 RID: 39928
	public long? TempCountdown;

	// Token: 0x04009BF9 RID: 39929
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RewardItemData> ShowRewardList;

	// Token: 0x04009BFA RID: 39930
	public int? CurDungeonId;

	// Token: 0x04009BFB RID: 39931
	private EDescModel DescMode;

	// Token: 0x04009BFC RID: 39932
	[Nullable(1)]
	public List<int> SelectRoleViewShowRoleList = new List<int>();

	// Token: 0x04009BFD RID: 39933
	[Nullable(1)]
	public List<int> SelectRoleViewRecommendRoleList = new List<int>();

	// Token: 0x04009BFE RID: 39934
	public int? CurRoomId;

	// Token: 0x04009BFF RID: 39935
	public string CurRoomTypeId;

	// Token: 0x04009C00 RID: 39936
	private RoguelikeEntranceViewModel EntranceViewModel;

	// Token: 0x04009C01 RID: 39937
	private RoguelikeTalentTreeViewModel TalentTreeViewModel;

	// Token: 0x04009C02 RID: 39938
	private static RoguelikeModel _Instance;
}

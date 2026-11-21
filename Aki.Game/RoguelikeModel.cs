using System;
using System.Collections.Generic;
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

// Token: 0x02001C67 RID: 7271
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class RoguelikeModel : ModelBase
{
	// Token: 0x06012085 RID: 73861 RVA: 0x0054DD08 File Offset: 0x0054BF08
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06012086 RID: 73862 RVA: 0x0054DD0B File Offset: 0x0054BF0B
	protected override bool OnClear()
	{
		this.RoguelikeChooseDataMap.Clear();
		this.RogueInfoInternal = null;
		return true;
	}

	// Token: 0x17001B4D RID: 6989
	// (get) Token: 0x06012087 RID: 73863 RVA: 0x0054DD20 File Offset: 0x0054BF20
	// (set) Token: 0x06012088 RID: 73864 RVA: 0x0054DD28 File Offset: 0x0054BF28
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

	// Token: 0x17001B4E RID: 6990
	// (get) Token: 0x06012089 RID: 73865 RVA: 0x0054DD31 File Offset: 0x0054BF31
	// (set) Token: 0x0601208A RID: 73866 RVA: 0x0054DD39 File Offset: 0x0054BF39
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

	// Token: 0x17001B4F RID: 6991
	// (get) Token: 0x0601208B RID: 73867 RVA: 0x0054DD42 File Offset: 0x0054BF42
	// (set) Token: 0x0601208C RID: 73868 RVA: 0x0054DD4A File Offset: 0x0054BF4A
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

	// Token: 0x17001B50 RID: 6992
	// (get) Token: 0x0601208D RID: 73869 RVA: 0x0054DD53 File Offset: 0x0054BF53
	// (set) Token: 0x0601208E RID: 73870 RVA: 0x0054DD5B File Offset: 0x0054BF5B
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

	// Token: 0x17001B51 RID: 6993
	// (get) Token: 0x0601208F RID: 73871 RVA: 0x0054DD64 File Offset: 0x0054BF64
	// (set) Token: 0x06012090 RID: 73872 RVA: 0x0054DD6C File Offset: 0x0054BF6C
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

	// Token: 0x17001B52 RID: 6994
	// (get) Token: 0x06012091 RID: 73873 RVA: 0x0054DD75 File Offset: 0x0054BF75
	// (set) Token: 0x06012092 RID: 73874 RVA: 0x0054DD7D File Offset: 0x0054BF7D
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

	// Token: 0x17001B53 RID: 6995
	// (get) Token: 0x06012093 RID: 73875 RVA: 0x0054DD86 File Offset: 0x0054BF86
	// (set) Token: 0x06012094 RID: 73876 RVA: 0x0054DD8E File Offset: 0x0054BF8E
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

	// Token: 0x17001B54 RID: 6996
	// (get) Token: 0x06012095 RID: 73877 RVA: 0x0054DD97 File Offset: 0x0054BF97
	// (set) Token: 0x06012096 RID: 73878 RVA: 0x0054DDA4 File Offset: 0x0054BFA4
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

	// Token: 0x17001B55 RID: 6997
	// (get) Token: 0x06012097 RID: 73879 RVA: 0x0054DDBB File Offset: 0x0054BFBB
	[Nullable(1)]
	public Dictionary<int, int> RoguelikeCurrencyDictMap
	{
		[NullableContext(1)]
		get
		{
			return this.RoguelikeCurrencyDict;
		}
	}

	// Token: 0x06012098 RID: 73880 RVA: 0x0054DDC4 File Offset: 0x0054BFC4
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

	// Token: 0x06012099 RID: 73881 RVA: 0x0054DE35 File Offset: 0x0054C035
	public void SetRoguelikeCurrency(int id, int count)
	{
		this.RoguelikeCurrencyDict[id] = count;
	}

	// Token: 0x0601209A RID: 73882 RVA: 0x0054DE44 File Offset: 0x0054C044
	public void UpdateRoguelikeCurrency(int id, int addCount)
	{
		int roguelikeCurrency = this.GetRoguelikeCurrency(id);
		this.RoguelikeCurrencyDict[id] = roguelikeCurrency + addCount;
		EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, id);
	}

	// Token: 0x0601209B RID: 73883 RVA: 0x0054DE7C File Offset: 0x0054C07C
	public int GetRoguelikeCurrency(int currencyId)
	{
		int result;
		if (!this.RoguelikeCurrencyDict.TryGetValue(currencyId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601209C RID: 73884 RVA: 0x0054DE9C File Offset: 0x0054C09C
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

	// Token: 0x0601209D RID: 73885 RVA: 0x0054DEDC File Offset: 0x0054C0DC
	public void UpdateDescModel(bool isSimple)
	{
		EDescModel descMode = isSimple ? EDescModel.SIMPLE : EDescModel.DETAIL;
		this.DescMode = descMode;
		EventSystem.Instance.Emit(EEventName.RoguelikeDataUpdate);
	}

	// Token: 0x0601209E RID: 73886 RVA: 0x0054DF08 File Offset: 0x0054C108
	public EDescModel GetDescModel()
	{
		return this.DescMode;
	}

	// Token: 0x0601209F RID: 73887 RVA: 0x0054DF10 File Offset: 0x0054C110
	public RoguelikeEntranceViewModel GetEntranceViewModel()
	{
		if (this.EntranceViewModel == null)
		{
			this.EntranceViewModel = new RoguelikeEntranceViewModel();
		}
		return this.EntranceViewModel;
	}

	// Token: 0x060120A0 RID: 73888 RVA: 0x0054DF2B File Offset: 0x0054C12B
	public void ClearEntranceViewModel()
	{
		this.EntranceViewModel = null;
	}

	// Token: 0x060120A1 RID: 73889 RVA: 0x0054DF34 File Offset: 0x0054C134
	[NullableContext(1)]
	public void SetRoguelikeChooseData(IReadOnlyList<Aki.Protocol.RoguelikeChooseData> roguelikeChooseData)
	{
		foreach (Aki.Protocol.RoguelikeChooseData roguelikeChooseData2 in roguelikeChooseData)
		{
			this.RoguelikeChooseDataMap[roguelikeChooseData2.Index] = new CSharpScript.Game.Module.Roguelike.RoguelikeChooseData(roguelikeChooseData2);
		}
	}

	// Token: 0x060120A2 RID: 73890 RVA: 0x0054DF8C File Offset: 0x0054C18C
	public CSharpScript.Game.Module.Roguelike.RoguelikeChooseData GetRoguelikeChooseDataById(int bindId)
	{
		CSharpScript.Game.Module.Roguelike.RoguelikeChooseData result;
		this.RoguelikeChooseDataMap.TryGetValue(bindId, out result);
		return result;
	}

	// Token: 0x060120A3 RID: 73891 RVA: 0x0054DFAC File Offset: 0x0054C1AC
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

	// Token: 0x060120A4 RID: 73892 RVA: 0x0054E164 File Offset: 0x0054C364
	public bool CheckInRoguelike()
	{
		DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
		InstanceDungeon? instanceDungeon;
		return (currentActivityData == null || !currentActivityData.IsDreamLinkInst(CreatureModel.Instance.GetInstanceId())) && InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 15 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x060120A5 RID: 73893 RVA: 0x0054E1D8 File Offset: 0x0054C3D8
	public bool CheckInRoguelikeOnly()
	{
		InstanceDungeon? instanceDungeon;
		return InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 15 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x060120A6 RID: 73894 RVA: 0x0054E228 File Offset: 0x0054C428
	public bool CheckIsGuideDungeon()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && instanceDungeon != null && paramConfigBySeasonId.Value.GuideInstArrayLength > 0 && Array.IndexOf<int>(paramConfigBySeasonId.Value.GuideInstArray(), instanceDungeon.Value.Id) >= 0;
	}

	// Token: 0x060120A7 RID: 73895 RVA: 0x0054E2A2 File Offset: 0x0054C4A2
	public RoguelikeTalentTreeViewModel GetTalentTreeViewModel()
	{
		if (this.TalentTreeViewModel == null)
		{
			this.TalentTreeViewModel = new RoguelikeTalentTreeViewModel();
		}
		return this.TalentTreeViewModel;
	}

	// Token: 0x060120A8 RID: 73896 RVA: 0x0054E2BD File Offset: 0x0054C4BD
	public void ClearTalentTreeViewModel()
	{
		this.TalentTreeViewModel = null;
	}

	// Token: 0x17001B56 RID: 6998
	// (get) Token: 0x060120A9 RID: 73897 RVA: 0x0054E2C6 File Offset: 0x0054C4C6
	[Nullable(1)]
	public Dictionary<int, int> RoguelikeSkillDataMap
	{
		[NullableContext(1)]
		get
		{
			return this.RoguelikeSkillData;
		}
	}

	// Token: 0x060120AA RID: 73898 RVA: 0x0054E2CE File Offset: 0x0054C4CE
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

	// Token: 0x060120AB RID: 73899 RVA: 0x0054E2F0 File Offset: 0x0054C4F0
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

	// Token: 0x060120AC RID: 73900 RVA: 0x0054E3C0 File Offset: 0x0054C5C0
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

	// Token: 0x060120AD RID: 73901 RVA: 0x0054E4AC File Offset: 0x0054C6AC
	public bool HasBlackFlowerExchanged(int dungeonId)
	{
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && Array.IndexOf<int>(paramConfigBySeasonId.Value.BlackFlowerInstList(), dungeonId) >= 0;
	}

	// Token: 0x060120AE RID: 73902 RVA: 0x0054E4F0 File Offset: 0x0054C6F0
	public bool HasBlackFlowerDrop()
	{
		RogueParam? paramConfigBySeasonId = this.GetParamConfigBySeasonId(null);
		return paramConfigBySeasonId != null && paramConfigBySeasonId.Value.BlackFlowerDropId != 0;
	}

	// Token: 0x060120AF RID: 73903 RVA: 0x0054E52A File Offset: 0x0054C72A
	public bool HasBossChallengeMode()
	{
		return this.GetBossChallengeInstId() != 0;
	}

	// Token: 0x060120B0 RID: 73904 RVA: 0x0054E538 File Offset: 0x0054C738
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

	// Token: 0x060120B1 RID: 73905 RVA: 0x0054E58C File Offset: 0x0054C78C
	[NullableContext(1)]
	private List<PayShopGoods> GetPayShopFirstTabGoods(int shopId)
	{
		int payShopFirstTabId = PayShopModel.Instance.GetPayShopFirstTabId((PayShopDefine.EPayShopTabType)shopId);
		return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, payShopFirstTabId, false);
	}

	// Token: 0x060120B2 RID: 73906 RVA: 0x0054E5B2 File Offset: 0x0054C7B2
	public bool GetMapNoteShowState()
	{
		return false;
	}

	// Token: 0x060120B3 RID: 73907 RVA: 0x0054E5B8 File Offset: 0x0054C7B8
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

	// Token: 0x060120B4 RID: 73908 RVA: 0x0054E6BC File Offset: 0x0054C8BC
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

	// Token: 0x060120B5 RID: 73909 RVA: 0x0054E714 File Offset: 0x0054C914
	public bool CheckRogueIsOpen()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.Roguelike) && ActivityRogueController.Instance.GetCurrentActivityData() != null && ActivityRogueController.Instance.GetCurrentActivityData().GetRogueActivityState() != ERogueActivityState.Close;
	}

	// Token: 0x060120B6 RID: 73910 RVA: 0x0054E74C File Offset: 0x0054C94C
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

	// Token: 0x17001B57 RID: 6999
	// (get) Token: 0x060120B7 RID: 73911 RVA: 0x0054E7E7 File Offset: 0x0054C9E7
	[Nullable(1)]
	public static RoguelikeModel Instance
	{
		[NullableContext(1)]
		get
		{
			return RoguelikeModel._Instance;
		}
	}

	// Token: 0x060120B8 RID: 73912 RVA: 0x0054E7EE File Offset: 0x0054C9EE
	[NullableContext(1)]
	public static RoguelikeModel GetOrCreateInstance()
	{
		if (RoguelikeModel._Instance == null)
		{
			RoguelikeModel.CreateInstance();
		}
		return RoguelikeModel._Instance;
	}

	// Token: 0x060120B9 RID: 73913 RVA: 0x0054E802 File Offset: 0x0054CA02
	public static bool CreateInstance()
	{
		if (RoguelikeModel._Instance != null)
		{
			return true;
		}
		RoguelikeModel._Instance = new RoguelikeModel();
		return true;
	}

	// Token: 0x060120BA RID: 73914 RVA: 0x0054E818 File Offset: 0x0054CA18
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060120BB RID: 73915 RVA: 0x0054E81A File Offset: 0x0054CA1A
	public static void ResetStaticDefaultValue()
	{
		RoguelikeModel._Instance = null;
	}

	// Token: 0x060120BC RID: 73916 RVA: 0x0054E822 File Offset: 0x0054CA22
	static RoguelikeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeModel.CreateStaticDefaultValue), new Action(RoguelikeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009D44 RID: 40260
	private RoguelikeInfo RogueInfoInternal;

	// Token: 0x04009D45 RID: 40261
	public RogueChallengeModeType? RogueModeType;

	// Token: 0x04009D46 RID: 40262
	private int CurIndexInternal;

	// Token: 0x04009D47 RID: 40263
	private CSharpScript.Game.Module.Roguelike.RogueGainEntry CurrentRogueGainEntryInternal;

	// Token: 0x04009D48 RID: 40264
	private int CurRoomCountInternal;

	// Token: 0x04009D49 RID: 40265
	private int TotalRoomCountInternal;

	// Token: 0x04009D4A RID: 40266
	private RoguelikeRoomType? CurRoomTypeInternal;

	// Token: 0x04009D4B RID: 40267
	[Nullable(1)]
	private readonly StateRef CurRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

	// Token: 0x04009D4C RID: 40268
	private List<int> EditFormationRoleListInternal;

	// Token: 0x04009D4D RID: 40269
	[Nullable(1)]
	private readonly Dictionary<int, CSharpScript.Game.Module.Roguelike.RoguelikeChooseData> RoguelikeChooseDataMap = new Dictionary<int, CSharpScript.Game.Module.Roguelike.RoguelikeChooseData>();

	// Token: 0x04009D4E RID: 40270
	[Nullable(1)]
	private readonly Dictionary<int, int> RoguelikeSkillData = new Dictionary<int, int>();

	// Token: 0x04009D4F RID: 40271
	[Nullable(1)]
	private readonly Dictionary<int, int> RoguelikeCurrencyDict = new Dictionary<int, int>();

	// Token: 0x04009D50 RID: 40272
	public long? TempCountdown;

	// Token: 0x04009D51 RID: 40273
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RewardItemData> ShowRewardList;

	// Token: 0x04009D52 RID: 40274
	public int? CurDungeonId;

	// Token: 0x04009D53 RID: 40275
	private EDescModel DescMode;

	// Token: 0x04009D54 RID: 40276
	[Nullable(1)]
	public List<int> SelectRoleViewShowRoleList = new List<int>();

	// Token: 0x04009D55 RID: 40277
	[Nullable(1)]
	public List<int> SelectRoleViewRecommendRoleList = new List<int>();

	// Token: 0x04009D56 RID: 40278
	public int? CurRoomId;

	// Token: 0x04009D57 RID: 40279
	public string CurRoomTypeId;

	// Token: 0x04009D58 RID: 40280
	private RoguelikeEntranceViewModel EntranceViewModel;

	// Token: 0x04009D59 RID: 40281
	private RoguelikeTalentTreeViewModel TalentTreeViewModel;

	// Token: 0x04009D5A RID: 40282
	private static RoguelikeModel _Instance;
}

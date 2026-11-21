using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001AD9 RID: 6873
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PlayerInfoModel : ModelBase
{
	// Token: 0x060110CB RID: 69835 RVA: 0x005027E0 File Offset: 0x005009E0
	public int? GetId()
	{
		return new int?(this.Id);
	}

	// Token: 0x060110CC RID: 69836 RVA: 0x005027F0 File Offset: 0x005009F0
	public void SetId(int id)
	{
		this.Id = id;
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.RecentlyLoginUID, id);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Log;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "设置当前UID";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UID", id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		EventSystem.Instance.Emit<int>(EEventName.ChangePlayerInfoId, id);
	}

	// Token: 0x060110CD RID: 69837 RVA: 0x00502849 File Offset: 0x00500A49
	public int[] GetIconList()
	{
		return this.IconList;
	}

	// Token: 0x060110CE RID: 69838 RVA: 0x00502851 File Offset: 0x00500A51
	public void SetIconList(int[] iconList)
	{
		this.IconList = iconList;
	}

	// Token: 0x060110CF RID: 69839 RVA: 0x0050285A File Offset: 0x00500A5A
	public int[] GetFrameList()
	{
		return this.FrameList;
	}

	// Token: 0x060110D0 RID: 69840 RVA: 0x00502862 File Offset: 0x00500A62
	public void SetFrameList(int[] frameList)
	{
		this.FrameList = frameList;
	}

	// Token: 0x060110D1 RID: 69841 RVA: 0x0050286B File Offset: 0x00500A6B
	public Dictionary<int, int> GetNumberProp()
	{
		return this.NumberProp;
	}

	// Token: 0x060110D2 RID: 69842 RVA: 0x00502873 File Offset: 0x00500A73
	public void SetNumberProp(Dictionary<int, int> numberProp)
	{
		this.NumberProp = numberProp;
	}

	// Token: 0x060110D3 RID: 69843 RVA: 0x0050287C File Offset: 0x00500A7C
	public Dictionary<int, string> GetStringProp()
	{
		return this.StringProp;
	}

	// Token: 0x060110D4 RID: 69844 RVA: 0x00502884 File Offset: 0x00500A84
	public void SetStringProp(Dictionary<int, string> stringProp)
	{
		this.StringProp = stringProp;
	}

	// Token: 0x060110D5 RID: 69845 RVA: 0x0050288D File Offset: 0x00500A8D
	public void SetPlayerName(string name)
	{
		this.ChangeStringProp(7, name);
		EventSystem.Instance.Emit(EEventName.OnNameChange);
	}

	// Token: 0x060110D6 RID: 69846 RVA: 0x005028A8 File Offset: 0x00500AA8
	public void UpdatePlayerAttributeNumberInfo(Dictionary<int, int> attrIntMap)
	{
		int num = 0;
		int? num2 = null;
		if (attrIntMap.ContainsKey(0))
		{
			num = this.GetPlayerLevel().GetValueOrDefault();
		}
		if (attrIntMap.ContainsKey(1))
		{
			num2 = this.GetPlayerExp();
		}
		foreach (KeyValuePair<int, int> keyValuePair in attrIntMap)
		{
			this.ChangeNumberProp(keyValuePair.Key, keyValuePair.Value);
		}
		int valueOrDefault = this.GetPlayerExp().GetValueOrDefault();
		int valueOrDefault2 = this.GetPlayerLevel().GetValueOrDefault();
		FunctionConfig instance = FunctionConfig.Instance;
		if (num <= 0 || num >= valueOrDefault2 || num2 == null)
		{
			if (num2 != null)
			{
				int? num3 = num2;
				int num4 = valueOrDefault;
				if (num3.GetValueOrDefault() < num4 & num3 != null)
				{
					int levelExp = instance.GetPlayerLevelConfig(valueOrDefault2).Value.LevelExp;
					EventSystem.Instance.Emit<int, int, int>(EEventName.OnPlayerExpChanged, valueOrDefault, num2.Value, levelExp);
				}
			}
			return;
		}
		IReadOnlyList<PlayerExp> rangePlayerExpConfig = instance.GetRangePlayerExpConfig(num, valueOrDefault2);
		if (rangePlayerExpConfig == null || rangePlayerExpConfig.Count < 1)
		{
			return;
		}
		PlayerExp playerExp = rangePlayerExpConfig[0];
		PlayerExp playerExp2 = rangePlayerExpConfig[rangePlayerExpConfig.Count - 1];
		int levelExp2 = playerExp.LevelExp;
		int totalExp = this.GetTotalExp(rangePlayerExpConfig, num2.Value, valueOrDefault);
		int levelExp3 = playerExp2.LevelExp;
		KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROSDKLEVEUPROLE);
		EventSystem.Instance.Emit<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, num, valueOrDefault2, valueOrDefault, num2.Value, totalExp, levelExp3, levelExp2);
	}

	// Token: 0x060110D7 RID: 69847 RVA: 0x00502A5C File Offset: 0x00500C5C
	public void ChangeNumberProp(int key, int value)
	{
		if (this.NumberProp != null)
		{
			this.NumberProp[key] = value;
		}
		if (key == 13 || key == 2 || key == 3)
		{
			int? playerMoneyItemId = this.GetPlayerMoneyItemId((EPlayerInfoNumber)key);
			EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, playerMoneyItemId.Value);
		}
	}

	// Token: 0x060110D8 RID: 69848 RVA: 0x00502AAC File Offset: 0x00500CAC
	public void ChangeStringProp(int key, string value)
	{
		if (this.StringProp != null)
		{
			this.StringProp[key] = value;
		}
	}

	// Token: 0x060110D9 RID: 69849 RVA: 0x00502AC4 File Offset: 0x00500CC4
	public void UpdatePlayerAttributeStringInfo(Dictionary<int, string> attrStringMap)
	{
		foreach (KeyValuePair<int, string> keyValuePair in attrStringMap)
		{
			this.ChangeStringProp(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x060110DA RID: 69850 RVA: 0x00502B20 File Offset: 0x00500D20
	private int GetTotalExp(IReadOnlyList<PlayerExp> playerExpConfigList, int sourceExp, int targetExp)
	{
		int num = 0;
		foreach (PlayerExp playerExp in playerExpConfigList)
		{
			num += playerExp.LevelExp;
		}
		return num - sourceExp + targetExp;
	}

	// Token: 0x060110DB RID: 69851 RVA: 0x00502B74 File Offset: 0x00500D74
	public int? GetNumberPropById(EPlayerInfoNumber key)
	{
		if (this.NumberProp == null)
		{
			return null;
		}
		int value;
		if (!this.NumberProp.TryGetValue((int)key, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x060110DC RID: 69852 RVA: 0x00502BB3 File Offset: 0x00500DB3
	public void SetNumberPropById(EPlayerInfoNumber key, int value)
	{
		if (this.NumberProp == null)
		{
			return;
		}
		this.NumberProp[(int)key] = value;
	}

	// Token: 0x060110DD RID: 69853 RVA: 0x00502BCC File Offset: 0x00500DCC
	[NullableContext(2)]
	public string GetStringPropById(EPlayerInfoNumber key)
	{
		if (this.StringProp == null)
		{
			return null;
		}
		string result;
		if (!this.StringProp.TryGetValue((int)key, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060110DE RID: 69854 RVA: 0x00502BF8 File Offset: 0x00500DF8
	public EPlayerGender GetPlayerGender()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.Sex);
		if (numberPropById == null)
		{
			return EPlayerGender.None;
		}
		return (EPlayerGender)numberPropById.Value;
	}

	// Token: 0x060110DF RID: 69855 RVA: 0x00502C20 File Offset: 0x00500E20
	public int GetPlayerMoney(int itemId)
	{
		if (itemId == 2)
		{
			return this.GetNumberPropById(EPlayerInfoNumber.MoneyGold).GetValueOrDefault();
		}
		if (itemId == 3)
		{
			return this.GetNumberPropById(EPlayerInfoNumber.MoneyDiamond).GetValueOrDefault();
		}
		if (itemId == 4)
		{
			return this.GetNumberPropById(EPlayerInfoNumber.CashCoin).GetValueOrDefault();
		}
		if (itemId == 5)
		{
			return PowerModel.Instance.GetPowerDataById(5).GetCurrentPower();
		}
		if (itemId == 6)
		{
			return PowerModel.Instance.GetPowerDataById(6).GetCurrentPower();
		}
		return 0;
	}

	// Token: 0x060110E0 RID: 69856 RVA: 0x00502C98 File Offset: 0x00500E98
	public int? GetPlayerMoneyItemId(EPlayerInfoNumber type)
	{
		if (type == EPlayerInfoNumber.MoneyGold)
		{
			return new int?(2);
		}
		if (type == EPlayerInfoNumber.MoneyDiamond)
		{
			return new int?(3);
		}
		if (type == EPlayerInfoNumber.CashCoin)
		{
			return new int?(4);
		}
		return null;
	}

	// Token: 0x060110E1 RID: 69857 RVA: 0x00502CD0 File Offset: 0x00500ED0
	[NullableContext(2)]
	public string GetAccountName(bool bCheckConfig = true)
	{
		if (this.StringProp == null)
		{
			return null;
		}
		if (!bCheckConfig)
		{
			return FunctionModel.Instance.GetPlayerName();
		}
		if (!PlayerInfoConfig.Instance.GetIsUseAccountName())
		{
			int playerRoleId = this.GetPlayerRoleId();
			return RoleModel.Instance.GetRoleInstanceById(playerRoleId).GetRoleRealName();
		}
		return FunctionModel.Instance.GetPlayerName();
	}

	// Token: 0x060110E2 RID: 69858 RVA: 0x00502D24 File Offset: 0x00500F24
	public bool IsPlayerId(int roleId, int? playerId = null)
	{
		int? num = playerId;
		int? num2 = (num != null) ? num : this.GetId();
		int playerRoleId = this.GetPlayerRoleId();
		num = num2;
		int? id = this.GetId();
		return (num.GetValueOrDefault() == id.GetValueOrDefault() & num != null == (id != null)) && roleId == playerRoleId;
	}

	// Token: 0x060110E3 RID: 69859 RVA: 0x00502D80 File Offset: 0x00500F80
	public int GetPlayerRoleId()
	{
		return RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
	}

	// Token: 0x060110E4 RID: 69860 RVA: 0x00502DA0 File Offset: 0x00500FA0
	public string GetPlayerHeadIconBig()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById != null)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(numberPropById.Value);
			if (roleConfig != null)
			{
				return roleConfig.Value.RoleHeadIconBig;
			}
		}
		return "";
	}

	// Token: 0x060110E5 RID: 69861 RVA: 0x00502DF0 File Offset: 0x00500FF0
	public string GetPlayerHeadIconLarge()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById != null)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(numberPropById.Value);
			if (roleConfig != null)
			{
				return roleConfig.Value.RoleHeadIconLarge;
			}
		}
		return "";
	}

	// Token: 0x060110E6 RID: 69862 RVA: 0x00502E40 File Offset: 0x00501040
	public string GetPlayerHeadIconCircle()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById != null)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(numberPropById.Value);
			if (roleConfig != null)
			{
				return roleConfig.Value.RoleHeadIconCircle;
			}
		}
		return "";
	}

	// Token: 0x060110E7 RID: 69863 RVA: 0x00502E90 File Offset: 0x00501090
	public int GetHeadIconId()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById != null)
		{
			return numberPropById.Value;
		}
		return 0;
	}

	// Token: 0x060110E8 RID: 69864 RVA: 0x00502EB8 File Offset: 0x005010B8
	[NullableContext(2)]
	public string GetPlayerStand()
	{
		EPlayerGender playerGender = this.GetPlayerGender();
		if (playerGender == EPlayerGender.Male)
		{
			return PlayerInfoConfig.Instance.GetMaleStandPath();
		}
		if (playerGender == EPlayerGender.Female)
		{
			return PlayerInfoConfig.Instance.GetFemaleStandPath();
		}
		return null;
	}

	// Token: 0x060110E9 RID: 69865 RVA: 0x00502EEA File Offset: 0x005010EA
	public int? GetPlayerLevel()
	{
		return this.GetNumberPropById(EPlayerInfoNumber.Level);
	}

	// Token: 0x060110EA RID: 69866 RVA: 0x00502EF3 File Offset: 0x005010F3
	public int? GetPlayerExp()
	{
		return this.GetNumberPropById(EPlayerInfoNumber.Experience);
	}

	// Token: 0x060110EB RID: 69867 RVA: 0x00502EFC File Offset: 0x005010FC
	[NullableContext(2)]
	public string GetPlayerName()
	{
		return this.GetStringPropById(EPlayerInfoNumber.Name);
	}

	// Token: 0x060110EC RID: 69868 RVA: 0x00502F05 File Offset: 0x00501105
	public int GetRandomSeed()
	{
		return this.RandomSeed;
	}

	// Token: 0x060110ED RID: 69869 RVA: 0x00502F10 File Offset: 0x00501110
	public int AdvanceRandomSeed(ERandomReason reason)
	{
		int randomSeed = this.RandomSeed;
		this.RandomSeed = RandomSystem.IterateRandomSeed(randomSeed, reason);
		return randomSeed;
	}

	// Token: 0x060110EE RID: 69870 RVA: 0x00502F32 File Offset: 0x00501132
	public void InitThirdPartyId(string userId, string onlineId, string accountId)
	{
		this.UserId = userId;
		this.OnlineId = onlineId;
		this.AccountId = accountId;
		EventSystem.Instance.Emit<string, string, string>(EEventName.TsSyncThirdPartyInfo, userId, onlineId, accountId);
	}

	// Token: 0x060110EF RID: 69871 RVA: 0x00502F5C File Offset: 0x0050115C
	[NullableContext(2)]
	public string GetThirdPartyUserId()
	{
		return this.UserId;
	}

	// Token: 0x060110F0 RID: 69872 RVA: 0x00502F64 File Offset: 0x00501164
	[NullableContext(2)]
	public string GetThirdPartyOnlineId()
	{
		return this.OnlineId;
	}

	// Token: 0x060110F1 RID: 69873 RVA: 0x00502F6C File Offset: 0x0050116C
	[NullableContext(2)]
	public string GetThirdPartyAccountId()
	{
		return this.AccountId;
	}

	// Token: 0x17001988 RID: 6536
	// (get) Token: 0x060110F2 RID: 69874 RVA: 0x00502F74 File Offset: 0x00501174
	public static PlayerInfoModel Instance
	{
		get
		{
			return PlayerInfoModel._Instance;
		}
	}

	// Token: 0x060110F3 RID: 69875 RVA: 0x00502F7B File Offset: 0x0050117B
	public static PlayerInfoModel GetOrCreateInstance()
	{
		if (PlayerInfoModel._Instance == null)
		{
			PlayerInfoModel.CreateInstance();
		}
		return PlayerInfoModel._Instance;
	}

	// Token: 0x060110F4 RID: 69876 RVA: 0x00502F8F File Offset: 0x0050118F
	public static bool CreateInstance()
	{
		if (PlayerInfoModel._Instance != null)
		{
			return true;
		}
		PlayerInfoModel._Instance = new PlayerInfoModel();
		return true;
	}

	// Token: 0x060110F5 RID: 69877 RVA: 0x00502FA5 File Offset: 0x005011A5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060110F6 RID: 69878 RVA: 0x00502FA7 File Offset: 0x005011A7
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoModel._Instance = null;
	}

	// Token: 0x060110F7 RID: 69879 RVA: 0x00502FAF File Offset: 0x005011AF
	static PlayerInfoModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoModel.CreateStaticDefaultValue), new Action(PlayerInfoModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009626 RID: 38438
	private int Id;

	// Token: 0x04009627 RID: 38439
	private int[] IconList = Array.Empty<int>();

	// Token: 0x04009628 RID: 38440
	private int[] FrameList = Array.Empty<int>();

	// Token: 0x04009629 RID: 38441
	private Dictionary<int, int> NumberProp = new Dictionary<int, int>();

	// Token: 0x0400962A RID: 38442
	private Dictionary<int, string> StringProp = new Dictionary<int, string>();

	// Token: 0x0400962B RID: 38443
	private string UserId = "";

	// Token: 0x0400962C RID: 38444
	private string OnlineId = "";

	// Token: 0x0400962D RID: 38445
	private string AccountId = "";

	// Token: 0x0400962E RID: 38446
	public int RandomSeed;

	// Token: 0x0400962F RID: 38447
	public bool NewbieGuideV2;

	// Token: 0x04009630 RID: 38448
	[Nullable(2)]
	private static PlayerInfoModel _Instance;
}

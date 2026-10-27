using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020025EE RID: 9710
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PlayerInfoModel : ModelBase
{
	// Token: 0x06013BE9 RID: 80873 RVA: 0x004F3A54 File Offset: 0x004F1C54
	public int? GetId()
	{
		return new int?(this.Id);
	}

	// Token: 0x06013BEA RID: 80874 RVA: 0x004F3A64 File Offset: 0x004F1C64
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

	// Token: 0x06013BEB RID: 80875 RVA: 0x004F3ABD File Offset: 0x004F1CBD
	public int[] GetIconList()
	{
		return this.IconList;
	}

	// Token: 0x06013BEC RID: 80876 RVA: 0x004F3AC5 File Offset: 0x004F1CC5
	public void SetIconList(int[] iconList)
	{
		this.IconList = iconList;
	}

	// Token: 0x06013BED RID: 80877 RVA: 0x004F3ACE File Offset: 0x004F1CCE
	public int[] GetFrameList()
	{
		return this.FrameList;
	}

	// Token: 0x06013BEE RID: 80878 RVA: 0x004F3AD6 File Offset: 0x004F1CD6
	public void SetFrameList(int[] frameList)
	{
		this.FrameList = frameList;
	}

	// Token: 0x06013BEF RID: 80879 RVA: 0x004F3ADF File Offset: 0x004F1CDF
	public Dictionary<int, int> GetNumberProp()
	{
		return this.NumberProp;
	}

	// Token: 0x06013BF0 RID: 80880 RVA: 0x004F3AE7 File Offset: 0x004F1CE7
	public void SetNumberProp(Dictionary<int, int> numberProp)
	{
		this.NumberProp = numberProp;
	}

	// Token: 0x06013BF1 RID: 80881 RVA: 0x004F3AF0 File Offset: 0x004F1CF0
	public Dictionary<int, string> GetStringProp()
	{
		return this.StringProp;
	}

	// Token: 0x06013BF2 RID: 80882 RVA: 0x004F3AF8 File Offset: 0x004F1CF8
	public void SetStringProp(Dictionary<int, string> stringProp)
	{
		this.StringProp = stringProp;
	}

	// Token: 0x06013BF3 RID: 80883 RVA: 0x004F3B01 File Offset: 0x004F1D01
	public void SetPlayerName(string name)
	{
		this.ChangeStringProp(7, name);
		EventSystem.Instance.Emit(EEventName.OnNameChange);
	}

	// Token: 0x06013BF4 RID: 80884 RVA: 0x004F3B1C File Offset: 0x004F1D1C
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

	// Token: 0x06013BF5 RID: 80885 RVA: 0x004F3CD0 File Offset: 0x004F1ED0
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

	// Token: 0x06013BF6 RID: 80886 RVA: 0x004F3D20 File Offset: 0x004F1F20
	public void ChangeStringProp(int key, string value)
	{
		if (this.StringProp != null)
		{
			this.StringProp[key] = value;
		}
	}

	// Token: 0x06013BF7 RID: 80887 RVA: 0x004F3D38 File Offset: 0x004F1F38
	public void UpdatePlayerAttributeStringInfo(Dictionary<int, string> attrStringMap)
	{
		foreach (KeyValuePair<int, string> keyValuePair in attrStringMap)
		{
			this.ChangeStringProp(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06013BF8 RID: 80888 RVA: 0x004F3D94 File Offset: 0x004F1F94
	private int GetTotalExp(IReadOnlyList<PlayerExp> playerExpConfigList, int sourceExp, int targetExp)
	{
		int num = 0;
		foreach (PlayerExp playerExp in playerExpConfigList)
		{
			num += playerExp.LevelExp;
		}
		return num - sourceExp + targetExp;
	}

	// Token: 0x06013BF9 RID: 80889 RVA: 0x004F3DE8 File Offset: 0x004F1FE8
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

	// Token: 0x06013BFA RID: 80890 RVA: 0x004F3E27 File Offset: 0x004F2027
	public void SetNumberPropById(EPlayerInfoNumber key, int value)
	{
		if (this.NumberProp == null)
		{
			return;
		}
		this.NumberProp[(int)key] = value;
	}

	// Token: 0x06013BFB RID: 80891 RVA: 0x004F3E40 File Offset: 0x004F2040
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

	// Token: 0x06013BFC RID: 80892 RVA: 0x004F3E6C File Offset: 0x004F206C
	public EPlayerGender GetPlayerGender()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.Sex);
		if (numberPropById == null)
		{
			return EPlayerGender.None;
		}
		return (EPlayerGender)numberPropById.Value;
	}

	// Token: 0x06013BFD RID: 80893 RVA: 0x004F3E94 File Offset: 0x004F2094
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

	// Token: 0x06013BFE RID: 80894 RVA: 0x004F3F0C File Offset: 0x004F210C
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

	// Token: 0x06013BFF RID: 80895 RVA: 0x004F3F44 File Offset: 0x004F2144
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

	// Token: 0x06013C00 RID: 80896 RVA: 0x004F3F98 File Offset: 0x004F2198
	public bool IsPlayerId(int roleId, int? playerId = null)
	{
		int? num = playerId;
		int? num2 = (num != null) ? num : this.GetId();
		int playerRoleId = this.GetPlayerRoleId();
		num = num2;
		int? id = this.GetId();
		return (num.GetValueOrDefault() == id.GetValueOrDefault() & num != null == (id != null)) && roleId == playerRoleId;
	}

	// Token: 0x06013C01 RID: 80897 RVA: 0x004F3FF4 File Offset: 0x004F21F4
	public int GetPlayerRoleId()
	{
		return RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
	}

	// Token: 0x06013C02 RID: 80898 RVA: 0x004F4014 File Offset: 0x004F2214
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

	// Token: 0x06013C03 RID: 80899 RVA: 0x004F4064 File Offset: 0x004F2264
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

	// Token: 0x06013C04 RID: 80900 RVA: 0x004F40B4 File Offset: 0x004F22B4
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

	// Token: 0x06013C05 RID: 80901 RVA: 0x004F4104 File Offset: 0x004F2304
	public int GetHeadIconId()
	{
		int? numberPropById = this.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		if (numberPropById != null)
		{
			return numberPropById.Value;
		}
		return 0;
	}

	// Token: 0x06013C06 RID: 80902 RVA: 0x004F412C File Offset: 0x004F232C
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

	// Token: 0x06013C07 RID: 80903 RVA: 0x004F415E File Offset: 0x004F235E
	public int? GetPlayerLevel()
	{
		return this.GetNumberPropById(EPlayerInfoNumber.Level);
	}

	// Token: 0x06013C08 RID: 80904 RVA: 0x004F4167 File Offset: 0x004F2367
	public int? GetPlayerExp()
	{
		return this.GetNumberPropById(EPlayerInfoNumber.Experience);
	}

	// Token: 0x06013C09 RID: 80905 RVA: 0x004F4170 File Offset: 0x004F2370
	[NullableContext(2)]
	public string GetPlayerName()
	{
		return this.GetStringPropById(EPlayerInfoNumber.Name);
	}

	// Token: 0x06013C0A RID: 80906 RVA: 0x004F4179 File Offset: 0x004F2379
	public int GetRandomSeed()
	{
		return this.RandomSeed;
	}

	// Token: 0x06013C0B RID: 80907 RVA: 0x004F4184 File Offset: 0x004F2384
	public int AdvanceRandomSeed(ERandomReason reason)
	{
		int randomSeed = this.RandomSeed;
		this.RandomSeed = RandomSystem.IterateRandomSeed(randomSeed, reason);
		return randomSeed;
	}

	// Token: 0x06013C0C RID: 80908 RVA: 0x004F41A6 File Offset: 0x004F23A6
	public void InitThirdPartyId(string userId, string onlineId, string accountId)
	{
		this.UserId = userId;
		this.OnlineId = onlineId;
		this.AccountId = accountId;
		EventSystem.Instance.Emit<string, string, string>(EEventName.TsSyncThirdPartyInfo, userId, onlineId, accountId);
	}

	// Token: 0x06013C0D RID: 80909 RVA: 0x004F41D0 File Offset: 0x004F23D0
	[NullableContext(2)]
	public string GetThirdPartyUserId()
	{
		return this.UserId;
	}

	// Token: 0x06013C0E RID: 80910 RVA: 0x004F41D8 File Offset: 0x004F23D8
	[NullableContext(2)]
	public string GetThirdPartyOnlineId()
	{
		return this.OnlineId;
	}

	// Token: 0x06013C0F RID: 80911 RVA: 0x004F41E0 File Offset: 0x004F23E0
	[NullableContext(2)]
	public string GetThirdPartyAccountId()
	{
		return this.AccountId;
	}

	// Token: 0x17001950 RID: 6480
	// (get) Token: 0x06013C10 RID: 80912 RVA: 0x004F41E8 File Offset: 0x004F23E8
	public static PlayerInfoModel Instance
	{
		get
		{
			return PlayerInfoModel._Instance;
		}
	}

	// Token: 0x06013C11 RID: 80913 RVA: 0x004F41EF File Offset: 0x004F23EF
	public static PlayerInfoModel GetOrCreateInstance()
	{
		if (PlayerInfoModel._Instance == null)
		{
			PlayerInfoModel.CreateInstance();
		}
		return PlayerInfoModel._Instance;
	}

	// Token: 0x06013C12 RID: 80914 RVA: 0x004F4203 File Offset: 0x004F2403
	public static bool CreateInstance()
	{
		if (PlayerInfoModel._Instance != null)
		{
			return true;
		}
		PlayerInfoModel._Instance = new PlayerInfoModel();
		return true;
	}

	// Token: 0x06013C13 RID: 80915 RVA: 0x004F4219 File Offset: 0x004F2419
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013C14 RID: 80916 RVA: 0x004F421B File Offset: 0x004F241B
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoModel._Instance = null;
	}

	// Token: 0x06013C15 RID: 80917 RVA: 0x004F4223 File Offset: 0x004F2423
	static PlayerInfoModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoModel.CreateStaticDefaultValue), new Action(PlayerInfoModel.ResetStaticDefaultValue));
	}

	// Token: 0x040094CF RID: 38095
	private int Id;

	// Token: 0x040094D0 RID: 38096
	private int[] IconList = Array.Empty<int>();

	// Token: 0x040094D1 RID: 38097
	private int[] FrameList = Array.Empty<int>();

	// Token: 0x040094D2 RID: 38098
	private Dictionary<int, int> NumberProp = new Dictionary<int, int>();

	// Token: 0x040094D3 RID: 38099
	private Dictionary<int, string> StringProp = new Dictionary<int, string>();

	// Token: 0x040094D4 RID: 38100
	private string UserId = "";

	// Token: 0x040094D5 RID: 38101
	private string OnlineId = "";

	// Token: 0x040094D6 RID: 38102
	private string AccountId = "";

	// Token: 0x040094D7 RID: 38103
	public int RandomSeed;

	// Token: 0x040094D8 RID: 38104
	public bool NewbieGuideV2;

	// Token: 0x040094D9 RID: 38105
	[Nullable(2)]
	private static PlayerInfoModel _Instance;
}

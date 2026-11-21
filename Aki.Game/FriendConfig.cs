using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010EB RID: 4331
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FriendConfig : ConfigBase
{
	// Token: 0x0600ACCA RID: 44234 RVA: 0x0032EB40 File Offset: 0x0032CD40
	public List<FriendFilter> GetAllFilterConfigDuplicate()
	{
		IReadOnlyList<FriendFilter> configList = ConfigFriendFilterAll.GetConfigList(true);
		if (configList != null)
		{
			List<FriendFilter> list = new List<FriendFilter>();
			foreach (FriendFilter item in configList)
			{
				list.Add(item);
			}
			return list;
		}
		return new List<FriendFilter>();
	}

	// Token: 0x0600ACCB RID: 44235 RVA: 0x0032EBA0 File Offset: 0x0032CDA0
	[NullableContext(2)]
	public string GetHeadIconPath(int headPhotoId)
	{
		HeadIcon? config = ConfigHeadIconById.GetConfig(headPhotoId, true);
		if (config != null)
		{
			return config.Value.IconPath;
		}
		return null;
	}

	// Token: 0x0600ACCC RID: 44236 RVA: 0x0032EBD0 File Offset: 0x0032CDD0
	public int GetFriendLimitByViewType(EFriendFilter viewType)
	{
		string id = "";
		switch (viewType)
		{
		case EFriendFilter.FriendList:
			id = "friend_list_limit";
			break;
		case EFriendFilter.FriendRequest:
			id = "friend_apply_list_limit";
			break;
		case EFriendFilter.RecentMultiple:
			id = "RecentlyTeamLimit";
			break;
		}
		return ConfigCommonParamById.GetIntConfig(id).Value;
	}

	// Token: 0x0600ACCD RID: 44237 RVA: 0x0032EC20 File Offset: 0x0032CE20
	public List<int> GetProcessViewFunctionList()
	{
		IEnumerable<PersonalTips> configList = ConfigPersonalTipsByFunctionId.GetConfigList(1, true);
		List<int> list = new List<int>();
		foreach (PersonalTips personalTips in configList)
		{
			list.Add(personalTips.Id);
		}
		list.Sort(this.SortProcessFunctionList);
		return list;
	}

	// Token: 0x0600ACCE RID: 44238 RVA: 0x0032EC88 File Offset: 0x0032CE88
	public int GetDefaultBackgroundCardId()
	{
		return ConfigCommonParamById.GetIntConfig("default_background_card").Value;
	}

	// Token: 0x170011DE RID: 4574
	// (get) Token: 0x0600ACCF RID: 44239 RVA: 0x0032ECA7 File Offset: 0x0032CEA7
	public static FriendConfig Instance
	{
		get
		{
			return FriendConfig._Instance;
		}
	}

	// Token: 0x0600ACD0 RID: 44240 RVA: 0x0032ECAE File Offset: 0x0032CEAE
	public static FriendConfig GetOrCreateInstance()
	{
		if (FriendConfig._Instance == null)
		{
			FriendConfig.CreateInstance();
		}
		return FriendConfig._Instance;
	}

	// Token: 0x0600ACD1 RID: 44241 RVA: 0x0032ECC2 File Offset: 0x0032CEC2
	public static bool CreateInstance()
	{
		if (FriendConfig._Instance != null)
		{
			return true;
		}
		FriendConfig._Instance = new FriendConfig();
		return true;
	}

	// Token: 0x0600ACD2 RID: 44242 RVA: 0x0032ECD8 File Offset: 0x0032CED8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ACD3 RID: 44243 RVA: 0x0032ECDA File Offset: 0x0032CEDA
	public static void ResetStaticDefaultValue()
	{
		FriendConfig._Instance = null;
	}

	// Token: 0x0600ACD4 RID: 44244 RVA: 0x0032ECE2 File Offset: 0x0032CEE2
	static FriendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendConfig.CreateStaticDefaultValue), new Action(FriendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040063A6 RID: 25510
	private readonly Comparison<int> SortProcessFunctionList = delegate(int a, int b)
	{
		PersonalTips? config = ConfigPersonalTipsById.GetConfig(a, true);
		PersonalTips? config2 = ConfigPersonalTipsById.GetConfig(b, true);
		return config.Value.Sort - config2.Value.Sort;
	};

	// Token: 0x040063A7 RID: 25511
	[Nullable(2)]
	private static FriendConfig _Instance;
}

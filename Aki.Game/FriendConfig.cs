using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C2C RID: 7212
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FriendConfig : ConfigBase
{
	// Token: 0x0600D8B4 RID: 55476 RVA: 0x00323768 File Offset: 0x00321968
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

	// Token: 0x0600D8B5 RID: 55477 RVA: 0x003237C8 File Offset: 0x003219C8
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

	// Token: 0x0600D8B6 RID: 55478 RVA: 0x003237F8 File Offset: 0x003219F8
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

	// Token: 0x0600D8B7 RID: 55479 RVA: 0x00323848 File Offset: 0x00321A48
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

	// Token: 0x0600D8B8 RID: 55480 RVA: 0x003238B0 File Offset: 0x00321AB0
	public int GetDefaultBackgroundCardId()
	{
		return ConfigCommonParamById.GetIntConfig("default_background_card").Value;
	}

	// Token: 0x170011B8 RID: 4536
	// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x003238CF File Offset: 0x00321ACF
	public static FriendConfig Instance
	{
		get
		{
			return FriendConfig._Instance;
		}
	}

	// Token: 0x0600D8BA RID: 55482 RVA: 0x003238D6 File Offset: 0x00321AD6
	public static FriendConfig GetOrCreateInstance()
	{
		if (FriendConfig._Instance == null)
		{
			FriendConfig.CreateInstance();
		}
		return FriendConfig._Instance;
	}

	// Token: 0x0600D8BB RID: 55483 RVA: 0x003238EA File Offset: 0x00321AEA
	public static bool CreateInstance()
	{
		if (FriendConfig._Instance != null)
		{
			return true;
		}
		FriendConfig._Instance = new FriendConfig();
		return true;
	}

	// Token: 0x0600D8BC RID: 55484 RVA: 0x00323900 File Offset: 0x00321B00
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D8BD RID: 55485 RVA: 0x00323902 File Offset: 0x00321B02
	public static void ResetStaticDefaultValue()
	{
		FriendConfig._Instance = null;
	}

	// Token: 0x0600D8BE RID: 55486 RVA: 0x0032390A File Offset: 0x00321B0A
	static FriendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendConfig.CreateStaticDefaultValue), new Action(FriendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040062D4 RID: 25300
	private readonly Comparison<int> SortProcessFunctionList = delegate(int a, int b)
	{
		PersonalTips? config = ConfigPersonalTipsById.GetConfig(a, true);
		PersonalTips? config2 = ConfigPersonalTipsById.GetConfig(b, true);
		return config.Value.Sort - config2.Value.Sort;
	};

	// Token: 0x040062D5 RID: 25301
	[Nullable(2)]
	private static FriendConfig _Instance;
}

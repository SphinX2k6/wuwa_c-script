using System;

// Token: 0x02002AD0 RID: 10960
public static class ESubDataLayerTypeExtensions
{
	// Token: 0x0601BCE8 RID: 113896 RVA: 0x00894C1C File Offset: 0x00892E1C
	public static string ToEnumString(this ESubDataLayerType value)
	{
		string result;
		switch (value)
		{
		case ESubDataLayerType.Default:
			result = "";
			break;
		case ESubDataLayerType.Cave:
			result = "DataLayerRuntime_EncloseSpaceSub";
			break;
		case ESubDataLayerType.Room:
			result = "DataLayerRuntime_EncloseSpaceSubRoom";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0601BCE9 RID: 113897 RVA: 0x00894C64 File Offset: 0x00892E64
	public static ESubDataLayerType FromString(string name)
	{
		ESubDataLayerType result;
		if (!ESubDataLayerTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ESubDataLayerType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCEA RID: 113898 RVA: 0x00894C90 File Offset: 0x00892E90
	public static bool TryFromString(string name, out ESubDataLayerType value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = ESubDataLayerType.Default;
			return false;
		}
		if (name != null && name.Length == 0)
		{
			value = ESubDataLayerType.Default;
			return true;
		}
		if (name == "DataLayerRuntime_EncloseSpaceSub")
		{
			value = ESubDataLayerType.Cave;
			return true;
		}
		if (!(name == "DataLayerRuntime_EncloseSpaceSubRoom"))
		{
			value = ESubDataLayerType.Default;
			return false;
		}
		value = ESubDataLayerType.Room;
		return true;
	}

	// Token: 0x0601BCEB RID: 113899 RVA: 0x00894CE4 File Offset: 0x00892EE4
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"",
			"DataLayerRuntime_EncloseSpaceSub",
			"DataLayerRuntime_EncloseSpaceSubRoom"
		};
	}

	// Token: 0x0601BCEC RID: 113900 RVA: 0x00894D04 File Offset: 0x00892F04
	public static ESubDataLayerType[] GetValues()
	{
		return new ESubDataLayerType[]
		{
			ESubDataLayerType.Default,
			ESubDataLayerType.Cave,
			ESubDataLayerType.Room
		};
	}

	// Token: 0x0601BCED RID: 113901 RVA: 0x00894D14 File Offset: 0x00892F14
	public static string[] GetNames()
	{
		return new string[]
		{
			"Default",
			"Cave",
			"Room"
		};
	}
}

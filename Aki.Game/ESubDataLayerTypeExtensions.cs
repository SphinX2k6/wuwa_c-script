using System;

// Token: 0x0200355B RID: 13659
public static class ESubDataLayerTypeExtensions
{
	// Token: 0x0601DFC0 RID: 122816 RVA: 0x0086CFBC File Offset: 0x0086B1BC
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

	// Token: 0x0601DFC1 RID: 122817 RVA: 0x0086D004 File Offset: 0x0086B204
	public static ESubDataLayerType FromString(string name)
	{
		ESubDataLayerType result;
		if (!ESubDataLayerTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ESubDataLayerType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601DFC2 RID: 122818 RVA: 0x0086D030 File Offset: 0x0086B230
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

	// Token: 0x0601DFC3 RID: 122819 RVA: 0x0086D084 File Offset: 0x0086B284
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"",
			"DataLayerRuntime_EncloseSpaceSub",
			"DataLayerRuntime_EncloseSpaceSubRoom"
		};
	}

	// Token: 0x0601DFC4 RID: 122820 RVA: 0x0086D0A4 File Offset: 0x0086B2A4
	public static ESubDataLayerType[] GetValues()
	{
		return new ESubDataLayerType[]
		{
			ESubDataLayerType.Default,
			ESubDataLayerType.Cave,
			ESubDataLayerType.Room
		};
	}

	// Token: 0x0601DFC5 RID: 122821 RVA: 0x0086D0B4 File Offset: 0x0086B2B4
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

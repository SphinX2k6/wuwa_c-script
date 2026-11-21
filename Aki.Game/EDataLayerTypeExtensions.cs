using System;

// Token: 0x02002ACE RID: 10958
public static class EDataLayerTypeExtensions
{
	// Token: 0x0601BCDF RID: 113887 RVA: 0x00894AC8 File Offset: 0x00892CC8
	public static string ToEnumString(this EDataLayerType value)
	{
		string result;
		switch (value)
		{
		case EDataLayerType.Default:
			result = "";
			break;
		case EDataLayerType.Cave:
			result = "DataLayerRuntime_EncloseSpace";
			break;
		case EDataLayerType.Room:
			result = "DataLayerRuntime_EncloseSpaceRoom";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0601BCE0 RID: 113888 RVA: 0x00894B10 File Offset: 0x00892D10
	public static EDataLayerType FromString(string name)
	{
		EDataLayerType result;
		if (!EDataLayerTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EDataLayerType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCE1 RID: 113889 RVA: 0x00894B3C File Offset: 0x00892D3C
	public static bool TryFromString(string name, out EDataLayerType value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = EDataLayerType.Default;
			return false;
		}
		if (name != null && name.Length == 0)
		{
			value = EDataLayerType.Default;
			return true;
		}
		if (name == "DataLayerRuntime_EncloseSpace")
		{
			value = EDataLayerType.Cave;
			return true;
		}
		if (!(name == "DataLayerRuntime_EncloseSpaceRoom"))
		{
			value = EDataLayerType.Default;
			return false;
		}
		value = EDataLayerType.Room;
		return true;
	}

	// Token: 0x0601BCE2 RID: 113890 RVA: 0x00894B90 File Offset: 0x00892D90
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"",
			"DataLayerRuntime_EncloseSpace",
			"DataLayerRuntime_EncloseSpaceRoom"
		};
	}

	// Token: 0x0601BCE3 RID: 113891 RVA: 0x00894BB0 File Offset: 0x00892DB0
	public static EDataLayerType[] GetValues()
	{
		return new EDataLayerType[]
		{
			EDataLayerType.Default,
			EDataLayerType.Cave,
			EDataLayerType.Room
		};
	}

	// Token: 0x0601BCE4 RID: 113892 RVA: 0x00894BC0 File Offset: 0x00892DC0
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

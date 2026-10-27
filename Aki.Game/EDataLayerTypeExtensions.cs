using System;

// Token: 0x02003559 RID: 13657
public static class EDataLayerTypeExtensions
{
	// Token: 0x0601DFB7 RID: 122807 RVA: 0x0086CE68 File Offset: 0x0086B068
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

	// Token: 0x0601DFB8 RID: 122808 RVA: 0x0086CEB0 File Offset: 0x0086B0B0
	public static EDataLayerType FromString(string name)
	{
		EDataLayerType result;
		if (!EDataLayerTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EDataLayerType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601DFB9 RID: 122809 RVA: 0x0086CEDC File Offset: 0x0086B0DC
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

	// Token: 0x0601DFBA RID: 122810 RVA: 0x0086CF30 File Offset: 0x0086B130
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"",
			"DataLayerRuntime_EncloseSpace",
			"DataLayerRuntime_EncloseSpaceRoom"
		};
	}

	// Token: 0x0601DFBB RID: 122811 RVA: 0x0086CF50 File Offset: 0x0086B150
	public static EDataLayerType[] GetValues()
	{
		return new EDataLayerType[]
		{
			EDataLayerType.Default,
			EDataLayerType.Cave,
			EDataLayerType.Room
		};
	}

	// Token: 0x0601DFBC RID: 122812 RVA: 0x0086CF60 File Offset: 0x0086B160
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

using System;

// Token: 0x0200010E RID: 270
public static class ELogLevelExtensions
{
	// Token: 0x060009FE RID: 2558 RVA: 0x00032BF8 File Offset: 0x00030DF8
	public static string ToEnumString(this ELogLevel value)
	{
		string result;
		switch (value)
		{
		case ELogLevel.Error:
			result = "Error";
			break;
		case ELogLevel.Warn:
			result = "Warn";
			break;
		case ELogLevel.Info:
			result = "Info";
			break;
		case ELogLevel.Debug:
			result = "Debug";
			break;
		case ELogLevel.Max:
			result = "Max";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00032C58 File Offset: 0x00030E58
	public static ELogLevel FromString(string name)
	{
		ELogLevel result;
		if (!ELogLevelExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ELogLevel 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00032C84 File Offset: 0x00030E84
	public static bool TryFromString(string name, out ELogLevel value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = ELogLevel.Error;
			return false;
		}
		if (name == "Error")
		{
			value = ELogLevel.Error;
			return true;
		}
		if (name == "Warn")
		{
			value = ELogLevel.Warn;
			return true;
		}
		if (name == "Info")
		{
			value = ELogLevel.Info;
			return true;
		}
		if (name == "Debug")
		{
			value = ELogLevel.Debug;
			return true;
		}
		if (!(name == "Max"))
		{
			value = ELogLevel.Error;
			return false;
		}
		value = ELogLevel.Max;
		return true;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00032CFE File Offset: 0x00030EFE
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"Error",
			"Warn",
			"Info",
			"Debug",
			"Max"
		};
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00032D2E File Offset: 0x00030F2E
	public static ELogLevel[] GetValues()
	{
		return new ELogLevel[]
		{
			ELogLevel.Error,
			ELogLevel.Warn,
			ELogLevel.Info,
			ELogLevel.Debug,
			ELogLevel.Max
		};
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00032D41 File Offset: 0x00030F41
	public static string[] GetNames()
	{
		return new string[]
		{
			"Error",
			"Warn",
			"Info",
			"Debug",
			"Max"
		};
	}
}

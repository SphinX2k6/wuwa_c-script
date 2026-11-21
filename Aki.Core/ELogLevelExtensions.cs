using System;

// Token: 0x0200010E RID: 270
public static class ELogLevelExtensions
{
	// Token: 0x06000A4F RID: 2639 RVA: 0x00033554 File Offset: 0x00031754
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

	// Token: 0x06000A50 RID: 2640 RVA: 0x000335B4 File Offset: 0x000317B4
	public static ELogLevel FromString(string name)
	{
		ELogLevel result;
		if (!ELogLevelExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ELogLevel 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x000335E0 File Offset: 0x000317E0
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

	// Token: 0x06000A52 RID: 2642 RVA: 0x0003365A File Offset: 0x0003185A
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

	// Token: 0x06000A53 RID: 2643 RVA: 0x0003368A File Offset: 0x0003188A
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

	// Token: 0x06000A54 RID: 2644 RVA: 0x0003369D File Offset: 0x0003189D
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

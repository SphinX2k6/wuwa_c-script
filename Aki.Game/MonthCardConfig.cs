using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200234C RID: 9036
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MonthCardConfig : ConfigBase
{
	// Token: 0x06011FBC RID: 73660 RVA: 0x00468D54 File Offset: 0x00466F54
	public MonthCardContent? GetConfig(int key)
	{
		MonthCardContent? config = ConfigMonthCardContentById.GetConfig(key, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取物品配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MonthCardConfig", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x17001789 RID: 6025
	// (get) Token: 0x06011FBD RID: 73661 RVA: 0x00468DA8 File Offset: 0x00466FA8
	public static MonthCardConfig Instance
	{
		get
		{
			return MonthCardConfig._Instance;
		}
	}

	// Token: 0x06011FBE RID: 73662 RVA: 0x00468DAF File Offset: 0x00466FAF
	public static MonthCardConfig GetOrCreateInstance()
	{
		if (MonthCardConfig._Instance == null)
		{
			MonthCardConfig.CreateInstance();
		}
		return MonthCardConfig._Instance;
	}

	// Token: 0x06011FBF RID: 73663 RVA: 0x00468DC3 File Offset: 0x00466FC3
	public static bool CreateInstance()
	{
		if (MonthCardConfig._Instance != null)
		{
			return true;
		}
		MonthCardConfig._Instance = new MonthCardConfig();
		return true;
	}

	// Token: 0x06011FC0 RID: 73664 RVA: 0x00468DD9 File Offset: 0x00466FD9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011FC1 RID: 73665 RVA: 0x00468DDB File Offset: 0x00466FDB
	public static void ResetStaticDefaultValue()
	{
		MonthCardConfig._Instance = null;
	}

	// Token: 0x06011FC2 RID: 73666 RVA: 0x00468DE3 File Offset: 0x00466FE3
	static MonthCardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardConfig.CreateStaticDefaultValue), new Action(MonthCardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040087E4 RID: 34788
	[Nullable(2)]
	private static MonthCardConfig _Instance;
}

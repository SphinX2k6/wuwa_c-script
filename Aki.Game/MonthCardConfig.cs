using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001831 RID: 6193
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MonthCardConfig : ConfigBase
{
	// Token: 0x0600F46C RID: 62572 RVA: 0x00475E1C File Offset: 0x0047401C
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

	// Token: 0x170017C3 RID: 6083
	// (get) Token: 0x0600F46D RID: 62573 RVA: 0x00475E70 File Offset: 0x00474070
	public static MonthCardConfig Instance
	{
		get
		{
			return MonthCardConfig._Instance;
		}
	}

	// Token: 0x0600F46E RID: 62574 RVA: 0x00475E77 File Offset: 0x00474077
	public static MonthCardConfig GetOrCreateInstance()
	{
		if (MonthCardConfig._Instance == null)
		{
			MonthCardConfig.CreateInstance();
		}
		return MonthCardConfig._Instance;
	}

	// Token: 0x0600F46F RID: 62575 RVA: 0x00475E8B File Offset: 0x0047408B
	public static bool CreateInstance()
	{
		if (MonthCardConfig._Instance != null)
		{
			return true;
		}
		MonthCardConfig._Instance = new MonthCardConfig();
		return true;
	}

	// Token: 0x0600F470 RID: 62576 RVA: 0x00475EA1 File Offset: 0x004740A1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F471 RID: 62577 RVA: 0x00475EA3 File Offset: 0x004740A3
	public static void ResetStaticDefaultValue()
	{
		MonthCardConfig._Instance = null;
	}

	// Token: 0x0600F472 RID: 62578 RVA: 0x00475EAB File Offset: 0x004740AB
	static MonthCardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardConfig.CreateStaticDefaultValue), new Action(MonthCardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008927 RID: 35111
	[Nullable(2)]
	private static MonthCardConfig _Instance;
}

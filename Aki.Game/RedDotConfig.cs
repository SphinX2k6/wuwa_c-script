using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200289C RID: 10396
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RedDotConfig : ConfigBase
{
	// Token: 0x0601A5E5 RID: 108005 RVA: 0x008285FE File Offset: 0x008267FE
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601A5E6 RID: 108006 RVA: 0x00828604 File Offset: 0x00826804
	public static Dictionary<ERedDotName, ERedDotName?> GetRelativeNameMap()
	{
		Dictionary<ERedDotName, ERedDotName?> dictionary = new Dictionary<ERedDotName, ERedDotName?>();
		foreach (RedDot redDot in ConfigRedDotByRelativeName.GetConfigList(true))
		{
			ERedDotName key;
			ERedDotName value;
			if (Enum.TryParse<ERedDotName>(redDot.Name, out key) && Enum.TryParse<ERedDotName>(redDot.RelativeName, out value))
			{
				dictionary.Add(key, new ERedDotName?(value));
			}
		}
		return dictionary;
	}

	// Token: 0x17002B3B RID: 11067
	// (get) Token: 0x0601A5E7 RID: 108007 RVA: 0x00828680 File Offset: 0x00826880
	public static RedDotConfig Instance
	{
		get
		{
			return RedDotConfig._Instance;
		}
	}

	// Token: 0x0601A5E8 RID: 108008 RVA: 0x00828687 File Offset: 0x00826887
	public static RedDotConfig GetOrCreateInstance()
	{
		if (RedDotConfig._Instance == null)
		{
			RedDotConfig.CreateInstance();
		}
		return RedDotConfig._Instance;
	}

	// Token: 0x0601A5E9 RID: 108009 RVA: 0x0082869B File Offset: 0x0082689B
	public static bool CreateInstance()
	{
		if (RedDotConfig._Instance != null)
		{
			return true;
		}
		RedDotConfig._Instance = new RedDotConfig();
		return true;
	}

	// Token: 0x0601A5EA RID: 108010 RVA: 0x008286B1 File Offset: 0x008268B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A5EB RID: 108011 RVA: 0x008286B3 File Offset: 0x008268B3
	public static void ResetStaticDefaultValue()
	{
		RedDotConfig._Instance = null;
	}

	// Token: 0x0601A5EC RID: 108012 RVA: 0x008286BB File Offset: 0x008268BB
	static RedDotConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotConfig.CreateStaticDefaultValue), new Action(RedDotConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E76E RID: 59246
	[Nullable(2)]
	private static RedDotConfig _Instance;
}

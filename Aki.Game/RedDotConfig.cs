using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200332A RID: 13098
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RedDotConfig : ConfigBase
{
	// Token: 0x0601C8ED RID: 116973 RVA: 0x0080205A File Offset: 0x0080025A
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601C8EE RID: 116974 RVA: 0x00802060 File Offset: 0x00800260
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

	// Token: 0x1700279F RID: 10143
	// (get) Token: 0x0601C8EF RID: 116975 RVA: 0x008020DC File Offset: 0x008002DC
	public static RedDotConfig Instance
	{
		get
		{
			return RedDotConfig._Instance;
		}
	}

	// Token: 0x0601C8F0 RID: 116976 RVA: 0x008020E3 File Offset: 0x008002E3
	public static RedDotConfig GetOrCreateInstance()
	{
		if (RedDotConfig._Instance == null)
		{
			RedDotConfig.CreateInstance();
		}
		return RedDotConfig._Instance;
	}

	// Token: 0x0601C8F1 RID: 116977 RVA: 0x008020F7 File Offset: 0x008002F7
	public static bool CreateInstance()
	{
		if (RedDotConfig._Instance != null)
		{
			return true;
		}
		RedDotConfig._Instance = new RedDotConfig();
		return true;
	}

	// Token: 0x0601C8F2 RID: 116978 RVA: 0x0080210D File Offset: 0x0080030D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C8F3 RID: 116979 RVA: 0x0080210F File Offset: 0x0080030F
	public static void ResetStaticDefaultValue()
	{
		RedDotConfig._Instance = null;
	}

	// Token: 0x0601C8F4 RID: 116980 RVA: 0x00802117 File Offset: 0x00800317
	static RedDotConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotConfig.CreateStaticDefaultValue), new Action(RedDotConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E2BE RID: 58046
	[Nullable(2)]
	private static RedDotConfig _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001312 RID: 4882
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HelpConfig : ConfigBase
{
	// Token: 0x0600C01A RID: 49178 RVA: 0x0038C396 File Offset: 0x0038A596
	[NullableContext(2)]
	public IReadOnlyList<HelpText> GetHelpContentInfoByGroupId(int groupId)
	{
		return ConfigHelpTextByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600C01B RID: 49179 RVA: 0x0038C3A0 File Offset: 0x0038A5A0
	public bool IsGroupIdValid(int groupId)
	{
		IReadOnlyList<HelpText> configList = ConfigHelpTextByGroupId.GetConfigList(groupId, true);
		return configList != null && configList.Count > 0;
	}

	// Token: 0x170012B1 RID: 4785
	// (get) Token: 0x0600C01C RID: 49180 RVA: 0x0038C3C3 File Offset: 0x0038A5C3
	public static HelpConfig Instance
	{
		get
		{
			return HelpConfig._Instance;
		}
	}

	// Token: 0x0600C01D RID: 49181 RVA: 0x0038C3CA File Offset: 0x0038A5CA
	public static HelpConfig GetOrCreateInstance()
	{
		if (HelpConfig._Instance == null)
		{
			HelpConfig.CreateInstance();
		}
		return HelpConfig._Instance;
	}

	// Token: 0x0600C01E RID: 49182 RVA: 0x0038C3DE File Offset: 0x0038A5DE
	public static bool CreateInstance()
	{
		if (HelpConfig._Instance != null)
		{
			return true;
		}
		HelpConfig._Instance = new HelpConfig();
		return true;
	}

	// Token: 0x0600C01F RID: 49183 RVA: 0x0038C3F4 File Offset: 0x0038A5F4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C020 RID: 49184 RVA: 0x0038C3F6 File Offset: 0x0038A5F6
	public static void ResetStaticDefaultValue()
	{
		HelpConfig._Instance = null;
	}

	// Token: 0x0600C021 RID: 49185 RVA: 0x0038C3FE File Offset: 0x0038A5FE
	static HelpConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpConfig.CreateStaticDefaultValue), new Action(HelpConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006E4E RID: 28238
	[Nullable(2)]
	private static HelpConfig _Instance;
}

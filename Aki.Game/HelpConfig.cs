using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E50 RID: 7760
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HelpConfig : ConfigBase
{
	// Token: 0x0600EBFB RID: 60411 RVA: 0x003806FE File Offset: 0x0037E8FE
	[NullableContext(2)]
	public IReadOnlyList<HelpText> GetHelpContentInfoByGroupId(int groupId)
	{
		return ConfigHelpTextByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600EBFC RID: 60412 RVA: 0x00380708 File Offset: 0x0037E908
	public bool IsGroupIdValid(int groupId)
	{
		IReadOnlyList<HelpText> configList = ConfigHelpTextByGroupId.GetConfigList(groupId, true);
		return configList != null && configList.Count > 0;
	}

	// Token: 0x17001287 RID: 4743
	// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x0038072B File Offset: 0x0037E92B
	public static HelpConfig Instance
	{
		get
		{
			return HelpConfig._Instance;
		}
	}

	// Token: 0x0600EBFE RID: 60414 RVA: 0x00380732 File Offset: 0x0037E932
	public static HelpConfig GetOrCreateInstance()
	{
		if (HelpConfig._Instance == null)
		{
			HelpConfig.CreateInstance();
		}
		return HelpConfig._Instance;
	}

	// Token: 0x0600EBFF RID: 60415 RVA: 0x00380746 File Offset: 0x0037E946
	public static bool CreateInstance()
	{
		if (HelpConfig._Instance != null)
		{
			return true;
		}
		HelpConfig._Instance = new HelpConfig();
		return true;
	}

	// Token: 0x0600EC00 RID: 60416 RVA: 0x0038075C File Offset: 0x0037E95C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EC01 RID: 60417 RVA: 0x0038075E File Offset: 0x0037E95E
	public static void ResetStaticDefaultValue()
	{
		HelpConfig._Instance = null;
	}

	// Token: 0x0600EC02 RID: 60418 RVA: 0x00380766 File Offset: 0x0037E966
	static HelpConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpConfig.CreateStaticDefaultValue), new Action(HelpConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006D6D RID: 28013
	[Nullable(2)]
	private static HelpConfig _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001543 RID: 5443
[NullableContext(1)]
[Nullable(0)]
public class LoadingConfig : ConfigBase
{
	// Token: 0x0600D9FB RID: 55803 RVA: 0x00409835 File Offset: 0x00407A35
	[NullableContext(2)]
	public IReadOnlyList<LoadingTipsText> GetLoadingTipsTextList(int levelAreaId)
	{
		return ConfigLoadingTipsTextByLevelAreaId.GetConfigList(levelAreaId, true);
	}

	// Token: 0x0600D9FC RID: 55804 RVA: 0x0040983E File Offset: 0x00407A3E
	public BroadcastImage? GetBroadcastImageConfig(int id)
	{
		return ConfigBroadcastImageById.GetConfig(id, true);
	}

	// Token: 0x0600D9FD RID: 55805 RVA: 0x00409847 File Offset: 0x00407A47
	[NullableContext(2)]
	public IReadOnlyList<LoadingLevelArea> GetLevelArea()
	{
		return ConfigLoadingLevelAreaAll.GetConfigList(true);
	}

	// Token: 0x0600D9FE RID: 55806 RVA: 0x0040984F File Offset: 0x00407A4F
	public LoadingLevelArea? GetLevelAreaById(int id)
	{
		return ConfigLoadingLevelAreaById.GetConfig(id, true);
	}

	// Token: 0x0600D9FF RID: 55807 RVA: 0x00409858 File Offset: 0x00407A58
	public int GetLoadingTipsTime()
	{
		return ConfigCommonParamById.GetIntConfig("loadingtips_time").GetValueOrDefault(1);
	}

	// Token: 0x1700145A RID: 5210
	// (get) Token: 0x0600DA00 RID: 55808 RVA: 0x00409878 File Offset: 0x00407A78
	public static LoadingConfig Instance
	{
		get
		{
			return LoadingConfig._Instance;
		}
	}

	// Token: 0x0600DA01 RID: 55809 RVA: 0x0040987F File Offset: 0x00407A7F
	public static LoadingConfig GetOrCreateInstance()
	{
		if (LoadingConfig._Instance == null)
		{
			LoadingConfig.CreateInstance();
		}
		return LoadingConfig._Instance;
	}

	// Token: 0x0600DA02 RID: 55810 RVA: 0x00409893 File Offset: 0x00407A93
	public static bool CreateInstance()
	{
		if (LoadingConfig._Instance != null)
		{
			return true;
		}
		LoadingConfig._Instance = new LoadingConfig();
		return true;
	}

	// Token: 0x0600DA03 RID: 55811 RVA: 0x004098A9 File Offset: 0x00407AA9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA04 RID: 55812 RVA: 0x004098AB File Offset: 0x00407AAB
	public static void ResetStaticDefaultValue()
	{
		LoadingConfig._Instance = null;
	}

	// Token: 0x0600DA05 RID: 55813 RVA: 0x004098B3 File Offset: 0x00407AB3
	static LoadingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingConfig.CreateStaticDefaultValue), new Action(LoadingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040079AF RID: 31151
	public int LoadingConfigRequestTimeoutMs = 3000;

	// Token: 0x040079B0 RID: 31152
	[Nullable(2)]
	private static LoadingConfig _Instance;
}

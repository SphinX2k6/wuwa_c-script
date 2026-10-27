using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002070 RID: 8304
[NullableContext(1)]
[Nullable(0)]
public class LoadingConfig : ConfigBase
{
	// Token: 0x06010593 RID: 66963 RVA: 0x003FD3ED File Offset: 0x003FB5ED
	[NullableContext(2)]
	public IReadOnlyList<LoadingTipsText> GetLoadingTipsTextList(int levelAreaId)
	{
		return ConfigLoadingTipsTextByLevelAreaId.GetConfigList(levelAreaId, true);
	}

	// Token: 0x06010594 RID: 66964 RVA: 0x003FD3F6 File Offset: 0x003FB5F6
	public BroadcastImage? GetBroadcastImageConfig(int id)
	{
		return ConfigBroadcastImageById.GetConfig(id, true);
	}

	// Token: 0x06010595 RID: 66965 RVA: 0x003FD3FF File Offset: 0x003FB5FF
	[NullableContext(2)]
	public IReadOnlyList<LoadingLevelArea> GetLevelArea()
	{
		return ConfigLoadingLevelAreaAll.GetConfigList(true);
	}

	// Token: 0x06010596 RID: 66966 RVA: 0x003FD407 File Offset: 0x003FB607
	public LoadingLevelArea? GetLevelAreaById(int id)
	{
		return ConfigLoadingLevelAreaById.GetConfig(id, true);
	}

	// Token: 0x06010597 RID: 66967 RVA: 0x003FD410 File Offset: 0x003FB610
	public int GetLoadingTipsTime()
	{
		return ConfigCommonParamById.GetIntConfig("loadingtips_time").GetValueOrDefault(1);
	}

	// Token: 0x1700142D RID: 5165
	// (get) Token: 0x06010598 RID: 66968 RVA: 0x003FD430 File Offset: 0x003FB630
	public static LoadingConfig Instance
	{
		get
		{
			return LoadingConfig._Instance;
		}
	}

	// Token: 0x06010599 RID: 66969 RVA: 0x003FD437 File Offset: 0x003FB637
	public static LoadingConfig GetOrCreateInstance()
	{
		if (LoadingConfig._Instance == null)
		{
			LoadingConfig.CreateInstance();
		}
		return LoadingConfig._Instance;
	}

	// Token: 0x0601059A RID: 66970 RVA: 0x003FD44B File Offset: 0x003FB64B
	public static bool CreateInstance()
	{
		if (LoadingConfig._Instance != null)
		{
			return true;
		}
		LoadingConfig._Instance = new LoadingConfig();
		return true;
	}

	// Token: 0x0601059B RID: 66971 RVA: 0x003FD461 File Offset: 0x003FB661
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601059C RID: 66972 RVA: 0x003FD463 File Offset: 0x003FB663
	public static void ResetStaticDefaultValue()
	{
		LoadingConfig._Instance = null;
	}

	// Token: 0x0601059D RID: 66973 RVA: 0x003FD46B File Offset: 0x003FB66B
	static LoadingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingConfig.CreateStaticDefaultValue), new Action(LoadingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040078C6 RID: 30918
	public int LoadingConfigRequestTimeoutMs = 3000;

	// Token: 0x040078C7 RID: 30919
	[Nullable(2)]
	private static LoadingConfig _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200165F RID: 5727
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class WuWuLogisticsConfig : ConfigBase
{
	// Token: 0x0600A183 RID: 41347 RVA: 0x0023A75E File Offset: 0x0023895E
	public IReadOnlyList<WuWuLogisticsDesc> GetDescListByGroupId(int groupId)
	{
		return ConfigWuWuLogisticsDescByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600A184 RID: 41348 RVA: 0x0023A767 File Offset: 0x00238967
	public WuWuLogisticsDesc? GetDescById(int id)
	{
		return ConfigWuWuLogisticsDescById.GetConfig(id, true);
	}

	// Token: 0x0600A185 RID: 41349 RVA: 0x0023A770 File Offset: 0x00238970
	public WuWuTaskPackage? GetTaskPackageById(int id)
	{
		return ConfigWuWuTaskPackageById.GetConfig(id, true);
	}

	// Token: 0x0600A186 RID: 41350 RVA: 0x0023A779 File Offset: 0x00238979
	public IReadOnlyList<WuWuTaskPackage> GetAllTaskPackage()
	{
		return ConfigWuWuTaskPackageAll.GetConfigList(true);
	}

	// Token: 0x0600A187 RID: 41351 RVA: 0x0023A781 File Offset: 0x00238981
	public WuWuWeekTask? GetWeekTaskById(int id)
	{
		return ConfigWuWuWeekTaskById.GetConfig(id, true);
	}

	// Token: 0x0600A188 RID: 41352 RVA: 0x0023A78A File Offset: 0x0023898A
	public IReadOnlyList<WuWuWeekTask> GetWeekTaskByWrapId(int wrapId)
	{
		return ConfigWuWuWeekTaskByWrapId.GetConfigList(wrapId, true);
	}

	// Token: 0x17000D9A RID: 3482
	// (get) Token: 0x0600A189 RID: 41353 RVA: 0x0023A793 File Offset: 0x00238993
	[Nullable(1)]
	public static WuWuLogisticsConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return WuWuLogisticsConfig._Instance;
		}
	}

	// Token: 0x0600A18A RID: 41354 RVA: 0x0023A79A File Offset: 0x0023899A
	[NullableContext(1)]
	public static WuWuLogisticsConfig GetOrCreateInstance()
	{
		if (WuWuLogisticsConfig._Instance == null)
		{
			WuWuLogisticsConfig.CreateInstance();
		}
		return WuWuLogisticsConfig._Instance;
	}

	// Token: 0x0600A18B RID: 41355 RVA: 0x0023A7AE File Offset: 0x002389AE
	public static bool CreateInstance()
	{
		if (WuWuLogisticsConfig._Instance != null)
		{
			return true;
		}
		WuWuLogisticsConfig._Instance = new WuWuLogisticsConfig();
		return true;
	}

	// Token: 0x0600A18C RID: 41356 RVA: 0x0023A7C4 File Offset: 0x002389C4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A18D RID: 41357 RVA: 0x0023A7C6 File Offset: 0x002389C6
	public static void ResetStaticDefaultValue()
	{
		WuWuLogisticsConfig._Instance = null;
	}

	// Token: 0x0600A18E RID: 41358 RVA: 0x0023A7CE File Offset: 0x002389CE
	static WuWuLogisticsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WuWuLogisticsConfig.CreateStaticDefaultValue), new Action(WuWuLogisticsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400496F RID: 18799
	private static WuWuLogisticsConfig _Instance;
}

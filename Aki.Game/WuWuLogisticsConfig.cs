using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000B17 RID: 2839
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class WuWuLogisticsConfig : ConfigBase
{
	// Token: 0x06007561 RID: 30049 RVA: 0x002445FA File Offset: 0x002427FA
	public IReadOnlyList<WuWuLogisticsDesc> GetDescListByGroupId(int groupId)
	{
		return ConfigWuWuLogisticsDescByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x00244603 File Offset: 0x00242803
	public WuWuLogisticsDesc? GetDescById(int id)
	{
		return ConfigWuWuLogisticsDescById.GetConfig(id, true);
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0024460C File Offset: 0x0024280C
	public WuWuTaskPackage? GetTaskPackageById(int id)
	{
		return ConfigWuWuTaskPackageById.GetConfig(id, true);
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x00244615 File Offset: 0x00242815
	public IReadOnlyList<WuWuTaskPackage> GetAllTaskPackage()
	{
		return ConfigWuWuTaskPackageAll.GetConfigList(true);
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x0024461D File Offset: 0x0024281D
	public WuWuWeekTask? GetWeekTaskById(int id)
	{
		return ConfigWuWuWeekTaskById.GetConfig(id, true);
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x00244626 File Offset: 0x00242826
	public IReadOnlyList<WuWuWeekTask> GetWeekTaskByWrapId(int wrapId)
	{
		return ConfigWuWuWeekTaskByWrapId.GetConfigList(wrapId, true);
	}

	// Token: 0x17000DBB RID: 3515
	// (get) Token: 0x06007567 RID: 30055 RVA: 0x0024462F File Offset: 0x0024282F
	[Nullable(1)]
	public static WuWuLogisticsConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return WuWuLogisticsConfig._Instance;
		}
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x00244636 File Offset: 0x00242836
	[NullableContext(1)]
	public static WuWuLogisticsConfig GetOrCreateInstance()
	{
		if (WuWuLogisticsConfig._Instance == null)
		{
			WuWuLogisticsConfig.CreateInstance();
		}
		return WuWuLogisticsConfig._Instance;
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x0024464A File Offset: 0x0024284A
	public static bool CreateInstance()
	{
		if (WuWuLogisticsConfig._Instance != null)
		{
			return true;
		}
		WuWuLogisticsConfig._Instance = new WuWuLogisticsConfig();
		return true;
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x00244660 File Offset: 0x00242860
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x00244662 File Offset: 0x00242862
	public static void ResetStaticDefaultValue()
	{
		WuWuLogisticsConfig._Instance = null;
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x0024466A File Offset: 0x0024286A
	static WuWuLogisticsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WuWuLogisticsConfig.CreateStaticDefaultValue), new Action(WuWuLogisticsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004A15 RID: 18965
	private static WuWuLogisticsConfig _Instance;
}

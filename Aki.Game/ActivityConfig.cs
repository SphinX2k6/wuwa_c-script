using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000572 RID: 1394
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityConfig : ConfigBase
{
	// Token: 0x06004321 RID: 17185 RVA: 0x0017427F File Offset: 0x0017247F
	public Activity? GetActivityConfig(int id)
	{
		return ConfigActivityById.GetConfig(id, true);
	}

	// Token: 0x06004322 RID: 17186 RVA: 0x00174288 File Offset: 0x00172488
	public ActivityFilter? GetActivityFilter(int id)
	{
		return ConfigActivityFilterById.GetConfig(id, true);
	}

	// Token: 0x06004323 RID: 17187 RVA: 0x00174291 File Offset: 0x00172491
	[NullableContext(2)]
	public IReadOnlyList<ActivityFilter> GetAllActivityFilter()
	{
		return ConfigActivityFilterAll.GetConfigList(true);
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x00174299 File Offset: 0x00172499
	[NullableContext(2)]
	public IReadOnlyList<ActivityPermanentFilter> GetAllActivityPermanentFilter()
	{
		return ConfigActivityPermanentFilterAll.GetConfigList(true);
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x001742A1 File Offset: 0x001724A1
	public ActivityTitleTags? GetActivityTitleTags(int id)
	{
		return ConfigActivityTitleTagsById.GetConfig(id, true);
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x001742AA File Offset: 0x001724AA
	public ActivityTimeShow? GetActivityTimeShow(int id)
	{
		return ConfigActivityTimeShowById.GetConfig(id, true);
	}

	// Token: 0x06004327 RID: 17191 RVA: 0x001742B3 File Offset: 0x001724B3
	[NullableContext(2)]
	public IReadOnlyList<ActivitySplitPak> GetActivitySplitPakAll()
	{
		return ConfigActivitySplitPakAll.GetConfigList(true);
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x001742BC File Offset: 0x001724BC
	public Dictionary<int, string> GetActivityTypeStringMap()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		IReadOnlyList<ActivitySplitPak> configList = ConfigActivitySplitPakAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (ActivitySplitPak activitySplitPak in configList)
			{
				if (activitySplitPak.ActivityTypeString != null)
				{
					dictionary[activitySplitPak.ActivityType] = activitySplitPak.ActivityTypeString;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x17000992 RID: 2450
	// (get) Token: 0x06004329 RID: 17193 RVA: 0x0017432C File Offset: 0x0017252C
	public static ActivityConfig Instance
	{
		get
		{
			return ActivityConfig._Instance;
		}
	}

	// Token: 0x0600432A RID: 17194 RVA: 0x00174333 File Offset: 0x00172533
	public static ActivityConfig GetOrCreateInstance()
	{
		if (ActivityConfig._Instance == null)
		{
			ActivityConfig.CreateInstance();
		}
		return ActivityConfig._Instance;
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x00174347 File Offset: 0x00172547
	public static bool CreateInstance()
	{
		if (ActivityConfig._Instance != null)
		{
			return true;
		}
		ActivityConfig._Instance = new ActivityConfig();
		return true;
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x0017435D File Offset: 0x0017255D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x0017435F File Offset: 0x0017255F
	public static void ResetStaticDefaultValue()
	{
		ActivityConfig._Instance = null;
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x00174367 File Offset: 0x00172567
	static ActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityConfig.CreateStaticDefaultValue), new Action(ActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003475 RID: 13429
	[Nullable(2)]
	private static ActivityConfig _Instance;
}

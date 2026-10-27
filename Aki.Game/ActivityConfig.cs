using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010BE RID: 4286
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityConfig : ConfigBase
{
	// Token: 0x06006F8B RID: 28555 RVA: 0x0016B907 File Offset: 0x00169B07
	public Activity? GetActivityConfig(int id)
	{
		return ConfigActivityById.GetConfig(id, true);
	}

	// Token: 0x06006F8C RID: 28556 RVA: 0x0016B910 File Offset: 0x00169B10
	public ActivityFilter? GetActivityFilter(int id)
	{
		return ConfigActivityFilterById.GetConfig(id, true);
	}

	// Token: 0x06006F8D RID: 28557 RVA: 0x0016B919 File Offset: 0x00169B19
	[NullableContext(2)]
	public IReadOnlyList<ActivityFilter> GetAllActivityFilter()
	{
		return ConfigActivityFilterAll.GetConfigList(true);
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x0016B921 File Offset: 0x00169B21
	[NullableContext(2)]
	public IReadOnlyList<ActivityPermanentFilter> GetAllActivityPermanentFilter()
	{
		return ConfigActivityPermanentFilterAll.GetConfigList(true);
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x0016B929 File Offset: 0x00169B29
	public ActivityTitleTags? GetActivityTitleTags(int id)
	{
		return ConfigActivityTitleTagsById.GetConfig(id, true);
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x0016B932 File Offset: 0x00169B32
	public ActivityTimeShow? GetActivityTimeShow(int id)
	{
		return ConfigActivityTimeShowById.GetConfig(id, true);
	}

	// Token: 0x06006F91 RID: 28561 RVA: 0x0016B93B File Offset: 0x00169B3B
	[NullableContext(2)]
	public IReadOnlyList<ActivitySplitPak> GetActivitySplitPakAll()
	{
		return ConfigActivitySplitPakAll.GetConfigList(true);
	}

	// Token: 0x06006F92 RID: 28562 RVA: 0x0016B944 File Offset: 0x00169B44
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

	// Token: 0x17000972 RID: 2418
	// (get) Token: 0x06006F93 RID: 28563 RVA: 0x0016B9B4 File Offset: 0x00169BB4
	public static ActivityConfig Instance
	{
		get
		{
			return ActivityConfig._Instance;
		}
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x0016B9BB File Offset: 0x00169BBB
	public static ActivityConfig GetOrCreateInstance()
	{
		if (ActivityConfig._Instance == null)
		{
			ActivityConfig.CreateInstance();
		}
		return ActivityConfig._Instance;
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x0016B9CF File Offset: 0x00169BCF
	public static bool CreateInstance()
	{
		if (ActivityConfig._Instance != null)
		{
			return true;
		}
		ActivityConfig._Instance = new ActivityConfig();
		return true;
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x0016B9E5 File Offset: 0x00169BE5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x0016B9E7 File Offset: 0x00169BE7
	public static void ResetStaticDefaultValue()
	{
		ActivityConfig._Instance = null;
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x0016B9EF File Offset: 0x00169BEF
	static ActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityConfig.CreateStaticDefaultValue), new Action(ActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040033DC RID: 13276
	[Nullable(2)]
	private static ActivityConfig _Instance;
}

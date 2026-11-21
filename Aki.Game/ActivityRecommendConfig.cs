using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000545 RID: 1349
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRecommendConfig : ConfigBase
{
	// Token: 0x06004202 RID: 16898 RVA: 0x00170EB9 File Offset: 0x0016F0B9
	public ActivityRecommend? GetRecommend(int id)
	{
		return ConfigActivityRecommendById.GetConfig(id, true);
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x00170EC4 File Offset: 0x0016F0C4
	public List<ActivityRecommend> GetRecommendByType(EActivityRecommendType type)
	{
		IEnumerable<ActivityRecommend> enumerable = ConfigActivityRecommendAll.GetConfigList(true) ?? new List<ActivityRecommend>();
		List<ActivityRecommend> list = new List<ActivityRecommend>();
		foreach (ActivityRecommend item in enumerable)
		{
			if (item.Type == (int)type)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00170F2C File Offset: 0x0016F12C
	public IReadOnlyList<ActivityRecommend> GetRecommendListByGroup(int groupId)
	{
		return ConfigActivityRecommendByActivityGroup.GetConfigList(groupId, true) ?? new List<ActivityRecommend>();
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00170F40 File Offset: 0x0016F140
	public int GetCurrentGroupId()
	{
		if (ConfigActivityRecommendCurrentById.GetConfig(1, true) == null)
		{
			return 0;
		}
		ActivityRecommendCurrent? activityRecommendCurrent;
		return activityRecommendCurrent.GetValueOrDefault().ActivityGroup;
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00170F6F File Offset: 0x0016F16F
	public ActivityRecommendCurrent? GetCurrentRecord(int id)
	{
		return ConfigActivityRecommendCurrentById.GetConfig(id, true);
	}

	// Token: 0x17000944 RID: 2372
	// (get) Token: 0x06004207 RID: 16903 RVA: 0x00170F78 File Offset: 0x0016F178
	public static ActivityRecommendConfig Instance
	{
		get
		{
			return ActivityRecommendConfig._Instance;
		}
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x00170F7F File Offset: 0x0016F17F
	public static ActivityRecommendConfig GetOrCreateInstance()
	{
		if (ActivityRecommendConfig._Instance == null)
		{
			ActivityRecommendConfig.CreateInstance();
		}
		return ActivityRecommendConfig._Instance;
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x00170F93 File Offset: 0x0016F193
	public static bool CreateInstance()
	{
		if (ActivityRecommendConfig._Instance != null)
		{
			return true;
		}
		ActivityRecommendConfig._Instance = new ActivityRecommendConfig();
		return true;
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x00170FA9 File Offset: 0x0016F1A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x00170FAB File Offset: 0x0016F1AB
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendConfig._Instance = null;
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x00170FB3 File Offset: 0x0016F1B3
	static ActivityRecommendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendConfig.CreateStaticDefaultValue), new Action(ActivityRecommendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040033BB RID: 13243
	[Nullable(2)]
	private static ActivityRecommendConfig _Instance;
}

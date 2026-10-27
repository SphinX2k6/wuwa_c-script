using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001091 RID: 4241
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRecommendConfig : ConfigBase
{
	// Token: 0x06006E6D RID: 28269 RVA: 0x00168585 File Offset: 0x00166785
	public ActivityRecommend? GetRecommend(int id)
	{
		return ConfigActivityRecommendById.GetConfig(id, true);
	}

	// Token: 0x06006E6E RID: 28270 RVA: 0x00168590 File Offset: 0x00166790
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

	// Token: 0x06006E6F RID: 28271 RVA: 0x001685F8 File Offset: 0x001667F8
	public IReadOnlyList<ActivityRecommend> GetRecommendListByGroup(int groupId)
	{
		return ConfigActivityRecommendByActivityGroup.GetConfigList(groupId, true) ?? new List<ActivityRecommend>();
	}

	// Token: 0x06006E70 RID: 28272 RVA: 0x0016860C File Offset: 0x0016680C
	public int GetCurrentGroupId()
	{
		if (ConfigActivityRecommendCurrentById.GetConfig(1, true) == null)
		{
			return 0;
		}
		ActivityRecommendCurrent? activityRecommendCurrent;
		return activityRecommendCurrent.GetValueOrDefault().ActivityGroup;
	}

	// Token: 0x06006E71 RID: 28273 RVA: 0x0016863B File Offset: 0x0016683B
	public ActivityRecommendCurrent? GetCurrentRecord(int id)
	{
		return ConfigActivityRecommendCurrentById.GetConfig(id, true);
	}

	// Token: 0x17000924 RID: 2340
	// (get) Token: 0x06006E72 RID: 28274 RVA: 0x00168644 File Offset: 0x00166844
	public static ActivityRecommendConfig Instance
	{
		get
		{
			return ActivityRecommendConfig._Instance;
		}
	}

	// Token: 0x06006E73 RID: 28275 RVA: 0x0016864B File Offset: 0x0016684B
	public static ActivityRecommendConfig GetOrCreateInstance()
	{
		if (ActivityRecommendConfig._Instance == null)
		{
			ActivityRecommendConfig.CreateInstance();
		}
		return ActivityRecommendConfig._Instance;
	}

	// Token: 0x06006E74 RID: 28276 RVA: 0x0016865F File Offset: 0x0016685F
	public static bool CreateInstance()
	{
		if (ActivityRecommendConfig._Instance != null)
		{
			return true;
		}
		ActivityRecommendConfig._Instance = new ActivityRecommendConfig();
		return true;
	}

	// Token: 0x06006E75 RID: 28277 RVA: 0x00168675 File Offset: 0x00166875
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E76 RID: 28278 RVA: 0x00168677 File Offset: 0x00166877
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendConfig._Instance = null;
	}

	// Token: 0x06006E77 RID: 28279 RVA: 0x0016867F File Offset: 0x0016687F
	static ActivityRecommendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendConfig.CreateStaticDefaultValue), new Action(ActivityRecommendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003322 RID: 13090
	[Nullable(2)]
	private static ActivityRecommendConfig _Instance;
}

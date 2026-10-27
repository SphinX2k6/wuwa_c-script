using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001396 RID: 5014
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewbieCourseV2Config : ConfigBase
{
	// Token: 0x06008C89 RID: 35977 RVA: 0x001E2300 File Offset: 0x001E0500
	public IReadOnlyList<NewbieCourseV2> GetConfigList(int activityId = 0)
	{
		IReadOnlyList<NewbieCourseV2> configList = ConfigNewbieCourseV2All.GetConfigList(true);
		List<NewbieCourseV2> list = ((configList != null) ? configList.ToList<NewbieCourseV2>() : null) ?? new List<NewbieCourseV2>();
		if (activityId > 0)
		{
			List<NewbieCourseV2> list2 = (from config in list
			where config.ActivityId == activityId
			select config).ToList<NewbieCourseV2>();
			list = ((list2.Count > 0) ? list2 : list);
		}
		return (from config in list
		orderby config.TargetLevel, config.Id
		select config).ToList<NewbieCourseV2>();
	}

	// Token: 0x06008C8A RID: 35978 RVA: 0x001E23B4 File Offset: 0x001E05B4
	public ItemData[] GetRewardList(int dropId)
	{
		DropPackage? dropPackage;
		Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		List<ItemData> list = new List<ItemData>();
		if (dictionary == null)
		{
			return list.ToArray();
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			ItemData item = new ItemData
			{
				ItemId = keyValuePair.Key,
				Count = keyValuePair.Value
			};
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008C8B RID: 35979 RVA: 0x001E2464 File Offset: 0x001E0664
	public int[] GetWeaponPreviewIdsForActivity(int activityId)
	{
		List<int> list = new List<int>();
		foreach (NewbieCourseV2 config in this.GetConfigList(activityId))
		{
			foreach (int item in ActivityNewbieCourseV2Config.ReadWeaponPreviewList(config))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06008C8C RID: 35980 RVA: 0x001E24F4 File Offset: 0x001E06F4
	private static IEnumerable<int> ReadWeaponPreviewList(NewbieCourseV2 config)
	{
		ActivityNewbieCourseV2Config.<ReadWeaponPreviewList>d__3 <ReadWeaponPreviewList>d__ = new ActivityNewbieCourseV2Config.<ReadWeaponPreviewList>d__3(-2);
		<ReadWeaponPreviewList>d__.<>3__config = config;
		return <ReadWeaponPreviewList>d__;
	}

	// Token: 0x17000BE1 RID: 3041
	// (get) Token: 0x06008C8D RID: 35981 RVA: 0x001E2504 File Offset: 0x001E0704
	public static ActivityNewbieCourseV2Config Instance
	{
		get
		{
			return ActivityNewbieCourseV2Config._Instance;
		}
	}

	// Token: 0x06008C8E RID: 35982 RVA: 0x001E250B File Offset: 0x001E070B
	public static ActivityNewbieCourseV2Config GetOrCreateInstance()
	{
		if (ActivityNewbieCourseV2Config._Instance == null)
		{
			ActivityNewbieCourseV2Config.CreateInstance();
		}
		return ActivityNewbieCourseV2Config._Instance;
	}

	// Token: 0x06008C8F RID: 35983 RVA: 0x001E251F File Offset: 0x001E071F
	public static bool CreateInstance()
	{
		if (ActivityNewbieCourseV2Config._Instance != null)
		{
			return true;
		}
		ActivityNewbieCourseV2Config._Instance = new ActivityNewbieCourseV2Config();
		return true;
	}

	// Token: 0x06008C90 RID: 35984 RVA: 0x001E2535 File Offset: 0x001E0735
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008C91 RID: 35985 RVA: 0x001E2537 File Offset: 0x001E0737
	public static void ResetStaticDefaultValue()
	{
		ActivityNewbieCourseV2Config._Instance = null;
	}

	// Token: 0x06008C92 RID: 35986 RVA: 0x001E253F File Offset: 0x001E073F
	static ActivityNewbieCourseV2Config()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewbieCourseV2Config.CreateStaticDefaultValue), new Action(ActivityNewbieCourseV2Config.ResetStaticDefaultValue));
	}

	// Token: 0x04003E62 RID: 15970
	[Nullable(2)]
	private static ActivityNewbieCourseV2Config _Instance;
}

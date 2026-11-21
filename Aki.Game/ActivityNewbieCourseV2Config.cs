using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200084A RID: 2122
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewbieCourseV2Config : ConfigBase
{
	// Token: 0x06006024 RID: 24612 RVA: 0x001EB154 File Offset: 0x001E9354
	public IReadOnlyList<NewbieCourseV2> GetConfigList(int activityId = 0)
	{
		IReadOnlyList<NewbieCourseV2> readOnlyList = ConfigNewbieCourseV2All.GetConfigList(true) ?? Array.Empty<NewbieCourseV2>();
		if (activityId > 0)
		{
			List<NewbieCourseV2> list = new List<NewbieCourseV2>();
			foreach (NewbieCourseV2 item in readOnlyList)
			{
				if (item.ActivityId == activityId)
				{
					list.Add(item);
				}
			}
			IReadOnlyList<NewbieCourseV2> readOnlyList2;
			if (list.Count <= 0)
			{
				readOnlyList2 = readOnlyList;
			}
			else
			{
				IReadOnlyList<NewbieCourseV2> readOnlyList3 = list;
				readOnlyList2 = readOnlyList3;
			}
			readOnlyList = readOnlyList2;
		}
		return NoLinq.OrderByThenByToList<NewbieCourseV2, int, int>(readOnlyList, (NewbieCourseV2 config) => config.TargetLevel, (NewbieCourseV2 config) => config.Id);
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x001EB218 File Offset: 0x001E9418
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

	// Token: 0x06006026 RID: 24614 RVA: 0x001EB2C8 File Offset: 0x001E94C8
	public int[] GetWeaponPreviewIdsForActivity(int activityId)
	{
		List<int> list = new List<int>();
		foreach (NewbieCourseV2 newbieCourseV in this.GetConfigList(activityId))
		{
			list.AddRange(newbieCourseV.GetWeaponPreviewListBytes());
		}
		return list.ToArray();
	}

	// Token: 0x17000C01 RID: 3073
	// (get) Token: 0x06006027 RID: 24615 RVA: 0x001EB330 File Offset: 0x001E9530
	public static ActivityNewbieCourseV2Config Instance
	{
		get
		{
			return ActivityNewbieCourseV2Config._Instance;
		}
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x001EB337 File Offset: 0x001E9537
	public static ActivityNewbieCourseV2Config GetOrCreateInstance()
	{
		if (ActivityNewbieCourseV2Config._Instance == null)
		{
			ActivityNewbieCourseV2Config.CreateInstance();
		}
		return ActivityNewbieCourseV2Config._Instance;
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x001EB34B File Offset: 0x001E954B
	public static bool CreateInstance()
	{
		if (ActivityNewbieCourseV2Config._Instance != null)
		{
			return true;
		}
		ActivityNewbieCourseV2Config._Instance = new ActivityNewbieCourseV2Config();
		return true;
	}

	// Token: 0x0600602A RID: 24618 RVA: 0x001EB361 File Offset: 0x001E9561
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600602B RID: 24619 RVA: 0x001EB363 File Offset: 0x001E9563
	public static void ResetStaticDefaultValue()
	{
		ActivityNewbieCourseV2Config._Instance = null;
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x001EB36B File Offset: 0x001E956B
	static ActivityNewbieCourseV2Config()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewbieCourseV2Config.CreateStaticDefaultValue), new Action(ActivityNewbieCourseV2Config.ResetStaticDefaultValue));
	}

	// Token: 0x04003EFA RID: 16122
	[Nullable(2)]
	private static ActivityNewbieCourseV2Config _Instance;
}

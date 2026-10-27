using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x020013D3 RID: 5075
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNoviceJourneyConfig : ConfigBase
{
	// Token: 0x06008F30 RID: 36656 RVA: 0x001EF3D1 File Offset: 0x001ED5D1
	[NullableContext(2)]
	public NewbieCourse[] GetNoticeJourneyConfigList()
	{
		return ConfigNewbieCourseAll.GetConfigList(true).ToArray<NewbieCourse>();
	}

	// Token: 0x06008F31 RID: 36657 RVA: 0x001EF3E0 File Offset: 0x001ED5E0
	public IItemData[] GetRewardList(int dropId)
	{
		DropPackage? dropPackage;
		Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		List<IItemData> list = new List<IItemData>();
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				ItemData item = new ItemData
				{
					ItemId = keyValuePair.Key,
					Count = keyValuePair.Value
				};
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x17000C02 RID: 3074
	// (get) Token: 0x06008F32 RID: 36658 RVA: 0x001EF48C File Offset: 0x001ED68C
	public static ActivityNoviceJourneyConfig Instance
	{
		get
		{
			return ActivityNoviceJourneyConfig._Instance;
		}
	}

	// Token: 0x06008F33 RID: 36659 RVA: 0x001EF493 File Offset: 0x001ED693
	public static ActivityNoviceJourneyConfig GetOrCreateInstance()
	{
		if (ActivityNoviceJourneyConfig._Instance == null)
		{
			ActivityNoviceJourneyConfig.CreateInstance();
		}
		return ActivityNoviceJourneyConfig._Instance;
	}

	// Token: 0x06008F34 RID: 36660 RVA: 0x001EF4A7 File Offset: 0x001ED6A7
	public static bool CreateInstance()
	{
		if (ActivityNoviceJourneyConfig._Instance != null)
		{
			return true;
		}
		ActivityNoviceJourneyConfig._Instance = new ActivityNoviceJourneyConfig();
		return true;
	}

	// Token: 0x06008F35 RID: 36661 RVA: 0x001EF4BD File Offset: 0x001ED6BD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008F36 RID: 36662 RVA: 0x001EF4BF File Offset: 0x001ED6BF
	public static void ResetStaticDefaultValue()
	{
		ActivityNoviceJourneyConfig._Instance = null;
	}

	// Token: 0x06008F37 RID: 36663 RVA: 0x001EF4C7 File Offset: 0x001ED6C7
	static ActivityNoviceJourneyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNoviceJourneyConfig.CreateStaticDefaultValue), new Action(ActivityNoviceJourneyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003F66 RID: 16230
	[Nullable(2)]
	private static ActivityNoviceJourneyConfig _Instance;
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000887 RID: 2183
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNoviceJourneyConfig : ConfigBase
{
	// Token: 0x060062C5 RID: 25285 RVA: 0x001F7EF1 File Offset: 0x001F60F1
	[NullableContext(2)]
	public NewbieCourse[] GetNoticeJourneyConfigList()
	{
		return ConfigNewbieCourseAll.GetConfigList(true).ToArray<NewbieCourse>();
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x001F7F00 File Offset: 0x001F6100
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

	// Token: 0x17000C22 RID: 3106
	// (get) Token: 0x060062C7 RID: 25287 RVA: 0x001F7FAC File Offset: 0x001F61AC
	public static ActivityNoviceJourneyConfig Instance
	{
		get
		{
			return ActivityNoviceJourneyConfig._Instance;
		}
	}

	// Token: 0x060062C8 RID: 25288 RVA: 0x001F7FB3 File Offset: 0x001F61B3
	public static ActivityNoviceJourneyConfig GetOrCreateInstance()
	{
		if (ActivityNoviceJourneyConfig._Instance == null)
		{
			ActivityNoviceJourneyConfig.CreateInstance();
		}
		return ActivityNoviceJourneyConfig._Instance;
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x001F7FC7 File Offset: 0x001F61C7
	public static bool CreateInstance()
	{
		if (ActivityNoviceJourneyConfig._Instance != null)
		{
			return true;
		}
		ActivityNoviceJourneyConfig._Instance = new ActivityNoviceJourneyConfig();
		return true;
	}

	// Token: 0x060062CA RID: 25290 RVA: 0x001F7FDD File Offset: 0x001F61DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x001F7FDF File Offset: 0x001F61DF
	public static void ResetStaticDefaultValue()
	{
		ActivityNoviceJourneyConfig._Instance = null;
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x001F7FE7 File Offset: 0x001F61E7
	static ActivityNoviceJourneyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNoviceJourneyConfig.CreateStaticDefaultValue), new Action(ActivityNoviceJourneyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003FFE RID: 16382
	[Nullable(2)]
	private static ActivityNoviceJourneyConfig _Instance;
}

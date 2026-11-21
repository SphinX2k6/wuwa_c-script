using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000989 RID: 2441
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRunConfig : ConfigBase
{
	// Token: 0x06006B38 RID: 27448 RVA: 0x00215338 File Offset: 0x00213538
	public ParkourChallenge GetActivityRunChallengeConfig(int id)
	{
		return ConfigParkourChallengeById.GetConfig(id, true).Value;
	}

	// Token: 0x06006B39 RID: 27449 RVA: 0x00215354 File Offset: 0x00213554
	public string GetActivityRunTitle(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetActivityRunChallengeConfig(id).Title, null) ?? "";
	}

	// Token: 0x06006B3A RID: 27450 RVA: 0x00215380 File Offset: 0x00213580
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	public Dictionary<int, ValueTuple<int, int>> GetActivityRunScoreMap(int id)
	{
		ParkourChallenge activityRunChallengeConfig = this.GetActivityRunChallengeConfig(id);
		Dictionary<int, ValueTuple<int, int>> dictionary = new Dictionary<int, ValueTuple<int, int>>();
		int num = 0;
		if (activityRunChallengeConfig.RewardListLength != 0)
		{
			for (int i = 0; i < activityRunChallengeConfig.RewardListLength; i++)
			{
				IntPair value = activityRunChallengeConfig.RewardList(i).Value;
				int item = value.Item1;
				int item2 = value.Item2;
				dictionary.Add(num, new ValueTuple<int, int>(item, item2));
				num++;
			}
		}
		return dictionary;
	}

	// Token: 0x06006B3B RID: 27451 RVA: 0x002153F4 File Offset: 0x002135F4
	public int GetActivityRunMarkId(int id)
	{
		return this.GetActivityRunChallengeConfig(id).MarkId;
	}

	// Token: 0x06006B3C RID: 27452 RVA: 0x00215410 File Offset: 0x00213610
	public string GetActivityRunTexture(int id)
	{
		return this.GetActivityRunChallengeConfig(id).BackGroundTexture;
	}

	// Token: 0x17000D31 RID: 3377
	// (get) Token: 0x06006B3D RID: 27453 RVA: 0x0021542C File Offset: 0x0021362C
	public static ActivityRunConfig Instance
	{
		get
		{
			return ActivityRunConfig._Instance;
		}
	}

	// Token: 0x06006B3E RID: 27454 RVA: 0x00215433 File Offset: 0x00213633
	public static ActivityRunConfig GetOrCreateInstance()
	{
		if (ActivityRunConfig._Instance == null)
		{
			ActivityRunConfig.CreateInstance();
		}
		return ActivityRunConfig._Instance;
	}

	// Token: 0x06006B3F RID: 27455 RVA: 0x00215447 File Offset: 0x00213647
	public static bool CreateInstance()
	{
		if (ActivityRunConfig._Instance != null)
		{
			return true;
		}
		ActivityRunConfig._Instance = new ActivityRunConfig();
		return true;
	}

	// Token: 0x06006B40 RID: 27456 RVA: 0x0021545D File Offset: 0x0021365D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006B41 RID: 27457 RVA: 0x0021545F File Offset: 0x0021365F
	public static void ResetStaticDefaultValue()
	{
		ActivityRunConfig._Instance = null;
	}

	// Token: 0x06006B42 RID: 27458 RVA: 0x00215467 File Offset: 0x00213667
	static ActivityRunConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunConfig.CreateStaticDefaultValue), new Action(ActivityRunConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004350 RID: 17232
	[Nullable(2)]
	private static ActivityRunConfig _Instance;
}

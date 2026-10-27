using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014D1 RID: 5329
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRunConfig : ConfigBase
{
	// Token: 0x0600975E RID: 38750 RVA: 0x0020B5F8 File Offset: 0x002097F8
	public ParkourChallenge GetActivityRunChallengeConfig(int id)
	{
		return ConfigParkourChallengeById.GetConfig(id, true).Value;
	}

	// Token: 0x0600975F RID: 38751 RVA: 0x0020B614 File Offset: 0x00209814
	public string GetActivityRunTitle(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetActivityRunChallengeConfig(id).Title, null) ?? "";
	}

	// Token: 0x06009760 RID: 38752 RVA: 0x0020B640 File Offset: 0x00209840
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

	// Token: 0x06009761 RID: 38753 RVA: 0x0020B6B4 File Offset: 0x002098B4
	public int GetActivityRunMarkId(int id)
	{
		return this.GetActivityRunChallengeConfig(id).MarkId;
	}

	// Token: 0x06009762 RID: 38754 RVA: 0x0020B6D0 File Offset: 0x002098D0
	public string GetActivityRunTexture(int id)
	{
		return this.GetActivityRunChallengeConfig(id).BackGroundTexture;
	}

	// Token: 0x17000D10 RID: 3344
	// (get) Token: 0x06009763 RID: 38755 RVA: 0x0020B6EC File Offset: 0x002098EC
	public static ActivityRunConfig Instance
	{
		get
		{
			return ActivityRunConfig._Instance;
		}
	}

	// Token: 0x06009764 RID: 38756 RVA: 0x0020B6F3 File Offset: 0x002098F3
	public static ActivityRunConfig GetOrCreateInstance()
	{
		if (ActivityRunConfig._Instance == null)
		{
			ActivityRunConfig.CreateInstance();
		}
		return ActivityRunConfig._Instance;
	}

	// Token: 0x06009765 RID: 38757 RVA: 0x0020B707 File Offset: 0x00209907
	public static bool CreateInstance()
	{
		if (ActivityRunConfig._Instance != null)
		{
			return true;
		}
		ActivityRunConfig._Instance = new ActivityRunConfig();
		return true;
	}

	// Token: 0x06009766 RID: 38758 RVA: 0x0020B71D File Offset: 0x0020991D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009767 RID: 38759 RVA: 0x0020B71F File Offset: 0x0020991F
	public static void ResetStaticDefaultValue()
	{
		ActivityRunConfig._Instance = null;
	}

	// Token: 0x06009768 RID: 38760 RVA: 0x0020B727 File Offset: 0x00209927
	static ActivityRunConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunConfig.CreateStaticDefaultValue), new Action(ActivityRunConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040042AB RID: 17067
	[Nullable(2)]
	private static ActivityRunConfig _Instance;
}

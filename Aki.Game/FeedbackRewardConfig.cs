using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AD2 RID: 6866
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FeedbackRewardConfig : ConfigBase
{
	// Token: 0x0600CBB4 RID: 52148 RVA: 0x002E8041 File Offset: 0x002E6241
	public GivebackScoreReward? GetGivebackScoreRewardById(int id)
	{
		return ConfigGivebackScoreRewardById.GetConfig(id, true);
	}

	// Token: 0x0600CBB5 RID: 52149 RVA: 0x002E804A File Offset: 0x002E624A
	[NullableContext(2)]
	public IReadOnlyList<GivebackScoreReward> GetGivebackScoreRewardAll()
	{
		return ConfigGivebackScoreRewardAll.GetConfigList(true);
	}

	// Token: 0x0600CBB6 RID: 52150 RVA: 0x002E8052 File Offset: 0x002E6252
	public GivebackTask? GetGivebackTaskById(int id)
	{
		return ConfigGivebackTaskByTaskId.GetConfig(id, true);
	}

	// Token: 0x0600CBB7 RID: 52151 RVA: 0x002E805B File Offset: 0x002E625B
	[NullableContext(2)]
	public IReadOnlyList<GivebackTask> GetGivebackTaskAll()
	{
		return ConfigGivebackTaskAll.GetConfigList(true);
	}

	// Token: 0x170010D3 RID: 4307
	// (get) Token: 0x0600CBB8 RID: 52152 RVA: 0x002E8063 File Offset: 0x002E6263
	public static FeedbackRewardConfig Instance
	{
		get
		{
			return FeedbackRewardConfig._Instance;
		}
	}

	// Token: 0x0600CBB9 RID: 52153 RVA: 0x002E806A File Offset: 0x002E626A
	public static FeedbackRewardConfig GetOrCreateInstance()
	{
		if (FeedbackRewardConfig._Instance == null)
		{
			FeedbackRewardConfig.CreateInstance();
		}
		return FeedbackRewardConfig._Instance;
	}

	// Token: 0x0600CBBA RID: 52154 RVA: 0x002E807E File Offset: 0x002E627E
	public static bool CreateInstance()
	{
		if (FeedbackRewardConfig._Instance != null)
		{
			return true;
		}
		FeedbackRewardConfig._Instance = new FeedbackRewardConfig();
		return true;
	}

	// Token: 0x0600CBBB RID: 52155 RVA: 0x002E8094 File Offset: 0x002E6294
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CBBC RID: 52156 RVA: 0x002E8096 File Offset: 0x002E6296
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardConfig._Instance = null;
	}

	// Token: 0x0600CBBD RID: 52157 RVA: 0x002E809E File Offset: 0x002E629E
	static FeedbackRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardConfig.CreateStaticDefaultValue), new Action(FeedbackRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005DAD RID: 23981
	[Nullable(2)]
	private static FeedbackRewardConfig _Instance;
}

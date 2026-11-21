using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020009D4 RID: 2516
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTimePointRewardConfig : ConfigBase
{
	// Token: 0x06006DF8 RID: 28152 RVA: 0x0021F571 File Offset: 0x0021D771
	public TimePointRewardActivity? GetTimePointRewardById(int id)
	{
		return ConfigTimePointRewardActivityById.GetConfig(id, true);
	}

	// Token: 0x06006DF9 RID: 28153 RVA: 0x0021F57A File Offset: 0x0021D77A
	public TimePointRewardConfig? GetConfigByActivityId(int actId)
	{
		return ConfigTimePointRewardConfigByActivityId.GetConfig(actId, true);
	}

	// Token: 0x06006DFA RID: 28154 RVA: 0x0021F583 File Offset: 0x0021D783
	[NullableContext(2)]
	public IReadOnlyList<TimePointRewardActivity> GetTimePointRewardListByActivityId(int actId)
	{
		return ConfigTimePointRewardActivityByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x17000D61 RID: 3425
	// (get) Token: 0x06006DFB RID: 28155 RVA: 0x0021F58C File Offset: 0x0021D78C
	public static ActivityTimePointRewardConfig Instance
	{
		get
		{
			return ActivityTimePointRewardConfig._Instance;
		}
	}

	// Token: 0x06006DFC RID: 28156 RVA: 0x0021F593 File Offset: 0x0021D793
	public static ActivityTimePointRewardConfig GetOrCreateInstance()
	{
		if (ActivityTimePointRewardConfig._Instance == null)
		{
			ActivityTimePointRewardConfig.CreateInstance();
		}
		return ActivityTimePointRewardConfig._Instance;
	}

	// Token: 0x06006DFD RID: 28157 RVA: 0x0021F5A7 File Offset: 0x0021D7A7
	public static bool CreateInstance()
	{
		if (ActivityTimePointRewardConfig._Instance != null)
		{
			return true;
		}
		ActivityTimePointRewardConfig._Instance = new ActivityTimePointRewardConfig();
		return true;
	}

	// Token: 0x06006DFE RID: 28158 RVA: 0x0021F5BD File Offset: 0x0021D7BD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006DFF RID: 28159 RVA: 0x0021F5BF File Offset: 0x0021D7BF
	public static void ResetStaticDefaultValue()
	{
		ActivityTimePointRewardConfig._Instance = null;
	}

	// Token: 0x06006E00 RID: 28160 RVA: 0x0021F5C7 File Offset: 0x0021D7C7
	static ActivityTimePointRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTimePointRewardConfig.CreateStaticDefaultValue), new Action(ActivityTimePointRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004479 RID: 17529
	[Nullable(2)]
	private static ActivityTimePointRewardConfig _Instance;
}

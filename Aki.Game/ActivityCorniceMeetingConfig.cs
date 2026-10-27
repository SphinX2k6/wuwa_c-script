using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020011F0 RID: 4592
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityCorniceMeetingConfig : ConfigBase
{
	// Token: 0x06007A8F RID: 31375 RVA: 0x0019CE79 File Offset: 0x0019B079
	public CorniceChallenge? GetCorniceMeetingChallengeConfig(int levelPlayId)
	{
		return ConfigCorniceChallengeById.GetConfig(levelPlayId, true);
	}

	// Token: 0x06007A90 RID: 31376 RVA: 0x0019CE82 File Offset: 0x0019B082
	public CorniceQuest? GetCorniceMeetingQuest(int levelPlayId)
	{
		return ConfigCorniceQuestById.GetConfig(levelPlayId, true);
	}

	// Token: 0x06007A91 RID: 31377 RVA: 0x0019CE8B File Offset: 0x0019B08B
	public CorniceChallenge? GetCorniceMeetingChallengeByMarkId(int markId)
	{
		return ConfigCorniceChallengeByMarkId.GetConfig(markId, true);
	}

	// Token: 0x17000A7B RID: 2683
	// (get) Token: 0x06007A92 RID: 31378 RVA: 0x0019CE94 File Offset: 0x0019B094
	public static ActivityCorniceMeetingConfig Instance
	{
		get
		{
			return ActivityCorniceMeetingConfig._Instance;
		}
	}

	// Token: 0x06007A93 RID: 31379 RVA: 0x0019CE9B File Offset: 0x0019B09B
	public static ActivityCorniceMeetingConfig GetOrCreateInstance()
	{
		if (ActivityCorniceMeetingConfig._Instance == null)
		{
			ActivityCorniceMeetingConfig.CreateInstance();
		}
		return ActivityCorniceMeetingConfig._Instance;
	}

	// Token: 0x06007A94 RID: 31380 RVA: 0x0019CEAF File Offset: 0x0019B0AF
	public static bool CreateInstance()
	{
		if (ActivityCorniceMeetingConfig._Instance != null)
		{
			return true;
		}
		ActivityCorniceMeetingConfig._Instance = new ActivityCorniceMeetingConfig();
		return true;
	}

	// Token: 0x06007A95 RID: 31381 RVA: 0x0019CEC5 File Offset: 0x0019B0C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007A96 RID: 31382 RVA: 0x0019CEC7 File Offset: 0x0019B0C7
	public static void ResetStaticDefaultValue()
	{
		ActivityCorniceMeetingConfig._Instance = null;
	}

	// Token: 0x06007A97 RID: 31383 RVA: 0x0019CECF File Offset: 0x0019B0CF
	static ActivityCorniceMeetingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCorniceMeetingConfig.CreateStaticDefaultValue), new Action(ActivityCorniceMeetingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003830 RID: 14384
	[Nullable(2)]
	private static ActivityCorniceMeetingConfig _Instance;
}

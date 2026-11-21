using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020006A4 RID: 1700
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityCorniceMeetingConfig : ConfigBase
{
	// Token: 0x06004E26 RID: 20006 RVA: 0x001A5B21 File Offset: 0x001A3D21
	public CorniceChallenge? GetCorniceMeetingChallengeConfig(int levelPlayId)
	{
		return ConfigCorniceChallengeById.GetConfig(levelPlayId, true);
	}

	// Token: 0x06004E27 RID: 20007 RVA: 0x001A5B2A File Offset: 0x001A3D2A
	public CorniceQuest? GetCorniceMeetingQuest(int levelPlayId)
	{
		return ConfigCorniceQuestById.GetConfig(levelPlayId, true);
	}

	// Token: 0x06004E28 RID: 20008 RVA: 0x001A5B33 File Offset: 0x001A3D33
	public CorniceChallenge? GetCorniceMeetingChallengeByMarkId(int markId)
	{
		return ConfigCorniceChallengeByMarkId.GetConfig(markId, true);
	}

	// Token: 0x17000A9B RID: 2715
	// (get) Token: 0x06004E29 RID: 20009 RVA: 0x001A5B3C File Offset: 0x001A3D3C
	public static ActivityCorniceMeetingConfig Instance
	{
		get
		{
			return ActivityCorniceMeetingConfig._Instance;
		}
	}

	// Token: 0x06004E2A RID: 20010 RVA: 0x001A5B43 File Offset: 0x001A3D43
	public static ActivityCorniceMeetingConfig GetOrCreateInstance()
	{
		if (ActivityCorniceMeetingConfig._Instance == null)
		{
			ActivityCorniceMeetingConfig.CreateInstance();
		}
		return ActivityCorniceMeetingConfig._Instance;
	}

	// Token: 0x06004E2B RID: 20011 RVA: 0x001A5B57 File Offset: 0x001A3D57
	public static bool CreateInstance()
	{
		if (ActivityCorniceMeetingConfig._Instance != null)
		{
			return true;
		}
		ActivityCorniceMeetingConfig._Instance = new ActivityCorniceMeetingConfig();
		return true;
	}

	// Token: 0x06004E2C RID: 20012 RVA: 0x001A5B6D File Offset: 0x001A3D6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x001A5B6F File Offset: 0x001A3D6F
	public static void ResetStaticDefaultValue()
	{
		ActivityCorniceMeetingConfig._Instance = null;
	}

	// Token: 0x06004E2E RID: 20014 RVA: 0x001A5B77 File Offset: 0x001A3D77
	static ActivityCorniceMeetingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCorniceMeetingConfig.CreateStaticDefaultValue), new Action(ActivityCorniceMeetingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040038C9 RID: 14537
	[Nullable(2)]
	private static ActivityCorniceMeetingConfig _Instance;
}

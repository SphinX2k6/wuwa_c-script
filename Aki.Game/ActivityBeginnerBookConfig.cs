using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200118D RID: 4493
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityBeginnerBookConfig : ConfigBase
{
	// Token: 0x060076E3 RID: 30435 RVA: 0x0018C60C File Offset: 0x0018A80C
	public WorldNewJourney GetActivityBeginnerConfig(int id)
	{
		return ConfigWorldNewJourneyById.GetConfig(id, true).Value;
	}

	// Token: 0x060076E4 RID: 30436 RVA: 0x0018C628 File Offset: 0x0018A828
	public WorldNewJourney[] GetAllActivityBeginnerConfig()
	{
		return ConfigWorldNewJourneyAll.GetConfigList(true).ToArray<WorldNewJourney>();
	}

	// Token: 0x17000A39 RID: 2617
	// (get) Token: 0x060076E5 RID: 30437 RVA: 0x0018C635 File Offset: 0x0018A835
	public static ActivityBeginnerBookConfig Instance
	{
		get
		{
			return ActivityBeginnerBookConfig._Instance;
		}
	}

	// Token: 0x060076E6 RID: 30438 RVA: 0x0018C63C File Offset: 0x0018A83C
	public static ActivityBeginnerBookConfig GetOrCreateInstance()
	{
		if (ActivityBeginnerBookConfig._Instance == null)
		{
			ActivityBeginnerBookConfig.CreateInstance();
		}
		return ActivityBeginnerBookConfig._Instance;
	}

	// Token: 0x060076E7 RID: 30439 RVA: 0x0018C650 File Offset: 0x0018A850
	public static bool CreateInstance()
	{
		if (ActivityBeginnerBookConfig._Instance != null)
		{
			return true;
		}
		ActivityBeginnerBookConfig._Instance = new ActivityBeginnerBookConfig();
		return true;
	}

	// Token: 0x060076E8 RID: 30440 RVA: 0x0018C666 File Offset: 0x0018A866
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060076E9 RID: 30441 RVA: 0x0018C668 File Offset: 0x0018A868
	public static void ResetStaticDefaultValue()
	{
		ActivityBeginnerBookConfig._Instance = null;
	}

	// Token: 0x060076EA RID: 30442 RVA: 0x0018C670 File Offset: 0x0018A870
	static ActivityBeginnerBookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBeginnerBookConfig.CreateStaticDefaultValue), new Action(ActivityBeginnerBookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003687 RID: 13959
	[Nullable(2)]
	private static ActivityBeginnerBookConfig _Instance;
}

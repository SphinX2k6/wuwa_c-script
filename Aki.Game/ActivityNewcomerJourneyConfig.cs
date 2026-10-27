using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200139E RID: 5022
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewcomerJourneyConfig : ConfigBase
{
	// Token: 0x06008CEB RID: 36075 RVA: 0x001E3F98 File Offset: 0x001E2198
	public AdventureTaskChapterV2? GetChapterById(int chapterId)
	{
		return ConfigAdventureTaskChapterV2ById.GetConfig(chapterId, true);
	}

	// Token: 0x06008CEC RID: 36076 RVA: 0x001E3FA1 File Offset: 0x001E21A1
	public AdventureRole? GetRoleById(int id)
	{
		return ConfigAdventureRoleById.GetConfig(id, true);
	}

	// Token: 0x06008CED RID: 36077 RVA: 0x001E3FAA File Offset: 0x001E21AA
	public AdventureTaskV2? GetTaskById(int taskId)
	{
		return ConfigAdventureTaskV2ById.GetConfig(taskId, true);
	}

	// Token: 0x17000BE3 RID: 3043
	// (get) Token: 0x06008CEE RID: 36078 RVA: 0x001E3FB3 File Offset: 0x001E21B3
	public static ActivityNewcomerJourneyConfig Instance
	{
		get
		{
			return ActivityNewcomerJourneyConfig._Instance;
		}
	}

	// Token: 0x06008CEF RID: 36079 RVA: 0x001E3FBA File Offset: 0x001E21BA
	public static ActivityNewcomerJourneyConfig GetOrCreateInstance()
	{
		if (ActivityNewcomerJourneyConfig._Instance == null)
		{
			ActivityNewcomerJourneyConfig.CreateInstance();
		}
		return ActivityNewcomerJourneyConfig._Instance;
	}

	// Token: 0x06008CF0 RID: 36080 RVA: 0x001E3FCE File Offset: 0x001E21CE
	public static bool CreateInstance()
	{
		if (ActivityNewcomerJourneyConfig._Instance != null)
		{
			return true;
		}
		ActivityNewcomerJourneyConfig._Instance = new ActivityNewcomerJourneyConfig();
		return true;
	}

	// Token: 0x06008CF1 RID: 36081 RVA: 0x001E3FE4 File Offset: 0x001E21E4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008CF2 RID: 36082 RVA: 0x001E3FE6 File Offset: 0x001E21E6
	public static void ResetStaticDefaultValue()
	{
		ActivityNewcomerJourneyConfig._Instance = null;
	}

	// Token: 0x06008CF3 RID: 36083 RVA: 0x001E3FEE File Offset: 0x001E21EE
	static ActivityNewcomerJourneyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewcomerJourneyConfig.CreateStaticDefaultValue), new Action(ActivityNewcomerJourneyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003E7E RID: 15998
	[Nullable(2)]
	private static ActivityNewcomerJourneyConfig _Instance;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000852 RID: 2130
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewcomerJourneyConfig : ConfigBase
{
	// Token: 0x06006081 RID: 24705 RVA: 0x001ECBBC File Offset: 0x001EADBC
	public AdventureTaskChapterV2? GetChapterById(int chapterId)
	{
		return ConfigAdventureTaskChapterV2ById.GetConfig(chapterId, true);
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x001ECBC5 File Offset: 0x001EADC5
	public AdventureRole? GetRoleById(int id)
	{
		return ConfigAdventureRoleById.GetConfig(id, true);
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x001ECBCE File Offset: 0x001EADCE
	public AdventureTaskV2? GetTaskById(int taskId)
	{
		return ConfigAdventureTaskV2ById.GetConfig(taskId, true);
	}

	// Token: 0x17000C03 RID: 3075
	// (get) Token: 0x06006084 RID: 24708 RVA: 0x001ECBD7 File Offset: 0x001EADD7
	public static ActivityNewcomerJourneyConfig Instance
	{
		get
		{
			return ActivityNewcomerJourneyConfig._Instance;
		}
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x001ECBDE File Offset: 0x001EADDE
	public static ActivityNewcomerJourneyConfig GetOrCreateInstance()
	{
		if (ActivityNewcomerJourneyConfig._Instance == null)
		{
			ActivityNewcomerJourneyConfig.CreateInstance();
		}
		return ActivityNewcomerJourneyConfig._Instance;
	}

	// Token: 0x06006086 RID: 24710 RVA: 0x001ECBF2 File Offset: 0x001EADF2
	public static bool CreateInstance()
	{
		if (ActivityNewcomerJourneyConfig._Instance != null)
		{
			return true;
		}
		ActivityNewcomerJourneyConfig._Instance = new ActivityNewcomerJourneyConfig();
		return true;
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x001ECC08 File Offset: 0x001EAE08
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x001ECC0A File Offset: 0x001EAE0A
	public static void ResetStaticDefaultValue()
	{
		ActivityNewcomerJourneyConfig._Instance = null;
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x001ECC12 File Offset: 0x001EAE12
	static ActivityNewcomerJourneyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewcomerJourneyConfig.CreateStaticDefaultValue), new Action(ActivityNewcomerJourneyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003F16 RID: 16150
	[Nullable(2)]
	private static ActivityNewcomerJourneyConfig _Instance;
}

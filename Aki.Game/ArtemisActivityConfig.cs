using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200059A RID: 1434
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ArtemisActivityConfig : ConfigBase
{
	// Token: 0x06004436 RID: 17462 RVA: 0x00178650 File Offset: 0x00176850
	public Artemis? GetArtemisByActivityIdAndDay(int id, int day)
	{
		return ConfigArtemisByDay.GetConfig(id, day, true);
	}

	// Token: 0x06004437 RID: 17463 RVA: 0x0017865A File Offset: 0x0017685A
	[NullableContext(2)]
	public IReadOnlyList<Artemis> GetArtemisGroupByActivityId(int activityId)
	{
		return ConfigArtemisByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x00178663 File Offset: 0x00176863
	public ArtemisChat? GetArtemisChatConfigById(int id)
	{
		return ConfigArtemisChatById.GetConfig(id, true);
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x0017866C File Offset: 0x0017686C
	public ArtemisQte? GetArtemisQteConfigById(int id)
	{
		return ConfigArtemisQteById.GetConfig(id, true);
	}

	// Token: 0x170009A5 RID: 2469
	// (get) Token: 0x0600443A RID: 17466 RVA: 0x00178675 File Offset: 0x00176875
	public static ArtemisActivityConfig Instance
	{
		get
		{
			return ArtemisActivityConfig._Instance;
		}
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x0017867C File Offset: 0x0017687C
	public static ArtemisActivityConfig GetOrCreateInstance()
	{
		if (ArtemisActivityConfig._Instance == null)
		{
			ArtemisActivityConfig.CreateInstance();
		}
		return ArtemisActivityConfig._Instance;
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x00178690 File Offset: 0x00176890
	public static bool CreateInstance()
	{
		if (ArtemisActivityConfig._Instance != null)
		{
			return true;
		}
		ArtemisActivityConfig._Instance = new ArtemisActivityConfig();
		return true;
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x001786A6 File Offset: 0x001768A6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x001786A8 File Offset: 0x001768A8
	public static void ResetStaticDefaultValue()
	{
		ArtemisActivityConfig._Instance = null;
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x001786B0 File Offset: 0x001768B0
	static ArtemisActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ArtemisActivityConfig.CreateStaticDefaultValue), new Action(ArtemisActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040034DA RID: 13530
	[Nullable(2)]
	private static ArtemisActivityConfig _Instance;
}

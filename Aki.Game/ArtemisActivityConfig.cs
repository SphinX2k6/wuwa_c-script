using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010E6 RID: 4326
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ArtemisActivityConfig : ConfigBase
{
	// Token: 0x060070A0 RID: 28832 RVA: 0x0016FC94 File Offset: 0x0016DE94
	public Artemis? GetArtemisByActivityIdAndDay(int id, int day)
	{
		return ConfigArtemisByDay.GetConfig(id, day, true);
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x0016FC9E File Offset: 0x0016DE9E
	[NullableContext(2)]
	public IReadOnlyList<Artemis> GetArtemisGroupByActivityId(int activityId)
	{
		return ConfigArtemisByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x0016FCA7 File Offset: 0x0016DEA7
	public ArtemisChat? GetArtemisChatConfigById(int id)
	{
		return ConfigArtemisChatById.GetConfig(id, true);
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x0016FCB0 File Offset: 0x0016DEB0
	public ArtemisQte? GetArtemisQteConfigById(int id)
	{
		return ConfigArtemisQteById.GetConfig(id, true);
	}

	// Token: 0x17000985 RID: 2437
	// (get) Token: 0x060070A4 RID: 28836 RVA: 0x0016FCB9 File Offset: 0x0016DEB9
	public static ArtemisActivityConfig Instance
	{
		get
		{
			return ArtemisActivityConfig._Instance;
		}
	}

	// Token: 0x060070A5 RID: 28837 RVA: 0x0016FCC0 File Offset: 0x0016DEC0
	public static ArtemisActivityConfig GetOrCreateInstance()
	{
		if (ArtemisActivityConfig._Instance == null)
		{
			ArtemisActivityConfig.CreateInstance();
		}
		return ArtemisActivityConfig._Instance;
	}

	// Token: 0x060070A6 RID: 28838 RVA: 0x0016FCD4 File Offset: 0x0016DED4
	public static bool CreateInstance()
	{
		if (ArtemisActivityConfig._Instance != null)
		{
			return true;
		}
		ArtemisActivityConfig._Instance = new ArtemisActivityConfig();
		return true;
	}

	// Token: 0x060070A7 RID: 28839 RVA: 0x0016FCEA File Offset: 0x0016DEEA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060070A8 RID: 28840 RVA: 0x0016FCEC File Offset: 0x0016DEEC
	public static void ResetStaticDefaultValue()
	{
		ArtemisActivityConfig._Instance = null;
	}

	// Token: 0x060070A9 RID: 28841 RVA: 0x0016FCF4 File Offset: 0x0016DEF4
	static ArtemisActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ArtemisActivityConfig.CreateStaticDefaultValue), new Action(ArtemisActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003441 RID: 13377
	[Nullable(2)]
	private static ArtemisActivityConfig _Instance;
}

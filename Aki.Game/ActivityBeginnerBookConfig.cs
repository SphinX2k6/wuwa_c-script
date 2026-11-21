using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000641 RID: 1601
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityBeginnerBookConfig : ConfigBase
{
	// Token: 0x06004A7A RID: 19066 RVA: 0x001951BC File Offset: 0x001933BC
	public WorldNewJourney GetActivityBeginnerConfig(int id)
	{
		return ConfigWorldNewJourneyById.GetConfig(id, true).Value;
	}

	// Token: 0x06004A7B RID: 19067 RVA: 0x001951D8 File Offset: 0x001933D8
	public WorldNewJourney[] GetAllActivityBeginnerConfig()
	{
		IReadOnlyList<WorldNewJourney> configList = ConfigWorldNewJourneyAll.GetConfigList(true);
		WorldNewJourney[] array = new WorldNewJourney[configList.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = configList[i];
		}
		return array;
	}

	// Token: 0x17000A59 RID: 2649
	// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00195215 File Offset: 0x00193415
	public static ActivityBeginnerBookConfig Instance
	{
		get
		{
			return ActivityBeginnerBookConfig._Instance;
		}
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x0019521C File Offset: 0x0019341C
	public static ActivityBeginnerBookConfig GetOrCreateInstance()
	{
		if (ActivityBeginnerBookConfig._Instance == null)
		{
			ActivityBeginnerBookConfig.CreateInstance();
		}
		return ActivityBeginnerBookConfig._Instance;
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x00195230 File Offset: 0x00193430
	public static bool CreateInstance()
	{
		if (ActivityBeginnerBookConfig._Instance != null)
		{
			return true;
		}
		ActivityBeginnerBookConfig._Instance = new ActivityBeginnerBookConfig();
		return true;
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x00195246 File Offset: 0x00193446
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x00195248 File Offset: 0x00193448
	public static void ResetStaticDefaultValue()
	{
		ActivityBeginnerBookConfig._Instance = null;
	}

	// Token: 0x06004A81 RID: 19073 RVA: 0x00195250 File Offset: 0x00193450
	static ActivityBeginnerBookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBeginnerBookConfig.CreateStaticDefaultValue), new Action(ActivityBeginnerBookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003720 RID: 14112
	[Nullable(2)]
	private static ActivityBeginnerBookConfig _Instance;
}

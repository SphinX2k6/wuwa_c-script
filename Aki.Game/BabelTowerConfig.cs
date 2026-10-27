using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001120 RID: 4384
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BabelTowerConfig : ConfigBase
{
	// Token: 0x060072BF RID: 29375 RVA: 0x00178B7C File Offset: 0x00176D7C
	public BabelTowerLevel GetBabelTowerLevelConfig(int id)
	{
		return ConfigBabelTowerLevelById.GetConfig(id, true).Value;
	}

	// Token: 0x060072C0 RID: 29376 RVA: 0x00178B98 File Offset: 0x00176D98
	public BabelTowerTask GetBabelTowerNormalQuest(int id)
	{
		return ConfigBabelTowerTaskByTaskId.GetConfig(id, true).Value;
	}

	// Token: 0x060072C1 RID: 29377 RVA: 0x00178BB4 File Offset: 0x00176DB4
	public BabelTowerDailyTask GetBabelTowerDailyQuest(int id)
	{
		return ConfigBabelTowerDailyTaskByTaskId.GetConfig(id, true).Value;
	}

	// Token: 0x060072C2 RID: 29378 RVA: 0x00178BD0 File Offset: 0x00176DD0
	public IReadOnlyList<BabelTowerDailyTask> GetBabelTowerAllDailyQuest()
	{
		return ConfigBabelTowerDailyTaskAll.GetConfigList(true);
	}

	// Token: 0x060072C3 RID: 29379 RVA: 0x00178BD8 File Offset: 0x00176DD8
	public BabelTowerBuff GetBabelTowerBuff(int id)
	{
		return ConfigBabelTowerBuffById.GetConfig(id, true).Value;
	}

	// Token: 0x060072C4 RID: 29380 RVA: 0x00178BF4 File Offset: 0x00176DF4
	public BabelTowerDeTerm GetBabelTowerDeTerm(int id)
	{
		return ConfigBabelTowerDeTermById.GetConfig(id, true).Value;
	}

	// Token: 0x060072C5 RID: 29381 RVA: 0x00178C10 File Offset: 0x00176E10
	public IReadOnlyList<BabelTowerDeTerm> GetBabelTowerDeTermByGroupId(int id)
	{
		return ConfigBabelTowerDeTermByGroupId.GetConfigList(id, true);
	}

	// Token: 0x060072C6 RID: 29382 RVA: 0x00178C1C File Offset: 0x00176E1C
	public BabelTowerDeTermMutex GetBabelTowerDeTermMutual(int id)
	{
		return ConfigBabelTowerDeTermMutexById.GetConfig(id, true).Value;
	}

	// Token: 0x060072C7 RID: 29383 RVA: 0x00178C38 File Offset: 0x00176E38
	public IReadOnlyList<BabelTowerQuick> GetBabelTowerQuickByInstId(int instId)
	{
		return ConfigBabelTowerQuickByInstId.GetConfigList(instId, true);
	}

	// Token: 0x060072C8 RID: 29384 RVA: 0x00178C44 File Offset: 0x00176E44
	public IReadOnlyList<BabelTowerLevel> GetAllBabelTowerDifficultLevel(int activityId)
	{
		return (from level in ConfigBabelTowerLevelAll.GetConfigList(true)
		where level.IsDifficult && level.ActivityId == activityId
		select level).ToList<BabelTowerLevel>();
	}

	// Token: 0x170009B1 RID: 2481
	// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00178C7A File Offset: 0x00176E7A
	public static BabelTowerConfig Instance
	{
		get
		{
			return BabelTowerConfig._Instance;
		}
	}

	// Token: 0x060072CA RID: 29386 RVA: 0x00178C81 File Offset: 0x00176E81
	public static BabelTowerConfig GetOrCreateInstance()
	{
		if (BabelTowerConfig._Instance == null)
		{
			BabelTowerConfig.CreateInstance();
		}
		return BabelTowerConfig._Instance;
	}

	// Token: 0x060072CB RID: 29387 RVA: 0x00178C95 File Offset: 0x00176E95
	public static bool CreateInstance()
	{
		if (BabelTowerConfig._Instance != null)
		{
			return true;
		}
		BabelTowerConfig._Instance = new BabelTowerConfig();
		return true;
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x00178CAB File Offset: 0x00176EAB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060072CD RID: 29389 RVA: 0x00178CAD File Offset: 0x00176EAD
	public static void ResetStaticDefaultValue()
	{
		BabelTowerConfig._Instance = null;
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x00178CB5 File Offset: 0x00176EB5
	static BabelTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerConfig.CreateStaticDefaultValue), new Action(BabelTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003517 RID: 13591
	[Nullable(2)]
	private static BabelTowerConfig _Instance;
}

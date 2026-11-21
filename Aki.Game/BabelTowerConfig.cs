using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020005D4 RID: 1492
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BabelTowerConfig : ConfigBase
{
	// Token: 0x06004655 RID: 18005 RVA: 0x00181538 File Offset: 0x0017F738
	public BabelTowerLevel GetBabelTowerLevelConfig(int id)
	{
		return ConfigBabelTowerLevelById.GetConfig(id, true).Value;
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x00181554 File Offset: 0x0017F754
	public BabelTowerTask GetBabelTowerNormalQuest(int id)
	{
		return ConfigBabelTowerTaskByTaskId.GetConfig(id, true).Value;
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x00181570 File Offset: 0x0017F770
	public BabelTowerDailyTask GetBabelTowerDailyQuest(int id)
	{
		return ConfigBabelTowerDailyTaskByTaskId.GetConfig(id, true).Value;
	}

	// Token: 0x06004658 RID: 18008 RVA: 0x0018158C File Offset: 0x0017F78C
	public IReadOnlyList<BabelTowerDailyTask> GetBabelTowerAllDailyQuest()
	{
		return ConfigBabelTowerDailyTaskAll.GetConfigList(true);
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x00181594 File Offset: 0x0017F794
	public BabelTowerBuff GetBabelTowerBuff(int id)
	{
		return ConfigBabelTowerBuffById.GetConfig(id, true).Value;
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x001815B0 File Offset: 0x0017F7B0
	public BabelTowerDeTerm GetBabelTowerDeTerm(int id)
	{
		return ConfigBabelTowerDeTermById.GetConfig(id, true).Value;
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x001815CC File Offset: 0x0017F7CC
	public IReadOnlyList<BabelTowerDeTerm> GetBabelTowerDeTermByGroupId(int id)
	{
		return ConfigBabelTowerDeTermByGroupId.GetConfigList(id, true);
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x001815D8 File Offset: 0x0017F7D8
	public BabelTowerDeTermMutex GetBabelTowerDeTermMutual(int id)
	{
		return ConfigBabelTowerDeTermMutexById.GetConfig(id, true).Value;
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x001815F4 File Offset: 0x0017F7F4
	public IReadOnlyList<BabelTowerQuick> GetBabelTowerQuickByInstId(int instId)
	{
		return ConfigBabelTowerQuickByInstId.GetConfigList(instId, true);
	}

	// Token: 0x0600465E RID: 18014 RVA: 0x00181600 File Offset: 0x0017F800
	public IReadOnlyList<BabelTowerLevel> GetAllBabelTowerDifficultLevel(int activityId)
	{
		List<BabelTowerLevel> list = new List<BabelTowerLevel>();
		foreach (BabelTowerLevel item in ConfigBabelTowerLevelAll.GetConfigList(true))
		{
			if (item.IsDifficult && item.ActivityId == activityId)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x170009D1 RID: 2513
	// (get) Token: 0x0600465F RID: 18015 RVA: 0x00181668 File Offset: 0x0017F868
	public static BabelTowerConfig Instance
	{
		get
		{
			return BabelTowerConfig._Instance;
		}
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x0018166F File Offset: 0x0017F86F
	public static BabelTowerConfig GetOrCreateInstance()
	{
		if (BabelTowerConfig._Instance == null)
		{
			BabelTowerConfig.CreateInstance();
		}
		return BabelTowerConfig._Instance;
	}

	// Token: 0x06004661 RID: 18017 RVA: 0x00181683 File Offset: 0x0017F883
	public static bool CreateInstance()
	{
		if (BabelTowerConfig._Instance != null)
		{
			return true;
		}
		BabelTowerConfig._Instance = new BabelTowerConfig();
		return true;
	}

	// Token: 0x06004662 RID: 18018 RVA: 0x00181699 File Offset: 0x0017F899
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004663 RID: 18019 RVA: 0x0018169B File Offset: 0x0017F89B
	public static void ResetStaticDefaultValue()
	{
		BabelTowerConfig._Instance = null;
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x001816A3 File Offset: 0x0017F8A3
	static BabelTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerConfig.CreateStaticDefaultValue), new Action(BabelTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040035B0 RID: 13744
	[Nullable(2)]
	private static BabelTowerConfig _Instance;
}

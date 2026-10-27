using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012C2 RID: 4802
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMapExploreConfig : ConfigBase
{
	// Token: 0x060083E7 RID: 33767 RVA: 0x001C1866 File Offset: 0x001BFA66
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060083E8 RID: 33768 RVA: 0x001C1869 File Offset: 0x001BFA69
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060083E9 RID: 33769 RVA: 0x001C186C File Offset: 0x001BFA6C
	public IReadOnlyList<ExploreActivityTask> GetExploreTaskList(int activityId)
	{
		IReadOnlyList<ExploreActivityTask> configList = ConfigExploreActivityTaskByActivityId.GetConfigList(activityId, true);
		return configList ?? new List<ExploreActivityTask>();
	}

	// Token: 0x060083EA RID: 33770 RVA: 0x001C188B File Offset: 0x001BFA8B
	public ExploreActivity? GetActivityInfo(int activityId)
	{
		return ConfigExploreActivityById.GetConfig(activityId, true);
	}

	// Token: 0x17000B36 RID: 2870
	// (get) Token: 0x060083EB RID: 33771 RVA: 0x001C1894 File Offset: 0x001BFA94
	public static ActivityMapExploreConfig Instance
	{
		get
		{
			return ActivityMapExploreConfig._Instance;
		}
	}

	// Token: 0x060083EC RID: 33772 RVA: 0x001C189B File Offset: 0x001BFA9B
	public static ActivityMapExploreConfig GetOrCreateInstance()
	{
		if (ActivityMapExploreConfig._Instance == null)
		{
			ActivityMapExploreConfig.CreateInstance();
		}
		return ActivityMapExploreConfig._Instance;
	}

	// Token: 0x060083ED RID: 33773 RVA: 0x001C18AF File Offset: 0x001BFAAF
	public static bool CreateInstance()
	{
		if (ActivityMapExploreConfig._Instance != null)
		{
			return true;
		}
		ActivityMapExploreConfig._Instance = new ActivityMapExploreConfig();
		return true;
	}

	// Token: 0x060083EE RID: 33774 RVA: 0x001C18C5 File Offset: 0x001BFAC5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060083EF RID: 33775 RVA: 0x001C18C7 File Offset: 0x001BFAC7
	public static void ResetStaticDefaultValue()
	{
		ActivityMapExploreConfig._Instance = null;
	}

	// Token: 0x060083F0 RID: 33776 RVA: 0x001C18CF File Offset: 0x001BFACF
	static ActivityMapExploreConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapExploreConfig.CreateStaticDefaultValue), new Action(ActivityMapExploreConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003B5B RID: 15195
	[Nullable(2)]
	private static ActivityMapExploreConfig _Instance;
}

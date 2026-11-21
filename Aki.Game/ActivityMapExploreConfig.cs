using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000776 RID: 1910
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMapExploreConfig : ConfigBase
{
	// Token: 0x06005782 RID: 22402 RVA: 0x001CA6C2 File Offset: 0x001C88C2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x001CA6C5 File Offset: 0x001C88C5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x001CA6C8 File Offset: 0x001C88C8
	public IReadOnlyList<ExploreActivityTask> GetExploreTaskList(int activityId)
	{
		IReadOnlyList<ExploreActivityTask> configList = ConfigExploreActivityTaskByActivityId.GetConfigList(activityId, true);
		return configList ?? new List<ExploreActivityTask>();
	}

	// Token: 0x06005785 RID: 22405 RVA: 0x001CA6E7 File Offset: 0x001C88E7
	public ExploreActivity? GetActivityInfo(int activityId)
	{
		return ConfigExploreActivityById.GetConfig(activityId, true);
	}

	// Token: 0x17000B56 RID: 2902
	// (get) Token: 0x06005786 RID: 22406 RVA: 0x001CA6F0 File Offset: 0x001C88F0
	public static ActivityMapExploreConfig Instance
	{
		get
		{
			return ActivityMapExploreConfig._Instance;
		}
	}

	// Token: 0x06005787 RID: 22407 RVA: 0x001CA6F7 File Offset: 0x001C88F7
	public static ActivityMapExploreConfig GetOrCreateInstance()
	{
		if (ActivityMapExploreConfig._Instance == null)
		{
			ActivityMapExploreConfig.CreateInstance();
		}
		return ActivityMapExploreConfig._Instance;
	}

	// Token: 0x06005788 RID: 22408 RVA: 0x001CA70B File Offset: 0x001C890B
	public static bool CreateInstance()
	{
		if (ActivityMapExploreConfig._Instance != null)
		{
			return true;
		}
		ActivityMapExploreConfig._Instance = new ActivityMapExploreConfig();
		return true;
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x001CA721 File Offset: 0x001C8921
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x001CA723 File Offset: 0x001C8923
	public static void ResetStaticDefaultValue()
	{
		ActivityMapExploreConfig._Instance = null;
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x001CA72B File Offset: 0x001C892B
	static ActivityMapExploreConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapExploreConfig.CreateStaticDefaultValue), new Action(ActivityMapExploreConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003BF3 RID: 15347
	[Nullable(2)]
	private static ActivityMapExploreConfig _Instance;
}

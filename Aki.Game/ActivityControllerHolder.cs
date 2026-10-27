using System;
using System.Runtime.CompilerServices;

// Token: 0x02001673 RID: 5747
[NullableContext(1)]
[Nullable(0)]
[Obsolete("活动控制管理废弃不使用,直接使用ActivityControllerBase.Instance")]
public class ActivityControllerHolder : Singleton
{
	// Token: 0x17000DA7 RID: 3495
	// (get) Token: 0x0600A241 RID: 41537 RVA: 0x0023CC78 File Offset: 0x0023AE78
	public static ActivityControllerHolder Instance
	{
		get
		{
			if (ActivityControllerHolder._instance == null)
			{
				ActivityControllerHolder._instance = new ActivityControllerHolder();
				ActivityControllerHolder._instance.OnInit();
			}
			return ActivityControllerHolder._instance;
		}
	}

	// Token: 0x0600A242 RID: 41538 RVA: 0x0023CC9B File Offset: 0x0023AE9B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A243 RID: 41539 RVA: 0x0023CC9D File Offset: 0x0023AE9D
	public static void ResetStaticDefaultValue()
	{
		ActivityControllerHolder instance = ActivityControllerHolder._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ActivityControllerHolder._instance = null;
	}

	// Token: 0x0600A244 RID: 41540 RVA: 0x0023CCB6 File Offset: 0x0023AEB6
	static ActivityControllerHolder()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityControllerHolder.CreateStaticDefaultValue), new Action(ActivityControllerHolder.ResetStaticDefaultValue));
	}

	// Token: 0x040049CC RID: 18892
	[Nullable(2)]
	private static ActivityControllerHolder _instance;
}

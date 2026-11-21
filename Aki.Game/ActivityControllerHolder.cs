using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B2B RID: 2859
[NullableContext(1)]
[Nullable(0)]
[Obsolete("活动控制管理废弃不使用,直接使用ActivityControllerBase.Instance")]
public class ActivityControllerHolder : Singleton
{
	// Token: 0x17000DC8 RID: 3528
	// (get) Token: 0x0600761F RID: 30239 RVA: 0x00246B08 File Offset: 0x00244D08
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

	// Token: 0x06007620 RID: 30240 RVA: 0x00246B2B File Offset: 0x00244D2B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007621 RID: 30241 RVA: 0x00246B2D File Offset: 0x00244D2D
	public static void ResetStaticDefaultValue()
	{
		ActivityControllerHolder instance = ActivityControllerHolder._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ActivityControllerHolder._instance = null;
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x00246B46 File Offset: 0x00244D46
	static ActivityControllerHolder()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityControllerHolder.CreateStaticDefaultValue), new Action(ActivityControllerHolder.ResetStaticDefaultValue));
	}

	// Token: 0x04004A72 RID: 19058
	[Nullable(2)]
	private static ActivityControllerHolder _instance;
}

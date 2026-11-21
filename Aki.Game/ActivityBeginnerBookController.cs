using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000642 RID: 1602
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityBeginnerBookController : ActivityControllerBase
{
	// Token: 0x06004A83 RID: 19075 RVA: 0x00195277 File Offset: 0x00193477
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x0019527A File Offset: 0x0019347A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x0019527C File Offset: 0x0019347C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_BeginnerBook";
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x00195283 File Offset: 0x00193483
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewBeginnerBook();
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x0019528A File Offset: 0x0019348A
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityBeginnerBookData();
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x001952A0 File Offset: 0x001934A0
	public UniTask NewJourneyRequest()
	{
		ActivityBeginnerBookController.<NewJourneyRequest>d__6 <NewJourneyRequest>d__;
		<NewJourneyRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewJourneyRequest>d__.<>4__this = this;
		<NewJourneyRequest>d__.<>1__state = -1;
		<NewJourneyRequest>d__.<>t__builder.Start<ActivityBeginnerBookController.<NewJourneyRequest>d__6>(ref <NewJourneyRequest>d__);
		return <NewJourneyRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x001952E3 File Offset: 0x001934E3
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x001952E6 File Offset: 0x001934E6
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000A5A RID: 2650
	// (get) Token: 0x06004A8B RID: 19083 RVA: 0x001952E9 File Offset: 0x001934E9
	public static ActivityBeginnerBookController Instance
	{
		get
		{
			return ActivityBeginnerBookController._Instance;
		}
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x001952F0 File Offset: 0x001934F0
	public static ActivityBeginnerBookController GetOrCreateInstance()
	{
		if (ActivityBeginnerBookController._Instance == null)
		{
			ActivityBeginnerBookController.CreateInstance();
		}
		return ActivityBeginnerBookController._Instance;
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x00195304 File Offset: 0x00193504
	public static bool CreateInstance()
	{
		if (ActivityBeginnerBookController._Instance != null)
		{
			return true;
		}
		ActivityBeginnerBookController._Instance = new ActivityBeginnerBookController();
		return true;
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x0019531A File Offset: 0x0019351A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x0019531C File Offset: 0x0019351C
	public static void ResetStaticDefaultValue()
	{
		ActivityBeginnerBookController._Instance = null;
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x00195324 File Offset: 0x00193524
	static ActivityBeginnerBookController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBeginnerBookController.CreateStaticDefaultValue), new Action(ActivityBeginnerBookController.ResetStaticDefaultValue));
	}

	// Token: 0x04003721 RID: 14113
	private int DataId;

	// Token: 0x04003722 RID: 14114
	[Nullable(2)]
	private static ActivityBeginnerBookController _Instance;
}

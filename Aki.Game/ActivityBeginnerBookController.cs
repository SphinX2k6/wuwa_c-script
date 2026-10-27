using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200118E RID: 4494
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityBeginnerBookController : ActivityControllerBase
{
	// Token: 0x060076EC RID: 30444 RVA: 0x0018C697 File Offset: 0x0018A897
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060076ED RID: 30445 RVA: 0x0018C69A File Offset: 0x0018A89A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060076EE RID: 30446 RVA: 0x0018C69C File Offset: 0x0018A89C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_BeginnerBook";
	}

	// Token: 0x060076EF RID: 30447 RVA: 0x0018C6A3 File Offset: 0x0018A8A3
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewBeginnerBook();
	}

	// Token: 0x060076F0 RID: 30448 RVA: 0x0018C6AA File Offset: 0x0018A8AA
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityBeginnerBookData();
	}

	// Token: 0x060076F1 RID: 30449 RVA: 0x0018C6C0 File Offset: 0x0018A8C0
	public UniTask NewJourneyRequest()
	{
		ActivityBeginnerBookController.<NewJourneyRequest>d__6 <NewJourneyRequest>d__;
		<NewJourneyRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewJourneyRequest>d__.<>4__this = this;
		<NewJourneyRequest>d__.<>1__state = -1;
		<NewJourneyRequest>d__.<>t__builder.Start<ActivityBeginnerBookController.<NewJourneyRequest>d__6>(ref <NewJourneyRequest>d__);
		return <NewJourneyRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060076F2 RID: 30450 RVA: 0x0018C703 File Offset: 0x0018A903
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060076F3 RID: 30451 RVA: 0x0018C706 File Offset: 0x0018A906
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000A3A RID: 2618
	// (get) Token: 0x060076F4 RID: 30452 RVA: 0x0018C709 File Offset: 0x0018A909
	public static ActivityBeginnerBookController Instance
	{
		get
		{
			return ActivityBeginnerBookController._Instance;
		}
	}

	// Token: 0x060076F5 RID: 30453 RVA: 0x0018C710 File Offset: 0x0018A910
	public static ActivityBeginnerBookController GetOrCreateInstance()
	{
		if (ActivityBeginnerBookController._Instance == null)
		{
			ActivityBeginnerBookController.CreateInstance();
		}
		return ActivityBeginnerBookController._Instance;
	}

	// Token: 0x060076F6 RID: 30454 RVA: 0x0018C724 File Offset: 0x0018A924
	public static bool CreateInstance()
	{
		if (ActivityBeginnerBookController._Instance != null)
		{
			return true;
		}
		ActivityBeginnerBookController._Instance = new ActivityBeginnerBookController();
		return true;
	}

	// Token: 0x060076F7 RID: 30455 RVA: 0x0018C73A File Offset: 0x0018A93A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060076F8 RID: 30456 RVA: 0x0018C73C File Offset: 0x0018A93C
	public static void ResetStaticDefaultValue()
	{
		ActivityBeginnerBookController._Instance = null;
	}

	// Token: 0x060076F9 RID: 30457 RVA: 0x0018C744 File Offset: 0x0018A944
	static ActivityBeginnerBookController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBeginnerBookController.CreateStaticDefaultValue), new Action(ActivityBeginnerBookController.ResetStaticDefaultValue));
	}

	// Token: 0x04003688 RID: 13960
	private int DataId;

	// Token: 0x04003689 RID: 13961
	[Nullable(2)]
	private static ActivityBeginnerBookController _Instance;
}

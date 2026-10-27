using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020013DB RID: 5083
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityPhantomCollectController : ActivityControllerBase
{
	// Token: 0x06008F7F RID: 36735 RVA: 0x001F0282 File Offset: 0x001EE482
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomCollectUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomCollectUpdateNotify));
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x001F02A0 File Offset: 0x001EE4A0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomCollectUpdateNotify);
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x001F02B4 File Offset: 0x001EE4B4
	[NullableContext(2)]
	protected void OnPhantomCollectUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		PhantomCollectUpdateNotify phantomCollectUpdateNotify = (PhantomCollectUpdateNotify)msg;
		this.ActivityId = phantomCollectUpdateNotify.ActivityId;
		ActivityPhantomCollectData currentActivityDataById = this.GetCurrentActivityDataById();
		if (currentActivityDataById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "声骇收集活动数据更新错误，没有活动数据:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId:", phantomCollectUpdateNotify.ActivityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (phantomCollectUpdateNotify.PhantomCollectReward == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Activity;
			ELogAuthor author2 = ELogAuthor.LPH;
			string message2 = "声骇收集活动数据更新错误:";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ActivityId:", phantomCollectUpdateNotify.ActivityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		currentActivityDataById.UpadatePhantomCollectReward(phantomCollectUpdateNotify.PhantomCollectReward);
		EventSystem.Instance.Emit<PhantomCollectRewardType>(EEventName.OnPhantomCollectUpdate, phantomCollectUpdateNotify.PhantomCollectReward.Type);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x001F038D File Offset: 0x001EE58D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPhantomCollect";
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x001F0394 File Offset: 0x001EE594
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewPhantomCollect();
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x001F039B File Offset: 0x001EE59B
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityPhantomCollectData();
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x001F03AE File Offset: 0x001EE5AE
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008F86 RID: 36742 RVA: 0x001F03B0 File Offset: 0x001EE5B0
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008F87 RID: 36743 RVA: 0x001F03B4 File Offset: 0x001EE5B4
	public ActivityPhantomCollectData GetCurrentActivityDataById()
	{
		ActivityPhantomCollectData activityPhantomCollectData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityPhantomCollectData;
		if (activityPhantomCollectData == null)
		{
			return null;
		}
		return activityPhantomCollectData;
	}

	// Token: 0x06008F88 RID: 36744 RVA: 0x001F03E0 File Offset: 0x001EE5E0
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<PhantomCollectReward> PhantomCollectRewardReceiveRequest(int taskType)
	{
		ActivityPhantomCollectController.<PhantomCollectRewardReceiveRequest>d__10 <PhantomCollectRewardReceiveRequest>d__;
		<PhantomCollectRewardReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomCollectReward>.Create();
		<PhantomCollectRewardReceiveRequest>d__.<>4__this = this;
		<PhantomCollectRewardReceiveRequest>d__.taskType = taskType;
		<PhantomCollectRewardReceiveRequest>d__.<>1__state = -1;
		<PhantomCollectRewardReceiveRequest>d__.<>t__builder.Start<ActivityPhantomCollectController.<PhantomCollectRewardReceiveRequest>d__10>(ref <PhantomCollectRewardReceiveRequest>d__);
		return <PhantomCollectRewardReceiveRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17000C05 RID: 3077
	// (get) Token: 0x06008F89 RID: 36745 RVA: 0x001F042B File Offset: 0x001EE62B
	public static ActivityPhantomCollectController Instance
	{
		get
		{
			return ActivityPhantomCollectController._Instance;
		}
	}

	// Token: 0x06008F8A RID: 36746 RVA: 0x001F0432 File Offset: 0x001EE632
	public static ActivityPhantomCollectController GetOrCreateInstance()
	{
		if (ActivityPhantomCollectController._Instance == null)
		{
			ActivityPhantomCollectController.CreateInstance();
		}
		return ActivityPhantomCollectController._Instance;
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x001F0446 File Offset: 0x001EE646
	public static bool CreateInstance()
	{
		if (ActivityPhantomCollectController._Instance != null)
		{
			return true;
		}
		ActivityPhantomCollectController._Instance = new ActivityPhantomCollectController();
		return true;
	}

	// Token: 0x06008F8C RID: 36748 RVA: 0x001F045C File Offset: 0x001EE65C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008F8D RID: 36749 RVA: 0x001F045E File Offset: 0x001EE65E
	public static void ResetStaticDefaultValue()
	{
		ActivityPhantomCollectController._Instance = null;
	}

	// Token: 0x06008F8E RID: 36750 RVA: 0x001F0466 File Offset: 0x001EE666
	static ActivityPhantomCollectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPhantomCollectController.CreateStaticDefaultValue), new Action(ActivityPhantomCollectController.ResetStaticDefaultValue));
	}

	// Token: 0x04003F74 RID: 16244
	public int ActivityId;

	// Token: 0x04003F75 RID: 16245
	[Nullable(2)]
	private static ActivityPhantomCollectController _Instance;
}

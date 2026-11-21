using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200088F RID: 2191
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityPhantomCollectController : ActivityControllerBase
{
	// Token: 0x06006314 RID: 25364 RVA: 0x001F8DBA File Offset: 0x001F6FBA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomCollectUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomCollectUpdateNotify));
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x001F8DD8 File Offset: 0x001F6FD8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomCollectUpdateNotify);
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x001F8DEC File Offset: 0x001F6FEC
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

	// Token: 0x06006317 RID: 25367 RVA: 0x001F8EC5 File Offset: 0x001F70C5
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPhantomCollect";
	}

	// Token: 0x06006318 RID: 25368 RVA: 0x001F8ECC File Offset: 0x001F70CC
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewPhantomCollect();
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x001F8ED3 File Offset: 0x001F70D3
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityPhantomCollectData();
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x001F8EE6 File Offset: 0x001F70E6
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600631B RID: 25371 RVA: 0x001F8EE8 File Offset: 0x001F70E8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x001F8EEC File Offset: 0x001F70EC
	public ActivityPhantomCollectData GetCurrentActivityDataById()
	{
		ActivityPhantomCollectData activityPhantomCollectData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityPhantomCollectData;
		if (activityPhantomCollectData == null)
		{
			return null;
		}
		return activityPhantomCollectData;
	}

	// Token: 0x0600631D RID: 25373 RVA: 0x001F8F18 File Offset: 0x001F7118
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

	// Token: 0x17000C25 RID: 3109
	// (get) Token: 0x0600631E RID: 25374 RVA: 0x001F8F63 File Offset: 0x001F7163
	public static ActivityPhantomCollectController Instance
	{
		get
		{
			return ActivityPhantomCollectController._Instance;
		}
	}

	// Token: 0x0600631F RID: 25375 RVA: 0x001F8F6A File Offset: 0x001F716A
	public static ActivityPhantomCollectController GetOrCreateInstance()
	{
		if (ActivityPhantomCollectController._Instance == null)
		{
			ActivityPhantomCollectController.CreateInstance();
		}
		return ActivityPhantomCollectController._Instance;
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x001F8F7E File Offset: 0x001F717E
	public static bool CreateInstance()
	{
		if (ActivityPhantomCollectController._Instance != null)
		{
			return true;
		}
		ActivityPhantomCollectController._Instance = new ActivityPhantomCollectController();
		return true;
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x001F8F94 File Offset: 0x001F7194
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x001F8F96 File Offset: 0x001F7196
	public static void ResetStaticDefaultValue()
	{
		ActivityPhantomCollectController._Instance = null;
	}

	// Token: 0x06006323 RID: 25379 RVA: 0x001F8F9E File Offset: 0x001F719E
	static ActivityPhantomCollectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPhantomCollectController.CreateStaticDefaultValue), new Action(ActivityPhantomCollectController.ResetStaticDefaultValue));
	}

	// Token: 0x0400400C RID: 16396
	public int ActivityId;

	// Token: 0x0400400D RID: 16397
	[Nullable(2)]
	private static ActivityPhantomCollectController _Instance;
}

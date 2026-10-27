using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001092 RID: 4242
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRecommendController : ControllerBase
{
	// Token: 0x06006E79 RID: 28281 RVA: 0x001686A6 File Offset: 0x001668A6
	protected override bool OnInit()
	{
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x06006E7A RID: 28282 RVA: 0x001686AF File Offset: 0x001668AF
	protected override bool OnClear()
	{
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x06006E7B RID: 28283 RVA: 0x001686B8 File Offset: 0x001668B8
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ActivityRecommendNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveActivityRecommendNotify));
	}

	// Token: 0x06006E7C RID: 28284 RVA: 0x001686D6 File Offset: 0x001668D6
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ActivityRecommendNotify);
	}

	// Token: 0x06006E7D RID: 28285 RVA: 0x001686E8 File Offset: 0x001668E8
	public void OpenView()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRecommendView, null, null);
	}

	// Token: 0x06006E7E RID: 28286 RVA: 0x001686FC File Offset: 0x001668FC
	[NullableContext(2)]
	private void OnReceiveActivityRecommendNotify(IMessage msg, Net.CallbackStatus status)
	{
		ActivityRecommendNotify activityRecommendNotify = (ActivityRecommendNotify)msg;
		IReadOnlyList<ActivityRecommendOnePb> recommends = activityRecommendNotify.Recommends;
		IReadOnlyList<ActivityRecommendOnePb> recommendFallback = recommends ?? new List<ActivityRecommendOnePb>();
		ActivityRecommendModel instance = ActivityRecommendModel.Instance;
		if (instance != null)
		{
			instance.SetRecommendFallback(recommendFallback);
		}
		long redDotStartTimeLatest = activityRecommendNotify.RedDotStartTimeLatest;
		ActivityRecommendModel instance2 = ActivityRecommendModel.Instance;
		if (instance2 != null)
		{
			instance2.SetRedDotStartTimeLatest(redDotStartTimeLatest);
		}
		EventSystem.Instance.Emit(EEventName.RefreshActivityRecommendRedDot);
	}

	// Token: 0x17000925 RID: 2341
	// (get) Token: 0x06006E7F RID: 28287 RVA: 0x00168759 File Offset: 0x00166959
	public static ActivityRecommendController Instance
	{
		get
		{
			return ActivityRecommendController._Instance;
		}
	}

	// Token: 0x06006E80 RID: 28288 RVA: 0x00168760 File Offset: 0x00166960
	public static ActivityRecommendController GetOrCreateInstance()
	{
		if (ActivityRecommendController._Instance == null)
		{
			ActivityRecommendController.CreateInstance();
		}
		return ActivityRecommendController._Instance;
	}

	// Token: 0x06006E81 RID: 28289 RVA: 0x00168774 File Offset: 0x00166974
	public static bool CreateInstance()
	{
		if (ActivityRecommendController._Instance != null)
		{
			return true;
		}
		ActivityRecommendController._Instance = new ActivityRecommendController();
		return true;
	}

	// Token: 0x06006E82 RID: 28290 RVA: 0x0016878A File Offset: 0x0016698A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E83 RID: 28291 RVA: 0x0016878C File Offset: 0x0016698C
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendController._Instance = null;
	}

	// Token: 0x06006E84 RID: 28292 RVA: 0x00168794 File Offset: 0x00166994
	static ActivityRecommendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendController.CreateStaticDefaultValue), new Action(ActivityRecommendController.ResetStaticDefaultValue));
	}

	// Token: 0x04003323 RID: 13091
	[Nullable(2)]
	private static ActivityRecommendController _Instance;
}

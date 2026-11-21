using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000546 RID: 1350
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRecommendController : ControllerBase
{
	// Token: 0x0600420E RID: 16910 RVA: 0x00170FDA File Offset: 0x0016F1DA
	protected override bool OnInit()
	{
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x00170FE3 File Offset: 0x0016F1E3
	protected override bool OnClear()
	{
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00170FEC File Offset: 0x0016F1EC
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ActivityRecommendNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveActivityRecommendNotify));
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x0017100A File Offset: 0x0016F20A
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ActivityRecommendNotify);
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x0017101C File Offset: 0x0016F21C
	public void OpenView()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRecommendView, null, null);
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x00171030 File Offset: 0x0016F230
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

	// Token: 0x17000945 RID: 2373
	// (get) Token: 0x06004214 RID: 16916 RVA: 0x0017108D File Offset: 0x0016F28D
	public static ActivityRecommendController Instance
	{
		get
		{
			return ActivityRecommendController._Instance;
		}
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x00171094 File Offset: 0x0016F294
	public static ActivityRecommendController GetOrCreateInstance()
	{
		if (ActivityRecommendController._Instance == null)
		{
			ActivityRecommendController.CreateInstance();
		}
		return ActivityRecommendController._Instance;
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x001710A8 File Offset: 0x0016F2A8
	public static bool CreateInstance()
	{
		if (ActivityRecommendController._Instance != null)
		{
			return true;
		}
		ActivityRecommendController._Instance = new ActivityRecommendController();
		return true;
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x001710BE File Offset: 0x0016F2BE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004218 RID: 16920 RVA: 0x001710C0 File Offset: 0x0016F2C0
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendController._Instance = null;
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x001710C8 File Offset: 0x0016F2C8
	static ActivityRecommendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendController.CreateStaticDefaultValue), new Action(ActivityRecommendController.ResetStaticDefaultValue));
	}

	// Token: 0x040033BC RID: 13244
	[Nullable(2)]
	private static ActivityRecommendController _Instance;
}

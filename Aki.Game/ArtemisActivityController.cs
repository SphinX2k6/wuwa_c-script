using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x0200059B RID: 1435
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ArtemisActivityController : ActivityControllerBase
{
	// Token: 0x06004441 RID: 17473 RVA: 0x001786D7 File Offset: 0x001768D7
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ArtemisNodeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnArtemisNodeUpdateResponse));
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x001786F5 File Offset: 0x001768F5
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ArtemisNodeUpdateNotify);
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x00178707 File Offset: 0x00176907
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x00178709 File Offset: 0x00176909
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_AimisActivityMain";
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x00178710 File Offset: 0x00176910
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ArtemisSubView();
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x00178717 File Offset: 0x00176917
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ArtemisActivityData();
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x0017871E File Offset: 0x0017691E
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x00178724 File Offset: 0x00176924
	[NullableContext(2)]
	private void OnArtemisNodeUpdateResponse(IMessage msg, Net.CallbackStatus status)
	{
		ArtemisNodeUpdateNotify artemisNodeUpdateNotify = (ArtemisNodeUpdateNotify)msg;
		if (artemisNodeUpdateNotify == null)
		{
			return;
		}
		ActivityModel instance = ActivityModel.Instance;
		ArtemisActivityData artemisActivityData = ((instance != null) ? instance.GetActivityById(artemisNodeUpdateNotify.ActivityId) : null) as ArtemisActivityData;
		if (artemisActivityData != null)
		{
			artemisActivityData.SetUnlockIndex(artemisNodeUpdateNotify.UnlockIndex);
		}
		if (artemisActivityData != null)
		{
			artemisActivityData.SetRewardedIndex(artemisNodeUpdateNotify.RewardedIndex);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, artemisNodeUpdateNotify.ActivityId);
		EventSystem.Instance.Emit(EEventName.OnArtemisStateRefresh);
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x001787A4 File Offset: 0x001769A4
	public void RequestArtemisStatus(ArtemisActivityData data, int day, [Nullable(2)] Action<bool> callBack = null)
	{
		ArtemisNodeUpdateRequest artemisNodeUpdateRequest = ArtemisNodeUpdateRequest.Create();
		artemisNodeUpdateRequest.ActivityId = data.GetCacheActivityId;
		artemisNodeUpdateRequest.Index = day;
		Net.Instance.Call(ERequestMessageId.ArtemisNodeUpdateRequest, artemisNodeUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ArtemisNodeUpdateResponse artemisNodeUpdateResponse = (ArtemisNodeUpdateResponse)msg;
			if (callBack != null)
			{
				callBack(artemisNodeUpdateResponse == null || artemisNodeUpdateResponse.Error > ErrorCode.Success);
			}
			if (artemisNodeUpdateResponse != null)
			{
				if (artemisNodeUpdateResponse.Error == ErrorCode.Success)
				{
					ArtemisActivityData data2 = data;
					if (data2 != null)
					{
						data2.SetRewardedIndex(day);
					}
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.GetCacheActivityId);
					EventSystem.Instance.Emit(EEventName.OnArtemisStateRefresh);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(artemisNodeUpdateResponse.Error, 18649, null, true, true);
			}
		}, 0);
	}

	// Token: 0x170009A6 RID: 2470
	// (get) Token: 0x0600444A RID: 17482 RVA: 0x0017880C File Offset: 0x00176A0C
	public static ArtemisActivityController Instance
	{
		get
		{
			return ArtemisActivityController._Instance;
		}
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x00178813 File Offset: 0x00176A13
	public static ArtemisActivityController GetOrCreateInstance()
	{
		if (ArtemisActivityController._Instance == null)
		{
			ArtemisActivityController.CreateInstance();
		}
		return ArtemisActivityController._Instance;
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x00178827 File Offset: 0x00176A27
	public static bool CreateInstance()
	{
		if (ArtemisActivityController._Instance != null)
		{
			return true;
		}
		ArtemisActivityController._Instance = new ArtemisActivityController();
		return true;
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x0017883D File Offset: 0x00176A3D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x0017883F File Offset: 0x00176A3F
	public static void ResetStaticDefaultValue()
	{
		ArtemisActivityController._Instance = null;
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x00178847 File Offset: 0x00176A47
	static ArtemisActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ArtemisActivityController.CreateStaticDefaultValue), new Action(ArtemisActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x040034DB RID: 13531
	public int CurrentDayIndex;

	// Token: 0x040034DC RID: 13532
	[Nullable(2)]
	private static ArtemisActivityController _Instance;
}

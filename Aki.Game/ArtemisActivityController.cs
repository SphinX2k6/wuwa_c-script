using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020010E7 RID: 4327
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ArtemisActivityController : ActivityControllerBase
{
	// Token: 0x060070AB RID: 28843 RVA: 0x0016FD1B File Offset: 0x0016DF1B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ArtemisNodeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnArtemisNodeUpdateResponse));
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x0016FD39 File Offset: 0x0016DF39
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ArtemisNodeUpdateNotify);
	}

	// Token: 0x060070AD RID: 28845 RVA: 0x0016FD4B File Offset: 0x0016DF4B
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060070AE RID: 28846 RVA: 0x0016FD4D File Offset: 0x0016DF4D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_AimisActivityMain";
	}

	// Token: 0x060070AF RID: 28847 RVA: 0x0016FD54 File Offset: 0x0016DF54
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ArtemisSubView();
	}

	// Token: 0x060070B0 RID: 28848 RVA: 0x0016FD5B File Offset: 0x0016DF5B
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ArtemisActivityData();
	}

	// Token: 0x060070B1 RID: 28849 RVA: 0x0016FD62 File Offset: 0x0016DF62
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060070B2 RID: 28850 RVA: 0x0016FD68 File Offset: 0x0016DF68
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

	// Token: 0x060070B3 RID: 28851 RVA: 0x0016FDE8 File Offset: 0x0016DFE8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(artemisNodeUpdateResponse.Error, 26895, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17000986 RID: 2438
	// (get) Token: 0x060070B4 RID: 28852 RVA: 0x0016FE50 File Offset: 0x0016E050
	public static ArtemisActivityController Instance
	{
		get
		{
			return ArtemisActivityController._Instance;
		}
	}

	// Token: 0x060070B5 RID: 28853 RVA: 0x0016FE57 File Offset: 0x0016E057
	public static ArtemisActivityController GetOrCreateInstance()
	{
		if (ArtemisActivityController._Instance == null)
		{
			ArtemisActivityController.CreateInstance();
		}
		return ArtemisActivityController._Instance;
	}

	// Token: 0x060070B6 RID: 28854 RVA: 0x0016FE6B File Offset: 0x0016E06B
	public static bool CreateInstance()
	{
		if (ArtemisActivityController._Instance != null)
		{
			return true;
		}
		ArtemisActivityController._Instance = new ArtemisActivityController();
		return true;
	}

	// Token: 0x060070B7 RID: 28855 RVA: 0x0016FE81 File Offset: 0x0016E081
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060070B8 RID: 28856 RVA: 0x0016FE83 File Offset: 0x0016E083
	public static void ResetStaticDefaultValue()
	{
		ArtemisActivityController._Instance = null;
	}

	// Token: 0x060070B9 RID: 28857 RVA: 0x0016FE8B File Offset: 0x0016E08B
	static ArtemisActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ArtemisActivityController.CreateStaticDefaultValue), new Action(ArtemisActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04003442 RID: 13378
	public int CurrentDayIndex;

	// Token: 0x04003443 RID: 13379
	[Nullable(2)]
	private static ArtemisActivityController _Instance;
}

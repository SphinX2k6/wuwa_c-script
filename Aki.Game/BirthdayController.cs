using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000BBD RID: 3005
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BirthdayController : UiControllerBase
{
	// Token: 0x06007CDB RID: 31963 RVA: 0x0026AA24 File Offset: 0x00268C24
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
		EventSystem.Instance.Add<bool>(EEventName.TsSyncBirthdayResetState, new Action<bool>(this.TsSyncBirthdayResetState));
	}

	// Token: 0x06007CDC RID: 31964 RVA: 0x0026AA88 File Offset: 0x00268C88
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
		EventSystem.Instance.Remove(EEventName.TsSyncBirthdayResetState, new Action<bool>(this.TsSyncBirthdayResetState));
	}

	// Token: 0x06007CDD RID: 31965 RVA: 0x0026AAE9 File Offset: 0x00268CE9
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BirthDayInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthDayInfoNotify notify = (BirthDayInfoNotify)msg;
			BirthdayModel.Instance.UpdateBirthdayInfo(notify);
		});
	}

	// Token: 0x06007CDE RID: 31966 RVA: 0x0026AB1A File Offset: 0x00268D1A
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BirthDayInfoNotify);
	}

	// Token: 0x06007CDF RID: 31967 RVA: 0x0026AB2C File Offset: 0x00268D2C
	public static void TrySelectBirthDayCardRoleRequest(int roleId, int year)
	{
		int? selectedRoleId = BirthdayModel.Instance.GetSelectedRoleId(year);
		if (selectedRoleId != null && selectedRoleId.Value != 0)
		{
			return;
		}
		BirthDayCardRoleRequest birthDayCardRoleRequest = BirthDayCardRoleRequest.Create();
		birthDayCardRoleRequest.RoleID = roleId;
		birthDayCardRoleRequest.YearId = year;
		Net.Instance.Call(ERequestMessageId.BirthDayCardRoleRequest, birthDayCardRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthDayCardRoleResponse birthDayCardRoleResponse = (BirthDayCardRoleResponse)msg;
			if (birthDayCardRoleResponse == null)
			{
				return;
			}
			if (birthDayCardRoleResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(birthDayCardRoleResponse.ErrorCode, 22249, null, true, true);
				return;
			}
			BirthdayModel.Instance.SetSelectedRole(roleId, year);
		}, 0);
	}

	// Token: 0x06007CE0 RID: 31968 RVA: 0x0026ABAC File Offset: 0x00268DAC
	public static bool TryBirthDayRewardRequest(int year)
	{
		if (BirthdayModel.Instance.GetSelectedRoleId(year) != null)
		{
			return false;
		}
		BirthDayRewardRequest birthDayRewardRequest = BirthDayRewardRequest.Create();
		birthDayRewardRequest.YearId = year;
		Net.Instance.Call(ERequestMessageId.BirthDayRewardRequest, birthDayRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthDayRewardResponse birthDayRewardResponse = (BirthDayRewardResponse)msg;
			if (birthDayRewardResponse == null)
			{
				return;
			}
			if (birthDayRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(birthDayRewardResponse.ErrorCode, 22398, null, true, true);
				return;
			}
			BirthdayModel.Instance.SetIsReceiveBirthdayReward(true);
		}, 0);
		return true;
	}

	// Token: 0x06007CE1 RID: 31969 RVA: 0x0026AC10 File Offset: 0x00268E10
	public void TryOpenBirthdayView(bool isInstantly = false)
	{
		if (!BirthdayModel.Instance.GetBirthdayIsReset())
		{
			return;
		}
		if (!FunctionModel.Instance.IsOpen(10084))
		{
			return;
		}
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.Birthday, ESplashScreenType.Config, delegate()
		{
			int thisBirthdayYear = BirthdayModel.Instance.ThisBirthdayYear;
			UiManager.Instance.OpenView(EUiViewName.BirthdayRoleSelectView, new BirthdayInfo(BirthdayDefine.ETriggerType.Natural, thisBirthdayYear, null), null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
	}

	// Token: 0x06007CE2 RID: 31970 RVA: 0x0026AC70 File Offset: 0x00268E70
	public void UseBirthdayItem(int itemId)
	{
		int limitYear = ConfigBirthDayByItemId.GetConfig(itemId, true).Value.LimitYear;
		int? selectedRoleId = BirthdayModel.Instance.GetSelectedRoleId(limitYear);
		if (selectedRoleId != null && selectedRoleId.Value != 0)
		{
			BirthdayRepeatEnterEvent birthdayRepeatEnterEvent = new BirthdayRepeatEnterEvent();
			birthdayRepeatEnterEvent.i_item_id = itemId;
			birthdayRepeatEnterEvent.i_trigger_type = 1;
			birthdayRepeatEnterEvent.bird_round_id = ConfigBirthDayByItemId.GetConfig(itemId, true).Value.Id;
			LogReportController.Instance.LogReport(birthdayRepeatEnterEvent);
			UiManager.Instance.OpenView(EUiViewName.BirthdayLetterView, new BirthdayInfo(BirthdayDefine.ETriggerType.Item, limitYear, new int?(selectedRoleId.Value)), null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BirthdayRoleSelectView, new BirthdayInfo(BirthdayDefine.ETriggerType.Item, limitYear, null), null);
	}

	// Token: 0x06007CE3 RID: 31971 RVA: 0x0026AD3C File Offset: 0x00268F3C
	public void OnWorldDone()
	{
		bool flag = BirthdayModel.Instance.IsDuringBirthday();
		if (!BirthdayModel.Instance.IsReceiveBirthdayReward && flag)
		{
			this.TryOpenBirthdayView(false);
		}
	}

	// Token: 0x06007CE4 RID: 31972 RVA: 0x0026AD6C File Offset: 0x00268F6C
	public void OnCrossDayZone()
	{
		bool flag = BirthdayModel.Instance.IsDuringBirthday();
		if (!BirthdayModel.Instance.IsReceiveBirthdayReward && flag)
		{
			this.TryOpenBirthdayView(true);
		}
	}

	// Token: 0x06007CE5 RID: 31973 RVA: 0x0026AD9C File Offset: 0x00268F9C
	public void TsSyncBirthdayResetState(bool isReset)
	{
		BirthdayModel.Instance.SyncTsResetState(isReset);
	}

	// Token: 0x17000E1F RID: 3615
	// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x0026ADA9 File Offset: 0x00268FA9
	public static BirthdayController Instance
	{
		get
		{
			return BirthdayController._Instance;
		}
	}

	// Token: 0x06007CE7 RID: 31975 RVA: 0x0026ADB0 File Offset: 0x00268FB0
	public static BirthdayController GetOrCreateInstance()
	{
		if (BirthdayController._Instance == null)
		{
			BirthdayController.CreateInstance();
		}
		return BirthdayController._Instance;
	}

	// Token: 0x06007CE8 RID: 31976 RVA: 0x0026ADC4 File Offset: 0x00268FC4
	public static bool CreateInstance()
	{
		if (BirthdayController._Instance != null)
		{
			return true;
		}
		BirthdayController._Instance = new BirthdayController();
		return true;
	}

	// Token: 0x06007CE9 RID: 31977 RVA: 0x0026ADDA File Offset: 0x00268FDA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CEA RID: 31978 RVA: 0x0026ADDC File Offset: 0x00268FDC
	public static void ResetStaticDefaultValue()
	{
		BirthdayController._Instance = null;
	}

	// Token: 0x06007CEB RID: 31979 RVA: 0x0026ADE4 File Offset: 0x00268FE4
	static BirthdayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BirthdayController.CreateStaticDefaultValue), new Action(BirthdayController.ResetStaticDefaultValue));
	}

	// Token: 0x04004DBD RID: 19901
	[Nullable(2)]
	private static BirthdayController _Instance;
}

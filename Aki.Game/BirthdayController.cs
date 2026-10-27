using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001705 RID: 5893
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BirthdayController : UiControllerBase
{
	// Token: 0x0600A8FB RID: 43259 RVA: 0x00260608 File Offset: 0x0025E808
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
		EventSystem.Instance.Add<bool>(EEventName.TsSyncBirthdayResetState, new Action<bool>(this.TsSyncBirthdayResetState));
	}

	// Token: 0x0600A8FC RID: 43260 RVA: 0x0026066C File Offset: 0x0025E86C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.CrossDayZone, new Action(this.OnCrossDayZone));
		EventSystem.Instance.Remove(EEventName.TsSyncBirthdayResetState, new Action<bool>(this.TsSyncBirthdayResetState));
	}

	// Token: 0x0600A8FD RID: 43261 RVA: 0x002606CD File Offset: 0x0025E8CD
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BirthDayInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthDayInfoNotify notify = (BirthDayInfoNotify)msg;
			BirthdayModel.Instance.UpdateBirthdayInfo(notify);
		});
	}

	// Token: 0x0600A8FE RID: 43262 RVA: 0x002606FE File Offset: 0x0025E8FE
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BirthDayInfoNotify);
	}

	// Token: 0x0600A8FF RID: 43263 RVA: 0x00260710 File Offset: 0x0025E910
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(birthDayCardRoleResponse.ErrorCode, 16190, null, true, true);
				return;
			}
			BirthdayModel.Instance.SetSelectedRole(roleId, year);
		}, 0);
	}

	// Token: 0x0600A900 RID: 43264 RVA: 0x00260790 File Offset: 0x0025E990
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(birthDayRewardResponse.ErrorCode, 21898, null, true, true);
				return;
			}
			BirthdayModel.Instance.SetIsReceiveBirthdayReward(true);
		}, 0);
		return true;
	}

	// Token: 0x0600A901 RID: 43265 RVA: 0x002607F4 File Offset: 0x0025E9F4
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

	// Token: 0x0600A902 RID: 43266 RVA: 0x00260854 File Offset: 0x0025EA54
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

	// Token: 0x0600A903 RID: 43267 RVA: 0x00260920 File Offset: 0x0025EB20
	public void OnWorldDone()
	{
		bool flag = BirthdayModel.Instance.IsDuringBirthday();
		if (!BirthdayModel.Instance.IsReceiveBirthdayReward && flag)
		{
			this.TryOpenBirthdayView(false);
		}
	}

	// Token: 0x0600A904 RID: 43268 RVA: 0x00260950 File Offset: 0x0025EB50
	public void OnCrossDayZone()
	{
		bool flag = BirthdayModel.Instance.IsDuringBirthday();
		if (!BirthdayModel.Instance.IsReceiveBirthdayReward && flag)
		{
			this.TryOpenBirthdayView(true);
		}
	}

	// Token: 0x0600A905 RID: 43269 RVA: 0x00260980 File Offset: 0x0025EB80
	public void TsSyncBirthdayResetState(bool isReset)
	{
		BirthdayModel.Instance.SyncTsResetState(isReset);
	}

	// Token: 0x17000DFE RID: 3582
	// (get) Token: 0x0600A906 RID: 43270 RVA: 0x0026098D File Offset: 0x0025EB8D
	public static BirthdayController Instance
	{
		get
		{
			return BirthdayController._Instance;
		}
	}

	// Token: 0x0600A907 RID: 43271 RVA: 0x00260994 File Offset: 0x0025EB94
	public static BirthdayController GetOrCreateInstance()
	{
		if (BirthdayController._Instance == null)
		{
			BirthdayController.CreateInstance();
		}
		return BirthdayController._Instance;
	}

	// Token: 0x0600A908 RID: 43272 RVA: 0x002609A8 File Offset: 0x0025EBA8
	public static bool CreateInstance()
	{
		if (BirthdayController._Instance != null)
		{
			return true;
		}
		BirthdayController._Instance = new BirthdayController();
		return true;
	}

	// Token: 0x0600A909 RID: 43273 RVA: 0x002609BE File Offset: 0x0025EBBE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A90A RID: 43274 RVA: 0x002609C0 File Offset: 0x0025EBC0
	public static void ResetStaticDefaultValue()
	{
		BirthdayController._Instance = null;
	}

	// Token: 0x0600A90B RID: 43275 RVA: 0x002609C8 File Offset: 0x0025EBC8
	static BirthdayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BirthdayController.CreateStaticDefaultValue), new Action(BirthdayController.ResetStaticDefaultValue));
	}

	// Token: 0x04004D16 RID: 19734
	[Nullable(2)]
	private static BirthdayController _Instance;
}

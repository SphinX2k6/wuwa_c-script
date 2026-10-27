using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200110B RID: 4363
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AvignonController : ActivityControllerBase
{
	// Token: 0x060071F0 RID: 29168 RVA: 0x00174EA1 File Offset: 0x001730A1
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AvignonTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.AvignonInfoUpdate));
	}

	// Token: 0x060071F1 RID: 29169 RVA: 0x00174EBF File Offset: 0x001730BF
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AvignonTaskNotify);
	}

	// Token: 0x060071F2 RID: 29170 RVA: 0x00174ED4 File Offset: 0x001730D4
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (EUiViewName viewName in new List<EUiViewName>
		{
			EUiViewName.AvignonActivityMainView,
			EUiViewName.AvignonStageTaskView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060071F3 RID: 29171 RVA: 0x00174F4C File Offset: 0x0017314C
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060071F4 RID: 29172 RVA: 0x00174F4E File Offset: 0x0017314E
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_CollegeThemeGuide";
	}

	// Token: 0x060071F5 RID: 29173 RVA: 0x00174F55 File Offset: 0x00173155
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new AvignonActivitySubView();
	}

	// Token: 0x060071F6 RID: 29174 RVA: 0x00174F5C File Offset: 0x0017315C
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return AvignonModel.Instance.GetAvigonoProtocolData();
	}

	// Token: 0x060071F7 RID: 29175 RVA: 0x00174F68 File Offset: 0x00173168
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipAvignonView, null, null);
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x00174F7C File Offset: 0x0017317C
	[NullableContext(2)]
	private void AvignonInfoUpdate(IMessage msg, Net.CallbackStatus tatus)
	{
		AvignonTaskNotify notify = (AvignonTaskNotify)msg;
		AvignonModel.Instance.AvignonInfoUpdate(notify);
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x00174F9C File Offset: 0x0017319C
	public void RequestTaskReward(int taskId)
	{
		AvignonRewardRequest avignonRewardRequest = AvignonRewardRequest.Create();
		avignonRewardRequest.TaskId = taskId;
		int avignonActivityId = AvignonModel.Instance.GetAvignonActivityId();
		avignonRewardRequest.ActivityId = avignonActivityId;
		Net.Instance.Call(ERequestMessageId.AvignonRewardRequest, avignonRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AvignonRewardResponse avignonRewardResponse = (AvignonRewardResponse)msg;
			if (avignonRewardResponse == null)
			{
				return;
			}
			if (avignonRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(avignonRewardResponse.ErrorCode, 29765, null, true, true);
				return;
			}
			AvignonModel.Instance.UpdateTaskRewardStatus(taskId);
		}, 0);
	}

	// Token: 0x1700099D RID: 2461
	// (get) Token: 0x060071FA RID: 29178 RVA: 0x00174FF7 File Offset: 0x001731F7
	public static AvignonController Instance
	{
		get
		{
			return AvignonController._Instance;
		}
	}

	// Token: 0x060071FB RID: 29179 RVA: 0x00174FFE File Offset: 0x001731FE
	public static AvignonController GetOrCreateInstance()
	{
		if (AvignonController._Instance == null)
		{
			AvignonController.CreateInstance();
		}
		return AvignonController._Instance;
	}

	// Token: 0x060071FC RID: 29180 RVA: 0x00175012 File Offset: 0x00173212
	public static bool CreateInstance()
	{
		if (AvignonController._Instance != null)
		{
			return true;
		}
		AvignonController._Instance = new AvignonController();
		return true;
	}

	// Token: 0x060071FD RID: 29181 RVA: 0x00175028 File Offset: 0x00173228
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060071FE RID: 29182 RVA: 0x0017502A File Offset: 0x0017322A
	public static void ResetStaticDefaultValue()
	{
		AvignonController._Instance = null;
	}

	// Token: 0x060071FF RID: 29183 RVA: 0x00175032 File Offset: 0x00173232
	static AvignonController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonController.CreateStaticDefaultValue), new Action(AvignonController.ResetStaticDefaultValue));
	}

	// Token: 0x040034D9 RID: 13529
	[Nullable(2)]
	private static AvignonController _Instance;
}

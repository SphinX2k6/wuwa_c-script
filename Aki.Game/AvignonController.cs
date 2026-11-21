using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020005BF RID: 1471
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AvignonController : ActivityControllerBase
{
	// Token: 0x06004586 RID: 17798 RVA: 0x0017D85D File Offset: 0x0017BA5D
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AvignonTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.AvignonInfoUpdate));
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x0017D87B File Offset: 0x0017BA7B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AvignonTaskNotify);
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x0017D890 File Offset: 0x0017BA90
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

	// Token: 0x06004589 RID: 17801 RVA: 0x0017D908 File Offset: 0x0017BB08
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x0017D90A File Offset: 0x0017BB0A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_CollegeThemeGuide";
	}

	// Token: 0x0600458B RID: 17803 RVA: 0x0017D911 File Offset: 0x0017BB11
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new AvignonActivitySubView();
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x0017D918 File Offset: 0x0017BB18
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return AvignonModel.Instance.GetAvigonoProtocolData();
	}

	// Token: 0x0600458D RID: 17805 RVA: 0x0017D924 File Offset: 0x0017BB24
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipAvignonView, null, null);
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x0017D938 File Offset: 0x0017BB38
	[NullableContext(2)]
	private void AvignonInfoUpdate(IMessage msg, Net.CallbackStatus tatus)
	{
		AvignonTaskNotify notify = (AvignonTaskNotify)msg;
		AvignonModel.Instance.AvignonInfoUpdate(notify);
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x0017D958 File Offset: 0x0017BB58
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(avignonRewardResponse.ErrorCode, 26226, null, true, true);
				return;
			}
			AvignonModel.Instance.UpdateTaskRewardStatus(taskId);
		}, 0);
	}

	// Token: 0x170009BD RID: 2493
	// (get) Token: 0x06004590 RID: 17808 RVA: 0x0017D9B3 File Offset: 0x0017BBB3
	public static AvignonController Instance
	{
		get
		{
			return AvignonController._Instance;
		}
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x0017D9BA File Offset: 0x0017BBBA
	public static AvignonController GetOrCreateInstance()
	{
		if (AvignonController._Instance == null)
		{
			AvignonController.CreateInstance();
		}
		return AvignonController._Instance;
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x0017D9CE File Offset: 0x0017BBCE
	public static bool CreateInstance()
	{
		if (AvignonController._Instance != null)
		{
			return true;
		}
		AvignonController._Instance = new AvignonController();
		return true;
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x0017D9E4 File Offset: 0x0017BBE4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x0017D9E6 File Offset: 0x0017BBE6
	public static void ResetStaticDefaultValue()
	{
		AvignonController._Instance = null;
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x0017D9EE File Offset: 0x0017BBEE
	static AvignonController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonController.CreateStaticDefaultValue), new Action(AvignonController.ResetStaticDefaultValue));
	}

	// Token: 0x04003572 RID: 13682
	[Nullable(2)]
	private static AvignonController _Instance;
}

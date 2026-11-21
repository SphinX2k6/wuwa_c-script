using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C3F RID: 7231
public class NetWorkMaskView : UiTickViewBase
{
	// Token: 0x06011F45 RID: 73541 RVA: 0x0054859C File Offset: 0x0054679C
	[NullableContext(1)]
	public NetWorkMaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011F46 RID: 73542 RVA: 0x005485B1 File Offset: 0x005467B1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(this.ReConnectSuccess));
		EventSystem.Instance.Add(EEventName.ReConnectFail, new Action(this.ReConnectFail));
	}

	// Token: 0x06011F47 RID: 73543 RVA: 0x005485EB File Offset: 0x005467EB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.ReConnectSuccess));
		EventSystem.Instance.Remove(EEventName.ReConnectFail, new Action(this.ReConnectFail));
	}

	// Token: 0x06011F48 RID: 73544 RVA: 0x00548628 File Offset: 0x00546828
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011F49 RID: 73545 RVA: 0x005486B4 File Offset: 0x005468B4
	protected override void OnStart()
	{
		this.TotalTime = 0f;
		this.Number = 0;
		bool flag = ReConnectModel.Instance.IsRpcEmpty();
		int? intConfig = ConfigCommonParamById.GetIntConfig("network_mask_time");
		this.DelayTime = (float)(flag ? 100 : intConfig.GetValueOrDefault(100));
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06011F4A RID: 73546 RVA: 0x0054870D File Offset: 0x0054690D
	protected override void OnBeforeDestroy()
	{
		this.ClearConfirmId();
	}

	// Token: 0x06011F4B RID: 73547 RVA: 0x00548715 File Offset: 0x00546915
	private void ClearConfirmId()
	{
		if (this.ConfirmBoxId != null)
		{
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxId.Value, null);
			this.ConfirmBoxId = null;
		}
	}

	// Token: 0x06011F4C RID: 73548 RVA: 0x00548748 File Offset: 0x00546948
	private void TickTipsTimeVisible(float deltaTime)
	{
		if (this.DelayTime < 0f || Net.Instance.IsNotifyCallbackPaused())
		{
			return;
		}
		this.DelayTime -= deltaTime;
		if (this.DelayTime < 0f)
		{
			base.GetItem(0).SetUIActive(true);
			int length = ReConnectModel.Instance.GetUnResponsedRpcStr().Length;
		}
	}

	// Token: 0x06011F4D RID: 73549 RVA: 0x005487AC File Offset: 0x005469AC
	protected override void OnTick(float delta)
	{
		this.TotalTime += delta;
		if (this.TotalTime > 1000f)
		{
			this.TotalTime -= 1000f;
			if (base.GetText(1).IsUIActiveSelf())
			{
				this.Number++;
				if (this.Number >= ReconnectDefine.ellipsis.Count)
				{
					this.Number = 0;
				}
				LguiUtil.Instance.SetLocalText(base.GetText(1), "ReconnectingInfo", new <>z__ReadOnlySingleElementList<object>(ReconnectDefine.ellipsis[this.Number]));
			}
		}
		this.TickTipsTimeVisible(delta);
	}

	// Token: 0x06011F4E RID: 73550 RVA: 0x00548850 File Offset: 0x00546A50
	private void InitBoxItem()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.NetWorkMaskTip);
		confirmBoxDataNew.FunctionMap[0] = new Action(this.OkBtn);
		confirmBoxDataNew.FunctionMap[1] = new Action(this.BackBtn);
		confirmBoxDataNew.FunctionMap[2] = new Action(this.OkBtn);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, delegate(bool success, int viewId)
		{
			this.ConfirmBoxId = new int?(viewId);
		});
	}

	// Token: 0x06011F4F RID: 73551 RVA: 0x005488CB File Offset: 0x00546ACB
	private void BackBtn()
	{
		ReConnectController.Instance.Logout(ELogoutReason.NetWorkMaskViewBackBtn);
	}

	// Token: 0x06011F50 RID: 73552 RVA: 0x005488D8 File Offset: 0x00546AD8
	private void OkBtn()
	{
	}

	// Token: 0x06011F51 RID: 73553 RVA: 0x005488DA File Offset: 0x00546ADA
	private void ReConnectSuccess()
	{
		UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, null);
	}

	// Token: 0x06011F52 RID: 73554 RVA: 0x005488EC File Offset: 0x00546AEC
	private void ReConnectFail()
	{
		this.InitBoxItem();
	}

	// Token: 0x04009C94 RID: 40084
	private int Number;

	// Token: 0x04009C95 RID: 40085
	private float TotalTime;

	// Token: 0x04009C96 RID: 40086
	private int? ConfirmBoxId = new int?(0);

	// Token: 0x04009C97 RID: 40087
	private float DelayTime;
}

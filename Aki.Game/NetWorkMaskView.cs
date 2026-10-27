using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002754 RID: 10068
public class NetWorkMaskView : UiTickViewBase
{
	// Token: 0x06014A62 RID: 84578 RVA: 0x00539708 File Offset: 0x00537908
	[NullableContext(1)]
	public NetWorkMaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A63 RID: 84579 RVA: 0x0053971D File Offset: 0x0053791D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(this.ReConnectSuccess));
		EventSystem.Instance.Add(EEventName.ReConnectFail, new Action(this.ReConnectFail));
	}

	// Token: 0x06014A64 RID: 84580 RVA: 0x00539757 File Offset: 0x00537957
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.ReConnectSuccess));
		EventSystem.Instance.Remove(EEventName.ReConnectFail, new Action(this.ReConnectFail));
	}

	// Token: 0x06014A65 RID: 84581 RVA: 0x00539794 File Offset: 0x00537994
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

	// Token: 0x06014A66 RID: 84582 RVA: 0x00539820 File Offset: 0x00537A20
	protected override void OnStart()
	{
		this.TotalTime = 0f;
		this.Number = 0;
		bool flag = ReConnectModel.Instance.IsRpcEmpty();
		int? intConfig = ConfigCommonParamById.GetIntConfig("network_mask_time");
		this.DelayTime = (float)(flag ? 100 : intConfig.GetValueOrDefault(100));
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06014A67 RID: 84583 RVA: 0x00539879 File Offset: 0x00537A79
	protected override void OnBeforeDestroy()
	{
		this.ClearConfirmId();
	}

	// Token: 0x06014A68 RID: 84584 RVA: 0x00539881 File Offset: 0x00537A81
	private void ClearConfirmId()
	{
		if (this.ConfirmBoxId != null)
		{
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxId.Value, null);
			this.ConfirmBoxId = null;
		}
	}

	// Token: 0x06014A69 RID: 84585 RVA: 0x005398B4 File Offset: 0x00537AB4
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

	// Token: 0x06014A6A RID: 84586 RVA: 0x00539918 File Offset: 0x00537B18
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

	// Token: 0x06014A6B RID: 84587 RVA: 0x005399BC File Offset: 0x00537BBC
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

	// Token: 0x06014A6C RID: 84588 RVA: 0x00539A37 File Offset: 0x00537C37
	private void BackBtn()
	{
		ReConnectController.Instance.Logout(ELogoutReason.NetWorkMaskViewBackBtn);
	}

	// Token: 0x06014A6D RID: 84589 RVA: 0x00539A44 File Offset: 0x00537C44
	private void OkBtn()
	{
	}

	// Token: 0x06014A6E RID: 84590 RVA: 0x00539A46 File Offset: 0x00537C46
	private void ReConnectSuccess()
	{
		UiManager.Instance.CloseView(EUiViewName.NetWorkMaskView, null);
	}

	// Token: 0x06014A6F RID: 84591 RVA: 0x00539A58 File Offset: 0x00537C58
	private void ReConnectFail()
	{
		this.InitBoxItem();
	}

	// Token: 0x04009B3B RID: 39739
	private int Number;

	// Token: 0x04009B3C RID: 39740
	private float TotalTime;

	// Token: 0x04009B3D RID: 39741
	private int? ConfirmBoxId = new int?(0);

	// Token: 0x04009B3E RID: 39742
	private float DelayTime;
}

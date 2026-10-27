using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02002755 RID: 10069
public class PlayStationNetWorkMaskView : UiTickViewBase
{
	// Token: 0x06014A71 RID: 84593 RVA: 0x00539A6E File Offset: 0x00537C6E
	[NullableContext(1)]
	public PlayStationNetWorkMaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A72 RID: 84594 RVA: 0x00539A8C File Offset: 0x00537C8C
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

	// Token: 0x06014A73 RID: 84595 RVA: 0x00539B18 File Offset: 0x00537D18
	protected override void OnStart()
	{
		this.TotalTime = 0f;
		this.Number = 0;
		this.DelayTime = (float)ConfigCommonParamById.GetIntConfig("network_mask_time").GetValueOrDefault();
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06014A74 RID: 84596 RVA: 0x00539B5D File Offset: 0x00537D5D
	protected override void OnBeforeDestroy()
	{
		this.ClearConfirmId();
	}

	// Token: 0x06014A75 RID: 84597 RVA: 0x00539B65 File Offset: 0x00537D65
	private void ClearConfirmId()
	{
		if (this.ConfirmBoxId != null)
		{
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxId.Value, null);
			this.ConfirmBoxId = null;
		}
	}

	// Token: 0x06014A76 RID: 84598 RVA: 0x00539B96 File Offset: 0x00537D96
	protected override void OnTick(float delta)
	{
		if (!this.CurrentTryReConnectState)
		{
			return;
		}
		this.RefreshNumberText(delta);
		this.TickTipsTimeVisible(delta);
		this.CheckPlayStationNetWork(delta);
	}

	// Token: 0x06014A77 RID: 84599 RVA: 0x00539BB8 File Offset: 0x00537DB8
	private void CheckPlayStationNetWork(float delta)
	{
		this.CheckPlayStationNetWorkTime += delta;
		if (this.CheckPlayStationNetWorkTime > 1000f)
		{
			this.CheckPlayStationNetWorkTime = 0f;
			if (!this.CheckPlayStationNetWorkState())
			{
				this.CurrentTryCount++;
				if (this.CurrentTryCount > 15)
				{
					this.OnReConnectFail();
					return;
				}
			}
			else
			{
				this.OnReConnectSuccess();
			}
		}
	}

	// Token: 0x06014A78 RID: 84600 RVA: 0x00539C18 File Offset: 0x00537E18
	private void OnReConnectSuccess()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014A79 RID: 84601 RVA: 0x00539C21 File Offset: 0x00537E21
	private void OnReConnectFail()
	{
		this.CurrentTryReConnectState = false;
		this.InitBoxItem();
	}

	// Token: 0x06014A7A RID: 84602 RVA: 0x00539C30 File Offset: 0x00537E30
	private void InitBoxItem()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PlayStationConnectFail);
		confirmBoxDataNew.FunctionMap[0] = new Action(this.OkBtn);
		confirmBoxDataNew.FunctionMap[1] = new Action(this.BackBtn);
		confirmBoxDataNew.FunctionMap[2] = new Action(this.OkBtn);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, delegate(bool success, int viewId)
		{
			this.ConfirmBoxId = new int?(viewId);
		});
	}

	// Token: 0x06014A7B RID: 84603 RVA: 0x00539CAE File Offset: 0x00537EAE
	private void BackBtn()
	{
		ReConnectController.Instance.Logout(ELogoutReason.PsnUnAvailable);
	}

	// Token: 0x06014A7C RID: 84604 RVA: 0x00539CBB File Offset: 0x00537EBB
	private void OkBtn()
	{
		this.CurrentTryCount = 0;
		this.CurrentTryReConnectState = true;
		this.ClearConfirmId();
	}

	// Token: 0x06014A7D RID: 84605 RVA: 0x00539CD4 File Offset: 0x00537ED4
	private void RefreshNumberText(float delta)
	{
		this.TotalTime += delta;
		if (this.TotalTime > 1000f)
		{
			this.TotalTime -= 1000f;
			if (base.GetText(1).IsUIActiveSelf())
			{
				this.Number = (this.Number + 1) % ReconnectDefine.ellipsis.Count;
				LguiUtil.Instance.SetLocalText(base.GetText(1), "ReconnectingInfo", new <>z__ReadOnlySingleElementList<object>(ReconnectDefine.ellipsis[this.Number]));
			}
		}
	}

	// Token: 0x06014A7E RID: 84606 RVA: 0x00539D60 File Offset: 0x00537F60
	private void TickTipsTimeVisible(float deltaTime)
	{
		if (this.DelayTime < 0f)
		{
			return;
		}
		this.DelayTime -= deltaTime;
		if (this.DelayTime < 0f)
		{
			base.GetItem(0).SetUIActive(true);
		}
	}

	// Token: 0x06014A7F RID: 84607 RVA: 0x00539D98 File Offset: 0x00537F98
	private bool CheckPlayStationNetWorkState()
	{
		return Platform.Instance.IsPs5Platform() && PlatformSdkManagerNew.Instance.GetPlatformSdk().IsPlatformNetworkReachable();
	}

	// Token: 0x04009B3F RID: 39743
	private const int RETRYMAXCOUNT = 15;

	// Token: 0x04009B40 RID: 39744
	private const int CHECKGAP = 1000;

	// Token: 0x04009B41 RID: 39745
	private int? ConfirmBoxId;

	// Token: 0x04009B42 RID: 39746
	private int Number;

	// Token: 0x04009B43 RID: 39747
	private float TotalTime;

	// Token: 0x04009B44 RID: 39748
	private float DelayTime;

	// Token: 0x04009B45 RID: 39749
	private float CheckPlayStationNetWorkTime = 1000f;

	// Token: 0x04009B46 RID: 39750
	private int CurrentTryCount;

	// Token: 0x04009B47 RID: 39751
	private bool CurrentTryReConnectState = true;

	// Token: 0x02008DBE RID: 36286
	private static class EComponent
	{
		// Token: 0x0402E00F RID: 188431
		public const int TipsItem = 0;

		// Token: 0x0402E010 RID: 188432
		public const int TipsTxt = 1;

		// Token: 0x0402E011 RID: 188433
		public const int TipsBgSpr = 2;
	}
}

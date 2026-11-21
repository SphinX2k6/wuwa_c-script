using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02001C40 RID: 7232
public class PlayStationNetWorkMaskView : UiTickViewBase
{
	// Token: 0x06011F54 RID: 73556 RVA: 0x00548902 File Offset: 0x00546B02
	[NullableContext(1)]
	public PlayStationNetWorkMaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011F55 RID: 73557 RVA: 0x00548920 File Offset: 0x00546B20
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

	// Token: 0x06011F56 RID: 73558 RVA: 0x005489AC File Offset: 0x00546BAC
	protected override void OnStart()
	{
		this.TotalTime = 0f;
		this.Number = 0;
		this.DelayTime = (float)ConfigCommonParamById.GetIntConfig("network_mask_time").GetValueOrDefault();
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06011F57 RID: 73559 RVA: 0x005489F1 File Offset: 0x00546BF1
	protected override void OnBeforeDestroy()
	{
		this.ClearConfirmId();
	}

	// Token: 0x06011F58 RID: 73560 RVA: 0x005489F9 File Offset: 0x00546BF9
	private void ClearConfirmId()
	{
		if (this.ConfirmBoxId != null)
		{
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxId.Value, null);
			this.ConfirmBoxId = null;
		}
	}

	// Token: 0x06011F59 RID: 73561 RVA: 0x00548A2A File Offset: 0x00546C2A
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

	// Token: 0x06011F5A RID: 73562 RVA: 0x00548A4C File Offset: 0x00546C4C
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

	// Token: 0x06011F5B RID: 73563 RVA: 0x00548AAC File Offset: 0x00546CAC
	private void OnReConnectSuccess()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011F5C RID: 73564 RVA: 0x00548AB5 File Offset: 0x00546CB5
	private void OnReConnectFail()
	{
		this.CurrentTryReConnectState = false;
		this.InitBoxItem();
	}

	// Token: 0x06011F5D RID: 73565 RVA: 0x00548AC4 File Offset: 0x00546CC4
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

	// Token: 0x06011F5E RID: 73566 RVA: 0x00548B42 File Offset: 0x00546D42
	private void BackBtn()
	{
		ReConnectController.Instance.Logout(ELogoutReason.PsnUnAvailable);
	}

	// Token: 0x06011F5F RID: 73567 RVA: 0x00548B4F File Offset: 0x00546D4F
	private void OkBtn()
	{
		this.CurrentTryCount = 0;
		this.CurrentTryReConnectState = true;
		this.ClearConfirmId();
	}

	// Token: 0x06011F60 RID: 73568 RVA: 0x00548B68 File Offset: 0x00546D68
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

	// Token: 0x06011F61 RID: 73569 RVA: 0x00548BF4 File Offset: 0x00546DF4
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

	// Token: 0x06011F62 RID: 73570 RVA: 0x00548C2C File Offset: 0x00546E2C
	private bool CheckPlayStationNetWorkState()
	{
		return Platform.Instance.IsPs5Platform() && PlatformSdkManagerNew.Instance.GetPlatformSdk().IsPlatformNetworkReachable();
	}

	// Token: 0x04009C98 RID: 40088
	private const int RETRYMAXCOUNT = 15;

	// Token: 0x04009C99 RID: 40089
	private const int CHECKGAP = 1000;

	// Token: 0x04009C9A RID: 40090
	private int? ConfirmBoxId;

	// Token: 0x04009C9B RID: 40091
	private int Number;

	// Token: 0x04009C9C RID: 40092
	private float TotalTime;

	// Token: 0x04009C9D RID: 40093
	private float DelayTime;

	// Token: 0x04009C9E RID: 40094
	private float CheckPlayStationNetWorkTime = 1000f;

	// Token: 0x04009C9F RID: 40095
	private int CurrentTryCount;

	// Token: 0x04009CA0 RID: 40096
	private bool CurrentTryReConnectState = true;

	// Token: 0x02007F47 RID: 32583
	private static class EComponent
	{
		// Token: 0x04029326 RID: 168742
		public const int TipsItem = 0;

		// Token: 0x04029327 RID: 168743
		public const int TipsTxt = 1;

		// Token: 0x04029328 RID: 168744
		public const int TipsBgSpr = 2;
	}
}

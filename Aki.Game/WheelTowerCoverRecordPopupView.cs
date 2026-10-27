using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001613 RID: 5651
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerCoverRecordPopupView : UiViewBase
{
	// Token: 0x06009F0B RID: 40715 RVA: 0x0022CD1C File Offset: 0x0022AF1C
	[NullableContext(1)]
	public WheelTowerCoverRecordPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F0C RID: 40716 RVA: 0x0022CD28 File Offset: 0x0022AF28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickCancel));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009F0D RID: 40717 RVA: 0x0022CE98 File Offset: 0x0022B098
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerCoverRecordPopupView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerCoverRecordPopupView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F0E RID: 40718 RVA: 0x0022CEDC File Offset: 0x0022B0DC
	protected override void OnStart()
	{
		IWheelTowerCoverRecordViewData wheelTowerCoverRecordViewData = this.OpenParam as IWheelTowerCoverRecordViewData;
		if (wheelTowerCoverRecordViewData == null)
		{
			return;
		}
		this.ConfirmCallback = wheelTowerCoverRecordViewData.OnClickConfirm;
		this.CancelCallback = wheelTowerCoverRecordViewData.OnClickCancel;
		string id = wheelTowerCoverRecordViewData.IsEndless ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelTowerRecordPopup_Title", new <>z__ReadOnlyArray<object>(new object[]
		{
			ConfigMultiTextLang.GetLocalTextNew(id, null),
			wheelTowerCoverRecordViewData.TeamNum.ToString()
		}));
		WheelTowerCoverRecordItem oldItem = this.OldItem;
		if (oldItem != null)
		{
			oldItem.Refresh(wheelTowerCoverRecordViewData.BeforeData);
		}
		WheelTowerCoverRecordItem newItem = this.NewItem;
		if (newItem != null)
		{
			newItem.Refresh(wheelTowerCoverRecordViewData.AfterData);
		}
		WheelTowerCoverRecordResetScoreItem resetScoreItem = this.ResetScoreItem;
		if (resetScoreItem != null)
		{
			resetScoreItem.Refresh(wheelTowerCoverRecordViewData.BeforeData, wheelTowerCoverRecordViewData.AfterData);
		}
		WheelTowerCoverRecordResetBossItem resetBossItem = this.ResetBossItem;
		if (resetBossItem != null)
		{
			resetBossItem.Refresh(wheelTowerCoverRecordViewData.BeforeData, wheelTowerCoverRecordViewData.AfterData);
		}
		WheelTowerModel.Instance.BlockEndlessUnlockTips = false;
	}

	// Token: 0x06009F0F RID: 40719 RVA: 0x0022CFD5 File Offset: 0x0022B1D5
	private void OnClickCancel()
	{
		Action cancelCallback = this.CancelCallback;
		if (cancelCallback != null)
		{
			cancelCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x06009F10 RID: 40720 RVA: 0x0022CFEF File Offset: 0x0022B1EF
	private void OnClickConfirm()
	{
		Action confirmCallback = this.ConfirmCallback;
		if (confirmCallback != null)
		{
			confirmCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400476B RID: 18283
	private WheelTowerCoverRecordItem OldItem;

	// Token: 0x0400476C RID: 18284
	private WheelTowerCoverRecordItem NewItem;

	// Token: 0x0400476D RID: 18285
	private WheelTowerCoverRecordResetScoreItem ResetScoreItem;

	// Token: 0x0400476E RID: 18286
	private WheelTowerCoverRecordResetBossItem ResetBossItem;

	// Token: 0x0400476F RID: 18287
	private Action ConfirmCallback;

	// Token: 0x04004770 RID: 18288
	private Action CancelCallback;
}

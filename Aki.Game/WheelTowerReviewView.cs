using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001633 RID: 5683
public class WheelTowerReviewView : UiViewBase
{
	// Token: 0x06009FD2 RID: 40914 RVA: 0x0023214F File Offset: 0x0023034F
	[NullableContext(1)]
	public WheelTowerReviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FD3 RID: 40915 RVA: 0x00232158 File Offset: 0x00230358
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009FD4 RID: 40916 RVA: 0x00232220 File Offset: 0x00230420
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerReviewView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerReviewView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FD5 RID: 40917 RVA: 0x00232264 File Offset: 0x00230464
	private void RefreshTitle(int cycleId)
	{
		NewTowerParam? towerConfig = WheelTowerConfig.Instance.GetTowerConfig(cycleId);
		string item = (towerConfig != null) ? (ConfigMultiTextLang.GetLocalTextNew(towerConfig.Value.CycleName, null) ?? string.Empty) : string.Empty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PrefabTextItem_1919949392_Text", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x06009FD6 RID: 40918 RVA: 0x002322C8 File Offset: 0x002304C8
	protected override void OnBeforeDestroy()
	{
		Action onCloseCallback = this.OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		this.OnCloseCallback = null;
	}

	// Token: 0x06009FD7 RID: 40919 RVA: 0x002322E2 File Offset: 0x002304E2
	private void OnConfirmBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04004889 RID: 18569
	[Nullable(2)]
	private Action OnCloseCallback;

	// Token: 0x0400488A RID: 18570
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerModeResultItem, NewTowerLevelRecordPb> ResultScrollView;
}

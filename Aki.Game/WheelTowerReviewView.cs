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

// Token: 0x02000AEB RID: 2795
public class WheelTowerReviewView : UiViewBase
{
	// Token: 0x060073B0 RID: 29616 RVA: 0x0023BF9B File Offset: 0x0023A19B
	[NullableContext(1)]
	public WheelTowerReviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073B1 RID: 29617 RVA: 0x0023BFA4 File Offset: 0x0023A1A4
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

	// Token: 0x060073B2 RID: 29618 RVA: 0x0023C06C File Offset: 0x0023A26C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerReviewView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerReviewView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060073B3 RID: 29619 RVA: 0x0023C0B0 File Offset: 0x0023A2B0
	private void RefreshTitle(int cycleId)
	{
		NewTowerParam? towerConfig = WheelTowerConfig.Instance.GetTowerConfig(cycleId);
		string item = (towerConfig != null) ? (ConfigMultiTextLang.GetLocalTextNew(towerConfig.Value.CycleName, null) ?? string.Empty) : string.Empty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PrefabTextItem_1919949392_Text", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x060073B4 RID: 29620 RVA: 0x0023C114 File Offset: 0x0023A314
	protected override void OnBeforeDestroy()
	{
		Action onCloseCallback = this.OnCloseCallback;
		if (onCloseCallback != null)
		{
			onCloseCallback();
		}
		this.OnCloseCallback = null;
	}

	// Token: 0x060073B5 RID: 29621 RVA: 0x0023C12E File Offset: 0x0023A32E
	private void OnConfirmBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400492F RID: 18735
	[Nullable(2)]
	private Action OnCloseCallback;

	// Token: 0x04004930 RID: 18736
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerModeResultItem, NewTowerLevelRecordPb> ResultScrollView;
}

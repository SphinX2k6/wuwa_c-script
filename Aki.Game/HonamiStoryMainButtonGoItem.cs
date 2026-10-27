using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EDA RID: 7898
public class HonamiStoryMainButtonGoItem : UiPanelBase
{
	// Token: 0x0600F307 RID: 62215 RVA: 0x003A93DC File Offset: 0x003A75DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnEnter));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F308 RID: 62216 RVA: 0x003A94E8 File Offset: 0x003A76E8
	public void RefreshButtonState()
	{
		bool flag = FunctionModel.Instance.IsOpen(10112);
		base.GetItem(3).SetUIActive(!flag);
		base.GetItem(4).SetUIActive(flag);
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			base.GetItem(2).SetUIActive(false);
			return;
		}
		bool uiactive = activityData.IsLevelSelectHasViewRedDot();
		base.GetItem(2).SetUIActive(uiactive);
	}

	// Token: 0x0600F309 RID: 62217 RVA: 0x003A9553 File Offset: 0x003A7753
	[NullableContext(1)]
	public void SetOnBtnEnterCallback(Action callback)
	{
		this.OnBtnEnterCallback = callback;
	}

	// Token: 0x0600F30A RID: 62218 RVA: 0x003A955C File Offset: 0x003A775C
	private void OnBtnEnter()
	{
		Action onBtnEnterCallback = this.OnBtnEnterCallback;
		if (onBtnEnterCallback == null)
		{
			return;
		}
		onBtnEnterCallback();
	}

	// Token: 0x04007093 RID: 28819
	[Nullable(2)]
	private Action OnBtnEnterCallback;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D6B RID: 3435
[NullableContext(2)]
[Nullable(0)]
public class InputMultiKeyItemGroup : UiPanelBase
{
	// Token: 0x06008CF9 RID: 36089 RVA: 0x002AA540 File Offset: 0x002A8740
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008CFA RID: 36090 RVA: 0x002AA5CC File Offset: 0x002A87CC
	protected override UniTask OnBeforeStartAsync()
	{
		InputMultiKeyItemGroup.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputMultiKeyItemGroup.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008CFB RID: 36091 RVA: 0x002AA60F File Offset: 0x002A880F
	protected override void OnStart()
	{
	}

	// Token: 0x06008CFC RID: 36092 RVA: 0x002AA611 File Offset: 0x002A8811
	protected override void OnBeforeDestroy()
	{
		this.OneInputMultiKeyItem = null;
		this.TwoInputMultiKeyItem = null;
	}

	// Token: 0x06008CFD RID: 36093 RVA: 0x002AA621 File Offset: 0x002A8821
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		if (this.InputActionOrAxisKeyItemGroup != null)
		{
			this.RefreshInternal(this.InputActionOrAxisKeyItemGroup);
		}
	}

	// Token: 0x06008CFE RID: 36094 RVA: 0x002AA653 File Offset: 0x002A8853
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x06008CFF RID: 36095 RVA: 0x002AA671 File Offset: 0x002A8871
	private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
	{
		if (this.InputActionOrAxisKeyItemGroup == null)
		{
			return;
		}
		this.RefreshInternal(this.InputActionOrAxisKeyItemGroup);
	}

	// Token: 0x06008D00 RID: 36096 RVA: 0x002AA688 File Offset: 0x002A8888
	[NullableContext(1)]
	public void Refresh(InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup)
	{
		this.InputActionOrAxisKeyItemGroup = inputActionOrAxisKeyItemGroup;
		this.RefreshInternal(inputActionOrAxisKeyItemGroup);
	}

	// Token: 0x06008D01 RID: 36097 RVA: 0x002AA698 File Offset: 0x002A8898
	[NullableContext(1)]
	private void RefreshInternal(InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup)
	{
		if (this.RootItem == null || !this.RootItem.IsValid())
		{
			return;
		}
		InputActionOrAxisKeyItem singleActionOrAxisKeyItem = inputActionOrAxisKeyItemGroup.SingleActionOrAxisKeyItem;
		InputActionOrAxisKeyItem doubleActionOrAxisKeyItem = inputActionOrAxisKeyItemGroup.DoubleActionOrAxisKeyItem;
		string linkString = inputActionOrAxisKeyItemGroup.LinkString;
		UUIText text = base.GetText(0);
		InputMultiKeyItem oneInputMultiKeyItem = this.OneInputMultiKeyItem;
		if (oneInputMultiKeyItem != null)
		{
			oneInputMultiKeyItem.RefreshByActionOrAxis(singleActionOrAxisKeyItem, false);
		}
		InputMultiKeyItem oneInputMultiKeyItem2 = this.OneInputMultiKeyItem;
		if (oneInputMultiKeyItem2 != null)
		{
			oneInputMultiKeyItem2.SetActive(true);
		}
		if (doubleActionOrAxisKeyItem != null)
		{
			InputMultiKeyItem twoInputMultiKeyItem = this.TwoInputMultiKeyItem;
			if (twoInputMultiKeyItem != null)
			{
				twoInputMultiKeyItem.RefreshByActionOrAxis(doubleActionOrAxisKeyItem, false);
			}
			InputMultiKeyItem twoInputMultiKeyItem2 = this.TwoInputMultiKeyItem;
			if (twoInputMultiKeyItem2 != null)
			{
				twoInputMultiKeyItem2.SetActive(true);
			}
			text.SetText(linkString ?? "/", true);
			text.SetUIActive(true);
			return;
		}
		InputMultiKeyItem twoInputMultiKeyItem3 = this.TwoInputMultiKeyItem;
		if (twoInputMultiKeyItem3 != null)
		{
			twoInputMultiKeyItem3.SetActive(false);
		}
		text.SetUIActive(false);
	}

	// Token: 0x06008D02 RID: 36098 RVA: 0x002AA757 File Offset: 0x002A8957
	public void SetEnable(bool bEnable, bool bForce = false)
	{
		if (this.IsEnable == bEnable && !bForce)
		{
			return;
		}
		if (bEnable)
		{
			this.RootItem.SetAlpha(1f);
		}
		else
		{
			this.RootItem.SetAlpha(0.2f);
		}
		this.IsEnable = bEnable;
	}

	// Token: 0x040054A4 RID: 21668
	private InputMultiKeyItem OneInputMultiKeyItem;

	// Token: 0x040054A5 RID: 21669
	private InputMultiKeyItem TwoInputMultiKeyItem;

	// Token: 0x040054A6 RID: 21670
	private bool IsEnable;

	// Token: 0x040054A7 RID: 21671
	private InputActionOrAxisKeyItemGroup InputActionOrAxisKeyItemGroup;

	// Token: 0x02006FC8 RID: 28616
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402483F RID: 149567
		public const int AddText = 0;

		// Token: 0x04024840 RID: 149568
		public const int KeyItem1 = 1;

		// Token: 0x04024841 RID: 149569
		public const int KeyItem2 = 2;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018B2 RID: 6322
[NullableContext(2)]
[Nullable(0)]
public class InputMultiKeyItemGroup : UiPanelBase
{
	// Token: 0x0600B910 RID: 47376 RVA: 0x0029FE00 File Offset: 0x0029E000
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

	// Token: 0x0600B911 RID: 47377 RVA: 0x0029FE8C File Offset: 0x0029E08C
	protected override UniTask OnBeforeStartAsync()
	{
		InputMultiKeyItemGroup.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputMultiKeyItemGroup.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B912 RID: 47378 RVA: 0x0029FECF File Offset: 0x0029E0CF
	protected override void OnStart()
	{
	}

	// Token: 0x0600B913 RID: 47379 RVA: 0x0029FED1 File Offset: 0x0029E0D1
	protected override void OnBeforeDestroy()
	{
		this.OneInputMultiKeyItem = null;
		this.TwoInputMultiKeyItem = null;
	}

	// Token: 0x0600B914 RID: 47380 RVA: 0x0029FEE1 File Offset: 0x0029E0E1
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		if (this.InputActionOrAxisKeyItemGroup != null)
		{
			this.RefreshInternal(this.InputActionOrAxisKeyItemGroup);
		}
	}

	// Token: 0x0600B915 RID: 47381 RVA: 0x0029FF13 File Offset: 0x0029E113
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600B916 RID: 47382 RVA: 0x0029FF31 File Offset: 0x0029E131
	private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
	{
		if (this.InputActionOrAxisKeyItemGroup == null)
		{
			return;
		}
		this.RefreshInternal(this.InputActionOrAxisKeyItemGroup);
	}

	// Token: 0x0600B917 RID: 47383 RVA: 0x0029FF48 File Offset: 0x0029E148
	[NullableContext(1)]
	public void Refresh(InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup)
	{
		this.InputActionOrAxisKeyItemGroup = inputActionOrAxisKeyItemGroup;
		this.RefreshInternal(inputActionOrAxisKeyItemGroup);
	}

	// Token: 0x0600B918 RID: 47384 RVA: 0x0029FF58 File Offset: 0x0029E158
	[NullableContext(1)]
	private void RefreshInternal(InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup)
	{
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

	// Token: 0x0600B919 RID: 47385 RVA: 0x002A0001 File Offset: 0x0029E201
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

	// Token: 0x040053F9 RID: 21497
	private InputMultiKeyItem OneInputMultiKeyItem;

	// Token: 0x040053FA RID: 21498
	private InputMultiKeyItem TwoInputMultiKeyItem;

	// Token: 0x040053FB RID: 21499
	private bool IsEnable;

	// Token: 0x040053FC RID: 21500
	private InputActionOrAxisKeyItemGroup InputActionOrAxisKeyItemGroup;

	// Token: 0x02007E41 RID: 32321
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029512 RID: 169234
		public const int AddText = 0;

		// Token: 0x04029513 RID: 169235
		public const int KeyItem1 = 1;

		// Token: 0x04029514 RID: 169236
		public const int KeyItem2 = 2;
	}
}

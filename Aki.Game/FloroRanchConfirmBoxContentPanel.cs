using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019DF RID: 6623
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchConfirmBoxContentPanel : UiPanelBase
{
	// Token: 0x0600C17E RID: 49534 RVA: 0x002BAAF1 File Offset: 0x002B8CF1
	public FloroRanchConfirmBoxContentPanel(ConfirmBoxDataNew confirmBoxData, [Nullable(new byte[]
	{
		1,
		2
	})] Action<Action<bool>> closeFunc)
	{
		this.ConfirmBoxData = confirmBoxData;
		this.CloseFunc = closeFunc;
	}

	// Token: 0x0600C17F RID: 49535 RVA: 0x002BAB24 File Offset: 0x002B8D24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C180 RID: 49536 RVA: 0x002BAC50 File Offset: 0x002B8E50
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
	{
		if (param == null)
		{
			return null;
		}
		return (param as ConfirmBoxDataNew).CustomPopType;
	}

	// Token: 0x0600C181 RID: 49537 RVA: 0x002BAC75 File Offset: 0x002B8E75
	public void OnClose()
	{
		this.SelectedIndex = -1;
		this.ConfirmBoxButtonClick();
	}

	// Token: 0x0600C182 RID: 49538 RVA: 0x002BAC84 File Offset: 0x002B8E84
	protected void ConfirmBoxButtonClick()
	{
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
		if (func != null && !func(this.SelectedIndex))
		{
			Action action = null;
			ConfirmBoxDataNew confirmBoxData2 = this.ConfirmBoxData;
			if (confirmBoxData2 != null)
			{
				Dictionary<int, Action> functionMap = confirmBoxData2.FunctionMap;
				if (functionMap != null)
				{
					functionMap.TryGetValue(this.SelectedIndex, out action);
				}
			}
			if (action != null)
			{
				action();
				return;
			}
		}
		else
		{
			this.CloseFunc(delegate(bool _)
			{
				Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
				if (closeFunction == null)
				{
					return;
				}
				closeFunction();
			});
		}
	}

	// Token: 0x0600C183 RID: 49539 RVA: 0x002BAD00 File Offset: 0x002B8F00
	private void HandleSelectedIndexWhenClose()
	{
		if (this.SelectedIndex != -1)
		{
			return;
		}
		if (this.Config.Value.ButtonTextLength == 1 || this.ConfirmBoxData.IsEscViewTriggerCallBack)
		{
			this.SelectedIndex = 1;
			return;
		}
		this.SelectedIndex = 0;
	}

	// Token: 0x0600C184 RID: 49540 RVA: 0x002BAD4C File Offset: 0x002B8F4C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchConfirmBoxContentPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchConfirmBoxContentPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C185 RID: 49541 RVA: 0x002BAD90 File Offset: 0x002B8F90
	public void InitPowerItem(IUiPopFrameInterface childPopView)
	{
		if (this.ConfirmBoxData.ShowPowerItem)
		{
			PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
			if (overPowerCurrencyItem != null)
			{
				UUIItem originalItem = overPowerCurrencyItem.GetOriginalItem();
				if (originalItem != null)
				{
					UUIItem inParent;
					if (childPopView == null)
					{
						inParent = null;
					}
					else
					{
						CommonPopViewBase popItem = childPopView.PopItem;
						inParent = ((popItem != null) ? popItem.GetCostParent() : null);
					}
					originalItem.SetUIParent(inParent, false);
				}
			}
			PowerCurrencyItem powerCurrencyItem = this.PowerCurrencyItem;
			if (powerCurrencyItem != null)
			{
				UUIItem originalItem2 = powerCurrencyItem.GetOriginalItem();
				if (originalItem2 != null)
				{
					UUIItem inParent2;
					if (childPopView == null)
					{
						inParent2 = null;
					}
					else
					{
						CommonPopViewBase popItem2 = childPopView.PopItem;
						inParent2 = ((popItem2 != null) ? popItem2.GetCostParent() : null);
					}
					originalItem2.SetUIParent(inParent2, false);
				}
			}
			this.PowerCurrencyItem.ShowWithoutText(5);
			PowerCurrencyItem powerCurrencyItem2 = this.PowerCurrencyItem;
			if (powerCurrencyItem2 == null)
			{
				return;
			}
			powerCurrencyItem2.SetButtonFunction(delegate(int _)
			{
				PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
			});
		}
	}

	// Token: 0x0600C186 RID: 49542 RVA: 0x002BAE54 File Offset: 0x002B9054
	protected UniTask InitButton()
	{
		FloroRanchConfirmBoxContentPanel.<InitButton>d__17 <InitButton>d__;
		<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButton>d__.<>4__this = this;
		<InitButton>d__.<>1__state = -1;
		<InitButton>d__.<>t__builder.Start<FloroRanchConfirmBoxContentPanel.<InitButton>d__17>(ref <InitButton>d__);
		return <InitButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C187 RID: 49543 RVA: 0x002BAE98 File Offset: 0x002B9098
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
	{
		FloroRanchConfirmBoxContentPanel.<CreateButton>d__18 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.uiItem = uiItem;
		<CreateButton>d__.index = index;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<FloroRanchConfirmBoxContentPanel.<CreateButton>d__18>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C188 RID: 49544 RVA: 0x002BAEF4 File Offset: 0x002B90F4
	private void ResetButtonList()
	{
		int i = 0;
		int count = this.ButtonList.Count;
		while (i < count)
		{
			this.ButtonList[i].Destroy(null);
			i++;
		}
		this.ButtonList = new List<ConfirmBoxButton>();
	}

	// Token: 0x0600C189 RID: 49545 RVA: 0x002BAF36 File Offset: 0x002B9136
	private void ToggleClick(EToggleState state)
	{
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(state == EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600C18A RID: 49546 RVA: 0x002BAF50 File Offset: 0x002B9150
	private void InitToggle()
	{
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		UUIText text = base.GetText(2);
		extendToggle.RootUIComp.Get().SetUIActive(confirmBoxData.HasToggle);
		this.ToggleFunction = null;
		if (!confirmBoxData.HasToggle || text == null)
		{
			return;
		}
		if (StringUtils.IsBlank(confirmBoxData.ToggleText))
		{
			if (!StringUtils.IsBlank(confirmBoxData.ToggleTextKey))
			{
				LguiUtil.Instance.SetLocalTextNew(text, confirmBoxData.ToggleTextKey, Array.Empty<object>());
			}
			else
			{
				extendToggle.RootUIComp.Get().SetUIActive(false);
			}
		}
		else
		{
			text.SetText(confirmBoxData.ToggleText, true);
		}
		this.ToggleFunction = confirmBoxData.GetToggleFunction();
	}

	// Token: 0x0600C18B RID: 49547 RVA: 0x002BB004 File Offset: 0x002B9204
	protected override void OnBeforeDestroy()
	{
		this.ResetButtonList();
		this.HandleSelectedIndexWhenClose();
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		Action action;
		if (((confirmBoxData != null) ? confirmBoxData.FunctionMap : null) != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
		{
			action();
		}
		ConfirmBoxDataNew confirmBoxData2 = this.ConfirmBoxData;
		if (confirmBoxData2 != null)
		{
			Action destroyFunction = confirmBoxData2.DestroyFunction;
			if (destroyFunction != null)
			{
				destroyFunction();
			}
		}
		PowerCurrencyItem powerCurrencyItem = this.PowerCurrencyItem;
		if (powerCurrencyItem != null)
		{
			powerCurrencyItem.Destroy(null);
		}
		PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
		if (overPowerCurrencyItem == null)
		{
			return;
		}
		overPowerCurrencyItem.Destroy(null);
	}

	// Token: 0x04005929 RID: 22825
	protected List<ConfirmBoxButton> ButtonList = new List<ConfirmBoxButton>();

	// Token: 0x0400592A RID: 22826
	protected ConfirmBox? Config;

	// Token: 0x0400592B RID: 22827
	protected int SelectedIndex = -1;

	// Token: 0x0400592C RID: 22828
	protected List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

	// Token: 0x0400592D RID: 22829
	[Nullable(2)]
	private PowerCurrencyItem PowerCurrencyItem;

	// Token: 0x0400592E RID: 22830
	[Nullable(2)]
	private PowerCurrencyItem OverPowerCurrencyItem;

	// Token: 0x0400592F RID: 22831
	private readonly ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x04005930 RID: 22832
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Action<Action<bool>> CloseFunc;

	// Token: 0x04005931 RID: 22833
	[Nullable(2)]
	protected Action<bool> ToggleFunction;

	// Token: 0x02007F09 RID: 32521
	[NullableContext(0)]
	private class EFloroRanchConfirmBoxContentDefine
	{
		// Token: 0x04029803 RID: 169987
		public const int ContentText = 0;

		// Token: 0x04029804 RID: 169988
		public const int Toggle = 1;

		// Token: 0x04029805 RID: 169989
		public const int ToggleText = 2;

		// Token: 0x04029806 RID: 169990
		public const int ButtonRootItem = 3;

		// Token: 0x04029807 RID: 169991
		public const int ButtonCancel = 4;

		// Token: 0x04029808 RID: 169992
		public const int ButtonConfirm = 5;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019E1 RID: 6625
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsConfirmBoxView : UiViewBase
{
	// Token: 0x0600C197 RID: 49559 RVA: 0x002BB380 File Offset: 0x002B9580
	public RacingBetsConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C198 RID: 49560 RVA: 0x002BB3A0 File Offset: 0x002B95A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C199 RID: 49561 RVA: 0x002BB530 File Offset: 0x002B9730
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsConfirmBoxView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsConfirmBoxView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C19A RID: 49562 RVA: 0x002BB574 File Offset: 0x002B9774
	protected override void OnStart()
	{
		UiViewBase attachView = (this.OpenParam as ConfirmBoxDataNew).AttachView;
		UUIItem uuiitem = (attachView != null) ? attachView.GetRootItem() : null;
		if (uuiitem != null)
		{
			UUIItem uuiitem2 = this.ChildPopView.GetPopViewOriginalActor().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIParent(uuiitem, false);
		}
	}

	// Token: 0x0600C19B RID: 49563 RVA: 0x002BB5CC File Offset: 0x002B97CC
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.SetBackBtnShowState(this.Config.Value.NeedClose);
		}
		IUiPopFrameInterface childPopView2 = this.ChildPopView;
		if (childPopView2 != null)
		{
			childPopView2.PopItem.SetMaskResponsibleState(this.Config.Value.NeedMaskClose);
		}
		IUiPopFrameInterface childPopView3 = this.ChildPopView;
		if (childPopView3 != null)
		{
			childPopView3.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
		}
		if (this.ConfirmBoxData.ShowPowerItem)
		{
			PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
			if (overPowerCurrencyItem != null)
			{
				UUIItem originalItem = overPowerCurrencyItem.GetOriginalItem();
				if (originalItem != null)
				{
					IUiPopFrameInterface childPopView4 = this.ChildPopView;
					UUIItem inParent;
					if (childPopView4 == null)
					{
						inParent = null;
					}
					else
					{
						CommonPopViewBase popItem = childPopView4.PopItem;
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
					IUiPopFrameInterface childPopView5 = this.ChildPopView;
					UUIItem inParent2;
					if (childPopView5 == null)
					{
						inParent2 = null;
					}
					else
					{
						CommonPopViewBase popItem2 = childPopView5.PopItem;
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

	// Token: 0x0600C19C RID: 49564 RVA: 0x002BB709 File Offset: 0x002B9909
	protected override void OnAfterShow()
	{
		Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
		if (afterShowFunction == null)
		{
			return;
		}
		afterShowFunction();
	}

	// Token: 0x0600C19D RID: 49565 RVA: 0x002BB720 File Offset: 0x002B9920
	protected override void OnBeforeHide()
	{
		if (this.LastHide)
		{
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action beforePlayCloseFunction = confirmBoxData.BeforePlayCloseFunction;
			if (beforePlayCloseFunction == null)
			{
				return;
			}
			beforePlayCloseFunction();
		}
	}

	// Token: 0x0600C19E RID: 49566 RVA: 0x002BB744 File Offset: 0x002B9944
	protected override void OnBeforeDestroy()
	{
		this.ResetButtonList();
		this.HandleSelectedIndexWhenClose();
		Action action;
		if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
		{
			action();
		}
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		if (confirmBoxData != null)
		{
			Action destroyFunction = confirmBoxData.DestroyFunction;
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

	// Token: 0x0600C19F RID: 49567 RVA: 0x002BB7C7 File Offset: 0x002B99C7
	protected void OnClose()
	{
		this.SelectedIndex = -1;
		this.ConfirmBoxButtonClick();
	}

	// Token: 0x0600C1A0 RID: 49568 RVA: 0x002BB7D8 File Offset: 0x002B99D8
	protected void ConfirmBoxButtonClick()
	{
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
		if (func != null && !func(this.SelectedIndex))
		{
			Action action;
			if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
			{
				action();
				return;
			}
		}
		else
		{
			base.CloseMe(delegate(bool _)
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

	// Token: 0x0600C1A1 RID: 49569 RVA: 0x002BB848 File Offset: 0x002B9A48
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

	// Token: 0x0600C1A2 RID: 49570 RVA: 0x002BB894 File Offset: 0x002B9A94
	protected UniTask InitButton()
	{
		RacingBetsConfirmBoxView.<InitButton>d__19 <InitButton>d__;
		<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButton>d__.<>4__this = this;
		<InitButton>d__.<>1__state = -1;
		<InitButton>d__.<>t__builder.Start<RacingBetsConfirmBoxView.<InitButton>d__19>(ref <InitButton>d__);
		return <InitButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C1A3 RID: 49571 RVA: 0x002BB8D8 File Offset: 0x002B9AD8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
	{
		RacingBetsConfirmBoxView.<CreateButton>d__20 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.uiItem = uiItem;
		<CreateButton>d__.index = index;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<RacingBetsConfirmBoxView.<CreateButton>d__20>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C1A4 RID: 49572 RVA: 0x002BB934 File Offset: 0x002B9B34
	private void ResetButtonList()
	{
		int i = 0;
		int num = this.ButtonList.Length;
		while (i < num)
		{
			this.ButtonList[i].Destroy(null);
			i++;
		}
		this.ButtonList = new ConfirmBoxButton[0];
	}

	// Token: 0x0600C1A5 RID: 49573 RVA: 0x002BB970 File Offset: 0x002B9B70
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005935 RID: 22837
	protected ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

	// Token: 0x04005936 RID: 22838
	protected ConfirmBox? Config;

	// Token: 0x04005937 RID: 22839
	[Nullable(2)]
	protected ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x04005938 RID: 22840
	protected int SelectedIndex;

	// Token: 0x04005939 RID: 22841
	protected readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

	// Token: 0x0400593A RID: 22842
	[Nullable(2)]
	private PowerCurrencyItem PowerCurrencyItem;

	// Token: 0x0400593B RID: 22843
	[Nullable(2)]
	private PowerCurrencyItem OverPowerCurrencyItem;

	// Token: 0x02007F11 RID: 32529
	[NullableContext(0)]
	private class EConfirmBoxViewDefine
	{
		// Token: 0x04029827 RID: 170023
		public const int ButtonClose = 0;

		// Token: 0x04029828 RID: 170024
		public const int ButtonCancel = 1;

		// Token: 0x04029829 RID: 170025
		public const int ButtonConfirm = 2;

		// Token: 0x0402982A RID: 170026
		public const int ContentText = 3;

		// Token: 0x0402982B RID: 170027
		public const int ContentText2 = 4;

		// Token: 0x0402982C RID: 170028
		public const int TitleText = 5;

		// Token: 0x0402982D RID: 170029
		public const int BtnMask = 6;

		// Token: 0x0402982E RID: 170030
		public const int ItemBtnRoot = 7;
	}
}

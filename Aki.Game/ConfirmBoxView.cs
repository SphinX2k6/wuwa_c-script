using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu.SubViews;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019DD RID: 6621
[NullableContext(1)]
[Nullable(0)]
public class ConfirmBoxView : UiViewBase, IExtraUiPopFrameType, IUiViewResource
{
	// Token: 0x0600C157 RID: 49495 RVA: 0x002B9BC2 File Offset: 0x002B7DC2
	public ConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C158 RID: 49496 RVA: 0x002B9BE4 File Offset: 0x002B7DE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C159 RID: 49497 RVA: 0x002B9DB8 File Offset: 0x002B7FB8
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		if (param == null)
		{
			return null;
		}
		return (param as ConfirmBoxDataNew).CustomPopType;
	}

	// Token: 0x0600C15A RID: 49498 RVA: 0x002B9DDD File Offset: 0x002B7FDD
	public string GetExtraResourceId([Nullable(2)] object param)
	{
		ConfirmBoxDataNew confirmBoxDataNew = param as ConfirmBoxDataNew;
		return ((confirmBoxDataNew != null) ? confirmBoxDataNew.CustomResourceId : null) ?? "";
	}

	// Token: 0x0600C15B RID: 49499 RVA: 0x002B9DFA File Offset: 0x002B7FFA
	protected void OnClose()
	{
		this.SelectedIndex = -1;
		this.ConfirmBoxButtonClick();
	}

	// Token: 0x0600C15C RID: 49500 RVA: 0x002B9E0C File Offset: 0x002B800C
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

	// Token: 0x0600C15D RID: 49501 RVA: 0x002B9E7C File Offset: 0x002B807C
	private void TryUploadLog()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName logUploadView = EUiViewName.LogUploadView;
		LogUploadOpenParam logUploadOpenParam = new LogUploadOpenParam();
		logUploadOpenParam.OpenSourceType = new EKuroSdkOpenCustomerServerType?(EKuroSdkOpenCustomerServerType.Setting);
		logUploadOpenParam.AutoStartUpload = new bool?(true);
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		logUploadOpenParam.ErrorCode = ((confirmBoxData != null) ? confirmBoxData.ErrorCode : null);
		instance.OpenView(logUploadView, logUploadOpenParam, null);
	}

	// Token: 0x0600C15E RID: 49502 RVA: 0x002B9ED8 File Offset: 0x002B80D8
	private void HandleSelectedIndexWhenClose()
	{
		if (this.SelectedIndex != -1)
		{
			return;
		}
		if ((this.Config != null && this.Config.GetValueOrDefault().ButtonTextLength == 1) || this.ConfirmBoxData.IsEscViewTriggerCallBack)
		{
			this.SelectedIndex = 1;
			return;
		}
		this.SelectedIndex = 0;
	}

	// Token: 0x0600C15F RID: 49503 RVA: 0x002B9F30 File Offset: 0x002B8130
	protected override float OnGetTimeDilation()
	{
		ConfirmBoxDataNew confirmBoxDataNew = this.OpenParam as ConfirmBoxDataNew;
		if (confirmBoxDataNew == null)
		{
			return 1f;
		}
		ConfirmBox? confirmBoxConfig = ConfirmBoxConfig.Instance.GetConfirmBoxConfig((int)confirmBoxDataNew.ConfigId);
		return (float)((confirmBoxConfig != null) ? confirmBoxConfig.GetValueOrDefault().TimeDilation : 1);
	}

	// Token: 0x0600C160 RID: 49504 RVA: 0x002B9F80 File Offset: 0x002B8180
	protected override UniTask OnBeforeStartAsync()
	{
		ConfirmBoxView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ConfirmBoxView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C161 RID: 49505 RVA: 0x002B9FC4 File Offset: 0x002B81C4
	protected override void OnStart()
	{
		UiViewBase attachView = (this.OpenParam as ConfirmBoxDataNew).AttachView;
		UUIItem uuiitem = (attachView != null) ? attachView.GetRootItem() : null;
		if (uuiitem != null)
		{
			(this.ChildPopView.GetPopViewOriginalActor().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIParent(uuiitem, false);
		}
	}

	// Token: 0x0600C162 RID: 49506 RVA: 0x002BA018 File Offset: 0x002B8218
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.SetBackBtnShowState(this.Config != null && this.Config.GetValueOrDefault().NeedClose);
		}
		IUiPopFrameInterface childPopView2 = this.ChildPopView;
		if (childPopView2 != null)
		{
			childPopView2.PopItem.SetMaskResponsibleState(this.Config != null && this.Config.GetValueOrDefault().NeedMaskClose);
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

	// Token: 0x0600C163 RID: 49507 RVA: 0x002BA16D File Offset: 0x002B836D
	protected override void OnAfterShow()
	{
		Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
		if (afterShowFunction == null)
		{
			return;
		}
		afterShowFunction();
	}

	// Token: 0x0600C164 RID: 49508 RVA: 0x002BA184 File Offset: 0x002B8384
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

	// Token: 0x0600C165 RID: 49509 RVA: 0x002BA1A8 File Offset: 0x002B83A8
	protected UniTask InitButton()
	{
		ConfirmBoxView.<InitButton>d__23 <InitButton>d__;
		<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButton>d__.<>4__this = this;
		<InitButton>d__.<>1__state = -1;
		<InitButton>d__.<>t__builder.Start<ConfirmBoxView.<InitButton>d__23>(ref <InitButton>d__);
		return <InitButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C166 RID: 49510 RVA: 0x002BA1EC File Offset: 0x002B83EC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
	{
		ConfirmBoxView.<CreateButton>d__24 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.uiItem = uiItem;
		<CreateButton>d__.index = index;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<ConfirmBoxView.<CreateButton>d__24>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C167 RID: 49511 RVA: 0x002BA248 File Offset: 0x002B8448
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

	// Token: 0x0600C168 RID: 49512 RVA: 0x002BA284 File Offset: 0x002B8484
	protected void InitPropItem()
	{
		ULGUIBehaviour scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		int count = this.ConfirmBoxData.ItemIdMap.Count;
		UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(count > 0);
		}
		if (count == 0)
		{
			return;
		}
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		foreach (KeyValuePair<int, int> keyValuePair in this.ConfirmBoxData.ItemIdMap)
		{
			list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
		}
		this.PropScrollView.RefreshByData<ValueTuple<int, int>>(list, null);
	}

	// Token: 0x0600C169 RID: 49513 RVA: 0x002BA344 File Offset: 0x002B8544
	private ILayoutItem<CommonItemSmallItemGrid> CreatePropItem(object tempData, UUIItem uiItem, int index)
	{
		ValueTuple<int, int> valueTuple = (ValueTuple<int, int>)tempData;
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.Initialize(uiItem.GetOwner());
		commonItemSmallItemGrid.RefreshByConfigId(valueTuple.Item1, new int?(valueTuple.Item2), null, false, false);
		return new LayoutItem<CommonItemSmallItemGrid>
		{
			Key = index,
			Value = commonItemSmallItemGrid
		};
	}

	// Token: 0x0600C16A RID: 49514 RVA: 0x002BA39C File Offset: 0x002B859C
	private void ToggleClick(EToggleState toggleState)
	{
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(toggleState == EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600C16B RID: 49515 RVA: 0x002BA3B8 File Offset: 0x002B85B8
	private void InitToggle()
	{
		ConfirmBoxDataNew data = this.OpenParam as ConfirmBoxDataNew;
		if (data != null && !data.HasToggle)
		{
			ConfirmBox? confirmBoxConfig = ConfirmBoxConfig.Instance.GetConfirmBoxConfig((int)data.ConfigId);
			if (confirmBoxConfig != null && confirmBoxConfig.GetValueOrDefault().ToggleType == 1)
			{
				data.HasToggle = true;
				data.ToggleTextKey = "Text_Confirmation_Box_Prompt";
				data.SetToggleFunction(delegate(bool isSelectOn)
				{
					ConfirmBoxModel instance = ConfirmBoxModel.Instance;
					if (instance == null)
					{
						return;
					}
					if (isSelectOn)
					{
						instance.NotShowAgainSet.Add(data.ConfigId);
						return;
					}
					instance.NotShowAgainSet.Remove(data.ConfigId);
				});
			}
			else if (confirmBoxConfig != null && confirmBoxConfig.GetValueOrDefault().ToggleType == 2)
			{
				data.HasToggle = true;
				data.ToggleTextKey = "PrefabTextItem_136241376_Text";
			}
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		UUIText text = base.GetText(7);
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem != null)
		{
			ConfirmBoxDataNew data2 = data;
			uuiitem.SetUIActive(data2 != null && data2.HasToggle);
		}
		this.ToggleFunction = null;
		if (data == null || !data.HasToggle || text == null)
		{
			return;
		}
		if (StringUtils.IsBlank(data.ToggleText))
		{
			if (!StringUtils.IsBlank(data.ToggleTextKey))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.ToggleTextKey, Array.Empty<object>());
			}
			else
			{
				UUIItem uuiitem2 = extendToggle.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(false);
				}
			}
		}
		else
		{
			text.SetText(data.ToggleText, true);
		}
		this.ToggleFunction = data.GetToggleFunction();
	}

	// Token: 0x0600C16C RID: 49516 RVA: 0x002BA574 File Offset: 0x002B8774
	protected override void OnBeforeDestroy()
	{
		this.ResetButtonList();
		GenericScrollView<CommonItemSmallItemGrid> propScrollView = this.PropScrollView;
		if (propScrollView != null)
		{
			propScrollView.ClearChildren();
		}
		this.HandleSelectedIndexWhenClose();
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		bool flag = extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		ConfirmBox? config = this.Config;
		if (config != null && config.GetValueOrDefault().ToggleType == 2 && flag)
		{
			this.TryUploadLog();
		}
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

	// Token: 0x0400591B RID: 22811
	protected ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

	// Token: 0x0400591C RID: 22812
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<CommonItemSmallItemGrid> PropScrollView;

	// Token: 0x0400591D RID: 22813
	protected ConfirmBox? Config;

	// Token: 0x0400591E RID: 22814
	[Nullable(2)]
	protected ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x0400591F RID: 22815
	protected int SelectedIndex;

	// Token: 0x04005920 RID: 22816
	protected readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

	// Token: 0x04005921 RID: 22817
	[Nullable(2)]
	private PowerCurrencyItem PowerCurrencyItem;

	// Token: 0x04005922 RID: 22818
	[Nullable(2)]
	private PowerCurrencyItem OverPowerCurrencyItem;

	// Token: 0x04005923 RID: 22819
	[Nullable(2)]
	protected Action<bool> ToggleFunction;

	// Token: 0x02007EFD RID: 32509
	[NullableContext(0)]
	private class EConfirmBoxViewDefine
	{
		// Token: 0x040297C9 RID: 169929
		public const int TitleText = 0;

		// Token: 0x040297CA RID: 169930
		public const int ContentText = 1;

		// Token: 0x040297CB RID: 169931
		public const int ButtonRootItem = 2;

		// Token: 0x040297CC RID: 169932
		public const int PropScrollView = 3;

		// Token: 0x040297CD RID: 169933
		public const int ButtonCancel = 4;

		// Token: 0x040297CE RID: 169934
		public const int ButtonConfirm = 5;

		// Token: 0x040297CF RID: 169935
		public const int Toggle = 6;

		// Token: 0x040297D0 RID: 169936
		public const int ToggleText = 7;

		// Token: 0x040297D1 RID: 169937
		public const int TipBar = 8;

		// Token: 0x040297D2 RID: 169938
		public const int TipTxt = 9;

		// Token: 0x040297D3 RID: 169939
		public const int SprTipBarBg = 10;
	}
}

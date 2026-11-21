using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001875 RID: 6261
[NullableContext(1)]
[Nullable(0)]
public class PayShopSwitchItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x0600F7EB RID: 63467 RVA: 0x00488620 File Offset: 0x00486820
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnExtendToggleToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F7EC RID: 63468 RVA: 0x0048876C File Offset: 0x0048696C
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600F7ED RID: 63469 RVA: 0x004887BB File Offset: 0x004869BB
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F7EE RID: 63470 RVA: 0x004887D4 File Offset: 0x004869D4
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600F7EF RID: 63471 RVA: 0x004887DC File Offset: 0x004869DC
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600F7F0 RID: 63472 RVA: 0x004887EA File Offset: 0x004869EA
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600F7F1 RID: 63473 RVA: 0x00488803 File Offset: 0x00486A03
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600F7F2 RID: 63474 RVA: 0x00488815 File Offset: 0x00486A15
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x0600F7F3 RID: 63475 RVA: 0x00488830 File Offset: 0x00486A30
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600F7F4 RID: 63476 RVA: 0x00488832 File Offset: 0x00486A32
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600F7F5 RID: 63477 RVA: 0x0048883C File Offset: 0x00486A3C
	public void UpdateView(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
		this.RootItem.SetUIActive(payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.Enable);
		this.RefreshSpriteBg(payShopId, tabId);
		this.RefreshTextureBg(payShopId, tabId);
		this.RefreshCountDown(payShopId, tabId);
	}

	// Token: 0x0600F7F6 RID: 63478 RVA: 0x004888A4 File Offset: 0x00486AA4
	private void RefreshSpriteBg(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		if (payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.SpriteBgPath != "")
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(payShopTabDataByPayShopIdAndTabId.SpriteBgPath);
			ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(resourcePath, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				if (sprite != null)
				{
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
					if (uiExtendToggleSpriteTransition != null)
					{
						uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_CheckedUnHover, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition2 = base.GetUiExtendToggleSpriteTransition(3);
					if (uiExtendToggleSpriteTransition2 != null)
					{
						uiExtendToggleSpriteTransition2.SetStateSprite(EToggleTransitionState.ETT_CheckedPressed, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition3 = base.GetUiExtendToggleSpriteTransition(3);
					if (uiExtendToggleSpriteTransition3 == null)
					{
						return;
					}
					uiExtendToggleSpriteTransition3.SetStateSprite(EToggleTransitionState.ETT_CheckedHover, sprite, false);
				}
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
		}
	}

	// Token: 0x0600F7F7 RID: 63479 RVA: 0x00488904 File Offset: 0x00486B04
	private void RefreshTextureBg(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		UUITexture texture = base.GetTexture(4);
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		if (payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.TextureBgPath != "")
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(payShopTabDataByPayShopIdAndTabId.TextureBgPath);
			base.SetTextureByPath(resourcePath, texture, null, null);
			texture.SetUIActive(true);
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x0600F7F8 RID: 63480 RVA: 0x00488970 File Offset: 0x00486B70
	public void RefreshCountDown(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		UUIItem item = base.GetItem(5);
		UUIText text = base.GetText(6);
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		if (payShopTabDataByPayShopIdAndTabId == null)
		{
			item.SetUIActive(false);
			text.SetText("", true);
			return;
		}
		long beginTime = payShopTabDataByPayShopIdAndTabId.BeginTime;
		long endTime = payShopTabDataByPayShopIdAndTabId.EndTime;
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (serverTime >= (double)beginTime && serverTime <= (double)endTime)
		{
			item.SetUIActive(true);
			double remainTime = (double)endTime - serverTime;
			string countDownTextFormat = TimeUtil.Instance.GetCountDownTextFormat10(remainTime);
			text.SetText(countDownTextFormat, true);
			return;
		}
		item.SetUIActive(false);
		text.SetText("", true);
	}

	// Token: 0x0600F7F9 RID: 63481 RVA: 0x00488A13 File Offset: 0x00486C13
	public void UpdateTitle(string title)
	{
		base.GetText(0).SetText(title, true);
	}

	// Token: 0x0600F7FA RID: 63482 RVA: 0x00488A24 File Offset: 0x00486C24
	public void BindRedDot(ERedDotName redDotName, int tabId = 0)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(2);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TabId = tabId;
		RedDotController.Instance.BindRedDot(redDotName, item, null, tabId);
	}

	// Token: 0x0600F7FB RID: 63483 RVA: 0x00488A60 File Offset: 0x00486C60
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), this.TabId);
			this.RedDotName = null;
			this.TabId = 0;
		}
	}

	// Token: 0x04008ADB RID: 35547
	private ERedDotName? RedDotName;

	// Token: 0x04008ADC RID: 35548
	private int TabId;

	// Token: 0x02007ABD RID: 31421
	[NullableContext(0)]
	private class EPayShopSwitchItem
	{
		// Token: 0x04027CB1 RID: 162993
		public const int Name = 0;

		// Token: 0x04027CB2 RID: 162994
		public const int SwitchToggle = 1;

		// Token: 0x04027CB3 RID: 162995
		public const int RedDot = 2;

		// Token: 0x04027CB4 RID: 162996
		public const int SpriteTransitionNum = 3;

		// Token: 0x04027CB5 RID: 162997
		public const int TextureBg = 4;

		// Token: 0x04027CB6 RID: 162998
		public const int CountDownItem = 5;

		// Token: 0x04027CB7 RID: 162999
		public const int CountDownText = 6;
	}
}

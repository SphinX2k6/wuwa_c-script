using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002390 RID: 9104
[NullableContext(1)]
[Nullable(0)]
public class PayShopSwitchItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06012339 RID: 74553 RVA: 0x0047B2D0 File Offset: 0x004794D0
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

	// Token: 0x0601233A RID: 74554 RVA: 0x0047B41C File Offset: 0x0047961C
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0601233B RID: 74555 RVA: 0x0047B46B File Offset: 0x0047966B
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601233C RID: 74556 RVA: 0x0047B484 File Offset: 0x00479684
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0601233D RID: 74557 RVA: 0x0047B48C File Offset: 0x0047968C
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0601233E RID: 74558 RVA: 0x0047B49A File Offset: 0x0047969A
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0601233F RID: 74559 RVA: 0x0047B4B3 File Offset: 0x004796B3
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x06012340 RID: 74560 RVA: 0x0047B4C5 File Offset: 0x004796C5
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x06012341 RID: 74561 RVA: 0x0047B4E0 File Offset: 0x004796E0
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06012342 RID: 74562 RVA: 0x0047B4E2 File Offset: 0x004796E2
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x06012343 RID: 74563 RVA: 0x0047B4EC File Offset: 0x004796EC
	public void UpdateView(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
		this.RootItem.SetUIActive(payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.Enable);
		this.RefreshSpriteBg(payShopId, tabId);
		this.RefreshTextureBg(payShopId, tabId);
		this.RefreshCountDown(payShopId, tabId);
	}

	// Token: 0x06012344 RID: 74564 RVA: 0x0047B554 File Offset: 0x00479754
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

	// Token: 0x06012345 RID: 74565 RVA: 0x0047B5B4 File Offset: 0x004797B4
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

	// Token: 0x06012346 RID: 74566 RVA: 0x0047B620 File Offset: 0x00479820
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

	// Token: 0x06012347 RID: 74567 RVA: 0x0047B6C3 File Offset: 0x004798C3
	public void UpdateTitle(string title)
	{
		base.GetText(0).SetText(title, true);
	}

	// Token: 0x06012348 RID: 74568 RVA: 0x0047B6D4 File Offset: 0x004798D4
	public void BindRedDot(ERedDotName redDotName, int tabId = 0)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(2);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TabId = tabId;
		RedDotController.Instance.BindRedDot(redDotName, item, null, tabId);
	}

	// Token: 0x06012349 RID: 74569 RVA: 0x0047B710 File Offset: 0x00479910
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), this.TabId);
			this.RedDotName = null;
			this.TabId = 0;
		}
	}

	// Token: 0x04008994 RID: 35220
	private ERedDotName? RedDotName;

	// Token: 0x04008995 RID: 35221
	private int TabId;

	// Token: 0x02008932 RID: 35122
	[NullableContext(0)]
	private class EPayShopSwitchItem
	{
		// Token: 0x0402C993 RID: 182675
		public const int Name = 0;

		// Token: 0x0402C994 RID: 182676
		public const int SwitchToggle = 1;

		// Token: 0x0402C995 RID: 182677
		public const int RedDot = 2;

		// Token: 0x0402C996 RID: 182678
		public const int SpriteTransitionNum = 3;

		// Token: 0x0402C997 RID: 182679
		public const int TextureBg = 4;

		// Token: 0x0402C998 RID: 182680
		public const int CountDownItem = 5;

		// Token: 0x0402C999 RID: 182681
		public const int CountDownText = 6;
	}
}

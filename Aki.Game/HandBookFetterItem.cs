using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001E07 RID: 7687
[NullableContext(1)]
[Nullable(0)]
public class HandBookFetterItem : GridProxyAbstract<PhantomFetter>
{
	// Token: 0x0600E9B9 RID: 59833 RVA: 0x00374AC8 File Offset: 0x00372CC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnFetterToggleClicked))
		};
	}

	// Token: 0x0600E9BA RID: 59834 RVA: 0x00374BA0 File Offset: 0x00372DA0
	public override void Refresh(PhantomFetter phantomFetter, bool isSelected, int gridIndex)
	{
		this.PhantomFetter = new PhantomFetter?(phantomFetter);
		this.GirdIndex = gridIndex;
		base.GetTexture(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		base.GetText(3).SetUIActive(false);
		base.GetSprite(5).SetUIActive(false);
		base.GetText(4).ShowTextNew(this.PhantomFetter.Value.Name);
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
		}
		this.ContentGenericLayout = new GenericLayoutNew<HandBookCommonItem>(base.GetHorizontalLayout(6), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookCommonItem>(this.InitContentItem), null);
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.ContentGenericLayout.RebuildLayoutByDataNew<HandBookCommonItemData>(this.HandBookCommonItemDataList, null);
		this.SetSelected(isSelected);
	}

	// Token: 0x0600E9BB RID: 59835 RVA: 0x00374C71 File Offset: 0x00372E71
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x0600E9BC RID: 59836 RVA: 0x00374C79 File Offset: 0x00372E79
	public void BindFetterToggleCallback(TFetterToggleFunction fetterToggleFunction)
	{
		this.FetterToggleFunction = fetterToggleFunction;
	}

	// Token: 0x0600E9BD RID: 59837 RVA: 0x00374C82 File Offset: 0x00372E82
	private void OnFetterToggleClicked(EToggleState state)
	{
		if (this.FetterToggleFunction != null && state == EToggleState.ETT_Checked)
		{
			this.FetterToggleFunction(this);
		}
	}

	// Token: 0x0600E9BE RID: 59838 RVA: 0x00374C9C File Offset: 0x00372E9C
	public PhantomFetter? GetPhantomFetter()
	{
		return this.PhantomFetter;
	}

	// Token: 0x0600E9BF RID: 59839 RVA: 0x00374CA4 File Offset: 0x00372EA4
	private ILayoutItem<HandBookCommonItem> InitContentItem(object data, UUIItem uiItem, int index)
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		handBookCommonItem.Initialize(uiItem.GetOwner());
		handBookCommonItem.Refresh((HandBookCommonItemData)data, false, 0);
		handBookCommonItem.SetToggleInteractive(false);
		return new LayoutItem<HandBookCommonItem>
		{
			Key = index,
			Value = handBookCommonItem
		};
	}

	// Token: 0x0600E9C0 RID: 59840 RVA: 0x00374CF0 File Offset: 0x00372EF0
	private void SetSelected(bool bSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600E9C1 RID: 59841 RVA: 0x00374D1F File Offset: 0x00372F1F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x0600E9C2 RID: 59842 RVA: 0x00374D28 File Offset: 0x00372F28
	public void SetToggleStateForce(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600E9C3 RID: 59843 RVA: 0x00374D3B File Offset: 0x00372F3B
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetToggleStateForce(EToggleState.ETT_Checked, false);
			this.OnFetterToggleClicked(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600E9C4 RID: 59844 RVA: 0x00374D4F File Offset: 0x00372F4F
	protected override void OnBeforeDestroy()
	{
		this.PhantomFetter = null;
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.FetterToggleFunction = null;
	}

	// Token: 0x04006C78 RID: 27768
	protected PhantomFetter? PhantomFetter;

	// Token: 0x04006C79 RID: 27769
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006C7A RID: 27770
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GenericLayoutNew<HandBookCommonItem> ContentGenericLayout;

	// Token: 0x04006C7B RID: 27771
	private int GirdIndex;

	// Token: 0x04006C7C RID: 27772
	[Nullable(2)]
	protected TFetterToggleFunction FetterToggleFunction;
}

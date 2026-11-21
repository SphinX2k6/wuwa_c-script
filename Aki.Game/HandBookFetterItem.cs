using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x020012C9 RID: 4809
[NullableContext(1)]
[Nullable(0)]
public class HandBookFetterItem : GridProxyAbstract<PhantomFetter>
{
	// Token: 0x0600BDD8 RID: 48600 RVA: 0x003807D0 File Offset: 0x0037E9D0
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

	// Token: 0x0600BDD9 RID: 48601 RVA: 0x003808A8 File Offset: 0x0037EAA8
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

	// Token: 0x0600BDDA RID: 48602 RVA: 0x00380979 File Offset: 0x0037EB79
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x0600BDDB RID: 48603 RVA: 0x00380981 File Offset: 0x0037EB81
	public void BindFetterToggleCallback(TFetterToggleFunction fetterToggleFunction)
	{
		this.FetterToggleFunction = fetterToggleFunction;
	}

	// Token: 0x0600BDDC RID: 48604 RVA: 0x0038098A File Offset: 0x0037EB8A
	private void OnFetterToggleClicked(EToggleState state)
	{
		if (this.FetterToggleFunction != null && state == EToggleState.ETT_Checked)
		{
			this.FetterToggleFunction(this);
		}
	}

	// Token: 0x0600BDDD RID: 48605 RVA: 0x003809A4 File Offset: 0x0037EBA4
	public PhantomFetter? GetPhantomFetter()
	{
		return this.PhantomFetter;
	}

	// Token: 0x0600BDDE RID: 48606 RVA: 0x003809AC File Offset: 0x0037EBAC
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

	// Token: 0x0600BDDF RID: 48607 RVA: 0x003809F8 File Offset: 0x0037EBF8
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

	// Token: 0x0600BDE0 RID: 48608 RVA: 0x00380A27 File Offset: 0x0037EC27
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x0600BDE1 RID: 48609 RVA: 0x00380A30 File Offset: 0x0037EC30
	public void SetToggleStateForce(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600BDE2 RID: 48610 RVA: 0x00380A43 File Offset: 0x0037EC43
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetToggleStateForce(EToggleState.ETT_Checked, false);
			this.OnFetterToggleClicked(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600BDE3 RID: 48611 RVA: 0x00380A57 File Offset: 0x0037EC57
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

	// Token: 0x04006D59 RID: 27993
	protected PhantomFetter? PhantomFetter;

	// Token: 0x04006D5A RID: 27994
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006D5B RID: 27995
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GenericLayoutNew<HandBookCommonItem> ContentGenericLayout;

	// Token: 0x04006D5C RID: 27996
	private int GirdIndex;

	// Token: 0x04006D5D RID: 27997
	[Nullable(2)]
	protected TFetterToggleFunction FetterToggleFunction;
}

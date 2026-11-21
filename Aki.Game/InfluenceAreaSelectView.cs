using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001443 RID: 5187
public class InfluenceAreaSelectView : UiViewBase
{
	// Token: 0x0600CE50 RID: 52816 RVA: 0x003D556E File Offset: 0x003D376E
	[NullableContext(1)]
	public InfluenceAreaSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CE51 RID: 52817 RVA: 0x003D5578 File Offset: 0x003D3778
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIInteractionGroup));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CE52 RID: 52818 RVA: 0x003D56E6 File Offset: 0x003D38E6
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CE53 RID: 52819 RVA: 0x003D56EF File Offset: 0x003D38EF
	private void ConfirmClick()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshInfluencePanel, this.CurrentSelectedAreaId);
		base.CloseMe(null);
	}

	// Token: 0x0600CE54 RID: 52820 RVA: 0x003D5710 File Offset: 0x003D3910
	protected override void OnStart()
	{
		this.CountryLayout = new GenericLayoutNew<AreaButtonItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AreaButtonItem>(this.InitItem), null);
		List<Country> countryList = InfluenceConfig.Instance.GetCountryList();
		this.CountryLayout.RebuildLayoutByDataNew<Country>(countryList, null);
		this.SpecialItem = new AreaButtonItem(base.GetItem(2));
		this.SpecialItem.UpdateItem(9999);
		this.SpecialItem.SetToggleFunction(new TAreaToggleFunction(this.ToggleFunction));
		this.SpecialItem.SetCanExecuteChange(new TAreaCanExecuteChange(this.CanExecuteChange));
	}

	// Token: 0x0600CE55 RID: 52821 RVA: 0x003D57AC File Offset: 0x003D39AC
	[NullableContext(1)]
	private ILayoutItem<AreaButtonItem> InitItem(object country, UUIItem uiItem, int _)
	{
		AreaButtonItem areaButtonItem = new AreaButtonItem(uiItem);
		areaButtonItem.UpdateItem(((Country)country).Id);
		areaButtonItem.SetToggleFunction(new TAreaToggleFunction(this.ToggleFunction));
		areaButtonItem.SetCanExecuteChange(new TAreaCanExecuteChange(this.CanExecuteChange));
		return new LayoutItem<AreaButtonItem>
		{
			Key = ((Country)country).Id,
			Value = areaButtonItem
		};
	}

	// Token: 0x0600CE56 RID: 52822 RVA: 0x003D5820 File Offset: 0x003D3A20
	private void ToggleFunction(int areaId)
	{
		if (this.CurrentSelectedAreaId != 0)
		{
			this.GetAreaButtonItem(this.CurrentSelectedAreaId).SetToggleState(EToggleState.ETT_UnChecked, false);
		}
		this.CurrentSelectedAreaId = areaId;
		UUIText text = base.GetText(3);
		UUIText text2 = base.GetText(4);
		bool flag = InfluenceReputationModel.Instance.IsCountryUnLock(areaId);
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(6);
		if (flag)
		{
			Country value = InfluenceConfig.Instance.GetCountryConfig(areaId).Value;
			LguiUtil.Instance.SetLocalTextNew(text, value.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text2, value.Desc, Array.Empty<object>());
			interactionGroup.SetInteractable(true);
			return;
		}
		LguiUtil.Instance.SetLocalText(text, "AreaLockTitle", Array.Empty<object>());
		LguiUtil.Instance.SetLocalText(text2, "AreaLockContent", Array.Empty<object>());
		interactionGroup.SetInteractable(false);
	}

	// Token: 0x0600CE57 RID: 52823 RVA: 0x003D58F0 File Offset: 0x003D3AF0
	private bool CanExecuteChange(int areaId)
	{
		return this.CurrentSelectedAreaId != areaId;
	}

	// Token: 0x0600CE58 RID: 52824 RVA: 0x003D5900 File Offset: 0x003D3B00
	[NullableContext(2)]
	private AreaButtonItem GetAreaButtonItem(int areaId)
	{
		AreaButtonItem layoutItemByKey = this.CountryLayout.GetLayoutItemByKey(areaId);
		if (layoutItemByKey != null)
		{
			return layoutItemByKey;
		}
		return this.SpecialItem;
	}

	// Token: 0x0600CE59 RID: 52825 RVA: 0x003D592C File Offset: 0x003D3B2C
	protected override void OnAfterShow()
	{
		int areaId = (int)this.OpenParam;
		this.GetAreaButtonItem(areaId).SetToggleState(EToggleState.ETT_Checked, true);
	}

	// Token: 0x0600CE5A RID: 52826 RVA: 0x003D5953 File Offset: 0x003D3B53
	protected override void OnBeforeDestroy()
	{
		this.CountryLayout.ClearChildren();
		this.CountryLayout = null;
		this.SpecialItem.Destroy(null);
		this.SpecialItem = null;
	}

	// Token: 0x04007571 RID: 30065
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<AreaButtonItem> CountryLayout;

	// Token: 0x04007572 RID: 30066
	[Nullable(2)]
	private AreaButtonItem SpecialItem;

	// Token: 0x04007573 RID: 30067
	private int CurrentSelectedAreaId;

	// Token: 0x020076F2 RID: 30450
	private enum EInfluenceAreaSelectView
	{
		// Token: 0x04026A31 RID: 158257
		CloseButton,
		// Token: 0x04026A32 RID: 158258
		CountryArea,
		// Token: 0x04026A33 RID: 158259
		SpecialArea,
		// Token: 0x04026A34 RID: 158260
		Title,
		// Token: 0x04026A35 RID: 158261
		Content,
		// Token: 0x04026A36 RID: 158262
		ConfirmButton,
		// Token: 0x04026A37 RID: 158263
		InteractionGroup
	}
}

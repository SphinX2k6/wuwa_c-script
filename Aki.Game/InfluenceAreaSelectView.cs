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

// Token: 0x02001F81 RID: 8065
public class InfluenceAreaSelectView : UiViewBase
{
	// Token: 0x0600FA31 RID: 64049 RVA: 0x003C9A32 File Offset: 0x003C7C32
	[NullableContext(1)]
	public InfluenceAreaSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA32 RID: 64050 RVA: 0x003C9A3C File Offset: 0x003C7C3C
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

	// Token: 0x0600FA33 RID: 64051 RVA: 0x003C9BAA File Offset: 0x003C7DAA
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FA34 RID: 64052 RVA: 0x003C9BB3 File Offset: 0x003C7DB3
	private void ConfirmClick()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshInfluencePanel, this.CurrentSelectedAreaId);
		base.CloseMe(null);
	}

	// Token: 0x0600FA35 RID: 64053 RVA: 0x003C9BD4 File Offset: 0x003C7DD4
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

	// Token: 0x0600FA36 RID: 64054 RVA: 0x003C9C70 File Offset: 0x003C7E70
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

	// Token: 0x0600FA37 RID: 64055 RVA: 0x003C9CE4 File Offset: 0x003C7EE4
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

	// Token: 0x0600FA38 RID: 64056 RVA: 0x003C9DB4 File Offset: 0x003C7FB4
	private bool CanExecuteChange(int areaId)
	{
		return this.CurrentSelectedAreaId != areaId;
	}

	// Token: 0x0600FA39 RID: 64057 RVA: 0x003C9DC4 File Offset: 0x003C7FC4
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

	// Token: 0x0600FA3A RID: 64058 RVA: 0x003C9DF0 File Offset: 0x003C7FF0
	protected override void OnAfterShow()
	{
		int areaId = (int)this.OpenParam;
		this.GetAreaButtonItem(areaId).SetToggleState(EToggleState.ETT_Checked, true);
	}

	// Token: 0x0600FA3B RID: 64059 RVA: 0x003C9E17 File Offset: 0x003C8017
	protected override void OnBeforeDestroy()
	{
		this.CountryLayout.ClearChildren();
		this.CountryLayout = null;
		this.SpecialItem.Destroy(null);
		this.SpecialItem = null;
	}

	// Token: 0x04007490 RID: 29840
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<AreaButtonItem> CountryLayout;

	// Token: 0x04007491 RID: 29841
	[Nullable(2)]
	private AreaButtonItem SpecialItem;

	// Token: 0x04007492 RID: 29842
	private int CurrentSelectedAreaId;

	// Token: 0x0200856D RID: 34157
	private enum EInfluenceAreaSelectView
	{
		// Token: 0x0402B70E RID: 177934
		CloseButton,
		// Token: 0x0402B70F RID: 177935
		CountryArea,
		// Token: 0x0402B710 RID: 177936
		SpecialArea,
		// Token: 0x0402B711 RID: 177937
		Title,
		// Token: 0x0402B712 RID: 177938
		Content,
		// Token: 0x0402B713 RID: 177939
		ConfirmButton,
		// Token: 0x0402B714 RID: 177940
		InteractionGroup
	}
}

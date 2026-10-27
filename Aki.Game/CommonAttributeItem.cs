using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028EF RID: 10479
public class CommonAttributeItem : UiPanelBase
{
	// Token: 0x06015A2E RID: 88622 RVA: 0x00575CC3 File Offset: 0x00573EC3
	[NullableContext(1)]
	public CommonAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06015A2F RID: 88623 RVA: 0x00575CD8 File Offset: 0x00573ED8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.ToggleEvent))
		};
	}

	// Token: 0x06015A30 RID: 88624 RVA: 0x00575DC4 File Offset: 0x00573FC4
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		extendToggle.RootUIComp.Get().SetUIActive(true);
		base.GetItem(7).SetUIActive(false);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
	}

	// Token: 0x06015A31 RID: 88625 RVA: 0x00575E1A File Offset: 0x0057401A
	private bool CanClickLikeToggle()
	{
		return !string.IsNullOrEmpty(this.Data.DetailText);
	}

	// Token: 0x06015A32 RID: 88626 RVA: 0x00575E34 File Offset: 0x00574034
	[NullableContext(1)]
	public void ShowTemp(ScrollViewDataBase data)
	{
		CommonAttributeData commonAttributeData = (CommonAttributeData)data;
		this.Data = commonAttributeData;
		if (!string.IsNullOrEmpty(commonAttributeData.AttrNameText))
		{
			base.GetText(1).SetText(commonAttributeData.AttrNameText, true);
		}
		if (!string.IsNullOrEmpty(commonAttributeData.AttrIconTexture))
		{
			base.GetTexture(0).SetUIActive(true);
			base.SetTextureByPath(commonAttributeData.AttrIconTexture, base.GetTexture(0), null, null);
		}
		else
		{
			base.GetTexture(0).SetUIActive(false);
		}
		if (!string.IsNullOrEmpty(commonAttributeData.DetailText))
		{
			base.GetItem(6).SetUIActive(true);
			base.GetText(5).SetText(commonAttributeData.DetailText, true);
		}
		else
		{
			base.GetItem(6).SetUIActive(false);
		}
		if (!string.IsNullOrEmpty(commonAttributeData.AttrBaseValue))
		{
			base.GetText(2).SetText(commonAttributeData.AttrBaseValue, true);
		}
		if (!string.IsNullOrEmpty(commonAttributeData.AttrAddValue))
		{
			base.GetText(3).SetText(commonAttributeData.AttrAddValue, true);
			return;
		}
		base.GetText(3).SetText("", true);
	}

	// Token: 0x06015A33 RID: 88627 RVA: 0x00575F44 File Offset: 0x00574144
	protected void ToggleEvent(EToggleState bState)
	{
		bool uiactive = bState == EToggleState.ETT_Checked;
		base.GetText(5).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(uiactive);
	}

	// Token: 0x0400A0E6 RID: 41190
	[Nullable(2)]
	private CommonAttributeData Data;

	// Token: 0x02008EFB RID: 36603
	private enum EAttrListDefine
	{
		// Token: 0x0402E5C3 RID: 189891
		AttrIconTexture,
		// Token: 0x0402E5C4 RID: 189892
		AttrNameText,
		// Token: 0x0402E5C5 RID: 189893
		AttrBaseValue,
		// Token: 0x0402E5C6 RID: 189894
		AttrAddValue,
		// Token: 0x0402E5C7 RID: 189895
		Toggle,
		// Token: 0x0402E5C8 RID: 189896
		DetailText,
		// Token: 0x0402E5C9 RID: 189897
		Arrow,
		// Token: 0x0402E5CA RID: 189898
		ExplainContent
	}
}

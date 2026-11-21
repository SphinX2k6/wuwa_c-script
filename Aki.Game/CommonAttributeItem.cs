using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E6A RID: 7786
public class CommonAttributeItem : UiPanelBase
{
	// Token: 0x06013432 RID: 78898 RVA: 0x005A0B97 File Offset: 0x0059ED97
	[NullableContext(1)]
	public CommonAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013433 RID: 78899 RVA: 0x005A0BAC File Offset: 0x0059EDAC
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

	// Token: 0x06013434 RID: 78900 RVA: 0x005A0C98 File Offset: 0x0059EE98
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		extendToggle.RootUIComp.Get().SetUIActive(true);
		base.GetItem(7).SetUIActive(false);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
	}

	// Token: 0x06013435 RID: 78901 RVA: 0x005A0CEE File Offset: 0x0059EEEE
	private bool CanClickLikeToggle()
	{
		return !string.IsNullOrEmpty(this.Data.DetailText);
	}

	// Token: 0x06013436 RID: 78902 RVA: 0x005A0D08 File Offset: 0x0059EF08
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

	// Token: 0x06013437 RID: 78903 RVA: 0x005A0E18 File Offset: 0x0059F018
	protected void ToggleEvent(EToggleState bState)
	{
		bool uiactive = bState == EToggleState.ETT_Checked;
		base.GetText(5).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(uiactive);
	}

	// Token: 0x0400A4D1 RID: 42193
	[Nullable(2)]
	private CommonAttributeData Data;

	// Token: 0x02008143 RID: 33091
	private enum EAttrListDefine
	{
		// Token: 0x04029CBE RID: 171198
		AttrIconTexture,
		// Token: 0x04029CBF RID: 171199
		AttrNameText,
		// Token: 0x04029CC0 RID: 171200
		AttrBaseValue,
		// Token: 0x04029CC1 RID: 171201
		AttrAddValue,
		// Token: 0x04029CC2 RID: 171202
		Toggle,
		// Token: 0x04029CC3 RID: 171203
		DetailText,
		// Token: 0x04029CC4 RID: 171204
		Arrow,
		// Token: 0x04029CC5 RID: 171205
		ExplainContent
	}
}

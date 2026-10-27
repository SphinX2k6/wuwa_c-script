using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001761 RID: 5985
[Nullable(new byte[]
{
	0,
	1
})]
public class AttributeSelectGrid : GridProxyAbstract<IRefineAttrItemData>
{
	// Token: 0x0600AD67 RID: 44391 RVA: 0x002708A8 File Offset: 0x0026EAA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600AD68 RID: 44392 RVA: 0x0027093C File Offset: 0x0026EB3C
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600AD69 RID: 44393 RVA: 0x00270998 File Offset: 0x0026EB98
	[NullableContext(1)]
	public override void Refresh(IRefineAttrItemData data, bool bSelected, int gridIndex)
	{
		this.AttrData = data;
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.PropIndexId);
		base.GetText(0).ShowTextNew(propertyIndexInfo.Value.Name);
		UUITexture texture = base.GetTexture(2);
		base.SetTextureShowUntilLoaded(propertyIndexInfo.Value.Icon, texture, null);
		UUIItem uuiitem = texture;
		bool bUseChangeColor = true;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.GetItem(3).SetUIActive(data.IsRecommend);
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600AD6A RID: 44394 RVA: 0x00270A38 File Offset: 0x0026EC38
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<IRefineAttrItemData, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.AttrData, base.GridIndex);
	}

	// Token: 0x0600AD6B RID: 44395 RVA: 0x00270A56 File Offset: 0x0026EC56
	private bool CanExecuteChange()
	{
		return this.AttrData != null && !this.AttrData.IsDisable;
	}

	// Token: 0x0600AD6C RID: 44396 RVA: 0x00270A70 File Offset: 0x0026EC70
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600AD6D RID: 44397 RVA: 0x00270A83 File Offset: 0x0026EC83
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600AD6E RID: 44398 RVA: 0x00270A96 File Offset: 0x0026EC96
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
	}

	// Token: 0x04004ED0 RID: 20176
	[Nullable(2)]
	private IRefineAttrItemData AttrData;

	// Token: 0x04004ED1 RID: 20177
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IRefineAttrItemData, int> OnClickToggleCallBack;

	// Token: 0x02007D51 RID: 32081
	private enum EItemComponent
	{
		// Token: 0x04029094 RID: 168084
		Name,
		// Token: 0x04029095 RID: 168085
		Toggle,
		// Token: 0x04029096 RID: 168086
		Icon,
		// Token: 0x04029097 RID: 168087
		Suggest
	}
}

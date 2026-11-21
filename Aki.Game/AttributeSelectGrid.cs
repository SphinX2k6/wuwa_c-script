using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C1A RID: 3098
[Nullable(new byte[]
{
	0,
	1
})]
public class AttributeSelectGrid : GridProxyAbstract<IRefineAttrItemData>
{
	// Token: 0x0600814E RID: 33102 RVA: 0x0027AD68 File Offset: 0x00278F68
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

	// Token: 0x0600814F RID: 33103 RVA: 0x0027ADFC File Offset: 0x00278FFC
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x0027AE58 File Offset: 0x00279058
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

	// Token: 0x06008151 RID: 33105 RVA: 0x0027AEF8 File Offset: 0x002790F8
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<IRefineAttrItemData, int> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.AttrData, base.GridIndex);
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x0027AF16 File Offset: 0x00279116
	private bool CanExecuteChange()
	{
		return this.AttrData != null && !this.AttrData.IsDisable;
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x0027AF30 File Offset: 0x00279130
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06008154 RID: 33108 RVA: 0x0027AF43 File Offset: 0x00279143
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008155 RID: 33109 RVA: 0x0027AF56 File Offset: 0x00279156
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
	}

	// Token: 0x04004F7A RID: 20346
	[Nullable(2)]
	private IRefineAttrItemData AttrData;

	// Token: 0x04004F7B RID: 20347
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IRefineAttrItemData, int> OnClickToggleCallBack;

	// Token: 0x02006ED7 RID: 28375
	private enum EItemComponent
	{
		// Token: 0x040243BF RID: 148415
		Name,
		// Token: 0x040243C0 RID: 148416
		Toggle,
		// Token: 0x040243C1 RID: 148417
		Icon,
		// Token: 0x040243C2 RID: 148418
		Suggest
	}
}

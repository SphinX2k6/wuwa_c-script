using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C20 RID: 3104
public class AttributeSelectItem : UiPanelBase
{
	// Token: 0x0600817E RID: 33150 RVA: 0x0027B6B0 File Offset: 0x002798B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600817F RID: 33151 RVA: 0x0027B738 File Offset: 0x00279938
	[NullableContext(1)]
	private void RefreshByData(IRefineAttrItemData data)
	{
		base.GetItem(3).SetUIActive(false);
		base.GetItem(4).SetUIActive(true);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.PropIndexId);
		base.GetText(1).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureShowUntilLoaded(propertyIndexInfo.Value.Icon, base.GetTexture(0), null);
		PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(data.PropItemId);
		bool isRatio = phantomMainPropertyItemId.AddType == 2;
		double propRatioValue = TipsDataTool.GetPropRatioValue((double)phantomMainPropertyItemId.StandardProperty, isRatio);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(data.PropIndexId, propRatioValue, isRatio);
		base.GetText(2).SetText(formatAttributeValueString, true);
	}

	// Token: 0x06008180 RID: 33152 RVA: 0x0027B7F8 File Offset: 0x002799F8
	[NullableContext(2)]
	public void RefreshUi(IRefineAttrItemData data)
	{
		if (data != null)
		{
			this.RefreshByData(data);
			return;
		}
		base.GetItem(3).SetUIActive(true);
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x02006EE0 RID: 28384
	private enum EToggleComponent
	{
		// Token: 0x040243EA RID: 148458
		IconAttribute,
		// Token: 0x040243EB RID: 148459
		TextName,
		// Token: 0x040243EC RID: 148460
		TextValue,
		// Token: 0x040243ED RID: 148461
		PanelSelect,
		// Token: 0x040243EE RID: 148462
		PanelConfirm
	}
}

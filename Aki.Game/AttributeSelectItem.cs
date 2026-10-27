using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001767 RID: 5991
public class AttributeSelectItem : UiPanelBase
{
	// Token: 0x0600AD97 RID: 44439 RVA: 0x002711F0 File Offset: 0x0026F3F0
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

	// Token: 0x0600AD98 RID: 44440 RVA: 0x00271278 File Offset: 0x0026F478
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

	// Token: 0x0600AD99 RID: 44441 RVA: 0x00271338 File Offset: 0x0026F538
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

	// Token: 0x02007D5A RID: 32090
	private enum EToggleComponent
	{
		// Token: 0x040290BF RID: 168127
		IconAttribute,
		// Token: 0x040290C0 RID: 168128
		TextName,
		// Token: 0x040290C1 RID: 168129
		TextValue,
		// Token: 0x040290C2 RID: 168130
		PanelSelect,
		// Token: 0x040290C3 RID: 168131
		PanelConfirm
	}
}

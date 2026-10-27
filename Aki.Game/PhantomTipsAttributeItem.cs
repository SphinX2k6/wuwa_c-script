using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200201C RID: 8220
public class PhantomTipsAttributeItem : UiPanelBase
{
	// Token: 0x060101C0 RID: 65984 RVA: 0x003EBFA8 File Offset: 0x003EA1A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060101C1 RID: 65985 RVA: 0x003EC004 File Offset: 0x003EA204
	[NullableContext(1)]
	public void RefreshUi(AttrListScrollData attributeData)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attributeData.Id);
		base.GetText(1).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureShowUntilLoaded(propertyIndexInfo.Value.Icon, base.GetTexture(0), null);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(attributeData.Id, attributeData.BaseValue, attributeData.IsRatio);
		base.GetText(2).SetText(formatAttributeValueString, true);
	}

	// Token: 0x02008612 RID: 34322
	private enum EComponent
	{
		// Token: 0x0402BA1C RID: 178716
		AttributeIcon,
		// Token: 0x0402BA1D RID: 178717
		AttributeName,
		// Token: 0x0402BA1E RID: 178718
		AttributeValue
	}
}

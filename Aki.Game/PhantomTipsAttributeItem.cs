using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014EF RID: 5359
public class PhantomTipsAttributeItem : UiPanelBase
{
	// Token: 0x0600D628 RID: 54824 RVA: 0x003F85A0 File Offset: 0x003F67A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600D629 RID: 54825 RVA: 0x003F85FC File Offset: 0x003F67FC
	[NullableContext(1)]
	public void RefreshUi(AttrListScrollData attributeData)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attributeData.Id);
		base.GetText(1).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureShowUntilLoaded(propertyIndexInfo.Value.Icon, base.GetTexture(0), null);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(attributeData.Id, attributeData.BaseValue, attributeData.IsRatio);
		base.GetText(2).SetText(formatAttributeValueString, true);
	}

	// Token: 0x02007799 RID: 30617
	private enum EComponent
	{
		// Token: 0x04026D2B RID: 159019
		AttributeIcon,
		// Token: 0x04026D2C RID: 159020
		AttributeName,
		// Token: 0x04026D2D RID: 159021
		AttributeValue
	}
}

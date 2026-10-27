using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A61 RID: 6753
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssTipsAttributeItem : GridProxyAbstract<AttrListScrollData>
{
	// Token: 0x0600C6D9 RID: 50905 RVA: 0x002D3FC4 File Offset: 0x002D21C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C6DA RID: 50906 RVA: 0x002D4050 File Offset: 0x002D2250
	[NullableContext(1)]
	public override void Refresh(AttrListScrollData attributeData, bool isSelected, int gridIndex)
	{
		PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attributeData.Id).Value;
		base.GetText(1).ShowTextNew(value.Name);
		base.SetTextureShowUntilLoaded(value.Icon, base.GetTexture(0), null);
		double propRatioValue = TipsDataTool.GetPropRatioValue(attributeData.BaseValue, attributeData.IsRatio);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(attributeData.Id, propRatioValue, attributeData.IsRatio);
		base.GetText(2).SetText(formatAttributeValueString, true);
	}

	// Token: 0x02007FAF RID: 32687
	private enum EComponent
	{
		// Token: 0x04029B0C RID: 170764
		AttributeIcon,
		// Token: 0x04029B0D RID: 170765
		AttributeName,
		// Token: 0x04029B0E RID: 170766
		AttributeValue
	}
}

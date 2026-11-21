using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F20 RID: 3872
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssTipsAttributeItem : GridProxyAbstract<AttrListScrollData>
{
	// Token: 0x06009AE9 RID: 39657 RVA: 0x002DF0BC File Offset: 0x002DD2BC
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

	// Token: 0x06009AEA RID: 39658 RVA: 0x002DF148 File Offset: 0x002DD348
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

	// Token: 0x0200713E RID: 28990
	private enum EComponent
	{
		// Token: 0x04024E49 RID: 151113
		AttributeIcon,
		// Token: 0x04024E4A RID: 151114
		AttributeName,
		// Token: 0x04024E4B RID: 151115
		AttributeValue
	}
}

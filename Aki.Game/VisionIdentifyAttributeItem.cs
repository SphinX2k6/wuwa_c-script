using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024C7 RID: 9415
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionIdentifyAttributeItem : GridProxyAbstract<AttrListScrollData>
{
	// Token: 0x06012E77 RID: 77431 RVA: 0x004AC890 File Offset: 0x004AAA90
	public override void Refresh(AttrListScrollData data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x06012E78 RID: 77432 RVA: 0x004AC89C File Offset: 0x004AAA9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
	}

	// Token: 0x06012E79 RID: 77433 RVA: 0x004AC924 File Offset: 0x004AAB24
	public void Update(AttrListScrollData data)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.Id);
		if (propertyIndexInfo == null)
		{
			return;
		}
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(4), null, null);
		base.GetText(0).ShowTextNew(propertyIndexInfo.Value.Name);
		base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(data.Id, data.BaseValue, data.IsRatio), true);
		base.GetText(3).SetText(AttributeModel.Instance.GetFormatAttributeValueString(data.Id, data.AddValue, data.IsRatio), true);
		base.GetItem(2).SetUIActive(data.AddValue - data.BaseValue > 0.0);
		base.GetText(3).SetUIActive(data.AddValue - data.BaseValue > 0.0);
	}

	// Token: 0x02008A49 RID: 35401
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CE67 RID: 183911
		AttributeText,
		// Token: 0x0402CE68 RID: 183912
		BeforeText,
		// Token: 0x0402CE69 RID: 183913
		ArrowItem,
		// Token: 0x0402CE6A RID: 183914
		AfterText,
		// Token: 0x0402CE6B RID: 183915
		AttributeTexture
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019AE RID: 6574
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionIdentifyAttributeItem : GridProxyAbstract<AttrListScrollData>
{
	// Token: 0x06010336 RID: 66358 RVA: 0x004BA490 File Offset: 0x004B8690
	public override void Refresh(AttrListScrollData data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x06010337 RID: 66359 RVA: 0x004BA49C File Offset: 0x004B869C
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

	// Token: 0x06010338 RID: 66360 RVA: 0x004BA524 File Offset: 0x004B8724
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

	// Token: 0x02007BD2 RID: 31698
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028185 RID: 164229
		AttributeText,
		// Token: 0x04028186 RID: 164230
		BeforeText,
		// Token: 0x04028187 RID: 164231
		ArrowItem,
		// Token: 0x04028188 RID: 164232
		AfterText,
		// Token: 0x04028189 RID: 164233
		AttributeTexture
	}
}

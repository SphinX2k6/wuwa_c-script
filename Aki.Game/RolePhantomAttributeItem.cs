using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028DB RID: 10459
public class RolePhantomAttributeItem : UiPanelBase
{
	// Token: 0x0601596E RID: 88430 RVA: 0x00572B95 File Offset: 0x00570D95
	[NullableContext(1)]
	public RolePhantomAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0601596F RID: 88431 RVA: 0x00572BAC File Offset: 0x00570DAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06015970 RID: 88432 RVA: 0x00572C08 File Offset: 0x00570E08
	public void ShowTemp(ConfigPropValue attrData)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrData.Id);
		if (propertyIndexInfo == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.BB, "属性表中找不到对应的属性ID配置数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		base.GetText(0).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(2), null, null);
		base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, (double)attrData.Value, false), true);
	}

	// Token: 0x02008EE9 RID: 36585
	private enum EPhantomAttributeItemDefine
	{
		// Token: 0x0402E573 RID: 189811
		AttrNameText,
		// Token: 0x0402E574 RID: 189812
		AttrAddValue,
		// Token: 0x0402E575 RID: 189813
		AttrIconTexture
	}
}

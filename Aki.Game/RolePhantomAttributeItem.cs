using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E56 RID: 7766
public class RolePhantomAttributeItem : UiPanelBase
{
	// Token: 0x06013372 RID: 78706 RVA: 0x0059DA5D File Offset: 0x0059BC5D
	[NullableContext(1)]
	public RolePhantomAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013373 RID: 78707 RVA: 0x0059DA74 File Offset: 0x0059BC74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06013374 RID: 78708 RVA: 0x0059DAD0 File Offset: 0x0059BCD0
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

	// Token: 0x02008131 RID: 33073
	private enum EPhantomAttributeItemDefine
	{
		// Token: 0x04029C6E RID: 171118
		AttrNameText,
		// Token: 0x04029C6F RID: 171119
		AttrAddValue,
		// Token: 0x04029C70 RID: 171120
		AttrIconTexture
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001977 RID: 6519
public class SmallItemGridElementComponent : SmallItemGridComponent
{
	// Token: 0x0600BEDA RID: 48858 RVA: 0x002B2D24 File Offset: 0x002B0F24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BEDB RID: 48859 RVA: 0x002B2D6C File Offset: 0x002B0F6C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x0600BEDC RID: 48860 RVA: 0x002B2D74 File Offset: 0x002B0F74
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		if (tempData == null)
		{
			this.SetActive(false);
			return;
		}
		int elementId = (int)tempData;
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
		if (elementConfig == null)
		{
			this.SetActive(false);
			return;
		}
		string icon = elementConfig.Value.Icon5;
		if (icon == "" || icon.Length == 0)
		{
			this.SetActive(false);
			return;
		}
		UUITexture texture = base.GetTexture(0);
		base.SetElementIcon(icon, texture, elementId, null);
		texture.SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
		this.SetActive(true);
	}

	// Token: 0x02007EC3 RID: 32451
	private enum EChildType
	{
		// Token: 0x040296FF RID: 169727
		ElementTexture
	}
}

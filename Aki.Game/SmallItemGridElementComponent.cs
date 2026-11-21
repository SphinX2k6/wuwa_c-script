using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000E34 RID: 3636
public class SmallItemGridElementComponent : SmallItemGridComponent
{
	// Token: 0x060092E2 RID: 37602 RVA: 0x002BDCA8 File Offset: 0x002BBEA8
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

	// Token: 0x060092E3 RID: 37603 RVA: 0x002BDCF0 File Offset: 0x002BBEF0
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x060092E4 RID: 37604 RVA: 0x002BDCF8 File Offset: 0x002BBEF8
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

	// Token: 0x02007052 RID: 28754
	private enum EChildType
	{
		// Token: 0x04024A3C RID: 150076
		ElementTexture
	}
}

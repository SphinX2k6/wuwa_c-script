using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000DCC RID: 3532
public class MediumItemGridElementComponent : MediumItemGridComponent
{
	// Token: 0x06008FF5 RID: 36853 RVA: 0x002B46AC File Offset: 0x002B28AC
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

	// Token: 0x06008FF6 RID: 36854 RVA: 0x002B46F4 File Offset: 0x002B28F4
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x06008FF7 RID: 36855 RVA: 0x002B46FC File Offset: 0x002B28FC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is int))
		{
			this.SetActive(false);
			return;
		}
		int elementId = (int)data;
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
		if (elementConfig == null)
		{
			this.SetActive(false);
			return;
		}
		string icon = elementConfig.Value.Icon5;
		if (string.IsNullOrEmpty(icon))
		{
			this.SetActive(false);
			return;
		}
		UUITexture texture = base.GetTexture(0);
		base.SetElementIcon(icon, texture, elementId, null);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
		}
		this.SetActive(true);
	}

	// Token: 0x0200700D RID: 28685
	private class EChildType
	{
		// Token: 0x0402497F RID: 149887
		public const int ElementTexture = 0;
	}
}

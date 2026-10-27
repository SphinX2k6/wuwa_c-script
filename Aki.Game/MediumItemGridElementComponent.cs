using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001913 RID: 6419
public class MediumItemGridElementComponent : MediumItemGridComponent
{
	// Token: 0x0600BC0B RID: 48139 RVA: 0x002A9F50 File Offset: 0x002A8150
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

	// Token: 0x0600BC0C RID: 48140 RVA: 0x002A9F98 File Offset: 0x002A8198
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x0600BC0D RID: 48141 RVA: 0x002A9FA0 File Offset: 0x002A81A0
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

	// Token: 0x02007E86 RID: 32390
	private class EChildType
	{
		// Token: 0x04029653 RID: 169555
		public const int ElementTexture = 0;
	}
}

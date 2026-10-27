using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A57 RID: 6743
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssRoleAttributeItem : GridProxyAbstract<AttrListScrollData>
{
	// Token: 0x0600C676 RID: 50806 RVA: 0x002D2584 File Offset: 0x002D0784
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C677 RID: 50807 RVA: 0x002D2674 File Offset: 0x002D0874
	[NullableContext(1)]
	public override void Refresh(AttrListScrollData data, bool isSelected, int gridIndex)
	{
		PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.Id).Value;
		base.SetTextureByPath(value.Icon, base.GetTexture(4), null, null);
		base.GetText(0).ShowTextNew(value.Name);
		base.GetItem(2).SetUIActive(false);
		base.GetText(3).SetUIActive(false);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(data.Id, data.BaseValue + data.AddValue, data.IsRatio);
		base.GetText(1).SetText(formatAttributeValueString, true);
	}

	// Token: 0x02007FA1 RID: 32673
	private class EChildType
	{
		// Token: 0x04029AC6 RID: 170694
		public const int AttributeText = 0;

		// Token: 0x04029AC7 RID: 170695
		public const int AttributeNumText = 1;

		// Token: 0x04029AC8 RID: 170696
		public const int ArrowItem = 2;

		// Token: 0x04029AC9 RID: 170697
		public const int AttributeAddText = 3;

		// Token: 0x04029ACA RID: 170698
		public const int AttributeIcon = 4;

		// Token: 0x04029ACB RID: 170699
		public const int Bg = 5;
	}
}

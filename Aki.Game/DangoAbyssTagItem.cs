using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A5E RID: 6750
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssTagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
{
	// Token: 0x0600C6C6 RID: 50886 RVA: 0x002D3AF0 File Offset: 0x002D1CF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C6C7 RID: 50887 RVA: 0x002D3B7C File Offset: 0x002D1D7C
	[NullableContext(1)]
	public override void Refresh(DangoAbyssDefine.DangoAbyssTagData data, bool isSelected, int gridIndex)
	{
		AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(data.TagId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
		FColor color = FColor.FromHex(value.BgColor);
		base.GetSprite(0).SetColor(color);
		string formatAttributeValueByTagId = DangoAbyssModel.Instance.GetFormatAttributeValueByTagId(data.Value, data.TagId, new bool?(this.GetValueByTips));
		base.GetText(2).SetText(formatAttributeValueByTagId, true);
	}

	// Token: 0x04005B95 RID: 23445
	public bool GetValueByTips;

	// Token: 0x02007FAD RID: 32685
	private enum EComponent
	{
		// Token: 0x04029B01 RID: 170753
		SpriteBg,
		// Token: 0x04029B02 RID: 170754
		NameText,
		// Token: 0x04029B03 RID: 170755
		DescText
	}
}

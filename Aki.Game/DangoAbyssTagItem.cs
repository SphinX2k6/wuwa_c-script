using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F1D RID: 3869
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssTagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
{
	// Token: 0x06009AD6 RID: 39638 RVA: 0x002DEBEC File Offset: 0x002DCDEC
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

	// Token: 0x06009AD7 RID: 39639 RVA: 0x002DEC78 File Offset: 0x002DCE78
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

	// Token: 0x04005C64 RID: 23652
	public bool GetValueByTips;

	// Token: 0x0200713C RID: 28988
	private enum EComponent
	{
		// Token: 0x04024E3E RID: 151102
		SpriteBg,
		// Token: 0x04024E3F RID: 151103
		NameText,
		// Token: 0x04024E40 RID: 151104
		DescText
	}
}

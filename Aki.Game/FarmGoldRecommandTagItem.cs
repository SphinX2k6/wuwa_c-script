using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200071C RID: 1820
public class FarmGoldRecommandTagItem : GridProxyAbstract<FarmGoldRecommendTag>
{
	// Token: 0x060053E3 RID: 21475 RVA: 0x001BB3E4 File Offset: 0x001B95E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060053E4 RID: 21476 RVA: 0x001BB450 File Offset: 0x001B9650
	public override void Refresh(FarmGoldRecommendTag config, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, config.RecommendText, Array.Empty<object>());
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(config.RecommendIcon, texture, null, null);
	}

	// Token: 0x02006A0A RID: 27146
	private enum EComponents
	{
		// Token: 0x04022E78 RID: 142968
		Icon,
		// Token: 0x04022E79 RID: 142969
		Text
	}
}

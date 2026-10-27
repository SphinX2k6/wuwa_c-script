using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001268 RID: 4712
public class FarmGoldRecommandTagItem : GridProxyAbstract<FarmGoldRecommendTag>
{
	// Token: 0x0600804C RID: 32844 RVA: 0x001B2714 File Offset: 0x001B0914
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

	// Token: 0x0600804D RID: 32845 RVA: 0x001B2780 File Offset: 0x001B0980
	public override void Refresh(FarmGoldRecommendTag config, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, config.RecommendText, Array.Empty<object>());
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(config.RecommendIcon, texture, null, null);
	}

	// Token: 0x0200787F RID: 30847
	private enum EComponents
	{
		// Token: 0x04027B47 RID: 162631
		Icon,
		// Token: 0x04027B48 RID: 162632
		Text
	}
}

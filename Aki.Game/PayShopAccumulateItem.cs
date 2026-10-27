using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200237D RID: 9085
public class PayShopAccumulateItem : UiPanelBase
{
	// Token: 0x0601226B RID: 74347 RVA: 0x0047610C File Offset: 0x0047430C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601226C RID: 74348 RVA: 0x00476178 File Offset: 0x00474378
	public void RefreshCurrencyTex(int currencyId)
	{
		UUITexture texture = base.GetTexture(1);
		texture.SetUIActive(false);
		base.SetItemIcon(base.GetTexture(1), currencyId, null, delegate(bool _)
		{
			texture.SetUIActive(true);
		});
	}

	// Token: 0x0601226D RID: 74349 RVA: 0x004761C7 File Offset: 0x004743C7
	[NullableContext(1)]
	public void RefreshTextById(string textId, IReadOnlyList<string> args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x02008919 RID: 35097
	private class EComponentDefine
	{
		// Token: 0x0402C8FD RID: 182525
		public const int TxtNum = 0;

		// Token: 0x0402C8FE RID: 182526
		public const int TexNumIcon = 1;
	}
}

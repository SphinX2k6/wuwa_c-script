using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001862 RID: 6242
public class PayShopAccumulateItem : UiPanelBase
{
	// Token: 0x0600F71B RID: 63259 RVA: 0x0048328C File Offset: 0x0048148C
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

	// Token: 0x0600F71C RID: 63260 RVA: 0x004832F8 File Offset: 0x004814F8
	public void RefreshCurrencyTex(int currencyId)
	{
		UUITexture texture = base.GetTexture(1);
		texture.SetUIActive(false);
		base.SetItemIcon(base.GetTexture(1), currencyId, null, delegate(bool _)
		{
			texture.SetUIActive(true);
		});
	}

	// Token: 0x0600F71D RID: 63261 RVA: 0x00483347 File Offset: 0x00481547
	[NullableContext(1)]
	public void RefreshTextById(string textId, IReadOnlyList<string> args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x02007AA3 RID: 31395
	private class EComponentDefine
	{
		// Token: 0x04027C15 RID: 162837
		public const int TxtNum = 0;

		// Token: 0x04027C16 RID: 162838
		public const int TexNumIcon = 1;
	}
}

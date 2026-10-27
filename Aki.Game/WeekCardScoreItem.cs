using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020023AD RID: 9133
public class WeekCardScoreItem : UiPanelBase
{
	// Token: 0x06012429 RID: 74793 RVA: 0x0047F090 File Offset: 0x0047D290
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601242A RID: 74794 RVA: 0x0047F11C File Offset: 0x0047D31C
	[NullableContext(1)]
	public void Refresh(IWeekScoreData costData)
	{
		UUIText text = base.GetText(0);
		text.SetUIActive(!string.IsNullOrEmpty(costData.Tips));
		if (!string.IsNullOrEmpty(costData.Tips))
		{
			LguiUtil.Instance.SetLocalTextNew(text, costData.Tips, Array.Empty<object>());
		}
		base.GetText(1).SetText(costData.Count.ToString(), true);
		base.SetTextureByPath(costData.IconPath, base.GetTexture(2), null, null);
	}

	// Token: 0x02008949 RID: 35145
	private class EComponent
	{
		// Token: 0x0402CA0B RID: 182795
		public const int TipsText = 0;

		// Token: 0x0402CA0C RID: 182796
		public const int CostText = 1;

		// Token: 0x0402CA0D RID: 182797
		public const int CostIcon = 2;
	}
}

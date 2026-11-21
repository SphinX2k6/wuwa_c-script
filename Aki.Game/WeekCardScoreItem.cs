using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001892 RID: 6290
public class WeekCardScoreItem : UiPanelBase
{
	// Token: 0x0600F8DB RID: 63707 RVA: 0x0048C564 File Offset: 0x0048A764
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

	// Token: 0x0600F8DC RID: 63708 RVA: 0x0048C5F0 File Offset: 0x0048A7F0
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

	// Token: 0x02007AD2 RID: 31442
	private class EComponent
	{
		// Token: 0x04027D26 RID: 163110
		public const int TipsText = 0;

		// Token: 0x04027D27 RID: 163111
		public const int CostText = 1;

		// Token: 0x04027D28 RID: 163112
		public const int CostIcon = 2;
	}
}

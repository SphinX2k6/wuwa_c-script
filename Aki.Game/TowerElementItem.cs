using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BEE RID: 11246
public class TowerElementItem : GridProxyAbstract<int>
{
	// Token: 0x060175B5 RID: 95669 RVA: 0x005F0D20 File Offset: 0x005EEF20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060175B6 RID: 95670 RVA: 0x005F0D89 File Offset: 0x005EEF89
	protected override void OnStart()
	{
	}

	// Token: 0x060175B7 RID: 95671 RVA: 0x005F0D8C File Offset: 0x005EEF8C
	public override void Refresh(int elementId, bool isSelected, int gridIndex)
	{
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		base.SetTextureByPath(elementInfo.Value.Icon, base.GetTexture(1), null, null);
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetColor(FColor.FromHex(elementInfo.Value.ElementColor));
	}

	// Token: 0x020091AB RID: 37291
	private enum EChildType
	{
		// Token: 0x0402F219 RID: 193049
		ElementColorBg,
		// Token: 0x0402F21A RID: 193050
		ElementText
	}
}

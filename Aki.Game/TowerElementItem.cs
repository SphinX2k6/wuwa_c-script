using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002169 RID: 8553
public class TowerElementItem : GridProxyAbstract<int>
{
	// Token: 0x06014FE6 RID: 85990 RVA: 0x0061D880 File Offset: 0x0061BA80
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

	// Token: 0x06014FE7 RID: 85991 RVA: 0x0061D8E9 File Offset: 0x0061BAE9
	protected override void OnStart()
	{
	}

	// Token: 0x06014FE8 RID: 85992 RVA: 0x0061D8EC File Offset: 0x0061BAEC
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

	// Token: 0x020083EE RID: 33774
	private enum EChildType
	{
		// Token: 0x0402A91A RID: 174362
		ElementColorBg,
		// Token: 0x0402A91B RID: 174363
		ElementText
	}
}

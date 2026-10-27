using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BE0 RID: 11232
public class TowerBuffShowItem : GridProxyAbstract<long>
{
	// Token: 0x06017546 RID: 95558 RVA: 0x005EEA9C File Offset: 0x005ECC9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017547 RID: 95559 RVA: 0x005EEB05 File Offset: 0x005ECD05
	public override void Refresh(long data, bool isSelected, int gridIndex)
	{
		this.CurrentBuffId = data;
		this.RefreshView();
	}

	// Token: 0x06017548 RID: 95560 RVA: 0x005EEB14 File Offset: 0x005ECD14
	private void RefreshView()
	{
		string towerBuffDesc = TowerClimbConfig.Instance.GetTowerBuffDesc(this.CurrentBuffId);
		base.GetText(1).SetText(towerBuffDesc, true);
		string towerBuffIcon = TowerClimbConfig.Instance.GetTowerBuffIcon(this.CurrentBuffId);
		base.SetTextureByPath(towerBuffIcon, base.GetTexture(0), null, null);
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(true);
	}

	// Token: 0x0400AEB0 RID: 44720
	private long CurrentBuffId;

	// Token: 0x02009198 RID: 37272
	private enum EChildType
	{
		// Token: 0x0402F1CD RID: 192973
		Icon,
		// Token: 0x0402F1CE RID: 192974
		Desc
	}
}

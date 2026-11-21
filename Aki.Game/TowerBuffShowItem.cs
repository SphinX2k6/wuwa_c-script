using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200215B RID: 8539
public class TowerBuffShowItem : GridProxyAbstract<long>
{
	// Token: 0x06014F77 RID: 85879 RVA: 0x0061B5DC File Offset: 0x006197DC
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

	// Token: 0x06014F78 RID: 85880 RVA: 0x0061B645 File Offset: 0x00619845
	public override void Refresh(long data, bool isSelected, int gridIndex)
	{
		this.CurrentBuffId = data;
		this.RefreshView();
	}

	// Token: 0x06014F79 RID: 85881 RVA: 0x0061B654 File Offset: 0x00619854
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

	// Token: 0x0400B2B5 RID: 45749
	private long CurrentBuffId;

	// Token: 0x020083DC RID: 33756
	private enum EChildType
	{
		// Token: 0x0402A8D2 RID: 174290
		Icon,
		// Token: 0x0402A8D3 RID: 174291
		Desc
	}
}

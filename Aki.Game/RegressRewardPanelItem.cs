using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000900 RID: 2304
public class RegressRewardPanelItem : GridProxyAbstract<RegressRewardTuple>
{
	// Token: 0x06006657 RID: 26199 RVA: 0x00200A28 File Offset: 0x001FEC28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006658 RID: 26200 RVA: 0x00200A70 File Offset: 0x001FEC70
	protected override void OnStart()
	{
		AActor owner = base.GetItem(0).GetOwner();
		this.Grid = new CommonItemSmallItemGrid();
		this.Grid.Initialize(owner);
	}

	// Token: 0x06006659 RID: 26201 RVA: 0x00200AA1 File Offset: 0x001FECA1
	public override void Refresh(RegressRewardTuple data, bool isSelected, int gridIndex)
	{
		this.Grid.RefreshByConfigId(data.Id, new int?(data.Num), null, false, false);
		this.Grid.SetReceivedVisible(data.Received);
	}

	// Token: 0x0600665A RID: 26202 RVA: 0x00200AD3 File Offset: 0x001FECD3
	protected override void OnBeforeDestroy()
	{
		this.Grid = null;
	}

	// Token: 0x0400419D RID: 16797
	[Nullable(2)]
	private CommonItemSmallItemGrid Grid;

	// Token: 0x02006C0B RID: 27659
	private class ERegressRewardPanelItem
	{
		// Token: 0x0402383C RID: 145468
		public const int ButtonItem = 0;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200144C RID: 5196
public class RegressRewardPanelItem : GridProxyAbstract<RegressRewardTuple>
{
	// Token: 0x060092C2 RID: 37570 RVA: 0x001F7EEC File Offset: 0x001F60EC
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

	// Token: 0x060092C3 RID: 37571 RVA: 0x001F7F34 File Offset: 0x001F6134
	protected override void OnStart()
	{
		AActor owner = base.GetItem(0).GetOwner();
		this.Grid = new CommonItemSmallItemGrid();
		this.Grid.Initialize(owner);
	}

	// Token: 0x060092C4 RID: 37572 RVA: 0x001F7F65 File Offset: 0x001F6165
	public override void Refresh(RegressRewardTuple data, bool isSelected, int gridIndex)
	{
		this.Grid.RefreshByConfigId(data.Id, new int?(data.Num), null, false, false);
		this.Grid.SetReceivedVisible(data.Received);
	}

	// Token: 0x060092C5 RID: 37573 RVA: 0x001F7F97 File Offset: 0x001F6197
	protected override void OnBeforeDestroy()
	{
		this.Grid = null;
	}

	// Token: 0x04004105 RID: 16645
	[Nullable(2)]
	private CommonItemSmallItemGrid Grid;

	// Token: 0x02007A87 RID: 31367
	private class ERegressRewardPanelItem
	{
		// Token: 0x04028522 RID: 165154
		public const int ButtonItem = 0;
	}
}

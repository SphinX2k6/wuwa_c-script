using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017FB RID: 6139
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardPanelItem : GridProxyAbstract<DailyActivityDefine.RewardTuple>
{
	// Token: 0x0600B3C8 RID: 46024 RVA: 0x0028A11B File Offset: 0x0028831B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B3C9 RID: 46025 RVA: 0x0028A140 File Offset: 0x00288340
	protected override void OnStart()
	{
		AActor owner = base.GetItem(0).GetOwner();
		this.Grid = new CommonItemSmallItemGrid();
		this.Grid.Initialize(owner);
	}

	// Token: 0x0600B3CA RID: 46026 RVA: 0x0028A174 File Offset: 0x00288374
	[NullableContext(1)]
	public override void Refresh(DailyActivityDefine.RewardTuple data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		this.Grid.RefreshByConfigId(this.RewardData.Id, new int?(this.RewardData.Num), null, this.RewardData.Received, this.RewardData.IsDoubleRewardVisible);
	}

	// Token: 0x0600B3CB RID: 46027 RVA: 0x0028A1C5 File Offset: 0x002883C5
	protected override void OnBeforeDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x04005162 RID: 20834
	private DailyActivityDefine.RewardTuple RewardData;

	// Token: 0x04005163 RID: 20835
	private CommonItemSmallItemGrid Grid;

	// Token: 0x02007DF8 RID: 32248
	[NullableContext(0)]
	private enum EItemComponent
	{
		// Token: 0x0402939E RID: 168862
		ButtonItem
	}
}

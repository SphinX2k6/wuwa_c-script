using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000CB4 RID: 3252
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardPanelItem : GridProxyAbstract<DailyActivityDefine.RewardTuple>
{
	// Token: 0x060087B2 RID: 34738 RVA: 0x00294817 File Offset: 0x00292A17
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060087B3 RID: 34739 RVA: 0x0029483C File Offset: 0x00292A3C
	protected override void OnStart()
	{
		AActor owner = base.GetItem(0).GetOwner();
		this.Grid = new CommonItemSmallItemGrid();
		this.Grid.Initialize(owner);
	}

	// Token: 0x060087B4 RID: 34740 RVA: 0x00294870 File Offset: 0x00292A70
	[NullableContext(1)]
	public override void Refresh(DailyActivityDefine.RewardTuple data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		this.Grid.RefreshByConfigId(this.RewardData.Id, new int?(this.RewardData.Num), null, this.RewardData.Received, this.RewardData.IsDoubleRewardVisible);
	}

	// Token: 0x060087B5 RID: 34741 RVA: 0x002948C1 File Offset: 0x00292AC1
	protected override void OnBeforeDestroy()
	{
		this.RewardData = null;
	}

	// Token: 0x0400520D RID: 21005
	private DailyActivityDefine.RewardTuple RewardData;

	// Token: 0x0400520E RID: 21006
	private CommonItemSmallItemGrid Grid;

	// Token: 0x02006F7E RID: 28542
	[NullableContext(0)]
	private enum EItemComponent
	{
		// Token: 0x040246C9 RID: 149193
		ButtonItem
	}
}

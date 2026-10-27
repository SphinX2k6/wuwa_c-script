using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02001503 RID: 5379
public class ActivityShipTowerData : ActivityBaseData
{
	// Token: 0x06009975 RID: 39285 RVA: 0x002135DA File Offset: 0x002117DA
	[NullableContext(1)]
	protected override void OnInit(ActivityData data)
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.ShipTowerSeason, EClientStorageSystemIdType.ShipTowerSeason);
	}

	// Token: 0x06009976 RID: 39286 RVA: 0x002135E6 File Offset: 0x002117E6
	public override bool GetExDataRedPointShowState()
	{
		return this.HasNewCycle() || ShipTowerModel.Instance.IsCanReceiveAward();
	}

	// Token: 0x06009977 RID: 39287 RVA: 0x002135FC File Offset: 0x002117FC
	public bool HasNewCycle()
	{
		int curSeason = ShipTowerModel.Instance.CurSeason;
		return curSeason > 0 && (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ShipTowerSeason) as ServerStorageNumber).Get().GetValueOrDefault() < curSeason;
	}

	// Token: 0x06009978 RID: 39288 RVA: 0x0021363B File Offset: 0x0021183B
	protected override bool GetExDataFinishShowState()
	{
		return ShipTowerModel.Instance.IsRewardAllReceived;
	}
}

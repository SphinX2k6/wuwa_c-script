using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020009BB RID: 2491
public class ActivityShipTowerData : ActivityBaseData
{
	// Token: 0x06006D4F RID: 27983 RVA: 0x0021D2F2 File Offset: 0x0021B4F2
	[NullableContext(1)]
	protected override void OnInit(ActivityData data)
	{
		ServerStorageUtil.OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey.ShipTowerSeason, EClientStorageSystemIdType.ShipTowerSeason, true);
	}

	// Token: 0x06006D50 RID: 27984 RVA: 0x0021D2FF File Offset: 0x0021B4FF
	public override bool GetExDataRedPointShowState()
	{
		return this.HasNewCycle() || ShipTowerModel.Instance.IsCanReceiveAward();
	}

	// Token: 0x06006D51 RID: 27985 RVA: 0x0021D318 File Offset: 0x0021B518
	public bool HasNewCycle()
	{
		int curSeason = ShipTowerModel.Instance.CurSeason;
		return curSeason > 0 && (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ShipTowerSeason) as ServerStorageNumber).Get().GetValueOrDefault() < curSeason;
	}

	// Token: 0x06006D52 RID: 27986 RVA: 0x0021D357 File Offset: 0x0021B557
	protected override bool GetExDataFinishShowState()
	{
		return ShipTowerModel.Instance.IsRewardAllReceived;
	}
}

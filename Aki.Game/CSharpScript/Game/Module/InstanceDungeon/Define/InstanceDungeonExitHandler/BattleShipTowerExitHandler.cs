using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058E7 RID: 22759
	public class BattleShipTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D00 RID: 236800 RVA: 0x00DBB6E7 File Offset: 0x00DB98E7
		public override bool Checker()
		{
			return ShipTowerModel.Instance.CheckInBattleShipTower();
		}

		// Token: 0x06039D01 RID: 236801 RVA: 0x00DBB6F4 File Offset: 0x00DB98F4
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			BattleShipTowerExitHandler.<>c__DisplayClass1_0 CS$<>8__locals1 = new BattleShipTowerExitHandler.<>c__DisplayClass1_0();
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerLeaveInstance);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|1);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__ReChallenge|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}
}

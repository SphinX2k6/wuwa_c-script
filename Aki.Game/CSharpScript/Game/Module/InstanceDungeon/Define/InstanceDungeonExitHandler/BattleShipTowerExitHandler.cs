using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048BF RID: 18623
	public class BattleShipTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC23 RID: 191523 RVA: 0x00D0A63F File Offset: 0x00D0883F
		public override bool Checker()
		{
			return ShipTowerModel.Instance.CheckInBattleShipTower();
		}

		// Token: 0x0602EC24 RID: 191524 RVA: 0x00D0A64C File Offset: 0x00D0884C
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

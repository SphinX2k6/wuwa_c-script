using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058E6 RID: 22758
	public class BattleBabelTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039CFD RID: 236797 RVA: 0x00DBB6C7 File Offset: 0x00DB98C7
		public override bool Checker()
		{
			return BabelTowerModel.Instance.CheckInBattleBabelTower();
		}

		// Token: 0x06039CFE RID: 236798 RVA: 0x00DBB6D3 File Offset: 0x00DB98D3
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			BabelTowerController.Instance.OnClickInstanceDungeonExitButton();
		}
	}
}

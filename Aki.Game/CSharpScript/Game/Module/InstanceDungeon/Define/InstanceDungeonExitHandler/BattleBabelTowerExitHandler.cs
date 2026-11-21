using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048BE RID: 18622
	public class BattleBabelTowerExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC20 RID: 191520 RVA: 0x00D0A61F File Offset: 0x00D0881F
		public override bool Checker()
		{
			return BabelTowerModel.Instance.CheckInBattleBabelTower();
		}

		// Token: 0x0602EC21 RID: 191521 RVA: 0x00D0A62B File Offset: 0x00D0882B
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			BabelTowerController.Instance.OnClickInstanceDungeonExitButton();
		}
	}
}

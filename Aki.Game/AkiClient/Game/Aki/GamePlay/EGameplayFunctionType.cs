using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay
{
	// Token: 0x02003E4F RID: 15951
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/EGameplayFunctionType.EGameplayFunctionType")]
	public enum EGameplayFunctionType : byte
	{
		// Token: 0x04014669 RID: 83561
		None,
		// Token: 0x0401466A RID: 83562
		Gear,
		// Token: 0x0401466B RID: 83563
		TreasureBox,
		// Token: 0x0401466C RID: 83564
		LanternCat,
		// Token: 0x0401466D RID: 83565
		Weapon,
		// Token: 0x0401466E RID: 83566
		CheckGear,
		// Token: 0x0401466F RID: 83567
		ShootTarget,
		// Token: 0x04014670 RID: 83568
		InstanceOpen,
		// Token: 0x04014671 RID: 83569
		Ore,
		// Token: 0x04014672 RID: 83570
		StartShootTarget,
		// Token: 0x04014673 RID: 83571
		Teleport,
		// Token: 0x04014674 RID: 83572
		Controller,
		// Token: 0x04014675 RID: 83573
		TreasureBoxController,
		// Token: 0x04014676 RID: 83574
		Elevator,
		// Token: 0x04014677 RID: 83575
		EGameplayFunctionType_MAX
	}
}

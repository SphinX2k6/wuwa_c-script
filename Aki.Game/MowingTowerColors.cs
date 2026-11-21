using System;
using UnrealEngine;

// Token: 0x02000834 RID: 2100
public class MowingTowerColors : IStaticVariableResetter
{
	// Token: 0x06005F7C RID: 24444 RVA: 0x001E7B85 File Offset: 0x001E5D85
	static MowingTowerColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerColors.CreateStaticDefaultValue), new Action(MowingTowerColors.ResetStaticDefaultValue));
	}

	// Token: 0x06005F7D RID: 24445 RVA: 0x001E7BA4 File Offset: 0x001E5DA4
	public static void CreateStaticDefaultValue()
	{
		MowingTowerColors.bgNormalMowingTowerColor = new FColor?(FColor.FromHex("ab9559"));
		MowingTowerColors.bgLockMowingTowerColor = new FColor?(FColor.FromHex("757575"));
		MowingTowerColors.bgInfiniteMowingTowerColor = new FColor?(FColor.FromHex("e8713f"));
		MowingTowerColors.normalMowingTowerColor = new FColor?(FColor.FromHex("cfc48a"));
		MowingTowerColors.lockMowingTowerColor = new FColor?(FColor.FromHex("757575"));
		MowingTowerColors.infiniteMowingTowerColor = new FColor?(FColor.FromHex("f1ac61"));
	}

	// Token: 0x06005F7E RID: 24446 RVA: 0x001E7C2C File Offset: 0x001E5E2C
	public static void ResetStaticDefaultValue()
	{
		MowingTowerColors.bgNormalMowingTowerColor = null;
		MowingTowerColors.bgLockMowingTowerColor = null;
		MowingTowerColors.bgInfiniteMowingTowerColor = null;
		MowingTowerColors.normalMowingTowerColor = null;
		MowingTowerColors.lockMowingTowerColor = null;
		MowingTowerColors.infiniteMowingTowerColor = null;
	}

	// Token: 0x04003E97 RID: 16023
	public static FColor? bgNormalMowingTowerColor;

	// Token: 0x04003E98 RID: 16024
	public static FColor? bgLockMowingTowerColor;

	// Token: 0x04003E99 RID: 16025
	public static FColor? bgInfiniteMowingTowerColor;

	// Token: 0x04003E9A RID: 16026
	public static FColor? normalMowingTowerColor;

	// Token: 0x04003E9B RID: 16027
	public static FColor? lockMowingTowerColor;

	// Token: 0x04003E9C RID: 16028
	public static FColor? infiniteMowingTowerColor;
}

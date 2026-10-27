using System;
using UnrealEngine;

// Token: 0x02001380 RID: 4992
public class MowingTowerColors : IStaticVariableResetter
{
	// Token: 0x06008BE1 RID: 35809 RVA: 0x001DED31 File Offset: 0x001DCF31
	static MowingTowerColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerColors.CreateStaticDefaultValue), new Action(MowingTowerColors.ResetStaticDefaultValue));
	}

	// Token: 0x06008BE2 RID: 35810 RVA: 0x001DED50 File Offset: 0x001DCF50
	public static void CreateStaticDefaultValue()
	{
		MowingTowerColors.bgNormalMowingTowerColor = new FColor?(FColor.FromHex("ab9559"));
		MowingTowerColors.bgLockMowingTowerColor = new FColor?(FColor.FromHex("757575"));
		MowingTowerColors.bgInfiniteMowingTowerColor = new FColor?(FColor.FromHex("e8713f"));
		MowingTowerColors.normalMowingTowerColor = new FColor?(FColor.FromHex("cfc48a"));
		MowingTowerColors.lockMowingTowerColor = new FColor?(FColor.FromHex("757575"));
		MowingTowerColors.infiniteMowingTowerColor = new FColor?(FColor.FromHex("f1ac61"));
	}

	// Token: 0x06008BE3 RID: 35811 RVA: 0x001DEDD8 File Offset: 0x001DCFD8
	public static void ResetStaticDefaultValue()
	{
		MowingTowerColors.bgNormalMowingTowerColor = null;
		MowingTowerColors.bgLockMowingTowerColor = null;
		MowingTowerColors.bgInfiniteMowingTowerColor = null;
		MowingTowerColors.normalMowingTowerColor = null;
		MowingTowerColors.lockMowingTowerColor = null;
		MowingTowerColors.infiniteMowingTowerColor = null;
	}

	// Token: 0x04003DFF RID: 15871
	public static FColor? bgNormalMowingTowerColor;

	// Token: 0x04003E00 RID: 15872
	public static FColor? bgLockMowingTowerColor;

	// Token: 0x04003E01 RID: 15873
	public static FColor? bgInfiniteMowingTowerColor;

	// Token: 0x04003E02 RID: 15874
	public static FColor? normalMowingTowerColor;

	// Token: 0x04003E03 RID: 15875
	public static FColor? lockMowingTowerColor;

	// Token: 0x04003E04 RID: 15876
	public static FColor? infiniteMowingTowerColor;
}

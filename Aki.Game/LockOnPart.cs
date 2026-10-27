using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

// Token: 0x0200303C RID: 12348
[NullableContext(1)]
[Nullable(0)]
public class LockOnPart
{
	// Token: 0x0601A315 RID: 107285 RVA: 0x006E390C File Offset: 0x006E1B0C
	public LockOnPart(FName config)
	{
		this.BoneNameString = config.ToString();
		this.BoneName = config;
		this.SoftLockValid = true;
		this.HardLockValid = true;
		this.AimPartBoneName = this.BoneNameString;
		this.EnablePartName = "";
	}

	// Token: 0x0601A316 RID: 107286 RVA: 0x006E3998 File Offset: 0x006E1B98
	public LockOnPart(SLockOnPart config)
	{
		this.BoneNameString = config.BoneName;
		this.BoneName = new FName(this.BoneNameString);
		this.SoftLockValid = config.SoftLockValid;
		this.HardLockValid = config.HardLockValid;
		this.AimPartBoneName = config.AimPartBoneName;
		this.EnablePartName = config.EnablePartName;
	}

	// Token: 0x0400C72B RID: 50987
	public FName BoneName = FNameUtil.NONE;

	// Token: 0x0400C72C RID: 50988
	public string BoneNameString = "";

	// Token: 0x0400C72D RID: 50989
	public bool SoftLockValid = true;

	// Token: 0x0400C72E RID: 50990
	public bool HardLockValid = true;

	// Token: 0x0400C72F RID: 50991
	public string AimPartBoneName = "";

	// Token: 0x0400C730 RID: 50992
	public string EnablePartName = "";
}

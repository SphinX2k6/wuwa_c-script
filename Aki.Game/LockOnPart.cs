using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

// Token: 0x02002592 RID: 9618
[NullableContext(1)]
[Nullable(0)]
public class LockOnPart
{
	// Token: 0x06017C7F RID: 97407 RVA: 0x0070B494 File Offset: 0x00709694
	public LockOnPart(FName config)
	{
		this.BoneNameString = config.ToString();
		this.BoneName = config;
		this.SoftLockValid = true;
		this.HardLockValid = true;
		this.AimPartBoneName = this.BoneNameString;
		this.EnablePartName = "";
	}

	// Token: 0x06017C80 RID: 97408 RVA: 0x0070B520 File Offset: 0x00709720
	public LockOnPart(SLockOnPart config)
	{
		this.BoneNameString = config.BoneName;
		this.BoneName = new FName(this.BoneNameString);
		this.SoftLockValid = config.SoftLockValid;
		this.HardLockValid = config.HardLockValid;
		this.AimPartBoneName = config.AimPartBoneName;
		this.EnablePartName = config.EnablePartName;
	}

	// Token: 0x0400CB04 RID: 51972
	public FName BoneName = FNameUtil.NONE;

	// Token: 0x0400CB05 RID: 51973
	public string BoneNameString = "";

	// Token: 0x0400CB06 RID: 51974
	public bool SoftLockValid = true;

	// Token: 0x0400CB07 RID: 51975
	public bool HardLockValid = true;

	// Token: 0x0400CB08 RID: 51976
	public string AimPartBoneName = "";

	// Token: 0x0400CB09 RID: 51977
	public string EnablePartName = "";
}

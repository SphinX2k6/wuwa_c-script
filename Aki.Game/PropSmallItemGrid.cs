using System;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x020019A0 RID: 6560
public class PropSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001005 RID: 4101
	// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x002B3FD2 File Offset: 0x002B21D2
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Prop;
		}
	}

	// Token: 0x040055FC RID: 22012
	public ERoleDevelopStateTagType? RoleDevelopStateTagType;

	// Token: 0x040055FD RID: 22013
	public bool? IsLockVisible;

	// Token: 0x040055FE RID: 22014
	public bool? IsLockVisibleBlack;

	// Token: 0x040055FF RID: 22015
	public bool? IsReceivableVisible;

	// Token: 0x04005600 RID: 22016
	public bool? IsStarReceivableVisible;

	// Token: 0x04005601 RID: 22017
	public bool? IsReceivedVisible;

	// Token: 0x04005602 RID: 22018
	public bool? IsNewVisible;

	// Token: 0x04005603 RID: 22019
	public bool? IsNotFoundVisible;

	// Token: 0x04005604 RID: 22020
	public int? CoolDownTime;

	// Token: 0x04005605 RID: 22021
	public bool? IsBirthdayEffectVisible;

	// Token: 0x04005606 RID: 22022
	public bool? IsOrnamentConflictVisible;

	// Token: 0x04005607 RID: 22023
	public bool? IsTimeFlagVisible;
}

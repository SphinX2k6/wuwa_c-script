using System;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02000E5D RID: 3677
public class PropSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001029 RID: 4137
	// (get) Token: 0x06009388 RID: 37768 RVA: 0x002BEF56 File Offset: 0x002BD156
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Prop;
		}
	}

	// Token: 0x040056AA RID: 22186
	public ERoleDevelopStateTagType? RoleDevelopStateTagType;

	// Token: 0x040056AB RID: 22187
	public int? ElementId;

	// Token: 0x040056AC RID: 22188
	public bool? IsLockVisible;

	// Token: 0x040056AD RID: 22189
	public bool? IsLockVisibleBlack;

	// Token: 0x040056AE RID: 22190
	public bool? IsReceivableVisible;

	// Token: 0x040056AF RID: 22191
	public bool? IsStarReceivableVisible;

	// Token: 0x040056B0 RID: 22192
	public bool? IsReceivedVisible;

	// Token: 0x040056B1 RID: 22193
	public bool? IsNewVisible;

	// Token: 0x040056B2 RID: 22194
	public bool? IsNotFoundVisible;

	// Token: 0x040056B3 RID: 22195
	public int? CoolDownTime;

	// Token: 0x040056B4 RID: 22196
	public bool? IsBirthdayEffectVisible;

	// Token: 0x040056B5 RID: 22197
	public bool? IsOrnamentConflictVisible;

	// Token: 0x040056B6 RID: 22198
	public bool? IsTimeFlagVisible;
}

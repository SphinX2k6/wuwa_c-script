using System;
using System.Runtime.CompilerServices;

// Token: 0x020019A4 RID: 6564
public class PhantomSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001009 RID: 4105
	// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x002B3FFE File Offset: 0x002B21FE
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Phantom;
		}
	}

	// Token: 0x04005613 RID: 22035
	public int? MonsterId;

	// Token: 0x04005614 RID: 22036
	public int? PhantomId;

	// Token: 0x04005615 RID: 22037
	public bool? IsLockVisible;

	// Token: 0x04005616 RID: 22038
	public bool? IsLockVisibleBlack;

	// Token: 0x04005617 RID: 22039
	public bool? IsReceivableVisible;

	// Token: 0x04005618 RID: 22040
	public bool? IsReceivedVisible;

	// Token: 0x04005619 RID: 22041
	public bool? IsNewVisible;

	// Token: 0x0400561A RID: 22042
	public bool? IsNotFoundVisible;

	// Token: 0x0400561B RID: 22043
	public bool? IsSelectedFlag;

	// Token: 0x0400561C RID: 22044
	public bool? IconHidden;

	// Token: 0x0400561D RID: 22045
	public int? VisionRoleHeadInfo;

	// Token: 0x0400561E RID: 22046
	public int? FetterGroupId;

	// Token: 0x0400561F RID: 22047
	public bool? IsPhantomLock;

	// Token: 0x04005620 RID: 22048
	public bool? IsPhantomDeprecate;

	// Token: 0x04005621 RID: 22049
	[Nullable(2)]
	public SmallItemMultiPlayer MultiPlayer;
}

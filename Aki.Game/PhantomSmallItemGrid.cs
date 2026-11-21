using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E62 RID: 3682
public class PhantomSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102E RID: 4142
	// (get) Token: 0x06009392 RID: 37778 RVA: 0x002BEF8D File Offset: 0x002BD18D
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Phantom;
		}
	}

	// Token: 0x040056C5 RID: 22213
	public int? MonsterId;

	// Token: 0x040056C6 RID: 22214
	public int? PhantomId;

	// Token: 0x040056C7 RID: 22215
	public bool? IsLockVisible;

	// Token: 0x040056C8 RID: 22216
	public bool? IsLockVisibleBlack;

	// Token: 0x040056C9 RID: 22217
	public bool? IsReceivableVisible;

	// Token: 0x040056CA RID: 22218
	public bool? IsReceivedVisible;

	// Token: 0x040056CB RID: 22219
	public bool? IsNewVisible;

	// Token: 0x040056CC RID: 22220
	public bool? IsNotFoundVisible;

	// Token: 0x040056CD RID: 22221
	public bool? IsSelectedFlag;

	// Token: 0x040056CE RID: 22222
	public bool? IconHidden;

	// Token: 0x040056CF RID: 22223
	public int? VisionRoleHeadInfo;

	// Token: 0x040056D0 RID: 22224
	public int? FetterGroupId;

	// Token: 0x040056D1 RID: 22225
	public bool? IsPhantomLock;

	// Token: 0x040056D2 RID: 22226
	public bool? IsPhantomDeprecate;

	// Token: 0x040056D3 RID: 22227
	[Nullable(2)]
	public SmallItemMultiPlayer MultiPlayer;
}

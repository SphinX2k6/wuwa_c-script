using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D15 RID: 3349
[NullableContext(2)]
public interface IPhantomConfirmPopupViewData
{
	// Token: 0x17000F56 RID: 3926
	// (get) Token: 0x06008AB0 RID: 35504
	// (set) Token: 0x06008AB1 RID: 35505
	[Nullable(1)]
	string Title { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F57 RID: 3927
	// (get) Token: 0x06008AB2 RID: 35506
	// (set) Token: 0x06008AB3 RID: 35507
	[Nullable(1)]
	string SubTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F58 RID: 3928
	// (get) Token: 0x06008AB4 RID: 35508
	// (set) Token: 0x06008AB5 RID: 35509
	[Nullable(1)]
	List<int> PhantomUniqueIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F59 RID: 3929
	// (get) Token: 0x06008AB6 RID: 35510
	// (set) Token: 0x06008AB7 RID: 35511
	Action OnRight { get; set; }

	// Token: 0x17000F5A RID: 3930
	// (get) Token: 0x06008AB8 RID: 35512
	// (set) Token: 0x06008AB9 RID: 35513
	Action OnMiddle { get; set; }

	// Token: 0x17000F5B RID: 3931
	// (get) Token: 0x06008ABA RID: 35514
	// (set) Token: 0x06008ABB RID: 35515
	Action OnLeft { get; set; }

	// Token: 0x17000F5C RID: 3932
	// (get) Token: 0x06008ABC RID: 35516
	// (set) Token: 0x06008ABD RID: 35517
	string MiddleTxtKey { get; set; }

	// Token: 0x17000F5D RID: 3933
	// (get) Token: 0x06008ABE RID: 35518
	// (set) Token: 0x06008ABF RID: 35519
	string RightTxtKey { get; set; }

	// Token: 0x17000F5E RID: 3934
	// (get) Token: 0x06008AC0 RID: 35520
	// (set) Token: 0x06008AC1 RID: 35521
	string LeftTxtKey { get; set; }
}

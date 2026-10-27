using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200185C RID: 6236
[NullableContext(2)]
public interface IPhantomConfirmPopupViewData
{
	// Token: 0x17000F33 RID: 3891
	// (get) Token: 0x0600B6C7 RID: 46791
	// (set) Token: 0x0600B6C8 RID: 46792
	[Nullable(1)]
	string Title { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F34 RID: 3892
	// (get) Token: 0x0600B6C9 RID: 46793
	// (set) Token: 0x0600B6CA RID: 46794
	[Nullable(1)]
	string SubTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F35 RID: 3893
	// (get) Token: 0x0600B6CB RID: 46795
	// (set) Token: 0x0600B6CC RID: 46796
	[Nullable(1)]
	List<int> PhantomUniqueIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000F36 RID: 3894
	// (get) Token: 0x0600B6CD RID: 46797
	// (set) Token: 0x0600B6CE RID: 46798
	Action OnRight { get; set; }

	// Token: 0x17000F37 RID: 3895
	// (get) Token: 0x0600B6CF RID: 46799
	// (set) Token: 0x0600B6D0 RID: 46800
	Action OnMiddle { get; set; }

	// Token: 0x17000F38 RID: 3896
	// (get) Token: 0x0600B6D1 RID: 46801
	// (set) Token: 0x0600B6D2 RID: 46802
	Action OnLeft { get; set; }

	// Token: 0x17000F39 RID: 3897
	// (get) Token: 0x0600B6D3 RID: 46803
	// (set) Token: 0x0600B6D4 RID: 46804
	string MiddleTxtKey { get; set; }

	// Token: 0x17000F3A RID: 3898
	// (get) Token: 0x0600B6D5 RID: 46805
	// (set) Token: 0x0600B6D6 RID: 46806
	string RightTxtKey { get; set; }

	// Token: 0x17000F3B RID: 3899
	// (get) Token: 0x0600B6D7 RID: 46807
	// (set) Token: 0x0600B6D8 RID: 46808
	string LeftTxtKey { get; set; }
}

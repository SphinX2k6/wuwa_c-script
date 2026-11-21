using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001FFC RID: 8188
[NullableContext(2)]
public interface ISpecialTransitionViewParams
{
	// Token: 0x17001E76 RID: 7798
	// (get) Token: 0x060144A7 RID: 83111
	// (set) Token: 0x060144A8 RID: 83112
	int? SpineId { get; set; }

	// Token: 0x17001E77 RID: 7799
	// (get) Token: 0x060144A9 RID: 83113
	// (set) Token: 0x060144AA RID: 83114
	string BgPath { get; set; }

	// Token: 0x17001E78 RID: 7800
	// (get) Token: 0x060144AB RID: 83115
	// (set) Token: 0x060144AC RID: 83116
	ICustomShowUi CustomShowUi { get; set; }

	// Token: 0x17001E79 RID: 7801
	// (get) Token: 0x060144AD RID: 83117
	// (set) Token: 0x060144AE RID: 83118
	string AkEvent { get; set; }
}

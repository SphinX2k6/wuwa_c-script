using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A80 RID: 10880
[NullableContext(2)]
public interface ISpecialTransitionViewParams
{
	// Token: 0x17001E1E RID: 7710
	// (get) Token: 0x06016A82 RID: 92802
	// (set) Token: 0x06016A83 RID: 92803
	int? SpineId { get; set; }

	// Token: 0x17001E1F RID: 7711
	// (get) Token: 0x06016A84 RID: 92804
	// (set) Token: 0x06016A85 RID: 92805
	string BgPath { get; set; }

	// Token: 0x17001E20 RID: 7712
	// (get) Token: 0x06016A86 RID: 92806
	// (set) Token: 0x06016A87 RID: 92807
	ICustomShowUi CustomShowUi { get; set; }

	// Token: 0x17001E21 RID: 7713
	// (get) Token: 0x06016A88 RID: 92808
	// (set) Token: 0x06016A89 RID: 92809
	string AkEvent { get; set; }
}

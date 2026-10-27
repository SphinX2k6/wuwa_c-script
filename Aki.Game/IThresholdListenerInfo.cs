using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F01 RID: 3841
[NullableContext(1)]
public interface IThresholdListenerInfo
{
	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x06006056 RID: 24662
	// (set) Token: 0x06006057 RID: 24663
	TThresholdListener Func { get; set; }

	// Token: 0x17000772 RID: 1906
	// (get) Token: 0x06006058 RID: 24664
	// (set) Token: 0x06006059 RID: 24665
	float Max { get; set; }

	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x0600605A RID: 24666
	// (set) Token: 0x0600605B RID: 24667
	float Min { get; set; }

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x0600605C RID: 24668
	// (set) Token: 0x0600605D RID: 24669
	bool InInterval { get; set; }
}

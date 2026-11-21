using System;
using System.Runtime.CompilerServices;

// Token: 0x020027ED RID: 10221
[NullableContext(2)]
public interface IUeMovementComp
{
	// Token: 0x17002940 RID: 10560
	// (get) Token: 0x06019B5C RID: 105308
	// (set) Token: 0x06019B5D RID: 105309
	UeSkeletalTickManageComponent SkelTickMgr { get; set; }

	// Token: 0x06019B5E RID: 105310
	bool CanTickDefault();

	// Token: 0x06019B5F RID: 105311
	bool CanTickWithDistance();

	// Token: 0x06019B60 RID: 105312
	void PreProxyTick(float delta);

	// Token: 0x06019B61 RID: 105313
	void ProxyTick();
}

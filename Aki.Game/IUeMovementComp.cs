using System;
using System.Runtime.CompilerServices;

// Token: 0x0200327D RID: 12925
[NullableContext(2)]
public interface IUeMovementComp
{
	// Token: 0x17002698 RID: 9880
	// (get) Token: 0x0601BF6C RID: 114540
	// (set) Token: 0x0601BF6D RID: 114541
	UeSkeletalTickManageComponent SkelTickMgr { get; set; }

	// Token: 0x0601BF6E RID: 114542
	bool CanTickDefault();

	// Token: 0x0601BF6F RID: 114543
	bool CanTickWithDistance();

	// Token: 0x0601BF70 RID: 114544
	void PreProxyTick(float delta);

	// Token: 0x0601BF71 RID: 114545
	void ProxyTick();
}

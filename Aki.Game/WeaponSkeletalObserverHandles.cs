using System;
using System.Runtime.CompilerServices;

// Token: 0x0200226B RID: 8811
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkeletalObserverHandles
{
	// Token: 0x06015C96 RID: 89238 RVA: 0x006517B5 File Offset: 0x0064F9B5
	public WeaponSkeletalObserverHandles(SkeletalObserverHandle weaponObserver, SkeletalObserverHandle weaponScabbardObserver)
	{
		this.WeaponObserver = weaponObserver;
		this.WeaponScabbardObserver = weaponScabbardObserver;
	}

	// Token: 0x0400B79D RID: 47005
	public SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B79E RID: 47006
	public SkeletalObserverHandle WeaponScabbardObserver;
}

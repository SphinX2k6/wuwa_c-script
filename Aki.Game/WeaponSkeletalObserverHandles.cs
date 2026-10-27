using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D11 RID: 11537
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkeletalObserverHandles
{
	// Token: 0x060183F5 RID: 99317 RVA: 0x0062B7BD File Offset: 0x006299BD
	public WeaponSkeletalObserverHandles(SkeletalObserverHandle weaponObserver, SkeletalObserverHandle weaponScabbardObserver)
	{
		this.WeaponObserver = weaponObserver;
		this.WeaponScabbardObserver = weaponScabbardObserver;
	}

	// Token: 0x0400B428 RID: 46120
	public SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B429 RID: 46121
	public SkeletalObserverHandle WeaponScabbardObserver;
}

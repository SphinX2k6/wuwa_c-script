using System;
using System.Runtime.CompilerServices;

// Token: 0x0200180D RID: 6157
[NullableContext(2)]
[Nullable(0)]
public class BattlePassBackgroundPanelParam
{
	// Token: 0x0600F1D5 RID: 61909 RVA: 0x00470BC6 File Offset: 0x0046EDC6
	public BattlePassBackgroundPanelParam(bool isRewardPanel = false, WeaponSkeletalObserverHandles weaponObservers = null)
	{
		this.IsRewardPanel = isRewardPanel;
		this.WeaponObservers = weaponObservers;
	}

	// Token: 0x0400884F RID: 34895
	public bool IsRewardPanel;

	// Token: 0x04008850 RID: 34896
	public WeaponSkeletalObserverHandles WeaponObservers;
}

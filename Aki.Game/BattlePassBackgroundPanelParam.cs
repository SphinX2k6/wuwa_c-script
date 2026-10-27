using System;
using System.Runtime.CompilerServices;

// Token: 0x02002328 RID: 9000
[NullableContext(2)]
[Nullable(0)]
public class BattlePassBackgroundPanelParam
{
	// Token: 0x06011D25 RID: 72997 RVA: 0x00463B02 File Offset: 0x00461D02
	public BattlePassBackgroundPanelParam(bool isRewardPanel = false, WeaponSkeletalObserverHandles weaponObservers = null)
	{
		this.IsRewardPanel = isRewardPanel;
		this.WeaponObservers = weaponObservers;
	}

	// Token: 0x0400870C RID: 34572
	public bool IsRewardPanel;

	// Token: 0x0400870D RID: 34573
	public WeaponSkeletalObserverHandles WeaponObservers;
}

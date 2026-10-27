using System;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;

// Token: 0x0200168F RID: 5775
public class CheckWheelTowerCanShowHandler : CheckDungeonTypeCanShowHandlerBase
{
	// Token: 0x0600A4BD RID: 42173 RVA: 0x0024AFF0 File Offset: 0x002491F0
	public override bool CheckCanShow()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		return activityData != null && activityData.IsUnLock() && activityData.IsInCycle();
	}
}

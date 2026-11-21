using System;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;

// Token: 0x02000B47 RID: 2887
public class CheckWheelTowerCanShowHandler : CheckDungeonTypeCanShowHandlerBase
{
	// Token: 0x0600789D RID: 30877 RVA: 0x00255354 File Offset: 0x00253554
	public override bool CheckCanShow()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		return activityData != null && activityData.IsUnLock() && activityData.IsInCycle();
	}
}

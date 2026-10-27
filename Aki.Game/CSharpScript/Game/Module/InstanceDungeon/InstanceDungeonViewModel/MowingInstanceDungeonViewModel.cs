using System;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x0200588F RID: 22671
	public class MowingInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x06039B25 RID: 236325 RVA: 0x00DB6150 File Offset: 0x00DB4350
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			return mowingActivityData != null && !mowingActivityData.GetActivityLevelUnlockState(instanceId);
		}

		// Token: 0x06039B26 RID: 236326 RVA: 0x00DB6177 File Offset: 0x00DB4377
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshMowingInstance();
		}
	}
}

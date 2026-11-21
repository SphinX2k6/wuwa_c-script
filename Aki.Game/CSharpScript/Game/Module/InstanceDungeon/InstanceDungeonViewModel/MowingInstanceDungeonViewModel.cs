using System;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02004867 RID: 18535
	public class MowingInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x0602EA48 RID: 191048 RVA: 0x00D05068 File Offset: 0x00D03268
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
			return mowingActivityData != null && !mowingActivityData.GetActivityLevelUnlockState(instanceId);
		}

		// Token: 0x0602EA49 RID: 191049 RVA: 0x00D0508F File Offset: 0x00D0328F
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshMowingInstance();
		}
	}
}

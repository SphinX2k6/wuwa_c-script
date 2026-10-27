using System;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02005892 RID: 22674
	public class SolarSpeedInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x06039B32 RID: 236338 RVA: 0x00DB6571 File Offset: 0x00DB4771
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			this.View.RefreshSolarSpeedInstance(0f, true);
			return true;
		}

		// Token: 0x06039B33 RID: 236339 RVA: 0x00DB6585 File Offset: 0x00DB4785
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshSolarSpeedInstance(delta, false);
		}
	}
}

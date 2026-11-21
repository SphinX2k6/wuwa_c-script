using System;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x0200486A RID: 18538
	public class SolarSpeedInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x0602EA55 RID: 191061 RVA: 0x00D05489 File Offset: 0x00D03689
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			this.View.RefreshSolarSpeedInstance(0f, true);
			return true;
		}

		// Token: 0x0602EA56 RID: 191062 RVA: 0x00D0549D File Offset: 0x00D0369D
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshSolarSpeedInstance(delta, false);
		}
	}
}

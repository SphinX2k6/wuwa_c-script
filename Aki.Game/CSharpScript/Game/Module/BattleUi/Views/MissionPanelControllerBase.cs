using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D4C RID: 19788
	public abstract class MissionPanelControllerBase
	{
		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x06031AE9 RID: 203497
		protected abstract EMissionPanelControllerType ControllerType { get; }

		// Token: 0x06031AEA RID: 203498
		public abstract void AddEvents();

		// Token: 0x06031AEB RID: 203499
		public abstract void RemoveEvents();

		// Token: 0x06031AEC RID: 203500
		public abstract void OnDestroy();
	}
}

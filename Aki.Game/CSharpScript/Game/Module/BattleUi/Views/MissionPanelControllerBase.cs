using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D6A RID: 23914
	public abstract class MissionPanelControllerBase
	{
		// Token: 0x17008E1B RID: 36379
		// (get) Token: 0x0603CB8D RID: 248717
		protected abstract EMissionPanelControllerType ControllerType { get; }

		// Token: 0x0603CB8E RID: 248718
		public abstract void AddEvents();

		// Token: 0x0603CB8F RID: 248719
		public abstract void RemoveEvents();

		// Token: 0x0603CB90 RID: 248720
		public abstract void OnDestroy();
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007793 RID: 30611
	public class ISetBehaviorIsPausedT
	{
		// Token: 0x1700E04B RID: 57419
		// (get) Token: 0x06035BBA RID: 220090 RVA: 0x00733106 File Offset: 0x00731306
		// (set) Token: 0x06035BBB RID: 220091 RVA: 0x0073310E File Offset: 0x0073130E
		public bool IsPaused { get; set; }

		// Token: 0x06035BBC RID: 220092 RVA: 0x00733117 File Offset: 0x00731317
		public ISetBehaviorIsPausedT()
		{
			this.IsPaused = false;
		}
	}
}

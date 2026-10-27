using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCD RID: 28621
	public class ISetBehaviorPausedT
	{
		// Token: 0x1700D47A RID: 54394
		// (get) Token: 0x06032960 RID: 207200 RVA: 0x006D35C2 File Offset: 0x006D17C2
		// (set) Token: 0x06032961 RID: 207201 RVA: 0x006D35CA File Offset: 0x006D17CA
		public bool IsPaused { get; set; }

		// Token: 0x06032962 RID: 207202 RVA: 0x006D35D3 File Offset: 0x006D17D3
		public ISetBehaviorPausedT()
		{
			this.IsPaused = false;
		}
	}
}

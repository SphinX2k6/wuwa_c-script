using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007796 RID: 30614
	public class ISetBehaviorPausedT
	{
		// Token: 0x1700E04E RID: 57422
		// (get) Token: 0x06035BC6 RID: 220102 RVA: 0x00733206 File Offset: 0x00731406
		// (set) Token: 0x06035BC7 RID: 220103 RVA: 0x0073320E File Offset: 0x0073140E
		public bool IsPaused { get; set; }

		// Token: 0x06035BC8 RID: 220104 RVA: 0x00733217 File Offset: 0x00731417
		public ISetBehaviorPausedT()
		{
			this.IsPaused = false;
		}
	}
}

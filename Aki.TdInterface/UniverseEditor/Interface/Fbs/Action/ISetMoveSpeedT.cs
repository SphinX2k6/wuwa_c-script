using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702C RID: 28716
	public class ISetMoveSpeedT
	{
		// Token: 0x1700D53E RID: 54590
		// (get) Token: 0x06032CC5 RID: 208069 RVA: 0x006DA3EA File Offset: 0x006D85EA
		// (set) Token: 0x06032CC6 RID: 208070 RVA: 0x006DA3F2 File Offset: 0x006D85F2
		public float Speed { get; set; }

		// Token: 0x06032CC7 RID: 208071 RVA: 0x006DA3FB File Offset: 0x006D85FB
		public ISetMoveSpeedT()
		{
			this.Speed = 0f;
		}
	}
}

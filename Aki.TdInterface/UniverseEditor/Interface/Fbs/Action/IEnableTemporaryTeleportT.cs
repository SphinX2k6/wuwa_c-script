using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D14 RID: 27924
	public class IEnableTemporaryTeleportT
	{
		// Token: 0x1700CCE5 RID: 52453
		// (get) Token: 0x06030296 RID: 197270 RVA: 0x0068CA98 File Offset: 0x0068AC98
		// (set) Token: 0x06030297 RID: 197271 RVA: 0x0068CAA0 File Offset: 0x0068ACA0
		public bool Enable { get; set; }

		// Token: 0x1700CCE6 RID: 52454
		// (get) Token: 0x06030298 RID: 197272 RVA: 0x0068CAA9 File Offset: 0x0068ACA9
		// (set) Token: 0x06030299 RID: 197273 RVA: 0x0068CAB1 File Offset: 0x0068ACB1
		public int RangeEntity { get; set; }

		// Token: 0x0603029A RID: 197274 RVA: 0x0068CABA File Offset: 0x0068ACBA
		public IEnableTemporaryTeleportT()
		{
			this.Enable = false;
			this.RangeEntity = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0B RID: 32011
	public class IVehicleEntityT
	{
		// Token: 0x1700EF9C RID: 61340
		// (get) Token: 0x06039C55 RID: 236629 RVA: 0x007CB0DB File Offset: 0x007C92DB
		// (set) Token: 0x06039C56 RID: 236630 RVA: 0x007CB0E3 File Offset: 0x007C92E3
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700EF9D RID: 61341
		// (get) Token: 0x06039C57 RID: 236631 RVA: 0x007CB0EC File Offset: 0x007C92EC
		// (set) Token: 0x06039C58 RID: 236632 RVA: 0x007CB0F4 File Offset: 0x007C92F4
		public TTargetVehicleUnion Vehicle { get; set; }

		// Token: 0x06039C59 RID: 236633 RVA: 0x007CB0FD File Offset: 0x007C92FD
		public IVehicleEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.Vehicle = null;
		}
	}
}

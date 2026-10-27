using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005034 RID: 20532
	public class IConveyorBeltMoveT
	{
		// Token: 0x17009502 RID: 38146
		// (get) Token: 0x06020E5B RID: 134747 RVA: 0x0049304E File Offset: 0x0049124E
		// (set) Token: 0x06020E5C RID: 134748 RVA: 0x00493056 File Offset: 0x00491256
		public EConveyorBeltMoveType Type { get; set; }

		// Token: 0x06020E5D RID: 134749 RVA: 0x0049305F File Offset: 0x0049125F
		public IConveyorBeltMoveT()
		{
			this.Type = EConveyorBeltMoveType.FixSpeed;
		}
	}
}

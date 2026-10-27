using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005268 RID: 21096
	public class IFixedAngleTurntableT
	{
		// Token: 0x17009A83 RID: 39555
		// (get) Token: 0x06022527 RID: 140583 RVA: 0x004C2111 File Offset: 0x004C0311
		// (set) Token: 0x06022528 RID: 140584 RVA: 0x004C2119 File Offset: 0x004C0319
		public EControllerType Type { get; set; }

		// Token: 0x17009A84 RID: 39556
		// (get) Token: 0x06022529 RID: 140585 RVA: 0x004C2122 File Offset: 0x004C0322
		// (set) Token: 0x0602252A RID: 140586 RVA: 0x004C212A File Offset: 0x004C032A
		public int RotationSpeed { get; set; }

		// Token: 0x17009A85 RID: 39557
		// (get) Token: 0x0602252B RID: 140587 RVA: 0x004C2133 File Offset: 0x004C0333
		// (set) Token: 0x0602252C RID: 140588 RVA: 0x004C213B File Offset: 0x004C033B
		public List<IFixedAngleItemT> ItemConfig { get; set; }

		// Token: 0x0602252D RID: 140589 RVA: 0x004C2144 File Offset: 0x004C0344
		public IFixedAngleTurntableT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
			this.ItemConfig = null;
		}
	}
}

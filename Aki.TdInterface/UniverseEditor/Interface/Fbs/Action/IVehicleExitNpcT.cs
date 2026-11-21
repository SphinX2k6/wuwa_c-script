using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0E RID: 32014
	public class IVehicleExitNpcT
	{
		// Token: 0x1700EFA1 RID: 61345
		// (get) Token: 0x06039C71 RID: 236657 RVA: 0x007CB50F File Offset: 0x007C970F
		// (set) Token: 0x06039C72 RID: 236658 RVA: 0x007CB517 File Offset: 0x007C9717
		public int TargetNpc { get; set; }

		// Token: 0x1700EFA2 RID: 61346
		// (get) Token: 0x06039C73 RID: 236659 RVA: 0x007CB520 File Offset: 0x007C9720
		// (set) Token: 0x06039C74 RID: 236660 RVA: 0x007CB528 File Offset: 0x007C9728
		public TExitVehicleTypeUnion ExitType { get; set; }

		// Token: 0x06039C75 RID: 236661 RVA: 0x007CB531 File Offset: 0x007C9731
		public IVehicleExitNpcT()
		{
			this.TargetNpc = 0;
			this.ExitType = null;
		}
	}
}

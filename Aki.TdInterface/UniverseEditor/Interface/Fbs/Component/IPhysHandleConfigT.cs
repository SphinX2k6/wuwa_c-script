using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D38 RID: 23864
	public class IPhysHandleConfigT
	{
		// Token: 0x1700AF80 RID: 44928
		// (get) Token: 0x06027AF6 RID: 162550 RVA: 0x0056DF2C File Offset: 0x0056C12C
		// (set) Token: 0x06027AF7 RID: 162551 RVA: 0x0056DF34 File Offset: 0x0056C134
		public int PhysHandleLinearDamping { get; set; }

		// Token: 0x1700AF81 RID: 44929
		// (get) Token: 0x06027AF8 RID: 162552 RVA: 0x0056DF3D File Offset: 0x0056C13D
		// (set) Token: 0x06027AF9 RID: 162553 RVA: 0x0056DF45 File Offset: 0x0056C145
		public int PhysHandleAngularStiffness { get; set; }

		// Token: 0x1700AF82 RID: 44930
		// (get) Token: 0x06027AFA RID: 162554 RVA: 0x0056DF4E File Offset: 0x0056C14E
		// (set) Token: 0x06027AFB RID: 162555 RVA: 0x0056DF56 File Offset: 0x0056C156
		public int PhysHandleLinearStiffness { get; set; }

		// Token: 0x1700AF83 RID: 44931
		// (get) Token: 0x06027AFC RID: 162556 RVA: 0x0056DF5F File Offset: 0x0056C15F
		// (set) Token: 0x06027AFD RID: 162557 RVA: 0x0056DF67 File Offset: 0x0056C167
		public int PhysHandleAngularDamping { get; set; }

		// Token: 0x06027AFE RID: 162558 RVA: 0x0056DF70 File Offset: 0x0056C170
		public IPhysHandleConfigT()
		{
			this.PhysHandleLinearDamping = 0;
			this.PhysHandleAngularStiffness = 0;
			this.PhysHandleLinearStiffness = 0;
			this.PhysHandleAngularDamping = 0;
		}
	}
}

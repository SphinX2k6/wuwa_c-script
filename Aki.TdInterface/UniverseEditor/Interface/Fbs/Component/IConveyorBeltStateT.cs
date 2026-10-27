using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200503A RID: 20538
	public class IConveyorBeltStateT
	{
		// Token: 0x17009509 RID: 38153
		// (get) Token: 0x06020E83 RID: 134787 RVA: 0x00493576 File Offset: 0x00491776
		// (set) Token: 0x06020E84 RID: 134788 RVA: 0x0049357E File Offset: 0x0049177E
		public string EntityState { get; set; }

		// Token: 0x1700950A RID: 38154
		// (get) Token: 0x06020E85 RID: 134789 RVA: 0x00493587 File Offset: 0x00491787
		// (set) Token: 0x06020E86 RID: 134790 RVA: 0x0049358F File Offset: 0x0049178F
		public TConveyorBeltFieldTypeUnion FieldType { get; set; }

		// Token: 0x1700950B RID: 38155
		// (get) Token: 0x06020E87 RID: 134791 RVA: 0x00493598 File Offset: 0x00491798
		// (set) Token: 0x06020E88 RID: 134792 RVA: 0x004935A0 File Offset: 0x004917A0
		public IFixSpeedT MoveType { get; set; }

		// Token: 0x06020E89 RID: 134793 RVA: 0x004935A9 File Offset: 0x004917A9
		public IConveyorBeltStateT()
		{
			this.EntityState = null;
			this.FieldType = null;
			this.MoveType = null;
		}
	}
}

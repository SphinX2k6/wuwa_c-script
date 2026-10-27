using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200527A RID: 21114
	public class IFixSpeedT
	{
		// Token: 0x17009ABC RID: 39612
		// (get) Token: 0x060225F3 RID: 140787 RVA: 0x004C3C38 File Offset: 0x004C1E38
		// (set) Token: 0x060225F4 RID: 140788 RVA: 0x004C3C40 File Offset: 0x004C1E40
		public EConveyorBeltMoveType Type { get; set; }

		// Token: 0x17009ABD RID: 39613
		// (get) Token: 0x060225F5 RID: 140789 RVA: 0x004C3C49 File Offset: 0x004C1E49
		// (set) Token: 0x060225F6 RID: 140790 RVA: 0x004C3C51 File Offset: 0x004C1E51
		public int Speed { get; set; }

		// Token: 0x060225F7 RID: 140791 RVA: 0x004C3C5A File Offset: 0x004C1E5A
		public IFixSpeedT()
		{
			this.Type = EConveyorBeltMoveType.FixSpeed;
			this.Speed = 0;
		}
	}
}

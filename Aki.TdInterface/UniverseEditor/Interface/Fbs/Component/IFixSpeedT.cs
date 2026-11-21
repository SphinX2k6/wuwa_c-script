using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E2 RID: 22498
	public class IFixSpeedT
	{
		// Token: 0x1700A2BA RID: 41658
		// (get) Token: 0x0602458D RID: 148877 RVA: 0x004FE7A8 File Offset: 0x004FC9A8
		// (set) Token: 0x0602458E RID: 148878 RVA: 0x004FE7B0 File Offset: 0x004FC9B0
		public EConveyorBeltMoveType Type { get; set; }

		// Token: 0x1700A2BB RID: 41659
		// (get) Token: 0x0602458F RID: 148879 RVA: 0x004FE7B9 File Offset: 0x004FC9B9
		// (set) Token: 0x06024590 RID: 148880 RVA: 0x004FE7C1 File Offset: 0x004FC9C1
		public int Speed { get; set; }

		// Token: 0x06024591 RID: 148881 RVA: 0x004FE7CA File Offset: 0x004FC9CA
		public IFixSpeedT()
		{
			this.Type = EConveyorBeltMoveType.FixSpeed;
			this.Speed = 0;
		}
	}
}

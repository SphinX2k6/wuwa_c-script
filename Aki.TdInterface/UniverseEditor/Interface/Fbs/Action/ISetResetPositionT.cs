using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007834 RID: 30772
	public class ISetResetPositionT
	{
		// Token: 0x1700E1C6 RID: 57798
		// (get) Token: 0x060361DD RID: 221661 RVA: 0x00740076 File Offset: 0x0073E276
		// (set) Token: 0x060361DE RID: 221662 RVA: 0x0074007E File Offset: 0x0073E27E
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700E1C7 RID: 57799
		// (get) Token: 0x060361DF RID: 221663 RVA: 0x00740087 File Offset: 0x0073E287
		// (set) Token: 0x060361E0 RID: 221664 RVA: 0x0074008F File Offset: 0x0073E28F
		public int EntityId { get; set; }

		// Token: 0x1700E1C8 RID: 57800
		// (get) Token: 0x060361E1 RID: 221665 RVA: 0x00740098 File Offset: 0x0073E298
		// (set) Token: 0x060361E2 RID: 221666 RVA: 0x007400A0 File Offset: 0x0073E2A0
		public int PositionEntityId { get; set; }

		// Token: 0x060361E3 RID: 221667 RVA: 0x007400A9 File Offset: 0x0073E2A9
		public ISetResetPositionT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
			this.PositionEntityId = 0;
		}
	}
}

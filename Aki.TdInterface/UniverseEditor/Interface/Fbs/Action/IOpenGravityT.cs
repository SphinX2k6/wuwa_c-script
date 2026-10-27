using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C04 RID: 27652
	public class IOpenGravityT
	{
		// Token: 0x1700CDA4 RID: 52644
		// (get) Token: 0x060309DA RID: 199130 RVA: 0x00699660 File Offset: 0x00697860
		// (set) Token: 0x060309DB RID: 199131 RVA: 0x00699668 File Offset: 0x00697868
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700CDA5 RID: 52645
		// (get) Token: 0x060309DC RID: 199132 RVA: 0x00699671 File Offset: 0x00697871
		// (set) Token: 0x060309DD RID: 199133 RVA: 0x00699679 File Offset: 0x00697879
		public int EntityId { get; set; }

		// Token: 0x1700CDA6 RID: 52646
		// (get) Token: 0x060309DE RID: 199134 RVA: 0x00699682 File Offset: 0x00697882
		// (set) Token: 0x060309DF RID: 199135 RVA: 0x0069968A File Offset: 0x0069788A
		public int PositionEntityId { get; set; }

		// Token: 0x1700CDA7 RID: 52647
		// (get) Token: 0x060309E0 RID: 199136 RVA: 0x00699693 File Offset: 0x00697893
		// (set) Token: 0x060309E1 RID: 199137 RVA: 0x0069969B File Offset: 0x0069789B
		public byte NullMask { get; set; }

		// Token: 0x060309E2 RID: 199138 RVA: 0x006996A4 File Offset: 0x006978A4
		public IOpenGravityT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
			this.PositionEntityId = 0;
			this.NullMask = 0;
		}
	}
}

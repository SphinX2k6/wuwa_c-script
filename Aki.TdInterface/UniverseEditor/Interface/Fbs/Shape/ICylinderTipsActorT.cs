using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C0E RID: 15374
	public class ICylinderTipsActorT
	{
		// Token: 0x170069AE RID: 27054
		// (get) Token: 0x060152F9 RID: 86777 RVA: 0x00311ADA File Offset: 0x0030FCDA
		// (set) Token: 0x060152FA RID: 86778 RVA: 0x00311AE2 File Offset: 0x0030FCE2
		public ETipsActorType Type { get; set; }

		// Token: 0x170069AF RID: 27055
		// (get) Token: 0x060152FB RID: 86779 RVA: 0x00311AEB File Offset: 0x0030FCEB
		// (set) Token: 0x060152FC RID: 86780 RVA: 0x00311AF3 File Offset: 0x0030FCF3
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069B0 RID: 27056
		// (get) Token: 0x060152FD RID: 86781 RVA: 0x00311AFC File Offset: 0x0030FCFC
		// (set) Token: 0x060152FE RID: 86782 RVA: 0x00311B04 File Offset: 0x0030FD04
		public float Radius { get; set; }

		// Token: 0x170069B1 RID: 27057
		// (get) Token: 0x060152FF RID: 86783 RVA: 0x00311B0D File Offset: 0x0030FD0D
		// (set) Token: 0x06015300 RID: 86784 RVA: 0x00311B15 File Offset: 0x0030FD15
		public float Height { get; set; }

		// Token: 0x170069B2 RID: 27058
		// (get) Token: 0x06015301 RID: 86785 RVA: 0x00311B1E File Offset: 0x0030FD1E
		// (set) Token: 0x06015302 RID: 86786 RVA: 0x00311B26 File Offset: 0x0030FD26
		public byte NullMask { get; set; }

		// Token: 0x06015303 RID: 86787 RVA: 0x00311B2F File Offset: 0x0030FD2F
		public ICylinderTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}

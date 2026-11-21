using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007407 RID: 29703
	public class IPetalGrabMoveT
	{
		// Token: 0x1700DA36 RID: 55862
		// (get) Token: 0x06033F8A RID: 212874 RVA: 0x00701969 File Offset: 0x006FFB69
		// (set) Token: 0x06033F8B RID: 212875 RVA: 0x00701971 File Offset: 0x006FFB71
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700DA37 RID: 55863
		// (get) Token: 0x06033F8C RID: 212876 RVA: 0x0070197A File Offset: 0x006FFB7A
		// (set) Token: 0x06033F8D RID: 212877 RVA: 0x00701982 File Offset: 0x006FFB82
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700DA38 RID: 55864
		// (get) Token: 0x06033F8E RID: 212878 RVA: 0x0070198B File Offset: 0x006FFB8B
		// (set) Token: 0x06033F8F RID: 212879 RVA: 0x00701993 File Offset: 0x006FFB93
		public bool IsOneWay { get; set; }

		// Token: 0x1700DA39 RID: 55865
		// (get) Token: 0x06033F90 RID: 212880 RVA: 0x0070199C File Offset: 0x006FFB9C
		// (set) Token: 0x06033F91 RID: 212881 RVA: 0x007019A4 File Offset: 0x006FFBA4
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700DA3A RID: 55866
		// (get) Token: 0x06033F92 RID: 212882 RVA: 0x007019AD File Offset: 0x006FFBAD
		// (set) Token: 0x06033F93 RID: 212883 RVA: 0x007019B5 File Offset: 0x006FFBB5
		public bool DynamicGravity { get; set; }

		// Token: 0x1700DA3B RID: 55867
		// (get) Token: 0x06033F94 RID: 212884 RVA: 0x007019BE File Offset: 0x006FFBBE
		// (set) Token: 0x06033F95 RID: 212885 RVA: 0x007019C6 File Offset: 0x006FFBC6
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700DA3C RID: 55868
		// (get) Token: 0x06033F96 RID: 212886 RVA: 0x007019CF File Offset: 0x006FFBCF
		// (set) Token: 0x06033F97 RID: 212887 RVA: 0x007019D7 File Offset: 0x006FFBD7
		public int AutoExitDistance { get; set; }

		// Token: 0x1700DA3D RID: 55869
		// (get) Token: 0x06033F98 RID: 212888 RVA: 0x007019E0 File Offset: 0x006FFBE0
		// (set) Token: 0x06033F99 RID: 212889 RVA: 0x007019E8 File Offset: 0x006FFBE8
		public IPetalGrabMoveLinearT ControlType { get; set; }

		// Token: 0x1700DA3E RID: 55870
		// (get) Token: 0x06033F9A RID: 212890 RVA: 0x007019F1 File Offset: 0x006FFBF1
		// (set) Token: 0x06033F9B RID: 212891 RVA: 0x007019F9 File Offset: 0x006FFBF9
		public byte NullMask { get; set; }

		// Token: 0x06033F9C RID: 212892 RVA: 0x00701A04 File Offset: 0x006FFC04
		public IPetalGrabMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.ControlType = null;
			this.NullMask = 0;
		}
	}
}

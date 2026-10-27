using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C0B RID: 15371
	public class ICylinderSectorTipsActorT
	{
		// Token: 0x170069A2 RID: 27042
		// (get) Token: 0x060152D5 RID: 86741 RVA: 0x003116E8 File Offset: 0x0030F8E8
		// (set) Token: 0x060152D6 RID: 86742 RVA: 0x003116F0 File Offset: 0x0030F8F0
		public ETipsActorType Type { get; set; }

		// Token: 0x170069A3 RID: 27043
		// (get) Token: 0x060152D7 RID: 86743 RVA: 0x003116F9 File Offset: 0x0030F8F9
		// (set) Token: 0x060152D8 RID: 86744 RVA: 0x00311701 File Offset: 0x0030F901
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069A4 RID: 27044
		// (get) Token: 0x060152D9 RID: 86745 RVA: 0x0031170A File Offset: 0x0030F90A
		// (set) Token: 0x060152DA RID: 86746 RVA: 0x00311712 File Offset: 0x0030F912
		public float Radius { get; set; }

		// Token: 0x170069A5 RID: 27045
		// (get) Token: 0x060152DB RID: 86747 RVA: 0x0031171B File Offset: 0x0030F91B
		// (set) Token: 0x060152DC RID: 86748 RVA: 0x00311723 File Offset: 0x0030F923
		public float Height { get; set; }

		// Token: 0x170069A6 RID: 27046
		// (get) Token: 0x060152DD RID: 86749 RVA: 0x0031172C File Offset: 0x0030F92C
		// (set) Token: 0x060152DE RID: 86750 RVA: 0x00311734 File Offset: 0x0030F934
		public float Angle { get; set; }

		// Token: 0x170069A7 RID: 27047
		// (get) Token: 0x060152DF RID: 86751 RVA: 0x0031173D File Offset: 0x0030F93D
		// (set) Token: 0x060152E0 RID: 86752 RVA: 0x00311745 File Offset: 0x0030F945
		public byte NullMask { get; set; }

		// Token: 0x060152E1 RID: 86753 RVA: 0x0031174E File Offset: 0x0030F94E
		public ICylinderSectorTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.Angle = 0f;
			this.NullMask = 0;
		}
	}
}

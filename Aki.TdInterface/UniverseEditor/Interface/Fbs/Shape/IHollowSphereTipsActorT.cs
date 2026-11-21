using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200402C RID: 16428
	public class IHollowSphereTipsActorT
	{
		// Token: 0x17006F98 RID: 28568
		// (get) Token: 0x060168BB RID: 92347 RVA: 0x00339EDE File Offset: 0x003380DE
		// (set) Token: 0x060168BC RID: 92348 RVA: 0x00339EE6 File Offset: 0x003380E6
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F99 RID: 28569
		// (get) Token: 0x060168BD RID: 92349 RVA: 0x00339EEF File Offset: 0x003380EF
		// (set) Token: 0x060168BE RID: 92350 RVA: 0x00339EF7 File Offset: 0x003380F7
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F9A RID: 28570
		// (get) Token: 0x060168BF RID: 92351 RVA: 0x00339F00 File Offset: 0x00338100
		// (set) Token: 0x060168C0 RID: 92352 RVA: 0x00339F08 File Offset: 0x00338108
		public float Radius { get; set; }

		// Token: 0x17006F9B RID: 28571
		// (get) Token: 0x060168C1 RID: 92353 RVA: 0x00339F11 File Offset: 0x00338111
		// (set) Token: 0x060168C2 RID: 92354 RVA: 0x00339F19 File Offset: 0x00338119
		public float InnerRadius { get; set; }

		// Token: 0x17006F9C RID: 28572
		// (get) Token: 0x060168C3 RID: 92355 RVA: 0x00339F22 File Offset: 0x00338122
		// (set) Token: 0x060168C4 RID: 92356 RVA: 0x00339F2A File Offset: 0x0033812A
		public byte NullMask { get; set; }

		// Token: 0x060168C5 RID: 92357 RVA: 0x00339F33 File Offset: 0x00338133
		public IHollowSphereTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.InnerRadius = 0f;
			this.NullMask = 0;
		}
	}
}

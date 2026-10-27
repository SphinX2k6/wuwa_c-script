using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C20 RID: 15392
	public class IHollowSphereTipsActorT
	{
		// Token: 0x170069F0 RID: 27120
		// (get) Token: 0x060153C5 RID: 86981 RVA: 0x00313356 File Offset: 0x00311556
		// (set) Token: 0x060153C6 RID: 86982 RVA: 0x0031335E File Offset: 0x0031155E
		public ETipsActorType Type { get; set; }

		// Token: 0x170069F1 RID: 27121
		// (get) Token: 0x060153C7 RID: 86983 RVA: 0x00313367 File Offset: 0x00311567
		// (set) Token: 0x060153C8 RID: 86984 RVA: 0x0031336F File Offset: 0x0031156F
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069F2 RID: 27122
		// (get) Token: 0x060153C9 RID: 86985 RVA: 0x00313378 File Offset: 0x00311578
		// (set) Token: 0x060153CA RID: 86986 RVA: 0x00313380 File Offset: 0x00311580
		public float Radius { get; set; }

		// Token: 0x170069F3 RID: 27123
		// (get) Token: 0x060153CB RID: 86987 RVA: 0x00313389 File Offset: 0x00311589
		// (set) Token: 0x060153CC RID: 86988 RVA: 0x00313391 File Offset: 0x00311591
		public float InnerRadius { get; set; }

		// Token: 0x170069F4 RID: 27124
		// (get) Token: 0x060153CD RID: 86989 RVA: 0x0031339A File Offset: 0x0031159A
		// (set) Token: 0x060153CE RID: 86990 RVA: 0x003133A2 File Offset: 0x003115A2
		public byte NullMask { get; set; }

		// Token: 0x060153CF RID: 86991 RVA: 0x003133AB File Offset: 0x003115AB
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

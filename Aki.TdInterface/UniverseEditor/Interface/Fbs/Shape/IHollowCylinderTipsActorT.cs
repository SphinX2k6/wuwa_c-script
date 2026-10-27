using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C1A RID: 15386
	public class IHollowCylinderTipsActorT
	{
		// Token: 0x170069D9 RID: 27097
		// (get) Token: 0x0601537F RID: 86911 RVA: 0x00312B34 File Offset: 0x00310D34
		// (set) Token: 0x06015380 RID: 86912 RVA: 0x00312B3C File Offset: 0x00310D3C
		public ETipsActorType Type { get; set; }

		// Token: 0x170069DA RID: 27098
		// (get) Token: 0x06015381 RID: 86913 RVA: 0x00312B45 File Offset: 0x00310D45
		// (set) Token: 0x06015382 RID: 86914 RVA: 0x00312B4D File Offset: 0x00310D4D
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069DB RID: 27099
		// (get) Token: 0x06015383 RID: 86915 RVA: 0x00312B56 File Offset: 0x00310D56
		// (set) Token: 0x06015384 RID: 86916 RVA: 0x00312B5E File Offset: 0x00310D5E
		public float Radius { get; set; }

		// Token: 0x170069DC RID: 27100
		// (get) Token: 0x06015385 RID: 86917 RVA: 0x00312B67 File Offset: 0x00310D67
		// (set) Token: 0x06015386 RID: 86918 RVA: 0x00312B6F File Offset: 0x00310D6F
		public float InnerRadius { get; set; }

		// Token: 0x170069DD RID: 27101
		// (get) Token: 0x06015387 RID: 86919 RVA: 0x00312B78 File Offset: 0x00310D78
		// (set) Token: 0x06015388 RID: 86920 RVA: 0x00312B80 File Offset: 0x00310D80
		public float Height { get; set; }

		// Token: 0x170069DE RID: 27102
		// (get) Token: 0x06015389 RID: 86921 RVA: 0x00312B89 File Offset: 0x00310D89
		// (set) Token: 0x0601538A RID: 86922 RVA: 0x00312B91 File Offset: 0x00310D91
		public byte NullMask { get; set; }

		// Token: 0x0601538B RID: 86923 RVA: 0x00312B9A File Offset: 0x00310D9A
		public IHollowCylinderTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.InnerRadius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}

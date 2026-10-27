using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF3 RID: 15347
	public class IBoxTipsActorT
	{
		// Token: 0x17006959 RID: 26969
		// (get) Token: 0x060151D5 RID: 86485 RVA: 0x0030F330 File Offset: 0x0030D530
		// (set) Token: 0x060151D6 RID: 86486 RVA: 0x0030F338 File Offset: 0x0030D538
		public ETipsActorType Type { get; set; }

		// Token: 0x1700695A RID: 26970
		// (get) Token: 0x060151D7 RID: 86487 RVA: 0x0030F341 File Offset: 0x0030D541
		// (set) Token: 0x060151D8 RID: 86488 RVA: 0x0030F349 File Offset: 0x0030D549
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x1700695B RID: 26971
		// (get) Token: 0x060151D9 RID: 86489 RVA: 0x0030F352 File Offset: 0x0030D552
		// (set) Token: 0x060151DA RID: 86490 RVA: 0x0030F35A File Offset: 0x0030D55A
		public float X { get; set; }

		// Token: 0x1700695C RID: 26972
		// (get) Token: 0x060151DB RID: 86491 RVA: 0x0030F363 File Offset: 0x0030D563
		// (set) Token: 0x060151DC RID: 86492 RVA: 0x0030F36B File Offset: 0x0030D56B
		public float Y { get; set; }

		// Token: 0x1700695D RID: 26973
		// (get) Token: 0x060151DD RID: 86493 RVA: 0x0030F374 File Offset: 0x0030D574
		// (set) Token: 0x060151DE RID: 86494 RVA: 0x0030F37C File Offset: 0x0030D57C
		public float Z { get; set; }

		// Token: 0x1700695E RID: 26974
		// (get) Token: 0x060151DF RID: 86495 RVA: 0x0030F385 File Offset: 0x0030D585
		// (set) Token: 0x060151E0 RID: 86496 RVA: 0x0030F38D File Offset: 0x0030D58D
		public byte NullMask { get; set; }

		// Token: 0x060151E1 RID: 86497 RVA: 0x0030F396 File Offset: 0x0030D596
		public IBoxTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.NullMask = 0;
		}
	}
}

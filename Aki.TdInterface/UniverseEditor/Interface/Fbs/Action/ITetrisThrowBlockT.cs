using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CB RID: 29643
	public class ITetrisThrowBlockT
	{
		// Token: 0x1700E126 RID: 57638
		// (get) Token: 0x06035D79 RID: 220537 RVA: 0x007544F3 File Offset: 0x007526F3
		// (set) Token: 0x06035D7A RID: 220538 RVA: 0x007544FB File Offset: 0x007526FB
		public string ShapeName { get; set; }

		// Token: 0x1700E127 RID: 57639
		// (get) Token: 0x06035D7B RID: 220539 RVA: 0x00754504 File Offset: 0x00752704
		// (set) Token: 0x06035D7C RID: 220540 RVA: 0x0075450C File Offset: 0x0075270C
		public int PosIndex { get; set; }

		// Token: 0x1700E128 RID: 57640
		// (get) Token: 0x06035D7D RID: 220541 RVA: 0x00754515 File Offset: 0x00752715
		// (set) Token: 0x06035D7E RID: 220542 RVA: 0x0075451D File Offset: 0x0075271D
		public int HeightIndex { get; set; }

		// Token: 0x1700E129 RID: 57641
		// (get) Token: 0x06035D7F RID: 220543 RVA: 0x00754526 File Offset: 0x00752726
		// (set) Token: 0x06035D80 RID: 220544 RVA: 0x0075452E File Offset: 0x0075272E
		public ETetrisRotation Rotation { get; set; }

		// Token: 0x1700E12A RID: 57642
		// (get) Token: 0x06035D81 RID: 220545 RVA: 0x00754537 File Offset: 0x00752737
		// (set) Token: 0x06035D82 RID: 220546 RVA: 0x0075453F File Offset: 0x0075273F
		public bool IsDelayFall { get; set; }

		// Token: 0x1700E12B RID: 57643
		// (get) Token: 0x06035D83 RID: 220547 RVA: 0x00754548 File Offset: 0x00752748
		// (set) Token: 0x06035D84 RID: 220548 RVA: 0x00754550 File Offset: 0x00752750
		public int FallSpeed { get; set; }

		// Token: 0x1700E12C RID: 57644
		// (get) Token: 0x06035D85 RID: 220549 RVA: 0x00754559 File Offset: 0x00752759
		// (set) Token: 0x06035D86 RID: 220550 RVA: 0x00754561 File Offset: 0x00752761
		public int FallAcceleration { get; set; }

		// Token: 0x1700E12D RID: 57645
		// (get) Token: 0x06035D87 RID: 220551 RVA: 0x0075456A File Offset: 0x0075276A
		// (set) Token: 0x06035D88 RID: 220552 RVA: 0x00754572 File Offset: 0x00752772
		public byte NullMask { get; set; }

		// Token: 0x06035D89 RID: 220553 RVA: 0x0075457B File Offset: 0x0075277B
		public ITetrisThrowBlockT()
		{
			this.ShapeName = null;
			this.PosIndex = 0;
			this.HeightIndex = 0;
			this.Rotation = ETetrisRotation.Origin;
			this.IsDelayFall = false;
			this.FallSpeed = 0;
			this.FallAcceleration = 0;
			this.NullMask = 0;
		}
	}
}

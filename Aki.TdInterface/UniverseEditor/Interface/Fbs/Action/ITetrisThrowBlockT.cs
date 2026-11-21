using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB2 RID: 31666
	public class ITetrisThrowBlockT
	{
		// Token: 0x1700ED36 RID: 60726
		// (get) Token: 0x06039114 RID: 233748 RVA: 0x007B6A33 File Offset: 0x007B4C33
		// (set) Token: 0x06039115 RID: 233749 RVA: 0x007B6A3B File Offset: 0x007B4C3B
		public string ShapeName { get; set; }

		// Token: 0x1700ED37 RID: 60727
		// (get) Token: 0x06039116 RID: 233750 RVA: 0x007B6A44 File Offset: 0x007B4C44
		// (set) Token: 0x06039117 RID: 233751 RVA: 0x007B6A4C File Offset: 0x007B4C4C
		public int PosIndex { get; set; }

		// Token: 0x1700ED38 RID: 60728
		// (get) Token: 0x06039118 RID: 233752 RVA: 0x007B6A55 File Offset: 0x007B4C55
		// (set) Token: 0x06039119 RID: 233753 RVA: 0x007B6A5D File Offset: 0x007B4C5D
		public int HeightIndex { get; set; }

		// Token: 0x1700ED39 RID: 60729
		// (get) Token: 0x0603911A RID: 233754 RVA: 0x007B6A66 File Offset: 0x007B4C66
		// (set) Token: 0x0603911B RID: 233755 RVA: 0x007B6A6E File Offset: 0x007B4C6E
		public ETetrisRotation Rotation { get; set; }

		// Token: 0x1700ED3A RID: 60730
		// (get) Token: 0x0603911C RID: 233756 RVA: 0x007B6A77 File Offset: 0x007B4C77
		// (set) Token: 0x0603911D RID: 233757 RVA: 0x007B6A7F File Offset: 0x007B4C7F
		public bool IsDelayFall { get; set; }

		// Token: 0x1700ED3B RID: 60731
		// (get) Token: 0x0603911E RID: 233758 RVA: 0x007B6A88 File Offset: 0x007B4C88
		// (set) Token: 0x0603911F RID: 233759 RVA: 0x007B6A90 File Offset: 0x007B4C90
		public int FallSpeed { get; set; }

		// Token: 0x1700ED3C RID: 60732
		// (get) Token: 0x06039120 RID: 233760 RVA: 0x007B6A99 File Offset: 0x007B4C99
		// (set) Token: 0x06039121 RID: 233761 RVA: 0x007B6AA1 File Offset: 0x007B4CA1
		public int FallAcceleration { get; set; }

		// Token: 0x1700ED3D RID: 60733
		// (get) Token: 0x06039122 RID: 233762 RVA: 0x007B6AAA File Offset: 0x007B4CAA
		// (set) Token: 0x06039123 RID: 233763 RVA: 0x007B6AB2 File Offset: 0x007B4CB2
		public byte NullMask { get; set; }

		// Token: 0x06039124 RID: 233764 RVA: 0x007B6ABB File Offset: 0x007B4CBB
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

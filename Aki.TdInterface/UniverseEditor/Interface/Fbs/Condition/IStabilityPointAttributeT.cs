using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D6 RID: 20950
	public class IStabilityPointAttributeT
	{
		// Token: 0x17009609 RID: 38409
		// (get) Token: 0x06020FD3 RID: 135123 RVA: 0x0048F78A File Offset: 0x0048D98A
		// (set) Token: 0x06020FD4 RID: 135124 RVA: 0x0048F792 File Offset: 0x0048D992
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x1700960A RID: 38410
		// (get) Token: 0x06020FD5 RID: 135125 RVA: 0x0048F79B File Offset: 0x0048D99B
		// (set) Token: 0x06020FD6 RID: 135126 RVA: 0x0048F7A3 File Offset: 0x0048D9A3
		public ECompare Compare { get; set; }

		// Token: 0x1700960B RID: 38411
		// (get) Token: 0x06020FD7 RID: 135127 RVA: 0x0048F7AC File Offset: 0x0048D9AC
		// (set) Token: 0x06020FD8 RID: 135128 RVA: 0x0048F7B4 File Offset: 0x0048D9B4
		public int Value { get; set; }

		// Token: 0x1700960C RID: 38412
		// (get) Token: 0x06020FD9 RID: 135129 RVA: 0x0048F7BD File Offset: 0x0048D9BD
		// (set) Token: 0x06020FDA RID: 135130 RVA: 0x0048F7C5 File Offset: 0x0048D9C5
		public int ValueGroup { get; set; }

		// Token: 0x1700960D RID: 38413
		// (get) Token: 0x06020FDB RID: 135131 RVA: 0x0048F7CE File Offset: 0x0048D9CE
		// (set) Token: 0x06020FDC RID: 135132 RVA: 0x0048F7D6 File Offset: 0x0048D9D6
		public byte NullMask { get; set; }

		// Token: 0x06020FDD RID: 135133 RVA: 0x0048F7DF File Offset: 0x0048D9DF
		public IStabilityPointAttributeT()
		{
			this.Type = EPlayerAttributeType.Health;
			this.Compare = ECompare.Eq;
			this.Value = 0;
			this.ValueGroup = 0;
			this.NullMask = 0;
		}
	}
}

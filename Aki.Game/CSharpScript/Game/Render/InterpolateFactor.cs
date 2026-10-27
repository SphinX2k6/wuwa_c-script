using System;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045B3 RID: 17843
	public class InterpolateFactor
	{
		// Token: 0x17007597 RID: 30103
		// (get) Token: 0x0602E04C RID: 188492 RVA: 0x00A9938C File Offset: 0x00A9758C
		// (set) Token: 0x0602E04D RID: 188493 RVA: 0x00A99394 File Offset: 0x00A97594
		public EInterpolateRangeType Type
		{
			get
			{
				return this.TypeInternal;
			}
			set
			{
				if (this.TypeInternal != value)
				{
					this.TypeInternal = value;
				}
			}
		}

		// Token: 0x04018924 RID: 100644
		private EInterpolateRangeType TypeInternal;

		// Token: 0x04018925 RID: 100645
		public float Factor;
	}
}

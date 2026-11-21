using System;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034DB RID: 13531
	public class InterpolateFactor
	{
		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06022736 RID: 141110 RVA: 0x009C55AC File Offset: 0x009C37AC
		// (set) Token: 0x06022737 RID: 141111 RVA: 0x009C55B4 File Offset: 0x009C37B4
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

		// Token: 0x04012F5F RID: 77663
		private EInterpolateRangeType TypeInternal;

		// Token: 0x04012F60 RID: 77664
		public float Factor;
	}
}

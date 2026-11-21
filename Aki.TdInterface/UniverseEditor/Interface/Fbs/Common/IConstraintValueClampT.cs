using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B4 RID: 25524
	public class IConstraintValueClampT
	{
		// Token: 0x1700BC9D RID: 48285
		// (get) Token: 0x0602B57C RID: 177532 RVA: 0x005E82CE File Offset: 0x005E64CE
		// (set) Token: 0x0602B57D RID: 177533 RVA: 0x005E82D6 File Offset: 0x005E64D6
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700BC9E RID: 48286
		// (get) Token: 0x0602B57E RID: 177534 RVA: 0x005E82DF File Offset: 0x005E64DF
		// (set) Token: 0x0602B57F RID: 177535 RVA: 0x005E82E7 File Offset: 0x005E64E7
		public float MinValue { get; set; }

		// Token: 0x1700BC9F RID: 48287
		// (get) Token: 0x0602B580 RID: 177536 RVA: 0x005E82F0 File Offset: 0x005E64F0
		// (set) Token: 0x0602B581 RID: 177537 RVA: 0x005E82F8 File Offset: 0x005E64F8
		public float MaxValue { get; set; }

		// Token: 0x0602B582 RID: 177538 RVA: 0x005E8301 File Offset: 0x005E6501
		public IConstraintValueClampT()
		{
			this.Type = EConstraintValueType.Max;
			this.MinValue = 0f;
			this.MaxValue = 0f;
		}
	}
}

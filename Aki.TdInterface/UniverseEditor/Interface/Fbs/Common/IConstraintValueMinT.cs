using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063BA RID: 25530
	public class IConstraintValueMinT
	{
		// Token: 0x1700BCA8 RID: 48296
		// (get) Token: 0x0602B5AA RID: 177578 RVA: 0x005E8724 File Offset: 0x005E6924
		// (set) Token: 0x0602B5AB RID: 177579 RVA: 0x005E872C File Offset: 0x005E692C
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700BCA9 RID: 48297
		// (get) Token: 0x0602B5AC RID: 177580 RVA: 0x005E8735 File Offset: 0x005E6935
		// (set) Token: 0x0602B5AD RID: 177581 RVA: 0x005E873D File Offset: 0x005E693D
		public float MinValue { get; set; }

		// Token: 0x0602B5AE RID: 177582 RVA: 0x005E8746 File Offset: 0x005E6946
		public IConstraintValueMinT()
		{
			this.Type = EConstraintValueType.Max;
			this.MinValue = 0f;
		}
	}
}

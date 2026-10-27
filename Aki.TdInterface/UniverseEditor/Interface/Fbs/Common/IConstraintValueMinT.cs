using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D7D RID: 23933
	public class IConstraintValueMinT
	{
		// Token: 0x1700B342 RID: 45890
		// (get) Token: 0x06028F20 RID: 167712 RVA: 0x0059F9F4 File Offset: 0x0059DBF4
		// (set) Token: 0x06028F21 RID: 167713 RVA: 0x0059F9FC File Offset: 0x0059DBFC
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700B343 RID: 45891
		// (get) Token: 0x06028F22 RID: 167714 RVA: 0x0059FA05 File Offset: 0x0059DC05
		// (set) Token: 0x06028F23 RID: 167715 RVA: 0x0059FA0D File Offset: 0x0059DC0D
		public float MinValue { get; set; }

		// Token: 0x06028F24 RID: 167716 RVA: 0x0059FA16 File Offset: 0x0059DC16
		public IConstraintValueMinT()
		{
			this.Type = EConstraintValueType.Max;
			this.MinValue = 0f;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D77 RID: 23927
	public class IConstraintValueClampT
	{
		// Token: 0x1700B337 RID: 45879
		// (get) Token: 0x06028EF2 RID: 167666 RVA: 0x0059F59E File Offset: 0x0059D79E
		// (set) Token: 0x06028EF3 RID: 167667 RVA: 0x0059F5A6 File Offset: 0x0059D7A6
		public EConstraintValueType Type { get; set; }

		// Token: 0x1700B338 RID: 45880
		// (get) Token: 0x06028EF4 RID: 167668 RVA: 0x0059F5AF File Offset: 0x0059D7AF
		// (set) Token: 0x06028EF5 RID: 167669 RVA: 0x0059F5B7 File Offset: 0x0059D7B7
		public float MinValue { get; set; }

		// Token: 0x1700B339 RID: 45881
		// (get) Token: 0x06028EF6 RID: 167670 RVA: 0x0059F5C0 File Offset: 0x0059D7C0
		// (set) Token: 0x06028EF7 RID: 167671 RVA: 0x0059F5C8 File Offset: 0x0059D7C8
		public float MaxValue { get; set; }

		// Token: 0x06028EF8 RID: 167672 RVA: 0x0059F5D1 File Offset: 0x0059D7D1
		public IConstraintValueClampT()
		{
			this.Type = EConstraintValueType.Max;
			this.MinValue = 0f;
			this.MaxValue = 0f;
		}
	}
}

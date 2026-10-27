using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B42 RID: 19266
	public class ICheckSystemStateConditionT
	{
		// Token: 0x17008BC9 RID: 35785
		// (get) Token: 0x0601E545 RID: 124229 RVA: 0x0043FF5B File Offset: 0x0043E15B
		// (set) Token: 0x0601E546 RID: 124230 RVA: 0x0043FF63 File Offset: 0x0043E163
		public ECondition Type { get; set; }

		// Token: 0x17008BCA RID: 35786
		// (get) Token: 0x0601E547 RID: 124231 RVA: 0x0043FF6C File Offset: 0x0043E16C
		// (set) Token: 0x0601E548 RID: 124232 RVA: 0x0043FF74 File Offset: 0x0043E174
		public TCheckSystemStateUnion Config { get; set; }

		// Token: 0x0601E549 RID: 124233 RVA: 0x0043FF7D File Offset: 0x0043E17D
		public ICheckSystemStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Config = null;
		}
	}
}

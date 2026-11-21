using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200520F RID: 21007
	public class IVisibleConditionT
	{
		// Token: 0x17009652 RID: 38482
		// (get) Token: 0x0602115D RID: 135517 RVA: 0x00492114 File Offset: 0x00490314
		// (set) Token: 0x0602115E RID: 135518 RVA: 0x0049211C File Offset: 0x0049031C
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009653 RID: 38483
		// (get) Token: 0x0602115F RID: 135519 RVA: 0x00492125 File Offset: 0x00490325
		// (set) Token: 0x06021160 RID: 135520 RVA: 0x0049212D File Offset: 0x0049032D
		public ECompare Compare { get; set; }

		// Token: 0x06021161 RID: 135521 RVA: 0x00492136 File Offset: 0x00490336
		public IVisibleConditionT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
		}
	}
}

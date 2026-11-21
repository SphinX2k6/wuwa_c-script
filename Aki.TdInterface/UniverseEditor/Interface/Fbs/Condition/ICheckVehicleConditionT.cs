using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005050 RID: 20560
	public class ICheckVehicleConditionT
	{
		// Token: 0x17009328 RID: 37672
		// (get) Token: 0x0602023F RID: 131647 RVA: 0x00475413 File Offset: 0x00473613
		// (set) Token: 0x06020240 RID: 131648 RVA: 0x0047541B File Offset: 0x0047361B
		public ECondition Type { get; set; }

		// Token: 0x17009329 RID: 37673
		// (get) Token: 0x06020241 RID: 131649 RVA: 0x00475424 File Offset: 0x00473624
		// (set) Token: 0x06020242 RID: 131650 RVA: 0x0047542C File Offset: 0x0047362C
		public TVehicleConditionUnion Condition { get; set; }

		// Token: 0x06020243 RID: 131651 RVA: 0x00475435 File Offset: 0x00473635
		public ICheckVehicleConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Condition = null;
		}
	}
}

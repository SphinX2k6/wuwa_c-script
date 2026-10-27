using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2C RID: 23084
	public class ITargetGearGroupConfigT
	{
		// Token: 0x1700ADA3 RID: 44451
		// (get) Token: 0x060273E0 RID: 160736 RVA: 0x00566808 File Offset: 0x00564A08
		// (set) Token: 0x060273E1 RID: 160737 RVA: 0x00566810 File Offset: 0x00564A10
		public List<int> Entitys { get; set; }

		// Token: 0x1700ADA4 RID: 44452
		// (get) Token: 0x060273E2 RID: 160738 RVA: 0x00566819 File Offset: 0x00564A19
		// (set) Token: 0x060273E3 RID: 160739 RVA: 0x00566821 File Offset: 0x00564A21
		public TTargetGearGroupSuccessConditionUnion SuccessCondition { get; set; }

		// Token: 0x1700ADA5 RID: 44453
		// (get) Token: 0x060273E4 RID: 160740 RVA: 0x0056682A File Offset: 0x00564A2A
		// (set) Token: 0x060273E5 RID: 160741 RVA: 0x00566832 File Offset: 0x00564A32
		public List<TTargetGearGroupFailureConditionUnion> FailureConditions { get; set; }

		// Token: 0x1700ADA6 RID: 44454
		// (get) Token: 0x060273E6 RID: 160742 RVA: 0x0056683B File Offset: 0x00564A3B
		// (set) Token: 0x060273E7 RID: 160743 RVA: 0x00566843 File Offset: 0x00564A43
		public List<ICheckGearHitT> CheckGears { get; set; }

		// Token: 0x1700ADA7 RID: 44455
		// (get) Token: 0x060273E8 RID: 160744 RVA: 0x0056684C File Offset: 0x00564A4C
		// (set) Token: 0x060273E9 RID: 160745 RVA: 0x00566854 File Offset: 0x00564A54
		public TGroupFinishConfigUnion FinishConfig { get; set; }

		// Token: 0x1700ADA8 RID: 44456
		// (get) Token: 0x060273EA RID: 160746 RVA: 0x0056685D File Offset: 0x00564A5D
		// (set) Token: 0x060273EB RID: 160747 RVA: 0x00566865 File Offset: 0x00564A65
		public byte NullMask { get; set; }

		// Token: 0x060273EC RID: 160748 RVA: 0x0056686E File Offset: 0x00564A6E
		public ITargetGearGroupConfigT()
		{
			this.Entitys = null;
			this.SuccessCondition = null;
			this.FailureConditions = null;
			this.CheckGears = null;
			this.FinishConfig = null;
			this.NullMask = 0;
		}
	}
}

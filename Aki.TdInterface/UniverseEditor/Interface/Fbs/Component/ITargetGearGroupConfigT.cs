using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006039 RID: 24633
	public class ITargetGearGroupConfigT
	{
		// Token: 0x1700B6DB RID: 46811
		// (get) Token: 0x06029958 RID: 170328 RVA: 0x005AD7CC File Offset: 0x005AB9CC
		// (set) Token: 0x06029959 RID: 170329 RVA: 0x005AD7D4 File Offset: 0x005AB9D4
		public List<int> Entitys { get; set; }

		// Token: 0x1700B6DC RID: 46812
		// (get) Token: 0x0602995A RID: 170330 RVA: 0x005AD7DD File Offset: 0x005AB9DD
		// (set) Token: 0x0602995B RID: 170331 RVA: 0x005AD7E5 File Offset: 0x005AB9E5
		public TTargetGearGroupSuccessConditionUnion SuccessCondition { get; set; }

		// Token: 0x1700B6DD RID: 46813
		// (get) Token: 0x0602995C RID: 170332 RVA: 0x005AD7EE File Offset: 0x005AB9EE
		// (set) Token: 0x0602995D RID: 170333 RVA: 0x005AD7F6 File Offset: 0x005AB9F6
		public List<TTargetGearGroupFailureConditionUnion> FailureConditions { get; set; }

		// Token: 0x1700B6DE RID: 46814
		// (get) Token: 0x0602995E RID: 170334 RVA: 0x005AD7FF File Offset: 0x005AB9FF
		// (set) Token: 0x0602995F RID: 170335 RVA: 0x005AD807 File Offset: 0x005ABA07
		public List<ICheckGearHitT> CheckGears { get; set; }

		// Token: 0x1700B6DF RID: 46815
		// (get) Token: 0x06029960 RID: 170336 RVA: 0x005AD810 File Offset: 0x005ABA10
		// (set) Token: 0x06029961 RID: 170337 RVA: 0x005AD818 File Offset: 0x005ABA18
		public TGroupFinishConfigUnion FinishConfig { get; set; }

		// Token: 0x1700B6E0 RID: 46816
		// (get) Token: 0x06029962 RID: 170338 RVA: 0x005AD821 File Offset: 0x005ABA21
		// (set) Token: 0x06029963 RID: 170339 RVA: 0x005AD829 File Offset: 0x005ABA29
		public byte NullMask { get; set; }

		// Token: 0x06029964 RID: 170340 RVA: 0x005AD832 File Offset: 0x005ABA32
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

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005032 RID: 20530
	public class ICheckTargetAttributeConditionT
	{
		// Token: 0x170092E4 RID: 37604
		// (get) Token: 0x0602012D RID: 131373 RVA: 0x004732A1 File Offset: 0x004714A1
		// (set) Token: 0x0602012E RID: 131374 RVA: 0x004732A9 File Offset: 0x004714A9
		public ECondition Type { get; set; }

		// Token: 0x170092E5 RID: 37605
		// (get) Token: 0x0602012F RID: 131375 RVA: 0x004732B2 File Offset: 0x004714B2
		// (set) Token: 0x06020130 RID: 131376 RVA: 0x004732BA File Offset: 0x004714BA
		public IPlayerAttributeT Option { get; set; }

		// Token: 0x170092E6 RID: 37606
		// (get) Token: 0x06020131 RID: 131377 RVA: 0x004732C3 File Offset: 0x004714C3
		// (set) Token: 0x06020132 RID: 131378 RVA: 0x004732CB File Offset: 0x004714CB
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020133 RID: 131379 RVA: 0x004732D4 File Offset: 0x004714D4
		public ICheckTargetAttributeConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Option = null;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

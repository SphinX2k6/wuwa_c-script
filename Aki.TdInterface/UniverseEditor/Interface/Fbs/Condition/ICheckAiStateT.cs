using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004980 RID: 18816
	public class ICheckAiStateT
	{
		// Token: 0x170087E5 RID: 34789
		// (get) Token: 0x0601D550 RID: 120144 RVA: 0x00422E3A File Offset: 0x0042103A
		// (set) Token: 0x0601D551 RID: 120145 RVA: 0x00422E42 File Offset: 0x00421042
		public ECondition Type { get; set; }

		// Token: 0x170087E6 RID: 34790
		// (get) Token: 0x0601D552 RID: 120146 RVA: 0x00422E4B File Offset: 0x0042104B
		// (set) Token: 0x0601D553 RID: 120147 RVA: 0x00422E53 File Offset: 0x00421053
		public ECompare Compare { get; set; }

		// Token: 0x170087E7 RID: 34791
		// (get) Token: 0x0601D554 RID: 120148 RVA: 0x00422E5C File Offset: 0x0042105C
		// (set) Token: 0x0601D555 RID: 120149 RVA: 0x00422E64 File Offset: 0x00421064
		public EAiStateType StateType { get; set; }

		// Token: 0x0601D556 RID: 120150 RVA: 0x00422E6D File Offset: 0x0042106D
		public ICheckAiStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.StateType = EAiStateType.AnimalStandUp;
		}
	}
}

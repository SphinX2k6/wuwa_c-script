using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A34 RID: 18996
	public class ICheckGameplayTagConditionT
	{
		// Token: 0x17008985 RID: 35205
		// (get) Token: 0x0601DBC6 RID: 121798 RVA: 0x0042EA8B File Offset: 0x0042CC8B
		// (set) Token: 0x0601DBC7 RID: 121799 RVA: 0x0042EA93 File Offset: 0x0042CC93
		public ECondition Type { get; set; }

		// Token: 0x17008986 RID: 35206
		// (get) Token: 0x0601DBC8 RID: 121800 RVA: 0x0042EA9C File Offset: 0x0042CC9C
		// (set) Token: 0x0601DBC9 RID: 121801 RVA: 0x0042EAA4 File Offset: 0x0042CCA4
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008987 RID: 35207
		// (get) Token: 0x0601DBCA RID: 121802 RVA: 0x0042EAAD File Offset: 0x0042CCAD
		// (set) Token: 0x0601DBCB RID: 121803 RVA: 0x0042EAB5 File Offset: 0x0042CCB5
		public string GameplayTag { get; set; }

		// Token: 0x17008988 RID: 35208
		// (get) Token: 0x0601DBCC RID: 121804 RVA: 0x0042EABE File Offset: 0x0042CCBE
		// (set) Token: 0x0601DBCD RID: 121805 RVA: 0x0042EAC6 File Offset: 0x0042CCC6
		public ECompare Compare { get; set; }

		// Token: 0x0601DBCE RID: 121806 RVA: 0x0042EACF File Offset: 0x0042CCCF
		public ICheckGameplayTagConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.GameplayTag = null;
			this.Compare = ECompare.Eq;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F39 RID: 20281
	public class ICheckInCombatT
	{
		// Token: 0x170090E6 RID: 37094
		// (get) Token: 0x0601F88F RID: 129167 RVA: 0x0046348D File Offset: 0x0046168D
		// (set) Token: 0x0601F890 RID: 129168 RVA: 0x00463495 File Offset: 0x00461695
		public ECondition Type { get; set; }

		// Token: 0x170090E7 RID: 37095
		// (get) Token: 0x0601F891 RID: 129169 RVA: 0x0046349E File Offset: 0x0046169E
		// (set) Token: 0x0601F892 RID: 129170 RVA: 0x004634A6 File Offset: 0x004616A6
		public bool InCombat { get; set; }

		// Token: 0x170090E8 RID: 37096
		// (get) Token: 0x0601F893 RID: 129171 RVA: 0x004634AF File Offset: 0x004616AF
		// (set) Token: 0x0601F894 RID: 129172 RVA: 0x004634B7 File Offset: 0x004616B7
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F895 RID: 129173 RVA: 0x004634C0 File Offset: 0x004616C0
		public ICheckInCombatT()
		{
			this.Type = ECondition.CompareVar;
			this.InCombat = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

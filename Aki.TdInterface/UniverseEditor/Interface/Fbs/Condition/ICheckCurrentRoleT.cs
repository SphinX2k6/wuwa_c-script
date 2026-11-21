using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E6D RID: 20077
	public class ICheckCurrentRoleT
	{
		// Token: 0x17008F31 RID: 36657
		// (get) Token: 0x0601F187 RID: 127367 RVA: 0x00456DAF File Offset: 0x00454FAF
		// (set) Token: 0x0601F188 RID: 127368 RVA: 0x00456DB7 File Offset: 0x00454FB7
		public ECondition Type { get; set; }

		// Token: 0x17008F32 RID: 36658
		// (get) Token: 0x0601F189 RID: 127369 RVA: 0x00456DC0 File Offset: 0x00454FC0
		// (set) Token: 0x0601F18A RID: 127370 RVA: 0x00456DC8 File Offset: 0x00454FC8
		public int RoleId { get; set; }

		// Token: 0x17008F33 RID: 36659
		// (get) Token: 0x0601F18B RID: 127371 RVA: 0x00456DD1 File Offset: 0x00454FD1
		// (set) Token: 0x0601F18C RID: 127372 RVA: 0x00456DD9 File Offset: 0x00454FD9
		public ECompare Compare { get; set; }

		// Token: 0x17008F34 RID: 36660
		// (get) Token: 0x0601F18D RID: 127373 RVA: 0x00456DE2 File Offset: 0x00454FE2
		// (set) Token: 0x0601F18E RID: 127374 RVA: 0x00456DEA File Offset: 0x00454FEA
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F18F RID: 127375 RVA: 0x00456DF3 File Offset: 0x00454FF3
		public ICheckCurrentRoleT()
		{
			this.Type = ECondition.CompareVar;
			this.RoleId = 0;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

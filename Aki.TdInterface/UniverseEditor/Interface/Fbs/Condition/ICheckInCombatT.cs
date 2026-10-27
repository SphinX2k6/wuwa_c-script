using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A73 RID: 19059
	public class ICheckInCombatT
	{
		// Token: 0x17008A0A RID: 35338
		// (get) Token: 0x0601DDEC RID: 122348 RVA: 0x00432301 File Offset: 0x00430501
		// (set) Token: 0x0601DDED RID: 122349 RVA: 0x00432309 File Offset: 0x00430509
		public ECondition Type { get; set; }

		// Token: 0x17008A0B RID: 35339
		// (get) Token: 0x0601DDEE RID: 122350 RVA: 0x00432312 File Offset: 0x00430512
		// (set) Token: 0x0601DDEF RID: 122351 RVA: 0x0043231A File Offset: 0x0043051A
		public bool InCombat { get; set; }

		// Token: 0x17008A0C RID: 35340
		// (get) Token: 0x0601DDF0 RID: 122352 RVA: 0x00432323 File Offset: 0x00430523
		// (set) Token: 0x0601DDF1 RID: 122353 RVA: 0x0043232B File Offset: 0x0043052B
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601DDF2 RID: 122354 RVA: 0x00432334 File Offset: 0x00430534
		public ICheckInCombatT()
		{
			this.Type = ECondition.CompareVar;
			this.InCombat = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

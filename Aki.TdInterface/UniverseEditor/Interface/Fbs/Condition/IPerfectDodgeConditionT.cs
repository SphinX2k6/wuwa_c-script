using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005167 RID: 20839
	public class IPerfectDodgeConditionT
	{
		// Token: 0x1700954C RID: 38220
		// (get) Token: 0x06020C91 RID: 134289 RVA: 0x0048A323 File Offset: 0x00488523
		// (set) Token: 0x06020C92 RID: 134290 RVA: 0x0048A32B File Offset: 0x0048852B
		public EBattleConditionType Type { get; set; }

		// Token: 0x1700954D RID: 38221
		// (get) Token: 0x06020C93 RID: 134291 RVA: 0x0048A334 File Offset: 0x00488534
		// (set) Token: 0x06020C94 RID: 134292 RVA: 0x0048A33C File Offset: 0x0048853C
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020C95 RID: 134293 RVA: 0x0048A345 File Offset: 0x00488545
		public IPerfectDodgeConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

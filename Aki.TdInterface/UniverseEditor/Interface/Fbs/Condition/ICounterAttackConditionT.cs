using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E0 RID: 20704
	public class ICounterAttackConditionT
	{
		// Token: 0x1700945F RID: 37983
		// (get) Token: 0x0602086D RID: 133229 RVA: 0x004835E7 File Offset: 0x004817E7
		// (set) Token: 0x0602086E RID: 133230 RVA: 0x004835EF File Offset: 0x004817EF
		public EBattleConditionType Type { get; set; }

		// Token: 0x17009460 RID: 37984
		// (get) Token: 0x0602086F RID: 133231 RVA: 0x004835F8 File Offset: 0x004817F8
		// (set) Token: 0x06020870 RID: 133232 RVA: 0x00483600 File Offset: 0x00481800
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020871 RID: 133233 RVA: 0x00483609 File Offset: 0x00481809
		public ICounterAttackConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

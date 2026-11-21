using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E3 RID: 30691
	public class ISetMonsterMoveTargetT
	{
		// Token: 0x1700E0ED RID: 57581
		// (get) Token: 0x06035E93 RID: 220819 RVA: 0x00738E51 File Offset: 0x00737051
		// (set) Token: 0x06035E94 RID: 220820 RVA: 0x00738E59 File Offset: 0x00737059
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700E0EE RID: 57582
		// (get) Token: 0x06035E95 RID: 220821 RVA: 0x00738E62 File Offset: 0x00737062
		// (set) Token: 0x06035E96 RID: 220822 RVA: 0x00738E6A File Offset: 0x0073706A
		public int TargetEntityId { get; set; }

		// Token: 0x1700E0EF RID: 57583
		// (get) Token: 0x06035E97 RID: 220823 RVA: 0x00738E73 File Offset: 0x00737073
		// (set) Token: 0x06035E98 RID: 220824 RVA: 0x00738E7B File Offset: 0x0073707B
		public EMoveEvent MoveEvent { get; set; }

		// Token: 0x1700E0F0 RID: 57584
		// (get) Token: 0x06035E99 RID: 220825 RVA: 0x00738E84 File Offset: 0x00737084
		// (set) Token: 0x06035E9A RID: 220826 RVA: 0x00738E8C File Offset: 0x0073708C
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700E0F1 RID: 57585
		// (get) Token: 0x06035E9B RID: 220827 RVA: 0x00738E95 File Offset: 0x00737095
		// (set) Token: 0x06035E9C RID: 220828 RVA: 0x00738E9D File Offset: 0x0073709D
		public byte NullMask { get; set; }

		// Token: 0x06035E9D RID: 220829 RVA: 0x00738EA6 File Offset: 0x007370A6
		public ISetMonsterMoveTargetT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.TargetEntityId = 0;
			this.MoveEvent = EMoveEvent.Walk;
			this.MonsterEntityIds = null;
			this.NullMask = 0;
		}
	}
}

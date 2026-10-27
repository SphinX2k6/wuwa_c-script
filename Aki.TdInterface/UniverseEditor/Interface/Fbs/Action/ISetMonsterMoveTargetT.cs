using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701A RID: 28698
	public class ISetMonsterMoveTargetT
	{
		// Token: 0x1700D519 RID: 54553
		// (get) Token: 0x06032C2D RID: 207917 RVA: 0x006D920D File Offset: 0x006D740D
		// (set) Token: 0x06032C2E RID: 207918 RVA: 0x006D9215 File Offset: 0x006D7415
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700D51A RID: 54554
		// (get) Token: 0x06032C2F RID: 207919 RVA: 0x006D921E File Offset: 0x006D741E
		// (set) Token: 0x06032C30 RID: 207920 RVA: 0x006D9226 File Offset: 0x006D7426
		public int TargetEntityId { get; set; }

		// Token: 0x1700D51B RID: 54555
		// (get) Token: 0x06032C31 RID: 207921 RVA: 0x006D922F File Offset: 0x006D742F
		// (set) Token: 0x06032C32 RID: 207922 RVA: 0x006D9237 File Offset: 0x006D7437
		public EMoveEvent MoveEvent { get; set; }

		// Token: 0x1700D51C RID: 54556
		// (get) Token: 0x06032C33 RID: 207923 RVA: 0x006D9240 File Offset: 0x006D7440
		// (set) Token: 0x06032C34 RID: 207924 RVA: 0x006D9248 File Offset: 0x006D7448
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700D51D RID: 54557
		// (get) Token: 0x06032C35 RID: 207925 RVA: 0x006D9251 File Offset: 0x006D7451
		// (set) Token: 0x06032C36 RID: 207926 RVA: 0x006D9259 File Offset: 0x006D7459
		public byte NullMask { get; set; }

		// Token: 0x06032C37 RID: 207927 RVA: 0x006D9262 File Offset: 0x006D7462
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

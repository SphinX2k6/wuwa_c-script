using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C21 RID: 27681
	public class IDetectBattleTagT
	{
		// Token: 0x1700CAE2 RID: 51938
		// (get) Token: 0x0602FA3B RID: 195131 RVA: 0x0067DA07 File Offset: 0x0067BC07
		// (set) Token: 0x0602FA3C RID: 195132 RVA: 0x0067DA0F File Offset: 0x0067BC0F
		public EDetectBattleConditionType Type { get; set; }

		// Token: 0x1700CAE3 RID: 51939
		// (get) Token: 0x0602FA3D RID: 195133 RVA: 0x0067DA18 File Offset: 0x0067BC18
		// (set) Token: 0x0602FA3E RID: 195134 RVA: 0x0067DA20 File Offset: 0x0067BC20
		public int EntityId { get; set; }

		// Token: 0x1700CAE4 RID: 51940
		// (get) Token: 0x0602FA3F RID: 195135 RVA: 0x0067DA29 File Offset: 0x0067BC29
		// (set) Token: 0x0602FA40 RID: 195136 RVA: 0x0067DA31 File Offset: 0x0067BC31
		public IDetectBattleMonsterOnGroundT TagOption { get; set; }

		// Token: 0x1700CAE5 RID: 51941
		// (get) Token: 0x0602FA41 RID: 195137 RVA: 0x0067DA3A File Offset: 0x0067BC3A
		// (set) Token: 0x0602FA42 RID: 195138 RVA: 0x0067DA42 File Offset: 0x0067BC42
		public float MaxWaitTime { get; set; }

		// Token: 0x0602FA43 RID: 195139 RVA: 0x0067DA4B File Offset: 0x0067BC4B
		public IDetectBattleTagT()
		{
			this.Type = EDetectBattleConditionType.DetectBattleTag;
			this.EntityId = 0;
			this.TagOption = null;
			this.MaxWaitTime = 0f;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B9 RID: 26041
	public class IDetectBattleTagT
	{
		// Token: 0x1700C153 RID: 49491
		// (get) Token: 0x0602D2B7 RID: 185015 RVA: 0x00631843 File Offset: 0x0062FA43
		// (set) Token: 0x0602D2B8 RID: 185016 RVA: 0x0063184B File Offset: 0x0062FA4B
		public EDetectBattleConditionType Type { get; set; }

		// Token: 0x1700C154 RID: 49492
		// (get) Token: 0x0602D2B9 RID: 185017 RVA: 0x00631854 File Offset: 0x0062FA54
		// (set) Token: 0x0602D2BA RID: 185018 RVA: 0x0063185C File Offset: 0x0062FA5C
		public int EntityId { get; set; }

		// Token: 0x1700C155 RID: 49493
		// (get) Token: 0x0602D2BB RID: 185019 RVA: 0x00631865 File Offset: 0x0062FA65
		// (set) Token: 0x0602D2BC RID: 185020 RVA: 0x0063186D File Offset: 0x0062FA6D
		public IDetectBattleMonsterOnGroundT TagOption { get; set; }

		// Token: 0x1700C156 RID: 49494
		// (get) Token: 0x0602D2BD RID: 185021 RVA: 0x00631876 File Offset: 0x0062FA76
		// (set) Token: 0x0602D2BE RID: 185022 RVA: 0x0063187E File Offset: 0x0062FA7E
		public float MaxWaitTime { get; set; }

		// Token: 0x0602D2BF RID: 185023 RVA: 0x00631887 File Offset: 0x0062FA87
		public IDetectBattleTagT()
		{
			this.Type = EDetectBattleConditionType.DetectBattleTag;
			this.EntityId = 0;
			this.TagOption = null;
			this.MaxWaitTime = 0f;
		}
	}
}

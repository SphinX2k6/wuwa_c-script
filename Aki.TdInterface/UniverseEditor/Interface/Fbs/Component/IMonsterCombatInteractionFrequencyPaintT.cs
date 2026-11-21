using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B08 RID: 23304
	public class IMonsterCombatInteractionFrequencyPaintT
	{
		// Token: 0x1700AA0E RID: 43534
		// (get) Token: 0x060264B2 RID: 156850 RVA: 0x0053EF54 File Offset: 0x0053D154
		// (set) Token: 0x060264B3 RID: 156851 RVA: 0x0053EF5C File Offset: 0x0053D15C
		public EMonsterCombatInteractionType Type { get; set; }

		// Token: 0x1700AA0F RID: 43535
		// (get) Token: 0x060264B4 RID: 156852 RVA: 0x0053EF65 File Offset: 0x0053D165
		// (set) Token: 0x060264B5 RID: 156853 RVA: 0x0053EF6D File Offset: 0x0053D16D
		public int FrequencyPaintTableId { get; set; }

		// Token: 0x060264B6 RID: 156854 RVA: 0x0053EF76 File Offset: 0x0053D176
		public IMonsterCombatInteractionFrequencyPaintT()
		{
			this.Type = EMonsterCombatInteractionType.WaterBoxStagnation;
			this.FrequencyPaintTableId = 0;
		}
	}
}

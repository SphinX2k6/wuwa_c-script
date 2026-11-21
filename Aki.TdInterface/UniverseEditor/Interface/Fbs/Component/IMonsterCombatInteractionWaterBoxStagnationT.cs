using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0B RID: 23307
	public class IMonsterCombatInteractionWaterBoxStagnationT
	{
		// Token: 0x1700AA12 RID: 43538
		// (get) Token: 0x060264C6 RID: 156870 RVA: 0x0053F0F2 File Offset: 0x0053D2F2
		// (set) Token: 0x060264C7 RID: 156871 RVA: 0x0053F0FA File Offset: 0x0053D2FA
		public EMonsterCombatInteractionType Type { get; set; }

		// Token: 0x060264C8 RID: 156872 RVA: 0x0053F103 File Offset: 0x0053D303
		public IMonsterCombatInteractionWaterBoxStagnationT()
		{
			this.Type = EMonsterCombatInteractionType.WaterBoxStagnation;
		}
	}
}

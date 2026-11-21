using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B02 RID: 23298
	public class IMonsterCombatInteractionConfigT
	{
		// Token: 0x1700AA08 RID: 43528
		// (get) Token: 0x06026490 RID: 156816 RVA: 0x0053EC32 File Offset: 0x0053CE32
		// (set) Token: 0x06026491 RID: 156817 RVA: 0x0053EC3A File Offset: 0x0053CE3A
		public EMonsterCombatInteractionType Type { get; set; }

		// Token: 0x06026492 RID: 156818 RVA: 0x0053EC43 File Offset: 0x0053CE43
		public IMonsterCombatInteractionConfigT()
		{
			this.Type = EMonsterCombatInteractionType.WaterBoxStagnation;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416A RID: 16746
	public class ICheckMonsterBattleAttributeT
	{
		// Token: 0x1700717B RID: 29051
		// (get) Token: 0x060170B3 RID: 94387 RVA: 0x00349402 File Offset: 0x00347602
		// (set) Token: 0x060170B4 RID: 94388 RVA: 0x0034940A File Offset: 0x0034760A
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x1700717C RID: 29052
		// (get) Token: 0x060170B5 RID: 94389 RVA: 0x00349413 File Offset: 0x00347613
		// (set) Token: 0x060170B6 RID: 94390 RVA: 0x0034941B File Offset: 0x0034761B
		public IHealthAttributeToTargetT Option { get; set; }

		// Token: 0x1700717D RID: 29053
		// (get) Token: 0x060170B7 RID: 94391 RVA: 0x00349424 File Offset: 0x00347624
		// (set) Token: 0x060170B8 RID: 94392 RVA: 0x0034942C File Offset: 0x0034762C
		public List<int> EntityIds { get; set; }

		// Token: 0x060170B9 RID: 94393 RVA: 0x00349435 File Offset: 0x00347635
		public ICheckMonsterBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
			this.Option = null;
			this.EntityIds = null;
		}
	}
}

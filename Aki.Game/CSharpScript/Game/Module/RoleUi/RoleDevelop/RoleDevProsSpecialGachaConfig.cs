using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CB7 RID: 15543
	public class RoleDevProsSpecialGachaConfig : IRoleDevProsSpecialGachaConfig
	{
		// Token: 0x06027D97 RID: 163223 RVA: 0x00B2734C File Offset: 0x00B2554C
		public RoleDevProsSpecialGachaConfig(int TypeId, int GachaId)
		{
		}

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x06027D98 RID: 163224 RVA: 0x00B27362 File Offset: 0x00B25562
		// (set) Token: 0x06027D99 RID: 163225 RVA: 0x00B2736A File Offset: 0x00B2556A
		public int TypeId { get; set; } = TypeId;

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x06027D9A RID: 163226 RVA: 0x00B27373 File Offset: 0x00B25573
		// (set) Token: 0x06027D9B RID: 163227 RVA: 0x00B2737B File Offset: 0x00B2557B
		public int GachaId { get; set; } = GachaId;
	}
}

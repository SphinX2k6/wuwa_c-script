using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FC RID: 29436
	public class INotifyMonsterPlayStandbyTagsT
	{
		// Token: 0x1700D7D4 RID: 55252
		// (get) Token: 0x0603355B RID: 210267 RVA: 0x006EC675 File Offset: 0x006EA875
		// (set) Token: 0x0603355C RID: 210268 RVA: 0x006EC67D File Offset: 0x006EA87D
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700D7D5 RID: 55253
		// (get) Token: 0x0603355D RID: 210269 RVA: 0x006EC686 File Offset: 0x006EA886
		// (set) Token: 0x0603355E RID: 210270 RVA: 0x006EC68E File Offset: 0x006EA88E
		public List<IMonsterStandByConfigT> StandbyConfigs { get; set; }

		// Token: 0x1700D7D6 RID: 55254
		// (get) Token: 0x0603355F RID: 210271 RVA: 0x006EC697 File Offset: 0x006EA897
		// (set) Token: 0x06033560 RID: 210272 RVA: 0x006EC69F File Offset: 0x006EA89F
		public byte NullMask { get; set; }

		// Token: 0x06033561 RID: 210273 RVA: 0x006EC6A8 File Offset: 0x006EA8A8
		public INotifyMonsterPlayStandbyTagsT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.StandbyConfigs = null;
			this.NullMask = 0;
		}
	}
}

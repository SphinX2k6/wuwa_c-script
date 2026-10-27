using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539F RID: 21407
	public class IHitLogicChangeTargetStateT
	{
		// Token: 0x17009D4A RID: 40266
		// (get) Token: 0x06023102 RID: 143618 RVA: 0x004DAC70 File Offset: 0x004D8E70
		// (set) Token: 0x06023103 RID: 143619 RVA: 0x004DAC78 File Offset: 0x004D8E78
		public EHitLogicType Type { get; set; }

		// Token: 0x17009D4B RID: 40267
		// (get) Token: 0x06023104 RID: 143620 RVA: 0x004DAC81 File Offset: 0x004D8E81
		// (set) Token: 0x06023105 RID: 143621 RVA: 0x004DAC89 File Offset: 0x004D8E89
		public List<IConditionHitConfigWithBulletT> TargetBulletHitConfigs { get; set; }

		// Token: 0x17009D4C RID: 40268
		// (get) Token: 0x06023106 RID: 143622 RVA: 0x004DAC92 File Offset: 0x004D8E92
		// (set) Token: 0x06023107 RID: 143623 RVA: 0x004DAC9A File Offset: 0x004D8E9A
		public List<IConditionHitConfigT> OtherBulletsHitConfig { get; set; }

		// Token: 0x06023108 RID: 143624 RVA: 0x004DACA3 File Offset: 0x004D8EA3
		public IHitLogicChangeTargetStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.TargetBulletHitConfigs = null;
			this.OtherBulletsHitConfig = null;
		}
	}
}

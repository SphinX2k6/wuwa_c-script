using System;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F75 RID: 12149
	public class RangeComponentPolicy
	{
		// Token: 0x0400F26D RID: 62061
		public RangeComponentConfigRule NeedReqEntityAccessRange = false;

		// Token: 0x0400F26E RID: 62062
		public RangeComponentConfigRule NeedReqPlayerAccessRange = false;

		// Token: 0x0400F26F RID: 62063
		public RangeComponentConfigRule NeedPendingEmitEvent = false;

		// Token: 0x0400F270 RID: 62064
		public RangeComponentConfigRule NeedDisablePassiveCollision = false;

		// Token: 0x0400F271 RID: 62065
		public RangeComponentConfigRule NeedUseFullCollisionPreset = false;
	}
}

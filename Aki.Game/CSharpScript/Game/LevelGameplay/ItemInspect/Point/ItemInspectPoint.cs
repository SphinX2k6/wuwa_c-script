using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02006DEE RID: 28142
	public class ItemInspectPoint
	{
		// Token: 0x04023B8E RID: 146318
		public bool IsActive;

		// Token: 0x04023B8F RID: 146319
		public bool IsValid;

		// Token: 0x04023B90 RID: 146320
		public bool IsChecked;

		// Token: 0x04023B91 RID: 146321
		public int TagId;

		// Token: 0x04023B92 RID: 146322
		public bool CancelTrace;

		// Token: 0x04023B93 RID: 146323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IInteractEffect> EffectConfigs;

		// Token: 0x04023B94 RID: 146324
		public float ProtectTime;

		// Token: 0x04023B95 RID: 146325
		[Nullable(2)]
		public IInteractPointInteraction InteractionConfig;
	}
}

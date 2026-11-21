using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02005F6D RID: 24429
	public class ItemInspectPoint
	{
		// Token: 0x0401EE30 RID: 126512
		public bool IsActive;

		// Token: 0x0401EE31 RID: 126513
		public bool IsValid;

		// Token: 0x0401EE32 RID: 126514
		public bool IsChecked;

		// Token: 0x0401EE33 RID: 126515
		public int TagId;

		// Token: 0x0401EE34 RID: 126516
		public bool CancelTrace;

		// Token: 0x0401EE35 RID: 126517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IInteractEffect> EffectConfigs;

		// Token: 0x0401EE36 RID: 126518
		public float ProtectTime;

		// Token: 0x0401EE37 RID: 126519
		[Nullable(2)]
		public IInteractPointInteraction InteractionConfig;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7D RID: 7293
	public class INpcSitDown_SetValue
	{
		// Token: 0x04005ED5 RID: 24277
		public ENpcLeisureInteract Type;

		// Token: 0x04005ED6 RID: 24278
		public bool? KeepState;

		// Token: 0x04005ED7 RID: 24279
		[Nullable(1)]
		public IMontageId MontageId;

		// Token: 0x04005ED8 RID: 24280
		public int PosEntityId;

		// Token: 0x04005ED9 RID: 24281
		public float Duration;
	}
}

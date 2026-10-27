using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1D RID: 7709
	public class ISetEntityTag_SetValue
	{
		// Token: 0x040062AD RID: 25261
		public int EntityId;

		// Token: 0x040062AE RID: 25262
		[Nullable(1)]
		public string GameplayTag;

		// Token: 0x040062AF RID: 25263
		public ESetEntityTagType SetType;

		// Token: 0x040062B0 RID: 25264
		public float? DelayTime;

		// Token: 0x040062B1 RID: 25265
		public bool? BeforeHide;
	}
}

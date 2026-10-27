using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1F RID: 7455
	public class IPlayScreenEffect_SetValue
	{
		// Token: 0x0400607A RID: 24698
		public EEffectType Type;

		// Token: 0x0400607B RID: 24699
		[Nullable(1)]
		public string Path;

		// Token: 0x0400607C RID: 24700
		public float? DestroyTime;

		// Token: 0x0400607D RID: 24701
		[Nullable(2)]
		public string BindSubScreenKey;
	}
}

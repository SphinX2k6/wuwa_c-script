using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F30 RID: 7984
	public class IPlayScreenEffect_SetValue
	{
		// Token: 0x040065F6 RID: 26102
		public EEffectType Type;

		// Token: 0x040065F7 RID: 26103
		public string Path;

		// Token: 0x040065F8 RID: 26104
		public float? DestroyTime;

		// Token: 0x040065F9 RID: 26105
		[Nullable(2)]
		public string BindSubScreenKey;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CFB RID: 7419
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayCommonEffect_SetValue
	{
		// Token: 0x04006020 RID: 24608
		public EEffectType Type;

		// Token: 0x04006021 RID: 24609
		public string Path;

		// Token: 0x04006022 RID: 24610
		public IBasePos2 Pos2;

		// Token: 0x04006023 RID: 24611
		public float? DestroyTime;

		// Token: 0x04006024 RID: 24612
		public bool? PlayEffectEnd;
	}
}

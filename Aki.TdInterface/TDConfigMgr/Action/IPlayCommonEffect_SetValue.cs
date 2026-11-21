using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F08 RID: 7944
	public class IPlayCommonEffect_SetValue
	{
		// Token: 0x04006590 RID: 26000
		public EEffectType Type;

		// Token: 0x04006591 RID: 26001
		public string Path;

		// Token: 0x04006592 RID: 26002
		public IBasePos2 Pos2;

		// Token: 0x04006593 RID: 26003
		public float? DestroyTime;

		// Token: 0x04006594 RID: 26004
		public bool? PlayEffectEnd;
	}
}

using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA0 RID: 7584
	public class ILoopSeasonChange_SetValue
	{
		// Token: 0x040061D2 RID: 25042
		public EClientSetSeasonStateType Type;

		// Token: 0x040061D3 RID: 25043
		public bool EnableLoop;

		// Token: 0x040061D4 RID: 25044
		public ISeasonLoopConfig SpringConfig;

		// Token: 0x040061D5 RID: 25045
		public ISeasonLoopConfig SummerConfig;

		// Token: 0x040061D6 RID: 25046
		public ISeasonLoopConfig AutumnConfig;

		// Token: 0x040061D7 RID: 25047
		public ISeasonLoopConfig WinterConfig;
	}
}

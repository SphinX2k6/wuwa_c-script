using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006942 RID: 26946
	public static class ControllerDefine
	{
		// Token: 0x0604326D RID: 275053 RVA: 0x0105E3DA File Offset: 0x0105C5DA
		public static bool CheckCombatDebugDrawControllerTick()
		{
			return !Info.Instance.IsBuildShipping;
		}

		// Token: 0x0604326E RID: 275054 RVA: 0x0105E3E9 File Offset: 0x0105C5E9
		public static bool CheckCrashCollectionControllerTick()
		{
			return !Info.Instance.IsBuildShipping;
		}
	}
}

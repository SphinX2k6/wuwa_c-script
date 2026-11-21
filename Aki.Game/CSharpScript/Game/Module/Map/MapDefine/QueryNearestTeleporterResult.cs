using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200455B RID: 17755
	public class QueryNearestTeleporterResult
	{
		// Token: 0x04017FD4 RID: 98260
		public int TargetMarkId;

		// Token: 0x04017FD5 RID: 98261
		public EMarkType TargetMarkType;

		// Token: 0x04017FD6 RID: 98262
		[Nullable(2)]
		public MapTeleportQueryInfo Info;

		// Token: 0x04017FD7 RID: 98263
		public EQueryNearestTeleporterFailedReason? FailedReason;
	}
}

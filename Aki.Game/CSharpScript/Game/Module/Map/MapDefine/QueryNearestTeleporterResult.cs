using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005585 RID: 21893
	public class QueryNearestTeleporterResult
	{
		// Token: 0x0401D549 RID: 120137
		public int TargetMarkId;

		// Token: 0x0401D54A RID: 120138
		public EMarkType TargetMarkType;

		// Token: 0x0401D54B RID: 120139
		[Nullable(2)]
		public MapTeleportQueryInfo Info;

		// Token: 0x0401D54C RID: 120140
		public EQueryNearestTeleporterFailedReason? FailedReason;
	}
}

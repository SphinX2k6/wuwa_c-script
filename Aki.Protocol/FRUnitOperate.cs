using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C7 RID: 5575
	public enum FRUnitOperate
	{
		// Token: 0x0400BCDE RID: 48350
		[OriginalName("UnitOpAdd")]
		UnitOpAdd,
		// Token: 0x0400BCDF RID: 48351
		[OriginalName("UnitOpRemove")]
		UnitOpRemove,
		// Token: 0x0400BCE0 RID: 48352
		[OriginalName("UnitOpUpdate")]
		UnitOpUpdate,
		// Token: 0x0400BCE1 RID: 48353
		[OriginalName("UnitReplace")]
		UnitReplace
	}
}

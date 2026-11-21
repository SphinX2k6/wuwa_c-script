using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001639 RID: 5689
	public enum FRUnitOperate
	{
		// Token: 0x0400C1D1 RID: 49617
		[OriginalName("UnitOpAdd")]
		UnitOpAdd,
		// Token: 0x0400C1D2 RID: 49618
		[OriginalName("UnitOpRemove")]
		UnitOpRemove,
		// Token: 0x0400C1D3 RID: 49619
		[OriginalName("UnitOpUpdate")]
		UnitOpUpdate,
		// Token: 0x0400C1D4 RID: 49620
		[OriginalName("UnitReplace")]
		UnitReplace
	}
}

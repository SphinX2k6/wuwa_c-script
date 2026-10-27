using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BC RID: 5564
	public enum EShieldUpdateType
	{
		// Token: 0x0400BC9B RID: 48283
		[OriginalName("EShieldUpdateTypeAdd")]
		Add,
		// Token: 0x0400BC9C RID: 48284
		[OriginalName("EShieldUpdateTypeDel")]
		Del,
		// Token: 0x0400BC9D RID: 48285
		[OriginalName("EShieldUpdateTypeModify")]
		Modify
	}
}

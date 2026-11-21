using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162E RID: 5678
	public enum EShieldUpdateType
	{
		// Token: 0x0400C18E RID: 49550
		[OriginalName("EShieldUpdateTypeAdd")]
		Add,
		// Token: 0x0400C18F RID: 49551
		[OriginalName("EShieldUpdateTypeDel")]
		Del,
		// Token: 0x0400C190 RID: 49552
		[OriginalName("EShieldUpdateTypeModify")]
		Modify
	}
}

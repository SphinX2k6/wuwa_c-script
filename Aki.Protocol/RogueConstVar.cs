using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162F RID: 5679
	public enum RogueConstVar
	{
		// Token: 0x0400C04E RID: 49230
		[OriginalName("Zero")]
		Zero,
		// Token: 0x0400C04F RID: 49231
		[OriginalName("ShopBindId")]
		ShopBindId = -1,
		// Token: 0x0400C050 RID: 49232
		[OriginalName("EventBindId")]
		EventBindId = -2,
		// Token: 0x0400C051 RID: 49233
		[OriginalName("EventRoleBuffBindId")]
		EventRoleBuffBindId = -3
	}
}

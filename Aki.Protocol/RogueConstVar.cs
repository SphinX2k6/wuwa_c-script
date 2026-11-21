using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A2 RID: 5794
	public enum RogueConstVar
	{
		// Token: 0x0400C548 RID: 50504
		[OriginalName("Zero")]
		Zero,
		// Token: 0x0400C549 RID: 50505
		[OriginalName("ShopBindId")]
		ShopBindId = -1,
		// Token: 0x0400C54A RID: 50506
		[OriginalName("EventBindId")]
		EventBindId = -2,
		// Token: 0x0400C54B RID: 50507
		[OriginalName("EventRoleBuffBindId")]
		EventRoleBuffBindId = -3
	}
}

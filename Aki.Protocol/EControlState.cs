using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200164A RID: 5706
	public enum EControlState
	{
		// Token: 0x0400C0F3 RID: 49395
		[OriginalName("EControlStateLetGo")]
		LetGo,
		// Token: 0x0400C0F4 RID: 49396
		[OriginalName("EControlStateFreeThrowing")]
		FreeThrowing,
		// Token: 0x0400C0F5 RID: 49397
		[OriginalName("EControlStateLockBaseThrowing")]
		LockBaseThrowing,
		// Token: 0x0400C0F6 RID: 49398
		[OriginalName("EControlStateLockEntityThrowing")]
		LockEntityThrowing
	}
}

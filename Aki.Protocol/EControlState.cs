using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016C0 RID: 5824
	public enum EControlState
	{
		// Token: 0x0400C5FA RID: 50682
		[OriginalName("EControlStateLetGo")]
		LetGo,
		// Token: 0x0400C5FB RID: 50683
		[OriginalName("EControlStateFreeThrowing")]
		FreeThrowing,
		// Token: 0x0400C5FC RID: 50684
		[OriginalName("EControlStateLockBaseThrowing")]
		LockBaseThrowing,
		// Token: 0x0400C5FD RID: 50685
		[OriginalName("EControlStateLockEntityThrowing")]
		LockEntityThrowing
	}
}

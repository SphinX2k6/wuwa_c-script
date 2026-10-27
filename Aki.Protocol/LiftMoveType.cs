using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158F RID: 5519
	public enum LiftMoveType
	{
		// Token: 0x0400A7AB RID: 42923
		[OriginalName("Default")]
		Default,
		// Token: 0x0400A7AC RID: 42924
		[OriginalName("Teleport")]
		Teleport,
		// Token: 0x0400A7AD RID: 42925
		[OriginalName("CustomSpeed")]
		CustomSpeed
	}
}

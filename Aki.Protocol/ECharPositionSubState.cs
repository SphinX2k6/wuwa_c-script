using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159D RID: 5533
	public enum ECharPositionSubState
	{
		// Token: 0x0400A7ED RID: 42989
		[OriginalName("None")]
		None,
		// Token: 0x0400A7EE RID: 42990
		[OriginalName("WaterSurface")]
		WaterSurface,
		// Token: 0x0400A7EF RID: 42991
		[OriginalName("WalkOnAir")]
		WalkOnAir,
		// Token: 0x0400A7F0 RID: 42992
		[OriginalName("FloatingOnAir")]
		FloatingOnAir,
		// Token: 0x0400A7F1 RID: 42993
		[OriginalName("FloatingOnGround")]
		FloatingOnGround
	}
}

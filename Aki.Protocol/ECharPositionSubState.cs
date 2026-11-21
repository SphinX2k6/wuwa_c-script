using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200160F RID: 5647
	public enum ECharPositionSubState
	{
		// Token: 0x0400AC6C RID: 44140
		[OriginalName("None")]
		None,
		// Token: 0x0400AC6D RID: 44141
		[OriginalName("WaterSurface")]
		WaterSurface,
		// Token: 0x0400AC6E RID: 44142
		[OriginalName("WalkOnAir")]
		WalkOnAir,
		// Token: 0x0400AC6F RID: 44143
		[OriginalName("FloatingOnAir")]
		FloatingOnAir,
		// Token: 0x0400AC70 RID: 44144
		[OriginalName("FloatingOnGround")]
		FloatingOnGround
	}
}

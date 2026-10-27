using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200444D RID: 17485
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/BlockoutToolsPlugin/Blueprints/Utility/EBlockoutStairsType.EBlockoutStairsType")]
	public enum EBlockoutStairsType : byte
	{
		// Token: 0x0401814D RID: 98637
		Box,
		// Token: 0x0401814E RID: 98638
		Sloped,
		// Token: 0x0401814F RID: 98639
		Closed,
		// Token: 0x04018150 RID: 98640
		EBlockoutStairsType_MAX
	}
}

using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C2 RID: 5570
	public enum DetectionType
	{
		// Token: 0x0400A9DE RID: 43486
		[OriginalName("NormalMonster")]
		NormalMonster,
		// Token: 0x0400A9DF RID: 43487
		[OriginalName("Dungeon")]
		Dungeon,
		// Token: 0x0400A9E0 RID: 43488
		[OriginalName("SilentArea")]
		SilentArea,
		// Token: 0x0400A9E1 RID: 43489
		[OriginalName("Material")]
		Material
	}
}

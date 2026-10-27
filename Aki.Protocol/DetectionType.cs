using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154C RID: 5452
	public enum DetectionType
	{
		// Token: 0x0400A580 RID: 42368
		[OriginalName("NormalMonster")]
		NormalMonster,
		// Token: 0x0400A581 RID: 42369
		[OriginalName("Dungeon")]
		Dungeon,
		// Token: 0x0400A582 RID: 42370
		[OriginalName("SilentArea")]
		SilentArea,
		// Token: 0x0400A583 RID: 42371
		[OriginalName("Material")]
		Material
	}
}

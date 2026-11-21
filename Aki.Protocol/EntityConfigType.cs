using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001605 RID: 5637
	public enum EntityConfigType
	{
		// Token: 0x0400AC3B RID: 44091
		[OriginalName("OldEntity")]
		OldEntity,
		// Token: 0x0400AC3C RID: 44092
		[OriginalName("Level")]
		Level,
		// Token: 0x0400AC3D RID: 44093
		[OriginalName("Global")]
		Global,
		// Token: 0x0400AC3E RID: 44094
		[OriginalName("Character")]
		Character,
		// Token: 0x0400AC3F RID: 44095
		[OriginalName("Template")]
		Template,
		// Token: 0x0400AC40 RID: 44096
		[OriginalName("Prefab")]
		Prefab
	}
}

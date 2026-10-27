using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001593 RID: 5523
	public enum EntityConfigType
	{
		// Token: 0x0400A7BC RID: 42940
		[OriginalName("OldEntity")]
		OldEntity,
		// Token: 0x0400A7BD RID: 42941
		[OriginalName("Level")]
		Level,
		// Token: 0x0400A7BE RID: 42942
		[OriginalName("Global")]
		Global,
		// Token: 0x0400A7BF RID: 42943
		[OriginalName("Character")]
		Character,
		// Token: 0x0400A7C0 RID: 42944
		[OriginalName("Template")]
		Template,
		// Token: 0x0400A7C1 RID: 42945
		[OriginalName("Prefab")]
		Prefab
	}
}

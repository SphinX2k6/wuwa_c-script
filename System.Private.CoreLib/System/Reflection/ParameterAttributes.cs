using System;

namespace System.Reflection
{
	// Token: 0x0200076A RID: 1898
	[Flags]
	public enum ParameterAttributes
	{
		// Token: 0x040016E7 RID: 5863
		None = 0,
		// Token: 0x040016E8 RID: 5864
		In = 1,
		// Token: 0x040016E9 RID: 5865
		Out = 2,
		// Token: 0x040016EA RID: 5866
		Lcid = 4,
		// Token: 0x040016EB RID: 5867
		Retval = 8,
		// Token: 0x040016EC RID: 5868
		Optional = 16,
		// Token: 0x040016ED RID: 5869
		HasDefault = 4096,
		// Token: 0x040016EE RID: 5870
		HasFieldMarshal = 8192,
		// Token: 0x040016EF RID: 5871
		Reserved3 = 16384,
		// Token: 0x040016F0 RID: 5872
		Reserved4 = 32768,
		// Token: 0x040016F1 RID: 5873
		ReservedMask = 61440
	}
}

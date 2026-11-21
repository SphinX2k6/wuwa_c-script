using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E4 RID: 5604
	public enum BlackboardParamType
	{
		// Token: 0x0400AB07 RID: 43783
		[OriginalName("BlackboardParamType_None")]
		None,
		// Token: 0x0400AB08 RID: 43784
		[OriginalName("BlackboardParamType_Int")]
		Int,
		// Token: 0x0400AB09 RID: 43785
		[OriginalName("BlackboardParamType_IntArray")]
		IntArray,
		// Token: 0x0400AB0A RID: 43786
		[OriginalName("BlackboardParamType_Long")]
		Long,
		// Token: 0x0400AB0B RID: 43787
		[OriginalName("BlackboardParamType_LongArray")]
		LongArray,
		// Token: 0x0400AB0C RID: 43788
		[OriginalName("BlackboardParamType_Boolean")]
		Boolean,
		// Token: 0x0400AB0D RID: 43789
		[OriginalName("BlackboardParamType_String")]
		String,
		// Token: 0x0400AB0E RID: 43790
		[OriginalName("BlackboardParamType_StringArray")]
		StringArray,
		// Token: 0x0400AB0F RID: 43791
		[OriginalName("BlackboardParamType_Float")]
		Float,
		// Token: 0x0400AB10 RID: 43792
		[OriginalName("BlackboardParamType_FloatArray")]
		FloatArray,
		// Token: 0x0400AB11 RID: 43793
		[OriginalName("BlackboardParamType_Vector")]
		Vector,
		// Token: 0x0400AB12 RID: 43794
		[OriginalName("BlackboardParamType_VectorArray")]
		VectorArray,
		// Token: 0x0400AB13 RID: 43795
		[OriginalName("BlackboardParamType_Rotator")]
		Rotator,
		// Token: 0x0400AB14 RID: 43796
		[OriginalName("BlackboardParamType_RotatorArray")]
		RotatorArray,
		// Token: 0x0400AB15 RID: 43797
		[OriginalName("BlackboardParamType_Entity")]
		Entity,
		// Token: 0x0400AB16 RID: 43798
		[OriginalName("BlackboardParamType_EntityArray")]
		EntityArray
	}
}

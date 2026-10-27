using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156E RID: 5486
	public enum BlackboardParamType
	{
		// Token: 0x0400A67A RID: 42618
		[OriginalName("BlackboardParamType_None")]
		None,
		// Token: 0x0400A67B RID: 42619
		[OriginalName("BlackboardParamType_Int")]
		Int,
		// Token: 0x0400A67C RID: 42620
		[OriginalName("BlackboardParamType_IntArray")]
		IntArray,
		// Token: 0x0400A67D RID: 42621
		[OriginalName("BlackboardParamType_Long")]
		Long,
		// Token: 0x0400A67E RID: 42622
		[OriginalName("BlackboardParamType_LongArray")]
		LongArray,
		// Token: 0x0400A67F RID: 42623
		[OriginalName("BlackboardParamType_Boolean")]
		Boolean,
		// Token: 0x0400A680 RID: 42624
		[OriginalName("BlackboardParamType_String")]
		String,
		// Token: 0x0400A681 RID: 42625
		[OriginalName("BlackboardParamType_StringArray")]
		StringArray,
		// Token: 0x0400A682 RID: 42626
		[OriginalName("BlackboardParamType_Float")]
		Float,
		// Token: 0x0400A683 RID: 42627
		[OriginalName("BlackboardParamType_FloatArray")]
		FloatArray,
		// Token: 0x0400A684 RID: 42628
		[OriginalName("BlackboardParamType_Vector")]
		Vector,
		// Token: 0x0400A685 RID: 42629
		[OriginalName("BlackboardParamType_VectorArray")]
		VectorArray,
		// Token: 0x0400A686 RID: 42630
		[OriginalName("BlackboardParamType_Rotator")]
		Rotator,
		// Token: 0x0400A687 RID: 42631
		[OriginalName("BlackboardParamType_RotatorArray")]
		RotatorArray,
		// Token: 0x0400A688 RID: 42632
		[OriginalName("BlackboardParamType_Entity")]
		Entity,
		// Token: 0x0400A689 RID: 42633
		[OriginalName("BlackboardParamType_EntityArray")]
		EntityArray
	}
}

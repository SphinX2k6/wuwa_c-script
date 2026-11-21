using System;

namespace System.Reflection
{
	// Token: 0x02000785 RID: 1925
	[Flags]
	public enum TypeAttributes
	{
		// Token: 0x0400172A RID: 5930
		VisibilityMask = 7,
		// Token: 0x0400172B RID: 5931
		NotPublic = 0,
		// Token: 0x0400172C RID: 5932
		Public = 1,
		// Token: 0x0400172D RID: 5933
		NestedPublic = 2,
		// Token: 0x0400172E RID: 5934
		NestedPrivate = 3,
		// Token: 0x0400172F RID: 5935
		NestedFamily = 4,
		// Token: 0x04001730 RID: 5936
		NestedAssembly = 5,
		// Token: 0x04001731 RID: 5937
		NestedFamANDAssem = 6,
		// Token: 0x04001732 RID: 5938
		NestedFamORAssem = 7,
		// Token: 0x04001733 RID: 5939
		LayoutMask = 24,
		// Token: 0x04001734 RID: 5940
		AutoLayout = 0,
		// Token: 0x04001735 RID: 5941
		SequentialLayout = 8,
		// Token: 0x04001736 RID: 5942
		ExplicitLayout = 16,
		// Token: 0x04001737 RID: 5943
		ClassSemanticsMask = 32,
		// Token: 0x04001738 RID: 5944
		Class = 0,
		// Token: 0x04001739 RID: 5945
		Interface = 32,
		// Token: 0x0400173A RID: 5946
		Abstract = 128,
		// Token: 0x0400173B RID: 5947
		Sealed = 256,
		// Token: 0x0400173C RID: 5948
		SpecialName = 1024,
		// Token: 0x0400173D RID: 5949
		Import = 4096,
		// Token: 0x0400173E RID: 5950
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		Serializable = 8192,
		// Token: 0x0400173F RID: 5951
		WindowsRuntime = 16384,
		// Token: 0x04001740 RID: 5952
		StringFormatMask = 196608,
		// Token: 0x04001741 RID: 5953
		AnsiClass = 0,
		// Token: 0x04001742 RID: 5954
		UnicodeClass = 65536,
		// Token: 0x04001743 RID: 5955
		AutoClass = 131072,
		// Token: 0x04001744 RID: 5956
		CustomFormatClass = 196608,
		// Token: 0x04001745 RID: 5957
		CustomFormatMask = 12582912,
		// Token: 0x04001746 RID: 5958
		BeforeFieldInit = 1048576,
		// Token: 0x04001747 RID: 5959
		RTSpecialName = 2048,
		// Token: 0x04001748 RID: 5960
		HasSecurity = 262144,
		// Token: 0x04001749 RID: 5961
		ReservedMask = 264192
	}
}

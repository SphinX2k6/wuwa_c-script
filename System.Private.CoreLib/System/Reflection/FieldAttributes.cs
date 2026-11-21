using System;

namespace System.Reflection
{
	// Token: 0x02000743 RID: 1859
	[Flags]
	public enum FieldAttributes
	{
		// Token: 0x04001657 RID: 5719
		FieldAccessMask = 7,
		// Token: 0x04001658 RID: 5720
		PrivateScope = 0,
		// Token: 0x04001659 RID: 5721
		Private = 1,
		// Token: 0x0400165A RID: 5722
		FamANDAssem = 2,
		// Token: 0x0400165B RID: 5723
		Assembly = 3,
		// Token: 0x0400165C RID: 5724
		Family = 4,
		// Token: 0x0400165D RID: 5725
		FamORAssem = 5,
		// Token: 0x0400165E RID: 5726
		Public = 6,
		// Token: 0x0400165F RID: 5727
		Static = 16,
		// Token: 0x04001660 RID: 5728
		InitOnly = 32,
		// Token: 0x04001661 RID: 5729
		Literal = 64,
		// Token: 0x04001662 RID: 5730
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		NotSerialized = 128,
		// Token: 0x04001663 RID: 5731
		SpecialName = 512,
		// Token: 0x04001664 RID: 5732
		PinvokeImpl = 8192,
		// Token: 0x04001665 RID: 5733
		RTSpecialName = 1024,
		// Token: 0x04001666 RID: 5734
		HasFieldMarshal = 4096,
		// Token: 0x04001667 RID: 5735
		HasDefault = 32768,
		// Token: 0x04001668 RID: 5736
		HasFieldRVA = 256,
		// Token: 0x04001669 RID: 5737
		ReservedMask = 38144
	}
}

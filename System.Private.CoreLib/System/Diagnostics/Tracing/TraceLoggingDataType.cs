using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000954 RID: 2388
	internal enum TraceLoggingDataType
	{
		// Token: 0x0400217E RID: 8574
		Nil,
		// Token: 0x0400217F RID: 8575
		Utf16String,
		// Token: 0x04002180 RID: 8576
		MbcsString,
		// Token: 0x04002181 RID: 8577
		Int8,
		// Token: 0x04002182 RID: 8578
		UInt8,
		// Token: 0x04002183 RID: 8579
		Int16,
		// Token: 0x04002184 RID: 8580
		UInt16,
		// Token: 0x04002185 RID: 8581
		Int32,
		// Token: 0x04002186 RID: 8582
		UInt32,
		// Token: 0x04002187 RID: 8583
		Int64,
		// Token: 0x04002188 RID: 8584
		UInt64,
		// Token: 0x04002189 RID: 8585
		Float,
		// Token: 0x0400218A RID: 8586
		Double,
		// Token: 0x0400218B RID: 8587
		Boolean32,
		// Token: 0x0400218C RID: 8588
		Binary,
		// Token: 0x0400218D RID: 8589
		Guid,
		// Token: 0x0400218E RID: 8590
		FileTime = 17,
		// Token: 0x0400218F RID: 8591
		SystemTime,
		// Token: 0x04002190 RID: 8592
		HexInt32 = 20,
		// Token: 0x04002191 RID: 8593
		HexInt64,
		// Token: 0x04002192 RID: 8594
		CountedUtf16String,
		// Token: 0x04002193 RID: 8595
		CountedMbcsString,
		// Token: 0x04002194 RID: 8596
		Struct,
		// Token: 0x04002195 RID: 8597
		Char16 = 518,
		// Token: 0x04002196 RID: 8598
		Char8 = 516,
		// Token: 0x04002197 RID: 8599
		Boolean8 = 772,
		// Token: 0x04002198 RID: 8600
		HexInt8 = 1028,
		// Token: 0x04002199 RID: 8601
		HexInt16 = 1030,
		// Token: 0x0400219A RID: 8602
		Utf16Xml = 2817,
		// Token: 0x0400219B RID: 8603
		MbcsXml,
		// Token: 0x0400219C RID: 8604
		CountedUtf16Xml = 2838,
		// Token: 0x0400219D RID: 8605
		CountedMbcsXml,
		// Token: 0x0400219E RID: 8606
		Utf16Json = 3073,
		// Token: 0x0400219F RID: 8607
		MbcsJson,
		// Token: 0x040021A0 RID: 8608
		CountedUtf16Json = 3094,
		// Token: 0x040021A1 RID: 8609
		CountedMbcsJson,
		// Token: 0x040021A2 RID: 8610
		HResult = 3847
	}
}

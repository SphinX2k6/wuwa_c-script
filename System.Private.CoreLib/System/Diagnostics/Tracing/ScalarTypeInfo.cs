using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000949 RID: 2377
	internal sealed class ScalarTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E2F RID: 36399 RVA: 0x0015ECF2 File Offset: 0x0015CEF2
		private ScalarTypeInfo(Type type, TraceLoggingDataType nativeFormat) : base(type)
		{
			this.nativeFormat = nativeFormat;
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x0015ED02 File Offset: 0x0015CF02
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddScalar(name, Statics.FormatScalar(format, this.nativeFormat));
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x0015ED17 File Offset: 0x0015CF17
		public override void WriteData(PropertyValue value)
		{
			TraceLoggingDataCollector.AddScalar(value);
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x0015ED1F File Offset: 0x0015CF1F
		public static TraceLoggingTypeInfo Boolean()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_boolean) == null)
			{
				result = (ScalarTypeInfo.s_boolean = new ScalarTypeInfo(typeof(bool), TraceLoggingDataType.Boolean8));
			}
			return result;
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x0015ED44 File Offset: 0x0015CF44
		public static TraceLoggingTypeInfo Byte()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_byte) == null)
			{
				result = (ScalarTypeInfo.s_byte = new ScalarTypeInfo(typeof(byte), TraceLoggingDataType.UInt8));
			}
			return result;
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x0015ED65 File Offset: 0x0015CF65
		public static TraceLoggingTypeInfo SByte()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_sbyte) == null)
			{
				result = (ScalarTypeInfo.s_sbyte = new ScalarTypeInfo(typeof(sbyte), TraceLoggingDataType.Int8));
			}
			return result;
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x0015ED86 File Offset: 0x0015CF86
		public static TraceLoggingTypeInfo Char()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_char) == null)
			{
				result = (ScalarTypeInfo.s_char = new ScalarTypeInfo(typeof(char), TraceLoggingDataType.Char16));
			}
			return result;
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x0015EDAB File Offset: 0x0015CFAB
		public static TraceLoggingTypeInfo Int16()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_int16) == null)
			{
				result = (ScalarTypeInfo.s_int16 = new ScalarTypeInfo(typeof(short), TraceLoggingDataType.Int16));
			}
			return result;
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x0015EDCC File Offset: 0x0015CFCC
		public static TraceLoggingTypeInfo UInt16()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_uint16) == null)
			{
				result = (ScalarTypeInfo.s_uint16 = new ScalarTypeInfo(typeof(ushort), TraceLoggingDataType.UInt16));
			}
			return result;
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x0015EDED File Offset: 0x0015CFED
		public static TraceLoggingTypeInfo Int32()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_int32) == null)
			{
				result = (ScalarTypeInfo.s_int32 = new ScalarTypeInfo(typeof(int), TraceLoggingDataType.Int32));
			}
			return result;
		}

		// Token: 0x06008E39 RID: 36409 RVA: 0x0015EE0E File Offset: 0x0015D00E
		public static TraceLoggingTypeInfo UInt32()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_uint32) == null)
			{
				result = (ScalarTypeInfo.s_uint32 = new ScalarTypeInfo(typeof(uint), TraceLoggingDataType.UInt32));
			}
			return result;
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x0015EE2F File Offset: 0x0015D02F
		public static TraceLoggingTypeInfo Int64()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_int64) == null)
			{
				result = (ScalarTypeInfo.s_int64 = new ScalarTypeInfo(typeof(long), TraceLoggingDataType.Int64));
			}
			return result;
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x0015EE51 File Offset: 0x0015D051
		public static TraceLoggingTypeInfo UInt64()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_uint64) == null)
			{
				result = (ScalarTypeInfo.s_uint64 = new ScalarTypeInfo(typeof(ulong), TraceLoggingDataType.UInt64));
			}
			return result;
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x0015EE73 File Offset: 0x0015D073
		public static TraceLoggingTypeInfo IntPtr()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_intptr) == null)
			{
				result = (ScalarTypeInfo.s_intptr = new ScalarTypeInfo(typeof(IntPtr), Statics.IntPtrType));
			}
			return result;
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x0015EE98 File Offset: 0x0015D098
		public static TraceLoggingTypeInfo UIntPtr()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_uintptr) == null)
			{
				result = (ScalarTypeInfo.s_uintptr = new ScalarTypeInfo(typeof(UIntPtr), Statics.UIntPtrType));
			}
			return result;
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x0015EEBD File Offset: 0x0015D0BD
		public static TraceLoggingTypeInfo Single()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_single) == null)
			{
				result = (ScalarTypeInfo.s_single = new ScalarTypeInfo(typeof(float), TraceLoggingDataType.Float));
			}
			return result;
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x0015EEDF File Offset: 0x0015D0DF
		public static TraceLoggingTypeInfo Double()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_double) == null)
			{
				result = (ScalarTypeInfo.s_double = new ScalarTypeInfo(typeof(double), TraceLoggingDataType.Double));
			}
			return result;
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x0015EF01 File Offset: 0x0015D101
		public static TraceLoggingTypeInfo Guid()
		{
			ScalarTypeInfo result;
			if ((result = ScalarTypeInfo.s_guid) == null)
			{
				result = (ScalarTypeInfo.s_guid = new ScalarTypeInfo(typeof(Guid), TraceLoggingDataType.Guid));
			}
			return result;
		}

		// Token: 0x04002152 RID: 8530
		private static ScalarTypeInfo s_boolean;

		// Token: 0x04002153 RID: 8531
		private static ScalarTypeInfo s_byte;

		// Token: 0x04002154 RID: 8532
		private static ScalarTypeInfo s_sbyte;

		// Token: 0x04002155 RID: 8533
		private static ScalarTypeInfo s_char;

		// Token: 0x04002156 RID: 8534
		private static ScalarTypeInfo s_int16;

		// Token: 0x04002157 RID: 8535
		private static ScalarTypeInfo s_uint16;

		// Token: 0x04002158 RID: 8536
		private static ScalarTypeInfo s_int32;

		// Token: 0x04002159 RID: 8537
		private static ScalarTypeInfo s_uint32;

		// Token: 0x0400215A RID: 8538
		private static ScalarTypeInfo s_int64;

		// Token: 0x0400215B RID: 8539
		private static ScalarTypeInfo s_uint64;

		// Token: 0x0400215C RID: 8540
		private static ScalarTypeInfo s_intptr;

		// Token: 0x0400215D RID: 8541
		private static ScalarTypeInfo s_uintptr;

		// Token: 0x0400215E RID: 8542
		private static ScalarTypeInfo s_single;

		// Token: 0x0400215F RID: 8543
		private static ScalarTypeInfo s_double;

		// Token: 0x04002160 RID: 8544
		private static ScalarTypeInfo s_guid;

		// Token: 0x04002161 RID: 8545
		private readonly TraceLoggingDataType nativeFormat;
	}
}

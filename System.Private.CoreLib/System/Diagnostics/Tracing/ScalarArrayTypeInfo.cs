using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094A RID: 2378
	internal sealed class ScalarArrayTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E41 RID: 36417 RVA: 0x0015EF23 File Offset: 0x0015D123
		private ScalarArrayTypeInfo(Type type, TraceLoggingDataType nativeFormat, int elementSize) : base(type)
		{
			this.nativeFormat = nativeFormat;
			this.elementSize = elementSize;
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x0015EF3A File Offset: 0x0015D13A
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddArray(name, Statics.FormatScalar(format, this.nativeFormat));
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x0015EF4F File Offset: 0x0015D14F
		public override void WriteData(PropertyValue value)
		{
			TraceLoggingDataCollector.AddArray(value, this.elementSize);
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x0015EF5D File Offset: 0x0015D15D
		public static TraceLoggingTypeInfo Boolean()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_boolean) == null)
			{
				result = (ScalarArrayTypeInfo.s_boolean = new ScalarArrayTypeInfo(typeof(bool[]), TraceLoggingDataType.Boolean8, 1));
			}
			return result;
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x0015EF83 File Offset: 0x0015D183
		public static TraceLoggingTypeInfo Byte()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_byte) == null)
			{
				result = (ScalarArrayTypeInfo.s_byte = new ScalarArrayTypeInfo(typeof(byte[]), TraceLoggingDataType.UInt8, 1));
			}
			return result;
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x0015EFA5 File Offset: 0x0015D1A5
		public static TraceLoggingTypeInfo SByte()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_sbyte) == null)
			{
				result = (ScalarArrayTypeInfo.s_sbyte = new ScalarArrayTypeInfo(typeof(sbyte[]), TraceLoggingDataType.Int8, 1));
			}
			return result;
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x0015EFC7 File Offset: 0x0015D1C7
		public static TraceLoggingTypeInfo Char()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_char) == null)
			{
				result = (ScalarArrayTypeInfo.s_char = new ScalarArrayTypeInfo(typeof(char[]), TraceLoggingDataType.Char16, 2));
			}
			return result;
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x0015EFED File Offset: 0x0015D1ED
		public static TraceLoggingTypeInfo Int16()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_int16) == null)
			{
				result = (ScalarArrayTypeInfo.s_int16 = new ScalarArrayTypeInfo(typeof(short[]), TraceLoggingDataType.Int16, 2));
			}
			return result;
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x0015F00F File Offset: 0x0015D20F
		public static TraceLoggingTypeInfo UInt16()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_uint16) == null)
			{
				result = (ScalarArrayTypeInfo.s_uint16 = new ScalarArrayTypeInfo(typeof(ushort[]), TraceLoggingDataType.UInt16, 2));
			}
			return result;
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x0015F031 File Offset: 0x0015D231
		public static TraceLoggingTypeInfo Int32()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_int32) == null)
			{
				result = (ScalarArrayTypeInfo.s_int32 = new ScalarArrayTypeInfo(typeof(int[]), TraceLoggingDataType.Int32, 4));
			}
			return result;
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x0015F053 File Offset: 0x0015D253
		public static TraceLoggingTypeInfo UInt32()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_uint32) == null)
			{
				result = (ScalarArrayTypeInfo.s_uint32 = new ScalarArrayTypeInfo(typeof(uint[]), TraceLoggingDataType.UInt32, 4));
			}
			return result;
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x0015F075 File Offset: 0x0015D275
		public static TraceLoggingTypeInfo Int64()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_int64) == null)
			{
				result = (ScalarArrayTypeInfo.s_int64 = new ScalarArrayTypeInfo(typeof(long[]), TraceLoggingDataType.Int64, 8));
			}
			return result;
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x0015F098 File Offset: 0x0015D298
		public static TraceLoggingTypeInfo UInt64()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_uint64) == null)
			{
				result = (ScalarArrayTypeInfo.s_uint64 = new ScalarArrayTypeInfo(typeof(ulong[]), TraceLoggingDataType.UInt64, 8));
			}
			return result;
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x0015F0BB File Offset: 0x0015D2BB
		public static TraceLoggingTypeInfo IntPtr()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_intptr) == null)
			{
				result = (ScalarArrayTypeInfo.s_intptr = new ScalarArrayTypeInfo(typeof(IntPtr[]), Statics.IntPtrType, 8));
			}
			return result;
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x0015F0E5 File Offset: 0x0015D2E5
		public static TraceLoggingTypeInfo UIntPtr()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_uintptr) == null)
			{
				result = (ScalarArrayTypeInfo.s_uintptr = new ScalarArrayTypeInfo(typeof(UIntPtr[]), Statics.UIntPtrType, 8));
			}
			return result;
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x0015F10F File Offset: 0x0015D30F
		public static TraceLoggingTypeInfo Single()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_single) == null)
			{
				result = (ScalarArrayTypeInfo.s_single = new ScalarArrayTypeInfo(typeof(float[]), TraceLoggingDataType.Float, 4));
			}
			return result;
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x0015F132 File Offset: 0x0015D332
		public static TraceLoggingTypeInfo Double()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_double) == null)
			{
				result = (ScalarArrayTypeInfo.s_double = new ScalarArrayTypeInfo(typeof(double[]), TraceLoggingDataType.Double, 8));
			}
			return result;
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x0015F155 File Offset: 0x0015D355
		public static TraceLoggingTypeInfo Guid()
		{
			ScalarArrayTypeInfo result;
			if ((result = ScalarArrayTypeInfo.s_guid) == null)
			{
				result = (ScalarArrayTypeInfo.s_guid = new ScalarArrayTypeInfo(typeof(Guid[]), TraceLoggingDataType.Guid, sizeof(Guid)));
			}
			return result;
		}

		// Token: 0x04002162 RID: 8546
		private static ScalarArrayTypeInfo s_boolean;

		// Token: 0x04002163 RID: 8547
		private static ScalarArrayTypeInfo s_byte;

		// Token: 0x04002164 RID: 8548
		private static ScalarArrayTypeInfo s_sbyte;

		// Token: 0x04002165 RID: 8549
		private static ScalarArrayTypeInfo s_char;

		// Token: 0x04002166 RID: 8550
		private static ScalarArrayTypeInfo s_int16;

		// Token: 0x04002167 RID: 8551
		private static ScalarArrayTypeInfo s_uint16;

		// Token: 0x04002168 RID: 8552
		private static ScalarArrayTypeInfo s_int32;

		// Token: 0x04002169 RID: 8553
		private static ScalarArrayTypeInfo s_uint32;

		// Token: 0x0400216A RID: 8554
		private static ScalarArrayTypeInfo s_int64;

		// Token: 0x0400216B RID: 8555
		private static ScalarArrayTypeInfo s_uint64;

		// Token: 0x0400216C RID: 8556
		private static ScalarArrayTypeInfo s_intptr;

		// Token: 0x0400216D RID: 8557
		private static ScalarArrayTypeInfo s_uintptr;

		// Token: 0x0400216E RID: 8558
		private static ScalarArrayTypeInfo s_single;

		// Token: 0x0400216F RID: 8559
		private static ScalarArrayTypeInfo s_double;

		// Token: 0x04002170 RID: 8560
		private static ScalarArrayTypeInfo s_guid;

		// Token: 0x04002171 RID: 8561
		private readonly TraceLoggingDataType nativeFormat;

		// Token: 0x04002172 RID: 8562
		private readonly int elementSize;
	}
}

using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000953 RID: 2387
	internal static class TraceLoggingDataCollector
	{
		// Token: 0x06008E7E RID: 36478 RVA: 0x0015FD2E File Offset: 0x0015DF2E
		public static int BeginBufferedArray()
		{
			return DataCollector.ThreadInstance.BeginBufferedArray();
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x0015FD3A File Offset: 0x0015DF3A
		public static void EndBufferedArray(int bookmark, int count)
		{
			DataCollector.ThreadInstance.EndBufferedArray(bookmark, count);
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x0015FD48 File Offset: 0x0015DF48
		public unsafe static void AddScalar(PropertyValue value)
		{
			PropertyValue.Scalar scalarValue = value.ScalarValue;
			DataCollector.ThreadInstance.AddScalar((void*)(&scalarValue), value.ScalarLength);
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x0015FD71 File Offset: 0x0015DF71
		public unsafe static void AddScalar(long value)
		{
			DataCollector.ThreadInstance.AddScalar((void*)(&value), 8);
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x0015FD71 File Offset: 0x0015DF71
		public unsafe static void AddScalar(double value)
		{
			DataCollector.ThreadInstance.AddScalar((void*)(&value), 8);
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x0015FD81 File Offset: 0x0015DF81
		public unsafe static void AddScalar(bool value)
		{
			DataCollector.ThreadInstance.AddScalar((void*)(&value), 1);
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x0015FD91 File Offset: 0x0015DF91
		public static void AddNullTerminatedString(string value)
		{
			DataCollector.ThreadInstance.AddNullTerminatedString(value);
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x0015FDA0 File Offset: 0x0015DFA0
		public static void AddArray(PropertyValue value, int elementSize)
		{
			Array array = (Array)value.ReferenceValue;
			DataCollector.ThreadInstance.AddArray(array, (array == null) ? 0 : array.Length, elementSize);
		}
	}
}

using System;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000955 RID: 2389
	internal sealed class TraceLoggingEventHandleTable
	{
		// Token: 0x06008E86 RID: 36486 RVA: 0x0015FDD2 File Offset: 0x0015DFD2
		internal TraceLoggingEventHandleTable()
		{
			this.m_innerTable = new IntPtr[10];
		}

		// Token: 0x170012F9 RID: 4857
		internal IntPtr this[int eventID]
		{
			get
			{
				IntPtr result = IntPtr.Zero;
				IntPtr[] array = Volatile.Read<IntPtr[]>(ref this.m_innerTable);
				if (eventID >= 0 && eventID < array.Length)
				{
					result = array[eventID];
				}
				return result;
			}
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x0015FE18 File Offset: 0x0015E018
		internal void SetEventHandle(int eventID, IntPtr eventHandle)
		{
			if (eventID >= this.m_innerTable.Length)
			{
				int num = this.m_innerTable.Length * 2;
				if (num <= eventID)
				{
					num = eventID + 1;
				}
				IntPtr[] array = new IntPtr[num];
				Array.Copy(this.m_innerTable, array, this.m_innerTable.Length);
				Volatile.Write<IntPtr[]>(ref this.m_innerTable, array);
			}
			this.m_innerTable[eventID] = eventHandle;
		}

		// Token: 0x040021A3 RID: 8611
		private IntPtr[] m_innerTable;
	}
}

using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D7 RID: 2263
	internal readonly struct EventPipeProviderConfiguration
	{
		// Token: 0x06008B7C RID: 35708 RVA: 0x00150F0D File Offset: 0x0014F10D
		internal EventPipeProviderConfiguration(string providerName, ulong keywords, uint loggingLevel, string filterData)
		{
			ArgumentException.ThrowIfNullOrEmpty(providerName, "providerName");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<uint>(loggingLevel, 5U, "loggingLevel");
			this.m_providerName = providerName;
			this.m_keywords = keywords;
			this.m_loggingLevel = loggingLevel;
			this.m_filterData = filterData;
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06008B7D RID: 35709 RVA: 0x00150F43 File Offset: 0x0014F143
		internal string ProviderName
		{
			get
			{
				return this.m_providerName;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x00150F4B File Offset: 0x0014F14B
		internal ulong Keywords
		{
			get
			{
				return this.m_keywords;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x00150F53 File Offset: 0x0014F153
		internal uint LoggingLevel
		{
			get
			{
				return this.m_loggingLevel;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06008B80 RID: 35712 RVA: 0x00150F5B File Offset: 0x0014F15B
		internal string FilterData
		{
			get
			{
				return this.m_filterData;
			}
		}

		// Token: 0x04001F68 RID: 8040
		[MarshalAs(UnmanagedType.LPWStr)]
		private readonly string m_providerName;

		// Token: 0x04001F69 RID: 8041
		private readonly ulong m_keywords;

		// Token: 0x04001F6A RID: 8042
		private readonly uint m_loggingLevel;

		// Token: 0x04001F6B RID: 8043
		[MarshalAs(UnmanagedType.LPWStr)]
		private readonly string m_filterData;
	}
}

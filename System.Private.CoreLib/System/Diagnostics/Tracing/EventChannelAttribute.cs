using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008FB RID: 2299
	[AttributeUsage(AttributeTargets.Field)]
	internal sealed class EventChannelAttribute : Attribute
	{
		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x00159802 File Offset: 0x00157A02
		// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x0015980A File Offset: 0x00157A0A
		public bool Enabled { get; set; }

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06008CE8 RID: 36072 RVA: 0x00159813 File Offset: 0x00157A13
		// (set) Token: 0x06008CE9 RID: 36073 RVA: 0x0015981B File Offset: 0x00157A1B
		public EventChannelType EventChannelType { get; set; }
	}
}

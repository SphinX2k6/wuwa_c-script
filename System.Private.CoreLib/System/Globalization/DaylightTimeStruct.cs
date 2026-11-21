using System;

namespace System.Globalization
{
	// Token: 0x020002E6 RID: 742
	internal readonly struct DaylightTimeStruct
	{
		// Token: 0x0600369A RID: 13978 RVA: 0x000B2BB2 File Offset: 0x000B0DB2
		public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
		{
			this.Start = start;
			this.End = end;
			this.Delta = delta;
		}

		// Token: 0x04000A84 RID: 2692
		public readonly DateTime Start;

		// Token: 0x04000A85 RID: 2693
		public readonly DateTime End;

		// Token: 0x04000A86 RID: 2694
		public readonly TimeSpan Delta;
	}
}

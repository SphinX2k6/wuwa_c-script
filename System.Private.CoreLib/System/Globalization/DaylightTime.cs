using System;

namespace System.Globalization
{
	// Token: 0x020002E5 RID: 741
	public class DaylightTime
	{
		// Token: 0x06003696 RID: 13974 RVA: 0x000B2B7D File Offset: 0x000B0D7D
		public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
		{
			this._start = start;
			this._end = end;
			this._delta = delta;
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000B2B9A File Offset: 0x000B0D9A
		public DateTime Start
		{
			get
			{
				return this._start;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x000B2BA2 File Offset: 0x000B0DA2
		public DateTime End
		{
			get
			{
				return this._end;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x000B2BAA File Offset: 0x000B0DAA
		public TimeSpan Delta
		{
			get
			{
				return this._delta;
			}
		}

		// Token: 0x04000A81 RID: 2689
		private readonly DateTime _start;

		// Token: 0x04000A82 RID: 2690
		private readonly DateTime _end;

		// Token: 0x04000A83 RID: 2691
		private readonly TimeSpan _delta;
	}
}

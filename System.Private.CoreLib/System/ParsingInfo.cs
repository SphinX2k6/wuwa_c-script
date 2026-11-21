using System;
using System.Globalization;

namespace System
{
	// Token: 0x02000131 RID: 305
	internal struct ParsingInfo
	{
		// Token: 0x06001251 RID: 4689 RVA: 0x00039877 File Offset: 0x00037A77
		public ParsingInfo(Calendar calendar)
		{
			this.fUseHour12 = false;
			this.fUseTwoDigitYear = false;
			this.fAllowInnerWhite = false;
			this.fAllowTrailingWhite = false;
			this.fUseHebrewNumberParser = false;
			this.calendar = calendar;
			this.dayOfWeek = -1;
			this.timeMark = DateTimeParse.TM.NotSet;
		}

		// Token: 0x0400045E RID: 1118
		internal Calendar calendar;

		// Token: 0x0400045F RID: 1119
		internal int dayOfWeek;

		// Token: 0x04000460 RID: 1120
		internal DateTimeParse.TM timeMark;

		// Token: 0x04000461 RID: 1121
		internal bool fUseHour12;

		// Token: 0x04000462 RID: 1122
		internal bool fUseTwoDigitYear;

		// Token: 0x04000463 RID: 1123
		internal bool fAllowInnerWhite;

		// Token: 0x04000464 RID: 1124
		internal bool fAllowTrailingWhite;

		// Token: 0x04000465 RID: 1125
		internal bool fUseHebrewNumberParser;
	}
}

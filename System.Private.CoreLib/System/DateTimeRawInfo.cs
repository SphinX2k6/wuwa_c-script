using System;

namespace System
{
	// Token: 0x0200012D RID: 301
	internal struct DateTimeRawInfo
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x00039765 File Offset: 0x00037965
		internal unsafe void Init(int* numberBuffer)
		{
			this.month = -1;
			this.year = -1;
			this.dayOfWeek = -1;
			this.era = -1;
			this.timeMark = DateTimeParse.TM.NotSet;
			this.fraction = -1.0;
			this.num = numberBuffer;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000397A0 File Offset: 0x000379A0
		internal unsafe void AddNumber(int value)
		{
			ref int ptr = ref *this.num;
			int num = this.numCount;
			this.numCount = num + 1;
			*(ref ptr + (IntPtr)num * 4) = value;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000397CA File Offset: 0x000379CA
		internal unsafe int GetNumber(int index)
		{
			return this.num[index];
		}

		// Token: 0x04000421 RID: 1057
		private unsafe int* num;

		// Token: 0x04000422 RID: 1058
		internal int numCount;

		// Token: 0x04000423 RID: 1059
		internal int month;

		// Token: 0x04000424 RID: 1060
		internal int year;

		// Token: 0x04000425 RID: 1061
		internal int dayOfWeek;

		// Token: 0x04000426 RID: 1062
		internal int era;

		// Token: 0x04000427 RID: 1063
		internal DateTimeParse.TM timeMark;

		// Token: 0x04000428 RID: 1064
		internal double fraction;

		// Token: 0x04000429 RID: 1065
		internal bool hasSameDateAndTimeSeparators;
	}
}

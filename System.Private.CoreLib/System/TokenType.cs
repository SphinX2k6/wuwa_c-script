using System;

namespace System
{
	// Token: 0x02000132 RID: 306
	internal enum TokenType
	{
		// Token: 0x04000467 RID: 1127
		NumberToken = 1,
		// Token: 0x04000468 RID: 1128
		YearNumberToken,
		// Token: 0x04000469 RID: 1129
		Am,
		// Token: 0x0400046A RID: 1130
		Pm,
		// Token: 0x0400046B RID: 1131
		MonthToken,
		// Token: 0x0400046C RID: 1132
		EndOfString,
		// Token: 0x0400046D RID: 1133
		DayOfWeekToken,
		// Token: 0x0400046E RID: 1134
		TimeZoneToken,
		// Token: 0x0400046F RID: 1135
		EraToken,
		// Token: 0x04000470 RID: 1136
		DateWordToken,
		// Token: 0x04000471 RID: 1137
		UnknownToken,
		// Token: 0x04000472 RID: 1138
		HebrewNumber,
		// Token: 0x04000473 RID: 1139
		JapaneseEraToken,
		// Token: 0x04000474 RID: 1140
		TEraToken,
		// Token: 0x04000475 RID: 1141
		IgnorableSymbol,
		// Token: 0x04000476 RID: 1142
		SEP_Unk = 256,
		// Token: 0x04000477 RID: 1143
		SEP_End = 512,
		// Token: 0x04000478 RID: 1144
		SEP_Space = 768,
		// Token: 0x04000479 RID: 1145
		SEP_Am = 1024,
		// Token: 0x0400047A RID: 1146
		SEP_Pm = 1280,
		// Token: 0x0400047B RID: 1147
		SEP_Date = 1536,
		// Token: 0x0400047C RID: 1148
		SEP_Time = 1792,
		// Token: 0x0400047D RID: 1149
		SEP_YearSuff = 2048,
		// Token: 0x0400047E RID: 1150
		SEP_MonthSuff = 2304,
		// Token: 0x0400047F RID: 1151
		SEP_DaySuff = 2560,
		// Token: 0x04000480 RID: 1152
		SEP_HourSuff = 2816,
		// Token: 0x04000481 RID: 1153
		SEP_MinuteSuff = 3072,
		// Token: 0x04000482 RID: 1154
		SEP_SecondSuff = 3328,
		// Token: 0x04000483 RID: 1155
		SEP_LocalTimeMark = 3584,
		// Token: 0x04000484 RID: 1156
		SEP_DateOrOffset = 3840,
		// Token: 0x04000485 RID: 1157
		RegularTokenMask = 255,
		// Token: 0x04000486 RID: 1158
		SeparatorTokenMask = 65280
	}
}

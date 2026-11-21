using System;

namespace System
{
	// Token: 0x0200012E RID: 302
	internal enum ParseFailureKind
	{
		// Token: 0x0400042B RID: 1067
		None,
		// Token: 0x0400042C RID: 1068
		ArgumentNull_String,
		// Token: 0x0400042D RID: 1069
		Format_BadDatePattern,
		// Token: 0x0400042E RID: 1070
		Format_BadDateTime,
		// Token: 0x0400042F RID: 1071
		Format_BadDateTimeCalendar,
		// Token: 0x04000430 RID: 1072
		Format_BadDayOfWeek,
		// Token: 0x04000431 RID: 1073
		Format_BadFormatSpecifier,
		// Token: 0x04000432 RID: 1074
		Format_BadQuote,
		// Token: 0x04000433 RID: 1075
		Format_DateOutOfRange,
		// Token: 0x04000434 RID: 1076
		Format_MissingIncompleteDate,
		// Token: 0x04000435 RID: 1077
		Format_NoFormatSpecifier,
		// Token: 0x04000436 RID: 1078
		Format_OffsetOutOfRange,
		// Token: 0x04000437 RID: 1079
		Format_RepeatDateTimePattern,
		// Token: 0x04000438 RID: 1080
		Format_UnknownDateTimeWord,
		// Token: 0x04000439 RID: 1081
		Format_UTCOutOfRange,
		// Token: 0x0400043A RID: 1082
		Argument_InvalidDateStyles,
		// Token: 0x0400043B RID: 1083
		Argument_BadFormatSpecifier,
		// Token: 0x0400043C RID: 1084
		Format_BadDateOnly,
		// Token: 0x0400043D RID: 1085
		Format_BadTimeOnly,
		// Token: 0x0400043E RID: 1086
		Format_DateTimeOnlyContainsNoneDateParts
	}
}

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000130 RID: 304
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct DateTimeResult
	{
		// Token: 0x06001249 RID: 4681 RVA: 0x000397D8 File Offset: 0x000379D8
		internal void Init(ReadOnlySpan<char> originalDateTimeString)
		{
			this.failureSpanArgument = originalDateTimeString;
			this.Year = -1;
			this.Month = -1;
			this.Day = -1;
			this.fraction = -1.0;
			this.era = -1;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0003980C File Offset: 0x00037A0C
		internal void SetDate(int year, int month, int day)
		{
			this.Year = year;
			this.Month = month;
			this.Day = day;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00039823 File Offset: 0x00037A23
		internal void SetBadFormatSpecifierFailure()
		{
			this.SetBadFormatSpecifierFailure(ReadOnlySpan<char>.Empty);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00039830 File Offset: 0x00037A30
		internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier)
		{
			this.failure = ParseFailureKind.Format_BadFormatSpecifier;
			this.failureSpanArgument = failedFormatSpecifier;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00039840 File Offset: 0x00037A40
		internal void SetBadDateTimeFailure()
		{
			this.failure = ParseFailureKind.Format_BadDateTime;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00039849 File Offset: 0x00037A49
		internal void SetFailure(ParseFailureKind failure)
		{
			this.failure = failure;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00039852 File Offset: 0x00037A52
		internal void SetFailure(ParseFailureKind failure, string failureStringArgument)
		{
			this.failure = failure;
			this.failureSpanArgument = failureStringArgument;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00039867 File Offset: 0x00037A67
		internal void SetFailure(ParseFailureKind failure, int failureIntArgument)
		{
			this.failure = failure;
			this.failureIntArgument = failureIntArgument;
		}

		// Token: 0x0400044F RID: 1103
		internal int Year;

		// Token: 0x04000450 RID: 1104
		internal int Month;

		// Token: 0x04000451 RID: 1105
		internal int Day;

		// Token: 0x04000452 RID: 1106
		internal int Hour;

		// Token: 0x04000453 RID: 1107
		internal int Minute;

		// Token: 0x04000454 RID: 1108
		internal int Second;

		// Token: 0x04000455 RID: 1109
		internal double fraction;

		// Token: 0x04000456 RID: 1110
		internal int era;

		// Token: 0x04000457 RID: 1111
		internal ParseFlags flags;

		// Token: 0x04000458 RID: 1112
		internal TimeSpan timeZoneOffset;

		// Token: 0x04000459 RID: 1113
		internal Calendar calendar;

		// Token: 0x0400045A RID: 1114
		internal DateTime parsedDate;

		// Token: 0x0400045B RID: 1115
		internal ParseFailureKind failure;

		// Token: 0x0400045C RID: 1116
		internal ReadOnlySpan<char> failureSpanArgument;

		// Token: 0x0400045D RID: 1117
		internal int failureIntArgument;
	}
}

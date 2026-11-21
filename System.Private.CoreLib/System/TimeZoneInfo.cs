using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using Internal.Win32;

namespace System
{
	// Token: 0x020001CA RID: 458
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0006907D File Offset: 0x0006727D
		public string Id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00069085 File Offset: 0x00067285
		public bool HasIanaId { get; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0006908D File Offset: 0x0006728D
		public string DisplayName
		{
			get
			{
				if (this._displayName == null)
				{
					Interlocked.CompareExchange<string>(ref this._displayName, null, null);
				}
				return this._displayName ?? string.Empty;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000690B4 File Offset: 0x000672B4
		public string StandardName
		{
			get
			{
				if (this._standardDisplayName == null)
				{
					Interlocked.CompareExchange<string>(ref this._standardDisplayName, null, null);
				}
				return this._standardDisplayName ?? string.Empty;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000690DB File Offset: 0x000672DB
		public string DaylightName
		{
			get
			{
				if (this._daylightDisplayName == null)
				{
					Interlocked.CompareExchange<string>(ref this._daylightDisplayName, null, null);
				}
				return this._daylightDisplayName ?? string.Empty;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00069102 File Offset: 0x00067302
		public TimeSpan BaseUtcOffset
		{
			get
			{
				return this._baseUtcOffset;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0006910A File Offset: 0x0006730A
		public bool SupportsDaylightSavingTime
		{
			get
			{
				return this._supportsDaylightSavingTime;
			}
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00069114 File Offset: 0x00067314
		public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset)
		{
			if (!this.SupportsDaylightSavingTime)
			{
				throw new ArgumentException(SR.Argument_DateTimeOffsetIsNotAmbiguous, "dateTimeOffset");
			}
			DateTime dateTime = TimeZoneInfo.ConvertTime(dateTimeOffset, this).DateTime;
			bool flag = false;
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForAmbiguousOffsets = this.GetAdjustmentRuleForAmbiguousOffsets(dateTime, out ruleIndex);
			if (adjustmentRuleForAmbiguousOffsets != null && adjustmentRuleForAmbiguousOffsets.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = this.GetDaylightTime(dateTime.Year, adjustmentRuleForAmbiguousOffsets, ruleIndex);
				flag = TimeZoneInfo.GetIsAmbiguousTime(dateTime, adjustmentRuleForAmbiguousOffsets, daylightTime);
			}
			if (!flag)
			{
				throw new ArgumentException(SR.Argument_DateTimeOffsetIsNotAmbiguous, "dateTimeOffset");
			}
			TimeSpan[] array = new TimeSpan[2];
			TimeSpan timeSpan = this._baseUtcOffset + adjustmentRuleForAmbiguousOffsets.BaseUtcOffsetDelta;
			if (adjustmentRuleForAmbiguousOffsets.DaylightDelta > TimeSpan.Zero)
			{
				array[0] = timeSpan;
				array[1] = timeSpan + adjustmentRuleForAmbiguousOffsets.DaylightDelta;
			}
			else
			{
				array[0] = timeSpan + adjustmentRuleForAmbiguousOffsets.DaylightDelta;
				array[1] = timeSpan;
			}
			return array;
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00069200 File Offset: 0x00067400
		public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime)
		{
			if (!this.SupportsDaylightSavingTime)
			{
				throw new ArgumentException(SR.Argument_DateTimeIsNotAmbiguous, "dateTime");
			}
			DateTime dateTime2;
			if (dateTime.Kind == DateTimeKind.Local)
			{
				TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
				dateTime2 = TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, this, TimeZoneInfoOptions.None, cachedData);
			}
			else if (dateTime.Kind == DateTimeKind.Utc)
			{
				TimeZoneInfo.CachedData cachedData2 = TimeZoneInfo.s_cachedData;
				dateTime2 = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.s_utcTimeZone, this, TimeZoneInfoOptions.None, cachedData2);
			}
			else
			{
				dateTime2 = dateTime;
			}
			bool flag = false;
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForAmbiguousOffsets = this.GetAdjustmentRuleForAmbiguousOffsets(dateTime2, out ruleIndex);
			if (adjustmentRuleForAmbiguousOffsets != null && adjustmentRuleForAmbiguousOffsets.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = this.GetDaylightTime(dateTime2.Year, adjustmentRuleForAmbiguousOffsets, ruleIndex);
				flag = TimeZoneInfo.GetIsAmbiguousTime(dateTime2, adjustmentRuleForAmbiguousOffsets, daylightTime);
			}
			if (!flag)
			{
				throw new ArgumentException(SR.Argument_DateTimeIsNotAmbiguous, "dateTime");
			}
			TimeSpan[] array = new TimeSpan[2];
			TimeSpan timeSpan = this._baseUtcOffset + adjustmentRuleForAmbiguousOffsets.BaseUtcOffsetDelta;
			if (adjustmentRuleForAmbiguousOffsets.DaylightDelta > TimeSpan.Zero)
			{
				array[0] = timeSpan;
				array[1] = timeSpan + adjustmentRuleForAmbiguousOffsets.DaylightDelta;
			}
			else
			{
				array[0] = timeSpan + adjustmentRuleForAmbiguousOffsets.DaylightDelta;
				array[1] = timeSpan;
			}
			return array;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00069324 File Offset: 0x00067524
		private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForAmbiguousOffsets(DateTime adjustedTime, out int? ruleIndex)
		{
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = this.GetAdjustmentRuleForTime(adjustedTime, out ruleIndex);
			if (adjustmentRuleForTime != null && adjustmentRuleForTime.NoDaylightTransitions && !adjustmentRuleForTime.HasDaylightSaving)
			{
				return this.GetPreviousAdjustmentRule(adjustmentRuleForTime, ruleIndex);
			}
			return adjustmentRuleForTime;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0006935C File Offset: 0x0006755C
		private TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			if (ruleIndex != null && 0 < ruleIndex.GetValueOrDefault() && ruleIndex.GetValueOrDefault() < this._adjustmentRules.Length)
			{
				return this._adjustmentRules[ruleIndex.GetValueOrDefault() - 1];
			}
			TimeZoneInfo.AdjustmentRule result = rule;
			for (int i = 1; i < this._adjustmentRules.Length; i++)
			{
				if (rule == this._adjustmentRules[i])
				{
					result = this._adjustmentRules[i - 1];
					break;
				}
			}
			return result;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000693CC File Offset: 0x000675CC
		public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset)
		{
			return TimeZoneInfo.GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000693DB File Offset: 0x000675DB
		public TimeSpan GetUtcOffset(DateTime dateTime)
		{
			return this.GetUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000693EC File Offset: 0x000675EC
		internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			return cachedData.Local.GetUtcOffset(dateTime, flags, cachedData);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0006940D File Offset: 0x0006760D
		internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return this.GetUtcOffset(dateTime, flags, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0006941C File Offset: 0x0006761C
		private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			if (dateTime.Kind == DateTimeKind.Local)
			{
				if (cachedData.GetCorrespondingKind(this) != DateTimeKind.Local)
				{
					return TimeZoneInfo.GetUtcOffsetFromUtc(TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, TimeZoneInfo.s_utcTimeZone, flags), this);
				}
			}
			else if (dateTime.Kind == DateTimeKind.Utc)
			{
				if (cachedData.GetCorrespondingKind(this) == DateTimeKind.Utc)
				{
					return this._baseUtcOffset;
				}
				return TimeZoneInfo.GetUtcOffsetFromUtc(dateTime, this);
			}
			return TimeZoneInfo.GetUtcOffset(dateTime, this);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00069480 File Offset: 0x00067680
		public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset)
		{
			return this._supportsDaylightSavingTime && this.IsAmbiguousTime(TimeZoneInfo.ConvertTime(dateTimeOffset, this).DateTime);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000694AC File Offset: 0x000676AC
		public bool IsAmbiguousTime(DateTime dateTime)
		{
			return this.IsAmbiguousTime(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000694B8 File Offset: 0x000676B8
		internal bool IsAmbiguousTime(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			if (!this._supportsDaylightSavingTime)
			{
				return false;
			}
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			DateTime dateTime2 = (dateTime.Kind == DateTimeKind.Local) ? TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, this, flags, cachedData) : ((dateTime.Kind == DateTimeKind.Utc) ? TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.s_utcTimeZone, this, flags, cachedData) : dateTime);
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = this.GetAdjustmentRuleForTime(dateTime2, out ruleIndex);
			if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = this.GetDaylightTime(dateTime2.Year, adjustmentRuleForTime, ruleIndex);
				return TimeZoneInfo.GetIsAmbiguousTime(dateTime2, adjustmentRuleForTime, daylightTime);
			}
			return false;
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00069540 File Offset: 0x00067740
		public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset)
		{
			bool result;
			TimeZoneInfo.GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this, out result);
			return result;
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0006955E File Offset: 0x0006775E
		public bool IsDaylightSavingTime(DateTime dateTime)
		{
			return this.IsDaylightSavingTime(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0006956D File Offset: 0x0006776D
		internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return this.IsDaylightSavingTime(dateTime, flags, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0006957C File Offset: 0x0006777C
		private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			if (!this._supportsDaylightSavingTime || this._adjustmentRules == null)
			{
				return false;
			}
			DateTime dateTime2;
			if (dateTime.Kind == DateTimeKind.Local)
			{
				dateTime2 = TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, this, flags, cachedData);
			}
			else if (dateTime.Kind == DateTimeKind.Utc)
			{
				if (cachedData.GetCorrespondingKind(this) == DateTimeKind.Utc)
				{
					return false;
				}
				bool result;
				TimeZoneInfo.GetUtcOffsetFromUtc(dateTime, this, out result);
				return result;
			}
			else
			{
				dateTime2 = dateTime;
			}
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = this.GetAdjustmentRuleForTime(dateTime2, out ruleIndex);
			if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = this.GetDaylightTime(dateTime2.Year, adjustmentRuleForTime, ruleIndex);
				return TimeZoneInfo.GetIsDaylightSavings(dateTime2, adjustmentRuleForTime, daylightTime);
			}
			return false;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0006960C File Offset: 0x0006780C
		public bool IsInvalidTime(DateTime dateTime)
		{
			bool result = false;
			if (dateTime.Kind == DateTimeKind.Unspecified || (dateTime.Kind == DateTimeKind.Local && TimeZoneInfo.s_cachedData.GetCorrespondingKind(this) == DateTimeKind.Local))
			{
				int? ruleIndex;
				TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = this.GetAdjustmentRuleForTime(dateTime, out ruleIndex);
				if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
				{
					DaylightTimeStruct daylightTime = this.GetDaylightTime(dateTime.Year, adjustmentRuleForTime, ruleIndex);
					result = TimeZoneInfo.GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime);
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0006966F File Offset: 0x0006786F
		public static void ClearCachedData()
		{
			TimeZoneInfo.s_cachedData = new TimeZoneInfo.CachedData();
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0006967B File Offset: 0x0006787B
		public static DateTimeOffset ConvertTimeBySystemTimeZoneId(DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
		{
			return TimeZoneInfo.ConvertTime(dateTimeOffset, TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId));
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00069689 File Offset: 0x00067889
		public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string destinationTimeZoneId)
		{
			return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId));
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00069698 File Offset: 0x00067898
		public static TimeZoneInfo FindSystemTimeZoneById(string id)
		{
			TimeZoneInfo result;
			Exception ex;
			switch (TimeZoneInfo.TryFindSystemTimeZoneById(id, out result, out ex))
			{
			case TimeZoneInfo.TimeZoneInfoResult.Success:
				return result;
			case TimeZoneInfo.TimeZoneInfoResult.InvalidTimeZoneException:
				throw ex;
			case TimeZoneInfo.TimeZoneInfoResult.SecurityException:
				throw new SecurityException(SR.Format(SR.Security_CannotReadFileData, id), ex);
			}
			throw new TimeZoneNotFoundException(SR.Format(SR.TimeZoneNotFound_MissingData, id), ex);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x000696F0 File Offset: 0x000678F0
		public static bool TryFindSystemTimeZoneById(string id, [Nullable(2)] [NotNullWhen(true)] out TimeZoneInfo timeZoneInfo)
		{
			Exception ex;
			return TimeZoneInfo.TryFindSystemTimeZoneById(id, out timeZoneInfo, out ex) == TimeZoneInfo.TimeZoneInfoResult.Success;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0006970C File Offset: 0x0006790C
		private static TimeZoneInfo.TimeZoneInfoResult TryFindSystemTimeZoneById(string id, out TimeZoneInfo timeZone, out Exception e)
		{
			if (string.Equals(id, "UTC", StringComparison.OrdinalIgnoreCase))
			{
				timeZone = TimeZoneInfo.Utc;
				e = null;
				return TimeZoneInfo.TimeZoneInfoResult.Success;
			}
			ArgumentNullException.ThrowIfNull(id, "id");
			if (id.Length == 0 || id.Length > 255 || id.Contains('\0'))
			{
				timeZone = null;
				e = null;
				return TimeZoneInfo.TimeZoneInfoResult.TimeZoneNotFoundException;
			}
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			TimeZoneInfo.CachedData obj = cachedData;
			TimeZoneInfo.TimeZoneInfoResult result;
			lock (obj)
			{
				result = TimeZoneInfo.TryGetTimeZone(id, out timeZone, out e, cachedData);
			}
			return result;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000697A0 File Offset: 0x000679A0
		public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId)
		{
			if (dateTime.Kind == DateTimeKind.Local && string.Equals(sourceTimeZoneId, TimeZoneInfo.Local.Id, StringComparison.OrdinalIgnoreCase))
			{
				TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
				return TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId), TimeZoneInfoOptions.None, cachedData);
			}
			if (dateTime.Kind == DateTimeKind.Utc && string.Equals(sourceTimeZoneId, TimeZoneInfo.Utc.Id, StringComparison.OrdinalIgnoreCase))
			{
				return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.s_utcTimeZone, TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId), TimeZoneInfoOptions.None, TimeZoneInfo.s_cachedData);
			}
			return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.FindSystemTimeZoneById(sourceTimeZoneId), TimeZoneInfo.FindSystemTimeZoneById(destinationTimeZoneId));
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0006982C File Offset: 0x00067A2C
		public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
		{
			ArgumentNullException.ThrowIfNull(destinationTimeZone, "destinationTimeZone");
			DateTime utcDateTime = dateTimeOffset.UtcDateTime;
			TimeSpan utcOffsetFromUtc = TimeZoneInfo.GetUtcOffsetFromUtc(utcDateTime, destinationTimeZone);
			long num = utcDateTime.Ticks + utcOffsetFromUtc.Ticks;
			if (num > DateTimeOffset.MaxValue.Ticks)
			{
				return DateTimeOffset.MaxValue;
			}
			if (num >= DateTimeOffset.MinValue.Ticks)
			{
				return new DateTimeOffset(num, utcOffsetFromUtc);
			}
			return DateTimeOffset.MinValue;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00069894 File Offset: 0x00067A94
		public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			ArgumentNullException.ThrowIfNull(destinationTimeZone, "destinationTimeZone");
			if (dateTime.Ticks == 0L)
			{
				TimeZoneInfo.ClearCachedData();
			}
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			TimeZoneInfo sourceTimeZone = (dateTime.Kind == DateTimeKind.Utc) ? TimeZoneInfo.s_utcTimeZone : cachedData.Local;
			return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, TimeZoneInfoOptions.None, cachedData);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000698E2 File Offset: 0x00067AE2
		public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
		{
			return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, TimeZoneInfoOptions.None, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000698F2 File Offset: 0x00067AF2
		internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
		{
			return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, flags, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00069904 File Offset: 0x00067B04
		private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData)
		{
			ArgumentNullException.ThrowIfNull(sourceTimeZone, "sourceTimeZone");
			ArgumentNullException.ThrowIfNull(destinationTimeZone, "destinationTimeZone");
			DateTimeKind correspondingKind = cachedData.GetCorrespondingKind(sourceTimeZone);
			if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == (TimeZoneInfoOptions)0 && dateTime.Kind != DateTimeKind.Unspecified && dateTime.Kind != correspondingKind)
			{
				throw new ArgumentException(SR.Argument_ConvertMismatch, "sourceTimeZone");
			}
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = sourceTimeZone.GetAdjustmentRuleForTime(dateTime, out ruleIndex);
			TimeSpan t = sourceTimeZone.BaseUtcOffset;
			if (adjustmentRuleForTime != null)
			{
				t += adjustmentRuleForTime.BaseUtcOffsetDelta;
				if (adjustmentRuleForTime.HasDaylightSaving)
				{
					DaylightTimeStruct daylightTime = sourceTimeZone.GetDaylightTime(dateTime.Year, adjustmentRuleForTime, ruleIndex);
					if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == (TimeZoneInfoOptions)0 && TimeZoneInfo.GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime))
					{
						throw new ArgumentException(SR.Argument_DateTimeIsInvalid, "dateTime");
					}
					bool isDaylightSavings = TimeZoneInfo.GetIsDaylightSavings(dateTime, adjustmentRuleForTime, daylightTime);
					t += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
				}
			}
			DateTimeKind correspondingKind2 = cachedData.GetCorrespondingKind(destinationTimeZone);
			if (dateTime.Kind != DateTimeKind.Unspecified && correspondingKind != DateTimeKind.Unspecified && correspondingKind == correspondingKind2)
			{
				return dateTime;
			}
			bool isAmbiguousDst;
			DateTime dateTime2 = TimeZoneInfo.ConvertUtcToTimeZone(dateTime.Ticks - t.Ticks, destinationTimeZone, out isAmbiguousDst);
			if (correspondingKind2 == DateTimeKind.Local)
			{
				return new DateTime(dateTime2.Ticks, DateTimeKind.Local, isAmbiguousDst);
			}
			return new DateTime(dateTime2.Ticks, correspondingKind2);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00069A2E File Offset: 0x00067C2E
		public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.s_utcTimeZone, destinationTimeZone, TimeZoneInfoOptions.None, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00069A44 File Offset: 0x00067C44
		public static DateTime ConvertTimeToUtc(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return dateTime;
			}
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			return TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, TimeZoneInfo.s_utcTimeZone, TimeZoneInfoOptions.None, cachedData);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00069A78 File Offset: 0x00067C78
		internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return dateTime;
			}
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			return TimeZoneInfo.ConvertTime(dateTime, cachedData.Local, TimeZoneInfo.s_utcTimeZone, flags, cachedData);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00069AAA File Offset: 0x00067CAA
		public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
		{
			return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, TimeZoneInfo.s_utcTimeZone, TimeZoneInfoOptions.None, TimeZoneInfo.s_cachedData);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00069ABE File Offset: 0x00067CBE
		[NullableContext(2)]
		public bool Equals([NotNullWhen(true)] TimeZoneInfo other)
		{
			return other != null && string.Equals(this._id, other._id, StringComparison.OrdinalIgnoreCase) && this.HasSameRules(other);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00069AE0 File Offset: 0x00067CE0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj as TimeZoneInfo);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00069AEE File Offset: 0x00067CEE
		public static TimeZoneInfo FromSerializedString(string source)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			if (source.Length == 0)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidSerializedString, source), "source");
			}
			return TimeZoneInfo.StringSerializer.GetDeserializedTimeZoneInfo(source);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00069B1F File Offset: 0x00067D1F
		public override int GetHashCode()
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(this._id);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00069B31 File Offset: 0x00067D31
		public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
		{
			return TimeZoneInfo.GetSystemTimeZones(false);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00069B3C File Offset: 0x00067D3C
		public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones(bool skipSorting)
		{
			TimeZoneInfo.CachedData cachedData = TimeZoneInfo.s_cachedData;
			TimeZoneInfo.CachedData obj = cachedData;
			lock (obj)
			{
				if ((skipSorting ? cachedData._readOnlyUnsortedSystemTimeZones : cachedData._readOnlySystemTimeZones) == null)
				{
					if (!cachedData._allSystemTimeZonesRead)
					{
						TimeZoneInfo.PopulateAllSystemTimeZones(cachedData);
						cachedData._allSystemTimeZonesRead = true;
					}
					if (cachedData._systemTimeZones != null)
					{
						TimeZoneInfo[] array = new TimeZoneInfo[cachedData._systemTimeZones.Count];
						cachedData._systemTimeZones.Values.CopyTo(array, 0);
						if (!skipSorting)
						{
							Array.Sort<TimeZoneInfo>(array, delegate(TimeZoneInfo x, TimeZoneInfo y)
							{
								int num = x.BaseUtcOffset.CompareTo(y.BaseUtcOffset);
								if (num != 0)
								{
									return num;
								}
								return string.CompareOrdinal(x.DisplayName, y.DisplayName);
							});
							cachedData._readOnlySystemTimeZones = (cachedData._readOnlyUnsortedSystemTimeZones = new ReadOnlyCollection<TimeZoneInfo>(array));
						}
						else
						{
							cachedData._readOnlyUnsortedSystemTimeZones = new ReadOnlyCollection<TimeZoneInfo>(array);
						}
					}
					else
					{
						cachedData._readOnlySystemTimeZones = (cachedData._readOnlyUnsortedSystemTimeZones = ReadOnlyCollection<TimeZoneInfo>.Empty);
					}
				}
			}
			if (!skipSorting)
			{
				return cachedData._readOnlySystemTimeZones;
			}
			return cachedData._readOnlyUnsortedSystemTimeZones;
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00069C44 File Offset: 0x00067E44
		public bool HasSameRules(TimeZoneInfo other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this._baseUtcOffset != other._baseUtcOffset || this._supportsDaylightSavingTime != other._supportsDaylightSavingTime)
			{
				return false;
			}
			TimeZoneInfo.AdjustmentRule[] adjustmentRules = this._adjustmentRules;
			TimeZoneInfo.AdjustmentRule[] adjustmentRules2 = other._adjustmentRules;
			return (adjustmentRules == null && adjustmentRules2 == null) || adjustmentRules.AsSpan<TimeZoneInfo.AdjustmentRule>().SequenceEqual(adjustmentRules2);
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00069CA6 File Offset: 0x00067EA6
		public static TimeZoneInfo Local
		{
			get
			{
				return TimeZoneInfo.s_cachedData.Local;
			}
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00069CB2 File Offset: 0x00067EB2
		public string ToSerializedString()
		{
			return TimeZoneInfo.StringSerializer.GetSerializedString(this);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00069CBA File Offset: 0x00067EBA
		public override string ToString()
		{
			return this.DisplayName;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00069CC2 File Offset: 0x00067EC2
		public static TimeZoneInfo Utc
		{
			get
			{
				return TimeZoneInfo.s_utcTimeZone;
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00069CCC File Offset: 0x00067ECC
		private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime, bool hasIanaId = false)
		{
			bool flag;
			TimeZoneInfo.ValidateTimeZoneInfo(id, baseUtcOffset, adjustmentRules, out flag);
			this._id = id;
			this._baseUtcOffset = baseUtcOffset;
			this._displayName = displayName;
			this._standardDisplayName = standardDisplayName;
			this._daylightDisplayName = (disableDaylightSavingTime ? null : daylightDisplayName);
			this._supportsDaylightSavingTime = (flag && !disableDaylightSavingTime);
			this._adjustmentRules = adjustmentRules;
			this.HasIanaId = (this._id.Equals("UTC", StringComparison.OrdinalIgnoreCase) || hasIanaId);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00069D50 File Offset: 0x00067F50
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, [Nullable(2)] string displayName, [Nullable(2)] string standardDisplayName)
		{
			string text;
			bool hasIanaId = TimeZoneInfo.TryConvertIanaIdToWindowsId(id, false, out text);
			if (standardDisplayName == null)
			{
				standardDisplayName = string.Empty;
			}
			return new TimeZoneInfo(id, baseUtcOffset, displayName ?? string.Empty, standardDisplayName, standardDisplayName, null, false, hasIanaId);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00069D87 File Offset: 0x00067F87
		[NullableContext(2)]
		[return: Nullable(1)]
		public static TimeZoneInfo CreateCustomTimeZone([Nullable(1)] string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, [Nullable(new byte[]
		{
			2,
			1
		})] TimeZoneInfo.AdjustmentRule[] adjustmentRules)
		{
			return TimeZoneInfo.CreateCustomTimeZone(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, false);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00069D98 File Offset: 0x00067F98
		[NullableContext(2)]
		[return: Nullable(1)]
		public static TimeZoneInfo CreateCustomTimeZone([Nullable(1)] string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, [Nullable(new byte[]
		{
			2,
			1
		})] TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			if (!disableDaylightSavingTime && adjustmentRules != null && adjustmentRules.Length != 0)
			{
				adjustmentRules = (TimeZoneInfo.AdjustmentRule[])adjustmentRules.Clone();
			}
			string text;
			bool hasIanaId = TimeZoneInfo.TryConvertIanaIdToWindowsId(id, false, out text);
			return new TimeZoneInfo(id, baseUtcOffset, displayName ?? string.Empty, standardDisplayName ?? string.Empty, daylightDisplayName ?? string.Empty, adjustmentRules, disableDaylightSavingTime, hasIanaId);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00069DF5 File Offset: 0x00067FF5
		public static bool TryConvertIanaIdToWindowsId(string ianaId, [Nullable(2)] [NotNullWhen(true)] out string windowsId)
		{
			return TimeZoneInfo.TryConvertIanaIdToWindowsId(ianaId, true, out windowsId);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00069DFF File Offset: 0x00067FFF
		public static bool TryConvertWindowsIdToIanaId(string windowsId, [Nullable(2)] [NotNullWhen(true)] out string ianaId)
		{
			return TimeZoneInfo.TryConvertWindowsIdToIanaId(windowsId, null, true, out ianaId);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00069E0A File Offset: 0x0006800A
		[NullableContext(2)]
		public static bool TryConvertWindowsIdToIanaId([Nullable(1)] string windowsId, string region, [NotNullWhen(true)] out string ianaId)
		{
			return TimeZoneInfo.TryConvertWindowsIdToIanaId(windowsId, region, true, out ianaId);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00069E18 File Offset: 0x00068018
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				bool flag;
				TimeZoneInfo.ValidateTimeZoneInfo(this._id, this._baseUtcOffset, this._adjustmentRules, out flag);
				if (flag != this._supportsDaylightSavingTime)
				{
					throw new SerializationException(SR.Format(SR.Serialization_CorruptField, "SupportsDaylightSavingTime"));
				}
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(SR.Serialization_InvalidData, innerException);
			}
			catch (InvalidTimeZoneException innerException2)
			{
				throw new SerializationException(SR.Serialization_InvalidData, innerException2);
			}
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00069E94 File Offset: 0x00068094
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("Id", this._id);
			info.AddValue("DisplayName", this._displayName);
			info.AddValue("StandardName", this._standardDisplayName);
			info.AddValue("DaylightName", this._daylightDisplayName);
			info.AddValue("BaseUtcOffset", this._baseUtcOffset);
			info.AddValue("AdjustmentRules", this._adjustmentRules);
			info.AddValue("SupportsDaylightSavingTime", this._supportsDaylightSavingTime);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00069F28 File Offset: 0x00068128
		private TimeZoneInfo(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._id = (string)info.GetValue("Id", typeof(string));
			this._displayName = (string)info.GetValue("DisplayName", typeof(string));
			this._standardDisplayName = (string)info.GetValue("StandardName", typeof(string));
			this._daylightDisplayName = (string)info.GetValue("DaylightName", typeof(string));
			this._baseUtcOffset = (TimeSpan)info.GetValue("BaseUtcOffset", typeof(TimeSpan));
			this._adjustmentRules = (TimeZoneInfo.AdjustmentRule[])info.GetValue("AdjustmentRules", typeof(TimeZoneInfo.AdjustmentRule[]));
			this._supportsDaylightSavingTime = (bool)info.GetValue("SupportsDaylightSavingTime", typeof(bool));
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0006A026 File Offset: 0x00068226
		private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out int? ruleIndex)
		{
			return this.GetAdjustmentRuleForTime(dateTime, false, out ruleIndex);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0006A034 File Offset: 0x00068234
		private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
		{
			if (this._adjustmentRules == null || this._adjustmentRules.Length == 0)
			{
				ruleIndex = null;
				return null;
			}
			DateTime dateOnly = dateTimeisUtc ? (dateTime + this.BaseUtcOffset).Date : dateTime.Date;
			int i = 0;
			int num = this._adjustmentRules.Length - 1;
			while (i <= num)
			{
				int num2 = i + (num - i >> 1);
				TimeZoneInfo.AdjustmentRule adjustmentRule = this._adjustmentRules[num2];
				TimeZoneInfo.AdjustmentRule previousRule = (num2 > 0) ? this._adjustmentRules[num2 - 1] : adjustmentRule;
				int num3 = this.CompareAdjustmentRuleToDateTime(adjustmentRule, previousRule, dateTime, dateOnly, dateTimeisUtc);
				if (num3 == 0)
				{
					ruleIndex = new int?(num2);
					return adjustmentRule;
				}
				if (num3 < 0)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			ruleIndex = null;
			return null;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0006A0F8 File Offset: 0x000682F8
		private int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
		{
			bool flag;
			if (rule.DateStart.Kind == DateTimeKind.Utc)
			{
				flag = ((dateTimeisUtc ? dateTime : this.ConvertToUtc(dateTime, previousRule.DaylightDelta, previousRule.BaseUtcOffsetDelta)) >= rule.DateStart);
			}
			else
			{
				flag = (dateOnly >= rule.DateStart);
			}
			if (!flag)
			{
				return 1;
			}
			bool flag2;
			if (rule.DateEnd.Kind == DateTimeKind.Utc)
			{
				flag2 = ((dateTimeisUtc ? dateTime : this.ConvertToUtc(dateTime, rule.DaylightDelta, rule.BaseUtcOffsetDelta)) <= rule.DateEnd);
			}
			else
			{
				flag2 = (dateOnly <= rule.DateEnd);
			}
			if (!flag2)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0006A19E File Offset: 0x0006839E
		private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			return this.ConvertToFromUtc(dateTime, daylightDelta, baseUtcOffsetDelta, true);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0006A1AA File Offset: 0x000683AA
		private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
		{
			return this.ConvertToFromUtc(dateTime, daylightDelta, baseUtcOffsetDelta, false);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0006A1B8 File Offset: 0x000683B8
		private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
		{
			TimeSpan timeSpan = this.BaseUtcOffset + daylightDelta + baseUtcOffsetDelta;
			if (convertToUtc)
			{
				timeSpan = timeSpan.Negate();
			}
			long num = dateTime.Ticks + timeSpan.Ticks;
			if (num > DateTime.MaxValue.Ticks)
			{
				return DateTime.MaxValue;
			}
			if (num >= DateTime.MinValue.Ticks)
			{
				return new DateTime(num);
			}
			return DateTime.MinValue;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0006A220 File Offset: 0x00068420
		private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
		{
			ticks += TimeZoneInfo.GetUtcOffsetFromUtc((ticks > DateTime.MaxValue.Ticks) ? DateTime.MaxValue : ((ticks < DateTime.MinValue.Ticks) ? DateTime.MinValue : new DateTime(ticks)), destinationTimeZone, out isAmbiguousLocalDst).Ticks;
			if (ticks > DateTime.MaxValue.Ticks)
			{
				return DateTime.MaxValue;
			}
			if (ticks >= DateTime.MinValue.Ticks)
			{
				return new DateTime(ticks);
			}
			return DateTime.MinValue;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0006A29C File Offset: 0x0006849C
		private DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			TimeSpan daylightDelta = rule.DaylightDelta;
			DateTime start;
			DateTime end;
			if (rule.NoDaylightTransitions)
			{
				TimeZoneInfo.AdjustmentRule previousAdjustmentRule = this.GetPreviousAdjustmentRule(rule, ruleIndex);
				start = this.ConvertFromUtc(rule.DateStart, previousAdjustmentRule.DaylightDelta, previousAdjustmentRule.BaseUtcOffsetDelta);
				end = this.ConvertFromUtc(rule.DateEnd, rule.DaylightDelta, rule.BaseUtcOffsetDelta);
			}
			else
			{
				start = TimeZoneInfo.TransitionTimeToDateTime(year, rule.DaylightTransitionStart);
				end = TimeZoneInfo.TransitionTimeToDateTime(year, rule.DaylightTransitionEnd);
			}
			return new DaylightTimeStruct(start, end, daylightDelta);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0006A318 File Offset: 0x00068518
		private static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			if (rule == null)
			{
				return false;
			}
			DateTime startTime;
			DateTime endTime;
			if (time.Kind == DateTimeKind.Local)
			{
				startTime = (rule.IsStartDateMarkerForBeginningOfYear() ? new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) : (daylightTime.Start + daylightTime.Delta));
				endTime = (rule.IsEndDateMarkerForEndOfYear() ? new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) : daylightTime.End);
			}
			else
			{
				bool flag = rule.DaylightDelta > TimeSpan.Zero;
				startTime = (rule.IsStartDateMarkerForBeginningOfYear() ? new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) : (daylightTime.Start + (flag ? rule.DaylightDelta : TimeSpan.Zero)));
				endTime = (rule.IsEndDateMarkerForEndOfYear() ? new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) : (daylightTime.End + (flag ? (-rule.DaylightDelta) : TimeSpan.Zero)));
			}
			bool flag2 = TimeZoneInfo.CheckIsDst(startTime, time, endTime, false, rule);
			if (flag2 && time.Kind == DateTimeKind.Local && TimeZoneInfo.GetIsAmbiguousTime(time, rule, daylightTime))
			{
				flag2 = time.IsAmbiguousDaylightSavingTime();
			}
			return flag2;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0006A468 File Offset: 0x00068668
		private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			if (rule.NoDaylightTransitions)
			{
				TimeZoneInfo.AdjustmentRule previousAdjustmentRule = this.GetPreviousAdjustmentRule(rule, ruleIndex);
				return baseUtcOffset + previousAdjustmentRule.BaseUtcOffsetDelta + previousAdjustmentRule.DaylightDelta;
			}
			return baseUtcOffset + rule.BaseUtcOffsetDelta;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0006A4AA File Offset: 0x000686AA
		private static TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule)
		{
			return baseUtcOffset + rule.BaseUtcOffsetDelta + rule.DaylightDelta;
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0006A4C4 File Offset: 0x000686C4
		private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
		{
			isAmbiguousLocalDst = false;
			if (rule == null)
			{
				return false;
			}
			DaylightTimeStruct daylightTime = zone.GetDaylightTime(year, rule, ruleIndex);
			bool ignoreYearAdjustment = false;
			TimeSpan daylightSavingsStartOffsetFromUtc = zone.GetDaylightSavingsStartOffsetFromUtc(utc, rule, ruleIndex);
			DateTime dateTime;
			if (rule.IsStartDateMarkerForBeginningOfYear() && daylightTime.Start.Year > DateTime.MinValue.Year)
			{
				if (TimeZoneInfo.TryGetStartOfDstIfYearEndWithDst(daylightTime.Start.Year - 1, utc, zone, out dateTime))
				{
					ignoreYearAdjustment = true;
				}
				else
				{
					dateTime = new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) - daylightSavingsStartOffsetFromUtc;
				}
			}
			else
			{
				dateTime = daylightTime.Start - daylightSavingsStartOffsetFromUtc;
			}
			TimeSpan daylightSavingsEndOffsetFromUtc = TimeZoneInfo.GetDaylightSavingsEndOffsetFromUtc(utc, rule);
			DateTime dateTime2;
			if (rule.IsEndDateMarkerForEndOfYear() && daylightTime.End.Year < DateTime.MaxValue.Year)
			{
				if (TimeZoneInfo.TryGetEndOfDstIfYearStartWithDst(daylightTime.End.Year + 1, utc, zone, out dateTime2))
				{
					ignoreYearAdjustment = true;
				}
				else
				{
					dateTime2 = new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) - daylightSavingsEndOffsetFromUtc;
				}
			}
			else
			{
				dateTime2 = daylightTime.End - daylightSavingsEndOffsetFromUtc;
			}
			DateTime t;
			DateTime t2;
			if (daylightTime.Delta.Ticks > 0L)
			{
				t = dateTime2 - daylightTime.Delta;
				t2 = dateTime2;
			}
			else
			{
				t = dateTime;
				t2 = dateTime - daylightTime.Delta;
			}
			bool flag = TimeZoneInfo.CheckIsDst(dateTime, time, dateTime2, ignoreYearAdjustment, rule);
			if (flag)
			{
				isAmbiguousLocalDst = (time >= t && time < t2);
				if (!isAmbiguousLocalDst && t.Year != t2.Year)
				{
					try
					{
						DateTime t3 = t.AddYears(1);
						DateTime t4 = t2.AddYears(1);
						isAmbiguousLocalDst = (time >= t3 && time < t4);
					}
					catch (ArgumentOutOfRangeException)
					{
					}
					if (!isAmbiguousLocalDst)
					{
						try
						{
							DateTime t3 = t.AddYears(-1);
							DateTime t4 = t2.AddYears(-1);
							isAmbiguousLocalDst = (time >= t3 && time < t4);
						}
						catch (ArgumentOutOfRangeException)
						{
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x0006A6E0 File Offset: 0x000688E0
		private static bool TryGetEndOfDstIfYearStartWithDst(int nextYear, TimeSpan utc, TimeZoneInfo zone, out DateTime dstEnd)
		{
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(new DateTime(nextYear, 1, 1), out ruleIndex);
			if (adjustmentRuleForTime == null)
			{
				dstEnd = default(DateTime);
				return false;
			}
			DaylightTimeStruct daylightTime;
			if (adjustmentRuleForTime.IsStartDateMarkerForBeginningOfYear())
			{
				if (adjustmentRuleForTime.IsEndDateMarkerForEndOfYear())
				{
					dstEnd = new DateTime(nextYear, 12, 31) - utc - adjustmentRuleForTime.BaseUtcOffsetDelta - adjustmentRuleForTime.DaylightDelta;
				}
				else
				{
					daylightTime = zone.GetDaylightTime(nextYear, adjustmentRuleForTime, ruleIndex);
					dstEnd = daylightTime.End - utc - adjustmentRuleForTime.BaseUtcOffsetDelta - adjustmentRuleForTime.DaylightDelta;
				}
				return true;
			}
			daylightTime = zone.GetDaylightTime(nextYear, adjustmentRuleForTime, ruleIndex);
			if (daylightTime.End < daylightTime.Start && !adjustmentRuleForTime.IsEndDateMarkerForEndOfYear())
			{
				dstEnd = daylightTime.End - utc - adjustmentRuleForTime.BaseUtcOffsetDelta - adjustmentRuleForTime.DaylightDelta;
				return true;
			}
			dstEnd = default(DateTime);
			return false;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0006A7D4 File Offset: 0x000689D4
		private static bool TryGetStartOfDstIfYearEndWithDst(int previousYear, TimeSpan utc, TimeZoneInfo zone, out DateTime dstStart)
		{
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(new DateTime(previousYear, 12, 31), out ruleIndex);
			if (adjustmentRuleForTime == null)
			{
				dstStart = default(DateTime);
				return false;
			}
			DaylightTimeStruct daylightTime = zone.GetDaylightTime(previousYear, adjustmentRuleForTime, ruleIndex);
			if (adjustmentRuleForTime.IsEndDateMarkerForEndOfYear() || daylightTime.Start > daylightTime.End)
			{
				dstStart = daylightTime.Start - utc - adjustmentRuleForTime.BaseUtcOffsetDelta;
				return true;
			}
			dstStart = default(DateTime);
			return false;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0006A84C File Offset: 0x00068A4C
		private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule)
		{
			if (!ignoreYearAdjustment && !rule.NoDaylightTransitions)
			{
				int year = startTime.Year;
				int year2 = endTime.Year;
				if (year != year2)
				{
					endTime = endTime.AddYears(year - year2);
				}
				int year3 = time.Year;
				if (year != year3)
				{
					time = time.AddYears(year - year3);
				}
			}
			if (startTime > endTime)
			{
				return time < endTime || time >= startTime;
			}
			if (rule.NoDaylightTransitions)
			{
				return time >= startTime && time <= endTime;
			}
			return time >= startTime && time < endTime;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		private static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			bool flag = false;
			if (rule == null || rule.DaylightDelta == TimeSpan.Zero)
			{
				return flag;
			}
			DateTime t;
			DateTime t2;
			if (rule.DaylightDelta > TimeSpan.Zero)
			{
				if (rule.IsEndDateMarkerForEndOfYear())
				{
					return false;
				}
				t = daylightTime.End;
				t2 = daylightTime.End - rule.DaylightDelta;
			}
			else
			{
				if (rule.IsStartDateMarkerForBeginningOfYear())
				{
					return false;
				}
				t = daylightTime.Start;
				t2 = daylightTime.Start + rule.DaylightDelta;
			}
			flag = (time >= t2 && time < t);
			if (!flag && t.Year != t2.Year)
			{
				try
				{
					DateTime t3 = t.AddYears(1);
					DateTime t4 = t2.AddYears(1);
					flag = (time >= t4 && time < t3);
				}
				catch (ArgumentOutOfRangeException)
				{
				}
				if (!flag)
				{
					try
					{
						DateTime t3 = t.AddYears(-1);
						DateTime t4 = t2.AddYears(-1);
						flag = (time >= t4 && time < t3);
					}
					catch (ArgumentOutOfRangeException)
					{
					}
				}
			}
			return flag;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0006AA0C File Offset: 0x00068C0C
		private static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			bool flag = false;
			if (rule == null || rule.DaylightDelta == TimeSpan.Zero)
			{
				return flag;
			}
			DateTime t;
			DateTime t2;
			if (rule.DaylightDelta < TimeSpan.Zero)
			{
				if (rule.IsEndDateMarkerForEndOfYear())
				{
					return false;
				}
				t = daylightTime.End;
				t2 = daylightTime.End - rule.DaylightDelta;
			}
			else
			{
				if (rule.IsStartDateMarkerForBeginningOfYear())
				{
					return false;
				}
				t = daylightTime.Start;
				t2 = daylightTime.Start + rule.DaylightDelta;
			}
			flag = (time >= t && time < t2);
			if (!flag && t.Year != t2.Year)
			{
				try
				{
					DateTime t3 = t.AddYears(1);
					DateTime t4 = t2.AddYears(1);
					flag = (time >= t3 && time < t4);
				}
				catch (ArgumentOutOfRangeException)
				{
				}
				if (!flag)
				{
					try
					{
						DateTime t3 = t.AddYears(-1);
						DateTime t4 = t2.AddYears(-1);
						flag = (time >= t3 && time < t4);
					}
					catch (ArgumentOutOfRangeException)
					{
					}
				}
			}
			return flag;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0006AB30 File Offset: 0x00068D30
		private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone)
		{
			TimeSpan timeSpan = zone.BaseUtcOffset;
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(time, out ruleIndex);
			if (adjustmentRuleForTime != null)
			{
				timeSpan += adjustmentRuleForTime.BaseUtcOffsetDelta;
				if (adjustmentRuleForTime.HasDaylightSaving)
				{
					DaylightTimeStruct daylightTime = zone.GetDaylightTime(time.Year, adjustmentRuleForTime, ruleIndex);
					bool isDaylightSavings = TimeZoneInfo.GetIsDaylightSavings(time, adjustmentRuleForTime, daylightTime);
					timeSpan += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
				}
			}
			return timeSpan;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0006AB9C File Offset: 0x00068D9C
		private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
		{
			bool flag;
			return TimeZoneInfo.GetUtcOffsetFromUtc(time, zone, out flag);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
		{
			bool flag;
			return TimeZoneInfo.GetUtcOffsetFromUtc(time, zone, out isDaylightSavings, out flag);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0006ABCC File Offset: 0x00068DCC
		internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			isDaylightSavings = false;
			isAmbiguousLocalDst = false;
			TimeSpan timeSpan = zone.BaseUtcOffset;
			int? ruleIndex;
			TimeZoneInfo.AdjustmentRule adjustmentRuleForTime;
			int year;
			if (time > TimeZoneInfo.s_maxDateOnly)
			{
				adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MaxValue, out ruleIndex);
				year = 9999;
			}
			else if (time < TimeZoneInfo.s_minDateOnly)
			{
				adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MinValue, out ruleIndex);
				year = 1;
			}
			else
			{
				adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(time, true, out ruleIndex);
				year = (time + timeSpan).Year;
			}
			if (adjustmentRuleForTime != null)
			{
				timeSpan += adjustmentRuleForTime.BaseUtcOffsetDelta;
				if (adjustmentRuleForTime.HasDaylightSaving)
				{
					isDaylightSavings = TimeZoneInfo.GetIsDaylightSavingsFromUtc(time, year, zone._baseUtcOffset, adjustmentRuleForTime, ruleIndex, out isAmbiguousLocalDst, zone);
					timeSpan += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
				}
			}
			return timeSpan;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0006AC88 File Offset: 0x00068E88
		internal static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime)
		{
			TimeSpan timeOfDay = transitionTime.TimeOfDay.TimeOfDay;
			DateTime result;
			if (transitionTime.IsFixedDateRule)
			{
				int num = transitionTime.Day;
				if (num > 28)
				{
					int num2 = DateTime.DaysInMonth(year, transitionTime.Month);
					if (num > num2)
					{
						num = num2;
					}
				}
				result = new DateTime(year, transitionTime.Month, num) + timeOfDay;
			}
			else if (transitionTime.Week <= 4)
			{
				result = new DateTime(year, transitionTime.Month, 1) + timeOfDay;
				int dayOfWeek = (int)result.DayOfWeek;
				int num3 = transitionTime.DayOfWeek - (DayOfWeek)dayOfWeek;
				if (num3 < 0)
				{
					num3 += 7;
				}
				num3 += 7 * (transitionTime.Week - 1);
				if (num3 > 0)
				{
					result = result.AddDays((double)num3);
				}
			}
			else
			{
				int day = DateTime.DaysInMonth(year, transitionTime.Month);
				result = new DateTime(year, transitionTime.Month, day) + timeOfDay;
				int num4 = result.DayOfWeek - transitionTime.DayOfWeek;
				if (num4 < 0)
				{
					num4 += 7;
				}
				if (num4 > 0)
				{
					result = result.AddDays((double)(-(double)num4));
				}
			}
			return result;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0006ADA0 File Offset: 0x00068FA0
		private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
		{
			TimeZoneInfo.TimeZoneInfoResult timeZoneInfoResult = TimeZoneInfo.TryGetTimeZoneUsingId(id, dstDisabled, out value, out e, cachedData, alwaysFallbackToLocalMachine);
			if (timeZoneInfoResult != TimeZoneInfo.TimeZoneInfoResult.Success)
			{
				bool hasIanaId;
				string alternativeId = TimeZoneInfo.GetAlternativeId(id, out hasIanaId);
				if (alternativeId != null)
				{
					timeZoneInfoResult = TimeZoneInfo.TryGetTimeZoneUsingId(alternativeId, dstDisabled, out value, out e, cachedData, alwaysFallbackToLocalMachine);
					if (timeZoneInfoResult == TimeZoneInfo.TimeZoneInfoResult.Success)
					{
						TimeZoneInfo timeZoneInfo = null;
						if (value._equivalentZones == null)
						{
							timeZoneInfo = new TimeZoneInfo(id, value._baseUtcOffset, value._displayName, value._standardDisplayName, value._daylightDisplayName, value._adjustmentRules, dstDisabled && value._supportsDaylightSavingTime, hasIanaId);
							value._equivalentZones = new List<TimeZoneInfo>();
							List<TimeZoneInfo> equivalentZones = value._equivalentZones;
							lock (equivalentZones)
							{
								value._equivalentZones.Add(timeZoneInfo);
								goto IL_16A;
							}
						}
						foreach (TimeZoneInfo timeZoneInfo2 in value._equivalentZones)
						{
							if (timeZoneInfo2.Id == id)
							{
								timeZoneInfo = timeZoneInfo2;
								break;
							}
						}
						if (timeZoneInfo == null)
						{
							timeZoneInfo = new TimeZoneInfo(id, value._baseUtcOffset, value._displayName, value._standardDisplayName, value._daylightDisplayName, value._adjustmentRules, dstDisabled && value._supportsDaylightSavingTime, hasIanaId);
							List<TimeZoneInfo> equivalentZones = value._equivalentZones;
							lock (equivalentZones)
							{
								value._equivalentZones.Add(timeZoneInfo);
							}
						}
						IL_16A:
						if (cachedData._timeZonesUsingAlternativeIds == null)
						{
							cachedData._timeZonesUsingAlternativeIds = new Dictionary<string, TimeZoneInfo>(StringComparer.OrdinalIgnoreCase);
						}
						cachedData._timeZonesUsingAlternativeIds[id] = timeZoneInfo;
						value = timeZoneInfo;
					}
				}
			}
			return timeZoneInfoResult;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0006AF70 File Offset: 0x00069170
		private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneUsingId(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine)
		{
			TimeZoneInfo.TimeZoneInfoResult result = TimeZoneInfo.TimeZoneInfoResult.Success;
			e = null;
			if (cachedData._systemTimeZones != null && cachedData._systemTimeZones.TryGetValue(id, out value))
			{
				if (dstDisabled && value._supportsDaylightSavingTime)
				{
					value = TimeZoneInfo.CreateCustomTimeZone(value._id, value._baseUtcOffset, value._displayName, value._standardDisplayName);
				}
				return result;
			}
			if (cachedData._timeZonesUsingAlternativeIds != null && cachedData._timeZonesUsingAlternativeIds.TryGetValue(id, out value))
			{
				if (dstDisabled && value._supportsDaylightSavingTime)
				{
					value = TimeZoneInfo.CreateCustomTimeZone(value._id, value._baseUtcOffset, value._displayName, value._standardDisplayName);
				}
				return result;
			}
			if (!cachedData._allSystemTimeZonesRead || alwaysFallbackToLocalMachine)
			{
				result = TimeZoneInfo.TryGetTimeZoneFromLocalMachine(id, dstDisabled, out value, out e, cachedData);
			}
			else
			{
				result = TimeZoneInfo.TimeZoneInfoResult.TimeZoneNotFoundException;
				value = null;
			}
			return result;
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0006B03C File Offset: 0x0006923C
		private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData)
		{
			TimeZoneInfo.TimeZoneInfoResult timeZoneInfoResult = TimeZoneInfo.TryGetTimeZoneFromLocalMachine(id, out value, out e);
			if (timeZoneInfoResult == TimeZoneInfo.TimeZoneInfoResult.Success)
			{
				if (cachedData._systemTimeZones == null)
				{
					cachedData._systemTimeZones = new Dictionary<string, TimeZoneInfo>(StringComparer.OrdinalIgnoreCase)
					{
						{
							"UTC",
							TimeZoneInfo.s_utcTimeZone
						}
					};
				}
				if (!id.Equals("UTC", StringComparison.OrdinalIgnoreCase))
				{
					cachedData._systemTimeZones.Add(id, value);
				}
				if (dstDisabled && value._supportsDaylightSavingTime)
				{
					value = TimeZoneInfo.CreateCustomTimeZone(value._id, value._baseUtcOffset, value._displayName, value._standardDisplayName);
				}
			}
			return timeZoneInfoResult;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0006B0CC File Offset: 0x000692CC
		private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
		{
			ArgumentException.ThrowIfNullOrEmpty(id, "id");
			if (TimeZoneInfo.UtcOffsetOutOfRange(baseUtcOffset))
			{
				throw new ArgumentOutOfRangeException("baseUtcOffset", SR.ArgumentOutOfRange_UtcOffset);
			}
			if (baseUtcOffset.Ticks % 600000000L != 0L)
			{
				throw new ArgumentException(SR.Argument_TimeSpanHasSeconds, "baseUtcOffset");
			}
			adjustmentRulesSupportDst = false;
			if (adjustmentRules != null && adjustmentRules.Length != 0)
			{
				adjustmentRulesSupportDst = true;
				TimeZoneInfo.AdjustmentRule adjustmentRule = null;
				for (int i = 0; i < adjustmentRules.Length; i++)
				{
					TimeZoneInfo.AdjustmentRule adjustmentRule2 = adjustmentRule;
					adjustmentRule = adjustmentRules[i];
					if (adjustmentRule == null)
					{
						throw new InvalidTimeZoneException(SR.Argument_AdjustmentRulesNoNulls);
					}
					if (!TimeZoneInfo.IsValidAdjustmentRuleOffset(baseUtcOffset, adjustmentRule))
					{
						throw new InvalidTimeZoneException(SR.ArgumentOutOfRange_UtcOffsetAndDaylightDelta);
					}
					if (adjustmentRule2 != null && adjustmentRule.DateStart <= adjustmentRule2.DateEnd)
					{
						throw new InvalidTimeZoneException(SR.Argument_AdjustmentRulesOutOfOrder);
					}
				}
			}
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0006B182 File Offset: 0x00069382
		internal static bool UtcOffsetOutOfRange(TimeSpan offset)
		{
			return offset < TimeZoneInfo.MinOffset || offset > TimeZoneInfo.MaxOffset;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0006B19E File Offset: 0x0006939E
		private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			return baseUtcOffset + adjustmentRule.BaseUtcOffsetDelta + (adjustmentRule.HasDaylightSaving ? adjustmentRule.DaylightDelta : TimeSpan.Zero);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0006B1C6 File Offset: 0x000693C6
		private static bool IsValidAdjustmentRuleOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			return !TimeZoneInfo.UtcOffsetOutOfRange(TimeZoneInfo.GetUtcOffset(baseUtcOffset, adjustmentRule));
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0006B1D8 File Offset: 0x000693D8
		private static TimeZoneInfo CreateUtcTimeZone()
		{
			string utcStandardDisplayName = TimeZoneInfo.GetUtcStandardDisplayName();
			string utcFullDisplayName = TimeZoneInfo.GetUtcFullDisplayName("UTC", utcStandardDisplayName);
			return TimeZoneInfo.CreateCustomTimeZone("UTC", TimeSpan.Zero, utcFullDisplayName, utcStandardDisplayName);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0006B208 File Offset: 0x00069408
		private unsafe static bool TryConvertIanaIdToWindowsId(string ianaId, bool allocate, out string windowsId)
		{
			if (GlobalizationMode.Invariant || GlobalizationMode.UseNls || ianaId == null || ianaId.AsSpan().ContainsAny('\\', '\n', '\r'))
			{
				windowsId = null;
				return false;
			}
			char* ptr = stackalloc char[(UIntPtr)200];
			int num = Interop.Globalization.IanaIdToWindowsId(ianaId, ptr, 100);
			if (num > 0)
			{
				windowsId = (allocate ? new string(ptr, 0, num) : null);
				return true;
			}
			windowsId = null;
			return false;
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0006B26C File Offset: 0x0006946C
		private unsafe static bool TryConvertWindowsIdToIanaId(string windowsId, string region, bool allocate, out string ianaId)
		{
			if (GlobalizationMode.Invariant || GlobalizationMode.UseNls || windowsId == null)
			{
				ianaId = null;
				return false;
			}
			if (windowsId.Equals("utc", StringComparison.OrdinalIgnoreCase))
			{
				ianaId = "Etc/UTC";
				return true;
			}
			if (windowsId.AsSpan().ContainsAny('\\', '\n', '\r'))
			{
				ianaId = null;
				return false;
			}
			IntPtr zero = IntPtr.Zero;
			if (region != null && region.Length < 11)
			{
				byte* ptr = stackalloc byte[(UIntPtr)(region.Length + 1)];
				int num = 0;
				while (num < region.Length && region[num] <= '\u007f')
				{
					ptr[num] = (char.IsAsciiLetterLower(region[num]) ? ((byte)(region[num] - 'a' + 'A')) : ((byte)region[num]));
					num++;
				}
				if (num >= region.Length)
				{
					ptr[region.Length] = 0;
					zero = new IntPtr((void*)ptr);
				}
			}
			char* ptr2 = stackalloc char[(UIntPtr)200];
			int num2 = Interop.Globalization.WindowsIdToIanaId(windowsId, zero, ptr2, 100);
			if (num2 > 0)
			{
				ianaId = (allocate ? new string(ptr2, 0, num2) : null);
				return true;
			}
			ianaId = null;
			return false;
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0006B379 File Offset: 0x00069579
		public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules()
		{
			if (this._adjustmentRules == null)
			{
				return Array.Empty<TimeZoneInfo.AdjustmentRule>();
			}
			return (TimeZoneInfo.AdjustmentRule[])this._adjustmentRules.Clone();
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0006B39C File Offset: 0x0006959C
		private static void PopulateAllSystemTimeZones(TimeZoneInfo.CachedData cachedData)
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", false))
			{
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					for (int i = 0; i < subKeyNames.Length; i++)
					{
						TimeZoneInfo timeZoneInfo;
						Exception ex;
						TimeZoneInfo.TryGetTimeZone(subKeyNames[i], false, out timeZoneInfo, out ex, cachedData, false);
					}
				}
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0006B400 File Offset: 0x00069600
		private static string GetAlternativeId(string id, out bool idIsIana)
		{
			idIsIana = true;
			string result;
			if (!TimeZoneInfo.TryConvertIanaIdToWindowsId(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0006B420 File Offset: 0x00069620
		private TimeZoneInfo(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
		{
			Interop.Kernel32.TIME_ZONE_INFORMATION time_ZONE_INFORMATION = zone;
			string standardName = time_ZONE_INFORMATION.GetStandardName();
			if (standardName.Length == 0)
			{
				this._id = "Local";
			}
			else
			{
				this._id = standardName;
			}
			this._baseUtcOffset = new TimeSpan(0, -zone.Bias, 0);
			if (!dstDisabled)
			{
				Interop.Kernel32.REG_TZI_FORMAT reg_TZI_FORMAT = new Interop.Kernel32.REG_TZI_FORMAT(ref zone);
				TimeZoneInfo.AdjustmentRule adjustmentRule = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(reg_TZI_FORMAT, DateTime.MinValue.Date, DateTime.MaxValue.Date, zone.Bias);
				if (adjustmentRule != null)
				{
					this._adjustmentRules = new TimeZoneInfo.AdjustmentRule[]
					{
						adjustmentRule
					};
				}
			}
			TimeZoneInfo.ValidateTimeZoneInfo(this._id, this._baseUtcOffset, this._adjustmentRules, out this._supportsDaylightSavingTime);
			this._displayName = standardName;
			this._standardDisplayName = standardName;
			time_ZONE_INFORMATION = zone;
			this._daylightDisplayName = time_ZONE_INFORMATION.GetDaylightName();
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0006B4F0 File Offset: 0x000696F0
		private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
		{
			Interop.Kernel32.SYSTEMTIME daylightDate = timeZone.DaylightDate;
			return daylightDate.Equals(timeZone.StandardDate);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0006B514 File Offset: 0x00069714
		private static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
		{
			if (timeZoneInformation.StandardDate.Month <= 0)
			{
				if (timeZoneInformation.Bias == defaultBaseUtcOffset)
				{
					return null;
				}
				return TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(startDate, endDate, TimeSpan.Zero, TimeZoneInfo.TransitionTime.CreateFixedDateRule(DateTime.MinValue, 1, 1), TimeZoneInfo.TransitionTime.CreateFixedDateRule(DateTime.MinValue.AddMilliseconds(1.0), 1, 1), new TimeSpan(0, defaultBaseUtcOffset - timeZoneInformation.Bias, 0), false);
			}
			else
			{
				TimeZoneInfo.TransitionTime daylightTransitionStart;
				if (!TimeZoneInfo.TransitionTimeFromTimeZoneInformation(timeZoneInformation, out daylightTransitionStart, true))
				{
					return null;
				}
				TimeZoneInfo.TransitionTime transitionTime;
				if (!TimeZoneInfo.TransitionTimeFromTimeZoneInformation(timeZoneInformation, out transitionTime, false))
				{
					return null;
				}
				if (daylightTransitionStart.Equals(transitionTime))
				{
					return null;
				}
				return TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(startDate, endDate, new TimeSpan(0, -timeZoneInformation.DaylightBias, 0), daylightTransitionStart, transitionTime, new TimeSpan(0, defaultBaseUtcOffset - timeZoneInformation.Bias, 0), false);
			}
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0006B5CC File Offset: 0x000697CC
		private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
		{
			dstDisabled = false;
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", false))
			{
				if (registryKey == null)
				{
					return null;
				}
				foreach (string text in registryKey.GetSubKeyNames())
				{
					if (TimeZoneInfo.TryCompareTimeZoneInformationToRegistry(timeZone, text, out dstDisabled))
					{
						return text;
					}
				}
			}
			return null;
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0006B640 File Offset: 0x00069840
		private static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData)
		{
			Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION time_DYNAMIC_ZONE_INFORMATION;
			if (Interop.Kernel32.GetDynamicTimeZoneInformation(out time_DYNAMIC_ZONE_INFORMATION) == 4294967295U)
			{
				return TimeZoneInfo.CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
			}
			string timeZoneKeyName = time_DYNAMIC_ZONE_INFORMATION.GetTimeZoneKeyName();
			TimeZoneInfo result;
			Exception ex;
			if (timeZoneKeyName.Length != 0 && TimeZoneInfo.TryGetTimeZone(timeZoneKeyName, time_DYNAMIC_ZONE_INFORMATION.DynamicDaylightTimeDisabled > 0, out result, out ex, cachedData, false) == TimeZoneInfo.TimeZoneInfoResult.Success)
			{
				return result;
			}
			Interop.Kernel32.TIME_ZONE_INFORMATION time_ZONE_INFORMATION = new Interop.Kernel32.TIME_ZONE_INFORMATION(ref time_DYNAMIC_ZONE_INFORMATION);
			bool dstDisabled;
			string text = TimeZoneInfo.FindIdFromTimeZoneInformation(time_ZONE_INFORMATION, out dstDisabled);
			TimeZoneInfo result2;
			if (text != null && TimeZoneInfo.TryGetTimeZone(text, dstDisabled, out result2, out ex, cachedData, false) == TimeZoneInfo.TimeZoneInfoResult.Success)
			{
				return result2;
			}
			return TimeZoneInfo.GetLocalTimeZoneFromWin32Data(time_ZONE_INFORMATION, dstDisabled);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0006B6CC File Offset: 0x000698CC
		private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
		{
			try
			{
				return new TimeZoneInfo(ref timeZoneInformation, dstDisabled);
			}
			catch (ArgumentException)
			{
			}
			catch (InvalidTimeZoneException)
			{
			}
			if (!dstDisabled)
			{
				try
				{
					return new TimeZoneInfo(ref timeZoneInformation, true);
				}
				catch (ArgumentException)
				{
				}
				catch (InvalidTimeZoneException)
				{
				}
			}
			return TimeZoneInfo.CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0006B74C File Offset: 0x0006994C
		private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, out TimeZoneInfo timeZone, out Exception e, TimeZoneInfo.CachedData cachedData)
		{
			return TimeZoneInfo.TryGetTimeZone(id, false, out timeZone, out e, cachedData, false);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0006B75C File Offset: 0x0006995C
		internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
		{
			isAmbiguousLocalDst = false;
			int year = time.Year;
			TimeZoneInfo.OffsetAndRule oneYearLocalFromUtc = TimeZoneInfo.s_cachedData.GetOneYearLocalFromUtc(year);
			TimeSpan timeSpan = oneYearLocalFromUtc.Offset;
			if (oneYearLocalFromUtc.Rule != null)
			{
				timeSpan += oneYearLocalFromUtc.Rule.BaseUtcOffsetDelta;
				if (oneYearLocalFromUtc.Rule.HasDaylightSaving)
				{
					bool isDaylightSavingsFromUtc = TimeZoneInfo.GetIsDaylightSavingsFromUtc(time, year, oneYearLocalFromUtc.Offset, oneYearLocalFromUtc.Rule, null, out isAmbiguousLocalDst, TimeZoneInfo.Local);
					timeSpan += (isDaylightSavingsFromUtc ? oneYearLocalFromUtc.Rule.DaylightDelta : TimeSpan.Zero);
				}
			}
			return timeSpan;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0006B7F0 File Offset: 0x000699F0
		private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			if (timeZoneInformation.StandardDate.Month <= 0)
			{
				transitionTime = default(TimeZoneInfo.TransitionTime);
				return false;
			}
			if (readStartDate)
			{
				if (timeZoneInformation.DaylightDate.Year == 0)
				{
					transitionTime = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, (int)timeZoneInformation.DaylightDate.Hour, (int)timeZoneInformation.DaylightDate.Minute, (int)timeZoneInformation.DaylightDate.Second, (int)timeZoneInformation.DaylightDate.Milliseconds), (int)timeZoneInformation.DaylightDate.Month, (int)timeZoneInformation.DaylightDate.Day, (DayOfWeek)timeZoneInformation.DaylightDate.DayOfWeek);
				}
				else
				{
					transitionTime = TimeZoneInfo.TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, (int)timeZoneInformation.DaylightDate.Hour, (int)timeZoneInformation.DaylightDate.Minute, (int)timeZoneInformation.DaylightDate.Second, (int)timeZoneInformation.DaylightDate.Milliseconds), (int)timeZoneInformation.DaylightDate.Month, (int)timeZoneInformation.DaylightDate.Day);
				}
			}
			else if (timeZoneInformation.StandardDate.Year == 0)
			{
				transitionTime = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, (int)timeZoneInformation.StandardDate.Hour, (int)timeZoneInformation.StandardDate.Minute, (int)timeZoneInformation.StandardDate.Second, (int)timeZoneInformation.StandardDate.Milliseconds), (int)timeZoneInformation.StandardDate.Month, (int)timeZoneInformation.StandardDate.Day, (DayOfWeek)timeZoneInformation.StandardDate.DayOfWeek);
			}
			else
			{
				transitionTime = TimeZoneInfo.TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, (int)timeZoneInformation.StandardDate.Hour, (int)timeZoneInformation.StandardDate.Minute, (int)timeZoneInformation.StandardDate.Second, (int)timeZoneInformation.StandardDate.Milliseconds), (int)timeZoneInformation.StandardDate.Month, (int)timeZoneInformation.StandardDate.Day);
			}
			return true;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0006B9B0 File Offset: 0x00069BB0
		private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out TimeZoneInfo.AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset)
		{
			rules = null;
			e = null;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones\\" + id + "\\Dynamic DST", false))
				{
					if (registryKey == null)
					{
						TimeZoneInfo.AdjustmentRule adjustmentRule = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(defaultTimeZoneInformation, DateTime.MinValue.Date, DateTime.MaxValue.Date, defaultBaseUtcOffset);
						if (adjustmentRule != null)
						{
							rules = new TimeZoneInfo.AdjustmentRule[]
							{
								adjustmentRule
							};
						}
						return true;
					}
					int num = (int)registryKey.GetValue("FirstEntry", -1);
					int num2 = (int)registryKey.GetValue("LastEntry", -1);
					if (num == -1 || num2 == -1 || num > num2)
					{
						return false;
					}
					Interop.Kernel32.REG_TZI_FORMAT reg_TZI_FORMAT;
					if (!TimeZoneInfo.TryGetTimeZoneEntryFromRegistry(registryKey, num.ToString(CultureInfo.InvariantCulture), out reg_TZI_FORMAT))
					{
						return false;
					}
					if (num == num2)
					{
						TimeZoneInfo.AdjustmentRule adjustmentRule2 = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(reg_TZI_FORMAT, DateTime.MinValue.Date, DateTime.MaxValue.Date, defaultBaseUtcOffset);
						if (adjustmentRule2 != null)
						{
							rules = new TimeZoneInfo.AdjustmentRule[]
							{
								adjustmentRule2
							};
						}
						return true;
					}
					List<TimeZoneInfo.AdjustmentRule> list = new List<TimeZoneInfo.AdjustmentRule>(1);
					TimeZoneInfo.AdjustmentRule adjustmentRule3 = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(reg_TZI_FORMAT, DateTime.MinValue.Date, new DateTime(num, 12, 31), defaultBaseUtcOffset);
					if (adjustmentRule3 != null)
					{
						list.Add(adjustmentRule3);
					}
					for (int i = num + 1; i < num2; i++)
					{
						if (!TimeZoneInfo.TryGetTimeZoneEntryFromRegistry(registryKey, i.ToString(CultureInfo.InvariantCulture), out reg_TZI_FORMAT))
						{
							return false;
						}
						TimeZoneInfo.AdjustmentRule adjustmentRule4 = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(reg_TZI_FORMAT, new DateTime(i, 1, 1), new DateTime(i, 12, 31), defaultBaseUtcOffset);
						if (adjustmentRule4 != null)
						{
							list.Add(adjustmentRule4);
						}
					}
					if (!TimeZoneInfo.TryGetTimeZoneEntryFromRegistry(registryKey, num2.ToString(CultureInfo.InvariantCulture), out reg_TZI_FORMAT))
					{
						return false;
					}
					TimeZoneInfo.AdjustmentRule adjustmentRule5 = TimeZoneInfo.CreateAdjustmentRuleFromTimeZoneInformation(reg_TZI_FORMAT, new DateTime(num2, 1, 1), DateTime.MaxValue.Date, defaultBaseUtcOffset);
					if (adjustmentRule5 != null)
					{
						list.Add(adjustmentRule5);
					}
					if (list.Count != 0)
					{
						rules = list.ToArray();
					}
				}
			}
			catch (InvalidCastException ex)
			{
				e = ex;
				return false;
			}
			catch (ArgumentOutOfRangeException ex2)
			{
				e = ex2;
				return false;
			}
			catch (ArgumentException ex3)
			{
				e = ex3;
				return false;
			}
			return true;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0006BC34 File Offset: 0x00069E34
		private unsafe static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
		{
			byte[] array = key.GetValue(name, null) as byte[];
			if (array == null || array.Length != sizeof(Interop.Kernel32.REG_TZI_FORMAT))
			{
				dtzi = default(Interop.Kernel32.REG_TZI_FORMAT);
				return false;
			}
			fixed (byte* ptr = &array[0])
			{
				byte* ptr2 = ptr;
				dtzi = *(Interop.Kernel32.REG_TZI_FORMAT*)ptr2;
			}
			return true;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0006BC84 File Offset: 0x00069E84
		private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
		{
			if (timeZone.Bias == registryTimeZoneInfo.Bias && timeZone.StandardBias == registryTimeZoneInfo.StandardBias)
			{
				Interop.Kernel32.SYSTEMTIME standardDate = timeZone.StandardDate;
				return standardDate.Equals(registryTimeZoneInfo.StandardDate);
			}
			return false;
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
		{
			dstDisabled = false;
			bool result;
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones\\" + id, false))
			{
				Interop.Kernel32.REG_TZI_FORMAT reg_TZI_FORMAT;
				if (registryKey == null)
				{
					result = false;
				}
				else if (!TimeZoneInfo.TryGetTimeZoneEntryFromRegistry(registryKey, "TZI", out reg_TZI_FORMAT))
				{
					result = false;
				}
				else if (!TimeZoneInfo.TryCompareStandardDate(timeZone, reg_TZI_FORMAT))
				{
					result = false;
				}
				else
				{
					bool flag;
					if (!dstDisabled && !TimeZoneInfo.CheckDaylightSavingTimeNotSupported(timeZone))
					{
						if (timeZone.DaylightBias == reg_TZI_FORMAT.DaylightBias)
						{
							Interop.Kernel32.SYSTEMTIME daylightDate = timeZone.DaylightDate;
							flag = daylightDate.Equals(reg_TZI_FORMAT.DaylightDate);
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = true;
					}
					bool flag2 = flag;
					if (flag2)
					{
						string a = registryKey.GetValue("Std", string.Empty) as string;
						Interop.Kernel32.TIME_ZONE_INFORMATION time_ZONE_INFORMATION = timeZone;
						flag2 = string.Equals(a, time_ZONE_INFORMATION.GetStandardName(), StringComparison.Ordinal);
					}
					result = flag2;
				}
			}
			return result;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x0006BDA0 File Offset: 0x00069FA0
		private unsafe static string GetLocalizedNameByMuiNativeResource(string resource)
		{
			if (string.IsNullOrEmpty(resource) || (GlobalizationMode.Invariant && GlobalizationMode.PredefinedCulturesOnly))
			{
				return string.Empty;
			}
			ReadOnlySpan<char> source = resource;
			Span<Range> destination = new Span<Range>(stackalloc byte[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(Range))], 3);
			destination = destination.Slice(0, source.Split(destination, ',', StringSplitOptions.None));
			if (destination.Length != 2)
			{
				return string.Empty;
			}
			Range range = *destination[1];
			int length = source.Length;
			int offset = range.Start.GetOffset(length);
			int length2 = range.End.GetOffset(length) - offset;
			int num;
			if (!int.TryParse(source.Slice(offset, length2), NumberStyles.Integer, CultureInfo.InvariantCulture, out num))
			{
				return string.Empty;
			}
			num = -num;
			CultureInfo cultureInfo = CultureInfo.CurrentUICulture;
			string systemDirectory = Environment.SystemDirectory;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			range = *destination[0];
			length2 = source.Length;
			offset = range.Start.GetOffset(length2);
			length = range.End.GetOffset(length2) - offset;
			defaultInterpolatedStringHandler.AppendFormatted(source.Slice(offset, length).TrimStart('@'));
			defaultInterpolatedStringHandler.AppendLiteral(".mui");
			string path = defaultInterpolatedStringHandler.ToStringAndClear();
			try
			{
				while (cultureInfo.Name.Length != 0)
				{
					string text = Path.Join(systemDirectory, cultureInfo.Name, path);
					if (File.Exists(text))
					{
						return TimeZoneInfo.GetLocalizedNameByNativeResource(text, num);
					}
					cultureInfo = cultureInfo.Parent;
				}
			}
			catch (ArgumentException)
			{
			}
			return string.Empty;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0006BF4C File Offset: 0x0006A14C
		private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
		{
			displayName = string.Empty;
			standardName = string.Empty;
			daylightName = string.Empty;
			string text = key.GetValue("MUI_Display", string.Empty) as string;
			string text2 = key.GetValue("MUI_Std", string.Empty) as string;
			string text3 = key.GetValue("MUI_Dlt", string.Empty) as string;
			if (!string.IsNullOrEmpty(text))
			{
				displayName = TimeZoneInfo.GetLocalizedNameByMuiNativeResource(text);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				standardName = TimeZoneInfo.GetLocalizedNameByMuiNativeResource(text2);
			}
			if (!string.IsNullOrEmpty(text3))
			{
				daylightName = TimeZoneInfo.GetLocalizedNameByMuiNativeResource(text3);
			}
			if (string.IsNullOrEmpty(displayName))
			{
				displayName = (key.GetValue("Display", string.Empty) as string);
			}
			if (string.IsNullOrEmpty(standardName))
			{
				standardName = (key.GetValue("Std", string.Empty) as string);
			}
			if (string.IsNullOrEmpty(daylightName))
			{
				daylightName = (key.GetValue("Dlt", string.Empty) as string);
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0006C040 File Offset: 0x0006A240
		private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e)
		{
			e = null;
			TimeZoneInfo.TimeZoneInfoResult result;
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones\\" + id, false))
			{
				Interop.Kernel32.REG_TZI_FORMAT reg_TZI_FORMAT;
				TimeZoneInfo.AdjustmentRule[] adjustmentRules;
				if (registryKey == null)
				{
					value = null;
					result = TimeZoneInfo.TimeZoneInfoResult.TimeZoneNotFoundException;
				}
				else if (!TimeZoneInfo.TryGetTimeZoneEntryFromRegistry(registryKey, "TZI", out reg_TZI_FORMAT))
				{
					value = null;
					result = TimeZoneInfo.TimeZoneInfoResult.InvalidTimeZoneException;
				}
				else if (!TimeZoneInfo.TryCreateAdjustmentRules(id, reg_TZI_FORMAT, out adjustmentRules, out e, reg_TZI_FORMAT.Bias))
				{
					value = null;
					result = TimeZoneInfo.TimeZoneInfoResult.InvalidTimeZoneException;
				}
				else
				{
					string text;
					string text2;
					string text3;
					TimeZoneInfo.GetLocalizedNamesByRegistryKey(registryKey, out text, out text2, out text3);
					try
					{
						value = new TimeZoneInfo(id, new TimeSpan(0, -reg_TZI_FORMAT.Bias, 0), text ?? string.Empty, text2 ?? string.Empty, text3 ?? string.Empty, adjustmentRules, false, false);
						result = TimeZoneInfo.TimeZoneInfoResult.Success;
					}
					catch (ArgumentException ex)
					{
						value = null;
						e = ex;
						result = TimeZoneInfo.TimeZoneInfoResult.InvalidTimeZoneException;
					}
					catch (InvalidTimeZoneException ex2)
					{
						value = null;
						e = ex2;
						result = TimeZoneInfo.TimeZoneInfoResult.InvalidTimeZoneException;
					}
				}
			}
			return result;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0006C144 File Offset: 0x0006A344
		private static string GetUtcStandardDisplayName()
		{
			CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
			if (currentUICulture.Name.Length == 0 || currentUICulture.TwoLetterISOLanguageName == "en")
			{
				return "Coordinated Universal Time";
			}
			string text = null;
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones\\UTC", false))
			{
				if (registryKey != null)
				{
					string text2 = registryKey.GetValue("MUI_Std", string.Empty) as string;
					if (!string.IsNullOrEmpty(text2))
					{
						text = TimeZoneInfo.GetLocalizedNameByMuiNativeResource(text2);
					}
					if (string.IsNullOrEmpty(text))
					{
						text = (registryKey.GetValue("Std", string.Empty) as string);
					}
				}
			}
			if (text == null || text == "GMT" || text == "UTC")
			{
				text = "Coordinated Universal Time";
			}
			return text;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0006C218 File Offset: 0x0006A418
		private static string GetUtcFullDisplayName(string _, string standardDisplayName)
		{
			return "(UTC) " + standardDisplayName;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0006C228 File Offset: 0x0006A428
		private unsafe static string GetLocalizedNameByNativeResource(string filePath, int resource)
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Interop.Kernel32.LoadLibraryEx(filePath, IntPtr.Zero, 2);
				if (intPtr != IntPtr.Zero)
				{
					char* ptr = stackalloc char[(UIntPtr)1000];
					int num = Interop.User32.LoadString(intPtr, (uint)resource, ptr, 500);
					if (num != 0)
					{
						return new string(ptr, 0, num);
					}
				}
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Interop.Kernel32.FreeLibrary(intPtr);
				}
			}
			return string.Empty;
		}

		// Token: 0x04000667 RID: 1639
		private readonly string _id;

		// Token: 0x04000668 RID: 1640
		private string _displayName;

		// Token: 0x04000669 RID: 1641
		private string _standardDisplayName;

		// Token: 0x0400066A RID: 1642
		private string _daylightDisplayName;

		// Token: 0x0400066B RID: 1643
		private readonly TimeSpan _baseUtcOffset;

		// Token: 0x0400066C RID: 1644
		private readonly bool _supportsDaylightSavingTime;

		// Token: 0x0400066D RID: 1645
		private readonly TimeZoneInfo.AdjustmentRule[] _adjustmentRules;

		// Token: 0x0400066E RID: 1646
		private List<TimeZoneInfo> _equivalentZones;

		// Token: 0x0400066F RID: 1647
		private static readonly TimeZoneInfo s_utcTimeZone = TimeZoneInfo.CreateUtcTimeZone();

		// Token: 0x04000670 RID: 1648
		private static TimeZoneInfo.CachedData s_cachedData = new TimeZoneInfo.CachedData();

		// Token: 0x04000671 RID: 1649
		private static readonly DateTime s_maxDateOnly = new DateTime(9999, 12, 31);

		// Token: 0x04000672 RID: 1650
		private static readonly DateTime s_minDateOnly = new DateTime(1, 1, 2);

		// Token: 0x04000674 RID: 1652
		private static readonly TimeSpan MaxOffset = TimeSpan.FromHours(14.0);

		// Token: 0x04000675 RID: 1653
		private static readonly TimeSpan MinOffset = -TimeZoneInfo.MaxOffset;

		// Token: 0x020001CB RID: 459
		[NullableContext(0)]
		[Serializable]
		public sealed class AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback
		{
			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06002360 RID: 9056 RVA: 0x0006C303 File Offset: 0x0006A503
			public DateTime DateStart
			{
				get
				{
					return this._dateStart;
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06002361 RID: 9057 RVA: 0x0006C30B File Offset: 0x0006A50B
			public DateTime DateEnd
			{
				get
				{
					return this._dateEnd;
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06002362 RID: 9058 RVA: 0x0006C313 File Offset: 0x0006A513
			public TimeSpan DaylightDelta
			{
				get
				{
					return this._daylightDelta;
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06002363 RID: 9059 RVA: 0x0006C31B File Offset: 0x0006A51B
			public TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				get
				{
					return this._daylightTransitionStart;
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06002364 RID: 9060 RVA: 0x0006C323 File Offset: 0x0006A523
			public TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				get
				{
					return this._daylightTransitionEnd;
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06002365 RID: 9061 RVA: 0x0006C32B File Offset: 0x0006A52B
			public TimeSpan BaseUtcOffsetDelta
			{
				get
				{
					return this._baseUtcOffsetDelta;
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06002366 RID: 9062 RVA: 0x0006C333 File Offset: 0x0006A533
			internal bool NoDaylightTransitions
			{
				get
				{
					return this._noDaylightTransitions;
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06002367 RID: 9063 RVA: 0x0006C33C File Offset: 0x0006A53C
			internal bool HasDaylightSaving
			{
				get
				{
					return this.DaylightDelta != TimeSpan.Zero || (this.DaylightTransitionStart != default(TimeZoneInfo.TransitionTime) && this.DaylightTransitionStart.TimeOfDay != DateTime.MinValue) || (this.DaylightTransitionEnd != default(TimeZoneInfo.TransitionTime) && this.DaylightTransitionEnd.TimeOfDay != DateTime.MinValue.AddMilliseconds(1.0));
				}
			}

			// Token: 0x06002368 RID: 9064 RVA: 0x0006C3CC File Offset: 0x0006A5CC
			[NullableContext(2)]
			public bool Equals([NotNullWhen(true)] TimeZoneInfo.AdjustmentRule other)
			{
				return other != null && this._dateStart == other._dateStart && this._dateEnd == other._dateEnd && this._daylightDelta == other._daylightDelta && this._baseUtcOffsetDelta == other._baseUtcOffsetDelta && this._daylightTransitionEnd.Equals(other._daylightTransitionEnd) && this._daylightTransitionStart.Equals(other._daylightTransitionStart);
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x0006C450 File Offset: 0x0006A650
			[NullableContext(2)]
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				TimeZoneInfo.AdjustmentRule adjustmentRule = obj as TimeZoneInfo.AdjustmentRule;
				return adjustmentRule != null && this.Equals(adjustmentRule);
			}

			// Token: 0x0600236A RID: 9066 RVA: 0x0006C470 File Offset: 0x0006A670
			public override int GetHashCode()
			{
				return this._dateStart.GetHashCode();
			}

			// Token: 0x0600236B RID: 9067 RVA: 0x0006C480 File Offset: 0x0006A680
			private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				TimeZoneInfo.AdjustmentRule.ValidateAdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd, noDaylightTransitions);
				this._dateStart = dateStart;
				this._dateEnd = dateEnd;
				this._daylightDelta = daylightDelta;
				this._daylightTransitionStart = daylightTransitionStart;
				this._daylightTransitionEnd = daylightTransitionEnd;
				this._baseUtcOffsetDelta = baseUtcOffsetDelta;
				this._noDaylightTransitions = noDaylightTransitions;
			}

			// Token: 0x0600236C RID: 9068 RVA: 0x0006C4D6 File Offset: 0x0006A6D6
			[NullableContext(1)]
			public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta)
			{
				return new TimeZoneInfo.AdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd, baseUtcOffsetDelta, false);
			}

			// Token: 0x0600236D RID: 9069 RVA: 0x0006C4E6 File Offset: 0x0006A6E6
			[NullableContext(1)]
			public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				return new TimeZoneInfo.AdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd, TimeSpan.Zero, false);
			}

			// Token: 0x0600236E RID: 9070 RVA: 0x0006C4F9 File Offset: 0x0006A6F9
			internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				TimeZoneInfo.AdjustmentRule.AdjustDaylightDeltaToExpectedRange(ref daylightDelta, ref baseUtcOffsetDelta);
				return new TimeZoneInfo.AdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd, baseUtcOffsetDelta, noDaylightTransitions);
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0006C514 File Offset: 0x0006A714
			internal bool IsStartDateMarkerForBeginningOfYear()
			{
				return !this.NoDaylightTransitions && this.DaylightTransitionStart.Month == 1 && this.DaylightTransitionStart.Day == 1 && this.DaylightTransitionStart.TimeOfDay.TimeOfDay.Ticks < 10000000L;
			}

			// Token: 0x06002370 RID: 9072 RVA: 0x0006C574 File Offset: 0x0006A774
			internal bool IsEndDateMarkerForEndOfYear()
			{
				return !this.NoDaylightTransitions && this.DaylightTransitionEnd.Month == 1 && this.DaylightTransitionEnd.Day == 1 && this.DaylightTransitionEnd.TimeOfDay.TimeOfDay.Ticks < 10000000L;
			}

			// Token: 0x06002371 RID: 9073 RVA: 0x0006C5D4 File Offset: 0x0006A7D4
			private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
			{
				if (dateStart.Kind != DateTimeKind.Unspecified && dateStart.Kind != DateTimeKind.Utc)
				{
					throw new ArgumentException(SR.Argument_DateTimeKindMustBeUnspecifiedOrUtc, "dateStart");
				}
				if (dateEnd.Kind != DateTimeKind.Unspecified && dateEnd.Kind != DateTimeKind.Utc)
				{
					throw new ArgumentException(SR.Argument_DateTimeKindMustBeUnspecifiedOrUtc, "dateEnd");
				}
				if (daylightTransitionStart.Equals(daylightTransitionEnd) && !noDaylightTransitions)
				{
					throw new ArgumentException(SR.Argument_TransitionTimesAreIdentical, "daylightTransitionEnd");
				}
				if (dateStart > dateEnd)
				{
					throw new ArgumentException(SR.Argument_OutOfOrderDateTimes, "dateStart");
				}
				if (daylightDelta.TotalHours < -23.0 || daylightDelta.TotalHours > 14.0)
				{
					throw new ArgumentOutOfRangeException("daylightDelta", daylightDelta, SR.ArgumentOutOfRange_UtcOffset);
				}
				if (daylightDelta.Ticks % 600000000L != 0L)
				{
					throw new ArgumentException(SR.Argument_TimeSpanHasSeconds, "daylightDelta");
				}
				if (dateStart != DateTime.MinValue && dateStart.Kind == DateTimeKind.Unspecified && dateStart.TimeOfDay != TimeSpan.Zero)
				{
					throw new ArgumentException(SR.Argument_DateTimeHasTimeOfDay, "dateStart");
				}
				if (dateEnd != DateTime.MaxValue && dateEnd.Kind == DateTimeKind.Unspecified && dateEnd.TimeOfDay != TimeSpan.Zero)
				{
					throw new ArgumentException(SR.Argument_DateTimeHasTimeOfDay, "dateEnd");
				}
			}

			// Token: 0x06002372 RID: 9074 RVA: 0x0006C72C File Offset: 0x0006A92C
			private static void AdjustDaylightDeltaToExpectedRange(ref TimeSpan daylightDelta, ref TimeSpan baseUtcOffsetDelta)
			{
				if (daylightDelta > TimeZoneInfo.AdjustmentRule.MaxDaylightDelta)
				{
					daylightDelta -= TimeZoneInfo.AdjustmentRule.DaylightDeltaAdjustment;
					baseUtcOffsetDelta += TimeZoneInfo.AdjustmentRule.DaylightDeltaAdjustment;
					return;
				}
				if (daylightDelta < -TimeZoneInfo.AdjustmentRule.MaxDaylightDelta)
				{
					daylightDelta += TimeZoneInfo.AdjustmentRule.DaylightDeltaAdjustment;
					baseUtcOffsetDelta -= TimeZoneInfo.AdjustmentRule.DaylightDeltaAdjustment;
				}
			}

			// Token: 0x06002373 RID: 9075 RVA: 0x0006C7BC File Offset: 0x0006A9BC
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				try
				{
					TimeZoneInfo.AdjustmentRule.ValidateAdjustmentRule(this._dateStart, this._dateEnd, this._daylightDelta, this._daylightTransitionStart, this._daylightTransitionEnd, this._noDaylightTransitions);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException);
				}
			}

			// Token: 0x06002374 RID: 9076 RVA: 0x0006C814 File Offset: 0x0006AA14
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				ArgumentNullException.ThrowIfNull(info, "info");
				info.AddValue("DateStart", this._dateStart);
				info.AddValue("DateEnd", this._dateEnd);
				info.AddValue("DaylightDelta", this._daylightDelta);
				info.AddValue("DaylightTransitionStart", this._daylightTransitionStart);
				info.AddValue("DaylightTransitionEnd", this._daylightTransitionEnd);
				info.AddValue("BaseUtcOffsetDelta", this._baseUtcOffsetDelta);
				info.AddValue("NoDaylightTransitions", this._noDaylightTransitions);
			}

			// Token: 0x06002375 RID: 9077 RVA: 0x0006C8B8 File Offset: 0x0006AAB8
			private AdjustmentRule(SerializationInfo info, StreamingContext context)
			{
				ArgumentNullException.ThrowIfNull(info, "info");
				this._dateStart = (DateTime)info.GetValue("DateStart", typeof(DateTime));
				this._dateEnd = (DateTime)info.GetValue("DateEnd", typeof(DateTime));
				this._daylightDelta = (TimeSpan)info.GetValue("DaylightDelta", typeof(TimeSpan));
				this._daylightTransitionStart = (TimeZoneInfo.TransitionTime)info.GetValue("DaylightTransitionStart", typeof(TimeZoneInfo.TransitionTime));
				this._daylightTransitionEnd = (TimeZoneInfo.TransitionTime)info.GetValue("DaylightTransitionEnd", typeof(TimeZoneInfo.TransitionTime));
				object valueNoThrow = info.GetValueNoThrow("BaseUtcOffsetDelta", typeof(TimeSpan));
				if (valueNoThrow != null)
				{
					this._baseUtcOffsetDelta = (TimeSpan)valueNoThrow;
				}
				valueNoThrow = info.GetValueNoThrow("NoDaylightTransitions", typeof(bool));
				if (valueNoThrow != null)
				{
					this._noDaylightTransitions = (bool)valueNoThrow;
				}
			}

			// Token: 0x04000676 RID: 1654
			private static readonly TimeSpan DaylightDeltaAdjustment = TimeSpan.FromHours(24.0);

			// Token: 0x04000677 RID: 1655
			private static readonly TimeSpan MaxDaylightDelta = TimeSpan.FromHours(12.0);

			// Token: 0x04000678 RID: 1656
			private readonly DateTime _dateStart;

			// Token: 0x04000679 RID: 1657
			private readonly DateTime _dateEnd;

			// Token: 0x0400067A RID: 1658
			private readonly TimeSpan _daylightDelta;

			// Token: 0x0400067B RID: 1659
			private readonly TimeZoneInfo.TransitionTime _daylightTransitionStart;

			// Token: 0x0400067C RID: 1660
			private readonly TimeZoneInfo.TransitionTime _daylightTransitionEnd;

			// Token: 0x0400067D RID: 1661
			private readonly TimeSpan _baseUtcOffsetDelta;

			// Token: 0x0400067E RID: 1662
			private readonly bool _noDaylightTransitions;
		}

		// Token: 0x020001CC RID: 460
		private enum TimeZoneInfoResult
		{
			// Token: 0x04000680 RID: 1664
			Success,
			// Token: 0x04000681 RID: 1665
			TimeZoneNotFoundException,
			// Token: 0x04000682 RID: 1666
			InvalidTimeZoneException,
			// Token: 0x04000683 RID: 1667
			SecurityException
		}

		// Token: 0x020001CD RID: 461
		private sealed class CachedData
		{
			// Token: 0x06002377 RID: 9079 RVA: 0x0006C9E8 File Offset: 0x0006ABE8
			private TimeZoneInfo CreateLocal()
			{
				TimeZoneInfo result;
				lock (this)
				{
					TimeZoneInfo timeZoneInfo = this._localTimeZone;
					if (timeZoneInfo == null)
					{
						timeZoneInfo = TimeZoneInfo.GetLocalTimeZone(this);
						timeZoneInfo = new TimeZoneInfo(timeZoneInfo._id, timeZoneInfo._baseUtcOffset, timeZoneInfo.DisplayName, timeZoneInfo.StandardName, timeZoneInfo.DaylightName, timeZoneInfo._adjustmentRules, false, timeZoneInfo.HasIanaId);
						this._localTimeZone = timeZoneInfo;
					}
					result = timeZoneInfo;
				}
				return result;
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06002378 RID: 9080 RVA: 0x0006CA70 File Offset: 0x0006AC70
			public TimeZoneInfo Local
			{
				get
				{
					return this._localTimeZone ?? this.CreateLocal();
				}
			}

			// Token: 0x06002379 RID: 9081 RVA: 0x0006CA84 File Offset: 0x0006AC84
			public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
			{
				if (timeZone == TimeZoneInfo.s_utcTimeZone)
				{
					return DateTimeKind.Utc;
				}
				if (timeZone != this._localTimeZone)
				{
					return DateTimeKind.Unspecified;
				}
				return DateTimeKind.Local;
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x0006CAA0 File Offset: 0x0006ACA0
			private static TimeZoneInfo GetCurrentOneYearLocal()
			{
				Interop.Kernel32.TIME_ZONE_INFORMATION time_ZONE_INFORMATION;
				if (Interop.Kernel32.GetTimeZoneInformation(out time_ZONE_INFORMATION) != 4294967295U)
				{
					return TimeZoneInfo.GetLocalTimeZoneFromWin32Data(time_ZONE_INFORMATION, false);
				}
				return TimeZoneInfo.CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x0006CADC File Offset: 0x0006ACDC
			public TimeZoneInfo.OffsetAndRule GetOneYearLocalFromUtc(int year)
			{
				TimeZoneInfo.OffsetAndRule offsetAndRule = this._oneYearLocalFromUtc;
				if (offsetAndRule == null || offsetAndRule.Year != year)
				{
					TimeZoneInfo currentOneYearLocal = TimeZoneInfo.CachedData.GetCurrentOneYearLocal();
					TimeZoneInfo.AdjustmentRule[] adjustmentRules = currentOneYearLocal._adjustmentRules;
					TimeZoneInfo.AdjustmentRule rule = (adjustmentRules != null) ? adjustmentRules[0] : null;
					offsetAndRule = new TimeZoneInfo.OffsetAndRule(year, currentOneYearLocal.BaseUtcOffset, rule);
					this._oneYearLocalFromUtc = offsetAndRule;
				}
				return offsetAndRule;
			}

			// Token: 0x04000684 RID: 1668
			private volatile TimeZoneInfo _localTimeZone;

			// Token: 0x04000685 RID: 1669
			public Dictionary<string, TimeZoneInfo> _systemTimeZones;

			// Token: 0x04000686 RID: 1670
			public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones;

			// Token: 0x04000687 RID: 1671
			public ReadOnlyCollection<TimeZoneInfo> _readOnlyUnsortedSystemTimeZones;

			// Token: 0x04000688 RID: 1672
			public Dictionary<string, TimeZoneInfo> _timeZonesUsingAlternativeIds;

			// Token: 0x04000689 RID: 1673
			public bool _allSystemTimeZonesRead;

			// Token: 0x0400068A RID: 1674
			private volatile TimeZoneInfo.OffsetAndRule _oneYearLocalFromUtc;
		}

		// Token: 0x020001CE RID: 462
		private struct StringSerializer
		{
			// Token: 0x0600237D RID: 9085 RVA: 0x0006CB2C File Offset: 0x0006AD2C
			public unsafe static string GetSerializedString(TimeZoneInfo zone)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				TimeZoneInfo.StringSerializer.SerializeSubstitute(zone.Id, ref valueStringBuilder);
				valueStringBuilder.Append(';');
				valueStringBuilder.AppendSpanFormattable<double>(zone.BaseUtcOffset.TotalMinutes, null, CultureInfo.InvariantCulture);
				valueStringBuilder.Append(';');
				TimeZoneInfo.StringSerializer.SerializeSubstitute(zone.DisplayName, ref valueStringBuilder);
				valueStringBuilder.Append(';');
				TimeZoneInfo.StringSerializer.SerializeSubstitute(zone.StandardName, ref valueStringBuilder);
				valueStringBuilder.Append(';');
				TimeZoneInfo.StringSerializer.SerializeSubstitute(zone.DaylightName, ref valueStringBuilder);
				valueStringBuilder.Append(';');
				foreach (TimeZoneInfo.AdjustmentRule adjustmentRule in zone.GetAdjustmentRules())
				{
					valueStringBuilder.Append('[');
					valueStringBuilder.AppendSpanFormattable<DateTime>(adjustmentRule.DateStart, "MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo);
					valueStringBuilder.Append(';');
					valueStringBuilder.AppendSpanFormattable<DateTime>(adjustmentRule.DateEnd, "MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo);
					valueStringBuilder.Append(';');
					valueStringBuilder.AppendSpanFormattable<double>(adjustmentRule.DaylightDelta.TotalMinutes, null, CultureInfo.InvariantCulture);
					valueStringBuilder.Append(';');
					TimeZoneInfo.StringSerializer.SerializeTransitionTime(adjustmentRule.DaylightTransitionStart, ref valueStringBuilder);
					valueStringBuilder.Append(';');
					TimeZoneInfo.StringSerializer.SerializeTransitionTime(adjustmentRule.DaylightTransitionEnd, ref valueStringBuilder);
					valueStringBuilder.Append(';');
					if (adjustmentRule.BaseUtcOffsetDelta != TimeSpan.Zero)
					{
						valueStringBuilder.AppendSpanFormattable<double>(adjustmentRule.BaseUtcOffsetDelta.TotalMinutes, null, CultureInfo.InvariantCulture);
						valueStringBuilder.Append(';');
					}
					if (adjustmentRule.NoDaylightTransitions)
					{
						valueStringBuilder.Append('1');
						valueStringBuilder.Append(';');
					}
					valueStringBuilder.Append(']');
				}
				valueStringBuilder.Append(';');
				return valueStringBuilder.ToString();
			}

			// Token: 0x0600237E RID: 9086 RVA: 0x0006CD04 File Offset: 0x0006AF04
			public static TimeZoneInfo GetDeserializedTimeZoneInfo(string source)
			{
				TimeZoneInfo.StringSerializer stringSerializer = new TimeZoneInfo.StringSerializer(source);
				string nextStringValue = stringSerializer.GetNextStringValue();
				TimeSpan nextTimeSpanValue = stringSerializer.GetNextTimeSpanValue();
				string nextStringValue2 = stringSerializer.GetNextStringValue();
				string nextStringValue3 = stringSerializer.GetNextStringValue();
				string nextStringValue4 = stringSerializer.GetNextStringValue();
				TimeZoneInfo.AdjustmentRule[] nextAdjustmentRuleArrayValue = stringSerializer.GetNextAdjustmentRuleArrayValue();
				TimeZoneInfo result;
				try
				{
					result = new TimeZoneInfo(nextStringValue, nextTimeSpanValue, nextStringValue2, nextStringValue3, nextStringValue4, nextAdjustmentRuleArrayValue, false, false);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException);
				}
				catch (InvalidTimeZoneException innerException2)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException2);
				}
				return result;
			}

			// Token: 0x0600237F RID: 9087 RVA: 0x0006CD9C File Offset: 0x0006AF9C
			private StringSerializer(string str)
			{
				this._serializedText = str;
				this._currentTokenStartIndex = 0;
				this._state = TimeZoneInfo.StringSerializer.State.StartOfToken;
			}

			// Token: 0x06002380 RID: 9088 RVA: 0x0006CDB4 File Offset: 0x0006AFB4
			private static void SerializeSubstitute(string text, ref ValueStringBuilder serializedText)
			{
				foreach (char c in text)
				{
					if (c == '\\' || c == '[' || c == ']' || c == ';')
					{
						serializedText.Append('\\');
					}
					serializedText.Append(c);
				}
			}

			// Token: 0x06002381 RID: 9089 RVA: 0x0006CE00 File Offset: 0x0006B000
			private static void SerializeTransitionTime(TimeZoneInfo.TransitionTime time, ref ValueStringBuilder serializedText)
			{
				serializedText.Append('[');
				serializedText.Append(time.IsFixedDateRule ? '1' : '0');
				serializedText.Append(';');
				serializedText.AppendSpanFormattable<DateTime>(time.TimeOfDay, "HH:mm:ss.FFF", DateTimeFormatInfo.InvariantInfo);
				serializedText.Append(';');
				serializedText.AppendSpanFormattable<int>(time.Month, null, CultureInfo.InvariantCulture);
				serializedText.Append(';');
				if (time.IsFixedDateRule)
				{
					serializedText.AppendSpanFormattable<int>(time.Day, null, CultureInfo.InvariantCulture);
					serializedText.Append(';');
				}
				else
				{
					serializedText.AppendSpanFormattable<int>(time.Week, null, CultureInfo.InvariantCulture);
					serializedText.Append(';');
					serializedText.AppendSpanFormattable<int>((int)time.DayOfWeek, null, CultureInfo.InvariantCulture);
					serializedText.Append(';');
				}
				serializedText.Append(']');
			}

			// Token: 0x06002382 RID: 9090 RVA: 0x0006CED0 File Offset: 0x0006B0D0
			private static void VerifyIsEscapableCharacter(char c)
			{
				if (c != '\\' && c != ';' && c != '[' && c != ']')
				{
					throw new SerializationException(SR.Format(SR.Serialization_InvalidEscapeSequence, c));
				}
			}

			// Token: 0x06002383 RID: 9091 RVA: 0x0006CEFC File Offset: 0x0006B0FC
			private void SkipVersionNextDataFields(int depth)
			{
				if (this._currentTokenStartIndex < 0 || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				TimeZoneInfo.StringSerializer.State state = TimeZoneInfo.StringSerializer.State.NotEscaped;
				for (int i = this._currentTokenStartIndex; i < this._serializedText.Length; i++)
				{
					if (state == TimeZoneInfo.StringSerializer.State.Escaped)
					{
						TimeZoneInfo.StringSerializer.VerifyIsEscapableCharacter(this._serializedText[i]);
						state = TimeZoneInfo.StringSerializer.State.NotEscaped;
					}
					else if (state == TimeZoneInfo.StringSerializer.State.NotEscaped)
					{
						char c = this._serializedText[i];
						if (c == '\0')
						{
							throw new SerializationException(SR.Serialization_InvalidData);
						}
						switch (c)
						{
						case '[':
							depth++;
							break;
						case '\\':
							state = TimeZoneInfo.StringSerializer.State.Escaped;
							break;
						case ']':
							depth--;
							if (depth == 0)
							{
								this._currentTokenStartIndex = i + 1;
								if (this._currentTokenStartIndex >= this._serializedText.Length)
								{
									this._state = TimeZoneInfo.StringSerializer.State.EndOfLine;
									return;
								}
								this._state = TimeZoneInfo.StringSerializer.State.StartOfToken;
								return;
							}
							break;
						}
					}
				}
				throw new SerializationException(SR.Serialization_InvalidData);
			}

			// Token: 0x06002384 RID: 9092 RVA: 0x0006CFEC File Offset: 0x0006B1EC
			private unsafe string GetNextStringValue()
			{
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._currentTokenStartIndex < 0 || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				TimeZoneInfo.StringSerializer.State state = TimeZoneInfo.StringSerializer.State.NotEscaped;
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				for (int i = this._currentTokenStartIndex; i < this._serializedText.Length; i++)
				{
					if (state == TimeZoneInfo.StringSerializer.State.Escaped)
					{
						TimeZoneInfo.StringSerializer.VerifyIsEscapableCharacter(this._serializedText[i]);
						valueStringBuilder.Append(this._serializedText[i]);
						state = TimeZoneInfo.StringSerializer.State.NotEscaped;
					}
					else if (state == TimeZoneInfo.StringSerializer.State.NotEscaped)
					{
						char c = this._serializedText[i];
						if (c == '\0')
						{
							throw new SerializationException(SR.Serialization_InvalidData);
						}
						if (c == ';')
						{
							this._currentTokenStartIndex = i + 1;
							if (this._currentTokenStartIndex >= this._serializedText.Length)
							{
								this._state = TimeZoneInfo.StringSerializer.State.EndOfLine;
							}
							else
							{
								this._state = TimeZoneInfo.StringSerializer.State.StartOfToken;
							}
							return valueStringBuilder.ToString();
						}
						switch (c)
						{
						case '[':
							throw new SerializationException(SR.Serialization_InvalidData);
						case '\\':
							state = TimeZoneInfo.StringSerializer.State.Escaped;
							break;
						case ']':
							throw new SerializationException(SR.Serialization_InvalidData);
						default:
							valueStringBuilder.Append(this._serializedText[i]);
							break;
						}
					}
				}
				if (state == TimeZoneInfo.StringSerializer.State.Escaped)
				{
					throw new SerializationException(SR.Format(SR.Serialization_InvalidEscapeSequence, string.Empty));
				}
				throw new SerializationException(SR.Serialization_InvalidData);
			}

			// Token: 0x06002385 RID: 9093 RVA: 0x0006D168 File Offset: 0x0006B368
			private DateTime GetNextDateTimeValue(string format)
			{
				DateTime result;
				if (!DateTime.TryParseExact(this.GetNextStringValue(), format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				return result;
			}

			// Token: 0x06002386 RID: 9094 RVA: 0x0006D198 File Offset: 0x0006B398
			private TimeSpan GetNextTimeSpanValue()
			{
				int nextInt32Value = this.GetNextInt32Value();
				TimeSpan result;
				try
				{
					result = new TimeSpan(0, nextInt32Value, 0);
				}
				catch (ArgumentOutOfRangeException innerException)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException);
				}
				return result;
			}

			// Token: 0x06002387 RID: 9095 RVA: 0x0006D1D8 File Offset: 0x0006B3D8
			private int GetNextInt32Value()
			{
				int result;
				if (!int.TryParse(this.GetNextStringValue(), NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result))
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				return result;
			}

			// Token: 0x06002388 RID: 9096 RVA: 0x0006D208 File Offset: 0x0006B408
			private TimeZoneInfo.AdjustmentRule[] GetNextAdjustmentRuleArrayValue()
			{
				List<TimeZoneInfo.AdjustmentRule> list = new List<TimeZoneInfo.AdjustmentRule>(1);
				int num = 0;
				for (TimeZoneInfo.AdjustmentRule nextAdjustmentRuleValue = this.GetNextAdjustmentRuleValue(); nextAdjustmentRuleValue != null; nextAdjustmentRuleValue = this.GetNextAdjustmentRuleValue())
				{
					list.Add(nextAdjustmentRuleValue);
					num++;
				}
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._currentTokenStartIndex < 0 || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (num == 0)
				{
					return null;
				}
				return list.ToArray();
			}

			// Token: 0x06002389 RID: 9097 RVA: 0x0006D284 File Offset: 0x0006B484
			private TimeZoneInfo.AdjustmentRule GetNextAdjustmentRuleValue()
			{
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine)
				{
					return null;
				}
				if (this._currentTokenStartIndex < 0 || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._serializedText[this._currentTokenStartIndex] == ';')
				{
					return null;
				}
				if (this._serializedText[this._currentTokenStartIndex] != '[')
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				this._currentTokenStartIndex++;
				DateTime nextDateTimeValue = this.GetNextDateTimeValue("MM:dd:yyyy");
				DateTime nextDateTimeValue2 = this.GetNextDateTimeValue("MM:dd:yyyy");
				TimeSpan nextTimeSpanValue = this.GetNextTimeSpanValue();
				TimeZoneInfo.TransitionTime nextTransitionTimeValue = this.GetNextTransitionTimeValue();
				TimeZoneInfo.TransitionTime nextTransitionTimeValue2 = this.GetNextTransitionTimeValue();
				TimeSpan baseUtcOffsetDelta = TimeSpan.Zero;
				int num = 0;
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				bool flag = char.IsAsciiDigit(this._serializedText[this._currentTokenStartIndex]);
				char c;
				if (!flag)
				{
					c = this._serializedText[this._currentTokenStartIndex];
					bool flag2 = c == '+' || c == '-';
					flag = flag2;
				}
				if (flag)
				{
					baseUtcOffsetDelta = this.GetNextTimeSpanValue();
				}
				c = this._serializedText[this._currentTokenStartIndex];
				flag = (c == '0' || c == '1');
				if (flag)
				{
					num = this.GetNextInt32Value();
				}
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._serializedText[this._currentTokenStartIndex] != ']')
				{
					this.SkipVersionNextDataFields(1);
				}
				else
				{
					this._currentTokenStartIndex++;
				}
				TimeZoneInfo.AdjustmentRule result;
				try
				{
					result = TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(nextDateTimeValue, nextDateTimeValue2, nextTimeSpanValue, nextTransitionTimeValue, nextTransitionTimeValue2, baseUtcOffsetDelta, num > 0);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException);
				}
				if (this._currentTokenStartIndex >= this._serializedText.Length)
				{
					this._state = TimeZoneInfo.StringSerializer.State.EndOfLine;
				}
				else
				{
					this._state = TimeZoneInfo.StringSerializer.State.StartOfToken;
				}
				return result;
			}

			// Token: 0x0600238A RID: 9098 RVA: 0x0006D49C File Offset: 0x0006B69C
			private TimeZoneInfo.TransitionTime GetNextTransitionTimeValue()
			{
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine || (this._currentTokenStartIndex < this._serializedText.Length && this._serializedText[this._currentTokenStartIndex] == ']'))
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._currentTokenStartIndex < 0 || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._serializedText[this._currentTokenStartIndex] != '[')
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				this._currentTokenStartIndex++;
				int nextInt32Value = this.GetNextInt32Value();
				if (nextInt32Value != 0 && nextInt32Value != 1)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				DateTime nextDateTimeValue = this.GetNextDateTimeValue("HH:mm:ss.FFF");
				nextDateTimeValue = new DateTime(1, 1, 1, nextDateTimeValue.Hour, nextDateTimeValue.Minute, nextDateTimeValue.Second, nextDateTimeValue.Millisecond);
				int nextInt32Value2 = this.GetNextInt32Value();
				TimeZoneInfo.TransitionTime result;
				if (nextInt32Value == 1)
				{
					int nextInt32Value3 = this.GetNextInt32Value();
					try
					{
						result = TimeZoneInfo.TransitionTime.CreateFixedDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value3);
						goto IL_137;
					}
					catch (ArgumentException innerException)
					{
						throw new SerializationException(SR.Serialization_InvalidData, innerException);
					}
				}
				int nextInt32Value4 = this.GetNextInt32Value();
				int nextInt32Value5 = this.GetNextInt32Value();
				try
				{
					result = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value4, (DayOfWeek)nextInt32Value5);
				}
				catch (ArgumentException innerException2)
				{
					throw new SerializationException(SR.Serialization_InvalidData, innerException2);
				}
				IL_137:
				if (this._state == TimeZoneInfo.StringSerializer.State.EndOfLine || this._currentTokenStartIndex >= this._serializedText.Length)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._serializedText[this._currentTokenStartIndex] != ']')
				{
					this.SkipVersionNextDataFields(1);
				}
				else
				{
					this._currentTokenStartIndex++;
				}
				bool flag = false;
				if (this._currentTokenStartIndex < this._serializedText.Length && this._serializedText[this._currentTokenStartIndex] == ';')
				{
					this._currentTokenStartIndex++;
					flag = true;
				}
				if (!flag)
				{
					throw new SerializationException(SR.Serialization_InvalidData);
				}
				if (this._currentTokenStartIndex >= this._serializedText.Length)
				{
					this._state = TimeZoneInfo.StringSerializer.State.EndOfLine;
				}
				else
				{
					this._state = TimeZoneInfo.StringSerializer.State.StartOfToken;
				}
				return result;
			}

			// Token: 0x0400068B RID: 1675
			private readonly string _serializedText;

			// Token: 0x0400068C RID: 1676
			private int _currentTokenStartIndex;

			// Token: 0x0400068D RID: 1677
			private TimeZoneInfo.StringSerializer.State _state;

			// Token: 0x020001CF RID: 463
			private enum State
			{
				// Token: 0x0400068F RID: 1679
				Escaped,
				// Token: 0x04000690 RID: 1680
				NotEscaped,
				// Token: 0x04000691 RID: 1681
				StartOfToken,
				// Token: 0x04000692 RID: 1682
				EndOfLine
			}
		}

		// Token: 0x020001D0 RID: 464
		[NullableContext(0)]
		[Serializable]
		public readonly struct TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback
		{
			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x0600238B RID: 9099 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
			public DateTime TimeOfDay
			{
				get
				{
					return this._timeOfDay;
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x0600238C RID: 9100 RVA: 0x0006D6C8 File Offset: 0x0006B8C8
			public int Month
			{
				get
				{
					return (int)this._month;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x0600238D RID: 9101 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
			public int Week
			{
				get
				{
					return (int)this._week;
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x0600238E RID: 9102 RVA: 0x0006D6D8 File Offset: 0x0006B8D8
			public int Day
			{
				get
				{
					return (int)this._day;
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x0600238F RID: 9103 RVA: 0x0006D6E0 File Offset: 0x0006B8E0
			public DayOfWeek DayOfWeek
			{
				get
				{
					return this._dayOfWeek;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06002390 RID: 9104 RVA: 0x0006D6E8 File Offset: 0x0006B8E8
			public bool IsFixedDateRule
			{
				get
				{
					return this._isFixedDateRule;
				}
			}

			// Token: 0x06002391 RID: 9105 RVA: 0x0006D6F0 File Offset: 0x0006B8F0
			[NullableContext(2)]
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				return obj is TimeZoneInfo.TransitionTime && this.Equals((TimeZoneInfo.TransitionTime)obj);
			}

			// Token: 0x06002392 RID: 9106 RVA: 0x0006D708 File Offset: 0x0006B908
			public static bool operator ==(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				return t1.Equals(t2);
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x0006D712 File Offset: 0x0006B912
			public static bool operator !=(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2)
			{
				return !t1.Equals(t2);
			}

			// Token: 0x06002394 RID: 9108 RVA: 0x0006D720 File Offset: 0x0006B920
			public bool Equals(TimeZoneInfo.TransitionTime other)
			{
				if (this._isFixedDateRule != other._isFixedDateRule || !(this._timeOfDay == other._timeOfDay) || this._month != other._month)
				{
					return false;
				}
				if (!other._isFixedDateRule)
				{
					return this._week == other._week && this._dayOfWeek == other._dayOfWeek;
				}
				return this._day == other._day;
			}

			// Token: 0x06002395 RID: 9109 RVA: 0x0006D793 File Offset: 0x0006B993
			public override int GetHashCode()
			{
				return (int)this._month ^ (int)this._week << 8;
			}

			// Token: 0x06002396 RID: 9110 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
			private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				TimeZoneInfo.TransitionTime.ValidateTransitionTime(timeOfDay, month, week, day, dayOfWeek);
				this._timeOfDay = timeOfDay;
				this._month = (byte)month;
				this._week = (byte)week;
				this._day = (byte)day;
				this._dayOfWeek = dayOfWeek;
				this._isFixedDateRule = isFixedDateRule;
			}

			// Token: 0x06002397 RID: 9111 RVA: 0x0006D7E2 File Offset: 0x0006B9E2
			public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
			{
				return new TimeZoneInfo.TransitionTime(timeOfDay, month, 1, day, DayOfWeek.Sunday, true);
			}

			// Token: 0x06002398 RID: 9112 RVA: 0x0006D7EF File Offset: 0x0006B9EF
			public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
			{
				return new TimeZoneInfo.TransitionTime(timeOfDay, month, week, 1, dayOfWeek, false);
			}

			// Token: 0x06002399 RID: 9113 RVA: 0x0006D7FC File Offset: 0x0006B9FC
			private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
			{
				if (timeOfDay.Kind != DateTimeKind.Unspecified)
				{
					throw new ArgumentException(SR.Argument_DateTimeKindMustBeUnspecified, "timeOfDay");
				}
				if (month < 1 || month > 12)
				{
					throw new ArgumentOutOfRangeException("month", SR.ArgumentOutOfRange_MonthParam);
				}
				if (day < 1 || day > 31)
				{
					throw new ArgumentOutOfRangeException("day", SR.ArgumentOutOfRange_DayParam);
				}
				if (week < 1 || week > 5)
				{
					throw new ArgumentOutOfRangeException("week", SR.ArgumentOutOfRange_Week);
				}
				if (dayOfWeek < DayOfWeek.Sunday || dayOfWeek > DayOfWeek.Saturday)
				{
					throw new ArgumentOutOfRangeException("dayOfWeek", SR.ArgumentOutOfRange_DayOfWeek);
				}
				int num;
				int num2;
				int num3;
				timeOfDay.GetDate(out num, out num2, out num3);
				if (num != 1 || num2 != 1 || num3 != 1 || timeOfDay.Ticks % 10000L != 0L)
				{
					throw new ArgumentException(SR.Argument_DateTimeHasTicks, "timeOfDay");
				}
			}

			// Token: 0x0600239A RID: 9114 RVA: 0x0006D8C0 File Offset: 0x0006BAC0
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				if (this != default(TimeZoneInfo.TransitionTime))
				{
					try
					{
						TimeZoneInfo.TransitionTime.ValidateTransitionTime(this._timeOfDay, (int)this._month, (int)this._week, (int)this._day, this._dayOfWeek);
					}
					catch (ArgumentException innerException)
					{
						throw new SerializationException(SR.Serialization_InvalidData, innerException);
					}
				}
			}

			// Token: 0x0600239B RID: 9115 RVA: 0x0006D928 File Offset: 0x0006BB28
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				ArgumentNullException.ThrowIfNull(info, "info");
				info.AddValue("TimeOfDay", this._timeOfDay);
				info.AddValue("Month", this._month);
				info.AddValue("Week", this._week);
				info.AddValue("Day", this._day);
				info.AddValue("DayOfWeek", this._dayOfWeek);
				info.AddValue("IsFixedDateRule", this._isFixedDateRule);
			}

			// Token: 0x0600239C RID: 9116 RVA: 0x0006D9AC File Offset: 0x0006BBAC
			private TransitionTime(SerializationInfo info, StreamingContext context)
			{
				ArgumentNullException.ThrowIfNull(info, "info");
				this._timeOfDay = (DateTime)info.GetValue("TimeOfDay", typeof(DateTime));
				this._month = (byte)info.GetValue("Month", typeof(byte));
				this._week = (byte)info.GetValue("Week", typeof(byte));
				this._day = (byte)info.GetValue("Day", typeof(byte));
				this._dayOfWeek = (DayOfWeek)info.GetValue("DayOfWeek", typeof(DayOfWeek));
				this._isFixedDateRule = (bool)info.GetValue("IsFixedDateRule", typeof(bool));
			}

			// Token: 0x04000693 RID: 1683
			private readonly DateTime _timeOfDay;

			// Token: 0x04000694 RID: 1684
			private readonly byte _month;

			// Token: 0x04000695 RID: 1685
			private readonly byte _week;

			// Token: 0x04000696 RID: 1686
			private readonly byte _day;

			// Token: 0x04000697 RID: 1687
			private readonly DayOfWeek _dayOfWeek;

			// Token: 0x04000698 RID: 1688
			private readonly bool _isFixedDateRule;
		}

		// Token: 0x020001D1 RID: 465
		private sealed class OffsetAndRule
		{
			// Token: 0x0600239D RID: 9117 RVA: 0x0006DA84 File Offset: 0x0006BC84
			public OffsetAndRule(int year, TimeSpan offset, TimeZoneInfo.AdjustmentRule rule)
			{
				this.Year = year;
				this.Offset = offset;
				this.Rule = rule;
			}

			// Token: 0x04000699 RID: 1689
			public readonly int Year;

			// Token: 0x0400069A RID: 1690
			public readonly TimeSpan Offset;

			// Token: 0x0400069B RID: 1691
			public readonly TimeZoneInfo.AdjustmentRule Rule;
		}
	}
}

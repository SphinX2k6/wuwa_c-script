using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002DE RID: 734
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
	{
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x000AF8F4 File Offset: 0x000ADAF4
		private string CultureName
		{
			get
			{
				string result;
				if ((result = this._name) == null)
				{
					result = (this._name = this._cultureData.CultureName);
				}
				return result;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000AF920 File Offset: 0x000ADB20
		private CultureInfo Culture
		{
			get
			{
				CultureInfo result;
				if ((result = this._cultureInfo) == null)
				{
					result = (this._cultureInfo = CultureInfo.GetCultureInfo(this.CultureName));
				}
				return result;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x000AF94C File Offset: 0x000ADB4C
		private string LanguageName
		{
			get
			{
				string result;
				if ((result = this._langName) == null)
				{
					result = (this._langName = this._cultureData.TwoLetterISOLanguageName);
				}
				return result;
			}
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x000AF977 File Offset: 0x000ADB77
		private string[] InternalGetAbbreviatedDayOfWeekNames()
		{
			return this.abbreviatedDayNames ?? this.InternalGetAbbreviatedDayOfWeekNamesCore();
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x000AF989 File Offset: 0x000ADB89
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] InternalGetAbbreviatedDayOfWeekNamesCore()
		{
			this.abbreviatedDayNames = this._cultureData.AbbreviatedDayNames(this.Calendar.ID);
			return this.abbreviatedDayNames;
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x000AF9AD File Offset: 0x000ADBAD
		private string[] InternalGetSuperShortDayNames()
		{
			return this.m_superShortDayNames ?? this.InternalGetSuperShortDayNamesCore();
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x000AF9BF File Offset: 0x000ADBBF
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] InternalGetSuperShortDayNamesCore()
		{
			this.m_superShortDayNames = this._cultureData.SuperShortDayNames(this.Calendar.ID);
			return this.m_superShortDayNames;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x000AF9E3 File Offset: 0x000ADBE3
		private string[] InternalGetDayOfWeekNames()
		{
			return this.dayNames ?? this.InternalGetDayOfWeekNamesCore();
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x000AF9F5 File Offset: 0x000ADBF5
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] InternalGetDayOfWeekNamesCore()
		{
			this.dayNames = this._cultureData.DayNames(this.Calendar.ID);
			return this.dayNames;
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x000AFA19 File Offset: 0x000ADC19
		private string[] InternalGetAbbreviatedMonthNames()
		{
			return this.abbreviatedMonthNames ?? this.InternalGetAbbreviatedMonthNamesCore();
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x000AFA2B File Offset: 0x000ADC2B
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] InternalGetAbbreviatedMonthNamesCore()
		{
			this.abbreviatedMonthNames = this._cultureData.AbbreviatedMonthNames(this.Calendar.ID);
			return this.abbreviatedMonthNames;
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x000AFA4F File Offset: 0x000ADC4F
		private string[] InternalGetMonthNames()
		{
			return this.monthNames ?? this.internalGetMonthNamesCore();
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x000AFA61 File Offset: 0x000ADC61
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string[] internalGetMonthNamesCore()
		{
			this.monthNames = this._cultureData.MonthNames(this.Calendar.ID);
			return this.monthNames;
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x000AFA85 File Offset: 0x000ADC85
		public DateTimeFormatInfo() : this(CultureInfo.InvariantCulture._cultureData, GregorianCalendar.GetDefaultInstance())
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x000AFA9C File Offset: 0x000ADC9C
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
			this._cultureData = cultureData;
			this.calendar = cal;
			this.InitializeOverridableProperties(cultureData, this.calendar.ID);
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x000AFADC File Offset: 0x000ADCDC
		private void InitializeOverridableProperties(CultureData cultureData, CalendarId calendarId)
		{
			if (this.firstDayOfWeek == -1)
			{
				this.firstDayOfWeek = cultureData.FirstDayOfWeek;
			}
			if (this.calendarWeekRule == -1)
			{
				this.calendarWeekRule = cultureData.CalendarWeekRule;
			}
			if (this.amDesignator == null)
			{
				this.amDesignator = cultureData.AMDesignator;
			}
			if (this.pmDesignator == null)
			{
				this.pmDesignator = cultureData.PMDesignator;
			}
			if (this.timeSeparator == null)
			{
				this.timeSeparator = cultureData.TimeSeparator;
			}
			if (this.dateSeparator == null)
			{
				this.dateSeparator = cultureData.DateSeparator(calendarId);
			}
			this.allLongTimePatterns = this._cultureData.LongTimes;
			this.allShortTimePatterns = this._cultureData.ShortTimes;
			this.allLongDatePatterns = cultureData.LongDates(calendarId);
			this.allShortDatePatterns = cultureData.ShortDates(calendarId);
			this.allYearMonthPatterns = cultureData.YearMonths(calendarId);
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x000AFBAD File Offset: 0x000ADDAD
		public static DateTimeFormatInfo InvariantInfo
		{
			get
			{
				return DateTimeFormat.InvariantFormatInfo;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x000AFBB4 File Offset: 0x000ADDB4
		public static DateTimeFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				if (!currentCulture._isInherited)
				{
					DateTimeFormatInfo dateTimeInfo = currentCulture._dateTimeInfo;
					if (dateTimeInfo != null)
					{
						return dateTimeInfo;
					}
				}
				return (DateTimeFormatInfo)currentCulture.GetFormat(typeof(DateTimeFormatInfo));
			}
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x000AFBF0 File Offset: 0x000ADDF0
		public static DateTimeFormatInfo GetInstance([Nullable(2)] IFormatProvider provider)
		{
			if (provider == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			CultureInfo cultureInfo = provider as CultureInfo;
			if (cultureInfo != null && !cultureInfo._isInherited)
			{
				return cultureInfo.DateTimeFormat;
			}
			DateTimeFormatInfo dateTimeFormatInfo = provider as DateTimeFormatInfo;
			if (dateTimeFormatInfo != null)
			{
				return dateTimeFormatInfo;
			}
			DateTimeFormatInfo dateTimeFormatInfo2 = provider.GetFormat(typeof(DateTimeFormatInfo)) as DateTimeFormatInfo;
			if (dateTimeFormatInfo2 == null)
			{
				return DateTimeFormatInfo.CurrentInfo;
			}
			return dateTimeFormatInfo2;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x000AFC4B File Offset: 0x000ADE4B
		[NullableContext(2)]
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(DateTimeFormatInfo)))
			{
				return null;
			}
			return this;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x000AFC62 File Offset: 0x000ADE62
		public object Clone()
		{
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)base.MemberwiseClone();
			dateTimeFormatInfo.calendar = (Calendar)this.Calendar.Clone();
			dateTimeFormatInfo._isReadOnly = false;
			return dateTimeFormatInfo;
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x000AFC8C File Offset: 0x000ADE8C
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x000AFCAD File Offset: 0x000ADEAD
		public string AMDesignator
		{
			get
			{
				if (this.amDesignator == null)
				{
					this.amDesignator = this._cultureData.AMDesignator;
				}
				return this.amDesignator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.ClearTokenHashTable();
				this.amDesignator = value;
				this.amDesignatorUtf8 = null;
			}
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x000AFCE4 File Offset: 0x000ADEE4
		internal ReadOnlySpan<TChar> AMDesignatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this.amDesignatorUtf8) == null)
				{
					array = (this.amDesignatorUtf8 = Encoding.UTF8.GetBytes(this.AMDesignator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this.AMDesignator);
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x000AFD4A File Offset: 0x000ADF4A
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x000AFD54 File Offset: 0x000ADF54
		public Calendar Calendar
		{
			get
			{
				return this.calendar;
			}
			[MemberNotNull("calendar")]
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value == this.calendar)
				{
					return;
				}
				for (int i = 0; i < this.OptionalCalendars.Length; i++)
				{
					if (this.OptionalCalendars[i] == value.ID)
					{
						if (this.calendar != null)
						{
							this.m_eraNames = null;
							this.m_abbrevEraNames = null;
							this.m_abbrevEnglishEraNames = null;
							this.monthDayPattern = null;
							this.dayNames = null;
							this.abbreviatedDayNames = null;
							this.m_superShortDayNames = null;
							this.monthNames = null;
							this.abbreviatedMonthNames = null;
							this.genitiveMonthNames = null;
							this.m_genitiveAbbreviatedMonthNames = null;
							this.leapYearMonthNames = null;
							this.formatFlags = DateTimeFormatFlags.NotInitialized;
							this.allShortDatePatterns = null;
							this.allLongDatePatterns = null;
							this.allYearMonthPatterns = null;
							this.dateTimeOffsetPattern = null;
							this.longDatePattern = null;
							this.shortDatePattern = null;
							this.yearMonthPattern = null;
							this.fullDateTimePattern = null;
							this.generalShortTimePattern = null;
							this.generalLongTimePattern = null;
							this.dateSeparator = null;
							this.ClearTokenHashTable();
						}
						this.calendar = value;
						this.InitializeOverridableProperties(this._cultureData, this.calendar.ID);
						return;
					}
				}
				throw new ArgumentOutOfRangeException("value", value, SR.Argument_InvalidCalendar);
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x000AFEA0 File Offset: 0x000AE0A0
		private CalendarId[] OptionalCalendars
		{
			get
			{
				CalendarId[] result;
				if ((result = this.optionalCalendars) == null)
				{
					result = (this.optionalCalendars = this._cultureData.CalendarIds);
				}
				return result;
			}
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x000AFECC File Offset: 0x000AE0CC
		public int GetEra(string eraName)
		{
			ArgumentNullException.ThrowIfNull(eraName, "eraName");
			if (eraName.Length == 0)
			{
				return -1;
			}
			for (int i = 0; i < this.EraNames.Length; i++)
			{
				if (this.m_eraNames[i].Length > 0 && this.Culture.CompareInfo.Compare(eraName, this.m_eraNames[i], CompareOptions.IgnoreCase) == 0)
				{
					return i + 1;
				}
			}
			for (int j = 0; j < this.AbbreviatedEraNames.Length; j++)
			{
				if (this.Culture.CompareInfo.Compare(eraName, this.m_abbrevEraNames[j], CompareOptions.IgnoreCase) == 0)
				{
					return j + 1;
				}
			}
			for (int k = 0; k < this.AbbreviatedEnglishEraNames.Length; k++)
			{
				if (CompareInfo.Invariant.Compare(eraName, this.m_abbrevEnglishEraNames[k], CompareOptions.IgnoreCase) == 0)
				{
					return k + 1;
				}
			}
			return -1;
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x000AFF94 File Offset: 0x000AE194
		internal string[] EraNames
		{
			get
			{
				string[] result;
				if ((result = this.m_eraNames) == null)
				{
					result = (this.m_eraNames = this._cultureData.EraNames(this.Calendar.ID));
				}
				return result;
			}
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x000AFFCC File Offset: 0x000AE1CC
		public string GetEraName(int era)
		{
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			string[] eraNames = this.EraNames;
			era--;
			if ((ulong)era >= (ulong)((long)eraNames.Length))
			{
				throw new ArgumentOutOfRangeException("era", era + 1, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			return eraNames[era];
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x000B0018 File Offset: 0x000AE218
		internal string[] AbbreviatedEraNames
		{
			get
			{
				string[] result;
				if ((result = this.m_abbrevEraNames) == null)
				{
					result = (this.m_abbrevEraNames = this._cultureData.AbbrevEraNames(this.Calendar.ID));
				}
				return result;
			}
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x000B0050 File Offset: 0x000AE250
		public string GetAbbreviatedEraName(int era)
		{
			if (this.AbbreviatedEraNames.Length == 0)
			{
				return this.GetEraName(era);
			}
			if (era == 0)
			{
				era = this.Calendar.CurrentEraValue;
			}
			string[] abbrevEraNames = this.m_abbrevEraNames;
			era--;
			if (era >= abbrevEraNames.Length)
			{
				throw new ArgumentOutOfRangeException("era", era + 1, SR.ArgumentOutOfRange_InvalidEraValue);
			}
			return abbrevEraNames[era];
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x000B00AB File Offset: 0x000AE2AB
		internal string[] AbbreviatedEnglishEraNames
		{
			get
			{
				if (this.m_abbrevEnglishEraNames == null)
				{
					this.m_abbrevEnglishEraNames = this._cultureData.AbbreviatedEnglishEraNames(this.Calendar.ID);
				}
				return this.m_abbrevEnglishEraNames;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x000B00D7 File Offset: 0x000AE2D7
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x000B0103 File Offset: 0x000AE303
		public string DateSeparator
		{
			get
			{
				if (this.dateSeparator == null)
				{
					this.dateSeparator = this._cultureData.DateSeparator(this.Calendar.ID);
				}
				return this.dateSeparator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.ClearTokenHashTable();
				this.dateSeparator = value;
				this.dateSeparatorUtf8 = null;
			}
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x000B0138 File Offset: 0x000AE338
		internal ReadOnlySpan<TChar> DateSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this.dateSeparatorUtf8) == null)
				{
					array = (this.dateSeparatorUtf8 = Encoding.UTF8.GetBytes(this.DateSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this.DateSeparator);
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x000B019E File Offset: 0x000AE39E
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x000B01C0 File Offset: 0x000AE3C0
		public DayOfWeek FirstDayOfWeek
		{
			get
			{
				if (this.firstDayOfWeek == -1)
				{
					this.firstDayOfWeek = this._cultureData.FirstDayOfWeek;
				}
				return (DayOfWeek)this.firstDayOfWeek;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				if (value < DayOfWeek.Sunday || value > DayOfWeek.Saturday)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, DayOfWeek.Sunday, DayOfWeek.Saturday));
				}
				this.firstDayOfWeek = (int)value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000B0216 File Offset: 0x000AE416
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x000B0238 File Offset: 0x000AE438
		public CalendarWeekRule CalendarWeekRule
		{
			get
			{
				if (this.calendarWeekRule == -1)
				{
					this.calendarWeekRule = this._cultureData.CalendarWeekRule;
				}
				return (CalendarWeekRule)this.calendarWeekRule;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				if (value < CalendarWeekRule.FirstDay || value > CalendarWeekRule.FirstFourDayWeek)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, CalendarWeekRule.FirstDay, CalendarWeekRule.FirstFourDayWeek));
				}
				this.calendarWeekRule = (int)value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x000B0290 File Offset: 0x000AE490
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x000B02C6 File Offset: 0x000AE4C6
		public string FullDateTimePattern
		{
			get
			{
				string result;
				if ((result = this.fullDateTimePattern) == null)
				{
					result = (this.fullDateTimePattern = this.LongDatePattern + " " + this.LongTimePattern);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.fullDateTimePattern = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x000B02F0 File Offset: 0x000AE4F0
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x000B0318 File Offset: 0x000AE518
		public string LongDatePattern
		{
			get
			{
				string result;
				if ((result = this.longDatePattern) == null)
				{
					result = (this.longDatePattern = this.UnclonedLongDatePatterns[0]);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.longDatePattern = value;
				this.OnLongDatePatternChanged();
			}
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x000B0345 File Offset: 0x000AE545
		private void OnLongDatePatternChanged()
		{
			this.ClearTokenHashTable();
			this.fullDateTimePattern = null;
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x000B0354 File Offset: 0x000AE554
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x000B037C File Offset: 0x000AE57C
		public string LongTimePattern
		{
			get
			{
				string result;
				if ((result = this.longTimePattern) == null)
				{
					result = (this.longTimePattern = this.UnclonedLongTimePatterns[0]);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.longTimePattern = value;
				this.OnLongTimePatternChanged();
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000B03A9 File Offset: 0x000AE5A9
		private void OnLongTimePatternChanged()
		{
			this.ClearTokenHashTable();
			this.fullDateTimePattern = null;
			this.generalLongTimePattern = null;
			this.dateTimeOffsetPattern = null;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x000B03C6 File Offset: 0x000AE5C6
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x000B03F2 File Offset: 0x000AE5F2
		public string MonthDayPattern
		{
			get
			{
				if (this.monthDayPattern == null)
				{
					this.monthDayPattern = this._cultureData.MonthDay(this.Calendar.ID);
				}
				return this.monthDayPattern;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.monthDayPattern = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x000B0419 File Offset: 0x000AE619
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x000B043A File Offset: 0x000AE63A
		public string PMDesignator
		{
			get
			{
				if (this.pmDesignator == null)
				{
					this.pmDesignator = this._cultureData.PMDesignator;
				}
				return this.pmDesignator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.ClearTokenHashTable();
				this.pmDesignator = value;
				this.pmDesignatorUtf8 = null;
			}
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x000B0470 File Offset: 0x000AE670
		internal ReadOnlySpan<TChar> PMDesignatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this.pmDesignatorUtf8) == null)
				{
					array = (this.pmDesignatorUtf8 = Encoding.UTF8.GetBytes(this.PMDesignator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this.PMDesignator);
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x000B04D6 File Offset: 0x000AE6D6
		public string RFC1123Pattern
		{
			get
			{
				return "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x000B04E0 File Offset: 0x000AE6E0
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x000B0508 File Offset: 0x000AE708
		public string ShortDatePattern
		{
			get
			{
				string result;
				if ((result = this.shortDatePattern) == null)
				{
					result = (this.shortDatePattern = this.UnclonedShortDatePatterns[0]);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.shortDatePattern = value;
				this.OnShortDatePatternChanged();
			}
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x000B0535 File Offset: 0x000AE735
		private void OnShortDatePatternChanged()
		{
			this.ClearTokenHashTable();
			this.generalLongTimePattern = null;
			this.generalShortTimePattern = null;
			this.dateTimeOffsetPattern = null;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x000B0554 File Offset: 0x000AE754
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x000B057C File Offset: 0x000AE77C
		public string ShortTimePattern
		{
			get
			{
				string result;
				if ((result = this.shortTimePattern) == null)
				{
					result = (this.shortTimePattern = this.UnclonedShortTimePatterns[0]);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.shortTimePattern = value;
				this.OnShortTimePatternChanged();
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x000B05A9 File Offset: 0x000AE7A9
		private void OnShortTimePatternChanged()
		{
			this.ClearTokenHashTable();
			this.generalShortTimePattern = null;
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		public string SortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x000B05C0 File Offset: 0x000AE7C0
		internal string GeneralShortTimePattern
		{
			get
			{
				string result;
				if ((result = this.generalShortTimePattern) == null)
				{
					result = (this.generalShortTimePattern = this.ShortDatePattern + " " + this.ShortTimePattern);
				}
				return result;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000B05F8 File Offset: 0x000AE7F8
		internal string GeneralLongTimePattern
		{
			get
			{
				string result;
				if ((result = this.generalLongTimePattern) == null)
				{
					result = (this.generalLongTimePattern = this.ShortDatePattern + " " + this.LongTimePattern);
				}
				return result;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x000B0630 File Offset: 0x000AE830
		internal string DateTimeOffsetPattern
		{
			get
			{
				if (this.dateTimeOffsetPattern == null)
				{
					bool flag = false;
					bool flag2 = false;
					char c = '\'';
					string text = this.LongTimePattern;
					int num = 0;
					while (!flag && num < text.Length)
					{
						char c2 = text[num];
						if (c2 <= '%')
						{
							if (c2 == '"')
							{
								goto IL_55;
							}
							if (c2 == '%')
							{
								goto IL_77;
							}
						}
						else
						{
							if (c2 == '\'')
							{
								goto IL_55;
							}
							if (c2 == '\\')
							{
								goto IL_77;
							}
							if (c2 == 'z')
							{
								flag = !flag2;
							}
						}
						IL_7D:
						num++;
						continue;
						IL_55:
						if (flag2 && c == text[num])
						{
							flag2 = false;
							goto IL_7D;
						}
						if (!flag2)
						{
							c = text[num];
							flag2 = true;
							goto IL_7D;
						}
						goto IL_7D;
						IL_77:
						num++;
						goto IL_7D;
					}
					this.dateTimeOffsetPattern = (flag ? (this.ShortDatePattern + " " + text) : (this.ShortDatePattern + " " + text + " zzz"));
				}
				return this.dateTimeOffsetPattern;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x000B0705 File Offset: 0x000AE905
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x000B0726 File Offset: 0x000AE926
		public string TimeSeparator
		{
			get
			{
				if (this.timeSeparator == null)
				{
					this.timeSeparator = this._cultureData.TimeSeparator;
				}
				return this.timeSeparator;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.ClearTokenHashTable();
				this.timeSeparator = value;
				this.timeSeparatorUtf8 = null;
			}
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x000B075C File Offset: 0x000AE95C
		internal ReadOnlySpan<TChar> TimeSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this.timeSeparatorUtf8) == null)
				{
					array = (this.timeSeparatorUtf8 = Encoding.UTF8.GetBytes(this.TimeSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this.TimeSeparator);
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x000B07C2 File Offset: 0x000AE9C2
		public string UniversalSortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x000B07CC File Offset: 0x000AE9CC
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x000B07F4 File Offset: 0x000AE9F4
		public string YearMonthPattern
		{
			get
			{
				string result;
				if ((result = this.yearMonthPattern) == null)
				{
					result = (this.yearMonthPattern = this.UnclonedYearMonthPatterns[0]);
				}
				return result;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				this.yearMonthPattern = value;
				this.OnYearMonthPatternChanged();
			}
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x000B0821 File Offset: 0x000AEA21
		private void OnYearMonthPatternChanged()
		{
			this.ClearTokenHashTable();
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x000B082C File Offset: 0x000AEA2C
		private static void CheckNullValue(string[] values, int length)
		{
			for (int i = 0; i < length; i++)
			{
				if (values[i] == null)
				{
					throw new ArgumentNullException("value", SR.ArgumentNull_ArrayValue);
				}
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x000B085A File Offset: 0x000AEA5A
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x000B086C File Offset: 0x000AEA6C
		public string[] AbbreviatedDayNames
		{
			get
			{
				return (string[])this.InternalGetAbbreviatedDayOfWeekNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.ClearTokenHashTable();
				this.abbreviatedDayNames = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x000B08CE File Offset: 0x000AEACE
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x000B08E0 File Offset: 0x000AEAE0
		public string[] ShortestDayNames
		{
			get
			{
				return (string[])this.InternalGetSuperShortDayNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.m_superShortDayNames = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x000B093C File Offset: 0x000AEB3C
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x000B0950 File Offset: 0x000AEB50
		public string[] DayNames
		{
			get
			{
				return (string[])this.InternalGetDayOfWeekNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 7)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 7), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length);
				this.ClearTokenHashTable();
				this.dayNames = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x000B09B2 File Offset: 0x000AEBB2
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x000B09C4 File Offset: 0x000AEBC4
		public string[] AbbreviatedMonthNames
		{
			get
			{
				return (string[])this.InternalGetAbbreviatedMonthNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.ClearTokenHashTable();
				this.abbreviatedMonthNames = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x000B0A2A File Offset: 0x000AEC2A
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x000B0A3C File Offset: 0x000AEC3C
		public string[] MonthNames
		{
			get
			{
				return (string[])this.InternalGetMonthNames().Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.monthNames = value;
				this.ClearTokenHashTable();
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x000B0AA2 File Offset: 0x000AECA2
		internal bool HasSpacesInMonthNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInMonthNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003650 RID: 13904 RVA: 0x000B0AAF File Offset: 0x000AECAF
		internal bool HasSpacesInDayNames
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseSpacesInDayNames) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x000B0AC0 File Offset: 0x000AECC0
		internal string InternalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			string[] array;
			if (style != MonthNameStyles.Genitive)
			{
				if (style != MonthNameStyles.LeapYear)
				{
					array = (abbreviated ? this.InternalGetAbbreviatedMonthNames() : this.InternalGetMonthNames());
				}
				else
				{
					array = this.InternalGetLeapYearMonthNames();
				}
			}
			else
			{
				array = this.InternalGetGenitiveMonthNames(abbreviated);
			}
			string[] array2 = array;
			month--;
			if (month >= array2.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<int>("month", month + 1, 1, array2.Length);
			}
			return array2[month];
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x000B0B20 File Offset: 0x000AED20
		internal string[] InternalGetGenitiveMonthNames(bool abbreviated)
		{
			if (abbreviated)
			{
				if (this.m_genitiveAbbreviatedMonthNames == null)
				{
					this.m_genitiveAbbreviatedMonthNames = this._cultureData.AbbreviatedGenitiveMonthNames(this.Calendar.ID);
				}
				return this.m_genitiveAbbreviatedMonthNames;
			}
			if (this.genitiveMonthNames == null)
			{
				this.genitiveMonthNames = this._cultureData.GenitiveMonthNames(this.Calendar.ID);
			}
			return this.genitiveMonthNames;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x000B0B85 File Offset: 0x000AED85
		internal string[] InternalGetLeapYearMonthNames()
		{
			if (this.leapYearMonthNames == null)
			{
				this.leapYearMonthNames = this._cultureData.LeapYearMonthNames(this.Calendar.ID);
			}
			return this.leapYearMonthNames;
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000B0BB4 File Offset: 0x000AEDB4
		public string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			string[] array = this.InternalGetAbbreviatedDayOfWeekNames();
			if (dayofweek >= (DayOfWeek)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<DayOfWeek>("dayofweek", dayofweek, DayOfWeek.Sunday, DayOfWeek.Saturday);
			}
			return array[(int)dayofweek];
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x000B0BE0 File Offset: 0x000AEDE0
		public string GetShortestDayName(DayOfWeek dayOfWeek)
		{
			string[] array = this.InternalGetSuperShortDayNames();
			if (dayOfWeek >= (DayOfWeek)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<DayOfWeek>("dayOfWeek", dayOfWeek, DayOfWeek.Sunday, DayOfWeek.Saturday);
			}
			return array[(int)dayOfWeek];
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x000B0C0C File Offset: 0x000AEE0C
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			string[] array = new string[patterns1.Length * patterns2.Length];
			int num = 0;
			for (int i = 0; i < patterns1.Length; i++)
			{
				for (int j = 0; j < patterns2.Length; j++)
				{
					array[num++] = patterns1[i] + connectString + patterns2[j];
				}
			}
			return array;
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x000B0C58 File Offset: 0x000AEE58
		public string[] GetAllDateTimePatterns()
		{
			List<string> list = new List<string>(132);
			foreach (char format in "dDfFgGmMoOrRstTuUyY")
			{
				foreach (string item in this.GetAllDateTimePatterns(format))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
		public string[] GetAllDateTimePatterns(char format)
		{
			if (format <= 'U')
			{
				switch (format)
				{
				case 'D':
					return this.AllLongDatePatterns;
				case 'E':
					goto IL_1AD;
				case 'F':
					break;
				case 'G':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllLongTimePatterns, " ");
				default:
					switch (format)
					{
					case 'M':
						goto IL_13B;
					case 'N':
					case 'P':
					case 'Q':
					case 'S':
						goto IL_1AD;
					case 'O':
						goto IL_14D;
					case 'R':
						goto IL_15E;
					case 'T':
						return this.AllLongTimePatterns;
					case 'U':
						break;
					default:
						goto IL_1AD;
					}
					break;
				}
				return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllLongTimePatterns, " ");
			}
			if (format != 'Y')
			{
				switch (format)
				{
				case 'd':
					return this.AllShortDatePatterns;
				case 'e':
					goto IL_1AD;
				case 'f':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllLongDatePatterns, this.AllShortTimePatterns, " ");
				case 'g':
					return DateTimeFormatInfo.GetCombinedPatterns(this.AllShortDatePatterns, this.AllShortTimePatterns, " ");
				default:
					switch (format)
					{
					case 'm':
						goto IL_13B;
					case 'n':
					case 'p':
					case 'q':
					case 'v':
					case 'w':
					case 'x':
						goto IL_1AD;
					case 'o':
						goto IL_14D;
					case 'r':
						goto IL_15E;
					case 's':
						return new string[]
						{
							"yyyy'-'MM'-'dd'T'HH':'mm':'ss"
						};
					case 't':
						return this.AllShortTimePatterns;
					case 'u':
						return new string[]
						{
							"yyyy'-'MM'-'dd HH':'mm':'ss'Z'"
						};
					case 'y':
						break;
					default:
						goto IL_1AD;
					}
					break;
				}
			}
			return this.AllYearMonthPatterns;
			IL_13B:
			return new string[]
			{
				this.MonthDayPattern
			};
			IL_14D:
			return new string[]
			{
				"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"
			};
			IL_15E:
			return new string[]
			{
				"ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"
			};
			IL_1AD:
			throw new ArgumentException(SR.Format(SR.Format_BadFormatSpecifier, format), "format");
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000B0E98 File Offset: 0x000AF098
		public string GetDayName(DayOfWeek dayofweek)
		{
			string[] array = this.InternalGetDayOfWeekNames();
			if (dayofweek >= (DayOfWeek)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<DayOfWeek>("dayofweek", dayofweek, DayOfWeek.Sunday, DayOfWeek.Saturday);
			}
			return array[(int)dayofweek];
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x000B0EC4 File Offset: 0x000AF0C4
		public string GetAbbreviatedMonthName(int month)
		{
			string[] array = this.InternalGetAbbreviatedMonthNames();
			month--;
			if (month >= array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<int>("month", month + 1, 1, 13);
			}
			return array[month];
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x000B0EF8 File Offset: 0x000AF0F8
		public string GetMonthName(int month)
		{
			string[] array = this.InternalGetMonthNames();
			month--;
			if (month >= array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Range<int>("month", month + 1, 1, 13);
			}
			return array[month];
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000B0F2C File Offset: 0x000AF12C
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			if (defaultPattern == patterns[0])
			{
				return (string[])patterns.Clone();
			}
			int num = 0;
			while (num < patterns.Length && !(defaultPattern == patterns[num]))
			{
				num++;
			}
			string[] array;
			if (num < patterns.Length)
			{
				array = (string[])patterns.Clone();
				array[num] = array[0];
			}
			else
			{
				array = new string[patterns.Length + 1];
				Array.Copy(patterns, 0, array, 1, patterns.Length);
			}
			array[0] = defaultPattern;
			return array;
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x000B0F9F File Offset: 0x000AF19F
		private string[] AllYearMonthPatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedYearMonthPatterns, this.YearMonthPattern);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x000B0FB2 File Offset: 0x000AF1B2
		private string[] AllShortDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortDatePatterns, this.ShortDatePattern);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x000B0FC5 File Offset: 0x000AF1C5
		private string[] AllShortTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedShortTimePatterns, this.ShortTimePattern);
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x000B0FD8 File Offset: 0x000AF1D8
		private string[] AllLongDatePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongDatePatterns, this.LongDatePattern);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x000B0FEB File Offset: 0x000AF1EB
		private string[] AllLongTimePatterns
		{
			get
			{
				return DateTimeFormatInfo.GetMergedPatterns(this.UnclonedLongTimePatterns, this.LongTimePattern);
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x000B0FFE File Offset: 0x000AF1FE
		private string[] UnclonedYearMonthPatterns
		{
			get
			{
				if (this.allYearMonthPatterns == null)
				{
					this.allYearMonthPatterns = this._cultureData.YearMonths(this.Calendar.ID);
				}
				return this.allYearMonthPatterns;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x000B102A File Offset: 0x000AF22A
		private string[] UnclonedShortDatePatterns
		{
			get
			{
				if (this.allShortDatePatterns == null)
				{
					this.allShortDatePatterns = this._cultureData.ShortDates(this.Calendar.ID);
				}
				return this.allShortDatePatterns;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x000B1056 File Offset: 0x000AF256
		private string[] UnclonedLongDatePatterns
		{
			get
			{
				if (this.allLongDatePatterns == null)
				{
					this.allLongDatePatterns = this._cultureData.LongDates(this.Calendar.ID);
				}
				return this.allLongDatePatterns;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x000B1082 File Offset: 0x000AF282
		private string[] UnclonedShortTimePatterns
		{
			get
			{
				if (this.allShortTimePatterns == null)
				{
					this.allShortTimePatterns = this._cultureData.ShortTimes;
				}
				return this.allShortTimePatterns;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x000B10A3 File Offset: 0x000AF2A3
		private string[] UnclonedLongTimePatterns
		{
			get
			{
				if (this.allLongTimePatterns == null)
				{
					this.allLongTimePatterns = this._cultureData.LongTimes;
				}
				return this.allLongTimePatterns;
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x000B10C4 File Offset: 0x000AF2C4
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			ArgumentNullException.ThrowIfNull(dtfi, "dtfi");
			if (dtfi.IsReadOnly)
			{
				return dtfi;
			}
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)dtfi.MemberwiseClone();
			dateTimeFormatInfo.calendar = Calendar.ReadOnly(dtfi.Calendar);
			dateTimeFormatInfo._isReadOnly = true;
			return dateTimeFormatInfo;
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x000B10FE File Offset: 0x000AF2FE
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x000B1106 File Offset: 0x000AF306
		public string NativeCalendarName
		{
			get
			{
				return this._cultureData.CalendarName(this.Calendar.ID);
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x000B1120 File Offset: 0x000AF320
		public void SetAllDateTimePatterns(string[] patterns, char format)
		{
			if (this.IsReadOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
			ArgumentNullException.ThrowIfNull(patterns, "patterns");
			if (patterns.Length == 0)
			{
				throw new ArgumentException(SR.Arg_ArrayZeroError, "patterns");
			}
			for (int i = 0; i < patterns.Length; i++)
			{
				if (patterns[i] == null)
				{
					throw new ArgumentNullException("patterns[" + i.ToString() + "]", SR.ArgumentNull_ArrayValue);
				}
			}
			if (format <= 'Y')
			{
				if (format == 'D')
				{
					this.allLongDatePatterns = patterns;
					this.longDatePattern = this.allLongDatePatterns[0];
					this.OnLongDatePatternChanged();
					return;
				}
				if (format == 'T')
				{
					this.allLongTimePatterns = patterns;
					this.longTimePattern = this.allLongTimePatterns[0];
					this.OnLongTimePatternChanged();
					return;
				}
				if (format != 'Y')
				{
					goto IL_122;
				}
			}
			else
			{
				if (format == 'd')
				{
					this.allShortDatePatterns = patterns;
					this.shortDatePattern = this.allShortDatePatterns[0];
					this.OnShortDatePatternChanged();
					return;
				}
				if (format == 't')
				{
					this.allShortTimePatterns = patterns;
					this.shortTimePattern = this.allShortTimePatterns[0];
					this.OnShortTimePatternChanged();
					return;
				}
				if (format != 'y')
				{
					goto IL_122;
				}
			}
			this.allYearMonthPatterns = patterns;
			this.yearMonthPattern = this.allYearMonthPatterns[0];
			this.OnYearMonthPatternChanged();
			return;
			IL_122:
			throw new ArgumentException(SR.Format(SR.Format_BadFormatSpecifier, format), "format");
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x000B1269 File Offset: 0x000AF469
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x000B127C File Offset: 0x000AF47C
		public string[] AbbreviatedMonthGenitiveNames
		{
			get
			{
				return (string[])this.InternalGetGenitiveMonthNames(true).Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.ClearTokenHashTable();
				this.m_genitiveAbbreviatedMonthNames = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x000B12E2 File Offset: 0x000AF4E2
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x000B12F8 File Offset: 0x000AF4F8
		public string[] MonthGenitiveNames
		{
			get
			{
				return (string[])this.InternalGetGenitiveMonthNames(false).Clone();
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
				}
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value.Length != 13)
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidArrayLength, 13), "value");
				}
				DateTimeFormatInfo.CheckNullValue(value, value.Length - 1);
				this.genitiveMonthNames = value;
				this.ClearTokenHashTable();
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x000B1360 File Offset: 0x000AF560
		internal string DecimalSeparator
		{
			get
			{
				string result;
				if ((result = this._decimalSeparator) == null)
				{
					result = (this._decimalSeparator = new NumberFormatInfo(this._cultureData.UseUserOverride ? CultureData.GetCultureData(this._cultureData.CultureName, false) : this._cultureData).NumberDecimalSeparator);
				}
				return result;
			}
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x000B13B0 File Offset: 0x000AF5B0
		internal ReadOnlySpan<TChar> DecimalSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._decimalSeparatorUtf8) == null)
				{
					array = (this._decimalSeparatorUtf8 = Encoding.UTF8.GetBytes(this.DecimalSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this.DecimalSeparator);
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x000B1418 File Offset: 0x000AF618
		internal string FullTimeSpanPositivePattern
		{
			get
			{
				string result;
				if ((result = this._fullTimeSpanPositivePattern) == null)
				{
					result = (this._fullTimeSpanPositivePattern = "d':'h':'mm':'ss'" + this.DecimalSeparator + "'FFFFFFF");
				}
				return result;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x000B1450 File Offset: 0x000AF650
		internal string FullTimeSpanNegativePattern
		{
			get
			{
				string result;
				if ((result = this._fullTimeSpanNegativePattern) == null)
				{
					result = (this._fullTimeSpanNegativePattern = "'-'" + this.FullTimeSpanPositivePattern);
				}
				return result;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x000B1480 File Offset: 0x000AF680
		internal CompareInfo CompareInfo
		{
			get
			{
				CompareInfo result;
				if ((result = this._compareInfo) == null)
				{
					result = (this._compareInfo = CompareInfo.GetCompareInfo(this._cultureData.SortName));
				}
				return result;
			}
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x000B14B0 File Offset: 0x000AF6B0
		internal static void ValidateStyles(DateTimeStyles style, bool styles = false)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None || (style & (DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal)) == (DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal) || (style & (DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) > DateTimeStyles.RoundtripKind)
			{
				DateTimeFormatInfo.<ValidateStyles>g__ThrowInvalid|229_0(style, styles);
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x000B14D8 File Offset: 0x000AF6D8
		internal DateTimeFormatFlags FormatFlags
		{
			get
			{
				if (this.formatFlags == DateTimeFormatFlags.NotInitialized)
				{
					return this.InitializeFormatFlags();
				}
				return this.formatFlags;
			}
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x000B14F0 File Offset: 0x000AF6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			this.formatFlags = (DateTimeFormatFlags)(DateTimeFormatInfoScanner.GetFormatFlagGenitiveMonth(this.MonthNames, this.InternalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.InternalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInMonthNames(this.MonthNames, this.InternalGetGenitiveMonthNames(false), this.AbbreviatedMonthNames, this.InternalGetGenitiveMonthNames(true)) | DateTimeFormatInfoScanner.GetFormatFlagUseSpaceInDayNames(this.DayNames, this.AbbreviatedDayNames) | DateTimeFormatInfoScanner.GetFormatFlagUseHebrewCalendar((int)this.Calendar.ID));
			return this.formatFlags;
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x000B156C File Offset: 0x000AF76C
		internal bool HasForceTwoDigitYears
		{
			get
			{
				CalendarId id = this.calendar.ID;
				return id - CalendarId.JAPAN <= 1;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x000B1592 File Offset: 0x000AF792
		internal bool HasYearMonthAdjustment
		{
			get
			{
				return (this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) > DateTimeFormatFlags.None;
			}
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x000B15A0 File Offset: 0x000AF7A0
		internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			if ((this.FormatFlags & DateTimeFormatFlags.UseHebrewRule) != DateTimeFormatFlags.None)
			{
				if (year < 1000)
				{
					year += 5000;
				}
				if (year < this.Calendar.GetYear(this.Calendar.MinSupportedDateTime) || year > this.Calendar.GetYear(this.Calendar.MaxSupportedDateTime))
				{
					return false;
				}
				if (parsedMonthName && !this.Calendar.IsLeapYear(year))
				{
					if (month >= 8)
					{
						month--;
					}
					else if (month == 7)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x000B1628 File Offset: 0x000AF828
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_jajpDTFI;
			if (dateTimeFormat == null)
			{
				dateTimeFormat = new CultureInfo("ja-JP", false).DateTimeFormat;
				dateTimeFormat.Calendar = JapaneseCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_jajpDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000B1664 File Offset: 0x000AF864
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			DateTimeFormatInfo dateTimeFormat = DateTimeFormatInfo.s_zhtwDTFI;
			if (dateTimeFormat == null)
			{
				dateTimeFormat = new CultureInfo("zh-TW", false).DateTimeFormat;
				dateTimeFormat.Calendar = TaiwanCalendar.GetDefaultInstance();
				DateTimeFormatInfo.s_zhtwDTFI = dateTimeFormat;
			}
			return dateTimeFormat;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000B169D File Offset: 0x000AF89D
		private void ClearTokenHashTable()
		{
			this._dtfiTokenHash = null;
			this.formatFlags = DateTimeFormatFlags.NotInitialized;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x000B16B0 File Offset: 0x000AF8B0
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash;
			if (array == null)
			{
				array = new DateTimeFormatInfo.TokenHashValue[199];
				string b = this.TimeSeparator.Trim();
				if ("," != b)
				{
					this.InsertHash(array, ",", TokenType.IgnorableSymbol, 0);
				}
				if ("." != b)
				{
					this.InsertHash(array, ".", TokenType.IgnorableSymbol, 0);
				}
				if ("시" != b && "時" != b && "时" != b)
				{
					this.InsertHash(array, this.TimeSeparator, TokenType.SEP_Time, 0);
				}
				if (this._name == "fr-CA")
				{
					this.InsertHash(array, " h", TokenType.SEP_HourSuff, 0);
					this.InsertHash(array, " h ", TokenType.SEP_HourSuff, 0);
					this.InsertHash(array, " min", TokenType.SEP_MinuteSuff, 0);
					this.InsertHash(array, " min ", TokenType.SEP_MinuteSuff, 0);
					this.InsertHash(array, " s", TokenType.SEP_SecondSuff, 0);
					this.InsertHash(array, " s ", TokenType.SEP_SecondSuff, 0);
				}
				this.InsertHash(array, this.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, this.PMDesignator, (TokenType)1284, 1);
				if (this.LanguageName.Equals("sq"))
				{
					this.InsertHash(array, "." + this.AMDesignator, (TokenType)1027, 0);
					this.InsertHash(array, "." + this.PMDesignator, (TokenType)1284, 1);
				}
				this.InsertHash(array, "年", TokenType.SEP_YearSuff, 0);
				this.InsertHash(array, "년", TokenType.SEP_YearSuff, 0);
				this.InsertHash(array, "月", TokenType.SEP_MonthSuff, 0);
				this.InsertHash(array, "월", TokenType.SEP_MonthSuff, 0);
				this.InsertHash(array, "日", TokenType.SEP_DaySuff, 0);
				this.InsertHash(array, "일", TokenType.SEP_DaySuff, 0);
				this.InsertHash(array, "時", TokenType.SEP_HourSuff, 0);
				this.InsertHash(array, "时", TokenType.SEP_HourSuff, 0);
				this.InsertHash(array, "分", TokenType.SEP_MinuteSuff, 0);
				this.InsertHash(array, "秒", TokenType.SEP_SecondSuff, 0);
				if (!LocalAppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == CalendarId.JAPAN)
				{
					this.InsertHash(array, "元", TokenType.YearNumberToken, 1);
					this.InsertHash(array, "(", TokenType.IgnorableSymbol, 0);
					this.InsertHash(array, ")", TokenType.IgnorableSymbol, 0);
				}
				if (this.LanguageName.Equals("ko"))
				{
					this.InsertHash(array, "시", TokenType.SEP_HourSuff, 0);
					this.InsertHash(array, "분", TokenType.SEP_MinuteSuff, 0);
					this.InsertHash(array, "초", TokenType.SEP_SecondSuff, 0);
				}
				if (this.LanguageName.Equals("ky"))
				{
					this.InsertHash(array, "-", TokenType.IgnorableSymbol, 0);
				}
				else
				{
					this.InsertHash(array, "-", TokenType.SEP_DateOrOffset, 0);
				}
				string[] dateWordsOfDTFI = new DateTimeFormatInfoScanner().GetDateWordsOfDTFI(this);
				DateTimeFormatFlags dateTimeFormatFlags = this.FormatFlags;
				bool flag = false;
				if (dateWordsOfDTFI != null)
				{
					for (int i = 0; i < dateWordsOfDTFI.Length; i++)
					{
						char c = dateWordsOfDTFI[i][0];
						if (c != '')
						{
							if (c != '')
							{
								this.InsertHash(array, dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
								if (this.LanguageName.Equals("eu"))
								{
									this.InsertHash(array, "." + dateWordsOfDTFI[i], TokenType.DateWordToken, 0);
								}
							}
							else
							{
								string text = dateWordsOfDTFI[i].Substring(1);
								this.InsertHash(array, text, TokenType.IgnorableSymbol, 0);
								if (this.DateSeparator.Trim().Equals(text))
								{
									flag = true;
								}
							}
						}
						else
						{
							ReadOnlySpan<char> monthPostfix = dateWordsOfDTFI[i].AsSpan(1);
							this.AddMonthNames(array, monthPostfix);
						}
					}
				}
				if (!flag)
				{
					this.InsertHash(array, this.DateSeparator, TokenType.SEP_Date, 0);
				}
				this.AddMonthNames(array, default(ReadOnlySpan<char>));
				for (int j = 1; j <= 13; j++)
				{
					this.InsertHash(array, this.GetAbbreviatedMonthName(j), TokenType.MonthToken, j);
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					string[] array2 = this.InternalGetGenitiveMonthNames(false);
					string[] array3 = this.InternalGetGenitiveMonthNames(true);
					for (int k = 1; k <= 13; k++)
					{
						this.InsertHash(array, array2[k - 1], TokenType.MonthToken, k);
						this.InsertHash(array, array3[k - 1], TokenType.MonthToken, k);
					}
				}
				if ((this.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					for (int l = 1; l <= 13; l++)
					{
						string str = this.InternalGetMonthName(l, MonthNameStyles.LeapYear, false);
						this.InsertHash(array, str, TokenType.MonthToken, l);
					}
				}
				for (int m = 0; m < 7; m++)
				{
					string str2 = this.GetDayName((DayOfWeek)m);
					this.InsertHash(array, str2, TokenType.DayOfWeekToken, m);
					str2 = this.GetAbbreviatedDayName((DayOfWeek)m);
					this.InsertHash(array, str2, TokenType.DayOfWeekToken, m);
				}
				int[] eras = this.calendar.Eras;
				for (int n = 1; n <= eras.Length; n++)
				{
					this.InsertHash(array, this.GetEraName(n), TokenType.EraToken, n);
					this.InsertHash(array, this.GetAbbreviatedEraName(n), TokenType.EraToken, n);
				}
				if (!GlobalizationMode.Invariant)
				{
					if (this.LanguageName.Equals("ja"))
					{
						for (int num = 0; num < 7; num++)
						{
							string str3 = "(" + this.GetAbbreviatedDayName((DayOfWeek)num) + ")";
							this.InsertHash(array, str3, TokenType.DayOfWeekToken, num);
						}
						if (this.Calendar.GetType() != typeof(JapaneseCalendar))
						{
							DateTimeFormatInfo japaneseCalendarDTFI = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
							for (int num2 = 1; num2 <= japaneseCalendarDTFI.Calendar.Eras.Length; num2++)
							{
								this.InsertHash(array, japaneseCalendarDTFI.GetEraName(num2), TokenType.JapaneseEraToken, num2);
								this.InsertHash(array, japaneseCalendarDTFI.GetAbbreviatedEraName(num2), TokenType.JapaneseEraToken, num2);
								this.InsertHash(array, japaneseCalendarDTFI.AbbreviatedEnglishEraNames[num2 - 1], TokenType.JapaneseEraToken, num2);
							}
						}
					}
					else if (this.CultureName.Equals("zh-TW"))
					{
						DateTimeFormatInfo taiwanCalendarDTFI = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
						for (int num3 = 1; num3 <= taiwanCalendarDTFI.Calendar.Eras.Length; num3++)
						{
							if (taiwanCalendarDTFI.GetEraName(num3).Length > 0)
							{
								this.InsertHash(array, taiwanCalendarDTFI.GetEraName(num3), TokenType.TEraToken, num3);
							}
						}
					}
				}
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.AMDesignator, (TokenType)1027, 0);
				this.InsertHash(array, DateTimeFormatInfo.InvariantInfo.PMDesignator, (TokenType)1284, 1);
				for (int num4 = 1; num4 <= 12; num4++)
				{
					string str4 = DateTimeFormatInfo.InvariantInfo.GetMonthName(num4);
					this.InsertHash(array, str4, TokenType.MonthToken, num4);
					str4 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(num4);
					this.InsertHash(array, str4, TokenType.MonthToken, num4);
				}
				for (int num5 = 0; num5 < 7; num5++)
				{
					string str5 = DateTimeFormatInfo.InvariantInfo.GetDayName((DayOfWeek)num5);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num5);
					str5 = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedDayName((DayOfWeek)num5);
					this.InsertHash(array, str5, TokenType.DayOfWeekToken, num5);
				}
				for (int num6 = 0; num6 < this.AbbreviatedEnglishEraNames.Length; num6++)
				{
					this.InsertHash(array, this.AbbreviatedEnglishEraNames[num6], TokenType.EraToken, num6 + 1);
				}
				this.InsertHash(array, "T", TokenType.SEP_LocalTimeMark, 0);
				this.InsertHash(array, "GMT", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "Z", TokenType.TimeZoneToken, 0);
				this.InsertHash(array, "/", TokenType.SEP_Date, 0);
				this.InsertHash(array, ":", TokenType.SEP_Time, 0);
				this._dtfiTokenHash = array;
			}
			return array;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x000B1E48 File Offset: 0x000B0048
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, ReadOnlySpan<char> monthPostfix = default(ReadOnlySpan<char>))
		{
			for (int i = 1; i <= 13; i++)
			{
				string text = this.GetMonthName(i);
				if (text.Length > 0)
				{
					if (!monthPostfix.IsEmpty)
					{
						this.InsertHash(temp, text + monthPostfix, TokenType.MonthToken, i);
					}
					else
					{
						this.InsertHash(temp, text, TokenType.MonthToken, i);
					}
				}
				text = this.GetAbbreviatedMonthName(i);
				this.InsertHash(temp, text, TokenType.MonthToken, i);
			}
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x000B1EB0 File Offset: 0x000B00B0
		private unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			number = -1;
			badFormat = false;
			int index = str.Index;
			if (!HebrewNumber.IsDigit((char)(*str.Value[index])))
			{
				return false;
			}
			HebrewNumberParsingContext hebrewNumberParsingContext = new HebrewNumberParsingContext(0);
			HebrewNumberParsingState hebrewNumberParsingState;
			for (;;)
			{
				hebrewNumberParsingState = HebrewNumber.ParseByChar((char)(*str.Value[index++]), ref hebrewNumberParsingContext);
				if (hebrewNumberParsingState <= HebrewNumberParsingState.NotHebrewDigit)
				{
					break;
				}
				if (index >= str.Value.Length || hebrewNumberParsingState == HebrewNumberParsingState.FoundEndOfHebrewNumber)
				{
					goto IL_5C;
				}
			}
			return false;
			IL_5C:
			if (hebrewNumberParsingState != HebrewNumberParsingState.FoundEndOfHebrewNumber)
			{
				return false;
			}
			str.Advance(index - str.Index);
			number = hebrewNumberParsingContext.result;
			return true;
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x000B1F37 File Offset: 0x000B0137
		private static bool IsHebrewChar(char ch)
		{
			return ch >= '֐' && ch <= '׿';
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x000B1F50 File Offset: 0x000B0150
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			return !LocalAppContextSwitches.EnforceLegacyJapaneseDateParsing && this.Calendar.ID == CalendarId.JAPAN && (nextCh == "元"[0] || (tokenString == "元" && nextCh == "年"[0]));
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x000B1FA0 File Offset: 0x000B01A0
		internal unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			tokenType = TokenType.UnknownToken;
			tokenValue = 0;
			char c = str.m_current;
			bool flag = char.IsLetter(c);
			if (flag)
			{
				c = this.Culture.TextInfo.ToLower(c);
				bool flag2;
				if (!GlobalizationMode.Invariant && DateTimeFormatInfo.IsHebrewChar(c) && TokenMask == TokenType.RegularTokenMask && DateTimeFormatInfo.TryParseHebrewNumber(ref str, out flag2, out tokenValue))
				{
					if (flag2)
					{
						tokenType = TokenType.UnknownToken;
						return false;
					}
					tokenType = TokenType.HebrewNumber;
					return true;
				}
			}
			int num = (int)(c % 'Ç');
			int num2 = (int)('\u0001' + c % 'Å');
			int num3 = str.Length - str.Index;
			int num4 = 0;
			DateTimeFormatInfo.TokenHashValue[] array = this._dtfiTokenHash ?? this.CreateTokenHashTable();
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			int count;
			for (;;)
			{
				tokenHashValue = array[num];
				if (tokenHashValue == null)
				{
					return false;
				}
				if ((tokenHashValue.tokenType & TokenMask) > (TokenType)0 && tokenHashValue.tokenString.Length <= num3)
				{
					bool flag3 = true;
					if (flag)
					{
						int num5 = str.Index + tokenHashValue.tokenString.Length;
						if (num5 > str.Length)
						{
							flag3 = false;
						}
						else if (num5 < str.Length)
						{
							char c2 = (char)(*str.Value[num5]);
							flag3 = (!char.IsLetter(c2) || this.IsAllowedJapaneseTokenFollowedByNonSpaceLetter(tokenHashValue.tokenString, c2));
						}
					}
					if (flag3 && ((tokenHashValue.tokenString.Length == 1 && *str.Value[str.Index] == (ushort)tokenHashValue.tokenString[0]) || this.Culture.CompareInfo.Compare(str.Value.Slice(str.Index, tokenHashValue.tokenString.Length), tokenHashValue.tokenString, CompareOptions.IgnoreCase) == 0))
					{
						break;
					}
					if ((tokenHashValue.tokenType == TokenType.MonthToken && this.HasSpacesInMonthNames) || (tokenHashValue.tokenType == TokenType.DayOfWeekToken && this.HasSpacesInDayNames))
					{
						count = 0;
						if (str.MatchSpecifiedWords(tokenHashValue.tokenString, true, ref count))
						{
							goto Block_19;
						}
					}
				}
				num4++;
				num += num2;
				if (num >= 199)
				{
					num -= 199;
				}
				if (num4 >= 199)
				{
					return false;
				}
			}
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(tokenHashValue.tokenString.Length);
			return true;
			Block_19:
			tokenType = (tokenHashValue.tokenType & TokenMask);
			tokenValue = tokenHashValue.tokenValue;
			str.Advance(count);
			return true;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x000B21EC File Offset: 0x000B03EC
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			DateTimeFormatInfo.TokenHashValue tokenHashValue = hashTable[hashcode];
			hashTable[hashcode] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			while (++pos < 199)
			{
				hashcode += hashProbe;
				if (hashcode >= 199)
				{
					hashcode -= 199;
				}
				DateTimeFormatInfo.TokenHashValue tokenHashValue2 = hashTable[hashcode];
				if (tokenHashValue2 == null || this.Culture.TextInfo.ToLower(tokenHashValue2.tokenString[0]) == ch)
				{
					hashTable[hashcode] = tokenHashValue;
					if (tokenHashValue2 == null)
					{
						return;
					}
					tokenHashValue = tokenHashValue2;
				}
			}
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x000B2268 File Offset: 0x000B0468
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
		{
			if (string.IsNullOrEmpty(str))
			{
				return;
			}
			int num = 0;
			if (!char.IsWhiteSpace(str[0]))
			{
				string text = str;
				if (!char.IsWhiteSpace(text[text.Length - 1]))
				{
					goto IL_3F;
				}
			}
			str = str.Trim();
			if (str.Length == 0)
			{
				return;
			}
			IL_3F:
			char c = this.Culture.TextInfo.ToLower(str[0]);
			int num2 = (int)(c % 'Ç');
			int num3 = (int)('\u0001' + c % 'Å');
			DateTimeFormatInfo.TokenHashValue tokenHashValue;
			for (;;)
			{
				tokenHashValue = hashTable[num2];
				if (tokenHashValue == null)
				{
					break;
				}
				if (str.Length >= tokenHashValue.tokenString.Length && this.CompareStringIgnoreCaseOptimized(str, 0, tokenHashValue.tokenString.Length, tokenHashValue.tokenString, 0, tokenHashValue.tokenString.Length))
				{
					goto Block_6;
				}
				num++;
				num2 += num3;
				if (num2 >= 199)
				{
					num2 -= 199;
				}
				if (num >= 199)
				{
					return;
				}
			}
			hashTable[num2] = new DateTimeFormatInfo.TokenHashValue(str, tokenType, tokenValue);
			return;
			Block_6:
			if (str.Length > tokenHashValue.tokenString.Length)
			{
				this.InsertAtCurrentHashNode(hashTable, str, c, tokenType, tokenValue, num, num2, num3);
				return;
			}
			int tokenType2 = (int)tokenHashValue.tokenType;
			if (((tokenType2 & 255) == 0 && (tokenType & TokenType.RegularTokenMask) != (TokenType)0) || ((tokenType2 & 65280) == 0 && (tokenType & TokenType.SeparatorTokenMask) != (TokenType)0))
			{
				tokenHashValue.tokenType |= tokenType;
				if (tokenValue != 0)
				{
					tokenHashValue.tokenValue = tokenValue;
				}
			}
			return;
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x000B23C6 File Offset: 0x000B05C6
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return (length1 == 1 && length2 == 1 && string1[offset1] == string2[offset2]) || this.Culture.CompareInfo.Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x000B2402 File Offset: 0x000B0602
		[CompilerGenerated]
		internal static void <ValidateStyles>g__ThrowInvalid|229_0(DateTimeStyles style, bool styles)
		{
			throw new ArgumentException(((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None) ? SR.Argument_InvalidDateTimeStyles : (((style & (DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal)) == (DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal)) ? SR.Argument_ConflictingDateTimeStyles : SR.Argument_ConflictingDateTimeRoundtripStyles), styles ? "styles" : "style");
		}

		// Token: 0x04000A15 RID: 2581
		private readonly CultureData _cultureData;

		// Token: 0x04000A16 RID: 2582
		private string _name;

		// Token: 0x04000A17 RID: 2583
		private string _langName;

		// Token: 0x04000A18 RID: 2584
		private CompareInfo _compareInfo;

		// Token: 0x04000A19 RID: 2585
		private CultureInfo _cultureInfo;

		// Token: 0x04000A1A RID: 2586
		private string amDesignator;

		// Token: 0x04000A1B RID: 2587
		private string pmDesignator;

		// Token: 0x04000A1C RID: 2588
		private string dateSeparator;

		// Token: 0x04000A1D RID: 2589
		private string generalShortTimePattern;

		// Token: 0x04000A1E RID: 2590
		private string generalLongTimePattern;

		// Token: 0x04000A1F RID: 2591
		private string timeSeparator;

		// Token: 0x04000A20 RID: 2592
		private string monthDayPattern;

		// Token: 0x04000A21 RID: 2593
		private string dateTimeOffsetPattern;

		// Token: 0x04000A22 RID: 2594
		private byte[] amDesignatorUtf8;

		// Token: 0x04000A23 RID: 2595
		private byte[] pmDesignatorUtf8;

		// Token: 0x04000A24 RID: 2596
		private byte[] timeSeparatorUtf8;

		// Token: 0x04000A25 RID: 2597
		private byte[] dateSeparatorUtf8;

		// Token: 0x04000A26 RID: 2598
		private Calendar calendar;

		// Token: 0x04000A27 RID: 2599
		private int firstDayOfWeek = -1;

		// Token: 0x04000A28 RID: 2600
		private int calendarWeekRule = -1;

		// Token: 0x04000A29 RID: 2601
		private string fullDateTimePattern;

		// Token: 0x04000A2A RID: 2602
		private string[] abbreviatedDayNames;

		// Token: 0x04000A2B RID: 2603
		private string[] m_superShortDayNames;

		// Token: 0x04000A2C RID: 2604
		private string[] dayNames;

		// Token: 0x04000A2D RID: 2605
		private string[] abbreviatedMonthNames;

		// Token: 0x04000A2E RID: 2606
		private string[] monthNames;

		// Token: 0x04000A2F RID: 2607
		private string[] genitiveMonthNames;

		// Token: 0x04000A30 RID: 2608
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x04000A31 RID: 2609
		private string[] leapYearMonthNames;

		// Token: 0x04000A32 RID: 2610
		private string longDatePattern;

		// Token: 0x04000A33 RID: 2611
		private string shortDatePattern;

		// Token: 0x04000A34 RID: 2612
		private string yearMonthPattern;

		// Token: 0x04000A35 RID: 2613
		private string longTimePattern;

		// Token: 0x04000A36 RID: 2614
		private string shortTimePattern;

		// Token: 0x04000A37 RID: 2615
		private string[] allYearMonthPatterns;

		// Token: 0x04000A38 RID: 2616
		private string[] allShortDatePatterns;

		// Token: 0x04000A39 RID: 2617
		private string[] allLongDatePatterns;

		// Token: 0x04000A3A RID: 2618
		private string[] allShortTimePatterns;

		// Token: 0x04000A3B RID: 2619
		private string[] allLongTimePatterns;

		// Token: 0x04000A3C RID: 2620
		private string[] m_eraNames;

		// Token: 0x04000A3D RID: 2621
		private string[] m_abbrevEraNames;

		// Token: 0x04000A3E RID: 2622
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x04000A3F RID: 2623
		private CalendarId[] optionalCalendars;

		// Token: 0x04000A40 RID: 2624
		internal bool _isReadOnly;

		// Token: 0x04000A41 RID: 2625
		private DateTimeFormatFlags formatFlags = DateTimeFormatFlags.NotInitialized;

		// Token: 0x04000A42 RID: 2626
		private string _decimalSeparator;

		// Token: 0x04000A43 RID: 2627
		private byte[] _decimalSeparatorUtf8;

		// Token: 0x04000A44 RID: 2628
		private string _fullTimeSpanPositivePattern;

		// Token: 0x04000A45 RID: 2629
		private string _fullTimeSpanNegativePattern;

		// Token: 0x04000A46 RID: 2630
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x04000A47 RID: 2631
		private static DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x04000A48 RID: 2632
		private static DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x020002DF RID: 735
		internal sealed class TokenHashValue
		{
			// Token: 0x06003687 RID: 13959 RVA: 0x000B243C File Offset: 0x000B063C
			internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			{
				this.tokenString = tokenString;
				this.tokenType = tokenType;
				this.tokenValue = tokenValue;
			}

			// Token: 0x04000A49 RID: 2633
			internal string tokenString;

			// Token: 0x04000A4A RID: 2634
			internal TokenType tokenType;

			// Token: 0x04000A4B RID: 2635
			internal int tokenValue;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Globalization
{
	// Token: 0x020002D8 RID: 728
	[NullableContext(1)]
	[Nullable(0)]
	public class CultureInfo : IFormatProvider, ICloneable
	{
		// Token: 0x060035A0 RID: 13728 RVA: 0x000AE44C File Offset: 0x000AC64C
		private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			CultureInfo.s_currentThreadCulture = args.CurrentValue;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x000AE45A File Offset: 0x000AC65A
		private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			CultureInfo.s_currentThreadUICulture = args.CurrentValue;
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x000AE468 File Offset: 0x000AC668
		private static CultureInfo InitializeUserDefaultCulture()
		{
			Interlocked.CompareExchange<CultureInfo>(ref CultureInfo.s_userDefaultCulture, CultureInfo.GetUserDefaultCulture(), null);
			return CultureInfo.s_userDefaultCulture;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x000AE482 File Offset: 0x000AC682
		private static CultureInfo InitializeUserDefaultUICulture()
		{
			Interlocked.CompareExchange<CultureInfo>(ref CultureInfo.s_userDefaultUICulture, CultureInfo.GetUserDefaultUICulture(), null);
			return CultureInfo.s_userDefaultUICulture;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000AE49C File Offset: 0x000AC69C
		private static string GetCultureNotSupportedExceptionMessage()
		{
			if (!GlobalizationMode.Invariant)
			{
				return SR.Argument_CultureNotSupported;
			}
			return SR.Argument_CultureNotSupportedInInvariantMode;
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000AE4B0 File Offset: 0x000AC6B0
		public CultureInfo(string name) : this(name, true)
		{
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000AE4BC File Offset: 0x000AC6BC
		public CultureInfo(string name, bool useUserOverride)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			CultureData cultureData = CultureData.GetCultureData(name, useUserOverride);
			if (cultureData == null)
			{
				throw new CultureNotFoundException("name", name, CultureInfo.GetCultureNotSupportedExceptionMessage());
			}
			this._cultureData = cultureData;
			this._name = this._cultureData.CultureName;
			this._isInherited = (base.GetType() != typeof(CultureInfo));
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x000AE528 File Offset: 0x000AC728
		private CultureInfo(CultureData cultureData, bool isReadOnly = false)
		{
			this._cultureData = cultureData;
			this._name = cultureData.CultureName;
			this._isReadOnly = isReadOnly;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000AE54C File Offset: 0x000AC74C
		private static CultureInfo CreateCultureInfoNoThrow(string name, bool useUserOverride)
		{
			CultureData cultureData = CultureData.GetCultureData(name, useUserOverride);
			if (cultureData == null)
			{
				return null;
			}
			return new CultureInfo(cultureData, false);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000AE56D File Offset: 0x000AC76D
		public CultureInfo(int culture) : this(culture, true)
		{
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x000AE578 File Offset: 0x000AC778
		public CultureInfo(int culture, bool useUserOverride)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(culture, "culture");
			if (culture <= 1024)
			{
				if (culture != 0 && culture != 1024)
				{
					goto IL_42;
				}
			}
			else if (culture != 2048 && culture != 3072 && culture != 4096)
			{
				goto IL_42;
			}
			bool flag = true;
			goto IL_44;
			IL_42:
			flag = false;
			IL_44:
			if (flag)
			{
				throw new CultureNotFoundException("culture", culture, SR.Argument_CultureNotSupported);
			}
			this._cultureData = CultureData.GetCultureData(culture, useUserOverride);
			this._isInherited = (base.GetType() != typeof(CultureInfo));
			this._name = this._cultureData.CultureName;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x000AE618 File Offset: 0x000AC818
		internal CultureInfo(string cultureName, string textAndCompareCultureName)
		{
			ArgumentNullException.ThrowIfNull(textAndCompareCultureName, "textAndCompareCultureName");
			CultureData cultureData = CultureData.GetCultureData(cultureName, false);
			if (cultureData == null)
			{
				throw new CultureNotFoundException("cultureName", cultureName, CultureInfo.GetCultureNotSupportedExceptionMessage());
			}
			CultureData cultureData2 = cultureData;
			this._cultureData = cultureData2;
			this._name = this._cultureData.CultureName;
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(textAndCompareCultureName);
			this._compareInfo = cultureInfo.CompareInfo;
			this._textInfo = cultureInfo.TextInfo;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x000AE68C File Offset: 0x000AC88C
		private static CultureInfo GetCultureByName(string name)
		{
			CultureInfo result;
			try
			{
				result = new CultureInfo(name)
				{
					_isReadOnly = true
				};
			}
			catch (ArgumentException)
			{
				result = CultureInfo.InvariantCulture;
			}
			return result;
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x000AE6C4 File Offset: 0x000AC8C4
		public static CultureInfo CreateSpecificCulture(string name)
		{
			CultureInfo cultureInfo;
			try
			{
				cultureInfo = new CultureInfo(name);
			}
			catch (ArgumentException)
			{
				cultureInfo = null;
				for (int i = 0; i < name.Length; i++)
				{
					if ('-' == name[i])
					{
						try
						{
							cultureInfo = new CultureInfo(name.Substring(0, i));
							break;
						}
						catch (ArgumentException)
						{
							throw;
						}
					}
				}
				if (cultureInfo == null)
				{
					throw;
				}
			}
			if (!cultureInfo.IsNeutralCulture)
			{
				return cultureInfo;
			}
			return new CultureInfo(cultureInfo._cultureData.SpecificCultureName);
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000AE74C File Offset: 0x000AC94C
		internal static bool VerifyCultureName(string cultureName, bool throwException)
		{
			int i = 0;
			while (i < cultureName.Length)
			{
				char c = cultureName[i];
				if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
				{
					if (throwException)
					{
						throw new ArgumentException(SR.Format(SR.Argument_InvalidResourceCultureName, cultureName));
					}
					return false;
				}
				else
				{
					i++;
				}
			}
			return true;
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x000AE79B File Offset: 0x000AC99B
		internal static bool VerifyCultureName(CultureInfo culture, bool throwException)
		{
			return !culture._isInherited || CultureInfo.VerifyCultureName(culture.Name, throwException);
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x000AE7B3 File Offset: 0x000AC9B3
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x000AE7DC File Offset: 0x000AC9DC
		public static CultureInfo CurrentCulture
		{
			get
			{
				CultureInfo result;
				if ((result = CultureInfo.s_currentThreadCulture) == null && (result = CultureInfo.s_DefaultThreadCurrentCulture) == null)
				{
					result = (CultureInfo.s_userDefaultCulture ?? CultureInfo.InitializeUserDefaultCulture());
				}
				return result;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				if (CultureInfo.s_asyncLocalCurrentCulture == null)
				{
					Action<AsyncLocalValueChangedArgs<CultureInfo>> valueChangedHandler;
					if ((valueChangedHandler = CultureInfo.<>O.<0>__AsyncLocalSetCurrentCulture) == null)
					{
						valueChangedHandler = (CultureInfo.<>O.<0>__AsyncLocalSetCurrentCulture = new Action<AsyncLocalValueChangedArgs<CultureInfo>>(CultureInfo.AsyncLocalSetCurrentCulture));
					}
					Interlocked.CompareExchange<AsyncLocal<CultureInfo>>(ref CultureInfo.s_asyncLocalCurrentCulture, new AsyncLocal<CultureInfo>(valueChangedHandler), null);
				}
				CultureInfo.s_asyncLocalCurrentCulture.Value = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000AE832 File Offset: 0x000ACA32
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000AE850 File Offset: 0x000ACA50
		public static CultureInfo CurrentUICulture
		{
			get
			{
				CultureInfo result;
				if ((result = CultureInfo.s_currentThreadUICulture) == null)
				{
					result = (CultureInfo.s_DefaultThreadCurrentUICulture ?? CultureInfo.UserDefaultUICulture);
				}
				return result;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				CultureInfo.VerifyCultureName(value, true);
				if (CultureInfo.s_asyncLocalCurrentUICulture == null)
				{
					Action<AsyncLocalValueChangedArgs<CultureInfo>> valueChangedHandler;
					if ((valueChangedHandler = CultureInfo.<>O.<1>__AsyncLocalSetCurrentUICulture) == null)
					{
						valueChangedHandler = (CultureInfo.<>O.<1>__AsyncLocalSetCurrentUICulture = new Action<AsyncLocalValueChangedArgs<CultureInfo>>(CultureInfo.AsyncLocalSetCurrentUICulture));
					}
					Interlocked.CompareExchange<AsyncLocal<CultureInfo>>(ref CultureInfo.s_asyncLocalCurrentUICulture, new AsyncLocal<CultureInfo>(valueChangedHandler), null);
				}
				CultureInfo.s_asyncLocalCurrentUICulture.Value = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000AE8AE File Offset: 0x000ACAAE
		internal static CultureInfo UserDefaultUICulture
		{
			get
			{
				return CultureInfo.s_userDefaultUICulture ?? CultureInfo.InitializeUserDefaultUICulture();
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x000AE8C0 File Offset: 0x000ACAC0
		public static CultureInfo InstalledUICulture
		{
			get
			{
				return CultureInfo.s_userDefaultCulture ?? CultureInfo.InitializeUserDefaultCulture();
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000AE8D2 File Offset: 0x000ACAD2
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x000AE8DB File Offset: 0x000ACADB
		[Nullable(2)]
		public static CultureInfo DefaultThreadCurrentCulture
		{
			[NullableContext(2)]
			get
			{
				return CultureInfo.s_DefaultThreadCurrentCulture;
			}
			[NullableContext(2)]
			set
			{
				CultureInfo.s_DefaultThreadCurrentCulture = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000AE8E5 File Offset: 0x000ACAE5
		// (set) Token: 0x060035B9 RID: 13753 RVA: 0x000AE8EE File Offset: 0x000ACAEE
		[Nullable(2)]
		public static CultureInfo DefaultThreadCurrentUICulture
		{
			[NullableContext(2)]
			get
			{
				return CultureInfo.s_DefaultThreadCurrentUICulture;
			}
			[NullableContext(2)]
			set
			{
				if (value != null)
				{
					CultureInfo.VerifyCultureName(value, true);
				}
				CultureInfo.s_DefaultThreadCurrentUICulture = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x000AE903 File Offset: 0x000ACB03
		public static CultureInfo InvariantCulture
		{
			get
			{
				return CultureInfo.s_InvariantCultureInfo;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x000AE90C File Offset: 0x000ACB0C
		public virtual CultureInfo Parent
		{
			get
			{
				if (this._parent == null)
				{
					string text = this._cultureData.ParentName;
					if (text == "zh")
					{
						if (this._name.Length == 5 && this._name[2] == '-')
						{
							if ((this._name[3] == 'C' && this._name[4] == 'N') || (this._name[3] == 'S' && this._name[4] == 'G'))
							{
								text = "zh-Hans";
							}
							else if ((this._name[3] == 'H' && this._name[4] == 'K') || (this._name[3] == 'M' && this._name[4] == 'O') || (this._name[3] == 'T' && this._name[4] == 'W'))
							{
								text = "zh-Hant";
							}
						}
						else if (this._name.Length > 8 && this._name.AsSpan(2, 4).SequenceEqual("-Han".AsSpan()) && this._name[7] == '-')
						{
							if (this._name[6] == 't')
							{
								text = "zh-Hant";
							}
							else if (this._name[6] == 's')
							{
								text = "zh-Hans";
							}
						}
					}
					CultureInfo value;
					if (string.IsNullOrEmpty(text))
					{
						value = CultureInfo.InvariantCulture;
					}
					else
					{
						value = (CultureInfo.CreateCultureInfoNoThrow(text, this._cultureData.UseUserOverride) ?? CultureInfo.InvariantCulture);
					}
					Interlocked.CompareExchange<CultureInfo>(ref this._parent, value, null);
				}
				return this._parent;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x000AEAC3 File Offset: 0x000ACCC3
		public virtual int LCID
		{
			get
			{
				return this._cultureData.LCID;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x000AEAD0 File Offset: 0x000ACCD0
		public virtual int KeyboardLayoutId
		{
			get
			{
				return this._cultureData.KeyboardLayoutId;
			}
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000AEADD File Offset: 0x000ACCDD
		public static CultureInfo[] GetCultures(CultureTypes types)
		{
			if ((types & CultureTypes.UserCustomCulture) == CultureTypes.UserCustomCulture)
			{
				types |= CultureTypes.ReplacementCultures;
			}
			return CultureData.GetCultures(types);
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x000AEAF4 File Offset: 0x000ACCF4
		public virtual string Name
		{
			get
			{
				string result;
				if ((result = this._nonSortName) == null)
				{
					result = (this._nonSortName = (this._cultureData.Name ?? string.Empty));
				}
				return result;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000AEB28 File Offset: 0x000ACD28
		internal string SortName
		{
			get
			{
				string result;
				if ((result = this._sortName) == null)
				{
					result = (this._sortName = this._cultureData.SortName);
				}
				return result;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x000AEB53 File Offset: 0x000ACD53
		[Nullable(2)]
		internal string InteropName
		{
			get
			{
				return this._cultureData.InteropName;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000AEB60 File Offset: 0x000ACD60
		public string IetfLanguageTag
		{
			get
			{
				string name = this.Name;
				string result;
				if (!(name == "zh-CHT"))
				{
					if (!(name == "zh-CHS"))
					{
						result = this.Name;
					}
					else
					{
						result = "zh-Hans";
					}
				}
				else
				{
					result = "zh-Hant";
				}
				return result;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
		public virtual string DisplayName
		{
			get
			{
				return this._cultureData.DisplayName;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000AEBB5 File Offset: 0x000ACDB5
		public virtual string NativeName
		{
			get
			{
				return this._cultureData.NativeName;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000AEBC2 File Offset: 0x000ACDC2
		public virtual string EnglishName
		{
			get
			{
				return this._cultureData.EnglishName;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000AEBCF File Offset: 0x000ACDCF
		public virtual string TwoLetterISOLanguageName
		{
			get
			{
				return this._cultureData.TwoLetterISOLanguageName;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x000AEBDC File Offset: 0x000ACDDC
		public virtual string ThreeLetterISOLanguageName
		{
			get
			{
				return this._cultureData.ThreeLetterISOLanguageName;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000AEBE9 File Offset: 0x000ACDE9
		public virtual string ThreeLetterWindowsLanguageName
		{
			get
			{
				return this._cultureData.ThreeLetterWindowsLanguageName;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x000AEBF8 File Offset: 0x000ACDF8
		public virtual CompareInfo CompareInfo
		{
			get
			{
				CompareInfo result;
				if ((result = this._compareInfo) == null)
				{
					result = (this._compareInfo = (this.UseUserOverride ? CultureInfo.GetCultureInfo(this._name).CompareInfo : new CompareInfo(this)));
				}
				return result;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000AEC38 File Offset: 0x000ACE38
		public virtual TextInfo TextInfo
		{
			get
			{
				if (this._textInfo == null)
				{
					TextInfo textInfo = new TextInfo(this._cultureData);
					textInfo.SetReadOnlyState(this._isReadOnly);
					this._textInfo = textInfo;
				}
				return this._textInfo;
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000AEC74 File Offset: 0x000ACE74
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (this == value)
			{
				return true;
			}
			CultureInfo cultureInfo = value as CultureInfo;
			return cultureInfo != null && this.Name.Equals(cultureInfo.Name) && this.CompareInfo.Equals(cultureInfo.CompareInfo);
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000AECB9 File Offset: 0x000ACEB9
		public override int GetHashCode()
		{
			return this.Name.GetHashCode() + this.CompareInfo.GetHashCode();
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000AECD2 File Offset: 0x000ACED2
		public override string ToString()
		{
			return this._name;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x000AECDA File Offset: 0x000ACEDA
		[NullableContext(2)]
		public virtual object GetFormat(Type formatType)
		{
			if (formatType == typeof(NumberFormatInfo))
			{
				return this.NumberFormat;
			}
			if (formatType == typeof(DateTimeFormatInfo))
			{
				return this.DateTimeFormat;
			}
			return null;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000AED0F File Offset: 0x000ACF0F
		public virtual bool IsNeutralCulture
		{
			get
			{
				return this._cultureData.IsNeutralCulture;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000AED1C File Offset: 0x000ACF1C
		public CultureTypes CultureTypes
		{
			get
			{
				CultureTypes cultureTypes = this._cultureData.IsNeutralCulture ? CultureTypes.NeutralCultures : CultureTypes.SpecificCultures;
				cultureTypes |= CultureTypes.InstalledWin32Cultures;
				if (this._cultureData.IsSupplementalCustomCulture)
				{
					cultureTypes |= CultureTypes.UserCustomCulture;
				}
				if (this._cultureData.IsReplacementCulture)
				{
					cultureTypes |= CultureTypes.ReplacementCultures;
				}
				return cultureTypes;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x000AED68 File Offset: 0x000ACF68
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x000AEDA9 File Offset: 0x000ACFA9
		public virtual NumberFormatInfo NumberFormat
		{
			get
			{
				if (this._numInfo == null)
				{
					Interlocked.CompareExchange<NumberFormatInfo>(ref this._numInfo, new NumberFormatInfo(this._cultureData)
					{
						_isReadOnly = this._isReadOnly
					}, null);
				}
				return this._numInfo;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._numInfo = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x000AEDC4 File Offset: 0x000ACFC4
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x000AEE0B File Offset: 0x000AD00B
		public virtual DateTimeFormatInfo DateTimeFormat
		{
			get
			{
				if (this._dateTimeInfo == null)
				{
					Interlocked.CompareExchange<DateTimeFormatInfo>(ref this._dateTimeInfo, new DateTimeFormatInfo(this._cultureData, this.Calendar)
					{
						_isReadOnly = this._isReadOnly
					}, null);
				}
				return this._dateTimeInfo;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._dateTimeInfo = value;
			}
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000AEE28 File Offset: 0x000AD028
		public void ClearCachedData()
		{
			CultureInfo.UserDefaultLocaleName = CultureInfo.GetUserDefaultLocaleName();
			CultureInfo.s_userDefaultCulture = CultureInfo.GetUserDefaultCulture();
			CultureInfo.s_userDefaultUICulture = CultureInfo.GetUserDefaultUICulture();
			RegionInfo.s_currentRegionInfo = null;
			TimeZone.ResetTimeZone();
			TimeZoneInfo.ClearCachedData();
			CultureInfo.s_cachedCulturesByLcid = null;
			CultureInfo.s_cachedCulturesByName = null;
			CultureData.ClearCachedData();
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x000AEE78 File Offset: 0x000AD078
		internal static Calendar GetCalendarInstance(CalendarId calType)
		{
			if (calType == CalendarId.GREGORIAN)
			{
				return new GregorianCalendar();
			}
			return CultureInfo.GetCalendarInstanceRare(calType);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000AEE8C File Offset: 0x000AD08C
		internal static Calendar GetCalendarInstanceRare(CalendarId calType)
		{
			switch (calType)
			{
			case CalendarId.GREGORIAN_US:
			case CalendarId.GREGORIAN_ME_FRENCH:
			case CalendarId.GREGORIAN_ARABIC:
			case CalendarId.GREGORIAN_XLIT_ENGLISH:
			case CalendarId.GREGORIAN_XLIT_FRENCH:
				return new GregorianCalendar((GregorianCalendarTypes)calType);
			case CalendarId.JAPAN:
				return new JapaneseCalendar();
			case CalendarId.TAIWAN:
				return new TaiwanCalendar();
			case CalendarId.KOREA:
				return new KoreanCalendar();
			case CalendarId.HIJRI:
				return new HijriCalendar();
			case CalendarId.THAI:
				return new ThaiBuddhistCalendar();
			case CalendarId.HEBREW:
				return new HebrewCalendar();
			case CalendarId.PERSIAN:
				return new PersianCalendar();
			case CalendarId.UMALQURA:
				return new UmAlQuraCalendar();
			}
			return new GregorianCalendar();
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000AEF4C File Offset: 0x000AD14C
		public virtual Calendar Calendar
		{
			get
			{
				if (this._calendar == null)
				{
					Calendar defaultCalendar = this._cultureData.DefaultCalendar;
					Interlocked.MemoryBarrier();
					defaultCalendar.SetReadOnlyState(this._isReadOnly);
					this._calendar = defaultCalendar;
				}
				return this._calendar;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x000AEF8C File Offset: 0x000AD18C
		public virtual Calendar[] OptionalCalendars
		{
			get
			{
				if (GlobalizationMode.Invariant)
				{
					return new GregorianCalendar[]
					{
						new GregorianCalendar()
					};
				}
				CalendarId[] calendarIds = this._cultureData.CalendarIds;
				Calendar[] array = new Calendar[calendarIds.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = CultureInfo.GetCalendarInstance(calendarIds[i]);
				}
				return array;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
		public bool UseUserOverride
		{
			get
			{
				return this._cultureData.UseUserOverride;
			}
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		public CultureInfo GetConsoleFallbackUICulture()
		{
			CultureInfo cultureInfo = this._consoleFallbackCulture;
			if (cultureInfo == null)
			{
				cultureInfo = CultureInfo.CreateSpecificCulture(this._cultureData.SCONSOLEFALLBACKNAME);
				cultureInfo._isReadOnly = true;
				this._consoleFallbackCulture = cultureInfo;
			}
			return cultureInfo;
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x000AF028 File Offset: 0x000AD228
		public virtual object Clone()
		{
			CultureInfo cultureInfo = (CultureInfo)base.MemberwiseClone();
			cultureInfo._isReadOnly = false;
			if (!this._isInherited)
			{
				if (this._dateTimeInfo != null)
				{
					cultureInfo._dateTimeInfo = (DateTimeFormatInfo)this._dateTimeInfo.Clone();
				}
				if (this._numInfo != null)
				{
					cultureInfo._numInfo = (NumberFormatInfo)this._numInfo.Clone();
				}
			}
			else
			{
				cultureInfo.DateTimeFormat = (DateTimeFormatInfo)this.DateTimeFormat.Clone();
				cultureInfo.NumberFormat = (NumberFormatInfo)this.NumberFormat.Clone();
			}
			if (this._textInfo != null)
			{
				cultureInfo._textInfo = (TextInfo)this._textInfo.Clone();
			}
			if (this._dateTimeInfo != null && this._dateTimeInfo.Calendar == this._calendar)
			{
				cultureInfo._calendar = cultureInfo.DateTimeFormat.Calendar;
			}
			else if (this._calendar != null)
			{
				cultureInfo._calendar = (Calendar)this._calendar.Clone();
			}
			return cultureInfo;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x000AF128 File Offset: 0x000AD328
		public static CultureInfo ReadOnly(CultureInfo ci)
		{
			ArgumentNullException.ThrowIfNull(ci, "ci");
			if (ci.IsReadOnly)
			{
				return ci;
			}
			CultureInfo cultureInfo = (CultureInfo)ci.MemberwiseClone();
			if (!ci.IsNeutralCulture)
			{
				if (!ci._isInherited)
				{
					if (ci._dateTimeInfo != null)
					{
						cultureInfo._dateTimeInfo = DateTimeFormatInfo.ReadOnly(ci._dateTimeInfo);
					}
					if (ci._numInfo != null)
					{
						cultureInfo._numInfo = NumberFormatInfo.ReadOnly(ci._numInfo);
					}
				}
				else
				{
					cultureInfo.DateTimeFormat = DateTimeFormatInfo.ReadOnly(ci.DateTimeFormat);
					cultureInfo.NumberFormat = NumberFormatInfo.ReadOnly(ci.NumberFormat);
				}
			}
			if (ci._textInfo != null)
			{
				cultureInfo._textInfo = TextInfo.ReadOnly(ci._textInfo);
			}
			if (ci._calendar != null)
			{
				cultureInfo._calendar = Calendar.ReadOnly(ci._calendar);
			}
			cultureInfo._isReadOnly = true;
			return cultureInfo;
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x000AF1F6 File Offset: 0x000AD3F6
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000AF1FE File Offset: 0x000AD3FE
		private void VerifyWritable()
		{
			if (this._isReadOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000AF213 File Offset: 0x000AD413
		internal bool HasInvariantCultureName
		{
			get
			{
				return this.Name == CultureInfo.InvariantCulture.Name;
			}
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x000AF22C File Offset: 0x000AD42C
		public static CultureInfo GetCultureInfo(int culture)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(culture, "culture");
			Dictionary<int, CultureInfo> cachedCulturesByLcid = CultureInfo.CachedCulturesByLcid;
			Dictionary<int, CultureInfo> obj = cachedCulturesByLcid;
			CultureInfo cultureInfo;
			lock (obj)
			{
				if (cachedCulturesByLcid.TryGetValue(culture, out cultureInfo))
				{
					return cultureInfo;
				}
			}
			try
			{
				cultureInfo = new CultureInfo(culture, false)
				{
					_isReadOnly = true
				};
			}
			catch (ArgumentException)
			{
				throw new CultureNotFoundException("culture", culture, CultureInfo.GetCultureNotSupportedExceptionMessage());
			}
			obj = cachedCulturesByLcid;
			lock (obj)
			{
				cachedCulturesByLcid[culture] = cultureInfo;
			}
			return cultureInfo;
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x000AF2E4 File Offset: 0x000AD4E4
		public static CultureInfo GetCultureInfo(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			name = CultureData.AnsiToLower(name);
			Dictionary<string, CultureInfo> cachedCulturesByName = CultureInfo.CachedCulturesByName;
			Dictionary<string, CultureInfo> obj = cachedCulturesByName;
			CultureInfo cultureInfo;
			lock (obj)
			{
				if (cachedCulturesByName.TryGetValue(name, out cultureInfo))
				{
					return cultureInfo;
				}
			}
			CultureInfo cultureInfo2 = CultureInfo.CreateCultureInfoNoThrow(name, false);
			if (cultureInfo2 == null)
			{
				throw new CultureNotFoundException("name", name, CultureInfo.GetCultureNotSupportedExceptionMessage());
			}
			cultureInfo = cultureInfo2;
			cultureInfo._isReadOnly = true;
			name = CultureData.AnsiToLower(cultureInfo._name);
			obj = cachedCulturesByName;
			lock (obj)
			{
				cachedCulturesByName[name] = cultureInfo;
			}
			return cultureInfo;
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x000AF3A4 File Offset: 0x000AD5A4
		public static CultureInfo GetCultureInfo(string name, string altName)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(altName, "altName");
			name = CultureData.AnsiToLower(name);
			altName = CultureData.AnsiToLower(altName);
			string key = name + "�" + altName;
			Dictionary<string, CultureInfo> cachedCulturesByName = CultureInfo.CachedCulturesByName;
			Dictionary<string, CultureInfo> obj = cachedCulturesByName;
			CultureInfo cultureInfo;
			lock (obj)
			{
				if (cachedCulturesByName.TryGetValue(key, out cultureInfo))
				{
					return cultureInfo;
				}
			}
			try
			{
				cultureInfo = new CultureInfo(name, altName)
				{
					_isReadOnly = true
				};
				cultureInfo.TextInfo.SetReadOnlyState(true);
			}
			catch (ArgumentException)
			{
				throw new CultureNotFoundException("name/altName", SR.Format(SR.Argument_OneOfCulturesNotSupported, name, altName));
			}
			obj = cachedCulturesByName;
			lock (obj)
			{
				cachedCulturesByName[key] = cultureInfo;
			}
			return cultureInfo;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000AF498 File Offset: 0x000AD698
		public static CultureInfo GetCultureInfo(string name, bool predefinedOnly)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (predefinedOnly && !GlobalizationMode.Invariant && (GlobalizationMode.UseNls ? (!CultureData.NlsIsEnsurePredefinedLocaleName(name)) : (!CultureData.IcuIsEnsurePredefinedLocaleName(name))))
			{
				throw new CultureNotFoundException("name", name, SR.Format(SR.Argument_InvalidPredefinedCultureName, name));
			}
			return CultureInfo.GetCultureInfo(name);
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
		private static Dictionary<string, CultureInfo> CachedCulturesByName
		{
			get
			{
				Dictionary<string, CultureInfo> dictionary = CultureInfo.s_cachedCulturesByName;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, CultureInfo>();
					dictionary = (Interlocked.CompareExchange<Dictionary<string, CultureInfo>>(ref CultureInfo.s_cachedCulturesByName, dictionary, null) ?? dictionary);
				}
				return dictionary;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000AF524 File Offset: 0x000AD724
		private static Dictionary<int, CultureInfo> CachedCulturesByLcid
		{
			get
			{
				Dictionary<int, CultureInfo> dictionary = CultureInfo.s_cachedCulturesByLcid;
				if (dictionary == null)
				{
					dictionary = new Dictionary<int, CultureInfo>();
					dictionary = (Interlocked.CompareExchange<Dictionary<int, CultureInfo>>(ref CultureInfo.s_cachedCulturesByLcid, dictionary, null) ?? dictionary);
				}
				return dictionary;
			}
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000AF554 File Offset: 0x000AD754
		public static CultureInfo GetCultureInfoByIetfLanguageTag(string name)
		{
			if (name == "zh-CHT" || name == "zh-CHS")
			{
				throw new CultureNotFoundException("name", SR.Format(SR.Argument_CultureIetfNotSupported, name));
			}
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(name);
			if (cultureInfo.LCID > 65535 || cultureInfo.LCID == 1034)
			{
				throw new CultureNotFoundException("name", SR.Format(SR.Argument_CultureIetfNotSupported, name));
			}
			return cultureInfo;
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x000AF5CC File Offset: 0x000AD7CC
		internal static CultureInfo GetUserDefaultCulture()
		{
			if (GlobalizationMode.Invariant)
			{
				return CultureInfo.InvariantCulture;
			}
			string userDefaultLocaleName = CultureInfo.UserDefaultLocaleName;
			if (userDefaultLocaleName == null)
			{
				return CultureInfo.InvariantCulture;
			}
			return CultureInfo.GetCultureByName(userDefaultLocaleName);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x000AF5FC File Offset: 0x000AD7FC
		private unsafe static CultureInfo GetUserDefaultUICulture()
		{
			if (GlobalizationMode.Invariant)
			{
				return CultureInfo.InvariantCulture;
			}
			uint num = 0U;
			uint num2 = 0U;
			if (Interop.Kernel32.GetUserPreferredUILanguages(8U, &num, null, &num2) != Interop.BOOL.FALSE)
			{
				Span<char> span;
				if (num2 <= 256U)
				{
					int num3 = (int)num2;
					span = new Span<char>(stackalloc byte[checked(unchecked((UIntPtr)num3) * 2)], num3);
				}
				else
				{
					span = new char[num2];
				}
				Span<char> span2 = span;
				fixed (char* pinnableReference = span2.GetPinnableReference())
				{
					char* pwszLanguagesBuffer = pinnableReference;
					if (Interop.Kernel32.GetUserPreferredUILanguages(8U, &num, pwszLanguagesBuffer, &num2) != Interop.BOOL.FALSE)
					{
						return CultureInfo.GetCultureByName(span2.ToString());
					}
				}
			}
			return CultureInfo.InitializeUserDefaultCulture();
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x000AF68E File Offset: 0x000AD88E
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x000AF695 File Offset: 0x000AD895
		[Nullable(2)]
		internal static string UserDefaultLocaleName { get; set; } = CultureInfo.GetUserDefaultLocaleName();

		// Token: 0x060035EC RID: 13804 RVA: 0x000AF69D File Offset: 0x000AD89D
		private static string GetUserDefaultLocaleName()
		{
			string result;
			if (!GlobalizationMode.Invariant)
			{
				if ((result = CultureData.GetLocaleInfoEx(null, 92U)) == null)
				{
					return CultureData.GetLocaleInfoEx("!x-sys-default-locale", 92U);
				}
			}
			else
			{
				result = CultureInfo.InvariantCulture.Name;
			}
			return result;
		}

		// Token: 0x040009E2 RID: 2530
		private bool _isReadOnly;

		// Token: 0x040009E3 RID: 2531
		private CompareInfo _compareInfo;

		// Token: 0x040009E4 RID: 2532
		private TextInfo _textInfo;

		// Token: 0x040009E5 RID: 2533
		internal NumberFormatInfo _numInfo;

		// Token: 0x040009E6 RID: 2534
		internal DateTimeFormatInfo _dateTimeInfo;

		// Token: 0x040009E7 RID: 2535
		private Calendar _calendar;

		// Token: 0x040009E8 RID: 2536
		internal CultureData _cultureData;

		// Token: 0x040009E9 RID: 2537
		internal bool _isInherited;

		// Token: 0x040009EA RID: 2538
		private CultureInfo _consoleFallbackCulture;

		// Token: 0x040009EB RID: 2539
		internal string _name;

		// Token: 0x040009EC RID: 2540
		private string _nonSortName;

		// Token: 0x040009ED RID: 2541
		private string _sortName;

		// Token: 0x040009EE RID: 2542
		private static volatile CultureInfo s_userDefaultCulture;

		// Token: 0x040009EF RID: 2543
		private static volatile CultureInfo s_userDefaultUICulture;

		// Token: 0x040009F0 RID: 2544
		private static readonly CultureInfo s_InvariantCultureInfo = new CultureInfo(CultureData.Invariant, true);

		// Token: 0x040009F1 RID: 2545
		private static volatile CultureInfo s_DefaultThreadCurrentUICulture;

		// Token: 0x040009F2 RID: 2546
		private static volatile CultureInfo s_DefaultThreadCurrentCulture;

		// Token: 0x040009F3 RID: 2547
		[ThreadStatic]
		private static CultureInfo s_currentThreadCulture;

		// Token: 0x040009F4 RID: 2548
		[ThreadStatic]
		private static CultureInfo s_currentThreadUICulture;

		// Token: 0x040009F5 RID: 2549
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x040009F6 RID: 2550
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x040009F7 RID: 2551
		private static Dictionary<string, CultureInfo> s_cachedCulturesByName;

		// Token: 0x040009F8 RID: 2552
		private static Dictionary<int, CultureInfo> s_cachedCulturesByLcid;

		// Token: 0x040009F9 RID: 2553
		private CultureInfo _parent;

		// Token: 0x020002D9 RID: 729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040009FB RID: 2555
			public static Action<AsyncLocalValueChangedArgs<CultureInfo>> <0>__AsyncLocalSetCurrentCulture;

			// Token: 0x040009FC RID: 2556
			public static Action<AsyncLocalValueChangedArgs<CultureInfo>> <1>__AsyncLocalSetCurrentUICulture;
		}
	}
}

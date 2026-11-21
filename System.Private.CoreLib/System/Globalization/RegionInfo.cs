using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x0200030A RID: 778
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionInfo
	{
		// Token: 0x060038DF RID: 14559 RVA: 0x000BC3F4 File Offset: 0x000BA5F4
		public RegionInfo(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (name.Length == 0)
			{
				throw new ArgumentException(SR.Argument_NoRegionInvariantCulture, "name");
			}
			CultureData cultureDataForRegion = CultureData.GetCultureDataForRegion(name, true);
			if (cultureDataForRegion == null)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidCultureName, name), "name");
			}
			this._cultureData = cultureDataForRegion;
			if (this._cultureData.IsNeutralCulture)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidNeutralRegionName, name), "name");
			}
			this._name = this._cultureData.RegionName;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x000BC488 File Offset: 0x000BA688
		public RegionInfo(int culture)
		{
			if (culture == 127)
			{
				throw new ArgumentException(SR.Argument_NoRegionInvariantCulture);
			}
			if (culture == 0)
			{
				throw new ArgumentException(SR.Format(SR.Argument_CultureIsNeutral, culture), "culture");
			}
			if (culture == 3072 || culture == 4096)
			{
				throw new ArgumentException(SR.Format(SR.Argument_CustomCultureCannotBePassedByNumber, culture), "culture");
			}
			this._cultureData = CultureData.GetCultureData(culture, true);
			this._name = this._cultureData.RegionName;
			if (this._cultureData.IsNeutralCulture)
			{
				throw new ArgumentException(SR.Format(SR.Argument_CultureIsNeutral, culture), "culture");
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x000BC53A File Offset: 0x000BA73A
		internal RegionInfo(CultureData cultureData)
		{
			this._cultureData = cultureData;
			this._name = this._cultureData.RegionName;
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x000BC55C File Offset: 0x000BA75C
		public static RegionInfo CurrentRegion
		{
			get
			{
				RegionInfo regionInfo = RegionInfo.s_currentRegionInfo;
				if (regionInfo == null)
				{
					regionInfo = new RegionInfo(CultureData.GetCurrentRegionData());
					regionInfo._name = regionInfo._cultureData.RegionName;
					RegionInfo.s_currentRegionInfo = regionInfo;
				}
				return regionInfo;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x000BC595 File Offset: 0x000BA795
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x000BC59D File Offset: 0x000BA79D
		public virtual string EnglishName
		{
			get
			{
				return this._cultureData.EnglishCountryName;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x000BC5AA File Offset: 0x000BA7AA
		public virtual string DisplayName
		{
			get
			{
				return this._cultureData.LocalizedCountryName;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x000BC5B7 File Offset: 0x000BA7B7
		public virtual string NativeName
		{
			get
			{
				return this._cultureData.NativeCountryName;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x000BC5C4 File Offset: 0x000BA7C4
		public virtual string TwoLetterISORegionName
		{
			get
			{
				return this._cultureData.TwoLetterISOCountryName;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x000BC5D1 File Offset: 0x000BA7D1
		public virtual string ThreeLetterISORegionName
		{
			get
			{
				return this._cultureData.ThreeLetterISOCountryName;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x000BC5DE File Offset: 0x000BA7DE
		public virtual string ThreeLetterWindowsRegionName
		{
			get
			{
				return this.ThreeLetterISORegionName;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x000BC5E6 File Offset: 0x000BA7E6
		public virtual bool IsMetric
		{
			get
			{
				return this._cultureData.MeasurementSystem == 0;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x000BC5F6 File Offset: 0x000BA7F6
		public virtual int GeoId
		{
			get
			{
				return this._cultureData.GeoId;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x000BC603 File Offset: 0x000BA803
		public virtual string CurrencyEnglishName
		{
			get
			{
				return this._cultureData.CurrencyEnglishName;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x000BC610 File Offset: 0x000BA810
		public virtual string CurrencyNativeName
		{
			get
			{
				return this._cultureData.CurrencyNativeName;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x000BC61D File Offset: 0x000BA81D
		public virtual string CurrencySymbol
		{
			get
			{
				return this._cultureData.CurrencySymbol;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x000BC62A File Offset: 0x000BA82A
		public virtual string ISOCurrencySymbol
		{
			get
			{
				return this._cultureData.ISOCurrencySymbol;
			}
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x000BC638 File Offset: 0x000BA838
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			RegionInfo regionInfo = value as RegionInfo;
			return regionInfo != null && this.Name.Equals(regionInfo.Name);
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x000BC662 File Offset: 0x000BA862
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x000BC66F File Offset: 0x000BA86F
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x04000B43 RID: 2883
		private string _name;

		// Token: 0x04000B44 RID: 2884
		private readonly CultureData _cultureData;

		// Token: 0x04000B45 RID: 2885
		internal static RegionInfo s_currentRegionInfo;
	}
}

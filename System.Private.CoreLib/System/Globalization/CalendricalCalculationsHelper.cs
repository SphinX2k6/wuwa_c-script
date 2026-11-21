using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002CA RID: 714
	internal static class CalendricalCalculationsHelper
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x000A64B5 File Offset: 0x000A46B5
		private static ReadOnlySpan<double> Coefficients1900to1987
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.70871E7CEBC5FB665C6CDA09BCB582780757E8F266C78289B5A1553B02AA3D828).FieldHandle);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x000A64C1 File Offset: 0x000A46C1
		private static ReadOnlySpan<double> Coefficients1800to1899
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.40EC13C575237954625B718CA2B291A90543D086FE5E3258F158FDDD3A9067CC8).FieldHandle);
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x000A64CD File Offset: 0x000A46CD
		private static ReadOnlySpan<double> Coefficients1700to1799
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.501E4F476B5C5D742AB5526561490A19EF5F752BEC30E7C5B172D05897A989328).FieldHandle);
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x000A64D9 File Offset: 0x000A46D9
		private static ReadOnlySpan<double> Coefficients1620to1699
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.1E398465A9EE43BEF177E8E00D8C5348363E726339A46C767812C81310C00CB28).FieldHandle);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x000A64E5 File Offset: 0x000A46E5
		private static ReadOnlySpan<double> LambdaCoefficients
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.EC85ED774A75308D011FEF4A32204FB9725776189F565C95E968E241738E89D48).FieldHandle);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x000A64F1 File Offset: 0x000A46F1
		private static ReadOnlySpan<double> AnomalyCoefficients
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.739592F1F51C1B5B4053CDFD26932FE506C041EC6B08A39DCE012EADDA72ADA78).FieldHandle);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x000A64FD File Offset: 0x000A46FD
		private static ReadOnlySpan<double> EccentricityCoefficients
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.9287D942CCFE5B2A54D81BDDC56BD89F2DC6C4C8B31507E6284F8D25D10093678).FieldHandle);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x000A6509 File Offset: 0x000A4709
		private static ReadOnlySpan<double> CoefficientsA
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.83F180C4F05CDA92C6CE1FB81ECB9031C503C1906040707C412F2BC7CB609F2A8).FieldHandle);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x000A6515 File Offset: 0x000A4715
		private static ReadOnlySpan<double> CoefficientsB
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.1537CF074FEBB1EDD62F5C35E2A77A575ED00CD6C5D8F479EFA4302E2F7576888).FieldHandle);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x000A6521 File Offset: 0x000A4721
		private static ReadOnlySpan<double> Coefficients
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.321F9E46BD1833FD819E17E50CBC1681CE91FD99CF5112DFAB7FC322FE3E9EC58).FieldHandle);
			}
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0002FCC1 File Offset: 0x0002DEC1
		private static double RadiansFromDegrees(double degree)
		{
			return degree * 3.141592653589793 / 180.0;
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x000A652D File Offset: 0x000A472D
		private static double SinOfDegree(double degree)
		{
			return Math.Sin(CalendricalCalculationsHelper.RadiansFromDegrees(degree));
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000A653A File Offset: 0x000A473A
		private static double CosOfDegree(double degree)
		{
			return Math.Cos(CalendricalCalculationsHelper.RadiansFromDegrees(degree));
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000A6547 File Offset: 0x000A4747
		private static double TanOfDegree(double degree)
		{
			return Math.Tan(CalendricalCalculationsHelper.RadiansFromDegrees(degree));
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000A6554 File Offset: 0x000A4754
		private static double Obliquity(double julianCenturies)
		{
			return CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.Coefficients, julianCenturies);
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000A6561 File Offset: 0x000A4761
		internal static long GetNumberOfDays(DateTime date)
		{
			return date.Ticks / 864000000000L;
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000A6574 File Offset: 0x000A4774
		private static int GetGregorianYear(double numberOfDays)
		{
			return new DateTime(Math.Min((long)(Math.Floor(numberOfDays) * 864000000000.0), DateTime.MaxValue.Ticks)).Year;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000A65B0 File Offset: 0x000A47B0
		private static double Reminder(double divisor, double dividend)
		{
			double num = Math.Floor(divisor / dividend);
			return divisor - dividend * num;
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000A65CB File Offset: 0x000A47CB
		private static double NormalizeLongitude(double longitude)
		{
			longitude = CalendricalCalculationsHelper.Reminder(longitude, 360.0);
			if (longitude < 0.0)
			{
				longitude += 360.0;
			}
			return longitude;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000A65F8 File Offset: 0x000A47F8
		public static double AsDayFraction(double longitude)
		{
			return longitude / 360.0;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000A6608 File Offset: 0x000A4808
		private unsafe static double PolynomialSum(ReadOnlySpan<double> coefficients, double indeterminate)
		{
			double num = *coefficients[0];
			double num2 = 1.0;
			for (int i = 1; i < coefficients.Length; i++)
			{
				num2 *= indeterminate;
				num += *coefficients[i] * num2;
			}
			return num;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000A664E File Offset: 0x000A484E
		private static double CenturiesFrom1900(int gregorianYear)
		{
			return (double)(CalendricalCalculationsHelper.GetNumberOfDays(new DateTime(gregorianYear, 7, 1)) - CalendricalCalculationsHelper.s_startOf1900Century) / 36525.0;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000A6670 File Offset: 0x000A4870
		private static double DefaultEphemerisCorrection(int gregorianYear)
		{
			double num = (double)(CalendricalCalculationsHelper.GetNumberOfDays(new DateTime(gregorianYear, 1, 1)) - CalendricalCalculationsHelper.s_startOf1810);
			return (Math.Pow(0.5 + num, 2.0) / 41048480.0 - 15.0) / 86400.0;
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000A66C9 File Offset: 0x000A48C9
		private static double EphemerisCorrection1988to2019(int gregorianYear)
		{
			return (double)(gregorianYear - 1933) / 86400.0;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000A66E0 File Offset: 0x000A48E0
		private static double EphemerisCorrection1900to1987(int gregorianYear)
		{
			double indeterminate = CalendricalCalculationsHelper.CenturiesFrom1900(gregorianYear);
			return CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.Coefficients1900to1987, indeterminate);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000A6700 File Offset: 0x000A4900
		private static double EphemerisCorrection1800to1899(int gregorianYear)
		{
			double indeterminate = CalendricalCalculationsHelper.CenturiesFrom1900(gregorianYear);
			return CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.Coefficients1800to1899, indeterminate);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000A6720 File Offset: 0x000A4920
		private static double EphemerisCorrection1700to1799(int gregorianYear)
		{
			double indeterminate = (double)(gregorianYear - 1700);
			return CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.Coefficients1700to1799, indeterminate) / 86400.0;
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000A674C File Offset: 0x000A494C
		private static double EphemerisCorrection1620to1699(int gregorianYear)
		{
			double indeterminate = (double)(gregorianYear - 1600);
			return CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.Coefficients1620to1699, indeterminate) / 86400.0;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000A6778 File Offset: 0x000A4978
		private static double EphemerisCorrection(double time)
		{
			int gregorianYear = CalendricalCalculationsHelper.GetGregorianYear(time);
			CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap[] array = CalendricalCalculationsHelper.s_ephemerisCorrectionTable;
			int i = 0;
			while (i < array.Length)
			{
				CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap ephemerisCorrectionAlgorithmMap = array[i];
				if (ephemerisCorrectionAlgorithmMap._lowestYear <= gregorianYear)
				{
					switch (ephemerisCorrectionAlgorithmMap._algorithm)
					{
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Default:
						return CalendricalCalculationsHelper.DefaultEphemerisCorrection(gregorianYear);
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Year1988to2019:
						return CalendricalCalculationsHelper.EphemerisCorrection1988to2019(gregorianYear);
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Year1900to1987:
						return CalendricalCalculationsHelper.EphemerisCorrection1900to1987(gregorianYear);
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Year1800to1899:
						return CalendricalCalculationsHelper.EphemerisCorrection1800to1899(gregorianYear);
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Year1700to1799:
						return CalendricalCalculationsHelper.EphemerisCorrection1700to1799(gregorianYear);
					case CalendricalCalculationsHelper.CorrectionAlgorithm.Year1620to1699:
						return CalendricalCalculationsHelper.EphemerisCorrection1620to1699(gregorianYear);
					default:
						goto IL_7F;
					}
				}
				else
				{
					i++;
				}
			}
			IL_7F:
			return CalendricalCalculationsHelper.DefaultEphemerisCorrection(gregorianYear);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000A680A File Offset: 0x000A4A0A
		public static double JulianCenturies(double moment)
		{
			return (moment + CalendricalCalculationsHelper.EphemerisCorrection(moment) - 730120.5) / 36525.0;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000A6828 File Offset: 0x000A4A28
		private static double EquationOfTime(double time)
		{
			double num = CalendricalCalculationsHelper.JulianCenturies(time);
			double num2 = CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.LambdaCoefficients, num);
			double num3 = CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.AnomalyCoefficients, num);
			double num4 = CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.EccentricityCoefficients, num);
			double num5 = CalendricalCalculationsHelper.TanOfDegree(CalendricalCalculationsHelper.Obliquity(num) / 2.0);
			double num6 = num5 * num5;
			double num7 = (num6 * CalendricalCalculationsHelper.SinOfDegree(2.0 * num2) - 2.0 * num4 * CalendricalCalculationsHelper.SinOfDegree(num3) + 4.0 * num4 * num6 * CalendricalCalculationsHelper.SinOfDegree(num3) * CalendricalCalculationsHelper.CosOfDegree(2.0 * num2) - 0.5 * Math.Pow(num6, 2.0) * CalendricalCalculationsHelper.SinOfDegree(4.0 * num2) - 1.25 * Math.Pow(num4, 2.0) * CalendricalCalculationsHelper.SinOfDegree(2.0 * num3)) / 6.283185307179586;
			return Math.CopySign(Math.Min(Math.Abs(num7), 0.5), num7);
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000A6948 File Offset: 0x000A4B48
		private static double AsLocalTime(double apparentMidday, double longitude)
		{
			double time = apparentMidday - CalendricalCalculationsHelper.AsDayFraction(longitude);
			return apparentMidday - CalendricalCalculationsHelper.EquationOfTime(time);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000A6966 File Offset: 0x000A4B66
		public static double Midday(double date, double longitude)
		{
			return CalendricalCalculationsHelper.AsLocalTime(date + 0.5, longitude) - CalendricalCalculationsHelper.AsDayFraction(longitude);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000A6980 File Offset: 0x000A4B80
		private static double InitLongitude(double longitude)
		{
			return CalendricalCalculationsHelper.NormalizeLongitude(longitude + 180.0) - 180.0;
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000A699C File Offset: 0x000A4B9C
		public static double MiddayAtPersianObservationSite(double date)
		{
			return CalendricalCalculationsHelper.Midday(date, CalendricalCalculationsHelper.InitLongitude(52.5));
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000A69B2 File Offset: 0x000A4BB2
		private static double PeriodicTerm(double julianCenturies, int x, double y, double z)
		{
			return (double)x * CalendricalCalculationsHelper.SinOfDegree(y + z * julianCenturies);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000A69C4 File Offset: 0x000A4BC4
		private static double SumLongSequenceOfPeriodicTerms(double julianCenturies)
		{
			return 0.0 + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 403406, 270.54861, 0.9287892) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 195207, 340.19128, 35999.1376958) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 119433, 63.91854, 35999.4089666) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 112392, 331.2622, 35998.7287385) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 3891, 317.843, 71998.20261) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 2819, 86.631, 71998.4403) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 1721, 240.052, 36000.35726) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 660, 310.26, 71997.4812) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 350, 247.23, 32964.4678) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 334, 260.87, -19.441) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 314, 297.82, 445267.1117) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 268, 343.14, 45036.884) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 242, 166.79, 3.1008) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 234, 81.53, 22518.4434) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 158, 3.5, -19.9739) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 132, 132.75, 65928.9345) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 129, 182.95, 9038.0293) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 114, 162.03, 3034.7684) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 99, 29.8, 33718.148) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 93, 266.4, 3034.448) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 86, 249.2, -2280.773) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 78, 157.6, 29929.992) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 72, 257.8, 31556.493) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 68, 185.1, 149.588) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 64, 69.9, 9037.75) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 46, 8.0, 107997.405) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 38, 197.1, -4444.176) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 37, 250.4, 151.771) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 32, 65.3, 67555.316) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 29, 162.7, 31556.08) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 28, 341.5, -4561.54) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 27, 291.6, 107996.706) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 27, 98.5, 1221.655) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 25, 146.7, 62894.167) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 24, 110.0, 31437.369) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 21, 5.2, 14578.298) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 21, 342.6, -31931.757) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 20, 230.9, 34777.243) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 18, 256.1, 1221.999) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 17, 45.3, 62894.511) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 14, 242.9, -4442.039) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 13, 115.2, 107997.909) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 13, 151.8, 119.066) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 13, 285.3, 16859.071) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 12, 53.3, -4.578) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 10, 126.6, 26895.292) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 10, 205.7, -39.127) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 10, 85.9, 12297.536) + CalendricalCalculationsHelper.PeriodicTerm(julianCenturies, 10, 146.1, 90073.778);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000A6F38 File Offset: 0x000A5138
		private static double Aberration(double julianCenturies)
		{
			return 9.74E-05 * CalendricalCalculationsHelper.CosOfDegree(177.63 + 35999.01848 * julianCenturies) - 0.005575;
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000A6F68 File Offset: 0x000A5168
		private static double Nutation(double julianCenturies)
		{
			double degree = CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.CoefficientsA, julianCenturies);
			double degree2 = CalendricalCalculationsHelper.PolynomialSum(CalendricalCalculationsHelper.CoefficientsB, julianCenturies);
			return -0.004778 * CalendricalCalculationsHelper.SinOfDegree(degree) - 0.0003667 * CalendricalCalculationsHelper.SinOfDegree(degree2);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		public static double Compute(double time)
		{
			double num = CalendricalCalculationsHelper.JulianCenturies(time);
			return CalendricalCalculationsHelper.InitLongitude(282.7771834 + 36000.76953744 * num + 5.729577951308232E-06 * CalendricalCalculationsHelper.SumLongSequenceOfPeriodicTerms(num) + CalendricalCalculationsHelper.Aberration(num) + CalendricalCalculationsHelper.Nutation(num));
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000A6FFD File Offset: 0x000A51FD
		public static double AsSeason(double longitude)
		{
			if (longitude >= 0.0)
			{
				return longitude;
			}
			return longitude + 360.0;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x000A7018 File Offset: 0x000A5218
		private static double EstimatePrior(double longitude, double time)
		{
			double num = time - 1.0145616361111112 * CalendricalCalculationsHelper.AsSeason(CalendricalCalculationsHelper.InitLongitude(CalendricalCalculationsHelper.Compute(time) - longitude));
			double num2 = CalendricalCalculationsHelper.InitLongitude(CalendricalCalculationsHelper.Compute(num) - longitude);
			return Math.Min(time, num - 1.0145616361111112 * num2);
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x000A7068 File Offset: 0x000A5268
		internal static long PersianNewYearOnOrBefore(long numberOfDays)
		{
			double date = (double)numberOfDays;
			long num = (long)Math.Floor(CalendricalCalculationsHelper.EstimatePrior(0.0, CalendricalCalculationsHelper.MiddayAtPersianObservationSite(date))) - 1L;
			long num2 = num + 3L;
			long num3;
			for (num3 = num; num3 != num2; num3 += 1L)
			{
				double num4 = CalendricalCalculationsHelper.Compute(CalendricalCalculationsHelper.MiddayAtPersianObservationSite((double)num3));
				if (0.0 <= num4 && num4 <= 2.0)
				{
					break;
				}
			}
			return num3 - 1L;
		}

		// Token: 0x0400093A RID: 2362
		private static readonly long s_startOf1810 = CalendricalCalculationsHelper.GetNumberOfDays(new DateTime(1810, 1, 1));

		// Token: 0x0400093B RID: 2363
		private static readonly long s_startOf1900Century = CalendricalCalculationsHelper.GetNumberOfDays(new DateTime(1900, 1, 1));

		// Token: 0x0400093C RID: 2364
		private static readonly CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap[] s_ephemerisCorrectionTable = new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap[]
		{
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(2020, CalendricalCalculationsHelper.CorrectionAlgorithm.Default),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(1988, CalendricalCalculationsHelper.CorrectionAlgorithm.Year1988to2019),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(1900, CalendricalCalculationsHelper.CorrectionAlgorithm.Year1900to1987),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(1800, CalendricalCalculationsHelper.CorrectionAlgorithm.Year1800to1899),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(1700, CalendricalCalculationsHelper.CorrectionAlgorithm.Year1700to1799),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(1620, CalendricalCalculationsHelper.CorrectionAlgorithm.Year1620to1699),
			new CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap(int.MinValue, CalendricalCalculationsHelper.CorrectionAlgorithm.Default)
		};

		// Token: 0x020002CB RID: 715
		private enum CorrectionAlgorithm
		{
			// Token: 0x0400093E RID: 2366
			Default,
			// Token: 0x0400093F RID: 2367
			Year1988to2019,
			// Token: 0x04000940 RID: 2368
			Year1900to1987,
			// Token: 0x04000941 RID: 2369
			Year1800to1899,
			// Token: 0x04000942 RID: 2370
			Year1700to1799,
			// Token: 0x04000943 RID: 2371
			Year1620to1699
		}

		// Token: 0x020002CC RID: 716
		private readonly struct EphemerisCorrectionAlgorithmMap
		{
			// Token: 0x06003438 RID: 13368 RVA: 0x000A7192 File Offset: 0x000A5392
			public EphemerisCorrectionAlgorithmMap(int year, CalendricalCalculationsHelper.CorrectionAlgorithm algorithm)
			{
				this._lowestYear = year;
				this._algorithm = algorithm;
			}

			// Token: 0x04000944 RID: 2372
			internal readonly int _lowestYear;

			// Token: 0x04000945 RID: 2373
			internal readonly CalendricalCalculationsHelper.CorrectionAlgorithm _algorithm;
		}
	}
}

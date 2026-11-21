using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000305 RID: 773
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class NumberFormatInfo : IFormatProvider, ICloneable
	{
		// Token: 0x06003843 RID: 14403 RVA: 0x000B971C File Offset: 0x000B791C
		public NumberFormatInfo()
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000B9820 File Offset: 0x000B7A20
		private static void VerifyNativeDigits(string[] nativeDig, string propertyName)
		{
			ArgumentNullException.ThrowIfNull(nativeDig, "nativeDig");
			if (nativeDig.Length != 10)
			{
				throw new ArgumentException(SR.Argument_InvalidNativeDigitCount, propertyName);
			}
			for (int i = 0; i < nativeDig.Length; i++)
			{
				if (nativeDig[i] == null)
				{
					throw new ArgumentNullException(propertyName, SR.ArgumentNull_ArrayValue);
				}
				if (nativeDig[i].Length != 1)
				{
					if (nativeDig[i].Length != 2)
					{
						throw new ArgumentException(SR.Argument_InvalidNativeDigitValue, propertyName);
					}
					if (!char.IsSurrogatePair(nativeDig[i][0], nativeDig[i][1]))
					{
						throw new ArgumentException(SR.Argument_InvalidNativeDigitValue, propertyName);
					}
				}
				if (CharUnicodeInfo.GetDecimalDigitValue(nativeDig[i], 0) != i && CharUnicodeInfo.GetUnicodeCategory(nativeDig[i], 0) != UnicodeCategory.PrivateUse)
				{
					throw new ArgumentException(SR.Argument_InvalidNativeDigitValue, propertyName);
				}
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x000B98DC File Offset: 0x000B7ADC
		private static void VerifyDigitSubstitution(DigitShapes digitSub, string propertyName)
		{
			if (digitSub > DigitShapes.NativeNational)
			{
				throw new ArgumentException(SR.Argument_InvalidDigitSubstitution, propertyName);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x000B98EE File Offset: 0x000B7AEE
		internal bool HasInvariantNumberSigns
		{
			get
			{
				return this._hasInvariantNumberSigns;
			}
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x000B98F6 File Offset: 0x000B7AF6
		internal bool AllowHyphenDuringParsing()
		{
			return this._allowHyphenDuringParsing;
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x000B9900 File Offset: 0x000B7B00
		private void InitializeInvariantAndNegativeSignFlags()
		{
			this._hasInvariantNumberSigns = (this._positiveSign == "+" && this._negativeSign == "-");
			bool flag = this._negativeSign.Length == 1;
			if (flag)
			{
				char c = this._negativeSign[0];
				if (c <= '₋')
				{
					if (c != '‒' && c != '⁻' && c != '₋')
					{
						goto IL_9A;
					}
				}
				else if (c <= '➖')
				{
					if (c != '−' && c != '➖')
					{
						goto IL_9A;
					}
				}
				else if (c != '﹣' && c != '－')
				{
					goto IL_9A;
				}
				bool flag2 = true;
				goto IL_9C;
				IL_9A:
				flag2 = false;
				IL_9C:
				flag = flag2;
			}
			this._allowHyphenDuringParsing = flag;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x000B99B4 File Offset: 0x000B7BB4
		internal NumberFormatInfo(CultureData cultureData)
		{
			if (cultureData != null)
			{
				cultureData.GetNFIValues(this);
				this.InitializeInvariantAndNegativeSignFlags();
			}
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x000B9AC7 File Offset: 0x000B7CC7
		private void VerifyWritable()
		{
			if (this._isReadOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x000B9ADC File Offset: 0x000B7CDC
		public static NumberFormatInfo InvariantInfo
		{
			get
			{
				NumberFormatInfo result;
				if ((result = NumberFormatInfo.s_invariantInfo) == null)
				{
					result = (NumberFormatInfo.s_invariantInfo = CultureInfo.InvariantCulture.NumberFormat);
				}
				return result;
			}
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x000B9AF7 File Offset: 0x000B7CF7
		public static NumberFormatInfo GetInstance([Nullable(2)] IFormatProvider formatProvider)
		{
			if (formatProvider != null)
			{
				return NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(formatProvider);
			}
			return NumberFormatInfo.CurrentInfo;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x000B9B08 File Offset: 0x000B7D08
		public object Clone()
		{
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)base.MemberwiseClone();
			numberFormatInfo._isReadOnly = false;
			return numberFormatInfo;
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x000B9B1C File Offset: 0x000B7D1C
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x000B9B24 File Offset: 0x000B7D24
		public int CurrencyDecimalDigits
		{
			get
			{
				return this._currencyDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 99);
				}
				this.VerifyWritable();
				this._currencyDecimalDigits = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x000B9B4A File Offset: 0x000B7D4A
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x000B9B52 File Offset: 0x000B7D52
		public string CurrencyDecimalSeparator
		{
			get
			{
				return this._currencyDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentException.ThrowIfNullOrEmpty(value, "value");
				this._currencyDecimalSeparator = value;
				this._currencyDecimalSeparatorUtf8 = null;
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x000B9B74 File Offset: 0x000B7D74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> CurrencyDecimalSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._currencyDecimalSeparatorUtf8) == null)
				{
					array = (this._currencyDecimalSeparatorUtf8 = Encoding.UTF8.GetBytes(this._currencyDecimalSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._currencyDecimalSeparator);
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x000B9BDA File Offset: 0x000B7DDA
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x000B9BE4 File Offset: 0x000B7DE4
		internal static void CheckGroupSize(string propName, int[] groupSize)
		{
			int i = 0;
			while (i < groupSize.Length)
			{
				if (groupSize[i] < 1)
				{
					if (i == groupSize.Length - 1 && groupSize[i] == 0)
					{
						return;
					}
					throw new ArgumentException(SR.Argument_InvalidGroupSize, propName);
				}
				else
				{
					if (groupSize[i] > 9)
					{
						throw new ArgumentException(SR.Argument_InvalidGroupSize, propName);
					}
					i++;
				}
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x000B9C32 File Offset: 0x000B7E32
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x000B9C44 File Offset: 0x000B7E44
		public int[] CurrencyGroupSizes
		{
			get
			{
				return (int[])this._currencyGroupSizes.Clone();
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				int[] array = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("value", array);
				this._currencyGroupSizes = array;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x000B9C80 File Offset: 0x000B7E80
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x000B9C94 File Offset: 0x000B7E94
		public int[] NumberGroupSizes
		{
			get
			{
				return (int[])this._numberGroupSizes.Clone();
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				int[] array = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("value", array);
				this._numberGroupSizes = array;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x000B9CD0 File Offset: 0x000B7ED0
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x000B9CE4 File Offset: 0x000B7EE4
		public int[] PercentGroupSizes
		{
			get
			{
				return (int[])this._percentGroupSizes.Clone();
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				int[] array = (int[])value.Clone();
				NumberFormatInfo.CheckGroupSize("value", array);
				this._percentGroupSizes = array;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x000B9D20 File Offset: 0x000B7F20
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x000B9D28 File Offset: 0x000B7F28
		public string CurrencyGroupSeparator
		{
			get
			{
				return this._currencyGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentNullException.ThrowIfNull(value, "value");
				this._currencyGroupSeparator = value;
				this._currencyGroupSeparatorUtf8 = null;
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x000B9D4C File Offset: 0x000B7F4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> CurrencyGroupSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._currencyGroupSeparatorUtf8) == null)
				{
					array = (this._currencyGroupSeparatorUtf8 = Encoding.UTF8.GetBytes(this._currencyGroupSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._currencyGroupSeparator);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600385E RID: 14430 RVA: 0x000B9DB2 File Offset: 0x000B7FB2
		// (set) Token: 0x0600385F RID: 14431 RVA: 0x000B9DBA File Offset: 0x000B7FBA
		public string CurrencySymbol
		{
			get
			{
				return this._currencySymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._currencySymbol = value;
				this._currencySymbolUtf8 = null;
			}
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000B9DDC File Offset: 0x000B7FDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> CurrencySymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._currencySymbolUtf8) == null)
				{
					array = (this._currencySymbolUtf8 = Encoding.UTF8.GetBytes(this._currencySymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._currencySymbol);
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x000B9E44 File Offset: 0x000B8044
		public static NumberFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				if (!currentCulture._isInherited)
				{
					NumberFormatInfo numInfo = currentCulture._numInfo;
					if (numInfo != null)
					{
						return numInfo;
					}
				}
				return (NumberFormatInfo)currentCulture.GetFormat(typeof(NumberFormatInfo));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x000B9E80 File Offset: 0x000B8080
		// (set) Token: 0x06003863 RID: 14435 RVA: 0x000B9E88 File Offset: 0x000B8088
		public string NaNSymbol
		{
			get
			{
				return this._nanSymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._nanSymbol = value;
				this._nanSymbolUtf8 = null;
			}
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000B9EAC File Offset: 0x000B80AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> NaNSymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._nanSymbolUtf8) == null)
				{
					array = (this._nanSymbolUtf8 = Encoding.UTF8.GetBytes(this._nanSymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._nanSymbol);
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x000B9F12 File Offset: 0x000B8112
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x000B9F1A File Offset: 0x000B811A
		public int CurrencyNegativePattern
		{
			get
			{
				return this._currencyNegativePattern;
			}
			set
			{
				if (value < 0 || value > 16)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 16);
				}
				this.VerifyWritable();
				this._currencyNegativePattern = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x000B9F40 File Offset: 0x000B8140
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x000B9F48 File Offset: 0x000B8148
		public int NumberNegativePattern
		{
			get
			{
				return this._numberNegativePattern;
			}
			set
			{
				if (value < 0 || value > 4)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 4);
				}
				this.VerifyWritable();
				this._numberNegativePattern = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x000B9F6C File Offset: 0x000B816C
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x000B9F74 File Offset: 0x000B8174
		public int PercentPositivePattern
		{
			get
			{
				return this._percentPositivePattern;
			}
			set
			{
				if (value < 0 || value > 3)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 3);
				}
				this.VerifyWritable();
				this._percentPositivePattern = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x000B9F98 File Offset: 0x000B8198
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x000B9FA0 File Offset: 0x000B81A0
		public int PercentNegativePattern
		{
			get
			{
				return this._percentNegativePattern;
			}
			set
			{
				if (value < 0 || value > 11)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 11);
				}
				this.VerifyWritable();
				this._percentNegativePattern = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x000B9FC6 File Offset: 0x000B81C6
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x000B9FCE File Offset: 0x000B81CE
		public string NegativeInfinitySymbol
		{
			get
			{
				return this._negativeInfinitySymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._negativeInfinitySymbol = value;
				this._negativeInfinitySymbolUtf8 = null;
			}
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x000B9FF0 File Offset: 0x000B81F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> NegativeInfinitySymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._negativeInfinitySymbolUtf8) == null)
				{
					array = (this._negativeInfinitySymbolUtf8 = Encoding.UTF8.GetBytes(this._negativeInfinitySymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._negativeInfinitySymbol);
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x000BA056 File Offset: 0x000B8256
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x000BA05E File Offset: 0x000B825E
		public string NegativeSign
		{
			get
			{
				return this._negativeSign;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._negativeSign = value;
				this._negativeSignUtf8 = null;
				this.InitializeInvariantAndNegativeSignFlags();
			}
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x000BA088 File Offset: 0x000B8288
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> NegativeSignTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._negativeSignUtf8) == null)
				{
					array = (this._negativeSignUtf8 = Encoding.UTF8.GetBytes(this._negativeSign));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._negativeSign);
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x000BA0EE File Offset: 0x000B82EE
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x000BA0F6 File Offset: 0x000B82F6
		public int NumberDecimalDigits
		{
			get
			{
				return this._numberDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 99);
				}
				this.VerifyWritable();
				this._numberDecimalDigits = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x000BA11C File Offset: 0x000B831C
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x000BA124 File Offset: 0x000B8324
		public string NumberDecimalSeparator
		{
			get
			{
				return this._numberDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentException.ThrowIfNullOrEmpty(value, "value");
				this._numberDecimalSeparator = value;
				this._numberDecimalSeparatorUtf8 = null;
			}
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x000BA148 File Offset: 0x000B8348
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> NumberDecimalSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._numberDecimalSeparatorUtf8) == null)
				{
					array = (this._numberDecimalSeparatorUtf8 = Encoding.UTF8.GetBytes(this._numberDecimalSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._numberDecimalSeparator);
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x000BA1AE File Offset: 0x000B83AE
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x000BA1B6 File Offset: 0x000B83B6
		public string NumberGroupSeparator
		{
			get
			{
				return this._numberGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentNullException.ThrowIfNull(value, "value");
				this._numberGroupSeparator = value;
				this._numberGroupSeparatorUtf8 = null;
			}
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x000BA1D8 File Offset: 0x000B83D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> NumberGroupSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._numberGroupSeparatorUtf8) == null)
				{
					array = (this._numberGroupSeparatorUtf8 = Encoding.UTF8.GetBytes(this._numberGroupSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._numberGroupSeparator);
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x000BA23E File Offset: 0x000B843E
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x000BA246 File Offset: 0x000B8446
		public int CurrencyPositivePattern
		{
			get
			{
				return this._currencyPositivePattern;
			}
			set
			{
				if (value < 0 || value > 3)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 3);
				}
				this.VerifyWritable();
				this._currencyPositivePattern = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x000BA26A File Offset: 0x000B846A
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x000BA272 File Offset: 0x000B8472
		public string PositiveInfinitySymbol
		{
			get
			{
				return this._positiveInfinitySymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._positiveInfinitySymbol = value;
				this._positiveInfinitySymbolUtf8 = null;
			}
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x000BA294 File Offset: 0x000B8494
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PositiveInfinitySymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._positiveInfinitySymbolUtf8) == null)
				{
					array = (this._positiveInfinitySymbolUtf8 = Encoding.UTF8.GetBytes(this._positiveInfinitySymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._positiveInfinitySymbol);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x000BA2FA File Offset: 0x000B84FA
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x000BA302 File Offset: 0x000B8502
		public string PositiveSign
		{
			get
			{
				return this._positiveSign;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._positiveSign = value;
				this._positiveSignUtf8 = null;
				this.InitializeInvariantAndNegativeSignFlags();
			}
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000BA32C File Offset: 0x000B852C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PositiveSignTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._positiveSignUtf8) == null)
				{
					array = (this._positiveSignUtf8 = Encoding.UTF8.GetBytes(this._positiveSign));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._positiveSign);
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x000BA392 File Offset: 0x000B8592
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x000BA39A File Offset: 0x000B859A
		public int PercentDecimalDigits
		{
			get
			{
				return this._percentDecimalDigits;
			}
			set
			{
				if (value < 0 || value > 99)
				{
					ThrowHelper.ThrowArgumentOutOfRange_Range<int>("value", value, 0, 99);
				}
				this.VerifyWritable();
				this._percentDecimalDigits = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x000BA3C0 File Offset: 0x000B85C0
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x000BA3C8 File Offset: 0x000B85C8
		public string PercentDecimalSeparator
		{
			get
			{
				return this._percentDecimalSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentException.ThrowIfNullOrEmpty(value, "value");
				this._percentDecimalSeparator = value;
				this._percentDecimalSeparatorUtf8 = null;
			}
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x000BA3EC File Offset: 0x000B85EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PercentDecimalSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._percentDecimalSeparatorUtf8) == null)
				{
					array = (this._percentDecimalSeparatorUtf8 = Encoding.UTF8.GetBytes(this._percentDecimalSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._percentDecimalSeparator);
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x000BA452 File Offset: 0x000B8652
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x000BA45A File Offset: 0x000B865A
		public string PercentGroupSeparator
		{
			get
			{
				return this._percentGroupSeparator;
			}
			set
			{
				this.VerifyWritable();
				ArgumentNullException.ThrowIfNull(value, "value");
				this._percentGroupSeparator = value;
				this._percentGroupSeparatorUtf8 = null;
			}
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x000BA47C File Offset: 0x000B867C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PercentGroupSeparatorTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._percentGroupSeparatorUtf8) == null)
				{
					array = (this._percentGroupSeparatorUtf8 = Encoding.UTF8.GetBytes(this._percentGroupSeparator));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._percentGroupSeparator);
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x000BA4E2 File Offset: 0x000B86E2
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x000BA4EA File Offset: 0x000B86EA
		public string PercentSymbol
		{
			get
			{
				return this._percentSymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._percentSymbol = value;
				this._percentSymbolUtf8 = null;
			}
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x000BA50C File Offset: 0x000B870C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PercentSymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._percentSymbolUtf8) == null)
				{
					array = (this._percentSymbolUtf8 = Encoding.UTF8.GetBytes(this._percentSymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._percentSymbol);
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x000BA572 File Offset: 0x000B8772
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x000BA57A File Offset: 0x000B877A
		public string PerMilleSymbol
		{
			get
			{
				return this._perMilleSymbol;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._perMilleSymbol = value;
				this._perMilleSymbolUtf8 = null;
			}
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x000BA59C File Offset: 0x000B879C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<TChar> PerMilleSymbolTChar<[IsUnmanaged] TChar>() where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				byte[] array;
				if ((array = this._perMilleSymbolUtf8) == null)
				{
					array = (this._perMilleSymbolUtf8 = Encoding.UTF8.GetBytes(this._perMilleSymbol));
				}
				return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(array);
			}
			return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(this._perMilleSymbol);
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x000BA602 File Offset: 0x000B8802
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x000BA614 File Offset: 0x000B8814
		public string[] NativeDigits
		{
			get
			{
				return (string[])this._nativeDigits.Clone();
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyNativeDigits(value, "value");
				this._nativeDigits = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x000BA62E File Offset: 0x000B882E
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x000BA636 File Offset: 0x000B8836
		public DigitShapes DigitSubstitution
		{
			get
			{
				return (DigitShapes)this._digitSubstitution;
			}
			set
			{
				this.VerifyWritable();
				NumberFormatInfo.VerifyDigitSubstitution(value, "value");
				this._digitSubstitution = (int)value;
			}
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x000BA650 File Offset: 0x000B8850
		[NullableContext(2)]
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(NumberFormatInfo)))
			{
				return null;
			}
			return this;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x000BA667 File Offset: 0x000B8867
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			ArgumentNullException.ThrowIfNull(nfi, "nfi");
			if (nfi.IsReadOnly)
			{
				return nfi;
			}
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)nfi.MemberwiseClone();
			numberFormatInfo._isReadOnly = true;
			return numberFormatInfo;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x000BA690 File Offset: 0x000B8890
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol)) != NumberStyles.None && (style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowHexSpecifier)) != NumberStyles.None && (style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowBinarySpecifier)) != NumberStyles.None)
			{
				NumberFormatInfo.<ValidateParseStyleInteger>g__ThrowInvalid|165_0(style);
			}
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x000BA6B3 File Offset: 0x000B88B3
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol)) != NumberStyles.None)
			{
				NumberFormatInfo.<ValidateParseStyleFloatingPoint>g__ThrowInvalid|166_0(style);
			}
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x000BA740 File Offset: 0x000B8940
		[CompilerGenerated]
		internal static NumberFormatInfo <GetInstance>g__GetProviderNonNull|58_0(IFormatProvider provider)
		{
			CultureInfo cultureInfo = provider as CultureInfo;
			if (cultureInfo != null && !cultureInfo._isInherited)
			{
				return cultureInfo._numInfo ?? cultureInfo.NumberFormat;
			}
			NumberFormatInfo result;
			if ((result = (provider as NumberFormatInfo)) == null)
			{
				result = ((provider.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo) ?? NumberFormatInfo.CurrentInfo);
			}
			return result;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x000BA798 File Offset: 0x000B8998
		[CompilerGenerated]
		internal static void <ValidateParseStyleInteger>g__ThrowInvalid|165_0(NumberStyles value)
		{
			throw new ArgumentException(((value & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier | NumberStyles.AllowBinarySpecifier)) != NumberStyles.None) ? SR.Argument_InvalidNumberStyles : SR.Arg_InvalidHexBinaryStyle, "style");
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x000BA7B9 File Offset: 0x000B89B9
		[CompilerGenerated]
		internal static void <ValidateParseStyleFloatingPoint>g__ThrowInvalid|166_0(NumberStyles value)
		{
			throw new ArgumentException(((value & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier | NumberStyles.AllowBinarySpecifier)) != NumberStyles.None) ? SR.Argument_InvalidNumberStyles : SR.Arg_HexBinaryStylesNotSupported, "style");
		}

		// Token: 0x04000AFA RID: 2810
		private static NumberFormatInfo s_invariantInfo;

		// Token: 0x04000AFB RID: 2811
		internal static readonly string[] s_asciiDigits = new string[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9"
		};

		// Token: 0x04000AFC RID: 2812
		internal static readonly int[] s_intArrayWithElement3 = new int[]
		{
			3
		};

		// Token: 0x04000AFD RID: 2813
		internal int[] _numberGroupSizes = NumberFormatInfo.s_intArrayWithElement3;

		// Token: 0x04000AFE RID: 2814
		internal int[] _currencyGroupSizes = NumberFormatInfo.s_intArrayWithElement3;

		// Token: 0x04000AFF RID: 2815
		internal int[] _percentGroupSizes = NumberFormatInfo.s_intArrayWithElement3;

		// Token: 0x04000B00 RID: 2816
		internal string _positiveSign = "+";

		// Token: 0x04000B01 RID: 2817
		internal string _negativeSign = "-";

		// Token: 0x04000B02 RID: 2818
		internal string _numberDecimalSeparator = ".";

		// Token: 0x04000B03 RID: 2819
		internal string _numberGroupSeparator = ",";

		// Token: 0x04000B04 RID: 2820
		internal string _currencyGroupSeparator = ",";

		// Token: 0x04000B05 RID: 2821
		internal string _currencyDecimalSeparator = ".";

		// Token: 0x04000B06 RID: 2822
		internal string _currencySymbol = "¤";

		// Token: 0x04000B07 RID: 2823
		internal string _nanSymbol = "NaN";

		// Token: 0x04000B08 RID: 2824
		internal string _positiveInfinitySymbol = "Infinity";

		// Token: 0x04000B09 RID: 2825
		internal string _negativeInfinitySymbol = "-Infinity";

		// Token: 0x04000B0A RID: 2826
		internal string _percentDecimalSeparator = ".";

		// Token: 0x04000B0B RID: 2827
		internal string _percentGroupSeparator = ",";

		// Token: 0x04000B0C RID: 2828
		internal string _percentSymbol = "%";

		// Token: 0x04000B0D RID: 2829
		internal string _perMilleSymbol = "‰";

		// Token: 0x04000B0E RID: 2830
		internal byte[] _positiveSignUtf8;

		// Token: 0x04000B0F RID: 2831
		internal byte[] _negativeSignUtf8;

		// Token: 0x04000B10 RID: 2832
		internal byte[] _currencySymbolUtf8;

		// Token: 0x04000B11 RID: 2833
		internal byte[] _numberDecimalSeparatorUtf8;

		// Token: 0x04000B12 RID: 2834
		internal byte[] _currencyDecimalSeparatorUtf8;

		// Token: 0x04000B13 RID: 2835
		internal byte[] _currencyGroupSeparatorUtf8;

		// Token: 0x04000B14 RID: 2836
		internal byte[] _numberGroupSeparatorUtf8;

		// Token: 0x04000B15 RID: 2837
		internal byte[] _percentSymbolUtf8;

		// Token: 0x04000B16 RID: 2838
		internal byte[] _percentDecimalSeparatorUtf8;

		// Token: 0x04000B17 RID: 2839
		internal byte[] _percentGroupSeparatorUtf8;

		// Token: 0x04000B18 RID: 2840
		internal byte[] _perMilleSymbolUtf8;

		// Token: 0x04000B19 RID: 2841
		internal byte[] _nanSymbolUtf8;

		// Token: 0x04000B1A RID: 2842
		internal byte[] _positiveInfinitySymbolUtf8;

		// Token: 0x04000B1B RID: 2843
		internal byte[] _negativeInfinitySymbolUtf8;

		// Token: 0x04000B1C RID: 2844
		internal string[] _nativeDigits = NumberFormatInfo.s_asciiDigits;

		// Token: 0x04000B1D RID: 2845
		internal int _numberDecimalDigits = 2;

		// Token: 0x04000B1E RID: 2846
		internal int _currencyDecimalDigits = 2;

		// Token: 0x04000B1F RID: 2847
		internal int _currencyPositivePattern;

		// Token: 0x04000B20 RID: 2848
		internal int _currencyNegativePattern;

		// Token: 0x04000B21 RID: 2849
		internal int _numberNegativePattern = 1;

		// Token: 0x04000B22 RID: 2850
		internal int _percentPositivePattern;

		// Token: 0x04000B23 RID: 2851
		internal int _percentNegativePattern;

		// Token: 0x04000B24 RID: 2852
		internal int _percentDecimalDigits = 2;

		// Token: 0x04000B25 RID: 2853
		internal int _digitSubstitution = 1;

		// Token: 0x04000B26 RID: 2854
		internal bool _isReadOnly;

		// Token: 0x04000B27 RID: 2855
		private bool _hasInvariantNumberSigns = true;

		// Token: 0x04000B28 RID: 2856
		private bool _allowHyphenDuringParsing;
	}
}

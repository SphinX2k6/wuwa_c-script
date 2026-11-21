using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;

namespace System
{
	// Token: 0x020000E9 RID: 233
	[NullableContext(2)]
	[Nullable(0)]
	public static class Convert
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00022820 File Offset: 0x00020A20
		private unsafe static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
		{
			ref char reference = ref MemoryMarshal.GetReference<char>(utf16);
			ref byte reference2 = ref MemoryMarshal.GetReference<byte>(bytes);
			int num = utf16.Length & -4;
			int length = bytes.Length;
			int i = 0;
			int num2 = 0;
			if (utf16.Length != 0)
			{
				ref sbyte reference3 = ref MemoryMarshal.GetReference<sbyte>(Convert.DecodingMap);
				int num3;
				if (length >= (num >> 2) * 3)
				{
					num3 = num - 4;
				}
				else
				{
					num3 = length / 3 * 4;
				}
				while (i < num3)
				{
					int num4 = Convert.Decode(Unsafe.Add<char>(ref reference, i), ref reference3);
					if (num4 < 0)
					{
						IL_200:
						consumed = i;
						written = num2;
						return false;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num4);
					num2 += 3;
					i += 4;
				}
				if (num3 != num - 4 || i == num)
				{
					goto IL_200;
				}
				int num5 = (int)(*Unsafe.Add<char>(ref reference, num - 4));
				int num6 = (int)(*Unsafe.Add<char>(ref reference, num - 3));
				int num7 = (int)(*Unsafe.Add<char>(ref reference, num - 2));
				int num8 = (int)(*Unsafe.Add<char>(ref reference, num - 1));
				if (((long)(num5 | num6 | num7 | num8) & (long)((ulong)-256)) != 0L)
				{
					goto IL_200;
				}
				num5 = (int)(*Unsafe.Add<sbyte>(ref reference3, num5));
				num6 = (int)(*Unsafe.Add<sbyte>(ref reference3, num6));
				num5 <<= 18;
				num6 <<= 12;
				num5 |= num6;
				if (num8 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref reference3, num7));
					num8 = (int)(*Unsafe.Add<sbyte>(ref reference3, num8));
					num7 <<= 6;
					num5 |= num8;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 3)
					{
						goto IL_200;
					}
					Convert.WriteThreeLowOrderBytes(Unsafe.Add<byte>(ref reference2, num2), num5);
					num2 += 3;
				}
				else if (num7 != 61)
				{
					num7 = (int)(*Unsafe.Add<sbyte>(ref reference3, num7));
					num7 <<= 6;
					num5 |= num7;
					if (num5 < 0 || num2 > length - 2)
					{
						goto IL_200;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					*Unsafe.Add<byte>(ref reference2, num2 + 1) = (byte)(num5 >> 8);
					num2 += 2;
				}
				else
				{
					if (num5 < 0 || num2 > length - 1)
					{
						goto IL_200;
					}
					*Unsafe.Add<byte>(ref reference2, num2) = (byte)(num5 >> 16);
					num2++;
				}
				i += 4;
				if (num != utf16.Length)
				{
					goto IL_200;
				}
			}
			consumed = i;
			written = num2;
			return true;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00022A38 File Offset: 0x00020C38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			int num = (int)encodedChars;
			int num2 = (int)(*Unsafe.Add<char>(ref encodedChars, 1));
			int num3 = (int)(*Unsafe.Add<char>(ref encodedChars, 2));
			int num4 = (int)(*Unsafe.Add<char>(ref encodedChars, 3));
			if (((long)(num | num2 | num3 | num4) & (long)((ulong)-256)) != 0L)
			{
				return -1;
			}
			num = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num));
			num2 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num2));
			num3 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num3));
			num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, num4));
			num <<= 18;
			num2 <<= 12;
			num3 <<= 6;
			num |= num4;
			num2 |= num3;
			return num | num2;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00022AB5 File Offset: 0x00020CB5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
			destination = (byte)(value >> 16);
			*Unsafe.Add<byte>(ref destination, 1) = (byte)(value >> 8);
			*Unsafe.Add<byte>(ref destination, 2) = (byte)value;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00022AD4 File Offset: 0x00020CD4
		[Nullable(0)]
		private unsafe static ReadOnlySpan<sbyte> DecodingMap
		{
			get
			{
				return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8), 256);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00022AE8 File Offset: 0x00020CE8
		public static TypeCode GetTypeCode(object value)
		{
			if (value == null)
			{
				return TypeCode.Empty;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.GetTypeCode();
			}
			return TypeCode.Object;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00022B0C File Offset: 0x00020D0C
		public static bool IsDBNull([NotNullWhen(true)] object value)
		{
			if (value == System.DBNull.Value)
			{
				return true;
			}
			IConvertible convertible = value as IConvertible;
			return convertible != null && convertible.GetTypeCode() == TypeCode.DBNull;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00022B38 File Offset: 0x00020D38
		[return: NotNullIfNotNull("value")]
		public static object ChangeType(object value, TypeCode typeCode)
		{
			return Convert.ChangeType(value, typeCode, CultureInfo.CurrentCulture);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00022B48 File Offset: 0x00020D48
		[return: NotNullIfNotNull("value")]
		public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
		{
			if (value == null && (typeCode == TypeCode.Empty || typeCode == TypeCode.String || typeCode == TypeCode.Object))
			{
				return null;
			}
			IConvertible convertible = value as IConvertible;
			if (convertible == null)
			{
				throw new InvalidCastException(SR.InvalidCast_IConvertible);
			}
			switch (typeCode)
			{
			case TypeCode.Empty:
				throw new InvalidCastException(SR.InvalidCast_Empty);
			case TypeCode.Object:
				return value;
			case TypeCode.DBNull:
				throw new InvalidCastException(SR.InvalidCast_DBNull);
			case TypeCode.Boolean:
				return convertible.ToBoolean(provider);
			case TypeCode.Char:
				return convertible.ToChar(provider);
			case TypeCode.SByte:
				return convertible.ToSByte(provider);
			case TypeCode.Byte:
				return convertible.ToByte(provider);
			case TypeCode.Int16:
				return convertible.ToInt16(provider);
			case TypeCode.UInt16:
				return convertible.ToUInt16(provider);
			case TypeCode.Int32:
				return convertible.ToInt32(provider);
			case TypeCode.UInt32:
				return convertible.ToUInt32(provider);
			case TypeCode.Int64:
				return convertible.ToInt64(provider);
			case TypeCode.UInt64:
				return convertible.ToUInt64(provider);
			case TypeCode.Single:
				return convertible.ToSingle(provider);
			case TypeCode.Double:
				return convertible.ToDouble(provider);
			case TypeCode.Decimal:
				return convertible.ToDecimal(provider);
			case TypeCode.DateTime:
				return convertible.ToDateTime(provider);
			case TypeCode.String:
				return convertible.ToString(provider);
			}
			throw new ArgumentException(SR.Arg_UnknownTypeCode);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00022CEC File Offset: 0x00020EEC
		internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			ArgumentNullException.ThrowIfNull(targetType, "targetType");
			if (value.GetType() == targetType)
			{
				return value;
			}
			if (targetType == typeof(bool))
			{
				return value.ToBoolean(provider);
			}
			if (targetType == typeof(char))
			{
				return value.ToChar(provider);
			}
			if (targetType == typeof(sbyte))
			{
				return value.ToSByte(provider);
			}
			if (targetType == typeof(byte))
			{
				return value.ToByte(provider);
			}
			if (targetType == typeof(short))
			{
				return value.ToInt16(provider);
			}
			if (targetType == typeof(ushort))
			{
				return value.ToUInt16(provider);
			}
			if (targetType == typeof(int))
			{
				return value.ToInt32(provider);
			}
			if (targetType == typeof(uint))
			{
				return value.ToUInt32(provider);
			}
			if (targetType == typeof(long))
			{
				return value.ToInt64(provider);
			}
			if (targetType == typeof(ulong))
			{
				return value.ToUInt64(provider);
			}
			if (targetType == typeof(float))
			{
				return value.ToSingle(provider);
			}
			if (targetType == typeof(double))
			{
				return value.ToDouble(provider);
			}
			if (targetType == typeof(decimal))
			{
				return value.ToDecimal(provider);
			}
			if (targetType == typeof(DateTime))
			{
				return value.ToDateTime(provider);
			}
			if (targetType == typeof(string))
			{
				return value.ToString(provider);
			}
			if (targetType == typeof(object))
			{
				return value;
			}
			if (targetType == typeof(Enum))
			{
				return (Enum)value;
			}
			if (targetType == typeof(DBNull))
			{
				throw new InvalidCastException(SR.InvalidCast_DBNull);
			}
			if (targetType == typeof(Empty))
			{
				throw new InvalidCastException(SR.InvalidCast_Empty);
			}
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, value.GetType().FullName, targetType.FullName));
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00022F03 File Offset: 0x00021103
		[return: NotNullIfNotNull("value")]
		public static object ChangeType(object value, [Nullable(1)] Type conversionType)
		{
			return Convert.ChangeType(value, conversionType, CultureInfo.CurrentCulture);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00022F14 File Offset: 0x00021114
		[return: NotNullIfNotNull("value")]
		public static object ChangeType(object value, [Nullable(1)] Type conversionType, IFormatProvider provider)
		{
			ArgumentNullException.ThrowIfNull(conversionType, "conversionType");
			if (value == null)
			{
				if (conversionType.IsValueType)
				{
					throw new InvalidCastException(SR.InvalidCast_CannotCastNullToValueType);
				}
				return null;
			}
			else
			{
				IConvertible convertible = value as IConvertible;
				if (convertible == null)
				{
					if (value.GetType() == conversionType)
					{
						return value;
					}
					throw new InvalidCastException(SR.InvalidCast_IConvertible);
				}
				else
				{
					if (conversionType == typeof(bool))
					{
						return convertible.ToBoolean(provider);
					}
					if (conversionType == typeof(char))
					{
						return convertible.ToChar(provider);
					}
					if (conversionType == typeof(sbyte))
					{
						return convertible.ToSByte(provider);
					}
					if (conversionType == typeof(byte))
					{
						return convertible.ToByte(provider);
					}
					if (conversionType == typeof(short))
					{
						return convertible.ToInt16(provider);
					}
					if (conversionType == typeof(ushort))
					{
						return convertible.ToUInt16(provider);
					}
					if (conversionType == typeof(int))
					{
						return convertible.ToInt32(provider);
					}
					if (conversionType == typeof(uint))
					{
						return convertible.ToUInt32(provider);
					}
					if (conversionType == typeof(long))
					{
						return convertible.ToInt64(provider);
					}
					if (conversionType == typeof(ulong))
					{
						return convertible.ToUInt64(provider);
					}
					if (conversionType == typeof(float))
					{
						return convertible.ToSingle(provider);
					}
					if (conversionType == typeof(double))
					{
						return convertible.ToDouble(provider);
					}
					if (conversionType == typeof(decimal))
					{
						return convertible.ToDecimal(provider);
					}
					if (conversionType == typeof(DateTime))
					{
						return convertible.ToDateTime(provider);
					}
					if (conversionType == typeof(string))
					{
						return convertible.ToString(provider);
					}
					if (conversionType == typeof(object))
					{
						return value;
					}
					return convertible.ToType(conversionType, provider);
				}
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00023101 File Offset: 0x00021301
		[DoesNotReturn]
		private static void ThrowCharOverflowException()
		{
			throw new OverflowException(SR.Overflow_Char);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0002310D File Offset: 0x0002130D
		[DoesNotReturn]
		private static void ThrowByteOverflowException()
		{
			throw new OverflowException(SR.Overflow_Byte);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00023119 File Offset: 0x00021319
		[DoesNotReturn]
		private static void ThrowSByteOverflowException()
		{
			throw new OverflowException(SR.Overflow_SByte);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00023125 File Offset: 0x00021325
		[DoesNotReturn]
		private static void ThrowInt16OverflowException()
		{
			throw new OverflowException(SR.Overflow_Int16);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00023131 File Offset: 0x00021331
		[DoesNotReturn]
		private static void ThrowUInt16OverflowException()
		{
			throw new OverflowException(SR.Overflow_UInt16);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0002313D File Offset: 0x0002133D
		[DoesNotReturn]
		private static void ThrowInt32OverflowException()
		{
			throw new OverflowException(SR.Overflow_Int32);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00023149 File Offset: 0x00021349
		[DoesNotReturn]
		private static void ThrowUInt32OverflowException()
		{
			throw new OverflowException(SR.Overflow_UInt32);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00023155 File Offset: 0x00021355
		[DoesNotReturn]
		private static void ThrowInt64OverflowException()
		{
			throw new OverflowException(SR.Overflow_Int64);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00023161 File Offset: 0x00021361
		[DoesNotReturn]
		private static void ThrowUInt64OverflowException()
		{
			throw new OverflowException(SR.Overflow_UInt64);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002316D File Offset: 0x0002136D
		public static bool ToBoolean([NotNullWhen(true)] object value)
		{
			return value != null && ((IConvertible)value).ToBoolean(null);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00023180 File Offset: 0x00021380
		public static bool ToBoolean([NotNullWhen(true)] object value, IFormatProvider provider)
		{
			return value != null && ((IConvertible)value).ToBoolean(provider);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00007B62 File Offset: 0x00005D62
		public static bool ToBoolean(bool value)
		{
			return value;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000201AE File Offset: 0x0001E3AE
		[CLSCompliant(false)]
		public static bool ToBoolean(sbyte value)
		{
			return value != 0;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00023193 File Offset: 0x00021393
		public static bool ToBoolean(char value)
		{
			return ((IConvertible)value).ToBoolean(null);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static bool ToBoolean(byte value)
		{
			return value > 0;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static bool ToBoolean(short value)
		{
			return value != 0;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000201AE File Offset: 0x0001E3AE
		[CLSCompliant(false)]
		public static bool ToBoolean(ushort value)
		{
			return value > 0;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static bool ToBoolean(int value)
		{
			return value != 0;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000201AE File Offset: 0x0001E3AE
		[CLSCompliant(false)]
		public static bool ToBoolean(uint value)
		{
			return value > 0U;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000231A1 File Offset: 0x000213A1
		public static bool ToBoolean(long value)
		{
			return value != 0L;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000231A1 File Offset: 0x000213A1
		[CLSCompliant(false)]
		public static bool ToBoolean(ulong value)
		{
			return value > 0UL;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000231A8 File Offset: 0x000213A8
		public static bool ToBoolean([NotNullWhen(true)] string value)
		{
			return value != null && bool.Parse(value);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000231A8 File Offset: 0x000213A8
		public static bool ToBoolean([NotNullWhen(true)] string value, IFormatProvider provider)
		{
			return value != null && bool.Parse(value);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000231B5 File Offset: 0x000213B5
		public static bool ToBoolean(float value)
		{
			return value != 0f;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000231C2 File Offset: 0x000213C2
		public static bool ToBoolean(double value)
		{
			return value != 0.0;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000231D3 File Offset: 0x000213D3
		public static bool ToBoolean(decimal value)
		{
			return value != 0m;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000231E0 File Offset: 0x000213E0
		public static bool ToBoolean(DateTime value)
		{
			return ((IConvertible)value).ToBoolean(null);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000231EE File Offset: 0x000213EE
		public static char ToChar(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToChar(null);
			}
			return '\0';
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00023201 File Offset: 0x00021401
		public static char ToChar(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToChar(provider);
			}
			return '\0';
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00023214 File Offset: 0x00021414
		public static char ToChar(bool value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00007B62 File Offset: 0x00005D62
		public static char ToChar(char value)
		{
			return value;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00023222 File Offset: 0x00021422
		[CLSCompliant(false)]
		public static char ToChar(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00007B62 File Offset: 0x00005D62
		public static char ToChar(byte value)
		{
			return (char)value;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00023222 File Offset: 0x00021422
		public static char ToChar(short value)
		{
			if (value < 0)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static char ToChar(ushort value)
		{
			return (char)value;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002322F File Offset: 0x0002142F
		public static char ToChar(int value)
		{
			return Convert.ToChar((uint)value);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00023237 File Offset: 0x00021437
		[CLSCompliant(false)]
		public static char ToChar(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00023248 File Offset: 0x00021448
		public static char ToChar(long value)
		{
			return Convert.ToChar((ulong)value);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00023250 File Offset: 0x00021450
		[CLSCompliant(false)]
		public static char ToChar(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowCharOverflowException();
			}
			return (char)value;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00023262 File Offset: 0x00021462
		[NullableContext(1)]
		public static char ToChar(string value)
		{
			return Convert.ToChar(value, null);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0002326B File Offset: 0x0002146B
		[NullableContext(1)]
		public static char ToChar(string value, [Nullable(2)] IFormatProvider provider)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (value.Length != 1)
			{
				throw new FormatException(SR.Format_NeedSingleChar);
			}
			return value[0];
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00023293 File Offset: 0x00021493
		public static char ToChar(float value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000232A1 File Offset: 0x000214A1
		public static char ToChar(double value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000232AF File Offset: 0x000214AF
		public static char ToChar(decimal value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000232BD File Offset: 0x000214BD
		public static char ToChar(DateTime value)
		{
			return ((IConvertible)value).ToChar(null);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000232CB File Offset: 0x000214CB
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSByte(null);
			}
			return 0;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000232DE File Offset: 0x000214DE
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSByte(provider);
			}
			return 0;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000232F1 File Offset: 0x000214F1
		[CLSCompliant(false)]
		public static sbyte ToSByte(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static sbyte ToSByte(sbyte value)
		{
			return value;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000232F8 File Offset: 0x000214F8
		[CLSCompliant(false)]
		public static sbyte ToSByte(char value)
		{
			if (value > '\u007f')
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000232F8 File Offset: 0x000214F8
		[CLSCompliant(false)]
		public static sbyte ToSByte(byte value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00023306 File Offset: 0x00021506
		[CLSCompliant(false)]
		public static sbyte ToSByte(short value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000232F8 File Offset: 0x000214F8
		[CLSCompliant(false)]
		public static sbyte ToSByte(ushort value)
		{
			if (value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00023306 File Offset: 0x00021506
		[CLSCompliant(false)]
		public static sbyte ToSByte(int value)
		{
			if (value < -128 || value > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00023319 File Offset: 0x00021519
		[CLSCompliant(false)]
		public static sbyte ToSByte(uint value)
		{
			if (value > 127U)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00023327 File Offset: 0x00021527
		[CLSCompliant(false)]
		public static sbyte ToSByte(long value)
		{
			if (value < -128L || value > 127L)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002333C File Offset: 0x0002153C
		[CLSCompliant(false)]
		public static sbyte ToSByte(ulong value)
		{
			if (value > 127UL)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)value;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0002334B File Offset: 0x0002154B
		[CLSCompliant(false)]
		public static sbyte ToSByte(float value)
		{
			return Convert.ToSByte((double)value);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00023354 File Offset: 0x00021554
		[CLSCompliant(false)]
		public static sbyte ToSByte(double value)
		{
			return Convert.ToSByte(Convert.ToInt32(value));
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00023361 File Offset: 0x00021561
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return decimal.ToSByte(decimal.Round(value, 0));
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0002336F File Offset: 0x0002156F
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return sbyte.Parse(value);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0002337C File Offset: 0x0002157C
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, [Nullable(2)] IFormatProvider provider)
		{
			return sbyte.Parse(value, provider);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00023385 File Offset: 0x00021585
		[CLSCompliant(false)]
		public static sbyte ToSByte(DateTime value)
		{
			return ((IConvertible)value).ToSByte(null);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00023393 File Offset: 0x00021593
		public static byte ToByte(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToByte(null);
			}
			return 0;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000233A6 File Offset: 0x000215A6
		public static byte ToByte(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToByte(provider);
			}
			return 0;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000233B9 File Offset: 0x000215B9
		public static byte ToByte(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00007B62 File Offset: 0x00005D62
		public static byte ToByte(byte value)
		{
			return value;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000233C0 File Offset: 0x000215C0
		public static byte ToByte(char value)
		{
			if (value > 'ÿ')
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000233D1 File Offset: 0x000215D1
		[CLSCompliant(false)]
		public static byte ToByte(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000233DE File Offset: 0x000215DE
		public static byte ToByte(short value)
		{
			if (value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000233C0 File Offset: 0x000215C0
		[CLSCompliant(false)]
		public static byte ToByte(ushort value)
		{
			if (value > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000233EF File Offset: 0x000215EF
		public static byte ToByte(int value)
		{
			return Convert.ToByte((uint)value);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000233DE File Offset: 0x000215DE
		[CLSCompliant(false)]
		public static byte ToByte(uint value)
		{
			if (value > 255U)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000233F7 File Offset: 0x000215F7
		public static byte ToByte(long value)
		{
			return Convert.ToByte((ulong)value);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000233FF File Offset: 0x000215FF
		[CLSCompliant(false)]
		public static byte ToByte(ulong value)
		{
			if (value > 255UL)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)value;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00023411 File Offset: 0x00021611
		public static byte ToByte(float value)
		{
			return Convert.ToByte((double)value);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0002341A File Offset: 0x0002161A
		public static byte ToByte(double value)
		{
			return Convert.ToByte(Convert.ToInt32(value));
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00023427 File Offset: 0x00021627
		public static byte ToByte(decimal value)
		{
			return decimal.ToByte(decimal.Round(value, 0));
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00023435 File Offset: 0x00021635
		public static byte ToByte(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00023442 File Offset: 0x00021642
		public static byte ToByte(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return byte.Parse(value, provider);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00023450 File Offset: 0x00021650
		public static byte ToByte(DateTime value)
		{
			return ((IConvertible)value).ToByte(null);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0002345E File Offset: 0x0002165E
		public static short ToInt16(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt16(null);
			}
			return 0;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00023471 File Offset: 0x00021671
		public static short ToInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt16(provider);
			}
			return 0;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00023484 File Offset: 0x00021684
		public static short ToInt16(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0002348B File Offset: 0x0002168B
		public static short ToInt16(char value)
		{
			if (value > '翿')
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static short ToInt16(sbyte value)
		{
			return (short)value;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00007B62 File Offset: 0x00005D62
		public static short ToInt16(byte value)
		{
			return (short)value;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0002348B File Offset: 0x0002168B
		[CLSCompliant(false)]
		public static short ToInt16(ushort value)
		{
			if (value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0002349C File Offset: 0x0002169C
		public static short ToInt16(int value)
		{
			if (value < -32768 || value > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000234B5 File Offset: 0x000216B5
		[CLSCompliant(false)]
		public static short ToInt16(uint value)
		{
			if (value > 32767U)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00007B62 File Offset: 0x00005D62
		public static short ToInt16(short value)
		{
			return value;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000234C6 File Offset: 0x000216C6
		public static short ToInt16(long value)
		{
			if (value < -32768L || value > 32767L)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000234E1 File Offset: 0x000216E1
		[CLSCompliant(false)]
		public static short ToInt16(ulong value)
		{
			if (value > 32767UL)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)value;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000234F3 File Offset: 0x000216F3
		public static short ToInt16(float value)
		{
			return Convert.ToInt16((double)value);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000234FC File Offset: 0x000216FC
		public static short ToInt16(double value)
		{
			return Convert.ToInt16(Convert.ToInt32(value));
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00023509 File Offset: 0x00021709
		public static short ToInt16(decimal value)
		{
			return decimal.ToInt16(decimal.Round(value, 0));
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00023517 File Offset: 0x00021717
		public static short ToInt16(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return short.Parse(value);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00023524 File Offset: 0x00021724
		public static short ToInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return short.Parse(value, provider);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00023532 File Offset: 0x00021732
		public static short ToInt16(DateTime value)
		{
			return ((IConvertible)value).ToInt16(null);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00023540 File Offset: 0x00021740
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt16(null);
			}
			return 0;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00023553 File Offset: 0x00021753
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt16(provider);
			}
			return 0;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00023566 File Offset: 0x00021766
		[CLSCompliant(false)]
		public static ushort ToUInt16(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static ushort ToUInt16(char value)
		{
			return (ushort)value;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0002356D File Offset: 0x0002176D
		[CLSCompliant(false)]
		public static ushort ToUInt16(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte value)
		{
			return (ushort)value;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0002356D File Offset: 0x0002176D
		[CLSCompliant(false)]
		public static ushort ToUInt16(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0002357A File Offset: 0x0002177A
		[CLSCompliant(false)]
		public static ushort ToUInt16(int value)
		{
			return Convert.ToUInt16((uint)value);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static ushort ToUInt16(ushort value)
		{
			return value;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00023582 File Offset: 0x00021782
		[CLSCompliant(false)]
		public static ushort ToUInt16(uint value)
		{
			if (value > 65535U)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00023593 File Offset: 0x00021793
		[CLSCompliant(false)]
		public static ushort ToUInt16(long value)
		{
			return Convert.ToUInt16((ulong)value);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0002359B File Offset: 0x0002179B
		[CLSCompliant(false)]
		public static ushort ToUInt16(ulong value)
		{
			if (value > 65535UL)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)value;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000235AD File Offset: 0x000217AD
		[CLSCompliant(false)]
		public static ushort ToUInt16(float value)
		{
			return Convert.ToUInt16((double)value);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000235B6 File Offset: 0x000217B6
		[CLSCompliant(false)]
		public static ushort ToUInt16(double value)
		{
			return Convert.ToUInt16(Convert.ToInt32(value));
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000235C3 File Offset: 0x000217C3
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return decimal.ToUInt16(decimal.Round(value, 0));
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000235D1 File Offset: 0x000217D1
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return ushort.Parse(value);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000235DE File Offset: 0x000217DE
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return ushort.Parse(value, provider);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000235EC File Offset: 0x000217EC
		[CLSCompliant(false)]
		public static ushort ToUInt16(DateTime value)
		{
			return ((IConvertible)value).ToUInt16(null);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000235FA File Offset: 0x000217FA
		public static int ToInt32(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(null);
			}
			return 0;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0002360D File Offset: 0x0002180D
		public static int ToInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt32(provider);
			}
			return 0;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static int ToInt32(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00007B62 File Offset: 0x00005D62
		public static int ToInt32(char value)
		{
			return (int)value;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static int ToInt32(sbyte value)
		{
			return (int)value;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00007B62 File Offset: 0x00005D62
		public static int ToInt32(byte value)
		{
			return (int)value;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00007B62 File Offset: 0x00005D62
		public static int ToInt32(short value)
		{
			return (int)value;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static int ToInt32(ushort value)
		{
			return (int)value;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00023620 File Offset: 0x00021820
		[CLSCompliant(false)]
		public static int ToInt32(uint value)
		{
			if (value < 0U)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00007B62 File Offset: 0x00005D62
		public static int ToInt32(int value)
		{
			return value;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0002362C File Offset: 0x0002182C
		public static int ToInt32(long value)
		{
			if (value < -2147483648L || value > 2147483647L)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00023647 File Offset: 0x00021847
		[CLSCompliant(false)]
		public static int ToInt32(ulong value)
		{
			if (value > 2147483647UL)
			{
				Convert.ThrowInt32OverflowException();
			}
			return (int)value;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00023659 File Offset: 0x00021859
		public static int ToInt32(float value)
		{
			return Convert.ToInt32((double)value);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00023664 File Offset: 0x00021864
		public static int ToInt32(double value)
		{
			if (value >= 0.0)
			{
				if (value < 2147483647.5)
				{
					int num = (int)value;
					double num2 = value - (double)num;
					if (num2 > 0.5 || (num2 == 0.5 && (num & 1) != 0))
					{
						num++;
					}
					return num;
				}
			}
			else if (value >= -2147483648.5)
			{
				int num3 = (int)value;
				double num4 = value - (double)num3;
				if (num4 < -0.5 || (num4 == -0.5 && (num3 & 1) != 0))
				{
					num3--;
				}
				return num3;
			}
			throw new OverflowException(SR.Overflow_Int32);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000236F5 File Offset: 0x000218F5
		public static int ToInt32(decimal value)
		{
			return decimal.ToInt32(decimal.Round(value, 0));
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00023703 File Offset: 0x00021903
		public static int ToInt32(string value)
		{
			if (value == null)
			{
				return 0;
			}
			return int.Parse(value);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00023710 File Offset: 0x00021910
		public static int ToInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0;
			}
			return int.Parse(value, provider);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0002371E File Offset: 0x0002191E
		public static int ToInt32(DateTime value)
		{
			return ((IConvertible)value).ToInt32(null);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0002372C File Offset: 0x0002192C
		[CLSCompliant(false)]
		public static uint ToUInt32(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt32(null);
			}
			return 0U;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0002373F File Offset: 0x0002193F
		[CLSCompliant(false)]
		public static uint ToUInt32(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt32(provider);
			}
			return 0U;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000201AE File Offset: 0x0001E3AE
		[CLSCompliant(false)]
		public static uint ToUInt32(bool value)
		{
			return (value > false) ? 1U : 0U;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static uint ToUInt32(char value)
		{
			return (uint)value;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00023752 File Offset: 0x00021952
		[CLSCompliant(false)]
		public static uint ToUInt32(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static uint ToUInt32(byte value)
		{
			return (uint)value;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00023752 File Offset: 0x00021952
		[CLSCompliant(false)]
		public static uint ToUInt32(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static uint ToUInt32(ushort value)
		{
			return (uint)value;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00023752 File Offset: 0x00021952
		[CLSCompliant(false)]
		public static uint ToUInt32(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static uint ToUInt32(uint value)
		{
			return value;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0002375E File Offset: 0x0002195E
		[CLSCompliant(false)]
		public static uint ToUInt32(long value)
		{
			return Convert.ToUInt32((ulong)value);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00023766 File Offset: 0x00021966
		[CLSCompliant(false)]
		public static uint ToUInt32(ulong value)
		{
			if (value > (ulong)-1)
			{
				Convert.ThrowUInt32OverflowException();
			}
			return (uint)value;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00023774 File Offset: 0x00021974
		[CLSCompliant(false)]
		public static uint ToUInt32(float value)
		{
			return Convert.ToUInt32((double)value);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00023780 File Offset: 0x00021980
		[CLSCompliant(false)]
		public static uint ToUInt32(double value)
		{
			if (value >= -0.5 && value < 4294967295.5)
			{
				uint num = (uint)value;
				double num2 = value - num;
				if (num2 > 0.5 || (num2 == 0.5 && (num & 1U) != 0U))
				{
					num += 1U;
				}
				return num;
			}
			throw new OverflowException(SR.Overflow_UInt32);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000237DB File Offset: 0x000219DB
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal value)
		{
			return decimal.ToUInt32(decimal.Round(value, 0));
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000237E9 File Offset: 0x000219E9
		[CLSCompliant(false)]
		public static uint ToUInt32(string value)
		{
			if (value == null)
			{
				return 0U;
			}
			return uint.Parse(value);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000237F6 File Offset: 0x000219F6
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0U;
			}
			return uint.Parse(value, provider);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00023804 File Offset: 0x00021A04
		[CLSCompliant(false)]
		public static uint ToUInt32(DateTime value)
		{
			return ((IConvertible)value).ToUInt32(null);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00023812 File Offset: 0x00021A12
		public static long ToInt64(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(null);
			}
			return 0L;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00023826 File Offset: 0x00021A26
		public static long ToInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToInt64(provider);
			}
			return 0L;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0002383A File Offset: 0x00021A3A
		public static long ToInt64(bool value)
		{
			return (value > false) ? 1L : 0L;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00023841 File Offset: 0x00021A41
		public static long ToInt64(char value)
		{
			return (long)((ulong)value);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00023845 File Offset: 0x00021A45
		[CLSCompliant(false)]
		public static long ToInt64(sbyte value)
		{
			return (long)value;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00023841 File Offset: 0x00021A41
		public static long ToInt64(byte value)
		{
			return (long)((ulong)value);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00023845 File Offset: 0x00021A45
		public static long ToInt64(short value)
		{
			return (long)value;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static long ToInt64(ushort value)
		{
			return (long)((ulong)value);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00023845 File Offset: 0x00021A45
		public static long ToInt64(int value)
		{
			return (long)value;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static long ToInt64(uint value)
		{
			return (long)((ulong)value);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00023849 File Offset: 0x00021A49
		[CLSCompliant(false)]
		public static long ToInt64(ulong value)
		{
			if (value < 0UL)
			{
				Convert.ThrowInt64OverflowException();
			}
			return (long)value;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00007B62 File Offset: 0x00005D62
		public static long ToInt64(long value)
		{
			return value;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00023856 File Offset: 0x00021A56
		public static long ToInt64(float value)
		{
			return Convert.ToInt64((double)value);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0002385F File Offset: 0x00021A5F
		public static long ToInt64(double value)
		{
			return checked((long)Math.Round(value));
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00023868 File Offset: 0x00021A68
		public static long ToInt64(decimal value)
		{
			return decimal.ToInt64(decimal.Round(value, 0));
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00023876 File Offset: 0x00021A76
		public static long ToInt64(string value)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00023884 File Offset: 0x00021A84
		public static long ToInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0L;
			}
			return long.Parse(value, provider);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00023893 File Offset: 0x00021A93
		public static long ToInt64(DateTime value)
		{
			return ((IConvertible)value).ToInt64(null);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000238A1 File Offset: 0x00021AA1
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt64(null);
			}
			return 0UL;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000238B5 File Offset: 0x00021AB5
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToUInt64(provider);
			}
			return 0UL;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0002383A File Offset: 0x00021A3A
		[CLSCompliant(false)]
		public static ulong ToUInt64(bool value)
		{
			return (ulong)((value > false) ? 1L : 0L);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static ulong ToUInt64(char value)
		{
			return (ulong)value;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000238C9 File Offset: 0x00021AC9
		[CLSCompliant(false)]
		public static ulong ToUInt64(sbyte value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte value)
		{
			return (ulong)value;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000238C9 File Offset: 0x00021AC9
		[CLSCompliant(false)]
		public static ulong ToUInt64(short value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static ulong ToUInt64(ushort value)
		{
			return (ulong)value;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000238C9 File Offset: 0x00021AC9
		[CLSCompliant(false)]
		public static ulong ToUInt64(int value)
		{
			if (value < 0)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)((long)value);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00023841 File Offset: 0x00021A41
		[CLSCompliant(false)]
		public static ulong ToUInt64(uint value)
		{
			return (ulong)value;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000238D6 File Offset: 0x00021AD6
		[CLSCompliant(false)]
		public static ulong ToUInt64(long value)
		{
			if (value < 0L)
			{
				Convert.ThrowUInt64OverflowException();
			}
			return (ulong)value;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		public static ulong ToUInt64(ulong value)
		{
			return value;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000238E3 File Offset: 0x00021AE3
		[CLSCompliant(false)]
		public static ulong ToUInt64(float value)
		{
			return Convert.ToUInt64((double)value);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000238EC File Offset: 0x00021AEC
		[CLSCompliant(false)]
		public static ulong ToUInt64(double value)
		{
			return checked((ulong)Math.Round(value));
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000238F5 File Offset: 0x00021AF5
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal value)
		{
			return decimal.ToUInt64(decimal.Round(value, 0));
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00023903 File Offset: 0x00021B03
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value)
		{
			if (value == null)
			{
				return 0UL;
			}
			return ulong.Parse(value);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00023911 File Offset: 0x00021B11
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0UL;
			}
			return ulong.Parse(value, provider);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00023920 File Offset: 0x00021B20
		[CLSCompliant(false)]
		public static ulong ToUInt64(DateTime value)
		{
			return ((IConvertible)value).ToUInt64(null);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0002392E File Offset: 0x00021B2E
		public static float ToSingle(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSingle(null);
			}
			return 0f;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00023945 File Offset: 0x00021B45
		public static float ToSingle(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToSingle(provider);
			}
			return 0f;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0002395C File Offset: 0x00021B5C
		[CLSCompliant(false)]
		public static float ToSingle(sbyte value)
		{
			return (float)value;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0002395C File Offset: 0x00021B5C
		public static float ToSingle(byte value)
		{
			return (float)value;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00023960 File Offset: 0x00021B60
		public static float ToSingle(char value)
		{
			return ((IConvertible)value).ToSingle(null);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0002395C File Offset: 0x00021B5C
		public static float ToSingle(short value)
		{
			return (float)value;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0002395C File Offset: 0x00021B5C
		[CLSCompliant(false)]
		public static float ToSingle(ushort value)
		{
			return (float)value;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0002395C File Offset: 0x00021B5C
		public static float ToSingle(int value)
		{
			return (float)value;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0002396E File Offset: 0x00021B6E
		[CLSCompliant(false)]
		public static float ToSingle(uint value)
		{
			return value;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0002395C File Offset: 0x00021B5C
		public static float ToSingle(long value)
		{
			return (float)value;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0002396E File Offset: 0x00021B6E
		[CLSCompliant(false)]
		public static float ToSingle(ulong value)
		{
			return value;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00007B62 File Offset: 0x00005D62
		public static float ToSingle(float value)
		{
			return value;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0002395C File Offset: 0x00021B5C
		public static float ToSingle(double value)
		{
			return (float)value;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00023973 File Offset: 0x00021B73
		public static float ToSingle(decimal value)
		{
			return (float)value;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0002397C File Offset: 0x00021B7C
		public static float ToSingle(string value)
		{
			if (value == null)
			{
				return 0f;
			}
			return float.Parse(value);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0002398D File Offset: 0x00021B8D
		public static float ToSingle(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0f;
			}
			return float.Parse(value, provider);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0002399F File Offset: 0x00021B9F
		public static float ToSingle(bool value)
		{
			return value > false;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000239A6 File Offset: 0x00021BA6
		public static float ToSingle(DateTime value)
		{
			return ((IConvertible)value).ToSingle(null);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000239B4 File Offset: 0x00021BB4
		public static double ToDouble(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(null);
			}
			return 0.0;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000239CF File Offset: 0x00021BCF
		public static double ToDouble(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDouble(provider);
			}
			return 0.0;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000239EA File Offset: 0x00021BEA
		[CLSCompliant(false)]
		public static double ToDouble(sbyte value)
		{
			return (double)value;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000239EA File Offset: 0x00021BEA
		public static double ToDouble(byte value)
		{
			return (double)value;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000239EA File Offset: 0x00021BEA
		public static double ToDouble(short value)
		{
			return (double)value;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000239EE File Offset: 0x00021BEE
		public static double ToDouble(char value)
		{
			return ((IConvertible)value).ToDouble(null);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000239EA File Offset: 0x00021BEA
		[CLSCompliant(false)]
		public static double ToDouble(ushort value)
		{
			return (double)value;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000239EA File Offset: 0x00021BEA
		public static double ToDouble(int value)
		{
			return (double)value;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000239FC File Offset: 0x00021BFC
		[CLSCompliant(false)]
		public static double ToDouble(uint value)
		{
			return value;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000239EA File Offset: 0x00021BEA
		public static double ToDouble(long value)
		{
			return (double)value;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000239FC File Offset: 0x00021BFC
		[CLSCompliant(false)]
		public static double ToDouble(ulong value)
		{
			return value;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000239EA File Offset: 0x00021BEA
		public static double ToDouble(float value)
		{
			return (double)value;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00007B62 File Offset: 0x00005D62
		public static double ToDouble(double value)
		{
			return value;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00023A01 File Offset: 0x00021C01
		public static double ToDouble(decimal value)
		{
			return (double)value;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00023A0A File Offset: 0x00021C0A
		public static double ToDouble(string value)
		{
			if (value == null)
			{
				return 0.0;
			}
			return double.Parse(value);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00023A1F File Offset: 0x00021C1F
		public static double ToDouble(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0.0;
			}
			return double.Parse(value, provider);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00023A35 File Offset: 0x00021C35
		public static double ToDouble(bool value)
		{
			return value > false;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00023A3C File Offset: 0x00021C3C
		public static double ToDouble(DateTime value)
		{
			return ((IConvertible)value).ToDouble(null);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00023A4A File Offset: 0x00021C4A
		public static decimal ToDecimal(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDecimal(null);
			}
			return 0m;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00023A61 File Offset: 0x00021C61
		public static decimal ToDecimal(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDecimal(provider);
			}
			return 0m;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00023A78 File Offset: 0x00021C78
		[CLSCompliant(false)]
		public static decimal ToDecimal(sbyte value)
		{
			return value;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00023A80 File Offset: 0x00021C80
		public static decimal ToDecimal(byte value)
		{
			return value;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00023A88 File Offset: 0x00021C88
		public static decimal ToDecimal(char value)
		{
			return ((IConvertible)value).ToDecimal(null);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00023A96 File Offset: 0x00021C96
		public static decimal ToDecimal(short value)
		{
			return value;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00023A9E File Offset: 0x00021C9E
		[CLSCompliant(false)]
		public static decimal ToDecimal(ushort value)
		{
			return value;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00023AA6 File Offset: 0x00021CA6
		public static decimal ToDecimal(int value)
		{
			return value;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00023AAE File Offset: 0x00021CAE
		[CLSCompliant(false)]
		public static decimal ToDecimal(uint value)
		{
			return value;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00023AB6 File Offset: 0x00021CB6
		public static decimal ToDecimal(long value)
		{
			return value;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00023ABE File Offset: 0x00021CBE
		[CLSCompliant(false)]
		public static decimal ToDecimal(ulong value)
		{
			return value;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00023AC6 File Offset: 0x00021CC6
		public static decimal ToDecimal(float value)
		{
			return (decimal)value;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00023ACE File Offset: 0x00021CCE
		public static decimal ToDecimal(double value)
		{
			return (decimal)value;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00023AD6 File Offset: 0x00021CD6
		public static decimal ToDecimal(string value)
		{
			if (value == null)
			{
				return 0m;
			}
			return decimal.Parse(value);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00023AE7 File Offset: 0x00021CE7
		public static decimal ToDecimal(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return 0m;
			}
			return decimal.Parse(value, provider);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00007B62 File Offset: 0x00005D62
		public static decimal ToDecimal(decimal value)
		{
			return value;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00023AF9 File Offset: 0x00021CF9
		public static decimal ToDecimal(bool value)
		{
			return (value > false) ? 1 : 0;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00023B04 File Offset: 0x00021D04
		public static decimal ToDecimal(DateTime value)
		{
			return ((IConvertible)value).ToDecimal(null);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00007B62 File Offset: 0x00005D62
		public static DateTime ToDateTime(DateTime value)
		{
			return value;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00023B12 File Offset: 0x00021D12
		public static DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDateTime(null);
			}
			return DateTime.MinValue;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00023B29 File Offset: 0x00021D29
		public static DateTime ToDateTime(object value, IFormatProvider provider)
		{
			if (value != null)
			{
				return ((IConvertible)value).ToDateTime(provider);
			}
			return DateTime.MinValue;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00023B40 File Offset: 0x00021D40
		public static DateTime ToDateTime(string value)
		{
			if (value == null)
			{
				return new DateTime(0L);
			}
			return DateTime.Parse(value);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00023B53 File Offset: 0x00021D53
		public static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			if (value == null)
			{
				return new DateTime(0L);
			}
			return DateTime.Parse(value, provider);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00023B67 File Offset: 0x00021D67
		[CLSCompliant(false)]
		public static DateTime ToDateTime(sbyte value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00023B75 File Offset: 0x00021D75
		public static DateTime ToDateTime(byte value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00023B83 File Offset: 0x00021D83
		public static DateTime ToDateTime(short value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00023B91 File Offset: 0x00021D91
		[CLSCompliant(false)]
		public static DateTime ToDateTime(ushort value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00023B9F File Offset: 0x00021D9F
		public static DateTime ToDateTime(int value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00023BAD File Offset: 0x00021DAD
		[CLSCompliant(false)]
		public static DateTime ToDateTime(uint value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00023BBB File Offset: 0x00021DBB
		public static DateTime ToDateTime(long value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00023BC9 File Offset: 0x00021DC9
		[CLSCompliant(false)]
		public static DateTime ToDateTime(ulong value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00023BD7 File Offset: 0x00021DD7
		public static DateTime ToDateTime(bool value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00023BE5 File Offset: 0x00021DE5
		public static DateTime ToDateTime(char value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00023BF3 File Offset: 0x00021DF3
		public static DateTime ToDateTime(float value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00023C01 File Offset: 0x00021E01
		public static DateTime ToDateTime(double value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00023C0F File Offset: 0x00021E0F
		public static DateTime ToDateTime(decimal value)
		{
			return ((IConvertible)value).ToDateTime(null);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00023C1D File Offset: 0x00021E1D
		public static string ToString(object value)
		{
			return Convert.ToString(value, null);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00023C28 File Offset: 0x00021E28
		public static string ToString(object value, IFormatProvider provider)
		{
			IConvertible convertible = value as IConvertible;
			if (convertible != null)
			{
				return convertible.ToString(provider);
			}
			IFormattable formattable = value as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(null, provider);
			}
			if (value != null)
			{
				return value.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00023C69 File Offset: 0x00021E69
		[NullableContext(1)]
		public static string ToString(bool value)
		{
			return value.ToString();
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00023C69 File Offset: 0x00021E69
		[NullableContext(1)]
		public static string ToString(bool value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00023C72 File Offset: 0x00021E72
		[NullableContext(1)]
		public static string ToString(char value)
		{
			return char.ToString(value);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00023C7A File Offset: 0x00021E7A
		[NullableContext(1)]
		public static string ToString(char value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString();
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00023C83 File Offset: 0x00021E83
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00023C8C File Offset: 0x00021E8C
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(sbyte value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00023C96 File Offset: 0x00021E96
		[NullableContext(1)]
		public static string ToString(byte value)
		{
			return value.ToString();
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00023C9F File Offset: 0x00021E9F
		[NullableContext(1)]
		public static string ToString(byte value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00023CA9 File Offset: 0x00021EA9
		[NullableContext(1)]
		public static string ToString(short value)
		{
			return value.ToString();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00023CB2 File Offset: 0x00021EB2
		[NullableContext(1)]
		public static string ToString(short value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00023CBC File Offset: 0x00021EBC
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString();
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00023CC5 File Offset: 0x00021EC5
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(ushort value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00023CCF File Offset: 0x00021ECF
		[NullableContext(1)]
		public static string ToString(int value)
		{
			return value.ToString();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00023CD8 File Offset: 0x00021ED8
		[NullableContext(1)]
		public static string ToString(int value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00023CE2 File Offset: 0x00021EE2
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString();
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00023CEB File Offset: 0x00021EEB
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(uint value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00023CF5 File Offset: 0x00021EF5
		[NullableContext(1)]
		public static string ToString(long value)
		{
			return value.ToString();
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00023CFE File Offset: 0x00021EFE
		[NullableContext(1)]
		public static string ToString(long value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00023D08 File Offset: 0x00021F08
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString();
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00023D11 File Offset: 0x00021F11
		[NullableContext(1)]
		[CLSCompliant(false)]
		public static string ToString(ulong value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00023D1B File Offset: 0x00021F1B
		[NullableContext(1)]
		public static string ToString(float value)
		{
			return value.ToString();
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00023D24 File Offset: 0x00021F24
		[NullableContext(1)]
		public static string ToString(float value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00023D2E File Offset: 0x00021F2E
		[NullableContext(1)]
		public static string ToString(double value)
		{
			return value.ToString();
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00023D37 File Offset: 0x00021F37
		[NullableContext(1)]
		public static string ToString(double value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00023D41 File Offset: 0x00021F41
		[NullableContext(1)]
		public static string ToString(decimal value)
		{
			return value.ToString();
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00023D4A File Offset: 0x00021F4A
		[NullableContext(1)]
		public static string ToString(decimal value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00023D54 File Offset: 0x00021F54
		[NullableContext(1)]
		public static string ToString(DateTime value)
		{
			return value.ToString();
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00023D5D File Offset: 0x00021F5D
		[NullableContext(1)]
		public static string ToString(DateTime value, [Nullable(2)] IFormatProvider provider)
		{
			return value.ToString(provider);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00007B62 File Offset: 0x00005D62
		[return: NotNullIfNotNull("value")]
		public static string ToString(string value)
		{
			return value;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00007B62 File Offset: 0x00005D62
		[return: NotNullIfNotNull("value")]
		public static string ToString(string value, IFormatProvider provider)
		{
			return value;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00023D67 File Offset: 0x00021F67
		public static byte ToByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num > 255)
			{
				Convert.ThrowByteOverflowException();
			}
			return (byte)num;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00023DA4 File Offset: 0x00021FA4
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 5120);
			if (fromBase != 10 && num <= 255)
			{
				return (sbyte)num;
			}
			if (num < -128 || num > 127)
			{
				Convert.ThrowSByteOverflowException();
			}
			return (sbyte)num;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00023E00 File Offset: 0x00022000
		public static short ToInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 6144);
			if (fromBase != 10 && num <= 65535)
			{
				return (short)num;
			}
			if (num < -32768 || num > 32767)
			{
				Convert.ThrowInt16OverflowException();
			}
			return (short)num;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00023E62 File Offset: 0x00022062
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0;
			}
			int num = ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
			if (num > 65535)
			{
				Convert.ThrowUInt16OverflowException();
			}
			return (ushort)num;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00023E9F File Offset: 0x0002209F
		public static int ToInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0;
			}
			return ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4096);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00023ECE File Offset: 0x000220CE
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0U;
			}
			return (uint)ParseNumbers.StringToInt(value.AsSpan(), fromBase, 4608);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00023EFD File Offset: 0x000220FD
		public static long ToInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0L;
			}
			return ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4096);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00023F2D File Offset: 0x0002212D
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, int fromBase)
		{
			if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
			{
				Convert.ThrowInvalidBase();
			}
			if (value == null)
			{
				return 0UL;
			}
			return (ulong)ParseNumbers.StringToLong(value.AsSpan(), fromBase, 4608);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00023F5D File Offset: 0x0002215D
		[NullableContext(1)]
		public static string ToString(byte value, int toBase)
		{
			return Convert.ToString((int)value, toBase);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00023F68 File Offset: 0x00022168
		[NullableContext(1)]
		public static string ToString(short value, int toBase)
		{
			string format = "d";
			if (toBase <= 8)
			{
				if (toBase == 2)
				{
					format = "b";
					goto IL_3E;
				}
				if (toBase == 8)
				{
					return Convert.ToOctalString((ulong)((ushort)value));
				}
			}
			else
			{
				if (toBase == 10)
				{
					goto IL_3E;
				}
				if (toBase == 16)
				{
					format = "x";
					goto IL_3E;
				}
			}
			Convert.ThrowInvalidBase();
			IL_3E:
			return value.ToString(format, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00023FC0 File Offset: 0x000221C0
		[NullableContext(1)]
		public static string ToString(int value, int toBase)
		{
			string format = "d";
			if (toBase <= 8)
			{
				if (toBase == 2)
				{
					format = "b";
					goto IL_3D;
				}
				if (toBase == 8)
				{
					return Convert.ToOctalString((ulong)value);
				}
			}
			else
			{
				if (toBase == 10)
				{
					goto IL_3D;
				}
				if (toBase == 16)
				{
					format = "x";
					goto IL_3D;
				}
			}
			Convert.ThrowInvalidBase();
			IL_3D:
			return value.ToString(format, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00024018 File Offset: 0x00022218
		[NullableContext(1)]
		public static string ToString(long value, int toBase)
		{
			string format = "d";
			if (toBase <= 8)
			{
				if (toBase == 2)
				{
					format = "b";
					goto IL_3C;
				}
				if (toBase == 8)
				{
					return Convert.ToOctalString((ulong)value);
				}
			}
			else
			{
				if (toBase == 10)
				{
					goto IL_3C;
				}
				if (toBase == 16)
				{
					format = "x";
					goto IL_3C;
				}
			}
			Convert.ThrowInvalidBase();
			IL_3C:
			return value.ToString(format, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0002406E File Offset: 0x0002226E
		private static void ThrowInvalidBase()
		{
			throw new ArgumentException(SR.Arg_InvalidBase);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002407C File Offset: 0x0002227C
		private unsafe static string ToOctalString(ulong value)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)44], 22);
			int num = span.Length;
			do
			{
				*span[--num] = (char)(48UL + (value & 7UL));
				value >>= 3;
			}
			while (value != 0UL);
			return span.Slice(num).ToString();
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000240D2 File Offset: 0x000222D2
		[NullableContext(1)]
		public static string ToBase64String(byte[] inArray)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray), Base64FormattingOptions.None);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000240EB File Offset: 0x000222EB
		[NullableContext(1)]
		public static string ToBase64String(byte[] inArray, Base64FormattingOptions options)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray), options);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00024104 File Offset: 0x00022304
		[NullableContext(1)]
		public static string ToBase64String(byte[] inArray, int offset, int length)
		{
			return Convert.ToBase64String(inArray, offset, length, Base64FormattingOptions.None);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00024110 File Offset: 0x00022310
		[NullableContext(1)]
		public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offset, inArray.Length - length, "offset");
			return Convert.ToBase64String(new ReadOnlySpan<byte>(inArray, offset, length), options);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0002415C File Offset: 0x0002235C
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			if (options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumIllegalVal, (int)options), "options");
			}
			if (bytes.Length == 0)
			{
				return string.Empty;
			}
			bool flag = options == Base64FormattingOptions.InsertLineBreaks;
			string text = string.FastAllocateString(Convert.ToBase64_CalculateAndValidateOutputLength(bytes.Length, flag));
			if (Vector128.IsHardwareAccelerated && !flag && bytes.Length >= 16)
			{
				Convert.ToBase64CharsLargeNoLineBreaks(bytes, new Span<char>(text.GetRawStringData(), text.Length), text.Length);
			}
			else
			{
				fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* inData = reference;
					char* outChars;
					if (text == null)
					{
						outChars = null;
					}
					else
					{
						fixed (char* ptr = text.GetPinnableReference())
						{
							outChars = ptr;
						}
					}
					Convert.ConvertToBase64Array(outChars, inData, 0, bytes.Length, flag);
					char* ptr = null;
				}
			}
			return text;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00024217 File Offset: 0x00022417
		[NullableContext(1)]
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, Base64FormattingOptions.None);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00024228 File Offset: 0x00022428
		[NullableContext(1)]
		public unsafe static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			ArgumentNullException.ThrowIfNull(outArray, "outArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offsetIn, "offsetIn");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offsetOut, "offsetOut");
			if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumIllegalVal, (int)options), "options");
			}
			int num = inArray.Length;
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offsetIn, num - length, "offsetIn");
			if (length == 0)
			{
				return 0;
			}
			int num2 = outArray.Length;
			bool flag = options == Base64FormattingOptions.InsertLineBreaks;
			int num3 = Convert.ToBase64_CalculateAndValidateOutputLength(length, flag);
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offsetOut, num2 - num3, "offsetOut");
			if (Vector128.IsHardwareAccelerated && !flag && length >= 16)
			{
				Convert.ToBase64CharsLargeNoLineBreaks(new ReadOnlySpan<byte>(inArray, offsetIn, length), outArray.AsSpan(offsetOut), num3);
			}
			else
			{
				fixed (char* ptr = &outArray[offsetOut])
				{
					char* outChars = ptr;
					fixed (byte* ptr2 = &inArray[0])
					{
						byte* inData = ptr2;
						Convert.ConvertToBase64Array(outChars, inData, offsetIn, length, flag);
					}
				}
			}
			return num3;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00024324 File Offset: 0x00022524
		[NullableContext(0)]
		public unsafe static bool TryToBase64Chars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			if (options > Base64FormattingOptions.InsertLineBreaks)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumIllegalVal, (int)options), "options");
			}
			if (bytes.Length == 0)
			{
				charsWritten = 0;
				return true;
			}
			bool flag = options == Base64FormattingOptions.InsertLineBreaks;
			int num = Convert.ToBase64_CalculateAndValidateOutputLength(bytes.Length, flag);
			if (num > chars.Length)
			{
				charsWritten = 0;
				return false;
			}
			if (Vector128.IsHardwareAccelerated && !flag && bytes.Length >= 16)
			{
				Convert.ToBase64CharsLargeNoLineBreaks(bytes, chars, num);
			}
			else
			{
				fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
				{
					char* outChars = reference;
					fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
					{
						byte* inData = reference2;
						Convert.ConvertToBase64Array(outChars, inData, 0, bytes.Length, flag);
					}
				}
			}
			charsWritten = num;
			return true;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000243D0 File Offset: 0x000225D0
		private static void ToBase64CharsLargeNoLineBreaks(ReadOnlySpan<byte> bytes, Span<char> chars, int charLengthRequired)
		{
			int num;
			int num2;
			Base64.EncodeToUtf8(bytes, MemoryMarshal.AsBytes<char>(chars), out num, out num2, true);
			ref ushort ptr = ref Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(chars));
			ref byte ptr2 = ref Unsafe.As<ushort, byte>(ref ptr);
			ref byte source = ref ptr2;
			ptr = Unsafe.Add<ushort>(ref ptr, charLengthRequired);
			ptr2 = Unsafe.Add<byte>(ref ptr2, charLengthRequired);
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated)
			{
				ref byte right = ref Unsafe.Add<byte>(ref source, 15);
				while (Unsafe.IsAddressGreaterThan<byte>(ref ptr2, ref right))
				{
					ptr2 = Unsafe.Subtract<byte>(ref ptr2, 16);
					ptr = Unsafe.Subtract<ushort>(ref ptr, 16);
					ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple = Vector128.Widen(Vector128.LoadUnsafe<byte>(ref ptr2));
					Vector128<ushort> item = valueTuple.Item1;
					Vector128<ushort> item2 = valueTuple.Item2;
					item.StoreUnsafe(ref ptr);
					item2.StoreUnsafe(ref ptr, (UIntPtr)((IntPtr)8));
				}
			}
			ref byte right2 = ref Unsafe.Add<byte>(ref source, 3);
			while (Unsafe.IsAddressGreaterThan<byte>(ref ptr2, ref right2))
			{
				ptr = Unsafe.Subtract<ushort>(ref ptr, 4);
				ptr2 = Unsafe.Subtract<byte>(ref ptr2, 4);
				Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(Unsafe.As<ushort, char>(ref ptr), Unsafe.ReadUnaligned<uint>(ref ptr2));
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000244A4 File Offset: 0x000226A4
		private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			int num = length % 3;
			int num2 = offset + (length - num);
			int num3 = 0;
			int num4 = 0;
			fixed (byte* pinnableReference = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.0358F626A5EF929BD1E006FAFB18CCB73666F2EF7AC99854D894785C359D0404), 65).GetPinnableReference())
			{
				byte* ptr = pinnableReference;
				int i;
				for (i = offset; i < num2; i += 3)
				{
					if (insertLineBreaks)
					{
						if (num4 == 76)
						{
							outChars[num3++] = '\r';
							outChars[num3++] = '\n';
							num4 = 0;
						}
						num4 += 4;
					}
					outChars[num3] = (char)ptr[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = (char)ptr[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
					outChars[num3 + 2] = (char)ptr[(int)(inData[i + 1] & 15) << 2 | (inData[i + 2] & 192) >> 6];
					outChars[num3 + 3] = (char)ptr[inData[i + 2] & 63];
					num3 += 4;
				}
				i = num2;
				if (insertLineBreaks && num != 0 && num4 == 76)
				{
					outChars[num3++] = '\r';
					outChars[num3++] = '\n';
				}
				if (num != 1)
				{
					if (num == 2)
					{
						outChars[num3] = (char)ptr[(inData[i] & 252) >> 2];
						outChars[num3 + 1] = (char)ptr[(int)(inData[i] & 3) << 4 | (inData[i + 1] & 240) >> 4];
						outChars[num3 + 2] = (char)ptr[(inData[i + 1] & 15) << 2];
						outChars[num3 + 3] = (char)ptr[64];
						num3 += 4;
					}
				}
				else
				{
					outChars[num3] = (char)ptr[(inData[i] & 252) >> 2];
					outChars[num3 + 1] = (char)ptr[(inData[i] & 3) << 4];
					outChars[num3 + 2] = (char)ptr[64];
					outChars[num3 + 3] = (char)ptr[64];
					num3 += 4;
				}
			}
			return num3;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00024694 File Offset: 0x00022894
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			uint num = (uint)((inputLength + 2) / 3 * 4);
			if (num == 0U)
			{
				return 0;
			}
			if (insertLineBreaks)
			{
				ValueTuple<uint, uint> valueTuple = Math.DivRem(num, 76U);
				uint num2 = valueTuple.Item1;
				if (valueTuple.Item2 == 0U)
				{
					num2 -= 1U;
				}
				num += num2 * 2U;
			}
			if (num > 2147483647U)
			{
				throw new OutOfMemoryException();
			}
			return (int)num;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000246E0 File Offset: 0x000228E0
		[NullableContext(1)]
		public unsafe static byte[] FromBase64String(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			char* inputPtr;
			if (s == null)
			{
				inputPtr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					inputPtr = pinnableReference;
				}
			}
			return Convert.FromBase64CharPtr(inputPtr, s.Length);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00024712 File Offset: 0x00022912
		[NullableContext(0)]
		public static bool TryFromBase64String([Nullable(1)] string s, Span<byte> bytes, out int bytesWritten)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Convert.TryFromBase64Chars(s.AsSpan(), bytes, out bytesWritten);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0002472C File Offset: 0x0002292C
		[NullableContext(0)]
		public unsafe static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)8], 4);
			bytesWritten = 0;
			while (chars.Length != 0)
			{
				int start;
				int num;
				bool flag = Convert.TryDecodeFromUtf16(chars, bytes, out start, out num);
				bytesWritten += num;
				if (flag)
				{
					return true;
				}
				chars = chars.Slice(start);
				bytes = bytes.Slice(num);
				if (((char)(*chars[0])).IsSpace())
				{
					int num2 = 1;
					while (num2 != chars.Length && ((char)(*chars[num2])).IsSpace())
					{
						num2++;
					}
					chars = chars.Slice(num2);
					if (num % 3 != 0 && chars.Length != 0)
					{
						bytesWritten = 0;
						return false;
					}
				}
				else
				{
					int start2;
					int num3;
					Convert.CopyToTempBufferWithoutWhiteSpace(chars, span, out start2, out num3);
					if ((num3 & 3) != 0)
					{
						bytesWritten = 0;
						return false;
					}
					span = span.Slice(0, num3);
					int num4;
					int num5;
					if (!Convert.TryDecodeFromUtf16(span, bytes, out num4, out num5))
					{
						bytesWritten = 0;
						return false;
					}
					bytesWritten += num5;
					chars = chars.Slice(start2);
					bytes = bytes.Slice(num5);
					if (num5 % 3 != 0)
					{
						for (int i = 0; i < chars.Length; i++)
						{
							if (!((char)(*chars[i])).IsSpace())
							{
								bytesWritten = 0;
								return false;
							}
						}
						return true;
					}
				}
			}
			return true;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00024860 File Offset: 0x00022A60
		private unsafe static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
			charsWritten = 0;
			for (int i = 0; i < chars.Length; i++)
			{
				char c = (char)(*chars[i]);
				if (!c.IsSpace())
				{
					int num = charsWritten;
					charsWritten = num + 1;
					*tempBuffer[num] = c;
					if (charsWritten == tempBuffer.Length)
					{
						consumed = i + 1;
						return;
					}
				}
			}
			consumed = chars.Length;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x000248C0 File Offset: 0x00022AC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSpace(this char c)
		{
			return c == ' ' || c == '\t' || c == '\r' || c == '\n';
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000248D8 File Offset: 0x00022AD8
		[NullableContext(1)]
		public unsafe static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offset, inArray.Length - length, "offset");
			if (length == 0)
			{
				return Array.Empty<byte>();
			}
			fixed (char* ptr = &inArray[0])
			{
				return Convert.FromBase64CharPtr(ptr + offset, length);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00024934 File Offset: 0x00022B34
		private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			while (inputLength > 0)
			{
				int num = (int)inputPtr[inputLength - 1];
				if (num != 32 && num != 10 && num != 13 && num != 9)
				{
					break;
				}
				inputLength--;
			}
			byte[] array = new byte[Convert.FromBase64_ComputeResultLength(inputPtr, inputLength)];
			int num2;
			if (!Convert.TryFromBase64Chars(new ReadOnlySpan<char>((void*)inputPtr, inputLength), array, out num2))
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return array;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002499C File Offset: 0x00022B9C
		private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			char* ptr = inputPtr + inputLength;
			int num = inputLength;
			int num2 = 0;
			while (inputPtr < ptr)
			{
				uint num3 = (uint)(*inputPtr);
				inputPtr++;
				if (num3 <= 32U)
				{
					num--;
				}
				else if (num3 == 61U)
				{
					num--;
					num2++;
				}
			}
			if (num2 != 0)
			{
				if (num2 == 1)
				{
					num2 = 2;
				}
				else
				{
					if (num2 != 2)
					{
						throw new FormatException(SR.Format_BadBase64Char);
					}
					num2 = 1;
				}
			}
			return num / 4 * 3 + num2;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000249FF File Offset: 0x00022BFF
		[NullableContext(1)]
		public static byte[] FromHexString(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Convert.FromHexString(s.AsSpan());
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00024A18 File Offset: 0x00022C18
		[NullableContext(0)]
		[return: Nullable(1)]
		public static byte[] FromHexString(ReadOnlySpan<char> chars)
		{
			if (chars.Length == 0)
			{
				return Array.Empty<byte>();
			}
			if (chars.Length % 2 != 0)
			{
				throw new FormatException(SR.Format_BadHexLength);
			}
			byte[] array = GC.AllocateUninitializedArray<byte>(chars.Length >> 1, false);
			int num;
			if (!HexConverter.TryDecodeFromUtf16(chars, array, out num))
			{
				throw new FormatException(SR.Format_BadHexChar);
			}
			return array;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00024A76 File Offset: 0x00022C76
		[NullableContext(0)]
		public static OperationStatus FromHexString([Nullable(1)] string source, Span<byte> destination, out int charsConsumed, out int bytesWritten)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			return Convert.FromHexString(source.AsSpan(), destination, out charsConsumed, out bytesWritten);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00024A94 File Offset: 0x00022C94
		[NullableContext(0)]
		public static OperationStatus FromHexString(ReadOnlySpan<char> source, Span<byte> destination, out int charsConsumed, out int bytesWritten)
		{
			ValueTuple<int, int> valueTuple = Math.DivRem(source.Length, 2);
			int num = valueTuple.Item1;
			int item = valueTuple.Item2;
			if (num == 0)
			{
				charsConsumed = 0;
				bytesWritten = 0;
				if (item != 1)
				{
					return OperationStatus.Done;
				}
				return OperationStatus.NeedMoreData;
			}
			else
			{
				OperationStatus result;
				if (destination.Length < num)
				{
					source = source.Slice(0, destination.Length * 2);
					num = destination.Length;
					result = OperationStatus.DestinationTooSmall;
				}
				else
				{
					if (item == 1)
					{
						source = source.Slice(0, source.Length - 1);
						result = OperationStatus.NeedMoreData;
					}
					else
					{
						result = OperationStatus.Done;
					}
					destination = destination.Slice(0, num);
				}
				if (!HexConverter.TryDecodeFromUtf16(source, destination, out charsConsumed))
				{
					bytesWritten = charsConsumed / 2;
					return OperationStatus.InvalidData;
				}
				bytesWritten = num;
				charsConsumed = source.Length;
				return result;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00024B3C File Offset: 0x00022D3C
		[NullableContext(1)]
		public static string ToHexString(byte[] inArray)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			return Convert.ToHexString(new ReadOnlySpan<byte>(inArray));
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00024B54 File Offset: 0x00022D54
		[NullableContext(1)]
		public static string ToHexString(byte[] inArray, int offset, int length)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offset, inArray.Length - length, "offset");
			return Convert.ToHexString(new ReadOnlySpan<byte>(inArray, offset, length));
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00024B94 File Offset: 0x00022D94
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string ToHexString(ReadOnlySpan<byte> bytes)
		{
			if (bytes.Length == 0)
			{
				return string.Empty;
			}
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(bytes.Length, 1073741823, "bytes");
			return HexConverter.ToString(bytes, HexConverter.Casing.Upper);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00024BC4 File Offset: 0x00022DC4
		[NullableContext(0)]
		public static bool TryToHexString(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			if (source.Length == 0)
			{
				charsWritten = 0;
				return true;
			}
			if (source.Length > 1073741823 || destination.Length < source.Length * 2)
			{
				charsWritten = 0;
				return false;
			}
			HexConverter.EncodeToUtf16(source, destination, HexConverter.Casing.Upper);
			charsWritten = source.Length * 2;
			return true;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00024C18 File Offset: 0x00022E18
		[NullableContext(1)]
		public static string ToHexStringLower(byte[] inArray)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			return Convert.ToHexStringLower(new ReadOnlySpan<byte>(inArray));
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00024C30 File Offset: 0x00022E30
		[NullableContext(1)]
		public static string ToHexStringLower(byte[] inArray, int offset, int length)
		{
			ArgumentNullException.ThrowIfNull(inArray, "inArray");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offset, inArray.Length - length, "offset");
			return Convert.ToHexStringLower(new ReadOnlySpan<byte>(inArray, offset, length));
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00024C70 File Offset: 0x00022E70
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string ToHexStringLower(ReadOnlySpan<byte> bytes)
		{
			if (bytes.Length == 0)
			{
				return string.Empty;
			}
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(bytes.Length, 1073741823, "bytes");
			return HexConverter.ToString(bytes, HexConverter.Casing.Lower);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00024CA4 File Offset: 0x00022EA4
		[NullableContext(0)]
		public static bool TryToHexStringLower(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			if (source.Length == 0)
			{
				charsWritten = 0;
				return true;
			}
			if (source.Length > 1073741823 || destination.Length < source.Length * 2)
			{
				charsWritten = 0;
				return false;
			}
			HexConverter.EncodeToUtf16(source, destination, HexConverter.Casing.Lower);
			charsWritten = source.Length * 2;
			return true;
		}

		// Token: 0x0400030D RID: 781
		[Nullable(1)]
		public static readonly object DBNull = System.DBNull.Value;
	}
}

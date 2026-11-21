using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200007B RID: 123
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class Enum : ValueType, IComparable, ISpanFormattable, IFormattable, IConvertible
	{
		// Token: 0x06000350 RID: 848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetEnumValuesAndNames(QCallTypeHandle enumType, out ulong[] values, out string[] names);

		// Token: 0x06000351 RID: 849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CorElementType InternalGetCorElementType(QCallTypeHandle enumType);

		// Token: 0x06000352 RID: 850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalGetUnderlyingType(QCallTypeHandle enumType, ObjectHandleOnStack res);

		// Token: 0x06000353 RID: 851 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		private static CorElementType InternalGetCorElementType(RuntimeType rt)
		{
			return Enum.InternalGetCorElementType(new QCallTypeHandle(ref rt));
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000AE00 File Offset: 0x00009000
		private CorElementType InternalGetCorElementType()
		{
			RuntimeType runtimeType = (RuntimeType)base.GetType();
			return Enum.InternalGetCorElementType(new QCallTypeHandle(ref runtimeType));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000AE28 File Offset: 0x00009028
		internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType)
		{
			RuntimeType result = null;
			Enum.InternalGetUnderlyingType(new QCallTypeHandle(ref enumType), ObjectHandleOnStack.Create<RuntimeType>(ref result));
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000AE4C File Offset: 0x0000904C
		private unsafe static Enum.EnumInfo<TStorage> GetEnumInfo<TStorage>(RuntimeType enumType, bool getNames = true) where TStorage : struct, INumber<TStorage>
		{
			Enum.EnumInfo<TStorage> enumInfo = enumType.Cache.EnumInfo as Enum.EnumInfo<TStorage>;
			if (enumInfo == null)
			{
				ulong[] array;
				string[] names;
				Enum.GetEnumValuesAndNames(new QCallTypeHandle(ref enumType), out array, out names);
				TStorage[] array2;
				if (typeof(TStorage) == typeof(ulong))
				{
					array2 = (TStorage[])array;
				}
				else
				{
					array2 = new TStorage[array.Length];
					int num = sizeof(TStorage);
					switch (num)
					{
					case 1:
						for (int i = 0; i < array2.Length; i++)
						{
							byte b = (byte)array[i];
							array2[i] = *(TStorage*)(&b);
						}
						break;
					case 2:
						for (int j = 0; j < array2.Length; j++)
						{
							ushort num2 = (ushort)array[j];
							array2[j] = *(TStorage*)(&num2);
						}
						break;
					case 3:
						break;
					case 4:
						for (int k = 0; k < array2.Length; k++)
						{
							uint num3 = (uint)array[k];
							array2[k] = *(TStorage*)(&num3);
						}
						break;
					default:
						if (num == 8)
						{
							for (int l = 0; l < array2.Length; l++)
							{
								ulong num4 = array[l];
								array2[l] = *(TStorage*)(&num4);
							}
						}
						break;
					}
				}
				enumInfo = new Enum.EnumInfo<TStorage>(enumType.IsDefined(typeof(FlagsAttribute), false), array2, names);
				enumType.Cache.EnumInfo = enumInfo;
			}
			return enumInfo;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(2)]
		public unsafe static string GetName<TEnum>(TEnum value) where TEnum : struct, Enum
		{
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			if (enumUnderlyingType == typeof(sbyte) || enumUnderlyingType == typeof(byte))
			{
				return Enum.GetNameInlined<byte>(Enum.GetEnumInfo<byte>(enumType, true), *(byte*)(&value));
			}
			if (enumUnderlyingType == typeof(short) || enumUnderlyingType == typeof(ushort))
			{
				return Enum.GetNameInlined<ushort>(Enum.GetEnumInfo<ushort>(enumType, true), *(ushort*)(&value));
			}
			if (enumUnderlyingType == typeof(int) || enumUnderlyingType == typeof(uint))
			{
				return Enum.GetNameInlined<uint>(Enum.GetEnumInfo<uint>(enumType, true), *(uint*)(&value));
			}
			if (enumUnderlyingType == typeof(long) || enumUnderlyingType == typeof(ulong))
			{
				return Enum.GetNameInlined<ulong>(Enum.GetEnumInfo<ulong>(enumType, true), (ulong)(*(long*)(&value)));
			}
			if (enumUnderlyingType == typeof(IntPtr) || enumUnderlyingType == typeof(UIntPtr))
			{
				return Enum.GetNameInlined<UIntPtr>(Enum.GetEnumInfo<UIntPtr>(enumType, true), (UIntPtr)(*(IntPtr*)(&value)));
			}
			if (enumUnderlyingType == typeof(float))
			{
				return Enum.GetNameInlined<float>(Enum.GetEnumInfo<float>(enumType, true), *(float*)(&value));
			}
			if (enumUnderlyingType == typeof(double))
			{
				return Enum.GetNameInlined<double>(Enum.GetEnumInfo<double>(enumType, true), *(double*)(&value));
			}
			if (enumUnderlyingType == typeof(char))
			{
				return Enum.GetNameInlined<char>(Enum.GetEnumInfo<char>(enumType, true), (char)(*(ushort*)(&value)));
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000B154 File Offset: 0x00009354
		[return: Nullable(2)]
		public static string GetName(Type enumType, object value)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.GetEnumName(value);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B168 File Offset: 0x00009368
		internal static string GetName(RuntimeType enumType, ulong uint64Value)
		{
			Type enumUnderlyingType = enumType.GetEnumUnderlyingType();
			switch (Type.GetTypeCode(enumUnderlyingType))
			{
			case TypeCode.Char:
				if (uint64Value > 65535UL)
				{
					return null;
				}
				return Enum.GetName<char>(Enum.GetEnumInfo<char>(enumType, true), (char)uint64Value);
			case TypeCode.SByte:
				if (uint64Value < 18446744073709551488UL || uint64Value > 127UL)
				{
					return null;
				}
				return Enum.GetName<byte>(Enum.GetEnumInfo<byte>(enumType, true), (byte)((sbyte)uint64Value));
			case TypeCode.Byte:
				if (uint64Value > 255UL)
				{
					return null;
				}
				return Enum.GetName<byte>(Enum.GetEnumInfo<byte>(enumType, true), (byte)uint64Value);
			case TypeCode.Int16:
				if (uint64Value < 18446744073709518848UL || uint64Value > 32767UL)
				{
					return null;
				}
				return Enum.GetName<ushort>(Enum.GetEnumInfo<ushort>(enumType, true), (ushort)((short)uint64Value));
			case TypeCode.UInt16:
				if (uint64Value > 65535UL)
				{
					return null;
				}
				return Enum.GetName<ushort>(Enum.GetEnumInfo<ushort>(enumType, true), (ushort)uint64Value);
			case TypeCode.Int32:
				if (uint64Value < 18446744071562067968UL || uint64Value > 2147483647UL)
				{
					return null;
				}
				return Enum.GetName<uint>(Enum.GetEnumInfo<uint>(enumType, true), (uint)((int)uint64Value));
			case TypeCode.UInt32:
				if (uint64Value > (ulong)-1)
				{
					return null;
				}
				return Enum.GetName<uint>(Enum.GetEnumInfo<uint>(enumType, true), (uint)uint64Value);
			case TypeCode.Int64:
				return Enum.GetName<ulong>(Enum.GetEnumInfo<ulong>(enumType, true), uint64Value);
			case TypeCode.UInt64:
				return Enum.GetName<ulong>(Enum.GetEnumInfo<ulong>(enumType, true), uint64Value);
			default:
				if (enumUnderlyingType == typeof(IntPtr))
				{
					if (uint64Value < (ulong)((long)IntPtr.MinValue) || uint64Value > (ulong)((long)IntPtr.MaxValue))
					{
						return null;
					}
					return Enum.GetName<UIntPtr>(Enum.GetEnumInfo<UIntPtr>(enumType, true), (UIntPtr)((IntPtr)uint64Value));
				}
				else
				{
					if (!(enumUnderlyingType == typeof(UIntPtr)))
					{
						throw Enum.CreateUnknownEnumTypeException();
					}
					if (uint64Value > (ulong)UIntPtr.MaxValue)
					{
						return null;
					}
					return Enum.GetName<UIntPtr>(Enum.GetEnumInfo<UIntPtr>(enumType, true), (UIntPtr)uint64Value);
				}
				break;
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B2FF File Offset: 0x000094FF
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetName<TStorage>(Enum.EnumInfo<TStorage> enumInfo, TStorage value) where TStorage : struct, INumber<TStorage>
		{
			return Enum.GetNameInlined<TStorage>(enumInfo, value);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B308 File Offset: 0x00009508
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string GetNameInlined<TStorage>(Enum.EnumInfo<TStorage> enumInfo, TStorage value) where TStorage : struct, INumber<TStorage>
		{
			string[] names = enumInfo.Names;
			if (enumInfo.ValuesAreSequentialFromZero)
			{
				if (sizeof(TStorage) <= 4)
				{
					uint num = uint.CreateTruncating<TStorage>(value);
					if (num < (uint)names.Length)
					{
						return names[(int)num];
					}
				}
				else if (ulong.CreateTruncating<TStorage>(value) < (ulong)((long)names.Length))
				{
					return names[(int)uint.CreateTruncating<TStorage>(value)];
				}
			}
			else
			{
				int num2 = Enum.FindDefinedIndex<TStorage>(enumInfo.Values, value);
				if (num2 < names.Length)
				{
					return names[num2];
				}
			}
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B36C File Offset: 0x0000956C
		public static string[] GetNames<[Nullable(0)] TEnum>() where TEnum : struct, Enum
		{
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			string[] names;
			if (enumUnderlyingType == typeof(sbyte) || enumUnderlyingType == typeof(byte))
			{
				names = Enum.GetEnumInfo<byte>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(short) || enumUnderlyingType == typeof(ushort))
			{
				names = Enum.GetEnumInfo<ushort>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(int) || enumUnderlyingType == typeof(uint))
			{
				names = Enum.GetEnumInfo<uint>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(long) || enumUnderlyingType == typeof(ulong))
			{
				names = Enum.GetEnumInfo<ulong>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(IntPtr) || enumUnderlyingType == typeof(UIntPtr))
			{
				names = Enum.GetEnumInfo<UIntPtr>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(float))
			{
				names = Enum.GetEnumInfo<float>(enumType, true).Names;
			}
			else if (enumUnderlyingType == typeof(double))
			{
				names = Enum.GetEnumInfo<double>(enumType, true).Names;
			}
			else
			{
				if (!(enumUnderlyingType == typeof(char)))
				{
					throw Enum.CreateUnknownEnumTypeException();
				}
				names = Enum.GetEnumInfo<char>(enumType, true).Names;
			}
			return new ReadOnlySpan<string>(names).ToArray();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B51B File Offset: 0x0000971B
		public static string[] GetNames(Type enumType)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.GetEnumNames();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B530 File Offset: 0x00009730
		internal static string[] GetNamesNoCopy(RuntimeType enumType)
		{
			switch (Enum.InternalGetCorElementType(enumType))
			{
			case CorElementType.ELEMENT_TYPE_CHAR:
				return Enum.GetEnumInfo<char>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_I1:
			case CorElementType.ELEMENT_TYPE_U1:
				return Enum.GetEnumInfo<byte>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_I2:
			case CorElementType.ELEMENT_TYPE_U2:
				return Enum.GetEnumInfo<ushort>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_I4:
			case CorElementType.ELEMENT_TYPE_U4:
				return Enum.GetEnumInfo<uint>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_I8:
			case CorElementType.ELEMENT_TYPE_U8:
				return Enum.GetEnumInfo<ulong>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_R4:
				return Enum.GetEnumInfo<float>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_R8:
				return Enum.GetEnumInfo<double>(enumType, true).Names;
			case CorElementType.ELEMENT_TYPE_I:
			case CorElementType.ELEMENT_TYPE_U:
				return Enum.GetEnumInfo<UIntPtr>(enumType, true).Names;
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B629 File Offset: 0x00009829
		public static Type GetUnderlyingType(Type enumType)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.GetEnumUnderlyingType();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000B63C File Offset: 0x0000983C
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static TEnum[] GetValues<TEnum>() where TEnum : struct, Enum
		{
			Array valuesAsUnderlyingTypeNoCopy = Enum.GetValuesAsUnderlyingTypeNoCopy((RuntimeType)typeof(TEnum));
			TEnum[] array = new TEnum[valuesAsUnderlyingTypeNoCopy.Length];
			Array.Copy(valuesAsUnderlyingTypeNoCopy, array, valuesAsUnderlyingTypeNoCopy.Length);
			return array;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000B678 File Offset: 0x00009878
		[RequiresDynamicCode("It might not be possible to create an array of the enum type at runtime. Use the GetValues<TEnum> overload or the GetValuesAsUnderlyingType method instead.")]
		public static Array GetValues(Type enumType)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.GetEnumValues();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000B68B File Offset: 0x0000988B
		public static Array GetValuesAsUnderlyingType<[Nullable(0)] TEnum>() where TEnum : struct, Enum
		{
			return typeof(TEnum).GetEnumValuesAsUnderlyingType();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000B69C File Offset: 0x0000989C
		public static Array GetValuesAsUnderlyingType(Type enumType)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.GetEnumValuesAsUnderlyingType();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000B6B0 File Offset: 0x000098B0
		internal static Array GetValuesAsUnderlyingType(RuntimeType enumType)
		{
			switch (Enum.InternalGetCorElementType(enumType))
			{
			case CorElementType.ELEMENT_TYPE_CHAR:
				return Enum.GetEnumInfo<char>(enumType, false).CloneValues<char>();
			case CorElementType.ELEMENT_TYPE_I1:
				return Enum.GetEnumInfo<byte>(enumType, false).CloneValues<sbyte>();
			case CorElementType.ELEMENT_TYPE_U1:
				return Enum.GetEnumInfo<byte>(enumType, false).CloneValues<byte>();
			case CorElementType.ELEMENT_TYPE_I2:
				return Enum.GetEnumInfo<ushort>(enumType, false).CloneValues<short>();
			case CorElementType.ELEMENT_TYPE_U2:
				return Enum.GetEnumInfo<ushort>(enumType, false).CloneValues<ushort>();
			case CorElementType.ELEMENT_TYPE_I4:
				return Enum.GetEnumInfo<uint>(enumType, false).CloneValues<int>();
			case CorElementType.ELEMENT_TYPE_U4:
				return Enum.GetEnumInfo<uint>(enumType, false).CloneValues<uint>();
			case CorElementType.ELEMENT_TYPE_I8:
				return Enum.GetEnumInfo<ulong>(enumType, false).CloneValues<long>();
			case CorElementType.ELEMENT_TYPE_U8:
				return Enum.GetEnumInfo<ulong>(enumType, false).CloneValues<ulong>();
			case CorElementType.ELEMENT_TYPE_R4:
				return Enum.GetEnumInfo<float>(enumType, false).CloneValues<float>();
			case CorElementType.ELEMENT_TYPE_R8:
				return Enum.GetEnumInfo<double>(enumType, false).CloneValues<double>();
			case CorElementType.ELEMENT_TYPE_I:
				return Enum.GetEnumInfo<UIntPtr>(enumType, false).CloneValues<IntPtr>();
			case CorElementType.ELEMENT_TYPE_U:
				return Enum.GetEnumInfo<UIntPtr>(enumType, false).CloneValues<UIntPtr>();
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B804 File Offset: 0x00009A04
		internal static Array GetValuesAsUnderlyingTypeNoCopy(RuntimeType enumType)
		{
			switch (Enum.InternalGetCorElementType(enumType))
			{
			case CorElementType.ELEMENT_TYPE_CHAR:
				return Enum.GetEnumInfo<char>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_I1:
				return Enum.GetEnumInfo<byte>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_U1:
				return Enum.GetEnumInfo<byte>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_I2:
				return Enum.GetEnumInfo<ushort>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_U2:
				return Enum.GetEnumInfo<ushort>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_I4:
				return Enum.GetEnumInfo<uint>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_U4:
				return Enum.GetEnumInfo<uint>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_I8:
				return Enum.GetEnumInfo<ulong>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_U8:
				return Enum.GetEnumInfo<ulong>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_R4:
				return Enum.GetEnumInfo<float>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_R8:
				return Enum.GetEnumInfo<double>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_I:
				return Enum.GetEnumInfo<UIntPtr>(enumType, false).Values;
			case CorElementType.ELEMENT_TYPE_U:
				return Enum.GetEnumInfo<UIntPtr>(enumType, false).Values;
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000B958 File Offset: 0x00009B58
		[Intrinsic]
		public unsafe bool HasFlag(Enum flag)
		{
			ArgumentNullException.ThrowIfNull(flag, "flag");
			if (base.GetType() != flag.GetType() && !base.GetType().IsEquivalentTo(flag.GetType()))
			{
				throw new ArgumentException(SR.Format(SR.Argument_EnumTypeDoesNotMatch, flag.GetType(), base.GetType()));
			}
			ref byte rawData = ref this.GetRawData();
			ref byte rawData2 = ref flag.GetRawData();
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
			case CorElementType.ELEMENT_TYPE_I1:
			case CorElementType.ELEMENT_TYPE_U1:
			{
				byte b = rawData2;
				return (rawData & b) == b;
			}
			case CorElementType.ELEMENT_TYPE_CHAR:
			case CorElementType.ELEMENT_TYPE_I2:
			case CorElementType.ELEMENT_TYPE_U2:
			{
				ushort num = *Unsafe.As<byte, ushort>(ref rawData2);
				return (*Unsafe.As<byte, ushort>(ref rawData) & num) == num;
			}
			case CorElementType.ELEMENT_TYPE_I4:
			case CorElementType.ELEMENT_TYPE_U4:
			case CorElementType.ELEMENT_TYPE_R4:
			{
				uint num2 = *Unsafe.As<byte, uint>(ref rawData2);
				return (*Unsafe.As<byte, uint>(ref rawData) & num2) == num2;
			}
			case CorElementType.ELEMENT_TYPE_I8:
			case CorElementType.ELEMENT_TYPE_U8:
			case CorElementType.ELEMENT_TYPE_R8:
			case CorElementType.ELEMENT_TYPE_I:
			case CorElementType.ELEMENT_TYPE_U:
			{
				ulong num3 = *Unsafe.As<byte, ulong>(ref rawData2);
				return (*Unsafe.As<byte, ulong>(ref rawData) & num3) == num3;
			}
			}
			return false;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000BA88 File Offset: 0x00009C88
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static bool IsDefined<TEnum>(TEnum value) where TEnum : struct, Enum
		{
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			if (enumUnderlyingType == typeof(sbyte) || enumUnderlyingType == typeof(byte))
			{
				return Enum.IsDefinedPrimitive<byte>(enumType, *(byte*)(&value));
			}
			if (enumUnderlyingType == typeof(short) || enumUnderlyingType == typeof(ushort))
			{
				return Enum.IsDefinedPrimitive<ushort>(enumType, *(ushort*)(&value));
			}
			if (enumUnderlyingType == typeof(int) || enumUnderlyingType == typeof(uint))
			{
				return Enum.IsDefinedPrimitive<uint>(enumType, *(uint*)(&value));
			}
			if (enumUnderlyingType == typeof(long) || enumUnderlyingType == typeof(ulong))
			{
				return Enum.IsDefinedPrimitive<ulong>(enumType, (ulong)(*(long*)(&value)));
			}
			if (enumUnderlyingType == typeof(IntPtr) || enumUnderlyingType == typeof(UIntPtr))
			{
				return Enum.IsDefinedPrimitive<UIntPtr>(enumType, (UIntPtr)(*(IntPtr*)(&value)));
			}
			if (enumUnderlyingType == typeof(float))
			{
				return Enum.IsDefinedPrimitive<float>(enumType, *(float*)(&value));
			}
			if (enumUnderlyingType == typeof(double))
			{
				return Enum.IsDefinedPrimitive<double>(enumType, *(double*)(&value));
			}
			if (enumUnderlyingType == typeof(char))
			{
				return Enum.IsDefinedPrimitive<char>(enumType, (char)(*(ushort*)(&value)));
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BBFC File Offset: 0x00009DFC
		internal static bool IsDefinedPrimitive<TStorage>(RuntimeType enumType, TStorage value) where TStorage : struct, INumber<TStorage>
		{
			Enum.EnumInfo<TStorage> enumInfo = Enum.GetEnumInfo<TStorage>(enumType, false);
			TStorage[] values = enumInfo.Values;
			if (enumInfo.ValuesAreSequentialFromZero)
			{
				return ulong.CreateTruncating<TStorage>(value) < (ulong)((long)values.Length);
			}
			return Enum.FindDefinedIndex<TStorage>(values, value) >= 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000BC38 File Offset: 0x00009E38
		public static bool IsDefined(Type enumType, object value)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			return enumType.IsEnumDefined(value);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000BC4C File Offset: 0x00009E4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int FindDefinedIndex<TStorage>(TStorage[] values, TStorage value) where TStorage : struct, IEquatable<TStorage>, IComparable<TStorage>
		{
			ReadOnlySpan<TStorage> span = values;
			if (values.Length > 32)
			{
				return span.BinarySearch(value);
			}
			return span.IndexOf(value);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000BC76 File Offset: 0x00009E76
		public static object Parse(Type enumType, string value)
		{
			return Enum.Parse(enumType, value, false);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000BC80 File Offset: 0x00009E80
		public static object Parse(Type enumType, [Nullable(0)] ReadOnlySpan<char> value)
		{
			return Enum.Parse(enumType, value, false);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000BC8C File Offset: 0x00009E8C
		public static object Parse(Type enumType, string value, bool ignoreCase)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			object result;
			Enum.TryParse(enumType, value.AsSpan(), ignoreCase, true, out result);
			return result;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public static object Parse(Type enumType, [Nullable(0)] ReadOnlySpan<char> value, bool ignoreCase)
		{
			object result;
			Enum.TryParse(enumType, value, ignoreCase, true, out result);
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000BCCE File Offset: 0x00009ECE
		[NullableContext(0)]
		public static TEnum Parse<TEnum>([Nullable(1)] string value) where TEnum : struct
		{
			return Enum.Parse<TEnum>(value, false);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000BCD7 File Offset: 0x00009ED7
		[NullableContext(0)]
		public static TEnum Parse<TEnum>(ReadOnlySpan<char> value) where TEnum : struct
		{
			return Enum.Parse<TEnum>(value, false);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		[NullableContext(0)]
		public static TEnum Parse<TEnum>([Nullable(1)] string value, bool ignoreCase) where TEnum : struct
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			TEnum result;
			Enum.TryParse<TEnum>(value.AsSpan(), ignoreCase, true, out result);
			return result;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000BD08 File Offset: 0x00009F08
		[NullableContext(0)]
		public static TEnum Parse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase) where TEnum : struct
		{
			TEnum result;
			Enum.TryParse<TEnum>(value, ignoreCase, true, out result);
			return result;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000BD21 File Offset: 0x00009F21
		[NullableContext(2)]
		public static bool TryParse([Nullable(1)] Type enumType, string value, [NotNullWhen(true)] out object result)
		{
			return Enum.TryParse(enumType, value, false, out result);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000BD2C File Offset: 0x00009F2C
		[NullableContext(0)]
		public static bool TryParse([Nullable(1)] Type enumType, ReadOnlySpan<char> value, [Nullable(2)] [NotNullWhen(true)] out object result)
		{
			return Enum.TryParse(enumType, value, false, out result);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000BD37 File Offset: 0x00009F37
		[NullableContext(2)]
		public static bool TryParse([Nullable(1)] Type enumType, string value, bool ignoreCase, [NotNullWhen(true)] out object result)
		{
			if (value != null)
			{
				return Enum.TryParse(enumType, value.AsSpan(), ignoreCase, false, out result);
			}
			result = null;
			return false;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000BD50 File Offset: 0x00009F50
		[NullableContext(0)]
		public static bool TryParse([Nullable(1)] Type enumType, ReadOnlySpan<char> value, bool ignoreCase, [Nullable(2)] [NotNullWhen(true)] out object result)
		{
			return Enum.TryParse(enumType, value, ignoreCase, false, out result);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000BD5C File Offset: 0x00009F5C
		private unsafe static bool TryParse(Type enumType, ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, [NotNullWhen(true)] out object result)
		{
			long value2 = 0L;
			RuntimeType runtimeType = Enum.ValidateRuntimeType(enumType);
			bool flag;
			switch (Enum.InternalGetCorElementType(runtimeType))
			{
			case CorElementType.ELEMENT_TYPE_I1:
				flag = Enum.TryParseByValueOrName<sbyte, byte>(runtimeType, value, ignoreCase, throwOnFailure, out *(sbyte*)(&value2));
				value2 = (long)(*(sbyte*)(&value2));
				break;
			case CorElementType.ELEMENT_TYPE_U1:
				flag = Enum.TryParseByValueOrName<byte, byte>(runtimeType, value, ignoreCase, throwOnFailure, out *(byte*)(&value2));
				value2 = (long)((ulong)(*(byte*)(&value2)));
				break;
			case CorElementType.ELEMENT_TYPE_I2:
				flag = Enum.TryParseByValueOrName<short, ushort>(runtimeType, value, ignoreCase, throwOnFailure, out *(short*)(&value2));
				value2 = (long)(*(short*)(&value2));
				break;
			case CorElementType.ELEMENT_TYPE_U2:
				flag = Enum.TryParseByValueOrName<ushort, ushort>(runtimeType, value, ignoreCase, throwOnFailure, out *(ushort*)(&value2));
				value2 = (long)((ulong)(*(ushort*)(&value2)));
				break;
			case CorElementType.ELEMENT_TYPE_I4:
				flag = Enum.TryParseByValueOrName<int, uint>(runtimeType, value, ignoreCase, throwOnFailure, out *(int*)(&value2));
				value2 = (long)(*(int*)(&value2));
				break;
			case CorElementType.ELEMENT_TYPE_U4:
				flag = Enum.TryParseByValueOrName<uint, uint>(runtimeType, value, ignoreCase, throwOnFailure, out *(uint*)(&value2));
				value2 = (long)((ulong)(*(uint*)(&value2)));
				break;
			case CorElementType.ELEMENT_TYPE_I8:
				flag = Enum.TryParseByValueOrName<long, ulong>(runtimeType, value, ignoreCase, throwOnFailure, out value2);
				break;
			case CorElementType.ELEMENT_TYPE_U8:
				flag = Enum.TryParseByValueOrName<ulong, ulong>(runtimeType, value, ignoreCase, throwOnFailure, out *(ulong*)(&value2));
				break;
			default:
				flag = Enum.<TryParse>g__TryParseRareTypes|40_0(runtimeType, value, ignoreCase, throwOnFailure, out value2);
				break;
			}
			result = (flag ? Enum.InternalBoxEnum(runtimeType.TypeHandle, value2) : null);
			return flag;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000BE69 File Offset: 0x0000A069
		[NullableContext(0)]
		public static bool TryParse<TEnum>([Nullable(2)] [NotNullWhen(true)] string value, out TEnum result) where TEnum : struct
		{
			return Enum.TryParse<TEnum>(value, false, out result);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000BE73 File Offset: 0x0000A073
		[NullableContext(0)]
		public static bool TryParse<TEnum>(ReadOnlySpan<char> value, out TEnum result) where TEnum : struct
		{
			return Enum.TryParse<TEnum>(value, false, false, out result);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000BE7E File Offset: 0x0000A07E
		[NullableContext(0)]
		public static bool TryParse<TEnum>([Nullable(2)] [NotNullWhen(true)] string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			if (value != null)
			{
				return Enum.TryParse<TEnum>(value.AsSpan(), ignoreCase, false, out result);
			}
			result = default(TEnum);
			return false;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000BE9A File Offset: 0x0000A09A
		[NullableContext(0)]
		public static bool TryParse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			return Enum.TryParse<TEnum>(value, ignoreCase, false, out result);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryParse<TEnum>(ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, out TEnum result) where TEnum : struct
		{
			if (!typeof(TEnum).IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "TEnum");
			}
			Unsafe.SkipInit<TEnum>(out result);
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			if (enumUnderlyingType == typeof(sbyte))
			{
				return Enum.TryParseByValueOrName<sbyte, byte>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, sbyte>(ref result));
			}
			if (enumUnderlyingType == typeof(byte))
			{
				return Enum.TryParseByValueOrName<byte, byte>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, byte>(ref result));
			}
			if (enumUnderlyingType == typeof(short))
			{
				return Enum.TryParseByValueOrName<short, ushort>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, short>(ref result));
			}
			if (enumUnderlyingType == typeof(ushort))
			{
				return Enum.TryParseByValueOrName<ushort, ushort>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, ushort>(ref result));
			}
			if (enumUnderlyingType == typeof(int))
			{
				return Enum.TryParseByValueOrName<int, uint>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, int>(ref result));
			}
			if (enumUnderlyingType == typeof(uint))
			{
				return Enum.TryParseByValueOrName<uint, uint>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, uint>(ref result));
			}
			if (enumUnderlyingType == typeof(long))
			{
				return Enum.TryParseByValueOrName<long, ulong>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, long>(ref result));
			}
			if (enumUnderlyingType == typeof(ulong))
			{
				return Enum.TryParseByValueOrName<ulong, ulong>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, ulong>(ref result));
			}
			if (enumUnderlyingType == typeof(IntPtr))
			{
				return Enum.TryParseRareTypeByValueOrName<IntPtr, UIntPtr>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, IntPtr>(ref result));
			}
			if (enumUnderlyingType == typeof(UIntPtr))
			{
				return Enum.TryParseRareTypeByValueOrName<UIntPtr, UIntPtr>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, UIntPtr>(ref result));
			}
			if (enumUnderlyingType == typeof(float))
			{
				return Enum.TryParseRareTypeByValueOrName<float, float>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, float>(ref result));
			}
			if (enumUnderlyingType == typeof(double))
			{
				return Enum.TryParseRareTypeByValueOrName<double, double>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, double>(ref result));
			}
			if (enumUnderlyingType == typeof(char))
			{
				return Enum.TryParseRareTypeByValueOrName<char, char>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TEnum, char>(ref result));
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		private unsafe static bool TryParseByValueOrName<[IsUnmanaged] TUnderlying, [IsUnmanaged] TStorage>(RuntimeType enumType, ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, out TUnderlying result) where TUnderlying : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TUnderlying> where TStorage : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TStorage>
		{
			if (!value.IsEmpty)
			{
				char c = (char)(*value[0]);
				if (char.IsWhiteSpace(c))
				{
					value = value.TrimStart();
					if (value.IsEmpty)
					{
						goto IL_A2;
					}
					c = (char)(*value[0]);
				}
				if (!char.IsAsciiDigit(c) && c != '-' && c != '+')
				{
					Unsafe.SkipInit<TUnderlying>(out result);
					return Enum.TryParseByName<TStorage>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TUnderlying, TStorage>(ref result));
				}
				NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
				Number.ParsingStatus parsingStatus = Number.TryParseBinaryIntegerStyle<char, TUnderlying>(value, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign, numberFormat, out result);
				if (parsingStatus == Number.ParsingStatus.OK)
				{
					return true;
				}
				if (parsingStatus != Number.ParsingStatus.Overflow)
				{
					Unsafe.SkipInit<TUnderlying>(out result);
					return Enum.TryParseByName<TStorage>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TUnderlying, TStorage>(ref result));
				}
				if (throwOnFailure)
				{
					Number.ThrowOverflowException<TUnderlying>();
				}
			}
			IL_A2:
			if (throwOnFailure)
			{
				Enum.ThrowInvalidEmptyParseArgument();
			}
			result = default(TUnderlying);
			return false;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000C17C File Offset: 0x0000A37C
		private unsafe static bool TryParseRareTypeByValueOrName<TUnderlying, TStorage>(RuntimeType enumType, ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, out TUnderlying result) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying>, IMinMaxValue<TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>, IMinMaxValue<TStorage>
		{
			if (!value.IsEmpty)
			{
				char c = (char)(*value[0]);
				if (char.IsWhiteSpace(c))
				{
					value = value.TrimStart();
					if (value.IsEmpty)
					{
						goto IL_D3;
					}
					c = (char)(*value[0]);
				}
				if (!char.IsAsciiDigit(c) && c != '-' && c != '+')
				{
					Unsafe.SkipInit<TUnderlying>(out result);
					return Enum.TryParseByName<TStorage>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TUnderlying, TStorage>(ref result));
				}
				Type underlyingType = Enum.GetUnderlyingType(enumType);
				Number.ParsingStatus parsingStatus;
				try
				{
					result = (TUnderlying)((object)Enum.ToObject(enumType, Convert.ChangeType(value.ToString(), underlyingType, CultureInfo.InvariantCulture)));
					return true;
				}
				catch (FormatException)
				{
					parsingStatus = Number.ParsingStatus.Failed;
				}
				catch when (endfilter(!throwOnFailure > false))
				{
					parsingStatus = Number.ParsingStatus.Overflow;
				}
				if (parsingStatus != Number.ParsingStatus.Overflow)
				{
					Unsafe.SkipInit<TUnderlying>(out result);
					return Enum.TryParseByName<TStorage>(enumType, value, ignoreCase, throwOnFailure, Unsafe.As<TUnderlying, TStorage>(ref result));
				}
				if (throwOnFailure)
				{
					ThrowHelper.ThrowOverflowException();
				}
			}
			IL_D3:
			if (throwOnFailure)
			{
				Enum.ThrowInvalidEmptyParseArgument();
			}
			result = default(TUnderlying);
			return false;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000C28C File Offset: 0x0000A48C
		private static bool TryParseByName<TStorage>(RuntimeType enumType, ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, out TStorage result) where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			ReadOnlySpan<char> readOnlySpan = value;
			Enum.EnumInfo<TStorage> enumInfo = Enum.GetEnumInfo<TStorage>(enumType, true);
			string[] names = enumInfo.Names;
			TStorage[] values = enumInfo.Values;
			bool flag = true;
			TStorage tstorage = default(TStorage);
			while (value.Length > 0)
			{
				int num = value.IndexOf(',');
				ReadOnlySpan<char> span;
				if (num < 0)
				{
					span = value.Trim();
					value = default(ReadOnlySpan<char>);
				}
				else
				{
					if (num == value.Length - 1)
					{
						flag = false;
						break;
					}
					span = value.Slice(0, num).Trim();
					value = value.Slice(num + 1);
				}
				bool flag2 = false;
				if (ignoreCase)
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (span.EqualsOrdinalIgnoreCase(names[i]))
						{
							tstorage |= values[i];
							flag2 = true;
							break;
						}
					}
				}
				else
				{
					for (int j = 0; j < names.Length; j++)
					{
						if (span.SequenceEqual(names[j]))
						{
							tstorage |= values[j];
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				result = tstorage;
				return true;
			}
			if (throwOnFailure)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumValueNotFound, readOnlySpan.ToString()));
			}
			result = default(TStorage);
			return false;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		internal static ulong ToUInt64(object value)
		{
			switch (Convert.GetTypeCode(value))
			{
			case TypeCode.Char:
				return (ulong)((char)value);
			case TypeCode.SByte:
				return (ulong)((long)((sbyte)value));
			case TypeCode.Byte:
				return (ulong)((byte)value);
			case TypeCode.Int16:
				return (ulong)((long)((short)value));
			case TypeCode.UInt16:
				return (ulong)((ushort)value);
			case TypeCode.Int32:
				return (ulong)((long)((int)value));
			case TypeCode.UInt32:
				return (ulong)((uint)value);
			case TypeCode.Int64:
				return (ulong)((long)value);
			case TypeCode.UInt64:
				return (ulong)value;
			default:
				if (value != null)
				{
					Type type = value.GetType();
					if (type.IsEnum)
					{
						type = type.GetEnumUnderlyingType();
					}
					if (type == typeof(IntPtr))
					{
						return (ulong)((long)((IntPtr)value));
					}
					if (type == typeof(UIntPtr))
					{
						return (ulong)((UIntPtr)value);
					}
				}
				throw Enum.CreateUnknownEnumTypeException();
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		internal unsafe object GetValue()
		{
			ref byte rawData = ref this.GetRawData();
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
				return *Unsafe.As<byte, bool>(ref rawData);
			case CorElementType.ELEMENT_TYPE_CHAR:
				return *Unsafe.As<byte, char>(ref rawData);
			case CorElementType.ELEMENT_TYPE_I1:
				return *Unsafe.As<byte, sbyte>(ref rawData);
			case CorElementType.ELEMENT_TYPE_U1:
				return rawData;
			case CorElementType.ELEMENT_TYPE_I2:
				return *Unsafe.As<byte, short>(ref rawData);
			case CorElementType.ELEMENT_TYPE_U2:
				return *Unsafe.As<byte, ushort>(ref rawData);
			case CorElementType.ELEMENT_TYPE_I4:
				return *Unsafe.As<byte, int>(ref rawData);
			case CorElementType.ELEMENT_TYPE_U4:
				return *Unsafe.As<byte, uint>(ref rawData);
			case CorElementType.ELEMENT_TYPE_I8:
				return *Unsafe.As<byte, long>(ref rawData);
			case CorElementType.ELEMENT_TYPE_U8:
				return *Unsafe.As<byte, ulong>(ref rawData);
			case CorElementType.ELEMENT_TYPE_R4:
				return *Unsafe.As<byte, float>(ref rawData);
			case CorElementType.ELEMENT_TYPE_R8:
				return *Unsafe.As<byte, double>(ref rawData);
			case CorElementType.ELEMENT_TYPE_I:
				return *Unsafe.As<byte, IntPtr>(ref rawData);
			case CorElementType.ELEMENT_TYPE_U:
				return *Unsafe.As<byte, UIntPtr>(ref rawData);
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000C630 File Offset: 0x0000A830
		[NullableContext(2)]
		public unsafe override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (this == obj)
			{
				return true;
			}
			if (base.GetType() != obj.GetType())
			{
				return false;
			}
			ref byte rawData = ref this.GetRawData();
			ref byte rawData2 = ref obj.GetRawData();
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
			case CorElementType.ELEMENT_TYPE_I1:
			case CorElementType.ELEMENT_TYPE_U1:
				return rawData == rawData2;
			case CorElementType.ELEMENT_TYPE_CHAR:
			case CorElementType.ELEMENT_TYPE_I2:
			case CorElementType.ELEMENT_TYPE_U2:
				return *Unsafe.As<byte, ushort>(ref rawData) == *Unsafe.As<byte, ushort>(ref rawData2);
			case CorElementType.ELEMENT_TYPE_I4:
			case CorElementType.ELEMENT_TYPE_U4:
			case CorElementType.ELEMENT_TYPE_R4:
				return *Unsafe.As<byte, uint>(ref rawData) == *Unsafe.As<byte, uint>(ref rawData2);
			case CorElementType.ELEMENT_TYPE_I8:
			case CorElementType.ELEMENT_TYPE_U8:
			case CorElementType.ELEMENT_TYPE_R8:
			case CorElementType.ELEMENT_TYPE_I:
			case CorElementType.ELEMENT_TYPE_U:
				return *Unsafe.As<byte, ulong>(ref rawData) == *Unsafe.As<byte, ulong>(ref rawData2);
			}
			return false;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000C718 File Offset: 0x0000A918
		public override int GetHashCode()
		{
			ref byte rawData = ref this.GetRawData();
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
				return Unsafe.As<byte, bool>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_CHAR:
				return Unsafe.As<byte, char>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_I1:
				return Unsafe.As<byte, sbyte>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_U1:
				return rawData.GetHashCode();
			case CorElementType.ELEMENT_TYPE_I2:
				return Unsafe.As<byte, short>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_U2:
				return Unsafe.As<byte, ushort>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_I4:
				return Unsafe.As<byte, int>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_U4:
				return Unsafe.As<byte, uint>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_I8:
				return Unsafe.As<byte, long>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_U8:
				return Unsafe.As<byte, ulong>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_R4:
				return Unsafe.As<byte, float>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_R8:
				return Unsafe.As<byte, double>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_I:
				return Unsafe.As<byte, IntPtr>(ref rawData).GetHashCode();
			case CorElementType.ELEMENT_TYPE_U:
				return Unsafe.As<byte, UIntPtr>(ref rawData).GetHashCode();
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000C878 File Offset: 0x0000AA78
		[NullableContext(2)]
		public unsafe int CompareTo(object target)
		{
			if (target == this)
			{
				return 0;
			}
			if (target == null)
			{
				return 1;
			}
			if (base.GetType() != target.GetType())
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumAndObjectMustBeSameType, target.GetType(), base.GetType()));
			}
			ref byte rawData = ref this.GetRawData();
			ref byte rawData2 = ref target.GetRawData();
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_BOOLEAN:
			case CorElementType.ELEMENT_TYPE_U1:
				return rawData.CompareTo(rawData2);
			case CorElementType.ELEMENT_TYPE_CHAR:
			case CorElementType.ELEMENT_TYPE_U2:
				return Unsafe.As<byte, ushort>(ref rawData).CompareTo(*Unsafe.As<byte, ushort>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_I1:
				return Unsafe.As<byte, sbyte>(ref rawData).CompareTo(*Unsafe.As<byte, sbyte>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_I2:
				return Unsafe.As<byte, short>(ref rawData).CompareTo(*Unsafe.As<byte, short>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_I4:
				return Unsafe.As<byte, int>(ref rawData).CompareTo(*Unsafe.As<byte, int>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_U4:
				return Unsafe.As<byte, uint>(ref rawData).CompareTo(*Unsafe.As<byte, uint>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_I8:
			case CorElementType.ELEMENT_TYPE_I:
				return Unsafe.As<byte, long>(ref rawData).CompareTo(*Unsafe.As<byte, long>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_U8:
			case CorElementType.ELEMENT_TYPE_U:
				return Unsafe.As<byte, ulong>(ref rawData).CompareTo(*Unsafe.As<byte, ulong>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_R4:
				return Unsafe.As<byte, float>(ref rawData).CompareTo(*Unsafe.As<byte, float>(ref rawData2));
			case CorElementType.ELEMENT_TYPE_R8:
				return Unsafe.As<byte, double>(ref rawData).CompareTo(*Unsafe.As<byte, double>(ref rawData2));
			}
			return 0;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public override string ToString()
		{
			RuntimeType enumType = (RuntimeType)base.GetType();
			ref byte rawData = ref this.GetRawData();
			string result;
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_I1:
				result = Enum.ToString<sbyte, byte>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_U1:
				result = Enum.ToStringInlined<byte, byte>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_I2:
				result = Enum.ToString<short, ushort>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_U2:
				result = Enum.ToString<ushort, ushort>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_I4:
				result = Enum.ToStringInlined<int, uint>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_U4:
				result = Enum.ToString<uint, uint>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_I8:
				result = Enum.ToString<long, ulong>(enumType, ref rawData);
				break;
			case CorElementType.ELEMENT_TYPE_U8:
				result = Enum.ToString<ulong, ulong>(enumType, ref rawData);
				break;
			default:
				result = Enum.<ToString>g__HandleRareTypes|54_0(enumType, ref rawData);
				break;
			}
			return result;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		public string ToString([Nullable(2)] [StringSyntax("EnumFormat")] string format)
		{
			if (string.IsNullOrEmpty(format))
			{
				return this.ToString();
			}
			if (format.Length == 1)
			{
				char c = format[0];
				RuntimeType enumType = (RuntimeType)base.GetType();
				ref byte rawData = ref this.GetRawData();
				string result;
				switch (this.InternalGetCorElementType())
				{
				case CorElementType.ELEMENT_TYPE_I1:
					result = Enum.ToString<sbyte, byte>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_U1:
					result = Enum.ToStringInlined<byte, byte>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_I2:
					result = Enum.ToString<short, ushort>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_U2:
					result = Enum.ToString<ushort, ushort>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_I4:
					result = Enum.ToStringInlined<int, uint>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_U4:
					result = Enum.ToString<uint, uint>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_I8:
					result = Enum.ToString<long, ulong>(enumType, c, ref rawData);
					break;
				case CorElementType.ELEMENT_TYPE_U8:
					result = Enum.ToString<ulong, ulong>(enumType, c, ref rawData);
					break;
				default:
					result = Enum.<ToString>g__HandleRareTypes|55_0(enumType, c, ref rawData);
					break;
				}
				return result;
			}
			throw Enum.CreateInvalidFormatSpecifierException();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000CB82 File Offset: 0x0000AD82
		[Obsolete("The provider argument is not used. Use ToString() instead.")]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this.ToString();
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		[NullableContext(2)]
		[Obsolete("The provider argument is not used. Use ToString(String) instead.")]
		[return: Nullable(1)]
		public string ToString([StringSyntax("EnumFormat")] string format, IFormatProvider provider)
		{
			return this.ToString(format);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000CB93 File Offset: 0x0000AD93
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ToString<TUnderlying, TStorage>(RuntimeType enumType, ref byte rawData) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			return Enum.ToStringInlined<TUnderlying, TStorage>(enumType, ref rawData);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static string ToStringInlined<TUnderlying, TStorage>(RuntimeType enumType, ref byte rawData) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			TStorage tstorage = *Unsafe.As<byte, TStorage>(ref rawData);
			Enum.EnumInfo<TStorage> enumInfo = Enum.GetEnumInfo<TStorage>(enumType, true);
			string result;
			if ((result = (enumInfo.HasFlagsAttribute ? Enum.FormatFlagNames<TStorage>(enumInfo, tstorage) : Enum.GetNameInlined<TStorage>(enumInfo, tstorage))) == null)
			{
				TUnderlying tunderlying = Unsafe.BitCast<TStorage, TUnderlying>(tstorage);
				result = tunderlying.ToString();
			}
			return result;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000CBED File Offset: 0x0000ADED
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ToString<TUnderlying, TStorage>(RuntimeType enumType, char format, ref byte rawData) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying>, IMinMaxValue<TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>, IMinMaxValue<TStorage>
		{
			return Enum.ToStringInlined<TUnderlying, TStorage>(enumType, format, ref rawData);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static string ToStringInlined<TUnderlying, TStorage>(RuntimeType enumType, char format, ref byte rawData) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying>, IMinMaxValue<TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>, IMinMaxValue<TStorage>
		{
			TStorage tstorage = *Unsafe.As<byte, TStorage>(ref rawData);
			int num = (int)(format | ' ');
			switch (num)
			{
			case 100:
				break;
			case 101:
				goto IL_89;
			case 102:
			{
				string text = Enum.FormatFlagNames<TStorage>(Enum.GetEnumInfo<TStorage>(enumType, true), tstorage);
				if (text != null)
				{
					return text;
				}
				break;
			}
			case 103:
			{
				Enum.EnumInfo<TStorage> enumInfo = Enum.GetEnumInfo<TStorage>(enumType, true);
				string text = enumInfo.HasFlagsAttribute ? Enum.FormatFlagNames<TStorage>(enumInfo, tstorage) : Enum.GetNameInlined<TStorage>(enumInfo, tstorage);
				if (text != null)
				{
					return text;
				}
				break;
			}
			default:
				if (num != 120)
				{
					goto IL_89;
				}
				return Enum.FormatNumberAsHex<TStorage>(ref rawData);
			}
			TUnderlying tunderlying = Unsafe.BitCast<TStorage, TUnderlying>(tstorage);
			return tunderlying.ToString();
			IL_89:
			throw Enum.CreateInvalidFormatSpecifierException();
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000CC98 File Offset: 0x0000AE98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static string FormatNumberAsHex<TStorage>(ref byte data) where TStorage : struct
		{
			fixed (byte* ptr = &data)
			{
				byte* state = ptr;
				return string.Create<IntPtr>(sizeof(TStorage) * 2, state, delegate(Span<char> destination, IntPtr intptr)
				{
					int num;
					Enum.TryFormatNumberAsHex<TStorage>(intptr, destination, out num);
				});
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryFormatNumberAsHex<TStorage>(ref byte data, Span<char> destination, out int charsWritten) where TStorage : struct
		{
			if (sizeof(TStorage) * 2 <= destination.Length)
			{
				if (typeof(TStorage) == typeof(byte) || typeof(TStorage) == typeof(sbyte))
				{
					HexConverter.ToCharsBuffer(data, destination, 0, HexConverter.Casing.Upper);
				}
				else if (typeof(TStorage) == typeof(ushort) || typeof(TStorage) == typeof(short) || typeof(TStorage) == typeof(char))
				{
					ushort num = *Unsafe.As<byte, ushort>(ref data);
					HexConverter.ToCharsBuffer((byte)(num >> 8), destination, 0, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)num, destination, 2, HexConverter.Casing.Upper);
				}
				else if (typeof(TStorage) == typeof(uint) || typeof(TStorage) == typeof(int))
				{
					uint num2 = *Unsafe.As<byte, uint>(ref data);
					HexConverter.ToCharsBuffer((byte)(num2 >> 24), destination, 0, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num2 >> 16), destination, 2, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num2 >> 8), destination, 4, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)num2, destination, 6, HexConverter.Casing.Upper);
				}
				else
				{
					if (!(typeof(TStorage) == typeof(ulong)) && !(typeof(TStorage) == typeof(UIntPtr)) && !(typeof(TStorage) == typeof(IntPtr)) && !(typeof(TStorage) == typeof(long)))
					{
						throw new InvalidOperationException(SR.InvalidOperation_UnknownEnumType);
					}
					ulong num3 = *Unsafe.As<byte, ulong>(ref data);
					HexConverter.ToCharsBuffer((byte)(num3 >> 56), destination, 0, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 48), destination, 2, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 40), destination, 4, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 32), destination, 6, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 24), destination, 8, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 16), destination, 10, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)(num3 >> 8), destination, 12, HexConverter.Casing.Upper);
					HexConverter.ToCharsBuffer((byte)num3, destination, 14, HexConverter.Casing.Upper);
				}
				charsWritten = sizeof(TStorage) * 2;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000CF18 File Offset: 0x0000B118
		public static string Format(Type enumType, object value, [StringSyntax("EnumFormat")] string format)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			ArgumentNullException.ThrowIfNull(format, "format");
			RuntimeType runtimeType = Enum.ValidateRuntimeType(enumType);
			Type type = value.GetType();
			if (type.IsEnum)
			{
				if (!type.IsEquivalentTo(runtimeType))
				{
					throw new ArgumentException(SR.Format(SR.Arg_EnumAndObjectMustBeSameType, type, runtimeType));
				}
				if (format.Length == 1)
				{
					return ((Enum)value).ToString(format);
				}
			}
			else
			{
				Type underlyingType = Enum.GetUnderlyingType(runtimeType);
				if (type != underlyingType)
				{
					throw new ArgumentException(SR.Format(SR.Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType, type, underlyingType));
				}
				if (format.Length == 1)
				{
					char format2 = format[0];
					ref byte rawData = ref value.GetRawData();
					switch (Enum.InternalGetCorElementType(runtimeType))
					{
					case CorElementType.ELEMENT_TYPE_CHAR:
						return Enum.ToString<char, char>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_I1:
						return Enum.ToString<sbyte, byte>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_U1:
						return Enum.ToString<byte, byte>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_I2:
						return Enum.ToString<short, ushort>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_U2:
						return Enum.ToString<ushort, ushort>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_I4:
						return Enum.ToString<int, uint>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_U4:
						return Enum.ToString<uint, uint>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_I8:
						return Enum.ToString<long, ulong>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_U8:
						return Enum.ToString<ulong, ulong>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_R4:
						return Enum.ToString<float, float>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_R8:
						return Enum.ToString<double, double>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_I:
						return Enum.ToString<IntPtr, UIntPtr>(runtimeType, format2, ref rawData);
					case CorElementType.ELEMENT_TYPE_U:
						return Enum.ToString<UIntPtr, UIntPtr>(runtimeType, format2, ref rawData);
					}
					throw Enum.CreateUnknownEnumTypeException();
				}
			}
			throw Enum.CreateInvalidFormatSpecifierException();
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		unsafe bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			RuntimeType enumType = (RuntimeType)base.GetType();
			ref byte rawData = ref this.GetRawData();
			CorElementType corElementType = this.InternalGetCorElementType();
			if (format.IsEmpty)
			{
				switch (corElementType)
				{
				case CorElementType.ELEMENT_TYPE_CHAR:
					return Enum.TryFormatPrimitiveDefault<char, char>(enumType, *Unsafe.As<byte, char>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_I1:
					return Enum.TryFormatPrimitiveDefault<sbyte, byte>(enumType, (sbyte)rawData, destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_U1:
					return Enum.TryFormatPrimitiveDefault<byte, byte>(enumType, rawData, destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_I2:
					return Enum.TryFormatPrimitiveDefault<short, ushort>(enumType, *Unsafe.As<byte, short>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_U2:
					return Enum.TryFormatPrimitiveDefault<ushort, ushort>(enumType, *Unsafe.As<byte, ushort>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_I4:
					return Enum.TryFormatPrimitiveDefault<int, uint>(enumType, *Unsafe.As<byte, int>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_U4:
					return Enum.TryFormatPrimitiveDefault<uint, uint>(enumType, *Unsafe.As<byte, uint>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_I8:
					return Enum.TryFormatPrimitiveDefault<long, ulong>(enumType, *Unsafe.As<byte, long>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_U8:
					return Enum.TryFormatPrimitiveDefault<ulong, ulong>(enumType, *Unsafe.As<byte, ulong>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_R4:
					return Enum.TryFormatPrimitiveDefault<float, float>(enumType, *Unsafe.As<byte, float>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_R8:
					return Enum.TryFormatPrimitiveDefault<double, double>(enumType, *Unsafe.As<byte, double>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_I:
					return Enum.TryFormatPrimitiveDefault<IntPtr, UIntPtr>(enumType, *Unsafe.As<byte, IntPtr>(ref rawData), destination, out charsWritten);
				case CorElementType.ELEMENT_TYPE_U:
					return Enum.TryFormatPrimitiveDefault<UIntPtr, UIntPtr>(enumType, *Unsafe.As<byte, UIntPtr>(ref rawData), destination, out charsWritten);
				}
				throw Enum.CreateUnknownEnumTypeException();
			}
			switch (corElementType)
			{
			case CorElementType.ELEMENT_TYPE_CHAR:
				return Enum.TryFormatPrimitiveNonDefault<char, char>(enumType, *Unsafe.As<byte, char>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_I1:
				return Enum.TryFormatPrimitiveNonDefault<sbyte, byte>(enumType, (sbyte)rawData, destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_U1:
				return Enum.TryFormatPrimitiveNonDefault<byte, byte>(enumType, rawData, destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_I2:
				return Enum.TryFormatPrimitiveNonDefault<short, ushort>(enumType, *Unsafe.As<byte, short>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_U2:
				return Enum.TryFormatPrimitiveNonDefault<ushort, ushort>(enumType, *Unsafe.As<byte, ushort>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_I4:
				return Enum.TryFormatPrimitiveNonDefault<int, uint>(enumType, *Unsafe.As<byte, int>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_U4:
				return Enum.TryFormatPrimitiveNonDefault<uint, uint>(enumType, *Unsafe.As<byte, uint>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_I8:
				return Enum.TryFormatPrimitiveNonDefault<long, ulong>(enumType, *Unsafe.As<byte, long>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_U8:
				return Enum.TryFormatPrimitiveNonDefault<ulong, ulong>(enumType, *Unsafe.As<byte, ulong>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_R4:
				return Enum.TryFormatPrimitiveNonDefault<float, float>(enumType, *Unsafe.As<byte, float>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_R8:
				return Enum.TryFormatPrimitiveNonDefault<double, double>(enumType, *Unsafe.As<byte, double>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_I:
				return Enum.TryFormatPrimitiveNonDefault<IntPtr, UIntPtr>(enumType, *Unsafe.As<byte, IntPtr>(ref rawData), destination, out charsWritten, format);
			case CorElementType.ELEMENT_TYPE_U:
				return Enum.TryFormatPrimitiveNonDefault<UIntPtr, UIntPtr>(enumType, *Unsafe.As<byte, UIntPtr>(ref rawData), destination, out charsWritten, format);
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000D400 File Offset: 0x0000B600
		[NullableContext(0)]
		public unsafe static bool TryFormat<TEnum>(TEnum value, Span<char> destination, out int charsWritten, [StringSyntax("EnumFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>)) where TEnum : struct
		{
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			if (format.IsEmpty)
			{
				if (enumUnderlyingType == typeof(int))
				{
					return Enum.TryFormatPrimitiveDefault<int, uint>(enumType, *(int*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(uint))
				{
					return Enum.TryFormatPrimitiveDefault<uint, uint>(enumType, *(uint*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(long))
				{
					return Enum.TryFormatPrimitiveDefault<long, ulong>(enumType, *(long*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(ulong))
				{
					return Enum.TryFormatPrimitiveDefault<ulong, ulong>(enumType, (ulong)(*(long*)(&value)), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(byte))
				{
					return Enum.TryFormatPrimitiveDefault<byte, byte>(enumType, *(byte*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(sbyte))
				{
					return Enum.TryFormatPrimitiveDefault<sbyte, byte>(enumType, *(sbyte*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(short))
				{
					return Enum.TryFormatPrimitiveDefault<short, ushort>(enumType, *(short*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(ushort))
				{
					return Enum.TryFormatPrimitiveDefault<ushort, ushort>(enumType, *(ushort*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(IntPtr))
				{
					return Enum.TryFormatPrimitiveDefault<IntPtr, UIntPtr>(enumType, *(IntPtr*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(UIntPtr))
				{
					return Enum.TryFormatPrimitiveDefault<UIntPtr, UIntPtr>(enumType, (UIntPtr)(*(IntPtr*)(&value)), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(float))
				{
					return Enum.TryFormatPrimitiveDefault<float, float>(enumType, *(float*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(double))
				{
					return Enum.TryFormatPrimitiveDefault<double, double>(enumType, *(double*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(char))
				{
					return Enum.TryFormatPrimitiveDefault<char, char>(enumType, (char)(*(ushort*)(&value)), destination, out charsWritten);
				}
			}
			else
			{
				if (enumUnderlyingType == typeof(int))
				{
					return Enum.TryFormatPrimitiveNonDefault<int, uint>(enumType, *(int*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(uint))
				{
					return Enum.TryFormatPrimitiveNonDefault<uint, uint>(enumType, *(uint*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(long))
				{
					return Enum.TryFormatPrimitiveNonDefault<long, ulong>(enumType, *(long*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(ulong))
				{
					return Enum.TryFormatPrimitiveNonDefault<ulong, ulong>(enumType, (ulong)(*(long*)(&value)), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(byte))
				{
					return Enum.TryFormatPrimitiveNonDefault<byte, byte>(enumType, *(byte*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(sbyte))
				{
					return Enum.TryFormatPrimitiveNonDefault<sbyte, byte>(enumType, *(sbyte*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(short))
				{
					return Enum.TryFormatPrimitiveNonDefault<short, ushort>(enumType, *(short*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(ushort))
				{
					return Enum.TryFormatPrimitiveNonDefault<ushort, ushort>(enumType, *(ushort*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(IntPtr))
				{
					return Enum.TryFormatPrimitiveNonDefault<IntPtr, UIntPtr>(enumType, *(IntPtr*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(UIntPtr))
				{
					return Enum.TryFormatPrimitiveNonDefault<UIntPtr, UIntPtr>(enumType, (UIntPtr)(*(IntPtr*)(&value)), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(float))
				{
					return Enum.TryFormatPrimitiveNonDefault<float, float>(enumType, *(float*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(double))
				{
					return Enum.TryFormatPrimitiveNonDefault<double, double>(enumType, *(double*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(char))
				{
					return Enum.TryFormatPrimitiveNonDefault<char, char>(enumType, (char)(*(ushort*)(&value)), destination, out charsWritten, format);
				}
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000D774 File Offset: 0x0000B974
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static bool TryFormatUnconstrained<TEnum>(TEnum value, Span<char> destination, out int charsWritten, [StringSyntax("EnumFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>))
		{
			RuntimeType enumType = (RuntimeType)typeof(TEnum);
			Type enumUnderlyingType = typeof(TEnum).GetEnumUnderlyingType();
			if (format.IsEmpty)
			{
				if (enumUnderlyingType == typeof(int))
				{
					return Enum.TryFormatPrimitiveDefault<int, uint>(enumType, *(int*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(uint))
				{
					return Enum.TryFormatPrimitiveDefault<uint, uint>(enumType, *(uint*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(long))
				{
					return Enum.TryFormatPrimitiveDefault<long, ulong>(enumType, *(long*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(ulong))
				{
					return Enum.TryFormatPrimitiveDefault<ulong, ulong>(enumType, (ulong)(*(long*)(&value)), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(byte))
				{
					return Enum.TryFormatPrimitiveDefault<byte, byte>(enumType, *(byte*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(sbyte))
				{
					return Enum.TryFormatPrimitiveDefault<sbyte, byte>(enumType, *(sbyte*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(short))
				{
					return Enum.TryFormatPrimitiveDefault<short, ushort>(enumType, *(short*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(ushort))
				{
					return Enum.TryFormatPrimitiveDefault<ushort, ushort>(enumType, *(ushort*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(IntPtr))
				{
					return Enum.TryFormatPrimitiveDefault<IntPtr, UIntPtr>(enumType, *(IntPtr*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(UIntPtr))
				{
					return Enum.TryFormatPrimitiveDefault<UIntPtr, UIntPtr>(enumType, (UIntPtr)(*(IntPtr*)(&value)), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(float))
				{
					return Enum.TryFormatPrimitiveDefault<float, float>(enumType, *(float*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(double))
				{
					return Enum.TryFormatPrimitiveDefault<double, double>(enumType, *(double*)(&value), destination, out charsWritten);
				}
				if (enumUnderlyingType == typeof(char))
				{
					return Enum.TryFormatPrimitiveDefault<char, char>(enumType, (char)(*(ushort*)(&value)), destination, out charsWritten);
				}
			}
			else
			{
				if (enumUnderlyingType == typeof(int))
				{
					return Enum.TryFormatPrimitiveNonDefault<int, uint>(enumType, *(int*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(uint))
				{
					return Enum.TryFormatPrimitiveNonDefault<uint, uint>(enumType, *(uint*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(long))
				{
					return Enum.TryFormatPrimitiveNonDefault<long, ulong>(enumType, *(long*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(ulong))
				{
					return Enum.TryFormatPrimitiveNonDefault<ulong, ulong>(enumType, (ulong)(*(long*)(&value)), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(byte))
				{
					return Enum.TryFormatPrimitiveNonDefault<byte, byte>(enumType, *(byte*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(sbyte))
				{
					return Enum.TryFormatPrimitiveNonDefault<sbyte, byte>(enumType, *(sbyte*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(short))
				{
					return Enum.TryFormatPrimitiveNonDefault<short, ushort>(enumType, *(short*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(ushort))
				{
					return Enum.TryFormatPrimitiveNonDefault<ushort, ushort>(enumType, *(ushort*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(IntPtr))
				{
					return Enum.TryFormatPrimitiveNonDefault<IntPtr, UIntPtr>(enumType, *(IntPtr*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(UIntPtr))
				{
					return Enum.TryFormatPrimitiveNonDefault<UIntPtr, UIntPtr>(enumType, (UIntPtr)(*(IntPtr*)(&value)), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(float))
				{
					return Enum.TryFormatPrimitiveNonDefault<float, float>(enumType, *(float*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(double))
				{
					return Enum.TryFormatPrimitiveNonDefault<double, double>(enumType, *(double*)(&value), destination, out charsWritten, format);
				}
				if (enumUnderlyingType == typeof(char))
				{
					return Enum.TryFormatPrimitiveNonDefault<char, char>(enumType, (char)(*(ushort*)(&value)), destination, out charsWritten, format);
				}
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		private static bool TryFormatPrimitiveDefault<TUnderlying, TStorage>(RuntimeType enumType, TUnderlying value, Span<char> destination, out int charsWritten) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying>, IMinMaxValue<TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>, IMinMaxValue<TStorage>
		{
			Enum.EnumInfo<TStorage> enumInfo = Enum.GetEnumInfo<TStorage>(enumType, true);
			if (!enumInfo.HasFlagsAttribute)
			{
				string nameInlined = Enum.GetNameInlined<TStorage>(enumInfo, Unsafe.BitCast<TUnderlying, TStorage>(value));
				if (nameInlined != null)
				{
					if (nameInlined.TryCopyTo(destination))
					{
						charsWritten = nameInlined.Length;
						return true;
					}
					charsWritten = 0;
					return false;
				}
			}
			else
			{
				bool flag = false;
				if (Enum.TryFormatFlagNames<TStorage>(enumInfo, Unsafe.BitCast<TUnderlying, TStorage>(value), destination, out charsWritten, ref flag) || flag)
				{
					return !flag;
				}
			}
			return value.TryFormat(destination, out charsWritten, default(ReadOnlySpan<char>), null);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000DB64 File Offset: 0x0000BD64
		private unsafe static bool TryFormatPrimitiveNonDefault<TUnderlying, TStorage>(RuntimeType enumType, TUnderlying value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format) where TUnderlying : struct, INumber<TUnderlying>, IBitwiseOperators<TUnderlying, TUnderlying, TUnderlying>, IMinMaxValue<TUnderlying> where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>, IMinMaxValue<TStorage>
		{
			if (format.Length == 1)
			{
				int num = (int)(*format[0] | 32);
				switch (num)
				{
				case 100:
					break;
				case 101:
					goto IL_8E;
				case 102:
				{
					bool flag = false;
					if (Enum.TryFormatFlagNames<TStorage>(Enum.GetEnumInfo<TStorage>(enumType, true), Unsafe.BitCast<TUnderlying, TStorage>(value), destination, out charsWritten, ref flag) || flag)
					{
						return !flag;
					}
					break;
				}
				case 103:
					return Enum.TryFormatPrimitiveDefault<TUnderlying, TStorage>(enumType, value, destination, out charsWritten);
				default:
					if (num != 120)
					{
						goto IL_8E;
					}
					return Enum.TryFormatNumberAsHex<TStorage>(Unsafe.As<TUnderlying, byte>(ref value), destination, out charsWritten);
				}
				return value.TryFormat(destination, out charsWritten, default(ReadOnlySpan<char>), null);
			}
			IL_8E:
			throw Enum.CreateInvalidFormatSpecifierException();
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000DC04 File Offset: 0x0000BE04
		private unsafe static string FormatFlagNames<TStorage>(Enum.EnumInfo<TStorage> enumInfo, TStorage resultValue) where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			string[] names = enumInfo.Names;
			TStorage[] values = enumInfo.Values;
			int index;
			string text = Enum.GetSingleFlagsEnumNameForValue<TStorage>(resultValue, names, values, out index);
			if (text == null)
			{
				Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)256], 64);
				int resultLength;
				int num;
				if (Enum.TryFindFlagsNames<TStorage>(resultValue, names, values, index, span, out resultLength, out num))
				{
					span = span.Slice(0, num);
					text = string.FastAllocateString(Enum.GetMultipleEnumsFlagsFormatResultLength(resultLength, num));
					Enum.WriteMultipleFoundFlagsNames(names, span, new Span<char>(text.GetRawStringData(), text.Length));
				}
			}
			return text;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		private unsafe static bool TryFormatFlagNames<TStorage>(Enum.EnumInfo<TStorage> enumInfo, TStorage resultValue, Span<char> destination, out int charsWritten, ref bool isDestinationTooSmall) where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			string[] names = enumInfo.Names;
			TStorage[] values = enumInfo.Values;
			int index;
			string singleFlagsEnumNameForValue = Enum.GetSingleFlagsEnumNameForValue<TStorage>(resultValue, names, values, out index);
			if (singleFlagsEnumNameForValue != null)
			{
				if (singleFlagsEnumNameForValue.TryCopyTo(destination))
				{
					charsWritten = singleFlagsEnumNameForValue.Length;
					return true;
				}
				isDestinationTooSmall = true;
			}
			else
			{
				Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)256], 64);
				int resultLength;
				int num;
				if (Enum.TryFindFlagsNames<TStorage>(resultValue, names, values, index, span, out resultLength, out num))
				{
					span = span.Slice(0, num);
					int multipleEnumsFlagsFormatResultLength = Enum.GetMultipleEnumsFlagsFormatResultLength(resultLength, num);
					if (multipleEnumsFlagsFormatResultLength <= destination.Length)
					{
						charsWritten = multipleEnumsFlagsFormatResultLength;
						Enum.WriteMultipleFoundFlagsNames(names, span, destination);
						return true;
					}
					isDestinationTooSmall = true;
				}
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000DD30 File Offset: 0x0000BF30
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int GetMultipleEnumsFlagsFormatResultLength(int resultLength, int foundItemsCount)
		{
			int num = 2 * (foundItemsCount - 1);
			return checked(resultLength + num);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000DD48 File Offset: 0x0000BF48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string GetSingleFlagsEnumNameForValue<TStorage>(TStorage resultValue, string[] names, TStorage[] values, out int index) where TStorage : struct, INumber<TStorage>
		{
			if (!(resultValue == INumberBase<TStorage>.Zero))
			{
				int i = values.Length - 1;
				while (i < values.Length)
				{
					if (values[i] <= resultValue)
					{
						if (values[i] == resultValue)
						{
							index = i;
							return names[i];
						}
						break;
					}
					else
					{
						i--;
					}
				}
				index = i;
				return null;
			}
			index = 0;
			if (values.Length == 0 || !(values[0] == INumberBase<TStorage>.Zero))
			{
				return "0";
			}
			return names[0];
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryFindFlagsNames<TStorage>(TStorage resultValue, string[] names, TStorage[] values, int index, Span<int> foundItems, out int resultLength, out int foundItemsCount) where TStorage : struct, INumber<TStorage>, IBitwiseOperators<TStorage, TStorage, TStorage>
		{
			resultLength = 0;
			foundItemsCount = 0;
			while (index < values.Length)
			{
				TStorage tstorage = values[index];
				if (index == 0 && tstorage == INumberBase<TStorage>.Zero)
				{
					break;
				}
				if ((resultValue & tstorage) == tstorage)
				{
					resultValue &= ~tstorage;
					*foundItems[foundItemsCount] = index;
					foundItemsCount++;
					checked
					{
						resultLength += names[index].Length;
						if (resultValue == INumberBase<TStorage>.Zero)
						{
							break;
						}
					}
				}
				index--;
			}
			return resultValue == INumberBase<TStorage>.Zero;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000DEBC File Offset: 0x0000C0BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteMultipleFoundFlagsNames(string[] names, ReadOnlySpan<int> foundItems, Span<char> destination)
		{
			for (int num = foundItems.Length - 1; num != 0; num--)
			{
				string text = names[*foundItems[num]];
				text.CopyTo(destination);
				destination = destination.Slice(text.Length);
				Span<char> span = destination.Slice(2);
				*destination[0] = ',';
				*destination[1] = ' ';
				destination = span;
			}
			names[*foundItems[0]].CopyTo(destination);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000DF30 File Offset: 0x0000C130
		private static RuntimeType ValidateRuntimeType(Type enumType)
		{
			ArgumentNullException.ThrowIfNull(enumType, "enumType");
			RuntimeType runtimeType = enumType as RuntimeType;
			if (runtimeType == null || !runtimeType.IsActualEnum)
			{
				Enum.ThrowInvalidRuntimeType(enumType);
			}
			return runtimeType;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000DF61 File Offset: 0x0000C161
		[DoesNotReturn]
		private static void ThrowInvalidRuntimeType(Type enumType)
		{
			throw new ArgumentException((!(enumType is RuntimeType)) ? SR.Arg_MustBeType : SR.Arg_MustBeEnum, "enumType");
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000DF81 File Offset: 0x0000C181
		private static void ThrowInvalidEmptyParseArgument()
		{
			throw new ArgumentException(SR.Arg_MustContainEnumInfo, "value");
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000DF92 File Offset: 0x0000C192
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static FormatException CreateInvalidFormatSpecifierException()
		{
			return new FormatException(SR.Format_InvalidEnumFormatSpecification);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000DF9E File Offset: 0x0000C19E
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static InvalidOperationException CreateUnknownEnumTypeException()
		{
			return new InvalidOperationException(SR.InvalidOperation_UnknownEnumType);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		public TypeCode GetTypeCode()
		{
			TypeCode result;
			switch (this.InternalGetCorElementType())
			{
			case CorElementType.ELEMENT_TYPE_CHAR:
				result = TypeCode.Char;
				break;
			case CorElementType.ELEMENT_TYPE_I1:
				result = TypeCode.SByte;
				break;
			case CorElementType.ELEMENT_TYPE_U1:
				result = TypeCode.Byte;
				break;
			case CorElementType.ELEMENT_TYPE_I2:
				result = TypeCode.Int16;
				break;
			case CorElementType.ELEMENT_TYPE_U2:
				result = TypeCode.UInt16;
				break;
			case CorElementType.ELEMENT_TYPE_I4:
				result = TypeCode.Int32;
				break;
			case CorElementType.ELEMENT_TYPE_U4:
				result = TypeCode.UInt32;
				break;
			case CorElementType.ELEMENT_TYPE_I8:
				result = TypeCode.Int64;
				break;
			case CorElementType.ELEMENT_TYPE_U8:
				result = TypeCode.UInt64;
				break;
			default:
				throw Enum.CreateUnknownEnumTypeException();
			}
			return result;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000E01D File Offset: 0x0000C21D
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.GetValue());
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000E02A File Offset: 0x0000C22A
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.GetValue());
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000E037 File Offset: 0x0000C237
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.GetValue());
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000E044 File Offset: 0x0000C244
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.GetValue());
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000E051 File Offset: 0x0000C251
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.GetValue());
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000E05E File Offset: 0x0000C25E
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.GetValue());
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000E06B File Offset: 0x0000C26B
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.GetValue());
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000E078 File Offset: 0x0000C278
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.GetValue());
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000E085 File Offset: 0x0000C285
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.GetValue());
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000E092 File Offset: 0x0000C292
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.GetValue());
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000E09F File Offset: 0x0000C29F
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.GetValue());
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.GetValue());
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000E0B9 File Offset: 0x0000C2B9
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.GetValue());
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Enum", "DateTime"));
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000E0EE File Offset: 0x0000C2EE
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		public static object ToObject(Type enumType, object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			switch (Convert.GetTypeCode(value))
			{
			case TypeCode.Boolean:
				return Enum.ToObject(enumType, ((bool)value > false) ? 1L : 0L);
			case TypeCode.Char:
				return Enum.ToObject(enumType, (ushort)((char)value));
			case TypeCode.SByte:
				return Enum.ToObject(enumType, (sbyte)value);
			case TypeCode.Byte:
				return Enum.ToObject(enumType, (byte)value);
			case TypeCode.Int16:
				return Enum.ToObject(enumType, (short)value);
			case TypeCode.UInt16:
				return Enum.ToObject(enumType, (ushort)value);
			case TypeCode.Int32:
				return Enum.ToObject(enumType, (int)value);
			case TypeCode.UInt32:
				return Enum.ToObject(enumType, (uint)value);
			case TypeCode.Int64:
				return Enum.ToObject(enumType, (long)value);
			case TypeCode.UInt64:
				return Enum.ToObject(enumType, (ulong)value);
			default:
			{
				Type type = value.GetType();
				if (type.IsEnum)
				{
					type = type.GetEnumUnderlyingType();
				}
				if (type == typeof(IntPtr))
				{
					Enum.ToObject(enumType, (long)((IntPtr)value));
				}
				if (type == typeof(UIntPtr))
				{
					Enum.ToObject(enumType, (ulong)((UIntPtr)value));
				}
				throw new ArgumentException(SR.Arg_MustBeEnumBaseTypeOrEnum, "value");
			}
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000E237 File Offset: 0x0000C437
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, sbyte value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)value);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000E237 File Offset: 0x0000C437
		public static object ToObject(Type enumType, short value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)value);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000E237 File Offset: 0x0000C437
		public static object ToObject(Type enumType, int value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)value);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000E24B File Offset: 0x0000C44B
		public static object ToObject(Type enumType, byte value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)((ulong)value));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000E24B File Offset: 0x0000C44B
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, ushort value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)((ulong)value));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000E24B File Offset: 0x0000C44B
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, uint value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)((ulong)value));
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000E25F File Offset: 0x0000C45F
		public static object ToObject(Type enumType, long value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, value);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000E25F File Offset: 0x0000C45F
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, ulong value)
		{
			return Enum.InternalBoxEnum(Enum.ValidateRuntimeType(enumType).TypeHandle, (long)value);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E274 File Offset: 0x0000C474
		private static object InternalBoxEnum(RuntimeTypeHandle type, long value)
		{
			ReadOnlySpan<byte> span = MemoryMarshal.AsBytes<long>(new ReadOnlySpan<long>(ref value));
			if (!BitConverter.IsLittleEndian)
			{
			}
			return RuntimeHelpers.Box(MemoryMarshal.GetReference<byte>(span), type);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		internal static bool AreSequentialFromZero<TStorage>(TStorage[] values) where TStorage : struct, INumber<TStorage>
		{
			for (int i = 0; i < values.Length; i++)
			{
				if (ulong.CreateTruncating<TStorage>(values[i]) != (ulong)((long)i))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		internal static bool AreSorted<TStorage>(TStorage[] values) where TStorage : struct, IComparable<TStorage>
		{
			for (int i = 1; i < values.Length; i++)
			{
				if (values[i - 1].CompareTo(values[i]) > 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000E314 File Offset: 0x0000C514
		[Conditional("DEBUG")]
		private static void AssertValidGenerics<TUnderlying, TStorage>()
		{
			if (!(typeof(TUnderlying) == typeof(sbyte)) && !(typeof(TUnderlying) == typeof(short)) && !(typeof(TUnderlying) == typeof(int)) && !(typeof(TUnderlying) == typeof(long)))
			{
				typeof(TUnderlying) == typeof(IntPtr);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool <TryParse>g__TryParseRareTypes|40_0(RuntimeType rt, ReadOnlySpan<char> value, bool ignoreCase, bool throwOnFailure, [NotNullWhen(true)] out long result)
		{
			CorElementType corElementType = Enum.InternalGetCorElementType(rt);
			if (corElementType <= CorElementType.ELEMENT_TYPE_R4)
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_CHAR)
				{
					char c;
					bool result2 = Enum.TryParseRareTypeByValueOrName<char, char>(rt, value, ignoreCase, throwOnFailure, out c);
					result = (long)((ulong)c);
					return result2;
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_R4)
				{
					float value2;
					bool result2 = Enum.TryParseRareTypeByValueOrName<float, float>(rt, value, ignoreCase, throwOnFailure, out value2);
					result = (long)BitConverter.SingleToInt32Bits(value2);
					return result2;
				}
			}
			else
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_R8)
				{
					double value3;
					bool result2 = Enum.TryParseRareTypeByValueOrName<double, double>(rt, value, ignoreCase, throwOnFailure, out value3);
					result = BitConverter.DoubleToInt64Bits(value3);
					return result2;
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_I)
				{
					IntPtr intPtr;
					bool result2 = Enum.TryParseRareTypeByValueOrName<IntPtr, UIntPtr>(rt, value, ignoreCase, throwOnFailure, out intPtr);
					result = (long)intPtr;
					return result2;
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_U)
				{
					UIntPtr uintPtr;
					bool result2 = Enum.TryParseRareTypeByValueOrName<UIntPtr, UIntPtr>(rt, value, ignoreCase, throwOnFailure, out uintPtr);
					result = (long)((ulong)uintPtr);
					return result2;
				}
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000E458 File Offset: 0x0000C658
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string <ToString>g__HandleRareTypes|54_0(RuntimeType enumType, ref byte rawData)
		{
			CorElementType corElementType = Enum.InternalGetCorElementType(enumType);
			if (corElementType <= CorElementType.ELEMENT_TYPE_R4)
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_CHAR)
				{
					return Enum.ToString<char, char>(enumType, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_R4)
				{
					return Enum.ToString<float, float>(enumType, ref rawData);
				}
			}
			else
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_R8)
				{
					return Enum.ToString<double, double>(enumType, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_I)
				{
					return Enum.ToString<IntPtr, UIntPtr>(enumType, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_U)
				{
					return Enum.ToString<UIntPtr, UIntPtr>(enumType, ref rawData);
				}
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string <ToString>g__HandleRareTypes|55_0(RuntimeType enumType, char formatChar, ref byte rawData)
		{
			CorElementType corElementType = Enum.InternalGetCorElementType(enumType);
			if (corElementType <= CorElementType.ELEMENT_TYPE_R4)
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_CHAR)
				{
					return Enum.ToString<char, char>(enumType, formatChar, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_R4)
				{
					return Enum.ToString<float, float>(enumType, formatChar, ref rawData);
				}
			}
			else
			{
				if (corElementType == CorElementType.ELEMENT_TYPE_R8)
				{
					return Enum.ToString<double, double>(enumType, formatChar, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_I)
				{
					return Enum.ToString<IntPtr, UIntPtr>(enumType, formatChar, ref rawData);
				}
				if (corElementType == CorElementType.ELEMENT_TYPE_U)
				{
					return Enum.ToString<UIntPtr, UIntPtr>(enumType, formatChar, ref rawData);
				}
			}
			throw Enum.CreateUnknownEnumTypeException();
		}

		// Token: 0x04000203 RID: 515
		private const char EnumSeparatorChar = ',';

		// Token: 0x0200007C RID: 124
		internal sealed class EnumInfo<TStorage> where TStorage : struct, INumber<TStorage>
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x0000E53B File Offset: 0x0000C73B
			public EnumInfo(bool hasFlagsAttribute, TStorage[] values, string[] names)
			{
				this.HasFlagsAttribute = hasFlagsAttribute;
				this.Values = values;
				this.Names = names;
				if (!Enum.AreSorted<TStorage>(values))
				{
					Array.Sort<TStorage, string>(values, names);
				}
				this.ValuesAreSequentialFromZero = Enum.AreSequentialFromZero<TStorage>(values);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0000E574 File Offset: 0x0000C774
			public TResult[] CloneValues<TResult>() where TResult : struct
			{
				return MemoryMarshal.Cast<TStorage, TResult>(this.Values).ToArray();
			}

			// Token: 0x04000204 RID: 516
			public readonly bool HasFlagsAttribute;

			// Token: 0x04000205 RID: 517
			public readonly bool ValuesAreSequentialFromZero;

			// Token: 0x04000206 RID: 518
			public readonly TStorage[] Values;

			// Token: 0x04000207 RID: 519
			public readonly string[] Names;
		}
	}
}

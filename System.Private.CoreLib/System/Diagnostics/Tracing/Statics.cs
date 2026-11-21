using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000951 RID: 2385
	internal static class Statics
	{
		// Token: 0x06008E6B RID: 36459 RVA: 0x0015F468 File Offset: 0x0015D668
		public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize)
		{
			Statics.CheckName(name);
			int num = Encoding.UTF8.GetByteCount(name) + 3 + prefixSize + suffixSize;
			byte[] array = new byte[num];
			ushort num2 = checked((ushort)(num + additionalSize));
			array[0] = (byte)num2;
			array[1] = (byte)(num2 >> 8);
			Encoding.UTF8.GetBytes(name, 0, name.Length, array, 2 + prefixSize);
			return array;
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x0015F4BC File Offset: 0x0015D6BC
		public static void EncodeTags(int tags, ref int pos, byte[] metadata)
		{
			int num = tags & 268435455;
			bool flag;
			do
			{
				byte b = (byte)(num >> 21 & 127);
				flag = ((num & 2097151) != 0);
				b |= (flag ? 128 : 0);
				num <<= 7;
				if (metadata != null)
				{
					metadata[pos] = b;
				}
				pos++;
			}
			while (flag);
		}

		// Token: 0x06008E6D RID: 36461 RVA: 0x0015F50A File Offset: 0x0015D70A
		public static byte Combine(int settingValue, byte defaultValue)
		{
			if ((int)((byte)settingValue) != settingValue)
			{
				return defaultValue;
			}
			return (byte)settingValue;
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x0015F515 File Offset: 0x0015D715
		public static int Combine(int settingValue1, int settingValue2)
		{
			if ((int)((byte)settingValue1) != settingValue1)
			{
				return settingValue2;
			}
			return settingValue1;
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x0015F51F File Offset: 0x0015D71F
		public static void CheckName(string name)
		{
			if (name != null && 0 <= name.IndexOf('\0'))
			{
				throw new ArgumentOutOfRangeException("name");
			}
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x0015F539 File Offset: 0x0015D739
		public static bool ShouldOverrideFieldName(string fieldName)
		{
			return fieldName.Length <= 2 && fieldName[0] == '_';
		}

		// Token: 0x06008E71 RID: 36465 RVA: 0x0015F551 File Offset: 0x0015D751
		public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format)
		{
			return (baseType & (TraceLoggingDataType)31) | (TraceLoggingDataType)(format << 8);
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x0015F55C File Offset: 0x0015D75C
		public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native)
		{
			switch (format)
			{
			case EventFieldFormat.Default:
				return native;
			case EventFieldFormat.String:
				return TraceLoggingDataType.Char8;
			case EventFieldFormat.Boolean:
				return TraceLoggingDataType.Boolean8;
			case EventFieldFormat.Hexadecimal:
				return TraceLoggingDataType.HexInt8;
			}
			return Statics.MakeDataType(native, format);
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x0015F5AC File Offset: 0x0015D7AC
		public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native)
		{
			switch (format)
			{
			case EventFieldFormat.Default:
				return native;
			case EventFieldFormat.String:
				return TraceLoggingDataType.Char16;
			case EventFieldFormat.Hexadecimal:
				return TraceLoggingDataType.HexInt16;
			}
			return Statics.MakeDataType(native, format);
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x0015F5F4 File Offset: 0x0015D7F4
		public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native)
		{
			switch (format)
			{
			case EventFieldFormat.Default:
				return native;
			case (EventFieldFormat)1:
			case EventFieldFormat.String:
				break;
			case EventFieldFormat.Boolean:
				return TraceLoggingDataType.Boolean32;
			case EventFieldFormat.Hexadecimal:
				return TraceLoggingDataType.HexInt32;
			default:
				if (format == EventFieldFormat.HResult)
				{
					return TraceLoggingDataType.HResult;
				}
				break;
			}
			return Statics.MakeDataType(native, format);
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x0015F644 File Offset: 0x0015D844
		public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native)
		{
			TraceLoggingDataType result;
			if (format != EventFieldFormat.Default)
			{
				if (format != EventFieldFormat.Hexadecimal)
				{
					result = Statics.MakeDataType(native, format);
				}
				else
				{
					result = TraceLoggingDataType.HexInt64;
				}
			}
			else
			{
				result = native;
			}
			return result;
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x0015F66C File Offset: 0x0015D86C
		public static TraceLoggingDataType FormatScalar(EventFieldFormat format, TraceLoggingDataType nativeFormat)
		{
			switch (nativeFormat)
			{
			case TraceLoggingDataType.Int8:
			case TraceLoggingDataType.UInt8:
				break;
			case TraceLoggingDataType.Int16:
			case TraceLoggingDataType.UInt16:
				goto IL_4A;
			case TraceLoggingDataType.Int32:
			case TraceLoggingDataType.UInt32:
			case TraceLoggingDataType.Float:
				return Statics.Format32(format, nativeFormat);
			case TraceLoggingDataType.Int64:
			case TraceLoggingDataType.UInt64:
			case TraceLoggingDataType.Double:
				return Statics.Format64(format, nativeFormat);
			default:
				if (nativeFormat == TraceLoggingDataType.Char16)
				{
					goto IL_4A;
				}
				if (nativeFormat != TraceLoggingDataType.Boolean8)
				{
					return Statics.MakeDataType(nativeFormat, format);
				}
				break;
			}
			return Statics.Format8(format, nativeFormat);
			IL_4A:
			return Statics.Format16(format, nativeFormat);
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x0015F6EA File Offset: 0x0015D8EA
		public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType)
		{
			return propInfo.IsDefined(attributeType, false);
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x0015F6F4 File Offset: 0x0015D8F4
		public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) where AttributeType : Attribute
		{
			AttributeType result = default(AttributeType);
			object[] customAttributes = propInfo.GetCustomAttributes(typeof(AttributeType), false);
			if (customAttributes.Length != 0)
			{
				result = (AttributeType)((object)customAttributes[0]);
			}
			return result;
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x0015F72C File Offset: 0x0015D92C
		public static AttributeType GetCustomAttribute<AttributeType>(Type type) where AttributeType : Attribute
		{
			AttributeType result = default(AttributeType);
			object[] customAttributes = type.GetCustomAttributes(typeof(AttributeType), false);
			if (customAttributes.Length != 0)
			{
				result = (AttributeType)((object)customAttributes[0]);
			}
			return result;
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x0015F764 File Offset: 0x0015D964
		public static Type FindEnumerableElementType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type type)
		{
			Type type2 = null;
			if (Statics.IsGenericMatch(type, typeof(IEnumerable<>)))
			{
				type2 = type.GetGenericArguments()[0];
			}
			else
			{
				TypeFilter filter;
				if ((filter = Statics.<>O.<0>__IsGenericMatch) == null)
				{
					filter = (Statics.<>O.<0>__IsGenericMatch = new TypeFilter(Statics.IsGenericMatch));
				}
				foreach (Type type3 in type.FindInterfaces(filter, typeof(IEnumerable<>)))
				{
					if (type2 != null)
					{
						type2 = null;
						break;
					}
					type2 = type3.GetGenericArguments()[0];
				}
			}
			return type2;
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x0015F7E5 File Offset: 0x0015D9E5
		public static bool IsGenericMatch(Type type, object openType)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == (Type)openType;
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x0015F804 File Offset: 0x0015DA04
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		public static TraceLoggingTypeInfo CreateDefaultTypeInfo(Type dataType, List<Type> recursionCheck)
		{
			if (recursionCheck.Contains(dataType))
			{
				throw new NotSupportedException(SR.EventSource_RecursiveTypeDefinition);
			}
			recursionCheck.Add(dataType);
			EventDataAttribute customAttribute = Statics.GetCustomAttribute<EventDataAttribute>(dataType);
			TraceLoggingTypeInfo result;
			if (customAttribute != null || Statics.GetCustomAttribute<CompilerGeneratedAttribute>(dataType) != null || Statics.IsGenericMatch(dataType, typeof(KeyValuePair<, >)))
			{
				TypeAnalysis typeAnalysis = new TypeAnalysis(dataType, customAttribute, recursionCheck);
				result = new InvokeTypeInfo(dataType, typeAnalysis);
			}
			else if (dataType.IsArray)
			{
				Type elementType = dataType.GetElementType();
				if (elementType == typeof(bool))
				{
					result = ScalarArrayTypeInfo.Boolean();
				}
				else if (elementType == typeof(byte))
				{
					result = ScalarArrayTypeInfo.Byte();
				}
				else if (elementType == typeof(sbyte))
				{
					result = ScalarArrayTypeInfo.SByte();
				}
				else if (elementType == typeof(short))
				{
					result = ScalarArrayTypeInfo.Int16();
				}
				else if (elementType == typeof(ushort))
				{
					result = ScalarArrayTypeInfo.UInt16();
				}
				else if (elementType == typeof(int))
				{
					result = ScalarArrayTypeInfo.Int32();
				}
				else if (elementType == typeof(uint))
				{
					result = ScalarArrayTypeInfo.UInt32();
				}
				else if (elementType == typeof(long))
				{
					result = ScalarArrayTypeInfo.Int64();
				}
				else if (elementType == typeof(ulong))
				{
					result = ScalarArrayTypeInfo.UInt64();
				}
				else if (elementType == typeof(char))
				{
					result = ScalarArrayTypeInfo.Char();
				}
				else if (elementType == typeof(double))
				{
					result = ScalarArrayTypeInfo.Double();
				}
				else if (elementType == typeof(float))
				{
					result = ScalarArrayTypeInfo.Single();
				}
				else if (elementType == typeof(IntPtr))
				{
					result = ScalarArrayTypeInfo.IntPtr();
				}
				else if (elementType == typeof(UIntPtr))
				{
					result = ScalarArrayTypeInfo.UIntPtr();
				}
				else if (elementType == typeof(Guid))
				{
					result = ScalarArrayTypeInfo.Guid();
				}
				else
				{
					result = new ArrayTypeInfo(dataType, TraceLoggingTypeInfo.GetInstance(elementType, recursionCheck));
				}
			}
			else
			{
				if (dataType.IsEnum)
				{
					dataType = Enum.GetUnderlyingType(dataType);
				}
				if (dataType == typeof(string))
				{
					result = StringTypeInfo.Instance();
				}
				else if (dataType == typeof(bool))
				{
					result = ScalarTypeInfo.Boolean();
				}
				else if (dataType == typeof(byte))
				{
					result = ScalarTypeInfo.Byte();
				}
				else if (dataType == typeof(sbyte))
				{
					result = ScalarTypeInfo.SByte();
				}
				else if (dataType == typeof(short))
				{
					result = ScalarTypeInfo.Int16();
				}
				else if (dataType == typeof(ushort))
				{
					result = ScalarTypeInfo.UInt16();
				}
				else if (dataType == typeof(int))
				{
					result = ScalarTypeInfo.Int32();
				}
				else if (dataType == typeof(uint))
				{
					result = ScalarTypeInfo.UInt32();
				}
				else if (dataType == typeof(long))
				{
					result = ScalarTypeInfo.Int64();
				}
				else if (dataType == typeof(ulong))
				{
					result = ScalarTypeInfo.UInt64();
				}
				else if (dataType == typeof(char))
				{
					result = ScalarTypeInfo.Char();
				}
				else if (dataType == typeof(double))
				{
					result = ScalarTypeInfo.Double();
				}
				else if (dataType == typeof(float))
				{
					result = ScalarTypeInfo.Single();
				}
				else if (dataType == typeof(DateTime))
				{
					result = DateTimeTypeInfo.Instance();
				}
				else if (dataType == typeof(decimal))
				{
					result = DecimalTypeInfo.Instance();
				}
				else if (dataType == typeof(IntPtr))
				{
					result = ScalarTypeInfo.IntPtr();
				}
				else if (dataType == typeof(UIntPtr))
				{
					result = ScalarTypeInfo.UIntPtr();
				}
				else if (dataType == typeof(Guid))
				{
					result = ScalarTypeInfo.Guid();
				}
				else if (dataType == typeof(TimeSpan))
				{
					result = TimeSpanTypeInfo.Instance();
				}
				else if (dataType == typeof(DateTimeOffset))
				{
					result = DateTimeOffsetTypeInfo.Instance();
				}
				else if (dataType == typeof(EmptyStruct))
				{
					result = NullTypeInfo.Instance();
				}
				else if (Statics.IsGenericMatch(dataType, typeof(Nullable<>)))
				{
					result = new NullableTypeInfo(dataType, recursionCheck);
				}
				else
				{
					Type type = Statics.FindEnumerableElementType(dataType);
					if (!(type != null))
					{
						throw new ArgumentException(SR.Format(SR.EventSource_NonCompliantTypeError, dataType.Name));
					}
					result = new EnumerableTypeInfo(dataType, TraceLoggingTypeInfo.GetInstance(type, recursionCheck));
				}
			}
			return result;
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x0015FCFF File Offset: 0x0015DEFF
		// Note: this type is marked as 'beforefieldinit'.
		static Statics()
		{
			if (8 != 8)
			{
			}
			Statics.IntPtrType = TraceLoggingDataType.Int64;
			if (8 != 8)
			{
			}
			Statics.UIntPtrType = TraceLoggingDataType.UInt64;
			if (8 != 8)
			{
			}
			Statics.HexIntPtrType = TraceLoggingDataType.HexInt64;
		}

		// Token: 0x04002179 RID: 8569
		public static readonly TraceLoggingDataType IntPtrType;

		// Token: 0x0400217A RID: 8570
		public static readonly TraceLoggingDataType UIntPtrType;

		// Token: 0x0400217B RID: 8571
		public static readonly TraceLoggingDataType HexIntPtrType;

		// Token: 0x02000952 RID: 2386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400217C RID: 8572
			public static TypeFilter <0>__IsGenericMatch;
		}
	}
}

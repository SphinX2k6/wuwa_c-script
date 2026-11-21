using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x0200079A RID: 1946
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public class CustomAttributeBuilder
	{
		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x001244F0 File Offset: 0x001226F0
		internal ConstructorInfo Ctor
		{
			get
			{
				return this.ctor;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x001244F8 File Offset: 0x001226F8
		internal byte[] Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x06007BEF RID: 31727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte[] GetBlob(Assembly asmb, ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues);

		// Token: 0x06007BF0 RID: 31728 RVA: 0x00124500 File Offset: 0x00122700
		internal CustomAttributeBuilder(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			this.ctor = con;
			this.data = binaryAttribute.ToArray();
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x00124527 File Offset: 0x00122727
		public CustomAttributeBuilder(ConstructorInfo con, [Nullable(new byte[]
		{
			1,
			2
		})] object[] constructorArgs)
		{
			this.Initialize(con, constructorArgs, Array.Empty<PropertyInfo>(), Array.Empty<object>(), Array.Empty<FieldInfo>(), Array.Empty<object>());
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x0012454B File Offset: 0x0012274B
		public CustomAttributeBuilder(ConstructorInfo con, [Nullable(new byte[]
		{
			1,
			2
		})] object[] constructorArgs, FieldInfo[] namedFields, object[] fieldValues)
		{
			this.Initialize(con, constructorArgs, Array.Empty<PropertyInfo>(), Array.Empty<object>(), namedFields, fieldValues);
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x00124568 File Offset: 0x00122768
		public CustomAttributeBuilder(ConstructorInfo con, [Nullable(new byte[]
		{
			1,
			2
		})] object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues)
		{
			this.Initialize(con, constructorArgs, namedProperties, propertyValues, Array.Empty<FieldInfo>(), Array.Empty<object>());
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x00124585 File Offset: 0x00122785
		public CustomAttributeBuilder(ConstructorInfo con, [Nullable(new byte[]
		{
			1,
			2
		})] object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues)
		{
			this.Initialize(con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0012459C File Offset: 0x0012279C
		private static bool IsValidType(Type t)
		{
			if (t.IsArray && t.GetArrayRank() > 1)
			{
				return false;
			}
			if (t is TypeBuilder && t.IsEnum)
			{
				Enum.GetUnderlyingType(t);
			}
			return (!t.IsClass || t.IsArray || t == typeof(object) || typeof(Type).IsAssignableFrom(t) || t == typeof(string) || t.Assembly.GetName().Name == "mscorlib") && (!t.IsValueType || t.IsPrimitive || t.IsEnum || (t.Assembly is AssemblyBuilder && t.Assembly.GetName().Name == "mscorlib"));
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x0012467C File Offset: 0x0012287C
		private static bool IsValidParam(object o, Type paramType)
		{
			Type type = o.GetType();
			if (!CustomAttributeBuilder.IsValidType(type))
			{
				return false;
			}
			if (paramType == typeof(object))
			{
				if (type.IsArray && type.GetArrayRank() == 1)
				{
					return CustomAttributeBuilder.IsValidType(type.GetElementType());
				}
				if (!type.IsPrimitive && !typeof(Type).IsAssignableFrom(type) && type != typeof(string) && !type.IsEnum)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x00124700 File Offset: 0x00122900
		private static bool IsValidValue(Type type, object value)
		{
			if (type.IsValueType && value == null)
			{
				return false;
			}
			if (type.IsArray && type.GetElementType().IsValueType && value != null)
			{
				using (IEnumerator enumerator = ((Array)value).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == null)
						{
							return false;
						}
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x0012477C File Offset: 0x0012297C
		private void Initialize(ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues)
		{
			this.ctor = con;
			this.args = constructorArgs;
			this.namedProperties = namedProperties;
			this.propertyValues = propertyValues;
			this.namedFields = namedFields;
			this.fieldValues = fieldValues;
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(constructorArgs, "constructorArgs");
			ArgumentNullException.ThrowIfNull(namedProperties, "namedProperties");
			ArgumentNullException.ThrowIfNull(propertyValues, "propertyValues");
			ArgumentNullException.ThrowIfNull(namedFields, "namedFields");
			ArgumentNullException.ThrowIfNull(fieldValues, "fieldValues");
			AssemblyBuilder.EnsureDynamicCodeSupported();
			if (con.GetParametersCount() != constructorArgs.Length)
			{
				throw new ArgumentException(SR.Argument_BadParameterCountsForConstructor);
			}
			if (namedProperties.Length != propertyValues.Length)
			{
				throw new ArgumentException(SR.Arg_ArrayLengthsDiffer, "namedProperties, propertyValues");
			}
			if (namedFields.Length != fieldValues.Length)
			{
				throw new ArgumentException(SR.Arg_ArrayLengthsDiffer, "namedFields, fieldValues");
			}
			if ((con.Attributes & MethodAttributes.Static) == MethodAttributes.Static || (con.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private)
			{
				throw new ArgumentException(SR.Argument_BadConstructor);
			}
			Type declaringType = this.ctor.DeclaringType;
			int num = 0;
			foreach (FieldInfo fieldInfo in namedFields)
			{
				Type declaringType2 = fieldInfo.DeclaringType;
				if (declaringType != declaringType2 && !declaringType2.IsSubclassOf(declaringType) && !declaringType.IsSubclassOf(declaringType2))
				{
					throw new ArgumentException(SR.Format(SR.Argument_FieldDoesNotBelongToConstructorClass, fieldInfo.Name));
				}
				if (!CustomAttributeBuilder.IsValidType(fieldInfo.FieldType))
				{
					throw new ArgumentException(SR.Format(SR.Argument_FieldDoesNotHaveAValidType, fieldInfo.Name));
				}
				if (!CustomAttributeBuilder.IsValidValue(fieldInfo.FieldType, fieldValues[num]))
				{
					throw new ArgumentException(SR.Format(SR.Argument_FieldDoesNotHaveAValidValue, fieldInfo.Name));
				}
				if (fieldValues[num] != null && !(fieldInfo.FieldType is TypeBuilder) && !fieldInfo.FieldType.IsEnum && !fieldInfo.FieldType.IsInstanceOfType(fieldValues[num]) && !fieldInfo.FieldType.IsArray)
				{
					throw new ArgumentException(SR.Format(SR.Argument_UnmatchedFieldValueAndType, fieldInfo.Name, fieldInfo.FieldType));
				}
				num++;
			}
			num = 0;
			foreach (PropertyInfo propertyInfo in namedProperties)
			{
				if (!propertyInfo.CanWrite)
				{
					throw new ArgumentException(SR.Format(SR.Argument_PropertyMissingSetter, propertyInfo.Name));
				}
				Type declaringType3 = propertyInfo.DeclaringType;
				if (declaringType != declaringType3 && !declaringType3.IsSubclassOf(declaringType) && !declaringType.IsSubclassOf(declaringType3))
				{
					throw new ArgumentException(SR.Format(SR.Argument_PropertyClassUnmatchedWithConstructor, propertyInfo.Name));
				}
				if (!CustomAttributeBuilder.IsValidType(propertyInfo.PropertyType))
				{
					throw new ArgumentException(SR.Format(SR.Argument_PropertyInvalidType, propertyInfo.Name));
				}
				if (!CustomAttributeBuilder.IsValidValue(propertyInfo.PropertyType, propertyValues[num]))
				{
					throw new ArgumentException(SR.Format(SR.Argument_PropertyInvalidValue, propertyInfo.Name));
				}
				if (propertyValues[num] != null && !(propertyInfo.PropertyType is TypeBuilder) && !propertyInfo.PropertyType.IsEnum && !propertyInfo.PropertyType.IsInstanceOfType(propertyValues[num]) && !propertyInfo.PropertyType.IsArray)
				{
					throw new ArgumentException(SR.Format(SR.Argument_PropertyUnmatchingPropertyType, propertyInfo.Name, propertyInfo.PropertyType, propertyValues[num]));
				}
				num++;
			}
			num = 0;
			foreach (ParameterInfo parameterInfo in CustomAttributeBuilder.GetParameters(con))
			{
				if (parameterInfo != null)
				{
					Type parameterType = parameterInfo.ParameterType;
					if (!CustomAttributeBuilder.IsValidType(parameterType))
					{
						throw new ArgumentException(SR.Format(SR.Argument_ParameterInvalidType, num));
					}
					if (!CustomAttributeBuilder.IsValidValue(parameterType, constructorArgs[num]))
					{
						throw new ArgumentException(SR.Format(SR.Argument_ParameterInvalidValue, num));
					}
					if (constructorArgs[num] != null)
					{
						if (!(parameterType is TypeBuilder) && !parameterType.IsEnum && !parameterType.IsInstanceOfType(constructorArgs[num]) && !parameterType.IsArray)
						{
							throw new ArgumentException(SR.Format(SR.Argument_ParameterHasUnmatchedArgumentValue, num, parameterType, constructorArgs[num]));
						}
						if (!CustomAttributeBuilder.IsValidParam(constructorArgs[num], parameterType))
						{
							throw new ArgumentException(SR.Format(SR.Argument_BadParameterTypeForCAB, constructorArgs[num].GetType()));
						}
					}
				}
				num++;
			}
			this.data = CustomAttributeBuilder.GetBlob(declaringType.Assembly, con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00124BBC File Offset: 0x00122DBC
		internal unsafe static int decode_len(ReadOnlySpan<byte> data, int pos, out int rpos)
		{
			int result;
			if ((*data[pos] & 128) == 0)
			{
				result = (int)(*data[pos++] & 127);
			}
			else if ((*data[pos] & 64) == 0)
			{
				result = ((int)(*data[pos] & 63) << 8) + (int)(*data[pos + 1]);
				pos += 2;
			}
			else
			{
				result = ((int)(*data[pos] & 31) << 24) + ((int)(*data[pos + 1]) << 16) + ((int)(*data[pos + 2]) << 8) + (int)(*data[pos + 3]);
				pos += 4;
			}
			rpos = pos;
			return result;
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00124C60 File Offset: 0x00122E60
		internal static string string_from_bytes(ReadOnlySpan<byte> data, int pos, int len)
		{
			return Encoding.UTF8.GetString(data.Slice(pos, len));
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00124C78 File Offset: 0x00122E78
		internal static string decode_string(byte[] data, int pos, out int rpos)
		{
			if (data[pos] == 255)
			{
				rpos = pos + 1;
				return null;
			}
			int num = CustomAttributeBuilder.decode_len(data, pos, out pos);
			string result = CustomAttributeBuilder.string_from_bytes(data, pos, num);
			pos += num;
			rpos = pos;
			return result;
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00124CBC File Offset: 0x00122EBC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2057:UnrecognizedReflectionPattern", Justification = "Types referenced from custom attributes are preserved")]
		internal static UnmanagedMarshal get_umarshal(CustomAttributeBuilder customBuilder, bool is_field)
		{
			byte[] array = customBuilder.Data;
			UnmanagedType elemType = (UnmanagedType)80;
			int num = -1;
			int sizeParamIndex = -1;
			bool flag = false;
			string empty = string.Empty;
			int num2 = (int)array[2];
			num2 |= (int)array[3] << 8;
			string fullName = CustomAttributeBuilder.GetParameters(customBuilder.Ctor)[0].ParameterType.FullName;
			int num3 = 6;
			if (fullName == "System.Int16")
			{
				num3 = 4;
			}
			int num4 = (int)array[num3++];
			num4 |= (int)array[num3++] << 8;
			int i = 0;
			while (i < num4)
			{
				byte b = array[num3++];
				if (array[num3++] == 85)
				{
					CustomAttributeBuilder.decode_string(array, num3, out num3);
				}
				string text = CustomAttributeBuilder.decode_string(array, num3, out num3);
				if (text != null)
				{
					int length = text.Length;
					switch (length)
					{
					case 9:
						if (!(text == "SizeConst"))
						{
							goto IL_2D4;
						}
						num = ((int)array[num3++] | (int)array[num3++] << 8 | (int)array[num3++] << 16 | (int)array[num3++] << 24);
						flag = true;
						break;
					case 10:
					case 15:
						goto IL_2D4;
					case 11:
					{
						if (!(text == "MarshalType"))
						{
							goto IL_2D4;
						}
						string text2 = CustomAttributeBuilder.decode_string(array, num3, out num3);
						break;
					}
					case 12:
						if (!(text == "ArraySubType"))
						{
							goto IL_2D4;
						}
						elemType = (UnmanagedType)((int)array[num3++] | (int)array[num3++] << 8 | (int)array[num3++] << 16 | (int)array[num3++] << 24);
						break;
					case 13:
						if (!(text == "MarshalCookie"))
						{
							goto IL_2D4;
						}
						CustomAttributeBuilder.decode_string(array, num3, out num3);
						break;
					case 14:
					{
						char c = text[0];
						if (c != 'M')
						{
							if (c != 'S')
							{
								goto IL_2D4;
							}
							if (!(text == "SizeParamIndex"))
							{
								goto IL_2D4;
							}
							sizeParamIndex = ((int)array[num3++] | (int)array[num3++] << 8);
							flag = true;
						}
						else
						{
							if (!(text == "MarshalTypeRef"))
							{
								goto IL_2D4;
							}
							string text2 = CustomAttributeBuilder.decode_string(array, num3, out num3);
							if (text2 != null)
							{
								Type.GetType(text2);
							}
						}
						break;
					}
					case 16:
						if (!(text == "SafeArraySubType"))
						{
							goto IL_2D4;
						}
						elemType = (UnmanagedType)((int)array[num3++] | (int)array[num3++] << 8 | (int)array[num3++] << 16 | (int)array[num3++] << 24);
						break;
					case 17:
						if (!(text == "IidParameterIndex"))
						{
							goto IL_2D4;
						}
						num3 += 4;
						break;
					default:
						if (length != 27)
						{
							goto IL_2D4;
						}
						if (!(text == "SafeArrayUserDefinedSubType"))
						{
							goto IL_2D4;
						}
						CustomAttributeBuilder.decode_string(array, num3, out num3);
						break;
					}
					i++;
					continue;
				}
				IL_2D4:
				throw new Exception(SR.Format(SR.Exception_UnknownMarshalAsAttributeField, text));
			}
			UnmanagedType unmanagedType = (UnmanagedType)num2;
			if (unmanagedType == UnmanagedType.ByValTStr)
			{
				return UnmanagedMarshal.DefineByValTStr(num);
			}
			if (unmanagedType != UnmanagedType.ByValArray)
			{
				if (unmanagedType != UnmanagedType.LPArray)
				{
					return UnmanagedMarshal.DefineUnmanagedMarshal((UnmanagedType)num2);
				}
				if (flag)
				{
					return UnmanagedMarshal.DefineLPArrayInternal(elemType, num, sizeParamIndex);
				}
				return UnmanagedMarshal.DefineLPArray(elemType);
			}
			else
			{
				if (!is_field)
				{
					throw new ArgumentException(SR.Argument_UnmanagedTypeOnlyValidOnFields);
				}
				return UnmanagedMarshal.DefineByValArray(num);
			}
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x0012500C File Offset: 0x0012320C
		private static Type elementTypeToType(int elementType)
		{
			Type typeFromHandle;
			switch (elementType)
			{
			case 2:
				typeFromHandle = typeof(bool);
				break;
			case 3:
				typeFromHandle = typeof(char);
				break;
			case 4:
				typeFromHandle = typeof(sbyte);
				break;
			case 5:
				typeFromHandle = typeof(byte);
				break;
			case 6:
				typeFromHandle = typeof(short);
				break;
			case 7:
				typeFromHandle = typeof(ushort);
				break;
			case 8:
				typeFromHandle = typeof(int);
				break;
			case 9:
				typeFromHandle = typeof(uint);
				break;
			case 10:
				typeFromHandle = typeof(long);
				break;
			case 11:
				typeFromHandle = typeof(ulong);
				break;
			case 12:
				typeFromHandle = typeof(float);
				break;
			case 13:
				typeFromHandle = typeof(double);
				break;
			case 14:
				typeFromHandle = typeof(string);
				break;
			default:
				throw new Exception(SR.Format(SR.ArgumentException_InvalidTypeArgument, elementType));
			}
			return typeFromHandle;
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x00125128 File Offset: 0x00123328
		private unsafe static object decode_cattr_value(Type t, ReadOnlySpan<byte> data, int pos, out int rpos)
		{
			TypeCode typeCode = Type.GetTypeCode(t);
			if (typeCode <= TypeCode.Boolean)
			{
				if (typeCode != TypeCode.Object)
				{
					if (typeCode == TypeCode.Boolean)
					{
						rpos = pos + 1;
						return *data[pos] > 0;
					}
				}
				else
				{
					int num = (int)(*data[pos]);
					pos++;
					if (num >= 2 && num <= 14)
					{
						return CustomAttributeBuilder.decode_cattr_value(CustomAttributeBuilder.elementTypeToType(num), data, pos, out rpos);
					}
					throw new Exception(SR.Exception_UnhandledSubType);
				}
			}
			else
			{
				if (typeCode == TypeCode.Int32)
				{
					rpos = pos + 4;
					return (int)(*data[pos]) + ((int)(*data[pos + 1]) << 8) + ((int)(*data[pos + 2]) << 16) + ((int)(*data[pos + 3]) << 24);
				}
				if (typeCode == TypeCode.String)
				{
					if (*data[pos] == 255)
					{
						rpos = pos + 1;
						return null;
					}
					int num2 = CustomAttributeBuilder.decode_len(data, pos, out pos);
					rpos = pos + num2;
					return CustomAttributeBuilder.string_from_bytes(data, pos, num2);
				}
			}
			throw new Exception("FIXME: Type " + ((t != null) ? t.ToString() : null) + " not yet handled in decode_cattr_value.");
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x0012523C File Offset: 0x0012343C
		internal static CustomAttributeBuilder.CustomAttributeInfo decode_cattr(CustomAttributeBuilder customBuilder)
		{
			byte[] array = customBuilder.Data;
			return CustomAttributeBuilder.decode_cattr(customBuilder.Ctor, array);
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00125264 File Offset: 0x00123464
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2057:UnrecognizedReflectionPattern", Justification = "Types referenced from custom attributes are preserved")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Types referenced from custom attributes are preserved")]
		internal unsafe static CustomAttributeBuilder.CustomAttributeInfo decode_cattr(ConstructorInfo ctor, ReadOnlySpan<byte> data)
		{
			CustomAttributeBuilder.CustomAttributeInfo customAttributeInfo = default(CustomAttributeBuilder.CustomAttributeInfo);
			if (data.Length < 2)
			{
				throw new Exception(SR.Format(SR.Exception_InvalidCustomAttributeLength, data.Length));
			}
			if (*data[0] != 1 || *data[1] != 0)
			{
				throw new Exception(SR.Exception_InvalidProlog);
			}
			int num = 2;
			ParameterInfo[] parameters = CustomAttributeBuilder.GetParameters(ctor);
			customAttributeInfo.ctor = ctor;
			customAttributeInfo.ctorArgs = new object[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				customAttributeInfo.ctorArgs[i] = CustomAttributeBuilder.decode_cattr_value(parameters[i].ParameterType, data, num, out num);
			}
			int num2 = (int)(*data[num]) + (int)(*data[num + 1]) * 256;
			num += 2;
			customAttributeInfo.namedParamNames = new string[num2];
			customAttributeInfo.namedParamValues = new object[num2];
			for (int j = 0; j < num2; j++)
			{
				int num3 = (int)(*data[num++]);
				int num4 = (int)(*data[num++]);
				string text = null;
				if (num4 == 85)
				{
					int num5 = CustomAttributeBuilder.decode_len(data, num, out num);
					text = CustomAttributeBuilder.string_from_bytes(data, num, num5);
					num += num5;
				}
				int num6 = CustomAttributeBuilder.decode_len(data, num, out num);
				string text2 = CustomAttributeBuilder.string_from_bytes(data, num, num6);
				customAttributeInfo.namedParamNames[j] = text2;
				num += num6;
				if (num3 != 83)
				{
					throw new Exception(SR.Format(SR.Exception_UnknownNamedType, num3));
				}
				FieldInfo field = ctor.DeclaringType.GetField(text2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (field == null)
				{
					throw new Exception(SR.Format(SR.Exception_EmptyFieldForCustomAttributeType, ctor.DeclaringType, text2));
				}
				object obj = CustomAttributeBuilder.decode_cattr_value(field.FieldType, data, num, out num);
				if (text != null)
				{
					obj = Enum.ToObject(Type.GetType(text), obj);
				}
				customAttributeInfo.namedParamValues[j] = obj;
			}
			return customAttributeInfo;
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x00125444 File Offset: 0x00123644
		private static ParameterInfo[] GetParameters(ConstructorInfo ctor)
		{
			ConstructorBuilder constructorBuilder = ctor as ConstructorBuilder;
			if (constructorBuilder != null)
			{
				return constructorBuilder.GetParametersInternal();
			}
			return ctor.GetParametersInternal();
		}

		// Token: 0x04001785 RID: 6021
		private ConstructorInfo ctor;

		// Token: 0x04001786 RID: 6022
		private byte[] data;

		// Token: 0x04001787 RID: 6023
		private object[] args;

		// Token: 0x04001788 RID: 6024
		private PropertyInfo[] namedProperties;

		// Token: 0x04001789 RID: 6025
		private object[] propertyValues;

		// Token: 0x0400178A RID: 6026
		private FieldInfo[] namedFields;

		// Token: 0x0400178B RID: 6027
		private object[] fieldValues;

		// Token: 0x0200079B RID: 1947
		internal struct CustomAttributeInfo
		{
			// Token: 0x0400178C RID: 6028
			public ConstructorInfo ctor;

			// Token: 0x0400178D RID: 6029
			public object[] ctorArgs;

			// Token: 0x0400178E RID: 6030
			public string[] namedParamNames;

			// Token: 0x0400178F RID: 6031
			public object[] namedParamValues;
		}
	}
}

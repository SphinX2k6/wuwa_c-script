using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000FC RID: 252
	internal class DefaultBinder : Binder
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x0002D044 File Offset: 0x0002B244
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "AOT compiler ensures params arrays are created for reflection-invokable methods")]
		public unsafe sealed override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state)
		{
			if (match == null || match.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptyArray, "match");
			}
			MethodBase[] array = (MethodBase[])match.Clone();
			state = null;
			int[][] array2 = new int[array.Length][];
			for (int i = 0; i < array.Length; i++)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = array[i].GetParametersAsSpan();
				array2[i] = new int[(parametersAsSpan.Length > args.Length) ? parametersAsSpan.Length : args.Length];
				if (names == null)
				{
					for (int j = 0; j < parametersAsSpan.Length; j++)
					{
						array2[i][j] = j;
					}
				}
				else if (!DefaultBinder.CreateParamOrder(array2[i], parametersAsSpan, names))
				{
					array[i] = null;
				}
			}
			Type[] array3 = new Type[array.Length];
			Type[] array4 = new Type[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] != null)
				{
					array4[i] = args[i].GetType();
				}
			}
			int num = 0;
			bool flag = (bindingAttr & BindingFlags.OptionalParamBinding) > BindingFlags.Default;
			for (int i = 0; i < array.Length; i++)
			{
				Type type = null;
				if (!(array[i] == null))
				{
					ReadOnlySpan<ParameterInfo> parametersAsSpan2 = array[i].GetParametersAsSpan();
					if (parametersAsSpan2.Length == 0)
					{
						if (args.Length == 0 || (array[i].CallingConvention & CallingConventions.VarArgs) != (CallingConventions)0)
						{
							array2[num] = array2[i];
							array[num++] = array[i];
						}
					}
					else
					{
						int j;
						if (parametersAsSpan2.Length > args.Length)
						{
							j = args.Length;
							while (j < parametersAsSpan2.Length - 1 && parametersAsSpan2[j]->DefaultValue != DBNull.Value)
							{
								j++;
							}
							if (j != parametersAsSpan2.Length - 1)
							{
								goto IL_469;
							}
							if (parametersAsSpan2[j]->DefaultValue == DBNull.Value)
							{
								if (!parametersAsSpan2[j]->ParameterType.IsArray || !parametersAsSpan2[j]->IsDefined(typeof(ParamArrayAttribute), true))
								{
									goto IL_469;
								}
								type = parametersAsSpan2[j]->ParameterType.GetElementType();
							}
						}
						else if (parametersAsSpan2.Length < args.Length)
						{
							int num2 = parametersAsSpan2.Length - 1;
							if (!parametersAsSpan2[num2]->ParameterType.IsArray || !parametersAsSpan2[num2]->IsDefined(typeof(ParamArrayAttribute), true) || array2[i][num2] != num2)
							{
								goto IL_469;
							}
							type = parametersAsSpan2[num2]->ParameterType.GetElementType();
						}
						else
						{
							int num3 = parametersAsSpan2.Length - 1;
							if (parametersAsSpan2[num3]->ParameterType.IsArray && parametersAsSpan2[num3]->IsDefined(typeof(ParamArrayAttribute), true) && array2[i][num3] == num3 && !parametersAsSpan2[num3]->ParameterType.IsAssignableFrom(array4[num3]))
							{
								type = parametersAsSpan2[num3]->ParameterType.GetElementType();
							}
						}
						int num4 = (type != null) ? (parametersAsSpan2.Length - 1) : args.Length;
						j = 0;
						while (j < num4)
						{
							Type type2 = parametersAsSpan2[j]->ParameterType;
							if (type2.IsByRef)
							{
								type2 = type2.GetElementType();
							}
							int num5 = array2[i][j];
							if (num5 >= args.Length)
							{
								goto IL_3B7;
							}
							if (!(type2 == array4[num5]) && (!flag || args[num5] != Type.Missing) && args[num5] != null && !(type2 == typeof(object)))
							{
								if (type2.IsPrimitive)
								{
									if (array4[num5] == null)
									{
										break;
									}
									if (!DefaultBinder.CanChangePrimitive(args[num5].GetType(), type2))
									{
										break;
									}
								}
								else if (!(array4[num5] == null) && !type2.IsAssignableFrom(array4[num5]))
								{
									if (false)
									{
										goto IL_3B7;
									}
									break;
								}
							}
							IL_3CA:
							j++;
							continue;
							IL_3B7:
							if (flag)
							{
								bool hasDefaultValue = parametersAsSpan2[j]->HasDefaultValue;
								goto IL_3CA;
							}
							goto IL_3CA;
						}
						if (type != null && j == parametersAsSpan2.Length - 1)
						{
							while (j < args.Length)
							{
								if (type.IsPrimitive)
								{
									if (array4[j] == null)
									{
										break;
									}
									object obj = args[j];
									if (!DefaultBinder.CanChangePrimitive((obj != null) ? obj.GetType() : null, type))
									{
										break;
									}
								}
								else if (!(array4[j] == null) && !type.IsAssignableFrom(array4[j]) && !false)
								{
									break;
								}
								j++;
							}
						}
						if (j == args.Length)
						{
							array2[num] = array2[i];
							array3[num] = type;
							array[num++] = array[i];
						}
					}
				}
				IL_469:;
			}
			if (num == 0)
			{
				throw new MissingMethodException(SR.MissingMember);
			}
			if (num == 1)
			{
				if (names != null)
				{
					state = new DefaultBinder.BinderState((int[])array2[0].Clone(), args.Length, array3[0] != null);
					DefaultBinder.ReorderParams(array2[0], args);
				}
				ReadOnlySpan<ParameterInfo> parametersAsSpan3 = array[0].GetParametersAsSpan();
				if (parametersAsSpan3.Length == args.Length)
				{
					if (array3[0] != null)
					{
						object[] array5 = new object[parametersAsSpan3.Length];
						int num6 = parametersAsSpan3.Length - 1;
						Array.Copy(args, array5, num6);
						array5[num6] = Array.CreateInstance(array3[0], 1);
						((Array)array5[num6]).SetValue(args[num6], 0);
						args = array5;
					}
				}
				else if (parametersAsSpan3.Length > args.Length)
				{
					object[] array6 = new object[parametersAsSpan3.Length];
					for (int i = 0; i < parametersAsSpan3.Length; i++)
					{
						int num7 = array2[0][i];
						if (num7 < args.Length)
						{
							array6[i] = args[num7];
						}
						else if (i == parametersAsSpan3.Length - 1 && array3[0] != null)
						{
							array6[i] = Array.CreateInstance(array3[0], 0);
						}
						else
						{
							array6[i] = parametersAsSpan3[i]->DefaultValue;
						}
					}
					args = array6;
				}
				else if ((array[0].CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
				{
					object[] array7 = new object[parametersAsSpan3.Length];
					int num8 = parametersAsSpan3.Length - 1;
					Array.Copy(args, array7, num8);
					array7[num8] = Array.CreateInstance(array3[0], args.Length - num8);
					Array.Copy(args, num8, (Array)array7[num8], 0, args.Length - num8);
					args = array7;
				}
				return array[0];
			}
			int num9 = 0;
			bool flag2 = false;
			for (int i = 1; i < num; i++)
			{
				int num10 = DefaultBinder.FindMostSpecificMethod(array[num9], array2[num9], array3[num9], array[i], array2[i], array3[i], array4, args);
				if (num10 == 0)
				{
					flag2 = true;
				}
				else if (num10 == 2)
				{
					num9 = i;
					flag2 = false;
				}
			}
			MethodBase methodBase = array[num9];
			if (flag2)
			{
				throw ThrowHelper.GetAmbiguousMatchException(methodBase);
			}
			if (names != null)
			{
				state = new DefaultBinder.BinderState((int[])array2[num9].Clone(), args.Length, array3[num9] != null);
				DefaultBinder.ReorderParams(array2[num9], args);
			}
			ReadOnlySpan<ParameterInfo> parametersAsSpan4 = methodBase.GetParametersAsSpan();
			if (parametersAsSpan4.Length == args.Length)
			{
				if (array3[num9] != null)
				{
					object[] array8 = new object[parametersAsSpan4.Length];
					int num11 = parametersAsSpan4.Length - 1;
					Array.Copy(args, array8, num11);
					array8[num11] = Array.CreateInstance(array3[num9], 1);
					((Array)array8[num11]).SetValue(args[num11], 0);
					args = array8;
				}
			}
			else if (parametersAsSpan4.Length > args.Length)
			{
				object[] array9 = new object[parametersAsSpan4.Length];
				int i;
				for (i = 0; i < args.Length; i++)
				{
					array9[i] = args[i];
				}
				while (i < parametersAsSpan4.Length - 1)
				{
					array9[i] = parametersAsSpan4[i]->DefaultValue;
					i++;
				}
				if (array3[num9] != null)
				{
					array9[i] = Array.CreateInstance(array3[num9], 0);
				}
				else
				{
					array9[i] = parametersAsSpan4[i]->DefaultValue;
				}
				args = array9;
			}
			else if ((methodBase.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
			{
				object[] array10 = new object[parametersAsSpan4.Length];
				int num12 = parametersAsSpan4.Length - 1;
				Array.Copy(args, array10, num12);
				array10[num12] = Array.CreateInstance(array3[num9], args.Length - num12);
				Array.Copy(args, num12, (Array)array10[num12], 0, args.Length - num12);
				args = array10;
			}
			return methodBase;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0002D870 File Offset: 0x0002BA70
		public sealed override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo)
		{
			ArgumentNullException.ThrowIfNull(match, "match");
			int num = 0;
			FieldInfo[] array = (FieldInfo[])match.Clone();
			if ((bindingAttr & BindingFlags.SetField) != BindingFlags.Default)
			{
				Type type = value.GetType();
				for (int i = 0; i < array.Length; i++)
				{
					Type fieldType = array[i].FieldType;
					if (fieldType == type)
					{
						array[num++] = array[i];
					}
					else if (value == Empty.Value && fieldType.IsClass)
					{
						array[num++] = array[i];
					}
					else if (fieldType == typeof(object))
					{
						array[num++] = array[i];
					}
					else if (fieldType.IsPrimitive)
					{
						if (DefaultBinder.CanChangePrimitive(type, fieldType))
						{
							array[num++] = array[i];
						}
					}
					else if (fieldType.IsAssignableFrom(type))
					{
						array[num++] = array[i];
					}
				}
				if (num == 0)
				{
					throw new MissingFieldException(SR.MissingField);
				}
				if (num == 1)
				{
					return array[0];
				}
			}
			int num2 = 0;
			bool flag = false;
			for (int i = 1; i < num; i++)
			{
				int num3 = DefaultBinder.FindMostSpecificField(array[num2], array[i]);
				if (num3 == 0)
				{
					flag = true;
				}
				else if (num3 == 2)
				{
					num2 = i;
					flag = false;
				}
			}
			FieldInfo fieldInfo = array[num2];
			if (flag)
			{
				throw ThrowHelper.GetAmbiguousMatchException(fieldInfo);
			}
			return fieldInfo;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0002D9AC File Offset: 0x0002BBAC
		public unsafe sealed override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
		{
			Type[] array = new Type[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				array[i] = types[i].UnderlyingSystemType;
				if (!(array[i] is RuntimeType) && !(array[i] is SignatureType))
				{
					throw new ArgumentException(SR.Arg_MustBeType, "types");
				}
			}
			types = array;
			if (match == null || match.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptyArray, "match");
			}
			MethodBase[] array2 = (MethodBase[])match.Clone();
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = array2[i].GetParametersAsSpan();
				if (parametersAsSpan.Length == types.Length)
				{
					int j;
					for (j = 0; j < types.Length; j++)
					{
						Type parameterType = parametersAsSpan[j]->ParameterType;
						if (!types[j].MatchesParameterTypeExactly(*parametersAsSpan[j]) && !(parameterType == typeof(object)))
						{
							Type type = types[j];
							SignatureType signatureType = type as SignatureType;
							if (signatureType != null)
							{
								MethodInfo methodInfo = array2[i] as MethodInfo;
								if (methodInfo == null)
								{
									break;
								}
								type = signatureType.TryResolveAgainstGenericMethod(methodInfo);
								if (type == null)
								{
									break;
								}
							}
							if (parameterType.IsPrimitive)
							{
								RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
								if (runtimeType == null)
								{
									break;
								}
								if (!DefaultBinder.CanChangePrimitive(runtimeType, parameterType.UnderlyingSystemType))
								{
									break;
								}
							}
							else if (!parameterType.IsAssignableFrom(type))
							{
								break;
							}
						}
					}
					if (j == types.Length)
					{
						array2[num++] = array2[i];
					}
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (num == 1)
			{
				return array2[0];
			}
			int num2 = 0;
			bool flag = false;
			int[] array3 = new int[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				array3[i] = i;
			}
			for (int i = 1; i < num; i++)
			{
				int num3 = DefaultBinder.FindMostSpecificMethod(array2[num2], array3, null, array2[i], array3, null, types, null);
				if (num3 == 0)
				{
					flag = true;
				}
				else if (num3 == 2)
				{
					flag = false;
					num2 = i;
				}
			}
			MethodBase methodBase = array2[num2];
			if (flag)
			{
				throw ThrowHelper.GetAmbiguousMatchException(methodBase);
			}
			return methodBase;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		public sealed override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
		{
			if (indexes != null)
			{
				for (int i = 0; i < indexes.Length; i++)
				{
					ArgumentNullException.ThrowIfNull(indexes[i], "indexes");
				}
			}
			if (match == null || match.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptyArray, "match");
			}
			PropertyInfo[] array = (PropertyInfo[])match.Clone();
			int j = 0;
			int num = 0;
			int num2 = (indexes != null) ? indexes.Length : 0;
			int k = 0;
			while (k < array.Length)
			{
				if (indexes == null)
				{
					goto IL_F5;
				}
				ParameterInfo[] indexParameters = array[k].GetIndexParameters();
				if (indexParameters.Length == num2)
				{
					for (j = 0; j < num2; j++)
					{
						Type parameterType = indexParameters[j].ParameterType;
						if (!(parameterType == indexes[j]) && !(parameterType == typeof(object)))
						{
							if (parameterType.IsPrimitive)
							{
								RuntimeType runtimeType = indexes[j].UnderlyingSystemType as RuntimeType;
								if (runtimeType == null)
								{
									break;
								}
								if (!DefaultBinder.CanChangePrimitive(runtimeType, parameterType.UnderlyingSystemType))
								{
									break;
								}
							}
							else if (!parameterType.IsAssignableFrom(indexes[j]))
							{
								break;
							}
						}
					}
					goto IL_F5;
				}
				IL_155:
				k++;
				continue;
				IL_F5:
				if (j == num2)
				{
					if (returnType != null)
					{
						if (array[k].PropertyType.IsPrimitive)
						{
							RuntimeType runtimeType2 = returnType.UnderlyingSystemType as RuntimeType;
							if (runtimeType2 == null)
							{
								goto IL_155;
							}
							if (!DefaultBinder.CanChangePrimitive(runtimeType2, array[k].PropertyType.UnderlyingSystemType))
							{
								goto IL_155;
							}
						}
						else if (!array[k].PropertyType.IsAssignableFrom(returnType))
						{
							goto IL_155;
						}
					}
					array[num++] = array[k];
					goto IL_155;
				}
				goto IL_155;
			}
			if (num == 0)
			{
				return null;
			}
			if (num == 1)
			{
				return array[0];
			}
			int num3 = 0;
			bool flag = false;
			int[] array2 = new int[num2];
			for (k = 0; k < num2; k++)
			{
				array2[k] = k;
			}
			for (k = 1; k < num; k++)
			{
				int num4 = DefaultBinder.FindMostSpecificType(array[num3].PropertyType, array[k].PropertyType, returnType);
				if (num4 == 0 && indexes != null)
				{
					num4 = DefaultBinder.FindMostSpecific(array[num3].GetIndexParameters(), array2, null, array[k].GetIndexParameters(), array2, null, indexes, null);
				}
				if (num4 == 0)
				{
					num4 = DefaultBinder.FindMostSpecificProperty(array[num3], array[k]);
					if (num4 == 0)
					{
						flag = true;
					}
				}
				if (num4 == 2)
				{
					flag = false;
					num3 = k;
				}
			}
			PropertyInfo propertyInfo = array[num3];
			if (flag)
			{
				throw ThrowHelper.GetAmbiguousMatchException(propertyInfo);
			}
			return propertyInfo;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002DDCD File Offset: 0x0002BFCD
		public override object ChangeType(object value, Type type, CultureInfo cultureInfo)
		{
			throw new NotSupportedException(SR.NotSupported_ChangeType);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002DDDC File Offset: 0x0002BFDC
		public sealed override void ReorderArgumentArray(ref object[] args, object state)
		{
			DefaultBinder.BinderState binderState = (DefaultBinder.BinderState)state;
			DefaultBinder.ReorderParams(binderState._argsMap, args);
			if (!binderState._isParamArray)
			{
				if (args.Length > binderState._originalSize)
				{
					object[] array = new object[binderState._originalSize];
					Array.Copy(args, array, binderState._originalSize);
					args = array;
				}
				return;
			}
			int num = args.Length - 1;
			if (args.Length == binderState._originalSize)
			{
				args[num] = ((object[])args[num])[0];
				return;
			}
			object[] array2 = new object[args.Length];
			Array.Copy(args, array2, num);
			int i = num;
			int num2 = 0;
			while (i < array2.Length)
			{
				array2[i] = ((object[])args[num])[num2];
				i++;
				num2++;
			}
			args = array2;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002DE94 File Offset: 0x0002C094
		public unsafe static MethodBase ExactBinding(MethodBase[] match, Type[] types)
		{
			ArgumentNullException.ThrowIfNull(match, "match");
			MethodBase[] array = new MethodBase[match.Length];
			int num = 0;
			for (int i = 0; i < match.Length; i++)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = match[i].GetParametersAsSpan();
				if (parametersAsSpan.Length != 0)
				{
					int num2 = 0;
					while (num2 < types.Length && parametersAsSpan[num2]->ParameterType.Equals(types[num2]))
					{
						num2++;
					}
					if (num2 >= types.Length)
					{
						array[num] = match[i];
						num++;
					}
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (num == 1)
			{
				return array[0];
			}
			return DefaultBinder.FindMostDerivedNewSlotMeth(array, num);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002DF28 File Offset: 0x0002C128
		public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types)
		{
			ArgumentNullException.ThrowIfNull(match, "match");
			PropertyInfo propertyInfo = null;
			int num = (types != null) ? types.Length : 0;
			for (int i = 0; i < match.Length; i++)
			{
				ParameterInfo[] indexParameters = match[i].GetIndexParameters();
				int num2 = 0;
				while (num2 < num && !(indexParameters[num2].ParameterType != types[num2]))
				{
					num2++;
				}
				if (num2 >= num && (!(returnType != null) || !(returnType != match[i].PropertyType)))
				{
					if (propertyInfo != null)
					{
						throw ThrowHelper.GetAmbiguousMatchException(propertyInfo);
					}
					propertyInfo = match[i];
				}
			}
			return propertyInfo;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002DFBC File Offset: 0x0002C1BC
		private unsafe static int FindMostSpecific(ReadOnlySpan<ParameterInfo> p1, int[] paramOrder1, Type paramArrayType1, ReadOnlySpan<ParameterInfo> p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
		{
			if (paramArrayType1 != null && paramArrayType2 == null)
			{
				return 2;
			}
			if (paramArrayType2 != null && paramArrayType1 == null)
			{
				return 1;
			}
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < types.Length; i++)
			{
				if (args == null || args[i] != Type.Missing)
				{
					Type type;
					if (paramArrayType1 != null && paramOrder1[i] >= p1.Length - 1)
					{
						type = paramArrayType1;
					}
					else
					{
						type = p1[paramOrder1[i]]->ParameterType;
					}
					Type type2;
					if (paramArrayType2 != null && paramOrder2[i] >= p2.Length - 1)
					{
						type2 = paramArrayType2;
					}
					else
					{
						type2 = p2[paramOrder2[i]]->ParameterType;
					}
					if (!(type == type2))
					{
						switch (DefaultBinder.FindMostSpecificType(type, type2, types[i]))
						{
						case 0:
							return 0;
						case 1:
							flag = true;
							break;
						case 2:
							flag2 = true;
							break;
						}
					}
				}
			}
			if (flag == flag2)
			{
				if (!flag && args != null)
				{
					if (p1.Length > p2.Length)
					{
						return 1;
					}
					if (p2.Length > p1.Length)
					{
						return 2;
					}
				}
				return 0;
			}
			if (!flag)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		private static int FindMostSpecificType(Type c1, Type c2, Type t)
		{
			if (c1 == c2)
			{
				return 0;
			}
			SignatureType signatureType = t as SignatureType;
			if (signatureType != null)
			{
				if (signatureType.MatchesExactly(c1))
				{
					return 1;
				}
				if (signatureType.MatchesExactly(c2))
				{
					return 2;
				}
			}
			else
			{
				if (c1 == t)
				{
					return 1;
				}
				if (c2 == t)
				{
					return 2;
				}
			}
			if (c1.IsByRef || c2.IsByRef)
			{
				if (c1.IsByRef && c2.IsByRef)
				{
					c1 = c1.GetElementType();
					c2 = c2.GetElementType();
				}
				else if (c1.IsByRef)
				{
					if (c1.GetElementType() == c2)
					{
						return 2;
					}
					c1 = c1.GetElementType();
				}
				else
				{
					if (c2.GetElementType() == c1)
					{
						return 1;
					}
					c2 = c2.GetElementType();
				}
			}
			bool flag;
			bool flag2;
			if (c1.IsPrimitive && c2.IsPrimitive)
			{
				flag = DefaultBinder.CanChangePrimitive(c2, c1);
				flag2 = DefaultBinder.CanChangePrimitive(c1, c2);
			}
			else
			{
				flag = c1.IsAssignableFrom(c2);
				flag2 = c2.IsAssignableFrom(c1);
			}
			if (flag == flag2)
			{
				return 0;
			}
			if (flag)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002E1E0 File Offset: 0x0002C3E0
		private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
		{
			int num = DefaultBinder.FindMostSpecific(m1.GetParametersAsSpan(), paramOrder1, paramArrayType1, m2.GetParametersAsSpan(), paramOrder2, paramArrayType2, types, args);
			if (num != 0)
			{
				return num;
			}
			if (!DefaultBinder.CompareMethodSig(m1, m2))
			{
				return 0;
			}
			int hierarchyDepth = DefaultBinder.GetHierarchyDepth(m1.DeclaringType);
			int hierarchyDepth2 = DefaultBinder.GetHierarchyDepth(m2.DeclaringType);
			if (hierarchyDepth == hierarchyDepth2)
			{
				return 0;
			}
			if (hierarchyDepth < hierarchyDepth2)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002E240 File Offset: 0x0002C440
		private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
		{
			if (!(cur1.Name == cur2.Name))
			{
				return 0;
			}
			int hierarchyDepth = DefaultBinder.GetHierarchyDepth(cur1.DeclaringType);
			int hierarchyDepth2 = DefaultBinder.GetHierarchyDepth(cur2.DeclaringType);
			if (hierarchyDepth == hierarchyDepth2)
			{
				return 0;
			}
			if (hierarchyDepth < hierarchyDepth2)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002E288 File Offset: 0x0002C488
		private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
		{
			if (!(cur1.Name == cur2.Name))
			{
				return 0;
			}
			int hierarchyDepth = DefaultBinder.GetHierarchyDepth(cur1.DeclaringType);
			int hierarchyDepth2 = DefaultBinder.GetHierarchyDepth(cur2.DeclaringType);
			if (hierarchyDepth == hierarchyDepth2)
			{
				return 0;
			}
			if (hierarchyDepth < hierarchyDepth2)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
		public unsafe static bool CompareMethodSig(MethodBase m1, MethodBase m2)
		{
			ReadOnlySpan<ParameterInfo> parametersAsSpan = m1.GetParametersAsSpan();
			ReadOnlySpan<ParameterInfo> parametersAsSpan2 = m2.GetParametersAsSpan();
			if (parametersAsSpan.Length != parametersAsSpan2.Length)
			{
				return false;
			}
			int length = parametersAsSpan.Length;
			for (int i = 0; i < length; i++)
			{
				if (parametersAsSpan[i]->ParameterType != parametersAsSpan2[i]->ParameterType)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0002E338 File Offset: 0x0002C538
		private static int GetHierarchyDepth(Type t)
		{
			int num = 0;
			Type type = t;
			do
			{
				num++;
				type = type.BaseType;
			}
			while (type != null);
			return num;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0002E360 File Offset: 0x0002C560
		internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches)
		{
			int num = 0;
			MethodBase methodBase = null;
			for (int i = 0; i < cMatches; i++)
			{
				int hierarchyDepth = DefaultBinder.GetHierarchyDepth(match[i].DeclaringType);
				if (hierarchyDepth == num)
				{
					throw ThrowHelper.GetAmbiguousMatchException(methodBase);
				}
				if (hierarchyDepth > num)
				{
					num = hierarchyDepth;
					methodBase = match[i];
				}
			}
			return methodBase;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		private static void ReorderParams(int[] paramOrder, object[] vars)
		{
			object[] array = new object[vars.Length];
			for (int i = 0; i < vars.Length; i++)
			{
				array[i] = vars[i];
			}
			int j = 0;
			int num = 0;
			while (j < vars.Length)
			{
				if (paramOrder[num] < vars.Length)
				{
					vars[j] = array[paramOrder[num]];
					paramOrder[num] = j;
					j++;
				}
				num++;
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		private unsafe static bool CreateParamOrder(int[] paramOrder, ReadOnlySpan<ParameterInfo> pars, string[] names)
		{
			bool[] array = new bool[pars.Length];
			for (int i = 0; i < pars.Length; i++)
			{
				paramOrder[i] = -1;
			}
			for (int j = 0; j < names.Length; j++)
			{
				int k;
				for (k = 0; k < pars.Length; k++)
				{
					if (names[j].Equals(pars[k]->Name))
					{
						paramOrder[k] = j;
						array[j] = true;
						break;
					}
				}
				if (k == pars.Length)
				{
					return false;
				}
			}
			int l = 0;
			for (int m = 0; m < pars.Length; m++)
			{
				if (paramOrder[m] == -1)
				{
					while (l < pars.Length)
					{
						if (!array[l])
						{
							paramOrder[m] = l;
							l++;
							break;
						}
						l++;
					}
				}
			}
			return true;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0002E4C0 File Offset: 0x0002C6C0
		internal unsafe static bool CanChangePrimitive(Type source, Type target)
		{
			if ((source == typeof(IntPtr) && target == typeof(IntPtr)) || (source == typeof(UIntPtr) && target == typeof(UIntPtr)))
			{
				return true;
			}
			DefaultBinder.Primitives primitives = (DefaultBinder.Primitives)(*DefaultBinder.PrimitiveConversions[(int)Type.GetTypeCode(source)]);
			DefaultBinder.Primitives primitives2 = (DefaultBinder.Primitives)(1 << (int)Type.GetTypeCode(target));
			return (primitives & primitives2) > (DefaultBinder.Primitives)0;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0002E53C File Offset: 0x0002C73C
		private static ReadOnlySpan<DefaultBinder.Primitives> PrimitiveConversions
		{
			get
			{
				return RuntimeHelpers.CreateSpan<DefaultBinder.Primitives>(fieldof(<PrivateImplementationDetails>.25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A4).FieldHandle);
			}
		}

		// Token: 0x020000FD RID: 253
		[Flags]
		private enum Primitives
		{
			// Token: 0x04000382 RID: 898
			Boolean = 8,
			// Token: 0x04000383 RID: 899
			Char = 16,
			// Token: 0x04000384 RID: 900
			SByte = 32,
			// Token: 0x04000385 RID: 901
			Byte = 64,
			// Token: 0x04000386 RID: 902
			Int16 = 128,
			// Token: 0x04000387 RID: 903
			UInt16 = 256,
			// Token: 0x04000388 RID: 904
			Int32 = 512,
			// Token: 0x04000389 RID: 905
			UInt32 = 1024,
			// Token: 0x0400038A RID: 906
			Int64 = 2048,
			// Token: 0x0400038B RID: 907
			UInt64 = 4096,
			// Token: 0x0400038C RID: 908
			Single = 8192,
			// Token: 0x0400038D RID: 909
			Double = 16384,
			// Token: 0x0400038E RID: 910
			Decimal = 32768,
			// Token: 0x0400038F RID: 911
			DateTime = 65536,
			// Token: 0x04000390 RID: 912
			String = 262144
		}

		// Token: 0x020000FE RID: 254
		internal sealed class BinderState
		{
			// Token: 0x06001039 RID: 4153 RVA: 0x0002E550 File Offset: 0x0002C750
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray)
			{
				this._argsMap = argsMap;
				this._originalSize = originalSize;
				this._isParamArray = isParamArray;
			}

			// Token: 0x04000391 RID: 913
			internal readonly int[] _argsMap;

			// Token: 0x04000392 RID: 914
			internal readonly int _originalSize;

			// Token: 0x04000393 RID: 915
			internal readonly bool _isParamArray;
		}
	}
}

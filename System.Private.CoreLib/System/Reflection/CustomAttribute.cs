using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006EF RID: 1775
	internal static class CustomAttribute
	{
		// Token: 0x060075B0 RID: 30128 RVA: 0x00117F80 File Offset: 0x00116180
		private static bool IsUserCattrProvider(object obj)
		{
			Type type = obj as Type;
			if (type is RuntimeType || (RuntimeFeature.IsDynamicCodeSupported && type != null && type.IsTypeBuilder()))
			{
				return false;
			}
			if (obj is Type)
			{
				return true;
			}
			if (CustomAttribute.corlib == null)
			{
				CustomAttribute.corlib = typeof(int).Assembly;
			}
			return obj.GetType().Assembly != CustomAttribute.corlib;
		}

		// Token: 0x060075B1 RID: 30129
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs);

		// Token: 0x060075B2 RID: 30130 RVA: 0x00117FEC File Offset: 0x001161EC
		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			object[] array = null;
			RuntimeMethodInfo runtimeMethodInfo = obj as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				array = runtimeMethodInfo.GetPseudoCustomAttributes();
			}
			else
			{
				RuntimeFieldInfo runtimeFieldInfo = obj as RuntimeFieldInfo;
				if (runtimeFieldInfo != null)
				{
					array = runtimeFieldInfo.GetPseudoCustomAttributes();
				}
				else
				{
					RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
					if (runtimeParameterInfo != null)
					{
						array = runtimeParameterInfo.GetPseudoCustomAttributes();
					}
					else
					{
						Type type = obj as Type;
						if (type != null)
						{
							array = CustomAttribute.GetPseudoCustomAttributes(type);
						}
					}
				}
			}
			if (attributeType != null && array != null)
			{
				int i = 0;
				while (i < array.Length)
				{
					if (attributeType.IsAssignableFrom(array[i].GetType()))
					{
						if (array.Length == 1)
						{
							return array;
						}
						return new object[]
						{
							array[i]
						};
					}
					else
					{
						i++;
					}
				}
				return Array.Empty<object>();
			}
			return array;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00118094 File Offset: 0x00116294
		private static object[] GetPseudoCustomAttributes(Type type)
		{
			int num = 0;
			TypeAttributes attributes = type.Attributes;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				array[num++] = new SerializableAttribute();
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				array[num++] = new ComImportAttribute();
			}
			return array;
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00118100 File Offset: 0x00116300
		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			object[] array = CustomAttribute.GetCustomAttributesInternal(obj, attributeType, false);
			object[] array2 = array;
			if (!inheritedOnly)
			{
				object[] pseudoCustomAttributes = CustomAttribute.GetPseudoCustomAttributes(obj, attributeType);
				if (pseudoCustomAttributes != null)
				{
					array = new Attribute[array2.Length + pseudoCustomAttributes.Length];
					object[] array3 = array;
					Array.Copy(array2, array3, array2.Length);
					Array.Copy(pseudoCustomAttributes, 0, array3, array2.Length, pseudoCustomAttributes.Length);
					return array3;
				}
			}
			return array2;
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00118150 File Offset: 0x00116350
		private static bool AttrTypeMatches(Type attributeType, Type attrType)
		{
			return attributeType == null || attributeType.IsAssignableFrom(attrType) || (attributeType.IsGenericTypeDefinition && attrType.IsGenericType && attributeType.IsAssignableFrom(attrType.GetGenericTypeDefinition()));
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00118188 File Offset: 0x00116388
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && !attributeType.IsInterface && attributeType != typeof(Attribute) && attributeType != typeof(CustomAttribute) && attributeType != typeof(object))
			{
				throw new ArgumentException(SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);
			}
			if (CustomAttribute.IsUserCattrProvider(obj))
			{
				return obj.GetCustomAttributes(attributeType, inherit);
			}
			if (attributeType == typeof(CustomAttribute))
			{
				attributeType = null;
			}
			if (attributeType == typeof(Attribute))
			{
				attributeType = null;
			}
			if (attributeType == typeof(object))
			{
				attributeType = null;
			}
			object[] customAttributesBase = CustomAttribute.GetCustomAttributesBase(obj, attributeType, false);
			if (!inherit && customAttributesBase.Length == 1)
			{
				if (customAttributesBase[0] == null)
				{
					throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
				}
				object[] array;
				if (attributeType != null && !attributeType.IsGenericTypeDefinition)
				{
					if (attributeType.IsAssignableFrom(customAttributesBase[0].GetType()))
					{
						array = (object[])Array.CreateInstance(attributeType, 1);
						array[0] = customAttributesBase[0];
					}
					else
					{
						array = (object[])Array.CreateInstance(attributeType, 0);
					}
				}
				else
				{
					array = (object[])Array.CreateInstance(customAttributesBase[0].GetType(), 1);
					array[0] = customAttributesBase[0];
				}
				return array;
			}
			else
			{
				if (inherit && CustomAttribute.GetBase(obj) == null)
				{
					inherit = false;
				}
				if (attributeType != null && attributeType.IsSealed && inherit && !CustomAttribute.RetrieveAttributeUsage(attributeType).Inherited)
				{
					inherit = false;
				}
				int capacity = Math.Max(customAttributesBase.Length, 16);
				ICustomAttributeProvider customAttributeProvider = obj;
				List<object> list;
				object[] array3;
				if (inherit)
				{
					Dictionary<Type, CustomAttribute.AttributeInfo> dictionary = new Dictionary<Type, CustomAttribute.AttributeInfo>(capacity);
					int num = 0;
					list = new List<object>(capacity);
					for (;;)
					{
						foreach (object obj2 in customAttributesBase)
						{
							if (obj2 == null)
							{
								goto Block_30;
							}
							Type type = obj2.GetType();
							if (CustomAttribute.AttrTypeMatches(attributeType, obj2.GetType()))
							{
								CustomAttribute.AttributeInfo attributeInfo;
								AttributeUsageAttribute attributeUsageAttribute;
								if (dictionary.TryGetValue(type, out attributeInfo))
								{
									attributeUsageAttribute = attributeInfo.Usage;
								}
								else
								{
									attributeUsageAttribute = CustomAttribute.RetrieveAttributeUsage(type);
								}
								if ((num == 0 || attributeUsageAttribute.Inherited) && (attributeUsageAttribute.AllowMultiple || attributeInfo == null || (attributeInfo != null && attributeInfo.InheritanceLevel == num)))
								{
									list.Add(obj2);
								}
								if (attributeInfo == null)
								{
									dictionary.Add(type, new CustomAttribute.AttributeInfo(attributeUsageAttribute, num));
								}
							}
						}
						if ((customAttributeProvider = CustomAttribute.GetBase(customAttributeProvider)) != null)
						{
							num++;
							customAttributesBase = CustomAttribute.GetCustomAttributesBase(customAttributeProvider, attributeType, true);
						}
						if (customAttributeProvider == null)
						{
							goto Block_40;
						}
					}
					Block_30:
					throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
					Block_40:
					if (attributeType == null || attributeType.IsValueType || attributeType.IsGenericTypeDefinition)
					{
						object[] array2 = new Attribute[list.Count];
						array3 = array2;
					}
					else
					{
						array3 = (Array.CreateInstance(attributeType, list.Count) as object[]);
					}
					list.CopyTo(array3, 0);
					return array3;
				}
				if (attributeType == null)
				{
					object[] array2 = customAttributesBase;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i] == null)
						{
							throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
						}
					}
					Attribute[] array4 = new Attribute[customAttributesBase.Length];
					customAttributesBase.CopyTo(array4, 0);
					return array4;
				}
				list = new List<object>(capacity);
				foreach (object obj3 in customAttributesBase)
				{
					if (obj3 == null)
					{
						throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
					}
					if (CustomAttribute.AttrTypeMatches(attributeType, obj3.GetType()))
					{
						list.Add(obj3);
					}
				}
				if (attributeType == null || attributeType.IsValueType || attributeType.IsGenericTypeDefinition)
				{
					object[] array2 = new Attribute[list.Count];
					array3 = array2;
				}
				else
				{
					array3 = (Array.CreateInstance(attributeType, list.Count) as object[]);
				}
				list.CopyTo(array3, 0);
				return array3;
			}
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00118544 File Offset: 0x00116744
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			if (CustomAttribute.IsUserCattrProvider(obj))
			{
				return obj.GetCustomAttributes(typeof(Attribute), inherit);
			}
			if (!inherit)
			{
				return (object[])CustomAttribute.GetCustomAttributesBase(obj, null, false).Clone();
			}
			return CustomAttribute.GetCustomAttributes(obj, typeof(CustomAttribute), inherit);
		}

		// Token: 0x060075B8 RID: 30136
		[DynamicDependency("#ctor(System.Reflection.ConstructorInfo,System.Reflection.Assembly,System.IntPtr,System.UInt32)", typeof(RuntimeCustomAttributeData))]
		[DynamicDependency("#ctor(System.Reflection.MemberInfo,System.Object)", typeof(CustomAttributeNamedArgument))]
		[DynamicDependency("#ctor(System.Type,System.Object)", typeof(CustomAttributeTypedArgument))]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj);

		// Token: 0x060075B9 RID: 30137 RVA: 0x0011859D File Offset: 0x0011679D
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			if (!inherit)
			{
				return CustomAttribute.GetCustomAttributesDataBase(obj, null, false);
			}
			return CustomAttribute.GetCustomAttributesData(obj, typeof(CustomAttribute), inherit);
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x001185C8 File Offset: 0x001167C8
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			if (attributeType == typeof(CustomAttribute))
			{
				attributeType = null;
			}
			IList<CustomAttributeData> customAttributesDataBase = CustomAttribute.GetCustomAttributesDataBase(obj, attributeType, false);
			if (!inherit && customAttributesDataBase.Count == 1)
			{
				if (customAttributesDataBase[0] == null)
				{
					throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
				}
				IList<CustomAttributeData> result;
				if (attributeType != null)
				{
					if (attributeType.IsAssignableFrom(customAttributesDataBase[0].AttributeType))
					{
						result = new CustomAttributeData[]
						{
							customAttributesDataBase[0]
						};
					}
					else
					{
						result = Array.Empty<CustomAttributeData>();
					}
				}
				else
				{
					result = new CustomAttributeData[]
					{
						customAttributesDataBase[0]
					};
				}
				return result;
			}
			else
			{
				if (inherit && CustomAttribute.GetBase(obj) == null)
				{
					inherit = false;
				}
				if (attributeType != null && attributeType.IsSealed && inherit && !CustomAttribute.RetrieveAttributeUsage(attributeType).Inherited)
				{
					inherit = false;
				}
				int capacity = Math.Max(customAttributesDataBase.Count, 16);
				ICustomAttributeProvider customAttributeProvider = obj;
				List<CustomAttributeData> list;
				if (inherit)
				{
					Dictionary<Type, CustomAttribute.AttributeInfo> dictionary = new Dictionary<Type, CustomAttribute.AttributeInfo>(capacity);
					int num = 0;
					list = new List<CustomAttributeData>(capacity);
					do
					{
						foreach (CustomAttributeData customAttributeData in customAttributesDataBase)
						{
							if (customAttributeData == null)
							{
								throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
							}
							Type attributeType2 = customAttributeData.AttributeType;
							if (!(attributeType != null) || attributeType.IsAssignableFrom(attributeType2))
							{
								CustomAttribute.AttributeInfo attributeInfo;
								AttributeUsageAttribute attributeUsageAttribute;
								if (dictionary.TryGetValue(attributeType2, out attributeInfo))
								{
									attributeUsageAttribute = attributeInfo.Usage;
								}
								else
								{
									attributeUsageAttribute = CustomAttribute.RetrieveAttributeUsage(attributeType2);
								}
								if ((num == 0 || attributeUsageAttribute.Inherited) && (attributeUsageAttribute.AllowMultiple || attributeInfo == null || (attributeInfo != null && attributeInfo.InheritanceLevel == num)))
								{
									list.Add(customAttributeData);
								}
								if (attributeInfo == null)
								{
									dictionary.Add(attributeType2, new CustomAttribute.AttributeInfo(attributeUsageAttribute, num));
								}
							}
						}
						if ((customAttributeProvider = CustomAttribute.GetBase(customAttributeProvider)) != null)
						{
							num++;
							customAttributesDataBase = CustomAttribute.GetCustomAttributesDataBase(customAttributeProvider, attributeType, true);
						}
					}
					while (customAttributeProvider != null);
					return list.ToArray();
				}
				if (attributeType == null)
				{
					using (IEnumerator<CustomAttributeData> enumerator = customAttributesDataBase.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == null)
							{
								throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
							}
						}
					}
					CustomAttributeData[] array = new CustomAttributeData[customAttributesDataBase.Count];
					customAttributesDataBase.CopyTo(array, 0);
					return array;
				}
				list = new List<CustomAttributeData>(capacity);
				foreach (CustomAttributeData customAttributeData2 in customAttributesDataBase)
				{
					if (customAttributeData2 == null)
					{
						throw new CustomAttributeFormatException(SR.Arg_CustomAttributeFormatException);
					}
					if (attributeType.IsAssignableFrom(customAttributeData2.AttributeType))
					{
						list.Add(customAttributeData2);
					}
				}
				return list.ToArray();
			}
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x0011889C File Offset: 0x00116A9C
		internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			CustomAttributeData[] array;
			if (CustomAttribute.IsUserCattrProvider(obj))
			{
				array = Array.Empty<CustomAttributeData>();
			}
			else
			{
				array = CustomAttribute.GetCustomAttributesDataInternal(obj);
			}
			if (!inheritedOnly)
			{
				CustomAttributeData[] pseudoCustomAttributesData = CustomAttribute.GetPseudoCustomAttributesData(obj, attributeType);
				if (pseudoCustomAttributesData != null)
				{
					if (array.Length == 0)
					{
						return Array.AsReadOnly<CustomAttributeData>(pseudoCustomAttributesData);
					}
					CustomAttributeData[] array2 = new CustomAttributeData[array.Length + pseudoCustomAttributesData.Length];
					Array.Copy(array, array2, array.Length);
					Array.Copy(pseudoCustomAttributesData, 0, array2, array.Length, pseudoCustomAttributesData.Length);
					return Array.AsReadOnly<CustomAttributeData>(array2);
				}
			}
			return Array.AsReadOnly<CustomAttributeData>(array);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x0011890C File Offset: 0x00116B0C
		internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
		{
			CustomAttributeData[] array = null;
			RuntimeMethodInfo runtimeMethodInfo = obj as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				array = runtimeMethodInfo.GetPseudoCustomAttributesData();
			}
			else
			{
				RuntimeFieldInfo runtimeFieldInfo = obj as RuntimeFieldInfo;
				if (runtimeFieldInfo != null)
				{
					array = runtimeFieldInfo.GetPseudoCustomAttributesData();
				}
				else
				{
					RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
					if (runtimeParameterInfo != null)
					{
						array = runtimeParameterInfo.GetPseudoCustomAttributesData();
					}
					else
					{
						Type type = obj as Type;
						if (type != null)
						{
							array = CustomAttribute.GetPseudoCustomAttributesData(type);
						}
					}
				}
			}
			if (attributeType != null && array != null)
			{
				int i = 0;
				while (i < array.Length)
				{
					if (attributeType.IsAssignableFrom(array[i].AttributeType))
					{
						if (array.Length == 1)
						{
							return array;
						}
						return new CustomAttributeData[]
						{
							array[i]
						};
					}
					else
					{
						i++;
					}
				}
				return Array.Empty<CustomAttributeData>();
			}
			return array;
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x001189B4 File Offset: 0x00116BB4
		private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type)
		{
			int num = 0;
			TypeAttributes attributes = type.Attributes;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(SerializableAttribute).GetConstructor(Type.EmptyTypes));
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				array[num++] = new RuntimeCustomAttributeData(typeof(ComImportAttribute).GetConstructor(Type.EmptyTypes));
			}
			return array;
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00118A48 File Offset: 0x00116C48
		internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && !attributeType.IsInterface && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(SR.Argument_MustHaveAttributeBaseClass + " " + attributeType.FullName);
			}
			AttributeUsageAttribute attributeUsageAttribute = null;
			while (!CustomAttribute.IsUserCattrProvider(obj))
			{
				if (CustomAttribute.IsDefinedInternal(obj, attributeType))
				{
					return true;
				}
				object[] pseudoCustomAttributes = CustomAttribute.GetPseudoCustomAttributes(obj, attributeType);
				if (pseudoCustomAttributes != null)
				{
					for (int i = 0; i < pseudoCustomAttributes.Length; i++)
					{
						if (attributeType.IsAssignableFrom(pseudoCustomAttributes[i].GetType()))
						{
							return true;
						}
					}
				}
				if (attributeUsageAttribute == null)
				{
					if (!inherit)
					{
						return false;
					}
					attributeUsageAttribute = CustomAttribute.RetrieveAttributeUsage(attributeType);
					if (!attributeUsageAttribute.Inherited)
					{
						return false;
					}
				}
				obj = CustomAttribute.GetBase(obj);
				if (obj == null)
				{
					return false;
				}
			}
			return obj.IsDefined(attributeType, inherit);
		}

		// Token: 0x060075BF RID: 30143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType);

		// Token: 0x060075C0 RID: 30144 RVA: 0x00118B18 File Offset: 0x00116D18
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Linker analyzes base properties and marks them")]
		private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
		{
			MethodInfo methodInfo = property.GetGetMethod(true);
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = property.GetSetMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (!(baseMethod != null) || !(baseMethod != methodInfo))
			{
				return null;
			}
			ParameterInfo[] indexParameters = property.GetIndexParameters();
			if (indexParameters != null && indexParameters.Length != 0)
			{
				Type[] array = new Type[indexParameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = indexParameters[i].ParameterType;
				}
				return baseMethod.DeclaringType.GetProperty(property.Name, property.PropertyType, array);
			}
			return baseMethod.DeclaringType.GetProperty(property.Name, property.PropertyType);
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00118BE0 File Offset: 0x00116DE0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Linker analyzes base events and marks them")]
		private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
		{
			MethodInfo methodInfo = evt.GetAddMethod(true);
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = evt.GetRaiseMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = evt.GetRemoveMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (baseMethod != null && baseMethod != methodInfo)
			{
				BindingFlags bindingFlags = methodInfo.IsPublic ? BindingFlags.Public : BindingFlags.NonPublic;
				bindingFlags |= (methodInfo.IsStatic ? BindingFlags.Static : BindingFlags.Instance);
				return baseMethod.DeclaringType.GetEvent(evt.Name, bindingFlags);
			}
			return null;
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00118C8C File Offset: 0x00116E8C
		private unsafe static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is Type)
			{
				return ((Type)obj).BaseType;
			}
			MethodInfo methodInfo = null;
			if (obj is RuntimePropertyInfo)
			{
				return CustomAttribute.GetBasePropertyDefinition((RuntimePropertyInfo)obj);
			}
			if (obj is RuntimeEventInfo)
			{
				return CustomAttribute.GetBaseEventDefinition((RuntimeEventInfo)obj);
			}
			if (obj is RuntimeMethodInfo)
			{
				methodInfo = (MethodInfo)obj;
			}
			RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
			if (runtimeParameterInfo != null)
			{
				MemberInfo member = runtimeParameterInfo.Member;
				if (member is MethodInfo)
				{
					methodInfo = (MethodInfo)member;
					MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
					if (baseMethod == methodInfo)
					{
						return null;
					}
					int position = runtimeParameterInfo.Position;
					if (position == -1)
					{
						return baseMethod.ReturnParameter;
					}
					return *baseMethod.GetParametersAsSpan()[position];
				}
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod2 = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (baseMethod2 == methodInfo)
			{
				return null;
			}
			return baseMethod2;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00118D78 File Offset: 0x00116F78
		private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			if (attributeType == typeof(AttributeUsageAttribute))
			{
				return new AttributeUsageAttribute(AttributeTargets.Class);
			}
			AttributeUsageAttribute attributeUsageAttribute = null;
			object[] customAttributes = CustomAttribute.GetCustomAttributes(attributeType, typeof(AttributeUsageAttribute), false);
			if (customAttributes.Length == 0)
			{
				if (attributeType.BaseType != null)
				{
					attributeUsageAttribute = CustomAttribute.RetrieveAttributeUsage(attributeType.BaseType);
				}
				if (attributeUsageAttribute != null)
				{
					return attributeUsageAttribute;
				}
				return CustomAttribute.DefaultAttributeUsage;
			}
			else
			{
				if (customAttributes.Length > 1)
				{
					throw new FormatException(SR.Format(SR.Format_AttributeUsage, attributeType.GetType().FullName));
				}
				return (AttributeUsageAttribute)customAttributes[0];
			}
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00118E04 File Offset: 0x00117004
		private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			if (CustomAttribute.usage_cache == null)
			{
				CustomAttribute.usage_cache = new Dictionary<Type, AttributeUsageAttribute>();
			}
			AttributeUsageAttribute attributeUsageAttribute;
			if (CustomAttribute.usage_cache.TryGetValue(attributeType, out attributeUsageAttribute))
			{
				return attributeUsageAttribute;
			}
			attributeUsageAttribute = CustomAttribute.RetrieveAttributeUsageNoCache(attributeType);
			CustomAttribute.usage_cache[attributeType] = attributeUsageAttribute;
			return attributeUsageAttribute;
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00118E48 File Offset: 0x00117048
		internal static object[] CreateAttributeArrayHelper(RuntimeType caType, int elementCount)
		{
			bool flag = false;
			bool flag2 = false;
			if (caType == typeof(Attribute))
			{
				flag = true;
			}
			else if (caType.IsValueType)
			{
				flag2 = true;
			}
			else if (caType.ContainsGenericParameters)
			{
				if (caType.IsSubclassOf(typeof(Attribute)))
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
			if (flag)
			{
				return (elementCount == 0) ? Array.Empty<Attribute>() : new Attribute[elementCount];
			}
			if (!flag2)
			{
				return (object[])Array.CreateInstance(caType, elementCount);
			}
			if (elementCount != 0)
			{
				return new object[elementCount];
			}
			return Array.Empty<object>();
		}

		// Token: 0x04001531 RID: 5425
		private static Assembly corlib;

		// Token: 0x04001532 RID: 5426
		[ThreadStatic]
		private static Dictionary<Type, AttributeUsageAttribute> usage_cache;

		// Token: 0x04001533 RID: 5427
		private static readonly AttributeUsageAttribute DefaultAttributeUsage = new AttributeUsageAttribute(AttributeTargets.All);

		// Token: 0x020006F0 RID: 1776
		private sealed class AttributeInfo
		{
			// Token: 0x060075C7 RID: 30151 RVA: 0x00118EE1 File Offset: 0x001170E1
			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
			{
				this._usage = usage;
				this._inheritanceLevel = inheritanceLevel;
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x060075C8 RID: 30152 RVA: 0x00118EF7 File Offset: 0x001170F7
			public AttributeUsageAttribute Usage
			{
				get
				{
					return this._usage;
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x060075C9 RID: 30153 RVA: 0x00118EFF File Offset: 0x001170FF
			public int InheritanceLevel
			{
				get
				{
					return this._inheritanceLevel;
				}
			}

			// Token: 0x04001534 RID: 5428
			private readonly AttributeUsageAttribute _usage;

			// Token: 0x04001535 RID: 5429
			private readonly int _inheritanceLevel;
		}
	}
}

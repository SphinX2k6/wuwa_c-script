using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000765 RID: 1893
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class NullabilityInfoContext
	{
		// Token: 0x060079AE RID: 31150 RVA: 0x0012066C File Offset: 0x0011E86C
		private NullabilityState? GetNullableContext(MemberInfo memberInfo)
		{
			while (memberInfo != null)
			{
				NullabilityState value;
				if (this._context.TryGetValue(memberInfo, out value))
				{
					return new NullabilityState?(value);
				}
				foreach (CustomAttributeData customAttributeData in memberInfo.GetCustomAttributesData())
				{
					if (customAttributeData.AttributeType.Name == "NullableContextAttribute" && customAttributeData.AttributeType.Namespace == "System.Runtime.CompilerServices" && customAttributeData.ConstructorArguments.Count == 1)
					{
						value = NullabilityInfoContext.TranslateByte(customAttributeData.ConstructorArguments[0].Value);
						this._context.Add(memberInfo, value);
						return new NullabilityState?(value);
					}
				}
				memberInfo = memberInfo.DeclaringType;
			}
			return null;
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x0012075C File Offset: 0x0011E95C
		public NullabilityInfo Create(ParameterInfo parameterInfo)
		{
			ArgumentNullException.ThrowIfNull(parameterInfo, "parameterInfo");
			IList<CustomAttributeData> customAttributesData = parameterInfo.GetCustomAttributesData();
			MethodBase methodBase = parameterInfo.Member as MethodBase;
			NullabilityInfoContext.NullableAttributeStateParser parser = (methodBase != null && this.IsPrivateOrInternalMethodAndAnnotationDisabled(methodBase)) ? NullabilityInfoContext.NullableAttributeStateParser.Unknown : NullabilityInfoContext.CreateParser(customAttributesData);
			NullabilityInfo nullabilityInfo = this.GetNullabilityInfo(parameterInfo.Member, parameterInfo.ParameterType, parser);
			if (nullabilityInfo.ReadState != NullabilityState.Unknown)
			{
				this.CheckParameterMetadataType(parameterInfo, nullabilityInfo);
			}
			NullabilityInfoContext.CheckNullabilityAttributes(nullabilityInfo, customAttributesData);
			return nullabilityInfo;
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x001207D0 File Offset: 0x0011E9D0
		private void CheckParameterMetadataType(ParameterInfo parameter, NullabilityInfo nullability)
		{
			MemberInfo member = parameter.Member;
			ConstructorInfo constructorInfo = member as ConstructorInfo;
			MemberInfo metaMember;
			ParameterInfo parameterInfo;
			if (constructorInfo == null)
			{
				MethodInfo methodInfo = member as MethodInfo;
				if (methodInfo == null)
				{
					return;
				}
				MethodInfo methodMetadataDefinition = NullabilityInfoContext.GetMethodMetadataDefinition(methodInfo);
				metaMember = methodMetadataDefinition;
				parameterInfo = (string.IsNullOrEmpty(parameter.Name) ? methodMetadataDefinition.ReturnParameter : NullabilityInfoContext.GetMetaParameter(methodMetadataDefinition, parameter));
			}
			else
			{
				parameterInfo = NullabilityInfoContext.GetMetaParameter(metaMember = (ConstructorInfo)NullabilityInfoContext.GetMemberMetadataDefinition(constructorInfo), parameter);
			}
			if (parameterInfo != null)
			{
				this.CheckGenericParameters(nullability, metaMember, parameterInfo.ParameterType, parameter.Member.ReflectedType);
			}
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x00120858 File Offset: 0x0011EA58
		private unsafe static ParameterInfo GetMetaParameter(MethodBase metaMethod, ParameterInfo parameter)
		{
			ReadOnlySpan<ParameterInfo> parametersAsSpan = metaMethod.GetParametersAsSpan();
			for (int i = 0; i < parametersAsSpan.Length; i++)
			{
				if (parameter.Position == i && parameter.Name == parametersAsSpan[i]->Name)
				{
					return *parametersAsSpan[i];
				}
			}
			return null;
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x001208AD File Offset: 0x0011EAAD
		private static MethodInfo GetMethodMetadataDefinition(MethodInfo method)
		{
			if (method.IsGenericMethod && !method.IsGenericMethodDefinition)
			{
				method = method.GetGenericMethodDefinition();
			}
			return (MethodInfo)NullabilityInfoContext.GetMemberMetadataDefinition(method);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x001208D4 File Offset: 0x0011EAD4
		private static void CheckNullabilityAttributes(NullabilityInfo nullability, IList<CustomAttributeData> attributes)
		{
			NullabilityState nullabilityState = NullabilityState.Unknown;
			NullabilityState nullabilityState2 = NullabilityState.Unknown;
			foreach (CustomAttributeData customAttributeData in attributes)
			{
				if (customAttributeData.AttributeType.Namespace == "System.Diagnostics.CodeAnalysis")
				{
					if (customAttributeData.AttributeType.Name == "NotNullAttribute")
					{
						nullabilityState = NullabilityState.NotNull;
					}
					else if ((customAttributeData.AttributeType.Name == "MaybeNullAttribute" || customAttributeData.AttributeType.Name == "MaybeNullWhenAttribute") && nullabilityState == NullabilityState.Unknown && !NullabilityInfoContext.IsValueTypeOrValueTypeByRef(nullability.Type))
					{
						nullabilityState = NullabilityState.Nullable;
					}
					else if (customAttributeData.AttributeType.Name == "DisallowNullAttribute")
					{
						nullabilityState2 = NullabilityState.NotNull;
					}
					else if (customAttributeData.AttributeType.Name == "AllowNullAttribute" && nullabilityState2 == NullabilityState.Unknown && !NullabilityInfoContext.IsValueTypeOrValueTypeByRef(nullability.Type))
					{
						nullabilityState2 = NullabilityState.Nullable;
					}
				}
			}
			if (nullabilityState != NullabilityState.Unknown)
			{
				nullability.ReadState = nullabilityState;
			}
			if (nullabilityState2 != NullabilityState.Unknown)
			{
				nullability.WriteState = nullabilityState2;
			}
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x001209F4 File Offset: 0x0011EBF4
		public unsafe NullabilityInfo Create(PropertyInfo propertyInfo)
		{
			ArgumentNullException.ThrowIfNull(propertyInfo, "propertyInfo");
			MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			NullabilityInfoContext.NullableAttributeStateParser parser = ((getMethod == null || this.IsPrivateOrInternalMethodAndAnnotationDisabled(getMethod)) && (setMethod == null || this.IsPrivateOrInternalMethodAndAnnotationDisabled(setMethod))) ? NullabilityInfoContext.NullableAttributeStateParser.Unknown : NullabilityInfoContext.CreateParser(propertyInfo.GetCustomAttributesData());
			NullabilityInfo nullabilityInfo = this.GetNullabilityInfo(propertyInfo, propertyInfo.PropertyType, parser);
			if (getMethod != null)
			{
				NullabilityInfoContext.CheckNullabilityAttributes(nullabilityInfo, getMethod.ReturnParameter.GetCustomAttributesData());
			}
			else
			{
				nullabilityInfo.ReadState = NullabilityState.Unknown;
			}
			if (setMethod != null)
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = setMethod.GetParametersAsSpan();
				ParameterInfo parameterInfo = *parametersAsSpan[parametersAsSpan.Length - 1];
				NullabilityInfoContext.CheckNullabilityAttributes(nullabilityInfo, parameterInfo.GetCustomAttributesData());
			}
			else
			{
				nullabilityInfo.WriteState = NullabilityState.Unknown;
			}
			return nullabilityInfo;
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00120AC6 File Offset: 0x0011ECC6
		private bool IsPrivateOrInternalMethodAndAnnotationDisabled(MethodBase method)
		{
			return (method.IsPrivate || method.IsFamilyAndAssembly || method.IsAssembly) && this.IsPublicOnly(method.IsPrivate, method.IsFamilyAndAssembly, method.IsAssembly, method.Module);
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00120B03 File Offset: 0x0011ED03
		public NullabilityInfo Create(EventInfo eventInfo)
		{
			ArgumentNullException.ThrowIfNull(eventInfo, "eventInfo");
			return this.GetNullabilityInfo(eventInfo, eventInfo.EventHandlerType, NullabilityInfoContext.CreateParser(eventInfo.GetCustomAttributesData()));
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00120B28 File Offset: 0x0011ED28
		public NullabilityInfo Create(FieldInfo fieldInfo)
		{
			ArgumentNullException.ThrowIfNull(fieldInfo, "fieldInfo");
			IList<CustomAttributeData> customAttributesData = fieldInfo.GetCustomAttributesData();
			NullabilityInfoContext.NullableAttributeStateParser parser = this.IsPrivateOrInternalFieldAndAnnotationDisabled(fieldInfo) ? NullabilityInfoContext.NullableAttributeStateParser.Unknown : NullabilityInfoContext.CreateParser(customAttributesData);
			NullabilityInfo nullabilityInfo = this.GetNullabilityInfo(fieldInfo, fieldInfo.FieldType, parser);
			NullabilityInfoContext.CheckNullabilityAttributes(nullabilityInfo, customAttributesData);
			return nullabilityInfo;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00120B73 File Offset: 0x0011ED73
		private bool IsPrivateOrInternalFieldAndAnnotationDisabled(FieldInfo fieldInfo)
		{
			return (fieldInfo.IsPrivate || fieldInfo.IsFamilyAndAssembly || fieldInfo.IsAssembly) && this.IsPublicOnly(fieldInfo.IsPrivate, fieldInfo.IsFamilyAndAssembly, fieldInfo.IsAssembly, fieldInfo.Module);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00120BB0 File Offset: 0x0011EDB0
		private bool IsPublicOnly(bool isPrivate, bool isFamilyAndAssembly, bool isAssembly, Module module)
		{
			NullabilityInfoContext.NotAnnotatedStatus notAnnotatedStatus;
			if (!this._publicOnlyModules.TryGetValue(module, out notAnnotatedStatus))
			{
				notAnnotatedStatus = NullabilityInfoContext.PopulateAnnotationInfo(module.GetCustomAttributesData());
				this._publicOnlyModules.Add(module, notAnnotatedStatus);
			}
			return notAnnotatedStatus != NullabilityInfoContext.NotAnnotatedStatus.None && (((isPrivate || isFamilyAndAssembly) && notAnnotatedStatus.HasFlag(NullabilityInfoContext.NotAnnotatedStatus.Private)) || (isAssembly && notAnnotatedStatus.HasFlag(NullabilityInfoContext.NotAnnotatedStatus.Internal)));
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00120C20 File Offset: 0x0011EE20
		private static NullabilityInfoContext.NotAnnotatedStatus PopulateAnnotationInfo(IList<CustomAttributeData> customAttributes)
		{
			foreach (CustomAttributeData customAttributeData in customAttributes)
			{
				if (customAttributeData.AttributeType.Name == "NullablePublicOnlyAttribute" && customAttributeData.AttributeType.Namespace == "System.Runtime.CompilerServices" && customAttributeData.ConstructorArguments.Count == 1)
				{
					object value = customAttributeData.ConstructorArguments[0].Value;
					bool flag;
					bool flag2;
					if (value is bool)
					{
						flag = (bool)value;
						flag2 = true;
					}
					else
					{
						flag2 = false;
					}
					if (flag2 && flag)
					{
						return NullabilityInfoContext.NotAnnotatedStatus.Private | NullabilityInfoContext.NotAnnotatedStatus.Internal;
					}
					return NullabilityInfoContext.NotAnnotatedStatus.Private;
				}
			}
			return NullabilityInfoContext.NotAnnotatedStatus.None;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00120CDC File Offset: 0x0011EEDC
		private NullabilityInfo GetNullabilityInfo(MemberInfo memberInfo, Type type, NullabilityInfoContext.NullableAttributeStateParser parser)
		{
			int num = 0;
			NullabilityInfo nullabilityInfo = this.GetNullabilityInfo(memberInfo, type, parser, ref num);
			if (nullabilityInfo.ReadState != NullabilityState.Unknown)
			{
				this.TryLoadGenericMetaTypeNullability(memberInfo, nullabilityInfo);
			}
			return nullabilityInfo;
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00120D08 File Offset: 0x0011EF08
		private NullabilityInfo GetNullabilityInfo(MemberInfo memberInfo, Type type, NullabilityInfoContext.NullableAttributeStateParser parser, ref int index)
		{
			NullabilityState nullabilityState = NullabilityState.Unknown;
			NullabilityInfo elementType = null;
			NullabilityInfo[] array = Array.Empty<NullabilityInfo>();
			Type type2 = type;
			if (type2.IsByRef || type2.IsPointer)
			{
				type2 = type2.GetElementType();
			}
			if (type2.IsValueType)
			{
				Type underlyingType = Nullable.GetUnderlyingType(type2);
				if (underlyingType != null)
				{
					type2 = underlyingType;
					nullabilityState = NullabilityState.Nullable;
				}
				else
				{
					nullabilityState = NullabilityState.NotNull;
				}
				if (type2.IsGenericType)
				{
					index++;
				}
			}
			else
			{
				int num = index;
				index = num + 1;
				if (!parser.ParseNullableState(num, ref nullabilityState))
				{
					NullabilityState? nullableContext = this.GetNullableContext(memberInfo);
					if (nullableContext != null)
					{
						NullabilityState valueOrDefault = nullableContext.GetValueOrDefault();
						nullabilityState = valueOrDefault;
					}
				}
				if (type2.IsArray)
				{
					elementType = this.GetNullabilityInfo(memberInfo, type2.GetElementType(), parser, ref index);
				}
			}
			if (type2.IsGenericType)
			{
				Type[] genericArguments = type2.GetGenericArguments();
				array = new NullabilityInfo[genericArguments.Length];
				for (int i = 0; i < genericArguments.Length; i++)
				{
					array[i] = this.GetNullabilityInfo(memberInfo, genericArguments[i], parser, ref index);
				}
			}
			return new NullabilityInfo(type, nullabilityState, nullabilityState, elementType, array);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00120E04 File Offset: 0x0011F004
		private static NullabilityInfoContext.NullableAttributeStateParser CreateParser(IList<CustomAttributeData> customAttributes)
		{
			foreach (CustomAttributeData customAttributeData in customAttributes)
			{
				if (customAttributeData.AttributeType.Name == "NullableAttribute" && customAttributeData.AttributeType.Namespace == "System.Runtime.CompilerServices" && customAttributeData.ConstructorArguments.Count == 1)
				{
					return new NullabilityInfoContext.NullableAttributeStateParser(customAttributeData.ConstructorArguments[0].Value);
				}
			}
			return new NullabilityInfoContext.NullableAttributeStateParser(null);
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x00120EA8 File Offset: 0x0011F0A8
		private void TryLoadGenericMetaTypeNullability(MemberInfo memberInfo, NullabilityInfo nullability)
		{
			MemberInfo memberMetadataDefinition = NullabilityInfoContext.GetMemberMetadataDefinition(memberInfo);
			Type type = null;
			FieldInfo fieldInfo = memberMetadataDefinition as FieldInfo;
			if (fieldInfo != null)
			{
				type = fieldInfo.FieldType;
			}
			else
			{
				PropertyInfo propertyInfo = memberMetadataDefinition as PropertyInfo;
				if (propertyInfo != null)
				{
					type = NullabilityInfoContext.GetPropertyMetaType(propertyInfo);
				}
			}
			if (type != null)
			{
				this.CheckGenericParameters(nullability, memberMetadataDefinition, type, memberInfo.ReflectedType);
			}
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00120EFC File Offset: 0x0011F0FC
		private static MemberInfo GetMemberMetadataDefinition(MemberInfo member)
		{
			Type declaringType = member.DeclaringType;
			if (declaringType != null && declaringType.IsGenericType && !declaringType.IsGenericTypeDefinition)
			{
				return declaringType.GetGenericTypeDefinition().GetMemberWithSameMetadataDefinitionAs(member);
			}
			return member;
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00120F38 File Offset: 0x0011F138
		private unsafe static Type GetPropertyMetaType(PropertyInfo property)
		{
			MethodInfo getMethod = property.GetGetMethod(true);
			if (getMethod != null)
			{
				return getMethod.ReturnType;
			}
			return property.GetSetMethod(true).GetParametersAsSpan()[0]->ParameterType;
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00120F74 File Offset: 0x0011F174
		private void CheckGenericParameters(NullabilityInfo nullability, MemberInfo metaMember, Type metaType, Type reflectedType)
		{
			if (metaType.IsGenericParameter)
			{
				if (nullability.ReadState == NullabilityState.NotNull)
				{
					this.TryUpdateGenericParameterNullability(nullability, metaType, reflectedType);
					return;
				}
			}
			else if (metaType.ContainsGenericParameters)
			{
				if (nullability.GenericTypeArguments.Length != 0)
				{
					Type[] genericArguments = metaType.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						this.CheckGenericParameters(nullability.GenericTypeArguments[i], metaMember, genericArguments[i], reflectedType);
					}
					return;
				}
				NullabilityInfo elementType = nullability.ElementType;
				if (elementType != null && metaType.IsArray)
				{
					this.CheckGenericParameters(elementType, metaMember, metaType.GetElementType(), reflectedType);
					return;
				}
				if (metaType.IsByRef)
				{
					this.CheckGenericParameters(nullability, metaMember, metaType.GetElementType(), reflectedType);
				}
			}
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00121018 File Offset: 0x0011F218
		private bool TryUpdateGenericParameterNullability(NullabilityInfo nullability, Type genericParameter, Type reflectedType)
		{
			if (reflectedType != null && !genericParameter.IsGenericMethodParameter && this.TryUpdateGenericTypeParameterNullabilityFromReflectedType(nullability, genericParameter, reflectedType, reflectedType))
			{
				return true;
			}
			if (NullabilityInfoContext.IsValueTypeOrValueTypeByRef(nullability.Type))
			{
				return true;
			}
			NullabilityState nullabilityState = NullabilityState.Unknown;
			if (NullabilityInfoContext.CreateParser(genericParameter.GetCustomAttributesData()).ParseNullableState(0, ref nullabilityState))
			{
				nullability.ReadState = nullabilityState;
				nullability.WriteState = nullabilityState;
				return true;
			}
			NullabilityState? nullableContext = this.GetNullableContext(genericParameter);
			if (nullableContext != null)
			{
				NullabilityState valueOrDefault = nullableContext.GetValueOrDefault();
				nullability.ReadState = valueOrDefault;
				nullability.WriteState = valueOrDefault;
				return true;
			}
			return false;
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x001210A4 File Offset: 0x0011F2A4
		private bool TryUpdateGenericTypeParameterNullabilityFromReflectedType(NullabilityInfo nullability, Type genericParameter, Type context, Type reflectedType)
		{
			Type type = (context.IsGenericType && !context.IsGenericTypeDefinition) ? context.GetGenericTypeDefinition() : context;
			if (genericParameter.DeclaringType == type)
			{
				return false;
			}
			Type baseType = type.BaseType;
			if (baseType == null)
			{
				return false;
			}
			if (!baseType.IsGenericType || (baseType.IsGenericTypeDefinition ? baseType : baseType.GetGenericTypeDefinition()) != genericParameter.DeclaringType)
			{
				return this.TryUpdateGenericTypeParameterNullabilityFromReflectedType(nullability, genericParameter, baseType, reflectedType);
			}
			Type[] genericArguments = baseType.GetGenericArguments();
			Type type2 = genericArguments[genericParameter.GenericParameterPosition];
			if (type2.IsGenericParameter)
			{
				return this.TryUpdateGenericParameterNullability(nullability, type2, reflectedType);
			}
			NullabilityInfoContext.NullableAttributeStateParser parser = NullabilityInfoContext.CreateParser(type.GetCustomAttributesData());
			int num = 1;
			for (int i = 0; i < genericParameter.GenericParameterPosition; i++)
			{
				num += NullabilityInfoContext.<TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|25_0(genericArguments[i]);
			}
			return NullabilityInfoContext.TryPopulateNullabilityInfo(nullability, parser, ref num);
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x0012117C File Offset: 0x0011F37C
		private static bool TryPopulateNullabilityInfo(NullabilityInfo nullability, NullabilityInfoContext.NullableAttributeStateParser parser, ref int index)
		{
			bool flag = NullabilityInfoContext.IsValueTypeOrValueTypeByRef(nullability.Type);
			if (!flag)
			{
				NullabilityState nullabilityState = NullabilityState.Unknown;
				if (!parser.ParseNullableState(index, ref nullabilityState))
				{
					return false;
				}
				nullability.ReadState = nullabilityState;
				nullability.WriteState = nullabilityState;
			}
			if (!flag || (Nullable.GetUnderlyingType(nullability.Type) ?? nullability.Type).IsGenericType)
			{
				index++;
			}
			if (nullability.GenericTypeArguments.Length != 0)
			{
				NullabilityInfo[] genericTypeArguments = nullability.GenericTypeArguments;
				for (int i = 0; i < genericTypeArguments.Length; i++)
				{
					NullabilityInfoContext.TryPopulateNullabilityInfo(genericTypeArguments[i], parser, ref index);
				}
			}
			else
			{
				NullabilityInfo elementType = nullability.ElementType;
				if (elementType != null)
				{
					NullabilityInfoContext.TryPopulateNullabilityInfo(elementType, parser, ref index);
				}
			}
			return true;
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x00121220 File Offset: 0x0011F420
		private static NullabilityState TranslateByte(object value)
		{
			if (value is byte)
			{
				byte b = (byte)value;
				return NullabilityInfoContext.TranslateByte(b);
			}
			return NullabilityState.Unknown;
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00121248 File Offset: 0x0011F448
		private static NullabilityState TranslateByte(byte b)
		{
			NullabilityState result;
			if (b != 1)
			{
				if (b != 2)
				{
					result = NullabilityState.Unknown;
				}
				else
				{
					result = NullabilityState.Nullable;
				}
			}
			else
			{
				result = NullabilityState.NotNull;
			}
			return result;
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x0012126A File Offset: 0x0011F46A
		private static bool IsValueTypeOrValueTypeByRef(Type type)
		{
			return type.IsValueType || ((type.IsByRef || type.IsPointer) && type.GetElementType().IsValueType);
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x001212B4 File Offset: 0x0011F4B4
		[CompilerGenerated]
		internal static int <TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|25_0(Type type)
		{
			Type type2 = Nullable.GetUnderlyingType(type) ?? type;
			if (type2.IsGenericType)
			{
				int num = 1;
				foreach (Type type3 in type2.GetGenericArguments())
				{
					num += NullabilityInfoContext.<TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|25_0(type3);
				}
				return num;
			}
			if (type2.HasElementType)
			{
				return ((type2.IsArray > false) ? 1 : 0) + NullabilityInfoContext.<TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|25_0(type2.GetElementType());
			}
			return (!type.IsValueType) ? 1 : 0;
		}

		// Token: 0x040016D8 RID: 5848
		private readonly Dictionary<Module, NullabilityInfoContext.NotAnnotatedStatus> _publicOnlyModules = new Dictionary<Module, NullabilityInfoContext.NotAnnotatedStatus>();

		// Token: 0x040016D9 RID: 5849
		private readonly Dictionary<MemberInfo, NullabilityState> _context = new Dictionary<MemberInfo, NullabilityState>();

		// Token: 0x02000766 RID: 1894
		[Flags]
		private enum NotAnnotatedStatus
		{
			// Token: 0x040016DB RID: 5851
			None = 0,
			// Token: 0x040016DC RID: 5852
			Private = 1,
			// Token: 0x040016DD RID: 5853
			Internal = 2
		}

		// Token: 0x02000767 RID: 1895
		private readonly struct NullableAttributeStateParser
		{
			// Token: 0x060079CA RID: 31178 RVA: 0x00121324 File Offset: 0x0011F524
			public NullableAttributeStateParser(object nullableAttributeArgument)
			{
				this._nullableAttributeArgument = nullableAttributeArgument;
			}

			// Token: 0x17000F8F RID: 3983
			// (get) Token: 0x060079CB RID: 31179 RVA: 0x0012132D File Offset: 0x0011F52D
			public static NullabilityInfoContext.NullableAttributeStateParser Unknown
			{
				get
				{
					return new NullabilityInfoContext.NullableAttributeStateParser(NullabilityInfoContext.NullableAttributeStateParser.UnknownByte);
				}
			}

			// Token: 0x060079CC RID: 31180 RVA: 0x0012133C File Offset: 0x0011F53C
			public bool ParseNullableState(int index, ref NullabilityState state)
			{
				object nullableAttributeArgument = this._nullableAttributeArgument;
				if (nullableAttributeArgument is byte)
				{
					byte b = (byte)nullableAttributeArgument;
					state = NullabilityInfoContext.TranslateByte(b);
					return true;
				}
				ReadOnlyCollection<CustomAttributeTypedArgument> readOnlyCollection = nullableAttributeArgument as ReadOnlyCollection<CustomAttributeTypedArgument>;
				if (readOnlyCollection != null)
				{
					if (index < readOnlyCollection.Count)
					{
						object value = readOnlyCollection[index].Value;
						if (value is byte)
						{
							byte b2 = (byte)value;
							state = NullabilityInfoContext.TranslateByte(b2);
							return true;
						}
					}
				}
				return false;
			}

			// Token: 0x040016DE RID: 5854
			private static readonly object UnknownByte = 0;

			// Token: 0x040016DF RID: 5855
			private readonly object _nullableAttributeArgument;
		}
	}
}

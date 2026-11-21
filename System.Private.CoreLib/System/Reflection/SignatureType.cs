using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x0200077F RID: 1919
	internal abstract class SignatureType : Type
	{
		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06007A9A RID: 31386 RVA: 0x000070DD File Offset: 0x000052DD
		public sealed override bool IsSignatureType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06007A9B RID: 31387
		public abstract override bool IsTypeDefinition { get; }

		// Token: 0x06007A9C RID: 31388
		protected abstract override bool HasElementTypeImpl();

		// Token: 0x06007A9D RID: 31389
		protected abstract override bool IsArrayImpl();

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06007A9E RID: 31390
		public abstract override bool IsSZArray { get; }

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06007A9F RID: 31391
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x06007AA0 RID: 31392
		protected abstract override bool IsByRefImpl();

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06007AA1 RID: 31393
		public abstract override bool IsByRefLike { get; }

		// Token: 0x06007AA2 RID: 31394
		protected abstract override bool IsPointerImpl();

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x00121CA8 File Offset: 0x0011FEA8
		public sealed override bool IsGenericType
		{
			get
			{
				return this.IsGenericTypeDefinition || this.IsConstructedGenericType;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06007AA4 RID: 31396
		public abstract override bool IsGenericTypeDefinition { get; }

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06007AA5 RID: 31397
		public abstract override bool IsConstructedGenericType { get; }

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06007AA6 RID: 31398
		public abstract override bool IsGenericParameter { get; }

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06007AA7 RID: 31399
		public abstract override bool IsGenericTypeParameter { get; }

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06007AA8 RID: 31400
		public abstract override bool IsGenericMethodParameter { get; }

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06007AA9 RID: 31401
		public abstract override bool ContainsGenericParameters { get; }

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x0001A499 File Offset: 0x00018699
		public sealed override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00121CBA File Offset: 0x0011FEBA
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public sealed override Type MakeArrayType()
		{
			return new SignatureArrayType(this, 1, false);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00121CC4 File Offset: 0x0011FEC4
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public sealed override Type MakeArrayType(int rank)
		{
			if (rank <= 0)
			{
				throw new IndexOutOfRangeException();
			}
			return new SignatureArrayType(this, rank, true);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00121CD8 File Offset: 0x0011FED8
		public sealed override Type MakeByRefType()
		{
			return new SignatureByRefType(this);
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x00121CE0 File Offset: 0x0011FEE0
		public sealed override Type MakePointerType()
		{
			return new SignaturePointerType(this);
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public sealed override Type MakeGenericType(params Type[] typeArguments)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00121CF4 File Offset: 0x0011FEF4
		public sealed override Type GetElementType()
		{
			return this.ElementType;
		}

		// Token: 0x06007AB1 RID: 31409
		public abstract override int GetArrayRank();

		// Token: 0x06007AB2 RID: 31410
		public abstract override Type GetGenericTypeDefinition();

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06007AB3 RID: 31411
		public abstract override Type[] GenericTypeArguments { get; }

		// Token: 0x06007AB4 RID: 31412
		public abstract override Type[] GetGenericArguments();

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06007AB5 RID: 31413
		public abstract override int GenericParameterPosition { get; }

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06007AB6 RID: 31414
		internal abstract SignatureType ElementType { get; }

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06007AB7 RID: 31415 RVA: 0x00007B62 File Offset: 0x00005D62
		public sealed override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06007AB8 RID: 31416
		public abstract override string Name { get; }

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06007AB9 RID: 31417
		public abstract override string Namespace { get; }

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06007ABA RID: 31418 RVA: 0x0001A4BA File Offset: 0x000186BA
		public sealed override string FullName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06007ABB RID: 31419 RVA: 0x0001A4BA File Offset: 0x000186BA
		public sealed override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007ABC RID: 31420
		public abstract override string ToString();

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06007ABD RID: 31421 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Assembly Assembly
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06007ABE RID: 31422 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Module Module
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06007ABF RID: 31423 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Type ReflectedType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06007AC0 RID: 31424 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Type BaseType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public sealed override Type[] GetInterfaces()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06007AC3 RID: 31427 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override int MetadataToken
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06007AC5 RID: 31429 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Type DeclaringType
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override MethodBase DeclaringMethod
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Type[] GetGenericParameterConstraints()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsEnumDefined(object value)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override string GetEnumName(object value)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override string[] GetEnumNames()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override Type GetEnumUnderlyingType()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[RequiresDynamicCode("It might not be possible to create an array of the enum type at runtime. Use Enum.GetValues<T> or the GetEnumValuesAsUnderlyingType method instead.")]
		public sealed override Array GetEnumValues()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x00121CFC File Offset: 0x0011FEFC
		public sealed override Guid GUID
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override TypeCode GetTypeCodeImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public sealed override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public sealed override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected sealed override MethodInfo GetMethodImpl(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public sealed override MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2731)]
		public sealed override MemberInfo[] GetDefaultMembers()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public sealed override EventInfo[] GetEvents()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public sealed override Type GetInterface(string name, bool ignoreCase)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override bool IsCOMObjectImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override bool IsPrimitiveImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public sealed override Type[] FindInterfaces(TypeFilter filter, object filterCriteria)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x00121D14 File Offset: 0x0011FF14
		public sealed override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override bool IsContextfulImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsEnum
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsEquivalentTo([NotNullWhen(true)] Type other)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsInstanceOfType([NotNullWhen(true)] object o)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override bool IsMarshalByRefImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsSecurityCritical
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06007AF5 RID: 31477 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsSecuritySafeCritical
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsSecurityTransparent
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public sealed override bool IsSerializable
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override bool IsSubclassOf(Type c)
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		protected sealed override bool IsValueTypeImpl()
		{
			throw new NotSupportedException(SR.NotSupported_SignatureType);
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06007AFA RID: 31482 RVA: 0x00121CE8 File Offset: 0x0011FEE8
		public sealed override StructLayoutAttribute StructLayoutAttribute
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06007AFB RID: 31483 RVA: 0x00121D2C File Offset: 0x0011FF2C
		public sealed override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException(SR.NotSupported_SignatureType);
			}
		}
	}
}

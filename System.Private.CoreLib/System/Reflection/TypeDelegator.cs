using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000786 RID: 1926
	[NullableContext(1)]
	[Nullable(0)]
	public class TypeDelegator : TypeInfo
	{
		// Token: 0x06007B18 RID: 31512 RVA: 0x001221A1 File Offset: 0x001203A1
		[NullableContext(2)]
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x001221BA File Offset: 0x001203BA
		protected TypeDelegator()
		{
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x001221C2 File Offset: 0x001203C2
		public TypeDelegator([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type delegatingType)
		{
			ArgumentNullException.ThrowIfNull(delegatingType, "delegatingType");
			this.typeImpl = delegatingType;
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x001221DC File Offset: 0x001203DC
		public override Guid GUID
		{
			get
			{
				return this.typeImpl.GUID;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x001221E9 File Offset: 0x001203E9
		public override int MetadataToken
		{
			get
			{
				return this.typeImpl.MetadataToken;
			}
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x001221F8 File Offset: 0x001203F8
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember([Nullable(1)] string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, [Nullable(new byte[]
		{
			2,
			1
		})] string[] namedParameters)
		{
			return this.typeImpl.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x0012221D File Offset: 0x0012041D
		public override Module Module
		{
			get
			{
				return this.typeImpl.Module;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06007B1F RID: 31519 RVA: 0x0012222A File Offset: 0x0012042A
		public override Assembly Assembly
		{
			get
			{
				return this.typeImpl.Assembly;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x00122237 File Offset: 0x00120437
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return this.typeImpl.TypeHandle;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06007B21 RID: 31521 RVA: 0x00122244 File Offset: 0x00120444
		public override string Name
		{
			get
			{
				return this.typeImpl.Name;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x00122251 File Offset: 0x00120451
		[Nullable(2)]
		public override string FullName
		{
			[NullableContext(2)]
			get
			{
				return this.typeImpl.FullName;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x0012225E File Offset: 0x0012045E
		[Nullable(2)]
		public override string Namespace
		{
			[NullableContext(2)]
			get
			{
				return this.typeImpl.Namespace;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x0012226B File Offset: 0x0012046B
		[Nullable(2)]
		public override string AssemblyQualifiedName
		{
			[NullableContext(2)]
			get
			{
				return this.typeImpl.AssemblyQualifiedName;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x00122278 File Offset: 0x00120478
		[Nullable(2)]
		public override Type BaseType
		{
			[NullableContext(2)]
			get
			{
				return this.typeImpl.BaseType;
			}
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00122285 File Offset: 0x00120485
		[NullableContext(2)]
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			return this.typeImpl.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x00122299 File Offset: 0x00120499
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetConstructors(bindingAttr);
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x001222A7 File Offset: 0x001204A7
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this.typeImpl.GetMethod(name, bindingAttr);
			}
			return this.typeImpl.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x001222CF File Offset: 0x001204CF
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMethods(bindingAttr);
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x001222DD File Offset: 0x001204DD
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		[return: Nullable(2)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetField(name, bindingAttr);
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x001222EC File Offset: 0x001204EC
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetFields(bindingAttr);
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x001222FA File Offset: 0x001204FA
		public override Type[] GetFunctionPointerCallingConventions()
		{
			return this.typeImpl.GetFunctionPointerCallingConventions();
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x00122307 File Offset: 0x00120507
		public override Type[] GetFunctionPointerParameterTypes()
		{
			return this.typeImpl.GetFunctionPointerParameterTypes();
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00122314 File Offset: 0x00120514
		public override Type GetFunctionPointerReturnType()
		{
			return this.typeImpl.GetFunctionPointerReturnType();
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x00122321 File Offset: 0x00120521
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: Nullable(2)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			return this.typeImpl.GetInterface(name, ignoreCase);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x00122330 File Offset: 0x00120530
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			return this.typeImpl.GetInterfaces();
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x0012233D File Offset: 0x0012053D
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		[return: Nullable(2)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvent(name, bindingAttr);
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x0012234C File Offset: 0x0012054C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			return this.typeImpl.GetEvents();
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00122359 File Offset: 0x00120559
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers)
		{
			if (returnType == null && types == null)
			{
				return this.typeImpl.GetProperty(name, bindingAttr);
			}
			return this.typeImpl.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x0012238B File Offset: 0x0012058B
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetProperties(bindingAttr);
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00122399 File Offset: 0x00120599
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvents(bindingAttr);
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x001223A7 File Offset: 0x001205A7
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetNestedTypes(bindingAttr);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x001223B5 File Offset: 0x001205B5
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		[return: Nullable(2)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetNestedType(name, bindingAttr);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x001223C4 File Offset: 0x001205C4
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMember(name, type, bindingAttr);
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x001223D4 File Offset: 0x001205D4
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMembers(bindingAttr);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x001223E2 File Offset: 0x001205E2
		public override MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member)
		{
			return this.typeImpl.GetMemberWithSameMetadataDefinitionAs(member);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x001223F0 File Offset: 0x001205F0
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.typeImpl.Attributes;
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06007B3C RID: 31548 RVA: 0x001223FD File Offset: 0x001205FD
		public override bool IsTypeDefinition
		{
			get
			{
				return this.typeImpl.IsTypeDefinition;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06007B3D RID: 31549 RVA: 0x0012240A File Offset: 0x0012060A
		public override bool IsSZArray
		{
			get
			{
				return this.typeImpl.IsSZArray;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06007B3E RID: 31550 RVA: 0x00122417 File Offset: 0x00120617
		public override bool IsVariableBoundArray
		{
			get
			{
				return this.typeImpl.IsVariableBoundArray;
			}
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x00122424 File Offset: 0x00120624
		protected override bool IsArrayImpl()
		{
			return this.typeImpl.IsArray;
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x00122431 File Offset: 0x00120631
		protected override bool IsPrimitiveImpl()
		{
			return this.typeImpl.IsPrimitive;
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0012243E File Offset: 0x0012063E
		protected override bool IsByRefImpl()
		{
			return this.typeImpl.IsByRef;
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06007B42 RID: 31554 RVA: 0x0012244B File Offset: 0x0012064B
		public override bool IsGenericTypeParameter
		{
			get
			{
				return this.typeImpl.IsGenericTypeParameter;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06007B43 RID: 31555 RVA: 0x00122458 File Offset: 0x00120658
		public override bool IsGenericMethodParameter
		{
			get
			{
				return this.typeImpl.IsGenericMethodParameter;
			}
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00122465 File Offset: 0x00120665
		protected override bool IsPointerImpl()
		{
			return this.typeImpl.IsPointer;
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00122472 File Offset: 0x00120672
		protected override bool IsValueTypeImpl()
		{
			return this.typeImpl.IsValueType;
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x0012247F File Offset: 0x0012067F
		protected override bool IsCOMObjectImpl()
		{
			return this.typeImpl.IsCOMObject;
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x0012248C File Offset: 0x0012068C
		public override bool IsByRefLike
		{
			get
			{
				return this.typeImpl.IsByRefLike;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x00122499 File Offset: 0x00120699
		public override bool IsConstructedGenericType
		{
			get
			{
				return this.typeImpl.IsConstructedGenericType;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06007B49 RID: 31561 RVA: 0x001224A6 File Offset: 0x001206A6
		public override bool IsCollectible
		{
			get
			{
				return this.typeImpl.IsCollectible;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x001224B3 File Offset: 0x001206B3
		public override bool IsFunctionPointer
		{
			get
			{
				return this.typeImpl.IsFunctionPointer;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x001224C0 File Offset: 0x001206C0
		public override bool IsUnmanagedFunctionPointer
		{
			get
			{
				return this.typeImpl.IsUnmanagedFunctionPointer;
			}
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x001224CD File Offset: 0x001206CD
		[NullableContext(2)]
		public override Type GetElementType()
		{
			return this.typeImpl.GetElementType();
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x001224DA File Offset: 0x001206DA
		protected override bool HasElementTypeImpl()
		{
			return this.typeImpl.HasElementType;
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06007B4E RID: 31566 RVA: 0x001224E7 File Offset: 0x001206E7
		public override Type UnderlyingSystemType
		{
			get
			{
				return this.typeImpl.UnderlyingSystemType;
			}
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x001224F4 File Offset: 0x001206F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(inherit);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x00122502 File Offset: 0x00120702
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00122511 File Offset: 0x00120711
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this.typeImpl.IsDefined(attributeType, inherit);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x00122520 File Offset: 0x00120720
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			return this.typeImpl.GetInterfaceMap(interfaceType);
		}

		// Token: 0x0400174A RID: 5962
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		protected Type typeImpl;
	}
}

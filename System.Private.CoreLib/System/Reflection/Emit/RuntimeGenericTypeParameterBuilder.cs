using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A8 RID: 1960
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeGenericTypeParameterBuilder : GenericTypeParameterBuilder
	{
		// Token: 0x06007D2F RID: 32047 RVA: 0x00127454 File Offset: 0x00125654
		[DynamicDependency("attrs")]
		internal RuntimeGenericTypeParameterBuilder(RuntimeTypeBuilder tbuilder, RuntimeMethodBuilder mbuilder, string name, int index)
		{
			this.tbuilder = tbuilder;
			this.mbuilder = mbuilder;
			this.name = name;
			this.index = index;
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x00127479 File Offset: 0x00125679
		protected override void SetBaseTypeConstraintCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type baseTypeConstraint)
		{
			this.base_type = (baseTypeConstraint ?? typeof(object));
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x00127490 File Offset: 0x00125690
		protected override void SetInterfaceConstraintsCore(params Type[] interfaceConstraints)
		{
			this.iface_constraints = interfaceConstraints;
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x00127499 File Offset: 0x00125699
		protected override void SetGenericParameterAttributesCore(GenericParameterAttributes genericParameterAttributes)
		{
			this.attrs = genericParameterAttributes;
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x001274A4 File Offset: 0x001256A4
		internal override Type InternalResolve()
		{
			if (this.mbuilder != null)
			{
				return MethodBase.GetMethodFromHandle(this.mbuilder.MethodHandleInternal, this.mbuilder.TypeBuilder.InternalResolve().TypeHandle).GetGenericArguments()[this.index];
			}
			return this.tbuilder.InternalResolve().GetGenericArguments()[this.index];
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x00127508 File Offset: 0x00125708
		internal override Type RuntimeResolve()
		{
			if (this.mbuilder != null)
			{
				return MethodBase.GetMethodFromHandle(this.mbuilder.MethodHandleInternal, this.mbuilder.TypeBuilder.RuntimeResolve().TypeHandle).GetGenericArguments()[this.index];
			}
			return this.tbuilder.RuntimeResolve().GetGenericArguments()[this.index];
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x0012756C File Offset: 0x0012576C
		public override bool IsSubclassOf(Type c)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x000070DD File Offset: 0x000052DD
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return TypeAttributes.Public;
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x0012756C File Offset: 0x0012576C
		public override bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D4A RID: 32074 RVA: 0x001221A1 File Offset: 0x001203A1
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x0012756C File Offset: 0x0012576C
		public override bool IsInstanceOfType(object o)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00127573 File Offset: 0x00125773
		protected override bool IsValueTypeImpl()
		{
			return this.base_type != null && this.base_type.IsValueType;
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06007D52 RID: 32082 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x0012756C File Offset: 0x0012576C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x0012756C File Offset: 0x0012576C
		public override Type GetElementType()
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x00007B62 File Offset: 0x00005D62
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x00127590 File Offset: 0x00125790
		public override Assembly Assembly
		{
			get
			{
				return this.tbuilder.Assembly;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x0012759D File Offset: 0x0012579D
		public override Type BaseType
		{
			get
			{
				return this.base_type;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06007D59 RID: 32089 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override string FullName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x0012756C File Offset: 0x0012576C
		public override Guid GUID
		{
			get
			{
				throw RuntimeGenericTypeParameterBuilder.not_supported();
			}
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x0012756C File Offset: 0x0012576C
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x0012756C File Offset: 0x0012576C
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x0012756C File Offset: 0x0012576C
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x0012756C File Offset: 0x0012576C
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			throw RuntimeGenericTypeParameterBuilder.not_supported();
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06007D5F RID: 32095 RVA: 0x001275A5 File Offset: 0x001257A5
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override string Namespace
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x001275AD File Offset: 0x001257AD
		public override Module Module
		{
			get
			{
				return this.tbuilder.Module;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06007D62 RID: 32098 RVA: 0x001275BA File Offset: 0x001257BA
		public override Type DeclaringType
		{
			get
			{
				if (!(this.mbuilder != null))
				{
					return this.tbuilder;
				}
				return this.mbuilder.DeclaringType;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x00014646 File Offset: 0x00012846
		public override Type ReflectedType
		{
			get
			{
				return this.DeclaringType;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x0012756C File Offset: 0x0012576C
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw RuntimeGenericTypeParameterBuilder.not_supported();
			}
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00066B61 File Offset: 0x00064D61
		public override Type[] GetGenericArguments()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x00066B61 File Offset: 0x00064D61
		public override Type GetGenericTypeDefinition()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06007D67 RID: 32103 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool ContainsGenericParameters
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsGenericParameter
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06007D6B RID: 32107 RVA: 0x001275DC File Offset: 0x001257DC
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06007D6C RID: 32108 RVA: 0x001275E4 File Offset: 0x001257E4
		public override int GenericParameterPosition
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x00066B61 File Offset: 0x00064D61
		public override Type[] GetGenericParameterConstraints()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x001275EC File Offset: 0x001257EC
		public override MethodBase DeclaringMethod
		{
			get
			{
				return this.mbuilder;
			}
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x001275F4 File Offset: 0x001257F4
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(con, binaryAttribute);
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customAttributeBuilder;
				this.cattrs = array;
				return;
			}
			this.cattrs = new CustomAttributeBuilder[1];
			this.cattrs[0] = customAttributeBuilder;
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x00127656 File Offset: 0x00125856
		private static NotSupportedException not_supported()
		{
			return new NotSupportedException();
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x001275A5 File Offset: 0x001257A5
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x0012765D File Offset: 0x0012585D
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x00127666 File Offset: 0x00125866
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x0012766E File Offset: 0x0012586E
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType()
		{
			return SymbolType.FormCompoundType("[]", this, 0);
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x0012767C File Offset: 0x0012587C
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType(int rank)
		{
			return SymbolType.FormCompoundType(TypeInfo.GetRankString(rank), this, 0);
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x0012768B File Offset: 0x0012588B
		public override Type MakeByRefType()
		{
			return SymbolType.FormCompoundType("&", this, 0);
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x00127699 File Offset: 0x00125899
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			throw new InvalidOperationException(SR.Format(SR.Arg_NotGenericTypeDefinition, this));
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x001276AB File Offset: 0x001258AB
		public override Type MakePointerType()
		{
			return SymbolType.FormCompoundType("*", this, 0);
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsByRefLike
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040017E6 RID: 6118
		private RuntimeTypeBuilder tbuilder;

		// Token: 0x040017E7 RID: 6119
		private RuntimeMethodBuilder mbuilder;

		// Token: 0x040017E8 RID: 6120
		private string name;

		// Token: 0x040017E9 RID: 6121
		private int index;

		// Token: 0x040017EA RID: 6122
		private Type base_type;

		// Token: 0x040017EB RID: 6123
		private Type[] iface_constraints;

		// Token: 0x040017EC RID: 6124
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040017ED RID: 6125
		private GenericParameterAttributes attrs;
	}
}

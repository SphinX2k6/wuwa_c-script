using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A5 RID: 1957
	internal sealed class RuntimeEnumBuilder : EnumBuilder
	{
		// Token: 0x06007CD4 RID: 31956 RVA: 0x00126C54 File Offset: 0x00124E54
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2064:UnrecognizedReflectionPattern", Justification = "Reflection.Emit is not subject to trimming")]
		internal RuntimeEnumBuilder(RuntimeModuleBuilder mb, string name, TypeAttributes visibility, Type underlyingType)
		{
			if ((visibility & ~TypeAttributes.VisibilityMask) != TypeAttributes.NotPublic)
			{
				throw new ArgumentException(SR.Argument_ShouldOnlySetVisibilityFlags, "name");
			}
			if ((visibility & TypeAttributes.VisibilityMask) >= TypeAttributes.NestedPublic && (visibility & TypeAttributes.VisibilityMask) <= TypeAttributes.VisibilityMask)
			{
				throw new ArgumentException();
			}
			this._tb = new RuntimeTypeBuilder(mb, name, visibility | TypeAttributes.Sealed, typeof(Enum), null, PackingSize.Unspecified, 0, null);
			this._underlyingType = underlyingType;
			this._underlyingField = this._tb.DefineField("value__", underlyingType, FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.SpecialName | FieldAttributes.RTSpecialName);
			this.setup_enum_type(this._tb);
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x00126CE2 File Offset: 0x00124EE2
		internal RuntimeTypeBuilder GetTypeBuilder()
		{
			return this._tb;
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00126CEA File Offset: 0x00124EEA
		internal override Type InternalResolve()
		{
			return this._tb.InternalResolve();
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00126CF7 File Offset: 0x00124EF7
		internal override Type RuntimeResolve()
		{
			return this._tb.RuntimeResolve();
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x00126D04 File Offset: 0x00124F04
		public override Assembly Assembly
		{
			get
			{
				return this._tb.Assembly;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x00126D11 File Offset: 0x00124F11
		public override string AssemblyQualifiedName
		{
			get
			{
				return this._tb.AssemblyQualifiedName;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x00126D1E File Offset: 0x00124F1E
		public override Type BaseType
		{
			get
			{
				return this._tb.BaseType;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x00126D2B File Offset: 0x00124F2B
		public override Type DeclaringType
		{
			get
			{
				return this._tb.DeclaringType;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06007CDC RID: 31964 RVA: 0x00126D38 File Offset: 0x00124F38
		public override string FullName
		{
			get
			{
				return this._tb.FullName;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06007CDD RID: 31965 RVA: 0x00126D45 File Offset: 0x00124F45
		public override Guid GUID
		{
			get
			{
				return this._tb.GUID;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06007CDE RID: 31966 RVA: 0x00126D52 File Offset: 0x00124F52
		public override Module Module
		{
			get
			{
				return this._tb.Module;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06007CDF RID: 31967 RVA: 0x00126D5F File Offset: 0x00124F5F
		public override string Name
		{
			get
			{
				return this._tb.Name;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x00126D6C File Offset: 0x00124F6C
		public override string Namespace
		{
			get
			{
				return this._tb.Namespace;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x00126D79 File Offset: 0x00124F79
		public override Type ReflectedType
		{
			get
			{
				return this._tb.ReflectedType;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06007CE2 RID: 31970 RVA: 0x00126D86 File Offset: 0x00124F86
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return this._tb.TypeHandle;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x00126D93 File Offset: 0x00124F93
		protected override FieldBuilder UnderlyingFieldCore
		{
			get
			{
				return this._underlyingField;
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x00126D9B File Offset: 0x00124F9B
		public override Type UnderlyingSystemType
		{
			get
			{
				return this._underlyingType;
			}
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x00126DA3 File Offset: 0x00124FA3
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		protected override TypeInfo CreateTypeInfoCore()
		{
			return this._tb.CreateTypeInfo();
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x00126D9B File Offset: 0x00124F9B
		public override Type GetEnumUnderlyingType()
		{
			return this._underlyingType;
		}

		// Token: 0x06007CE7 RID: 31975
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2110:ReflectionToDynamicallyAccessedMembers", Justification = "For instance members with MethodImplOptions.InternalCall, the linker preserves all fields of the declaring type. The _tb field has DynamicallyAccessedMembersAttribute requirements, but the field access is safe because Reflection.Emit is not subject to trimming.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void setup_enum_type(Type t);

		// Token: 0x06007CE8 RID: 31976 RVA: 0x00126DB0 File Offset: 0x00124FB0
		protected override FieldBuilder DefineLiteralCore(string literalName, object literalValue)
		{
			FieldBuilder fieldBuilder = this._tb.DefineField(literalName, this, FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static | FieldAttributes.Literal);
			fieldBuilder.SetConstant(literalValue);
			return fieldBuilder;
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00126DD5 File Offset: 0x00124FD5
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this._tb.attrs;
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x00126DE2 File Offset: 0x00124FE2
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this._tb.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x00126DF6 File Offset: 0x00124FF6
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this._tb.GetConstructors(bindingAttr);
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x00126E04 File Offset: 0x00125004
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._tb.GetCustomAttributes(inherit);
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x00126E12 File Offset: 0x00125012
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				return this._tb.GetCustomAttributes(inherit);
			}
			return this._tb.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x00126E37 File Offset: 0x00125037
		public override Type GetElementType()
		{
			return this._tb.GetElementType();
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x00126E44 File Offset: 0x00125044
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetEvent(name, bindingAttr);
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x00126E53 File Offset: 0x00125053
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			return this._tb.GetEvents();
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x00126E60 File Offset: 0x00125060
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this._tb.GetEvents(bindingAttr);
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x00126E6E File Offset: 0x0012506E
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetField(name, bindingAttr);
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x00126E7D File Offset: 0x0012507D
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this._tb.GetFields(bindingAttr);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x00126E8B File Offset: 0x0012508B
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			return this._tb.GetInterface(name, ignoreCase);
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x00126E9A File Offset: 0x0012509A
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			return this._tb.GetInterfaceMap(interfaceType);
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x00126EA8 File Offset: 0x001250A8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			return this._tb.GetInterfaces();
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x00126EB5 File Offset: 0x001250B5
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return this._tb.GetMember(name, type, bindingAttr);
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x00126EC5 File Offset: 0x001250C5
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return this._tb.GetMembers(bindingAttr);
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x00126ED3 File Offset: 0x001250D3
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this._tb.GetMethod(name, bindingAttr);
			}
			return this._tb.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x00126EFB File Offset: 0x001250FB
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this._tb.GetMethods(bindingAttr);
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x00126F09 File Offset: 0x00125109
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetNestedType(name, bindingAttr);
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x00126F18 File Offset: 0x00125118
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return this._tb.GetNestedTypes(bindingAttr);
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x00126F26 File Offset: 0x00125126
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this._tb.GetProperties(bindingAttr);
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x00126F34 File Offset: 0x00125134
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x00126F40 File Offset: 0x00125140
		protected override bool HasElementTypeImpl()
		{
			return this._tb.HasElementType;
		}

		// Token: 0x06007D00 RID: 32000 RVA: 0x00126F50 File Offset: 0x00125150
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return this._tb.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x06007D01 RID: 32001 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x000070DD File Offset: 0x000052DD
		protected override bool IsValueTypeImpl()
		{
			return true;
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x00126F75 File Offset: 0x00125175
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._tb.IsDefined(attributeType, inherit);
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x00126F84 File Offset: 0x00125184
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			this._tb.SetCustomAttribute(con, binaryAttribute);
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06007D0A RID: 32010 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x001221A1 File Offset: 0x001203A1
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsTypeDefinition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06007D0E RID: 32014 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsByRefLike
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040017CD RID: 6093
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		private RuntimeTypeBuilder _tb;

		// Token: 0x040017CE RID: 6094
		private FieldBuilder _underlyingField;

		// Token: 0x040017CF RID: 6095
		private Type _underlyingType;
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007D4 RID: 2004
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TypeBuilder : TypeInfo
	{
		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600804A RID: 32842 RVA: 0x0012F31F File Offset: 0x0012D51F
		public PackingSize PackingSize
		{
			get
			{
				return this.PackingSizeCore;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600804B RID: 32843
		protected abstract PackingSize PackingSizeCore { get; }

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x0012F327 File Offset: 0x0012D527
		public int Size
		{
			get
			{
				return this.SizeCore;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600804D RID: 32845
		protected abstract int SizeCore { get; }

		// Token: 0x0600804E RID: 32846 RVA: 0x0012F32F File Offset: 0x0012D52F
		public void AddInterfaceImplementation([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type interfaceType)
		{
			ArgumentNullException.ThrowIfNull(interfaceType, "interfaceType");
			this.AddInterfaceImplementationCore(interfaceType);
		}

		// Token: 0x0600804F RID: 32847
		protected abstract void AddInterfaceImplementationCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type interfaceType);

		// Token: 0x06008050 RID: 32848 RVA: 0x0012F343 File Offset: 0x0012D543
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public Type CreateType()
		{
			return this.CreateTypeInfo();
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x0012F34B File Offset: 0x0012D54B
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public TypeInfo CreateTypeInfo()
		{
			return this.CreateTypeInfoCore();
		}

		// Token: 0x06008052 RID: 32850
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		protected abstract TypeInfo CreateTypeInfoCore();

		// Token: 0x06008053 RID: 32851 RVA: 0x0012F353 File Offset: 0x0012D553
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineConstructor(attributes, callingConvention, parameterTypes, null, null);
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x0012F360 File Offset: 0x0012D560
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalCustomModifiers)
		{
			return this.DefineConstructorCore(attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers);
		}

		// Token: 0x06008055 RID: 32853
		protected abstract ConstructorBuilder DefineConstructorCore(MethodAttributes attributes, CallingConventions callingConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalCustomModifiers);

		// Token: 0x06008056 RID: 32854 RVA: 0x0012F36F File Offset: 0x0012D56F
		public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes)
		{
			return this.DefineDefaultConstructorCore(attributes);
		}

		// Token: 0x06008057 RID: 32855
		protected abstract ConstructorBuilder DefineDefaultConstructorCore(MethodAttributes attributes);

		// Token: 0x06008058 RID: 32856 RVA: 0x0012F378 File Offset: 0x0012D578
		public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineEventCore(name, attributes, eventtype);
		}

		// Token: 0x06008059 RID: 32857
		protected abstract EventBuilder DefineEventCore(string name, EventAttributes attributes, Type eventtype);

		// Token: 0x0600805A RID: 32858 RVA: 0x0012F38E File Offset: 0x0012D58E
		public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes)
		{
			return this.DefineField(fieldName, type, null, null, attributes);
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x0012F39B File Offset: 0x0012D59B
		public FieldBuilder DefineField(string fieldName, Type type, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalCustomModifiers, FieldAttributes attributes)
		{
			ArgumentException.ThrowIfNullOrEmpty(fieldName, "fieldName");
			ArgumentNullException.ThrowIfNull(type, "type");
			return this.DefineFieldCore(fieldName, type, requiredCustomModifiers, optionalCustomModifiers, attributes);
		}

		// Token: 0x0600805C RID: 32860
		protected abstract FieldBuilder DefineFieldCore(string fieldName, Type type, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalCustomModifiers, FieldAttributes attributes);

		// Token: 0x0600805D RID: 32861 RVA: 0x0012F3C0 File Offset: 0x0012D5C0
		public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
		{
			ArgumentNullException.ThrowIfNull(names, "names");
			if (names.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptyArray, "names");
			}
			return this.DefineGenericParametersCore(names);
		}

		// Token: 0x0600805E RID: 32862
		protected abstract GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names);

		// Token: 0x0600805F RID: 32863 RVA: 0x0012F3E8 File Offset: 0x0012D5E8
		public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
		{
			ArgumentNullException.ThrowIfNull(data, "data");
			return this.DefineInitializedDataCore(name, data, attributes);
		}

		// Token: 0x06008060 RID: 32864
		protected abstract FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes);

		// Token: 0x06008061 RID: 32865 RVA: 0x0012F3FE File Offset: 0x0012D5FE
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes)
		{
			return this.DefineMethod(name, attributes, CallingConventions.Standard, null, null);
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x0012F40B File Offset: 0x0012D60B
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention)
		{
			return this.DefineMethod(name, attributes, callingConvention, null, null);
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x0012F418 File Offset: 0x0012D618
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x0012F436 File Offset: 0x0012D636
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineMethod(name, attributes, CallingConventions.Standard, returnType, parameterTypes);
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x0012F444 File Offset: 0x0012D644
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			if (parameterTypes != null)
			{
				if (parameterTypeOptionalCustomModifiers != null && parameterTypeOptionalCustomModifiers.Length != parameterTypes.Length)
				{
					throw new ArgumentException(SR.Format(SR.Argument_MismatchedArrays, "parameterTypeOptionalCustomModifiers", "parameterTypes"));
				}
				if (parameterTypeRequiredCustomModifiers != null && parameterTypeRequiredCustomModifiers.Length != parameterTypes.Length)
				{
					throw new ArgumentException(SR.Format(SR.Argument_MismatchedArrays, "parameterTypeRequiredCustomModifiers", "parameterTypes"));
				}
			}
			return this.DefineMethodCore(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}

		// Token: 0x06008066 RID: 32870
		protected abstract MethodBuilder DefineMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers);

		// Token: 0x06008067 RID: 32871 RVA: 0x0012F4C5 File Offset: 0x0012D6C5
		public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
		{
			ArgumentNullException.ThrowIfNull(methodInfoBody, "methodInfoBody");
			ArgumentNullException.ThrowIfNull(methodInfoDeclaration, "methodInfoDeclaration");
			this.DefineMethodOverrideCore(methodInfoBody, methodInfoDeclaration);
		}

		// Token: 0x06008068 RID: 32872
		protected abstract void DefineMethodOverrideCore(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration);

		// Token: 0x06008069 RID: 32873 RVA: 0x0012F4E5 File Offset: 0x0012D6E5
		public TypeBuilder DefineNestedType(string name)
		{
			return this.DefineNestedType(name, TypeAttributes.NestedPrivate, null, null);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0012F4F1 File Offset: 0x0012D6F1
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr)
		{
			return this.DefineNestedType(name, attr, null, null);
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x0012F4FD File Offset: 0x0012D6FD
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent)
		{
			return this.DefineNestedType(name, attr, parent, null);
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x0012F509 File Offset: 0x0012D709
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] interfaces)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineNestedTypeCore(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}

		// Token: 0x0600806D RID: 32877
		protected abstract TypeBuilder DefineNestedTypeCore(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] interfaces, PackingSize packSize, int typeSize);

		// Token: 0x0600806E RID: 32878 RVA: 0x0012F523 File Offset: 0x0012D723
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, int typeSize)
		{
			return this.DefineNestedType(name, attr, parent, PackingSize.Unspecified, typeSize);
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x0012F531 File Offset: 0x0012D731
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, PackingSize packSize)
		{
			return this.DefineNestedType(name, attr, parent, packSize, 0);
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x0012F53F File Offset: 0x0012D73F
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, PackingSize packSize, int typeSize)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineNestedTypeCore(name, attr, parent, null, packSize, typeSize);
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x0012F55C File Offset: 0x0012D75C
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, nativeCallConv, nativeCharSet);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x0012F584 File Offset: 0x0012D784
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, entryName, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, nativeCallConv, nativeCharSet);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x0012F5AC File Offset: 0x0012D7AC
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			ArgumentException.ThrowIfNullOrEmpty(dllName, "dllName");
			ArgumentException.ThrowIfNullOrEmpty(entryName, "entryName");
			return this.DefinePInvokeMethodCore(name, dllName, entryName, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, nativeCallConv, nativeCharSet);
		}

		// Token: 0x06008074 RID: 32884
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		protected abstract MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet);

		// Token: 0x06008075 RID: 32885 RVA: 0x0012F5F8 File Offset: 0x0012D7F8
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineProperty(name, attributes, returnType, null, null, parameterTypes, null, null);
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x0012F614 File Offset: 0x0012D814
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineProperty(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x0012F634 File Offset: 0x0012D834
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers)
		{
			return this.DefineProperty(name, attributes, (CallingConventions)0, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x0012F658 File Offset: 0x0012D858
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefinePropertyCore(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}

		// Token: 0x06008079 RID: 32889
		protected abstract PropertyBuilder DefinePropertyCore(string name, PropertyAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers);

		// Token: 0x0600807A RID: 32890 RVA: 0x0012F685 File Offset: 0x0012D885
		public ConstructorBuilder DefineTypeInitializer()
		{
			return this.DefineTypeInitializerCore();
		}

		// Token: 0x0600807B RID: 32891
		protected abstract ConstructorBuilder DefineTypeInitializerCore();

		// Token: 0x0600807C RID: 32892 RVA: 0x0012F68D File Offset: 0x0012D88D
		public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
		{
			return this.DefineUninitializedDataCore(name, size, attributes);
		}

		// Token: 0x0600807D RID: 32893
		protected abstract FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes);

		// Token: 0x0600807E RID: 32894 RVA: 0x0012F698 File Offset: 0x0012D898
		public bool IsCreated()
		{
			return this.IsCreatedCore();
		}

		// Token: 0x0600807F RID: 32895
		protected abstract bool IsCreatedCore();

		// Token: 0x06008080 RID: 32896 RVA: 0x0012F6A0 File Offset: 0x0012D8A0
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06008081 RID: 32897
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06008082 RID: 32898 RVA: 0x0012F6C5 File Offset: 0x0012D8C5
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x0012F6E9 File Offset: 0x0012D8E9
		[NullableContext(2)]
		public void SetParent([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent)
		{
			this.SetParentCore(parent);
		}

		// Token: 0x06008084 RID: 32900
		[NullableContext(2)]
		protected abstract void SetParentCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent);

		// Token: 0x06008085 RID: 32901 RVA: 0x001276AB File Offset: 0x001258AB
		public override Type MakePointerType()
		{
			return SymbolType.FormCompoundType("*", this, 0);
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x0012768B File Offset: 0x0012588B
		public override Type MakeByRefType()
		{
			return SymbolType.FormCompoundType("&", this, 0);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x0012766E File Offset: 0x0012586E
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType()
		{
			return SymbolType.FormCompoundType("[]", this, 0);
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x0012767C File Offset: 0x0012587C
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public override Type MakeArrayType(int rank)
		{
			return SymbolType.FormCompoundType(TypeInfo.GetRankString(rank), this, 0);
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x0012F6F2 File Offset: 0x0012D8F2
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			return TypeBuilderInstantiation.MakeGenericType(this, typeArguments);
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x0012F6FC File Offset: 0x0012D8FC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "MakeGenericType is only called on a TypeBuilder which is not subject to trimming")]
		public static MethodInfo GetMethod(Type type, MethodInfo method)
		{
			if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
			{
				throw new ArgumentException(SR.Argument_MustBeTypeBuilder, "type");
			}
			if (method.IsGenericMethod && !method.IsGenericMethodDefinition)
			{
				throw new ArgumentException(SR.Argument_NeedGenericMethodDefinition, "method");
			}
			if (method.DeclaringType == null || !method.DeclaringType.IsGenericTypeDefinition)
			{
				throw new ArgumentException(SR.Argument_MethodNeedGenericDeclaringType, "method");
			}
			if (type.GetGenericTypeDefinition() != method.DeclaringType)
			{
				throw new ArgumentException(SR.Argument_InvalidMethodDeclaringType, "type");
			}
			if (type.IsGenericTypeDefinition)
			{
				type = type.MakeGenericType(type.GetGenericArguments());
			}
			TypeBuilderInstantiation typeBuilderInstantiation = type as TypeBuilderInstantiation;
			if (typeBuilderInstantiation == null)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "type");
			}
			return MethodOnTypeBuilderInstantiation.GetMethod(method, typeBuilderInstantiation);
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x0012F7D0 File Offset: 0x0012D9D0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "MakeGenericType is only called on a TypeBuilder which is not subject to trimming")]
		public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor)
		{
			if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
			{
				throw new ArgumentException(SR.Argument_MustBeTypeBuilder, "type");
			}
			if (!constructor.DeclaringType.IsGenericTypeDefinition)
			{
				throw new ArgumentException(SR.Argument_ConstructorNeedGenericDeclaringType, "constructor");
			}
			if (type.GetGenericTypeDefinition() != constructor.DeclaringType)
			{
				throw new ArgumentException(SR.Argument_InvalidConstructorDeclaringType, "type");
			}
			if (type.IsGenericTypeDefinition)
			{
				type = type.MakeGenericType(type.GetGenericArguments());
			}
			TypeBuilderInstantiation typeBuilderInstantiation = type as TypeBuilderInstantiation;
			if (typeBuilderInstantiation == null)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "type");
			}
			return ConstructorOnTypeBuilderInstantiation.GetConstructor(constructor, typeBuilderInstantiation);
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x0012F874 File Offset: 0x0012DA74
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "MakeGenericType is only called on a TypeBuilder which is not subject to trimming")]
		public static FieldInfo GetField(Type type, FieldInfo field)
		{
			if (!(type is TypeBuilder) && !(type is TypeBuilderInstantiation))
			{
				throw new ArgumentException(SR.Argument_MustBeTypeBuilder, "type");
			}
			if (!field.DeclaringType.IsGenericTypeDefinition)
			{
				throw new ArgumentException(SR.Argument_FieldNeedGenericDeclaringType, "field");
			}
			if (type.GetGenericTypeDefinition() != field.DeclaringType)
			{
				throw new ArgumentException(SR.Argument_InvalidFieldDeclaringType, "type");
			}
			if (type.IsGenericTypeDefinition)
			{
				type = type.MakeGenericType(type.GetGenericArguments());
			}
			TypeBuilderInstantiation typeBuilderInstantiation = type as TypeBuilderInstantiation;
			if (typeBuilderInstantiation == null)
			{
				throw new ArgumentException(SR.Argument_NeedNonGenericType, "type");
			}
			return FieldOnTypeBuilderInstantiation.GetField(field, typeBuilderInstantiation);
		}

		// Token: 0x04001AC4 RID: 6852
		public const int UnspecifiedTypeSize = 0;
	}
}

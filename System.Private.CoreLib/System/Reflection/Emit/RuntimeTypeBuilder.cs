using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B6 RID: 1974
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeTypeBuilder : TypeBuilder
	{
		// Token: 0x06007E60 RID: 32352 RVA: 0x0012AC02 File Offset: 0x00128E02
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.attrs;
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x0012AC0C File Offset: 0x00128E0C
		[DynamicDependency("state")]
		[DynamicDependency("IsAssignableToInternal")]
		internal RuntimeTypeBuilder(RuntimeModuleBuilder mb, TypeAttributes attr, int table_idx, bool is_hidden_global_type = false)
		{
			this.is_hidden_global_type = is_hidden_global_type;
			this.parent = null;
			this.attrs = attr;
			this.class_size = 0;
			this.table_idx = table_idx;
			this.tname = ((table_idx == 1) ? "<Module>" : ("type_" + table_idx.ToString()));
			this.nspace = string.Empty;
			this.fullname = TypeIdentifiers.WithoutEscape(this.tname);
			this.pmodule = mb;
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x0012AC88 File Offset: 0x00128E88
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2074:UnrecognizedReflectionPattern", Justification = "Linker doesn't analyze ResolveUserType but it's an identity function")]
		[DynamicDependency("state")]
		[DynamicDependency("IsAssignableToInternal")]
		internal RuntimeTypeBuilder(RuntimeModuleBuilder mb, string name, TypeAttributes attr, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, Type[] interfaces, PackingSize packing_size, int type_size, Type nesting_type)
		{
			this.is_hidden_global_type = false;
			this.parent = RuntimeTypeBuilder.ResolveUserType(parent);
			this.attrs = attr;
			this.class_size = type_size;
			this.packing_size = packing_size;
			this.nesting_type = nesting_type;
			RuntimeTypeBuilder.check_name("name", name);
			if (parent == null && (attr & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic && (attr & TypeAttributes.Abstract) == TypeAttributes.NotPublic)
			{
				throw new InvalidOperationException(SR.InvalidOperation_BadInterfaceNotAbstract);
			}
			int num = name.LastIndexOf('.');
			if (num != -1)
			{
				this.tname = name.Substring(num + 1);
				this.nspace = name.Substring(0, num);
			}
			else
			{
				this.tname = name;
				this.nspace = string.Empty;
			}
			if (interfaces != null)
			{
				this.interfaces = new Type[interfaces.Length];
				Array.Copy(interfaces, this.interfaces, interfaces.Length);
			}
			this.pmodule = mb;
			if ((attr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && parent == null)
			{
				this.parent = typeof(object);
			}
			this.table_idx = mb.get_next_table_index(2, 1);
			this.fullname = this.GetFullName();
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0012ADA0 File Offset: 0x00128FA0
		public override Assembly Assembly
		{
			get
			{
				return this.pmodule.Assembly;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06007E64 RID: 32356 RVA: 0x0012ADAD File Offset: 0x00128FAD
		public override string AssemblyQualifiedName
		{
			get
			{
				return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.AssemblyQualifiedName);
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0012ADB6 File Offset: 0x00128FB6
		public override Type BaseType
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06007E66 RID: 32358 RVA: 0x0012ADBE File Offset: 0x00128FBE
		public override Type DeclaringType
		{
			get
			{
				return this.nesting_type;
			}
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0012ADC8 File Offset: 0x00128FC8
		public override bool IsSubclassOf(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (c == this)
			{
				return false;
			}
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (c == baseType)
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06007E68 RID: 32360 RVA: 0x0012AE10 File Offset: 0x00129010
		public override Type UnderlyingSystemType
		{
			get
			{
				if (this.is_created)
				{
					return this.created.UnderlyingSystemType;
				}
				if (!this.IsEnum)
				{
					return this;
				}
				if (this.underlying_type != null)
				{
					return this.underlying_type;
				}
				throw new InvalidOperationException("Enumeration type is not defined.");
			}
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x0012AE50 File Offset: 0x00129050
		private ITypeName GetFullName()
		{
			ITypeIdentifier typeIdentifier = TypeIdentifiers.FromInternal(this.tname);
			if (this.nesting_type != null)
			{
				return TypeNames.FromDisplay(this.nesting_type.FullName).NestedName(typeIdentifier);
			}
			if (this.nspace != null && this.nspace.Length > 0)
			{
				return TypeIdentifiers.FromInternal(this.nspace, typeIdentifier);
			}
			return typeIdentifier;
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x0012AEB2 File Offset: 0x001290B2
		public override string FullName
		{
			get
			{
				return TypeNameBuilder.ToString(this, TypeNameBuilder.Format.FullName);
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0012AEBB File Offset: 0x001290BB
		public override Guid GUID
		{
			get
			{
				this.check_created();
				return this.created.GUID;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x0012AECE File Offset: 0x001290CE
		public override Module Module
		{
			get
			{
				return this.pmodule;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x0012AED6 File Offset: 0x001290D6
		public override string Name
		{
			get
			{
				return this.tname;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x0012AEDE File Offset: 0x001290DE
		public override string Namespace
		{
			get
			{
				return this.nspace;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x0012AEE6 File Offset: 0x001290E6
		protected override PackingSize PackingSizeCore
		{
			get
			{
				return this.packing_size;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0012AEEE File Offset: 0x001290EE
		protected override int SizeCore
		{
			get
			{
				return this.class_size;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x0012ADBE File Offset: 0x00128FBE
		public override Type ReflectedType
		{
			get
			{
				return this.nesting_type;
			}
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x0012AEF8 File Offset: 0x001290F8
		protected override void AddInterfaceImplementationCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type interfaceType)
		{
			this.check_not_created();
			if (this.interfaces != null)
			{
				Type[] array = this.interfaces;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == interfaceType)
					{
						return;
					}
				}
				Type[] array2 = new Type[this.interfaces.Length + 1];
				this.interfaces.CopyTo(array2, 0);
				array2[this.interfaces.Length] = interfaceType;
				this.interfaces = array2;
				return;
			}
			this.interfaces = new Type[1];
			this.interfaces[0] = interfaceType;
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x0012AF7C File Offset: 0x0012917C
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (!(this.created == typeof(object)))
			{
				return this.created.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
			}
			if (this.ctors == null)
			{
				return null;
			}
			ConstructorBuilder constructorBuilder = null;
			int num = 0;
			foreach (RuntimeConstructorBuilder runtimeConstructorBuilder in this.ctors)
			{
				if (callConvention == CallingConventions.Any || runtimeConstructorBuilder.CallingConvention == callConvention)
				{
					constructorBuilder = runtimeConstructorBuilder;
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (types != null)
			{
				MethodBase[] array2 = new MethodBase[num];
				if (num == 1)
				{
					array2[0] = constructorBuilder;
				}
				else
				{
					num = 0;
					foreach (RuntimeConstructorBuilder constructorInfo in this.ctors)
					{
						if (callConvention == CallingConventions.Any || constructorInfo.CallingConvention == callConvention)
						{
							array2[num++] = constructorInfo;
						}
					}
				}
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				return (ConstructorInfo)binder.SelectMethod(bindingAttr, array2, types, modifiers);
			}
			if (num > 1)
			{
				throw ThrowHelper.GetAmbiguousMatchException(constructorBuilder);
			}
			return constructorBuilder;
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x0012B078 File Offset: 0x00129278
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!this.is_created)
			{
				throw new NotSupportedException();
			}
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x0012B090 File Offset: 0x00129290
		public override object[] GetCustomAttributes(bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(inherit);
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0012B0A4 File Offset: 0x001292A4
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x0012B0BC File Offset: 0x001292BC
		protected override TypeBuilder DefineNestedTypeCore(string name, TypeAttributes attr, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, Type[] interfaces, PackingSize packSize, int typeSize)
		{
			if (interfaces != null)
			{
				foreach (Type type in interfaces)
				{
					ArgumentNullException.ThrowIfNull(type, "interfaces");
					if (type.IsByRef)
					{
						throw new ArgumentException("interfaces");
					}
				}
			}
			RuntimeTypeBuilder runtimeTypeBuilder = new RuntimeTypeBuilder(this.pmodule, name, attr, parent, interfaces, packSize, typeSize, this);
			runtimeTypeBuilder.fullname = runtimeTypeBuilder.GetFullName();
			this.pmodule.RegisterTypeName(runtimeTypeBuilder, runtimeTypeBuilder.fullname);
			if (this.subtypes != null)
			{
				RuntimeTypeBuilder[] array = new RuntimeTypeBuilder[this.subtypes.Length + 1];
				Array.Copy(this.subtypes, array, this.subtypes.Length);
				array[this.subtypes.Length] = runtimeTypeBuilder;
				this.subtypes = array;
			}
			else
			{
				this.subtypes = new RuntimeTypeBuilder[1];
				this.subtypes[0] = runtimeTypeBuilder;
			}
			return runtimeTypeBuilder;
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x0012B188 File Offset: 0x00129388
		protected override ConstructorBuilder DefineConstructorCore(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
		{
			this.check_not_created();
			if (base.IsInterface && (attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new InvalidOperationException();
			}
			RuntimeConstructorBuilder runtimeConstructorBuilder = new RuntimeConstructorBuilder(this, attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.ctors != null)
			{
				RuntimeConstructorBuilder[] array = new RuntimeConstructorBuilder[this.ctors.Length + 1];
				Array.Copy(this.ctors, array, this.ctors.Length);
				array[this.ctors.Length] = runtimeConstructorBuilder;
				this.ctors = array;
			}
			else
			{
				this.ctors = new RuntimeConstructorBuilder[1];
				this.ctors[0] = runtimeConstructorBuilder;
			}
			return runtimeConstructorBuilder;
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0012B214 File Offset: 0x00129414
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Reflection.Emit is not subject to trimming")]
		protected override ConstructorBuilder DefineDefaultConstructorCore(MethodAttributes attributes)
		{
			if (base.IsInterface)
			{
				throw new InvalidOperationException();
			}
			if ((attributes & (MethodAttributes.Static | MethodAttributes.Virtual)) > MethodAttributes.PrivateScope)
			{
				throw new ArgumentException(SR.Arg_NoStaticVirtual);
			}
			Type type;
			if (this.parent != null)
			{
				type = this.parent;
			}
			else
			{
				type = typeof(object);
			}
			Type type2 = type;
			type = type.InternalResolve();
			if (type == typeof(object) || type == typeof(ValueType))
			{
				type = type2;
			}
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor == null)
			{
				throw new NotSupportedException(SR.NotSupported_NoParentDefaultConstructor);
			}
			RuntimeConstructorBuilder runtimeConstructorBuilder = (RuntimeConstructorBuilder)base.DefineConstructor(attributes, CallingConventions.Standard, Type.EmptyTypes);
			ILGenerator ilgenerator = runtimeConstructorBuilder.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, constructor);
			ilgenerator.Emit(OpCodes.Ret);
			runtimeConstructorBuilder.finished = true;
			return runtimeConstructorBuilder;
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x0012B2F8 File Offset: 0x001294F8
		private void append_method(RuntimeMethodBuilder mb)
		{
			if (this.methods != null)
			{
				if (this.methods.Length == this.num_methods)
				{
					RuntimeMethodBuilder[] destinationArray = new RuntimeMethodBuilder[this.methods.Length * 2];
					Array.Copy(this.methods, destinationArray, this.num_methods);
					this.methods = destinationArray;
				}
			}
			else
			{
				this.methods = new RuntimeMethodBuilder[1];
			}
			this.methods[this.num_methods] = mb;
			this.num_methods++;
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0012B370 File Offset: 0x00129570
		protected override MethodBuilder DefineMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			RuntimeTypeBuilder.check_name("name", name);
			this.check_not_created();
			if (base.IsInterface && ((attributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope) && (attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException(SR.InvalidOperation_BadInterfaceNotAbstractAndVirtual);
			}
			if (returnType == null)
			{
				returnType = typeof(void);
			}
			RuntimeMethodBuilder runtimeMethodBuilder = new RuntimeMethodBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
			this.append_method(runtimeMethodBuilder);
			return runtimeMethodBuilder;
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0012B3E4 File Offset: 0x001295E4
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		protected override MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			RuntimeTypeBuilder.check_name("name", name);
			RuntimeTypeBuilder.check_name("dllName", dllName);
			RuntimeTypeBuilder.check_name("entryName", entryName);
			if ((attributes & MethodAttributes.Abstract) != MethodAttributes.PrivateScope)
			{
				throw new ArgumentException(SR.Argument_BadPInvokeMethod);
			}
			if (base.IsInterface)
			{
				throw new ArgumentException(SR.Argument_BadPInvokeOnInterface);
			}
			this.check_not_created();
			RuntimeMethodBuilder runtimeMethodBuilder = new RuntimeMethodBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, dllName, entryName, nativeCallConv, nativeCharSet);
			this.append_method(runtimeMethodBuilder);
			return runtimeMethodBuilder;
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x0012B468 File Offset: 0x00129668
		protected override void DefineMethodOverrideCore(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
		{
			this.check_not_created();
			if (methodInfoBody.DeclaringType != this)
			{
				throw new ArgumentException(SR.Argument_MethodBodyMustBelongToType);
			}
			RuntimeMethodBuilder runtimeMethodBuilder = methodInfoBody as RuntimeMethodBuilder;
			if (runtimeMethodBuilder != null)
			{
				runtimeMethodBuilder.set_override(methodInfoDeclaration);
			}
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0012B4A8 File Offset: 0x001296A8
		protected override FieldBuilder DefineFieldCore(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
		{
			RuntimeTypeBuilder.check_name("fieldName", fieldName);
			if (type == typeof(void))
			{
				throw new ArgumentException(SR.Argument_BadFieldType);
			}
			this.check_not_created();
			RuntimeFieldBuilder runtimeFieldBuilder = new RuntimeFieldBuilder(this, fieldName, type, attributes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.fields != null)
			{
				if (this.fields.Length == this.num_fields)
				{
					RuntimeFieldBuilder[] destinationArray = new RuntimeFieldBuilder[this.fields.Length * 2];
					Array.Copy(this.fields, destinationArray, this.num_fields);
					this.fields = destinationArray;
				}
				this.fields[this.num_fields] = runtimeFieldBuilder;
				this.num_fields++;
			}
			else
			{
				this.fields = new RuntimeFieldBuilder[1];
				this.fields[0] = runtimeFieldBuilder;
				this.num_fields++;
			}
			if (this.IsEnum && this.underlying_type == null && (attributes & FieldAttributes.Static) == FieldAttributes.PrivateScope)
			{
				this.underlying_type = type;
			}
			return runtimeFieldBuilder;
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0012B598 File Offset: 0x00129798
		protected override PropertyBuilder DefinePropertyCore(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			RuntimeTypeBuilder.check_name("name", name);
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					ArgumentNullException.ThrowIfNull(parameterTypes[i], "parameterTypes");
				}
			}
			this.check_not_created();
			RuntimePropertyBuilder runtimePropertyBuilder = new RuntimePropertyBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
			if (this.properties != null)
			{
				Array.Resize<RuntimePropertyBuilder>(ref this.properties, this.properties.Length + 1);
				this.properties[this.properties.Length - 1] = runtimePropertyBuilder;
			}
			else
			{
				this.properties = new RuntimePropertyBuilder[]
				{
					runtimePropertyBuilder
				};
			}
			return runtimePropertyBuilder;
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0012B630 File Offset: 0x00129830
		protected override ConstructorBuilder DefineTypeInitializerCore()
		{
			return base.DefineConstructor(MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, null);
		}

		// Token: 0x06007E81 RID: 32385
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2110:ReflectionToDynamicallyAccessedMembers", Justification = "For instance member internal calls, the linker preserves all fields of the declaring type. The parent and created fields have DynamicallyAccessedMembersAttribute requirements, but creating the runtime class is safe because the annotations fully preserve the parent type, and the type created via Reflection.Emit is not subject to trimming.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		private extern TypeInfo create_runtime_class();

		// Token: 0x06007E82 RID: 32386 RVA: 0x0012B63F File Offset: 0x0012983F
		private bool is_nested_in(Type t)
		{
			while (t != null)
			{
				if (t == this)
				{
					return true;
				}
				t = t.DeclaringType;
			}
			return false;
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0012B660 File Offset: 0x00129860
		private bool has_ctor_method()
		{
			MethodAttributes methodAttributes = MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
			for (int i = 0; i < this.num_methods; i++)
			{
				MethodBuilder methodBuilder = this.methods[i];
				if (methodBuilder.Name == ConstructorInfo.ConstructorName && (methodBuilder.Attributes & methodAttributes) == methodAttributes)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0012B6B0 File Offset: 0x001298B0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2083:UnrecognizedReflectionPattern", Justification = "Reflection.Emit is not subject to trimming")]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		protected override TypeInfo CreateTypeInfoCore()
		{
			if (this.createTypeCalled)
			{
				return this.created;
			}
			if (!base.IsInterface && this.parent == null && this != typeof(object) && this.FullName != "<Module>")
			{
				base.SetParent(typeof(object));
			}
			if (this.fields != null)
			{
				foreach (RuntimeFieldBuilder runtimeFieldBuilder in this.fields)
				{
					if (!(runtimeFieldBuilder == null))
					{
						Type fieldType = runtimeFieldBuilder.FieldType;
						if (!runtimeFieldBuilder.IsStatic)
						{
							RuntimeTypeBuilder runtimeTypeBuilder = fieldType as RuntimeTypeBuilder;
							if (runtimeTypeBuilder != null && fieldType.IsValueType && fieldType != this && this.is_nested_in(fieldType) && !runtimeTypeBuilder.is_created)
							{
								throw new NotImplementedException();
							}
						}
					}
				}
			}
			if (this.parent != null)
			{
				if (this.parent.IsByRef)
				{
					throw new NotSupportedException();
				}
				if (base.IsInterface)
				{
					throw new TypeLoadException();
				}
			}
			if (!base.IsInterface && !base.IsValueType && this.ctors == null && this.tname != "<Module>" && ((this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) | TypeAttributes.Sealed) != (TypeAttributes.Abstract | TypeAttributes.Sealed) && !this.has_ctor_method())
			{
				base.DefineDefaultConstructor(MethodAttributes.Public);
			}
			this.createTypeCalled = true;
			if (this.parent != null)
			{
				if (this.parent.IsSealed)
				{
					throw new TypeLoadException(SR.Format(SR.TypeLoad_AssemblySealedParentTypeError, this.fullname.DisplayName, this.Assembly));
				}
				if (this.parent.IsGenericTypeDefinition)
				{
					throw new BadImageFormatException();
				}
			}
			if (this.parent == typeof(Enum) && this.methods != null)
			{
				throw new TypeLoadException(SR.Format(SR.TypeLoad_AssemblyEnumContainsMethodsError, this.fullname.DisplayName, this.Assembly));
			}
			if (this.interfaces != null)
			{
				foreach (Type type in this.interfaces)
				{
					if (type.IsNestedPrivate && type.Assembly != this.Assembly)
					{
						throw new TypeLoadException(SR.Format(SR.TypeLoad_AssemblyInaccessibleInterfaceError, this.fullname.DisplayName, this.Assembly, type.FullName));
					}
					if (type.IsGenericTypeDefinition)
					{
						throw new BadImageFormatException();
					}
					if (!type.IsInterface)
					{
						throw new TypeLoadException();
					}
					RuntimeTypeBuilder runtimeTypeBuilder2 = type as RuntimeTypeBuilder;
					if (runtimeTypeBuilder2 != null && !runtimeTypeBuilder2.is_created)
					{
						throw new TypeLoadException();
					}
				}
			}
			if (this.methods != null)
			{
				bool flag = !base.IsAbstract;
				for (int j = 0; j < this.num_methods; j++)
				{
					RuntimeMethodBuilder runtimeMethodBuilder = this.methods[j];
					if (flag && runtimeMethodBuilder.IsAbstract)
					{
						throw new InvalidOperationException(SR.Format(SR.InvalidOperation_AbstractMethod, runtimeMethodBuilder));
					}
					runtimeMethodBuilder.check_override();
					runtimeMethodBuilder.fixup();
				}
			}
			if (this.ctors != null)
			{
				RuntimeConstructorBuilder[] array3 = this.ctors;
				for (int i = 0; i < array3.Length; i++)
				{
					array3[i].fixup();
				}
			}
			this.ResolveUserTypes();
			this.created = this.create_runtime_class();
			if (this.is_hidden_global_type)
			{
				return null;
			}
			if (this.created != null)
			{
				return this.created;
			}
			return this;
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x0012BA04 File Offset: 0x00129C04
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2074:UnrecognizedReflectionPattern", Justification = "Linker doesn't analyze ResolveUserType but it's an identity function")]
		private void ResolveUserTypes()
		{
			this.parent = RuntimeTypeBuilder.ResolveUserType(this.parent);
			RuntimeTypeBuilder.ResolveUserTypes(this.interfaces);
			if (this.fields != null)
			{
				foreach (RuntimeFieldBuilder runtimeFieldBuilder in this.fields)
				{
					if (runtimeFieldBuilder != null)
					{
						runtimeFieldBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.methods != null)
			{
				foreach (RuntimeMethodBuilder runtimeMethodBuilder in this.methods)
				{
					if (runtimeMethodBuilder != null)
					{
						runtimeMethodBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.ctors != null)
			{
				foreach (RuntimeConstructorBuilder runtimeConstructorBuilder in this.ctors)
				{
					if (runtimeConstructorBuilder != null)
					{
						runtimeConstructorBuilder.ResolveUserTypes();
					}
				}
			}
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0012BAB0 File Offset: 0x00129CB0
		internal static void ResolveUserTypes(Type[] types)
		{
			if (types != null)
			{
				for (int i = 0; i < types.Length; i++)
				{
					types[i] = RuntimeTypeBuilder.ResolveUserType(types[i]);
				}
			}
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x0012BADC File Offset: 0x00129CDC
		[return: NotNullIfNotNull("t")]
		internal static Type ResolveUserType(Type t)
		{
			if (!(t != null) || (!(t.GetType().Assembly != typeof(int).Assembly) && !(t is TypeDelegator)))
			{
				return t;
			}
			t = t.UnderlyingSystemType;
			if (t != null && (t.GetType().Assembly != typeof(int).Assembly || t is TypeDelegator))
			{
				throw new NotSupportedException(SR.PlatformNotSupported_UserDefinedSubclassesOfType);
			}
			return t;
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0012BB63 File Offset: 0x00129D63
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetConstructors(bindingAttr);
			}
			throw new NotSupportedException();
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0001A563 File Offset: 0x00018763
		public override Type GetElementType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0012BB7F File Offset: 0x00129D7F
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetEvent(name, bindingAttr);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0001A7A4 File Offset: 0x000189A4
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public override EventInfo[] GetEvents()
		{
			return this.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0012BB94 File Offset: 0x00129D94
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetEvents(bindingAttr);
			}
			throw new NotSupportedException();
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0012BBB0 File Offset: 0x00129DB0
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetField(name, bindingAttr);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x0012BBC5 File Offset: 0x00129DC5
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetFields(bindingAttr);
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x0012BBD9 File Offset: 0x00129DD9
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type GetInterface(string name, bool ignoreCase)
		{
			this.check_created();
			return this.created.GetInterface(name, ignoreCase);
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x0012BBF0 File Offset: 0x00129DF0
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public override Type[] GetInterfaces()
		{
			if (this.is_created)
			{
				return this.created.GetInterfaces();
			}
			if (this.interfaces != null)
			{
				Type[] array = new Type[this.interfaces.Length];
				this.interfaces.CopyTo(array, 0);
				return array;
			}
			return Type.EmptyTypes;
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0012BC3B File Offset: 0x00129E3B
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetMember(name, type, bindingAttr);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0012BC51 File Offset: 0x00129E51
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetMembers(bindingAttr);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x0012BC68 File Offset: 0x00129E68
		private MethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase)
		{
			MethodInfo[] array2;
			if ((bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.Default && this.parent != null)
			{
				MethodInfo[] array = this.parent.GetMethods(bindingAttr);
				List<MethodInfo> list = new List<MethodInfo>(array.Length);
				bool flag = (bindingAttr & BindingFlags.FlattenHierarchy) > BindingFlags.Default;
				foreach (MethodInfo methodInfo in array)
				{
					MethodAttributes attributes = methodInfo.Attributes;
					if (!methodInfo.IsStatic || flag)
					{
						MethodAttributes methodAttributes = attributes & MethodAttributes.MemberAccessMask;
						bool flag2;
						if (methodAttributes != MethodAttributes.Private)
						{
							if (methodAttributes != MethodAttributes.Assembly)
							{
								if (methodAttributes == MethodAttributes.Public)
								{
									flag2 = ((bindingAttr & BindingFlags.Public) > BindingFlags.Default);
								}
								else
								{
									flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
								}
							}
							else
							{
								flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
							}
						}
						else
						{
							flag2 = false;
						}
						bool flag3 = flag2;
						if (flag3)
						{
							list.Add(methodInfo);
						}
					}
				}
				if (this.methods == null)
				{
					array2 = new MethodInfo[list.Count];
					list.CopyTo(array2);
				}
				else
				{
					array2 = new MethodInfo[this.methods.Length + list.Count];
					list.CopyTo(array2, 0);
					this.methods.CopyTo(array2, list.Count);
				}
			}
			else
			{
				MethodInfo[] array3 = this.methods;
				array2 = array3;
			}
			if (array2 == null)
			{
				return Array.Empty<MethodInfo>();
			}
			List<MethodInfo> list2 = new List<MethodInfo>();
			foreach (MethodInfo methodInfo2 in array2)
			{
				if (!(methodInfo2 == null) && (name == null || string.Compare(methodInfo2.Name, name, ignoreCase) == 0))
				{
					bool flag3 = false;
					MethodAttributes attributes = methodInfo2.Attributes;
					if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag3 = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag3 = true;
					}
					if (flag3)
					{
						flag3 = false;
						if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag3 = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag3 = true;
						}
						if (flag3)
						{
							list2.Add(methodInfo2);
						}
					}
				}
			}
			return list2.ToArray();
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0012BE1B File Offset: 0x0012A01B
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			this.check_created();
			return this.GetMethodsByName(null, bindingAttr, false);
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x0012BE2C File Offset: 0x0012A02C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (types == null)
			{
				return this.created.GetMethod(name, bindingAttr);
			}
			return this.created.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x0012BE5C File Offset: 0x0012A05C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			if (this.subtypes == null)
			{
				return null;
			}
			foreach (RuntimeTypeBuilder runtimeTypeBuilder in this.subtypes)
			{
				if (runtimeTypeBuilder.is_created)
				{
					if ((runtimeTypeBuilder.attrs & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
					{
						if ((bindingAttr & BindingFlags.Public) == BindingFlags.Default)
						{
							goto IL_55;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) == BindingFlags.Default)
					{
						goto IL_55;
					}
					if (runtimeTypeBuilder.Name == name)
					{
						return runtimeTypeBuilder.created;
					}
				}
				IL_55:;
			}
			return null;
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x0012BECC File Offset: 0x0012A0CC
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			if (!this.is_created)
			{
				throw new NotSupportedException();
			}
			List<Type> list = new List<Type>();
			if (this.subtypes == null)
			{
				return Type.EmptyTypes;
			}
			foreach (RuntimeTypeBuilder runtimeTypeBuilder in this.subtypes)
			{
				bool flag = false;
				if ((runtimeTypeBuilder.attrs & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
				{
					if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
					{
						flag = true;
					}
				}
				else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
				{
					flag = true;
				}
				if (flag)
				{
					list.Add(runtimeTypeBuilder);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0012BF46 File Offset: 0x0012A146
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetProperties(bindingAttr);
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x0012BF5A File Offset: 0x0012A15A
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw RuntimeTypeBuilder.not_supported();
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0012BF61 File Offset: 0x0012A161
		protected override bool HasElementTypeImpl()
		{
			return this.is_created && this.created.HasElementType;
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0012BF78 File Offset: 0x0012A178
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			this.check_created();
			return this.created.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0001A59D File Offset: 0x0001879D
		protected override bool IsCOMObjectImpl()
		{
			return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x00007B65 File Offset: 0x00005D65
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x0012BFA4 File Offset: 0x0012A1A4
		protected override bool IsValueTypeImpl()
		{
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (baseType == typeof(ValueType))
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x0012BFE0 File Offset: 0x0012A1E0
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			if (!this.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
			}
			ArgumentNullException.ThrowIfNull(typeArguments, "typeArguments");
			if (this.generic_params.Length != typeArguments.Length)
			{
				throw new ArgumentException(SR.Format(SR.Argument_NotEnoughGenArguments, this.generic_params.Length, typeArguments.Length), "typeArguments");
			}
			for (int i = 0; i < typeArguments.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(typeArguments[i], "typeArguments");
			}
			Type[] array = new Type[typeArguments.Length];
			typeArguments.CopyTo(array, 0);
			return RuntimeAssemblyBuilder.MakeGenericType(this, array);
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0012C077 File Offset: 0x0012A277
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				this.check_created();
				return this.created.TypeHandle;
			}
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x0012C08A File Offset: 0x0012A28A
		internal void SetCustomAttribute(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0012C094 File Offset: 0x0012A294
		protected unsafe override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			string fullName = con.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.StructLayoutAttribute")
			{
				int num = (int)(*binaryAttribute[2]) | (int)(*binaryAttribute[3]) << 8;
				this.attrs &= ~TypeAttributes.LayoutMask;
				TypeAttributes typeAttributes = this.attrs;
				TypeAttributes typeAttributes2;
				switch (num)
				{
				case 0:
					typeAttributes2 = TypeAttributes.SequentialLayout;
					goto IL_7E;
				case 2:
					typeAttributes2 = TypeAttributes.ExplicitLayout;
					goto IL_7E;
				case 3:
					typeAttributes2 = TypeAttributes.NotPublic;
					goto IL_7E;
				}
				throw new Exception(SR.Argument_InvalidKindOfTypeForCA);
				IL_7E:
				this.attrs = (typeAttributes | typeAttributes2);
				RuntimeConstructorBuilder runtimeConstructorBuilder = con as RuntimeConstructorBuilder;
				Type type = (runtimeConstructorBuilder != null) ? runtimeConstructorBuilder.parameters[0] : con.GetParametersInternal()[0].ParameterType;
				int num2 = 6;
				if (type.FullName == "System.Int16")
				{
					num2 = 4;
				}
				int num3 = (int)BinaryPrimitives.ReadUInt16LittleEndian(binaryAttribute.Slice(num2++));
				num2++;
				for (int i = 0; i < num3; i++)
				{
					num2++;
					int num4;
					if (*binaryAttribute[num2++] == 85)
					{
						num4 = CustomAttributeBuilder.decode_len(binaryAttribute, num2, out num2);
						CustomAttributeBuilder.string_from_bytes(binaryAttribute, num2, num4);
						num2 += num4;
					}
					num4 = CustomAttributeBuilder.decode_len(binaryAttribute, num2, out num2);
					string a = CustomAttributeBuilder.string_from_bytes(binaryAttribute, num2, num4);
					num2 += num4;
					int num5 = BinaryPrimitives.ReadInt32LittleEndian(binaryAttribute.Slice(num2++));
					num2 += 3;
					if (!(a == "CharSet"))
					{
						if (!(a == "Pack"))
						{
							if (a == "Size")
							{
								this.class_size = num5;
							}
						}
						else
						{
							this.packing_size = (PackingSize)num5;
						}
					}
					else
					{
						switch (num5)
						{
						case 1:
						case 2:
							this.attrs &= ~TypeAttributes.StringFormatMask;
							break;
						case 3:
							this.attrs &= ~TypeAttributes.AutoClass;
							this.attrs |= TypeAttributes.UnicodeClass;
							break;
						case 4:
							this.attrs &= ~TypeAttributes.UnicodeClass;
							this.attrs |= TypeAttributes.AutoClass;
							break;
						}
					}
				}
				return;
			}
			if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= TypeAttributes.SpecialName;
				return;
			}
			if (fullName == "System.SerializableAttribute")
			{
				this.attrs |= TypeAttributes.Serializable;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.ComImportAttribute")
			{
				this.attrs |= TypeAttributes.Import;
				return;
			}
			if (fullName == "System.Security.SuppressUnmanagedCodeSecurityAttribute")
			{
				this.attrs |= TypeAttributes.HasSecurity;
			}
			else if (fullName == "System.Runtime.CompilerServices.IsByRefLikeAttribute")
			{
				this.is_byreflike_set = 1;
			}
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

		// Token: 0x06007EA7 RID: 32423 RVA: 0x0012C3A4 File Offset: 0x0012A5A4
		protected override EventBuilder DefineEventCore(string name, EventAttributes attributes, Type eventtype)
		{
			RuntimeTypeBuilder.check_name("name", name);
			ArgumentNullException.ThrowIfNull(eventtype, "eventtype");
			this.check_not_created();
			RuntimeEventBuilder runtimeEventBuilder = new RuntimeEventBuilder(this, name, attributes, eventtype);
			if (this.events != null)
			{
				RuntimeEventBuilder[] array = new RuntimeEventBuilder[this.events.Length + 1];
				Array.Copy(this.events, array, this.events.Length);
				array[this.events.Length] = runtimeEventBuilder;
				this.events = array;
			}
			else
			{
				this.events = new RuntimeEventBuilder[1];
				this.events[0] = runtimeEventBuilder;
			}
			return runtimeEventBuilder;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0012C42D File Offset: 0x0012A62D
		protected override FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes)
		{
			RuntimeFieldBuilder runtimeFieldBuilder = (RuntimeFieldBuilder)base.DefineUninitializedData(name, data.Length, attributes);
			runtimeFieldBuilder.SetRVAData(data);
			return runtimeFieldBuilder;
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0012C448 File Offset: 0x0012A648
		protected override FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			if (size <= 0 || size > 4128768)
			{
				throw new ArgumentException(SR.Argument_BadSizeForData);
			}
			this.check_not_created();
			string text = "$ArrayType$" + size.ToString();
			ITypeIdentifier innerName = TypeIdentifiers.WithoutEscape(text);
			Type type = this.pmodule.GetRegisteredType(this.fullname.NestedName(innerName));
			if (type == null)
			{
				TypeBuilder typeBuilder = this.DefineNestedTypeCore(text, TypeAttributes.Public | TypeAttributes.NestedPublic | TypeAttributes.ExplicitLayout | TypeAttributes.Sealed, typeof(ValueType), null, RuntimeFieldBuilder.RVADataPackingSize(size), size);
				typeBuilder.CreateType();
				type = typeBuilder;
			}
			return base.DefineField(name, type, attributes | FieldAttributes.Static | FieldAttributes.HasFieldRVA);
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x0012C4EF File Offset: 0x0012A6EF
		public override int MetadataToken
		{
			get
			{
				return 33554432 | this.table_idx;
			}
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0012C500 File Offset: 0x0012A700
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2074:UnrecognizedReflectionPattern", Justification = "Linker doesn't analyze ResolveUserType but it's an identity function")]
		protected override void SetParentCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent)
		{
			this.check_not_created();
			if (parent == null)
			{
				if ((this.attrs & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic)
				{
					if ((this.attrs & TypeAttributes.Abstract) == TypeAttributes.NotPublic)
					{
						throw new InvalidOperationException(SR.InvalidOperation_BadInterfaceNotAbstract);
					}
					this.parent = null;
				}
				else
				{
					this.parent = typeof(object);
				}
			}
			else
			{
				if (parent.IsInterface)
				{
					throw new ArgumentException(SR.Argument_CannotSetParentToInterface);
				}
				this.parent = parent;
			}
			this.parent = RuntimeTypeBuilder.ResolveUserType(this.parent);
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x0012C586 File Offset: 0x0012A786
		internal int get_next_table_index(int table, int count)
		{
			return this.pmodule.get_next_table_index(table, count);
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x0012C595 File Offset: 0x0012A795
		public override InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			if (this.created == null)
			{
				throw new NotSupportedException(SR.NotSupported_IncompleteTypes);
			}
			return this.created.GetInterfaceMap(interfaceType);
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0012C5BC File Offset: 0x0012A7BC
		internal override Type InternalResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x0012C5BC File Offset: 0x0012A7BC
		internal override Type RuntimeResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x0012C5CA File Offset: 0x0012A7CA
		internal bool is_created
		{
			get
			{
				return this.createTypeCalled;
			}
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x00126C2D File Offset: 0x00124E2D
		private static NotSupportedException not_supported()
		{
			return new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0012C5D2 File Offset: 0x0012A7D2
		internal void check_not_created()
		{
			if (this.is_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_TypeHasBeenCreated);
			}
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0012C5E7 File Offset: 0x0012A7E7
		private void check_created()
		{
			if (!this.is_created)
			{
				throw RuntimeTypeBuilder.not_supported();
			}
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0012C5F7 File Offset: 0x0012A7F7
		private static void check_name(string argName, string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, argName);
			if (name[0] == '\0')
			{
				throw new ArgumentException(SR.Argument_EmptyName, argName);
			}
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x0012C615 File Offset: 0x0012A815
		public override string ToString()
		{
			return this.FullName;
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x0012C61D File Offset: 0x0012A81D
		public override bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			return base.IsAssignableFrom(c);
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x0012C628 File Offset: 0x0012A828
		internal bool IsAssignableToInternal([NotNullWhen(true)] Type c)
		{
			if (c == this)
			{
				return true;
			}
			if (c.IsInterface)
			{
				if (this.parent != null && this.is_created && c.IsAssignableFrom(this.parent))
				{
					return true;
				}
				if (this.interfaces == null)
				{
					return false;
				}
				foreach (Type c2 in this.interfaces)
				{
					if (c.IsAssignableFrom(c2))
					{
						return true;
					}
				}
				if (!this.is_created)
				{
					return false;
				}
			}
			if (this.parent == null)
			{
				return c == typeof(object);
			}
			return c.IsAssignableFrom(this.parent);
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x0012C6D1 File Offset: 0x0012A8D1
		protected override bool IsCreatedCore()
		{
			return this.is_created;
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x0012C6DC File Offset: 0x0012A8DC
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return Type.EmptyTypes;
			}
			Type[] array = new Type[this.generic_params.Length];
			this.generic_params.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x0012C713 File Offset: 0x0012A913
		public override Type GetGenericTypeDefinition()
		{
			if (this.generic_params == null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
			}
			return this;
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x0012C729 File Offset: 0x0012A929
		public override bool ContainsGenericParameters
		{
			get
			{
				return this.generic_params != null;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00007B65 File Offset: 0x00005D65
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return GenericParameterAttributes.None;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06007EBE RID: 32446 RVA: 0x0012C729 File Offset: 0x0012A929
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06007EBF RID: 32447 RVA: 0x0012C734 File Offset: 0x0012A934
		public override bool IsGenericType
		{
			get
			{
				return this.IsGenericTypeDefinition;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int GenericParameterPosition
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x0012C73C File Offset: 0x0012A93C
		protected override GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names)
		{
			this.generic_params = new RuntimeGenericTypeParameterBuilder[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				ArgumentNullException.ThrowIfNull(text, "names");
				this.generic_params[i] = new RuntimeGenericTypeParameterBuilder(this, null, text, i);
			}
			return this.generic_params;
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x000070DD File Offset: 0x000052DD
		internal override bool IsTypeBuilder()
		{
			return true;
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06007EC5 RID: 32453 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x0012C78D File Offset: 0x0012A98D
		public override bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			return base.IsAssignableFrom(typeInfo);
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x0012C798 File Offset: 0x0012A998
		internal static bool SetConstantValue(Type destType, object value, ref object destValue)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (destType.IsByRef)
				{
					destType = destType.GetElementType();
				}
				destType = (Nullable.GetUnderlyingType(destType) ?? destType);
				if (destType.IsEnum)
				{
					RuntimeEnumBuilder runtimeEnumBuilder = destType as RuntimeEnumBuilder;
					Type type2;
					if (runtimeEnumBuilder != null)
					{
						type2 = runtimeEnumBuilder.GetEnumUnderlyingType();
						if ((!runtimeEnumBuilder.GetTypeBuilder().is_created || !(type == runtimeEnumBuilder.GetTypeBuilder().created)) && !(type == type2))
						{
							RuntimeTypeBuilder.throw_argument_ConstantDoesntMatch();
						}
					}
					else
					{
						RuntimeTypeBuilder runtimeTypeBuilder = destType as RuntimeTypeBuilder;
						if (runtimeTypeBuilder != null)
						{
							type2 = runtimeTypeBuilder.underlying_type;
							if (type2 == null || (type != runtimeTypeBuilder.UnderlyingSystemType && type != type2))
							{
								RuntimeTypeBuilder.throw_argument_ConstantDoesntMatch();
							}
						}
						else
						{
							type2 = Enum.GetUnderlyingType(destType);
							if (type != destType && type != type2)
							{
								RuntimeTypeBuilder.throw_argument_ConstantDoesntMatch();
							}
						}
					}
					type = type2;
				}
				else if (!destType.IsAssignableFrom(type))
				{
					RuntimeTypeBuilder.throw_argument_ConstantDoesntMatch();
				}
				switch (Type.GetTypeCode(type))
				{
				case TypeCode.Boolean:
				case TypeCode.Char:
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
					destValue = value;
					return true;
				case TypeCode.DateTime:
				{
					long ticks = ((DateTime)value).Ticks;
					destValue = ticks;
					return true;
				}
				case TypeCode.String:
					destValue = value;
					return true;
				}
				throw new ArgumentException(SR.Format(SR.Argument_ConstantNotSupported, type));
			}
			destValue = null;
			return true;
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x0012C913 File Offset: 0x0012AB13
		private static void throw_argument_ConstantDoesntMatch()
		{
			throw new ArgumentException(SR.Argument_ConstantDoesntMatch);
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsTypeDefinition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06007ECA RID: 32458 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsByRefLike
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001866 RID: 6246
		private string tname;

		// Token: 0x04001867 RID: 6247
		private string nspace;

		// Token: 0x04001868 RID: 6248
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		private Type parent;

		// Token: 0x04001869 RID: 6249
		private Type nesting_type;

		// Token: 0x0400186A RID: 6250
		internal Type[] interfaces;

		// Token: 0x0400186B RID: 6251
		internal int num_methods;

		// Token: 0x0400186C RID: 6252
		internal RuntimeMethodBuilder[] methods;

		// Token: 0x0400186D RID: 6253
		internal RuntimeConstructorBuilder[] ctors;

		// Token: 0x0400186E RID: 6254
		internal RuntimePropertyBuilder[] properties;

		// Token: 0x0400186F RID: 6255
		internal int num_fields;

		// Token: 0x04001870 RID: 6256
		internal RuntimeFieldBuilder[] fields;

		// Token: 0x04001871 RID: 6257
		internal RuntimeEventBuilder[] events;

		// Token: 0x04001872 RID: 6258
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001873 RID: 6259
		internal RuntimeTypeBuilder[] subtypes;

		// Token: 0x04001874 RID: 6260
		internal TypeAttributes attrs;

		// Token: 0x04001875 RID: 6261
		private int table_idx;

		// Token: 0x04001876 RID: 6262
		private RuntimeModuleBuilder pmodule;

		// Token: 0x04001877 RID: 6263
		private int class_size;

		// Token: 0x04001878 RID: 6264
		private PackingSize packing_size;

		// Token: 0x04001879 RID: 6265
		private IntPtr generic_container;

		// Token: 0x0400187A RID: 6266
		private RuntimeGenericTypeParameterBuilder[] generic_params;

		// Token: 0x0400187B RID: 6267
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		private TypeInfo created;

		// Token: 0x0400187C RID: 6268
		private int is_byreflike_set;

		// Token: 0x0400187D RID: 6269
		private int state;

		// Token: 0x0400187E RID: 6270
		internal bool is_hidden_global_type;

		// Token: 0x0400187F RID: 6271
		private ITypeName fullname;

		// Token: 0x04001880 RID: 6272
		private bool createTypeCalled;

		// Token: 0x04001881 RID: 6273
		private Type underlying_type;
	}
}

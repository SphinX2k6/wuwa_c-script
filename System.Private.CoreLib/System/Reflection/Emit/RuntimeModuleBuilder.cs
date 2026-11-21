using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B2 RID: 1970
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeModuleBuilder : ModuleBuilder
	{
		// Token: 0x06007DF4 RID: 32244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(RuntimeModuleBuilder ab);

		// Token: 0x06007DF5 RID: 32245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_wrappers_type(RuntimeModuleBuilder mb, Type ab);

		// Token: 0x06007DF6 RID: 32246 RVA: 0x00129944 File Offset: 0x00127B44
		[DynamicDependency("table_indexes")]
		internal RuntimeModuleBuilder(RuntimeAssemblyBuilder assb, string name)
		{
			this.scopename = name;
			this.name = name;
			this.fqname = name;
			this.assemblyb = assb;
			this.assembly = assb;
			this.guid = Guid.NewGuid().ToByteArray();
			this.table_idx = this.get_next_table_index(0, 1);
			this.name_cache = new Dictionary<ITypeName, RuntimeTypeBuilder>();
			this.us_string_cache = new Dictionary<string, int>(512);
			this.global_type_created = false;
			RuntimeModuleBuilder.basic_init(this);
			this.CreateGlobalType();
			Type ab = new RuntimeTypeBuilder(this, TypeAttributes.Abstract, 16777215, false).CreateTypeInfo();
			RuntimeModuleBuilder.set_wrappers_type(this, ab);
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x001299EC File Offset: 0x00127BEC
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public override string FullyQualifiedName
		{
			get
			{
				string text = this.fqname;
				if (text == null)
				{
					return null;
				}
				return text;
			}
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x00129A06 File Offset: 0x00127C06
		protected override void CreateGlobalFunctionsCore()
		{
			if (this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_GlobalsHaveBeenCreated);
			}
			if (this.global_type != null)
			{
				this.global_type_created = true;
				this.global_type.CreateTypeInfo();
			}
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x00129A3C File Offset: 0x00127C3C
		protected override FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes)
		{
			ArgumentNullException.ThrowIfNull(data, "data");
			FieldAttributes fieldAttributes = attributes & ~(FieldAttributes.RTSpecialName | FieldAttributes.HasFieldMarshal | FieldAttributes.HasDefault | FieldAttributes.HasFieldRVA);
			RuntimeFieldBuilder runtimeFieldBuilder = (RuntimeFieldBuilder)this.DefineDataImpl(name, data.Length, fieldAttributes | FieldAttributes.HasFieldRVA);
			runtimeFieldBuilder.SetRVAData(data);
			return runtimeFieldBuilder;
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x00129A79 File Offset: 0x00127C79
		protected override FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes)
		{
			return this.DefineDataImpl(name, size, attributes & ~(FieldAttributes.RTSpecialName | FieldAttributes.HasFieldMarshal | FieldAttributes.HasDefault | FieldAttributes.HasFieldRVA));
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x00129A8C File Offset: 0x00127C8C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Reflection.Emit is not subject to trimming")]
		private FieldBuilder DefineDataImpl(string name, int size, FieldAttributes attributes)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			if (this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_GlobalsHaveBeenCreated);
			}
			if (size <= 0 || size >= 4128768)
			{
				throw new ArgumentException(SR.Argument_BadSizeForData, null);
			}
			this.CreateGlobalType();
			string className = "$ArrayType$" + size.ToString();
			Type type = this.GetType(className, false, false);
			if (type == null)
			{
				RuntimeTypeBuilder runtimeTypeBuilder = this.DefineType(className, TypeAttributes.Public | TypeAttributes.ExplicitLayout | TypeAttributes.Sealed, typeof(ValueType), null, RuntimeFieldBuilder.RVADataPackingSize(size), size);
				runtimeTypeBuilder.CreateType();
				type = runtimeTypeBuilder;
			}
			FieldBuilder fieldBuilder = this.global_type.DefineField(name, type, attributes | FieldAttributes.Static);
			if (this.global_fields != null)
			{
				FieldBuilder[] array = new FieldBuilder[this.global_fields.Length + 1];
				Array.Copy(this.global_fields, array, this.global_fields.Length);
				array[this.global_fields.Length] = fieldBuilder;
				object[] array2 = array;
				this.global_fields = array2;
			}
			else
			{
				object[] array2 = new FieldBuilder[]
				{
					fieldBuilder
				};
				this.global_fields = array2;
			}
			return fieldBuilder;
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x00129B8C File Offset: 0x00127D8C
		private void addGlobalMethod(MethodBuilder mb)
		{
			object[] array2;
			if (this.global_methods != null)
			{
				MethodBuilder[] array = new MethodBuilder[this.global_methods.Length + 1];
				Array.Copy(this.global_methods, array, this.global_methods.Length);
				array[this.global_methods.Length] = mb;
				array2 = array;
				this.global_methods = array2;
				return;
			}
			array2 = new MethodBuilder[]
			{
				mb
			};
			this.global_methods = array2;
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x00129BEC File Offset: 0x00127DEC
		protected override MethodBuilder DefineGlobalMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
		{
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException(SR.Argument_GlobalMembersMustBeStatic);
			}
			if (this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_GlobalsHaveBeenCreated);
			}
			this.CreateGlobalType();
			MethodBuilder methodBuilder = this.global_type.DefineMethod(name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
			this.addGlobalMethod(methodBuilder);
			return methodBuilder;
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x00129C48 File Offset: 0x00127E48
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		protected override MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException(SR.Argument_GlobalMembersMustBeStatic);
			}
			if (this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_GlobalsHaveBeenCreated);
			}
			this.CreateGlobalType();
			MethodBuilder methodBuilder = this.global_type.DefinePInvokeMethod(name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
			this.addGlobalMethod(methodBuilder);
			return methodBuilder;
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x00129CB0 File Offset: 0x00127EB0
		private void AddType(RuntimeTypeBuilder tb)
		{
			if (this.types != null)
			{
				if (this.types.Length == this.num_types)
				{
					RuntimeTypeBuilder[] destinationArray = new RuntimeTypeBuilder[this.types.Length * 2];
					Array.Copy(this.types, destinationArray, this.num_types);
					this.types = destinationArray;
				}
			}
			else
			{
				this.types = new RuntimeTypeBuilder[1];
			}
			this.types[this.num_types] = tb;
			this.num_types++;
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00129D28 File Offset: 0x00127F28
		private RuntimeTypeBuilder DefineType(string name, TypeAttributes attr, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, Type[] interfaces, PackingSize packingSize, int typesize)
		{
			ITypeIdentifier key = TypeIdentifiers.FromInternal(name);
			if (this.name_cache.ContainsKey(key))
			{
				throw new ArgumentException(SR.Argument_DuplicateTypeName);
			}
			RuntimeTypeBuilder runtimeTypeBuilder = new RuntimeTypeBuilder(this, name, attr, parent, interfaces, packingSize, typesize, null);
			this.AddType(runtimeTypeBuilder);
			this.name_cache.Add(key, runtimeTypeBuilder);
			return runtimeTypeBuilder;
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x00129D7B File Offset: 0x00127F7B
		internal void RegisterTypeName(RuntimeTypeBuilder tb, ITypeName name)
		{
			this.name_cache.Add(name, tb);
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x00129D8C File Offset: 0x00127F8C
		internal RuntimeTypeBuilder GetRegisteredType(ITypeName name)
		{
			RuntimeTypeBuilder result;
			this.name_cache.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x00129DA9 File Offset: 0x00127FA9
		protected override TypeBuilder DefineTypeCore(string name, TypeAttributes attr, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, Type[] interfaces, PackingSize packingSize, int typesize)
		{
			return this.DefineType(name, attr, parent, interfaces, packingSize, typesize);
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00129DBA File Offset: 0x00127FBA
		protected override MethodInfo GetArrayMethodCore(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return new MonoArrayMethod(arrayClass, methodName, callingConvention, returnType, parameterTypes);
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x00129DC8 File Offset: 0x00127FC8
		protected override EnumBuilder DefineEnumCore(string name, TypeAttributes visibility, Type underlyingType)
		{
			ITypeIdentifier key = TypeIdentifiers.FromInternal(name);
			if (this.name_cache.ContainsKey(key))
			{
				throw new ArgumentException(SR.Argument_DuplicateTypeName);
			}
			RuntimeEnumBuilder runtimeEnumBuilder = new RuntimeEnumBuilder(this, name, visibility, underlyingType);
			RuntimeTypeBuilder typeBuilder = runtimeEnumBuilder.GetTypeBuilder();
			this.AddType(typeBuilder);
			this.name_cache.Add(key, typeBuilder);
			return runtimeEnumBuilder;
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x0012048B File Offset: 0x0011E68B
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string className)
		{
			return this.GetType(className, false, false);
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x00120496 File Offset: 0x0011E696
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string className, bool ignoreCase)
		{
			return this.GetType(className, false, ignoreCase);
		}

		// Token: 0x06007E08 RID: 32264 RVA: 0x00129E1C File Offset: 0x0012801C
		private static RuntimeTypeBuilder search_in_array(RuntimeTypeBuilder[] arr, int validElementsInArray, ITypeName className)
		{
			for (int i = 0; i < validElementsInArray; i++)
			{
				if (string.Compare(className.DisplayName, arr[i].FullName, true, CultureInfo.InvariantCulture) == 0)
				{
					return arr[i];
				}
			}
			return null;
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x00129E58 File Offset: 0x00128058
		private static RuntimeTypeBuilder search_nested_in_array(RuntimeTypeBuilder[] arr, int validElementsInArray, ITypeName className)
		{
			for (int i = 0; i < validElementsInArray; i++)
			{
				if (string.Compare(className.DisplayName, arr[i].Name, true, CultureInfo.InvariantCulture) == 0)
				{
					return arr[i];
				}
			}
			return null;
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x00129E94 File Offset: 0x00128094
		private static RuntimeTypeBuilder GetMaybeNested(RuntimeTypeBuilder t, IEnumerable<ITypeName> nested)
		{
			RuntimeTypeBuilder runtimeTypeBuilder = t;
			foreach (ITypeName className in nested)
			{
				if (runtimeTypeBuilder.subtypes == null)
				{
					return null;
				}
				runtimeTypeBuilder = RuntimeModuleBuilder.search_nested_in_array(runtimeTypeBuilder.subtypes, runtimeTypeBuilder.subtypes.Length, className);
				if (runtimeTypeBuilder == null)
				{
					return null;
				}
			}
			return runtimeTypeBuilder;
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x00129F08 File Offset: 0x00128108
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string className, bool throwOnError, bool ignoreCase)
		{
			ArgumentException.ThrowIfNullOrEmpty(className, "className");
			RuntimeTypeBuilder runtimeTypeBuilder = null;
			if (this.types == null && throwOnError)
			{
				throw new TypeLoadException(className);
			}
			TypeSpec typeSpec = TypeSpec.Parse(className);
			if (!ignoreCase)
			{
				ITypeName key = typeSpec.TypeNameWithoutModifiers();
				this.name_cache.TryGetValue(key, out runtimeTypeBuilder);
			}
			else
			{
				if (this.types != null)
				{
					runtimeTypeBuilder = RuntimeModuleBuilder.search_in_array(this.types, this.num_types, typeSpec.Name);
				}
				if (!typeSpec.IsNested && runtimeTypeBuilder != null)
				{
					runtimeTypeBuilder = RuntimeModuleBuilder.GetMaybeNested(runtimeTypeBuilder, typeSpec.Nested);
				}
			}
			if (runtimeTypeBuilder == null && throwOnError)
			{
				throw new TypeLoadException(className);
			}
			if (runtimeTypeBuilder != null && (typeSpec.HasModifiers || typeSpec.IsByRef))
			{
				Type type = runtimeTypeBuilder;
				if (runtimeTypeBuilder != null)
				{
					RuntimeTypeBuilder runtimeTypeBuilder2 = runtimeTypeBuilder;
					if (runtimeTypeBuilder2.is_created)
					{
						type = runtimeTypeBuilder2.CreateType();
					}
				}
				foreach (IModifierSpec modifierSpec in typeSpec.Modifiers)
				{
					if (modifierSpec is PointerSpec)
					{
						type = type.MakePointerType();
					}
					else if (modifierSpec is IArraySpec)
					{
						IArraySpec arraySpec = modifierSpec as IArraySpec;
						if (arraySpec.IsBound)
						{
							return null;
						}
						if (arraySpec.Rank == 1)
						{
							type = type.MakeArrayType();
						}
						else
						{
							type = type.MakeArrayType(arraySpec.Rank);
						}
					}
				}
				if (typeSpec.IsByRef)
				{
					type = type.MakeByRefType();
				}
				runtimeTypeBuilder = (type as RuntimeTypeBuilder);
				if (runtimeTypeBuilder == null)
				{
					return type;
				}
			}
			if (runtimeTypeBuilder != null && runtimeTypeBuilder.is_created)
			{
				return runtimeTypeBuilder.CreateType();
			}
			return runtimeTypeBuilder;
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0012A0B0 File Offset: 0x001282B0
		internal int get_next_table_index(int table, int count)
		{
			if (this.table_indexes == null)
			{
				this.table_indexes = new int[64];
				for (int i = 0; i < 64; i++)
				{
					this.table_indexes[i] = 1;
				}
				this.table_indexes[2] = 2;
			}
			int result = this.table_indexes[table];
			this.table_indexes[table] += count;
			return result;
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0012A10C File Offset: 0x0012830C
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

		// Token: 0x06007E0E RID: 32270 RVA: 0x0012A170 File Offset: 0x00128370
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] GetTypes()
		{
			if (this.types == null)
			{
				return Type.EmptyTypes;
			}
			int num = this.num_types;
			Type[] array = new Type[num];
			Array.Copy(this.types, array, num);
			for (int i = 0; i < array.Length; i++)
			{
				if (this.types[i].is_created)
				{
					array[i] = this.types[i].CreateType();
				}
			}
			return array;
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0012A1D4 File Offset: 0x001283D4
		public override int GetMethodMetadataToken(MethodInfo method)
		{
			ArgumentNullException.ThrowIfNull(method, "method");
			return method.MetadataToken;
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0012A1E7 File Offset: 0x001283E7
		public override int GetMethodMetadataToken(ConstructorInfo constructor)
		{
			ArgumentNullException.ThrowIfNull(constructor, "constructor");
			return constructor.MetadataToken;
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0012A1FA File Offset: 0x001283FA
		public override int GetFieldMetadataToken(FieldInfo field)
		{
			ArgumentNullException.ThrowIfNull(field, "field");
			return field.MetadataToken;
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0012A20D File Offset: 0x0012840D
		internal static Module GetRuntimeModuleFromModule(Module m)
		{
			if (m is ModuleBuilder)
			{
				return m;
			}
			return m as RuntimeModule;
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x0012A21F File Offset: 0x0012841F
		public override int GetSignatureMetadataToken(SignatureHelper signature)
		{
			ArgumentNullException.ThrowIfNull(signature, "signature");
			return this.GetToken(signature);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0012A233 File Offset: 0x00128433
		public override int GetStringMetadataToken(string stringConstant)
		{
			ArgumentNullException.ThrowIfNull(stringConstant, "stringConstant");
			return this.GetToken(stringConstant);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0012A247 File Offset: 0x00128447
		public override int GetTypeMetadataToken(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (type.IsByRef)
			{
				throw new ArgumentException(SR.Argument_CannotBeByRefType, "type");
			}
			return type.MetadataToken;
		}

		// Token: 0x06007E16 RID: 32278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getUSIndex(RuntimeModuleBuilder mb, string str);

		// Token: 0x06007E17 RID: 32279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getToken(RuntimeModuleBuilder mb, object obj, bool create_open_instance);

		// Token: 0x06007E18 RID: 32280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getMethodToken(RuntimeModuleBuilder mb, MethodBase method, Type[] opt_param_types);

		// Token: 0x06007E19 RID: 32281 RVA: 0x0012A274 File Offset: 0x00128474
		internal int GetToken(string str)
		{
			int usindex;
			if (!this.us_string_cache.TryGetValue(str, out usindex))
			{
				usindex = RuntimeModuleBuilder.getUSIndex(this, str);
				this.us_string_cache[str] = usindex;
			}
			return usindex;
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x0012A2A8 File Offset: 0x001284A8
		private int GetPseudoToken(MemberInfo member, bool create_open_instance)
		{
			Dictionary<MemberInfo, int> dictionary = create_open_instance ? this.inst_tokens_open : this.inst_tokens;
			int num;
			if (dictionary == null)
			{
				dictionary = new Dictionary<MemberInfo, int>(ReferenceEqualityComparer.Instance);
				if (create_open_instance)
				{
					this.inst_tokens_open = dictionary;
				}
				else
				{
					this.inst_tokens = dictionary;
				}
			}
			else if (dictionary.TryGetValue(member, out num))
			{
				return num;
			}
			if (member is TypeBuilderInstantiation || member is SymbolType)
			{
				num = RuntimeModuleBuilder.typespec_tokengen--;
			}
			else if (member is FieldOnTypeBuilderInstantiation)
			{
				num = RuntimeModuleBuilder.memberref_tokengen--;
			}
			else if (member is ConstructorOnTypeBuilderInstantiation)
			{
				num = RuntimeModuleBuilder.memberref_tokengen--;
			}
			else if (member is MethodOnTypeBuilderInstantiation)
			{
				num = RuntimeModuleBuilder.memberref_tokengen--;
			}
			else if (member is FieldBuilder)
			{
				num = RuntimeModuleBuilder.memberref_tokengen--;
			}
			else
			{
				TypeBuilder typeBuilder = member as TypeBuilder;
				if (typeBuilder != null)
				{
					if (create_open_instance && typeBuilder.ContainsGenericParameters)
					{
						num = RuntimeModuleBuilder.typespec_tokengen--;
					}
					else if (member.Module == this)
					{
						num = RuntimeModuleBuilder.typedef_tokengen--;
					}
					else
					{
						num = RuntimeModuleBuilder.typeref_tokengen--;
					}
				}
				else
				{
					RuntimeEnumBuilder runtimeEnumBuilder = member as RuntimeEnumBuilder;
					if (runtimeEnumBuilder != null)
					{
						num = this.GetPseudoToken(runtimeEnumBuilder.GetTypeBuilder(), create_open_instance);
						dictionary[member] = num;
						return num;
					}
					RuntimeConstructorBuilder runtimeConstructorBuilder = member as RuntimeConstructorBuilder;
					if (runtimeConstructorBuilder != null)
					{
						if (member.Module == this && !runtimeConstructorBuilder.TypeBuilder.ContainsGenericParameters)
						{
							num = RuntimeModuleBuilder.methoddef_tokengen--;
						}
						else
						{
							num = RuntimeModuleBuilder.memberref_tokengen--;
						}
					}
					else
					{
						RuntimeMethodBuilder runtimeMethodBuilder = member as RuntimeMethodBuilder;
						if (runtimeMethodBuilder != null)
						{
							if (member.Module == this && !runtimeMethodBuilder.TypeBuilder.ContainsGenericParameters && !runtimeMethodBuilder.IsGenericMethodDefinition)
							{
								num = RuntimeModuleBuilder.methoddef_tokengen--;
							}
							else
							{
								num = RuntimeModuleBuilder.memberref_tokengen--;
							}
						}
						else
						{
							if (!(member is GenericTypeParameterBuilder))
							{
								throw new NotImplementedException();
							}
							num = RuntimeModuleBuilder.typespec_tokengen--;
						}
					}
				}
			}
			dictionary[member] = num;
			this.RegisterToken(member, num);
			return num;
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x0012A4CC File Offset: 0x001286CC
		internal int GetToken(MemberInfo member)
		{
			if (member is ConstructorBuilder || member is MethodBuilder || member is FieldBuilder)
			{
				return this.GetPseudoToken(member, false);
			}
			return RuntimeModuleBuilder.getToken(this, member, true);
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x0012A4F8 File Offset: 0x001286F8
		internal int GetToken(MemberInfo member, bool create_open_instance)
		{
			if (member is TypeBuilderInstantiation || member is FieldOnTypeBuilderInstantiation || member is ConstructorOnTypeBuilderInstantiation || member is MethodOnTypeBuilderInstantiation || member is SymbolType || member is FieldBuilder || member is TypeBuilder || member is ConstructorBuilder || member is MethodBuilder || member is GenericTypeParameterBuilder || member is EnumBuilder)
			{
				return this.GetPseudoToken(member, create_open_instance);
			}
			return RuntimeModuleBuilder.getToken(this, member, create_open_instance);
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0012A56E File Offset: 0x0012876E
		internal int GetToken(MethodBase method, Type[] opt_param_types)
		{
			if (method is ConstructorBuilder || method is MethodBuilder)
			{
				return this.GetPseudoToken(method, false);
			}
			return RuntimeModuleBuilder.getMethodToken(this, method, opt_param_types);
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0012A591 File Offset: 0x00128791
		internal int GetToken(SignatureHelper helper)
		{
			return RuntimeModuleBuilder.getToken(this, helper, true);
		}

		// Token: 0x06007E1F RID: 32287
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RegisterToken(object obj, int token);

		// Token: 0x06007E20 RID: 32288 RVA: 0x0012A59C File Offset: 0x0012879C
		internal ITokenGenerator GetTokenGenerator()
		{
			ModuleBuilderTokenGenerator result;
			if ((result = this.token_gen) == null)
			{
				result = (this.token_gen = new ModuleBuilderTokenGenerator(this));
			}
			return result;
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x0012A5C4 File Offset: 0x001287C4
		internal static object RuntimeResolve(object obj)
		{
			RuntimeMethodBuilder runtimeMethodBuilder = obj as RuntimeMethodBuilder;
			if (runtimeMethodBuilder != null)
			{
				return runtimeMethodBuilder.RuntimeResolve();
			}
			RuntimeConstructorBuilder runtimeConstructorBuilder = obj as RuntimeConstructorBuilder;
			if (runtimeConstructorBuilder != null)
			{
				return runtimeConstructorBuilder.RuntimeResolve();
			}
			RuntimeFieldBuilder runtimeFieldBuilder = obj as RuntimeFieldBuilder;
			if (runtimeFieldBuilder != null)
			{
				return runtimeFieldBuilder.RuntimeResolve();
			}
			RuntimeGenericTypeParameterBuilder runtimeGenericTypeParameterBuilder = obj as RuntimeGenericTypeParameterBuilder;
			if (runtimeGenericTypeParameterBuilder != null)
			{
				return runtimeGenericTypeParameterBuilder.RuntimeResolve();
			}
			FieldOnTypeBuilderInstantiation fieldOnTypeBuilderInstantiation = obj as FieldOnTypeBuilderInstantiation;
			if (fieldOnTypeBuilderInstantiation != null)
			{
				return fieldOnTypeBuilderInstantiation.RuntimeResolve();
			}
			MethodOnTypeBuilderInstantiation methodOnTypeBuilderInstantiation = obj as MethodOnTypeBuilderInstantiation;
			if (methodOnTypeBuilderInstantiation != null)
			{
				return methodOnTypeBuilderInstantiation.RuntimeResolve();
			}
			ConstructorOnTypeBuilderInstantiation constructorOnTypeBuilderInstantiation = obj as ConstructorOnTypeBuilderInstantiation;
			if (constructorOnTypeBuilderInstantiation != null)
			{
				return constructorOnTypeBuilderInstantiation.RuntimeResolve();
			}
			Type type = obj as Type;
			if (type != null)
			{
				return type.RuntimeResolve();
			}
			throw new NotImplementedException(obj.GetType().FullName);
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0012A675 File Offset: 0x00128875
		internal void CreateGlobalType()
		{
			if (this.global_type == null)
			{
				this.global_type = new RuntimeTypeBuilder(this, TypeAttributes.NotPublic, 1, true);
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x0012A68E File Offset: 0x0012888E
		public override Assembly Assembly
		{
			get
			{
				return this.assemblyb;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x0012A696 File Offset: 0x00128896
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x0012A696 File Offset: 0x00128896
		public override string ScopeName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x0012A69E File Offset: 0x0012889E
		public override Guid ModuleVersionId
		{
			get
			{
				return new Guid(this.guid);
			}
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsResource()
		{
			return false;
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x0012A6AB File Offset: 0x001288AB
		private protected override ModuleHandle GetModuleHandleImpl()
		{
			return new ModuleHandle(this._impl);
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x0012A6B8 File Offset: 0x001288B8
		[RequiresUnreferencedCode("Methods might be removed")]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (!this.global_type_created)
			{
				return null;
			}
			if (types == null)
			{
				return this.global_type.AsType().GetMethod(name);
			}
			return this.global_type.AsType().GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x0012A6F3 File Offset: 0x001288F3
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveField(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x0012A704 File Offset: 0x00128904
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMember(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x0012A715 File Offset: 0x00128915
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMethod(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x0012A726 File Offset: 0x00128926
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override string ResolveString(int metadataToken)
		{
			return RuntimeModule.ResolveString(this, this._impl, metadataToken);
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x0012A735 File Offset: 0x00128935
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override byte[] ResolveSignature(int metadataToken)
		{
			return RuntimeModule.ResolveSignature(this, this._impl, metadataToken);
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x0012A744 File Offset: 0x00128944
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveType(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0012A755 File Offset: 0x00128955
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x0012A75E File Offset: 0x0012895E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x0012A766 File Offset: 0x00128966
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return base.IsDefined(attributeType, inherit);
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0011B693 File Offset: 0x00119893
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttribute.GetCustomAttributesData(this, false);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0012A770 File Offset: 0x00128970
		[RequiresUnreferencedCode("Fields might be removed")]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			if (!this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod);
			}
			return this.global_type.AsType().GetField(name, bindingAttr);
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0012A797 File Offset: 0x00128997
		[RequiresUnreferencedCode("Fields might be removed")]
		public override FieldInfo[] GetFields(BindingFlags bindingFlags)
		{
			if (!this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod);
			}
			return this.global_type.AsType().GetFields(bindingFlags);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0012A7BD File Offset: 0x001289BD
		[RequiresUnreferencedCode("Methods might be removed")]
		public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
		{
			if (!this.global_type_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod);
			}
			return this.global_type.AsType().GetMethods(bindingFlags);
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x0011CDE1 File Offset: 0x0011AFE1
		public override int MetadataToken
		{
			get
			{
				return RuntimeModule.get_MetadataToken(this);
			}
		}

		// Token: 0x0400182E RID: 6190
		internal IntPtr _impl;

		// Token: 0x0400182F RID: 6191
		internal Assembly assembly;

		// Token: 0x04001830 RID: 6192
		internal string fqname;

		// Token: 0x04001831 RID: 6193
		internal string name;

		// Token: 0x04001832 RID: 6194
		internal string scopename;

		// Token: 0x04001833 RID: 6195
		internal bool is_resource;

		// Token: 0x04001834 RID: 6196
		internal int token;

		// Token: 0x04001835 RID: 6197
		private UIntPtr dynamic_image;

		// Token: 0x04001836 RID: 6198
		private int num_types;

		// Token: 0x04001837 RID: 6199
		private RuntimeTypeBuilder[] types;

		// Token: 0x04001838 RID: 6200
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001839 RID: 6201
		private int table_idx;

		// Token: 0x0400183A RID: 6202
		internal RuntimeAssemblyBuilder assemblyb;

		// Token: 0x0400183B RID: 6203
		private object[] global_methods;

		// Token: 0x0400183C RID: 6204
		private object[] global_fields;

		// Token: 0x0400183D RID: 6205
		private bool is_main;

		// Token: 0x0400183E RID: 6206
		private object resources;

		// Token: 0x0400183F RID: 6207
		private IntPtr unparented_classes;

		// Token: 0x04001840 RID: 6208
		private int[] table_indexes;

		// Token: 0x04001841 RID: 6209
		private byte[] guid;

		// Token: 0x04001842 RID: 6210
		private RuntimeTypeBuilder global_type;

		// Token: 0x04001843 RID: 6211
		private bool global_type_created;

		// Token: 0x04001844 RID: 6212
		private Dictionary<ITypeName, RuntimeTypeBuilder> name_cache;

		// Token: 0x04001845 RID: 6213
		private Dictionary<string, int> us_string_cache;

		// Token: 0x04001846 RID: 6214
		private ModuleBuilderTokenGenerator token_gen;

		// Token: 0x04001847 RID: 6215
		private static int typeref_tokengen = 33554431;

		// Token: 0x04001848 RID: 6216
		private static int typedef_tokengen = 50331647;

		// Token: 0x04001849 RID: 6217
		private static int typespec_tokengen = 469762047;

		// Token: 0x0400184A RID: 6218
		private static int memberref_tokengen = 184549375;

		// Token: 0x0400184B RID: 6219
		private static int methoddef_tokengen = 117440511;

		// Token: 0x0400184C RID: 6220
		private Dictionary<MemberInfo, int> inst_tokens;

		// Token: 0x0400184D RID: 6221
		private Dictionary<MemberInfo, int> inst_tokens_open;
	}
}

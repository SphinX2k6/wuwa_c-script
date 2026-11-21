using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B1 RID: 1969
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeMethodBuilder : MethodBuilder
	{
		// Token: 0x06007DBC RID: 32188 RVA: 0x00128E7C File Offset: 0x0012707C
		[DynamicDependency("paramModOpt")]
		internal RuntimeMethodBuilder(RuntimeTypeBuilder tb, string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.name = name;
			this.attrs = attributes;
			this.call_conv = callingConvention;
			this.rtype = returnType;
			this.returnModReq = returnModReq;
			this.returnModOpt = returnModOpt;
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				this.call_conv |= CallingConventions.HasThis;
			}
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					ArgumentNullException.ThrowIfNull(parameterTypes[i], "parameterTypes");
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
			this.type = tb;
			this.table_idx = this.get_next_table_index(6, 1);
			((RuntimeModuleBuilder)tb.Module).RegisterToken(this, this.MetadataToken);
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x00128F58 File Offset: 0x00127158
		internal RuntimeMethodBuilder(RuntimeTypeBuilder tb, string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt, string dllName, string entryName, CallingConvention nativeCConv, CharSet nativeCharset) : this(tb, name, attributes, callingConvention, returnType, returnModReq, returnModOpt, parameterTypes, paramModReq, paramModOpt)
		{
			this.pi_dll = dllName;
			this.pi_entry = entryName;
			this.native_cc = nativeCConv;
			this.charset = nativeCharset;
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06007DBE RID: 32190 RVA: 0x0001A563 File Offset: 0x00018763
		public override bool ContainsGenericParameters
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x00128F9C File Offset: 0x0012719C
		// (set) Token: 0x06007DC0 RID: 32192 RVA: 0x00128FA4 File Offset: 0x001271A4
		protected override bool InitLocalsCore
		{
			get
			{
				return this.init_locals;
			}
			set
			{
				this.init_locals = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x00128FAD File Offset: 0x001271AD
		internal RuntimeTypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x00128FB5 File Offset: 0x001271B5
		public override int MetadataToken
		{
			get
			{
				return 100663296 | this.table_idx;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x00128FC3 File Offset: 0x001271C3
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw RuntimeMethodBuilder.NotSupported();
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x00128FCA File Offset: 0x001271CA
		internal RuntimeMethodHandle MethodHandleInternal
		{
			get
			{
				return this.mhandle;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x00128FD2 File Offset: 0x001271D2
		public override Type ReturnType
		{
			get
			{
				return this.rtype;
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x00128FAD File Offset: 0x001271AD
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x00128FDA File Offset: 0x001271DA
		public override Type DeclaringType
		{
			get
			{
				if (this.type.is_hidden_global_type)
				{
					return null;
				}
				return this.type;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06007DC8 RID: 32200 RVA: 0x00128FF1 File Offset: 0x001271F1
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x00128FF9 File Offset: 0x001271F9
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06007DCA RID: 32202 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06007DCB RID: 32203 RVA: 0x00129001 File Offset: 0x00127201
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (set) Token: 0x06007DCC RID: 32204 RVA: 0x00129009 File Offset: 0x00127209
		internal bool BestFitMapping
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551567UL) | (value ? 16UL : 32UL));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (set) Token: 0x06007DCD RID: 32205 RVA: 0x00129028 File Offset: 0x00127228
		internal bool ThrowOnUnmappableChar
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709539327UL) | (value ? 4096UL : 8192UL));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (set) Token: 0x06007DCE RID: 32206 RVA: 0x00129050 File Offset: 0x00127250
		internal bool ExactSpelling
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551614UL) | ((value > false) ? 1UL : 0UL));
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (set) Token: 0x06007DCF RID: 32207 RVA: 0x0012906A File Offset: 0x0012726A
		internal bool SetLastError
		{
			set
			{
				this.extra_flags = (uint)(((ulong)this.extra_flags & 18446744073709551551UL) | (value ? 64UL : 0UL));
			}
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x00007B62 File Offset: 0x00005D62
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00129088 File Offset: 0x00127288
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x00129090 File Offset: 0x00127290
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw RuntimeMethodBuilder.NotSupported();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x001290AC File Offset: 0x001272AC
		internal override ParameterInfo[] GetParametersInternal()
		{
			if (this.parameters == null)
			{
				return Array.Empty<ParameterInfo>();
			}
			ParameterInfo[] array = new ParameterInfo[this.parameters.Length];
			for (int i = 0; i < this.parameters.Length; i++)
			{
				ParameterInfo[] array2 = array;
				int num = i;
				ParameterBuilder[] array3 = this.pinfo;
				array2[num] = RuntimeParameterInfo.New((array3 != null) ? array3[i + 1] : null, this.parameters[i], this, i + 1);
			}
			return array;
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x0012910E File Offset: 0x0012730E
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x00129122 File Offset: 0x00127322
		internal override Type GetParameterType(int pos)
		{
			return this.parameters[pos];
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x0012912C File Offset: 0x0012732C
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetMethod(this);
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x0012913F File Offset: 0x0012733F
		internal Module GetModule()
		{
			return this.type.Module;
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00128FC3 File Offset: 0x001271C3
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw RuntimeMethodBuilder.NotSupported();
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00128FC3 File Offset: 0x001271C3
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw RuntimeMethodBuilder.NotSupported();
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x0012914C File Offset: 0x0012734C
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.type.is_created)
			{
				return CustomAttribute.GetCustomAttributes(this, inherit);
			}
			throw RuntimeMethodBuilder.NotSupported();
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x00129168 File Offset: 0x00127368
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.type.is_created)
			{
				return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
			}
			throw RuntimeMethodBuilder.NotSupported();
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00129188 File Offset: 0x00127388
		protected override ILGenerator GetILGeneratorCore(int size)
		{
			if ((this.iattrs & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (this.iattrs & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ShouldNotHaveMethodBody);
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new RuntimeILGenerator(this.type.Module, ((RuntimeModuleBuilder)this.type.Module).GetTokenGenerator(), size);
			return this.ilgen;
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x001291F8 File Offset: 0x001273F8
		protected override ParameterBuilder DefineParameterCore(int position, ParameterAttributes attributes, string strParamName)
		{
			this.RejectIfCreated();
			if (position < 0 || this.parameters == null || position > this.parameters.Length)
			{
				throw new ArgumentOutOfRangeException("position");
			}
			ParameterBuilder parameterBuilder = new RuntimeParameterBuilder(this, position, attributes, strParamName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[position] = parameterBuilder;
			return parameterBuilder;
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x00129260 File Offset: 0x00127460
		internal void check_override()
		{
			if (this.override_methods != null)
			{
				foreach (MethodInfo methodInfo in this.override_methods)
				{
					if (methodInfo.IsVirtual && !base.IsVirtual && !base.IsStatic && !this.ReflectedType.IsInterface)
					{
						throw new TypeLoadException(SR.Format(SR.TypeLoad_MethodOverrideNotVirtual, this.name, methodInfo));
					}
				}
			}
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x001292CC File Offset: 0x001274CC
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0) && (this.code == null || this.code.Length == 0))
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_BadEmptyMethodBody, this.Name));
			}
			RuntimeILGenerator runtimeILGenerator = this.ilgen;
			if (runtimeILGenerator == null)
			{
				return;
			}
			runtimeILGenerator.label_fixup(this);
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x00129344 File Offset: 0x00127544
		internal void ResolveUserTypes()
		{
			this.rtype = RuntimeTypeBuilder.ResolveUserType(this.rtype);
			RuntimeTypeBuilder.ResolveUserTypes(this.parameters);
			RuntimeTypeBuilder.ResolveUserTypes(this.returnModReq);
			RuntimeTypeBuilder.ResolveUserTypes(this.returnModOpt);
			if (this.paramModReq != null)
			{
				Type[][] array = this.paramModReq;
				for (int i = 0; i < array.Length; i++)
				{
					RuntimeTypeBuilder.ResolveUserTypes(array[i]);
				}
			}
			if (this.paramModOpt != null)
			{
				Type[][] array = this.paramModOpt;
				for (int i = 0; i < array.Length; i++)
				{
					RuntimeTypeBuilder.ResolveUserTypes(array[i]);
				}
			}
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x001293D0 File Offset: 0x001275D0
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			string fullName = con.ReflectedType.FullName;
			if (fullName == "System.Runtime.CompilerServices.MethodImplAttribute")
			{
				int num = (int)BinaryPrimitives.ReadUInt16LittleEndian(binaryAttribute.Slice(2));
				this.iattrs |= (MethodImplAttributes)num;
				return;
			}
			if (!(fullName == "System.Runtime.InteropServices.DllImportAttribute"))
			{
				if (fullName == "System.Runtime.InteropServices.PreserveSigAttribute")
				{
					this.iattrs |= MethodImplAttributes.PreserveSig;
					return;
				}
				if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
				{
					this.attrs |= MethodAttributes.SpecialName;
					return;
				}
				if (fullName == "System.Security.SuppressUnmanagedCodeSecurityAttribute")
				{
					this.attrs |= MethodAttributes.HasSecurity;
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
				return;
			}
			else
			{
				CustomAttributeBuilder.CustomAttributeInfo customAttributeInfo = CustomAttributeBuilder.decode_cattr(con, binaryAttribute);
				bool flag = true;
				this.pi_dll = (string)customAttributeInfo.ctorArgs[0];
				if (this.pi_dll == null || this.pi_dll.Length == 0)
				{
					throw new ArgumentException(SR.Arg_DllNameCannotBeEmpty);
				}
				this.native_cc = System.Runtime.InteropServices.CallingConvention.Winapi;
				for (int i = 0; i < customAttributeInfo.namedParamNames.Length; i++)
				{
					string a = customAttributeInfo.namedParamNames[i];
					object obj = customAttributeInfo.namedParamValues[i];
					if (a == "CallingConvention")
					{
						this.native_cc = (CallingConvention)obj;
					}
					else if (a == "CharSet")
					{
						this.charset = (CharSet)obj;
					}
					else if (a == "EntryPoint")
					{
						this.pi_entry = (string)obj;
					}
					else if (a == "ExactSpelling")
					{
						this.ExactSpelling = (bool)obj;
					}
					else if (a == "SetLastError")
					{
						this.SetLastError = (bool)obj;
					}
					else if (a == "PreserveSig")
					{
						flag = (bool)obj;
					}
					else if (a == "BestFitMapping")
					{
						this.BestFitMapping = (bool)obj;
					}
					else if (a == "ThrowOnUnmappableChar")
					{
						this.ThrowOnUnmappableChar = (bool)obj;
					}
				}
				this.attrs |= MethodAttributes.PinvokeImpl;
				if (flag)
				{
					this.iattrs |= MethodImplAttributes.PreserveSig;
				}
				return;
			}
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x00129675 File Offset: 0x00127875
		protected override void SetImplementationFlagsCore(MethodImplAttributes attributes)
		{
			this.RejectIfCreated();
			this.iattrs = attributes;
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x00129684 File Offset: 0x00127884
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"MethodBuilder [",
				this.type.Name,
				"::",
				this.name,
				"]"
			});
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x001296C0 File Offset: 0x001278C0
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x001296C9 File Offset: 0x001278C9
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x001296D6 File Offset: 0x001278D6
		internal override int get_next_table_index(int table, int count)
		{
			return this.type.get_next_table_index(table, count);
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x001296E8 File Offset: 0x001278E8
		private static void ExtendArray<T>([NotNull] ref T[] array, T elem)
		{
			if (array == null)
			{
				array = new T[1];
			}
			else
			{
				T[] array2 = new T[array.Length + 1];
				Array.Copy(array, array2, array.Length);
				array = array2;
			}
			array[array.Length - 1] = elem;
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x0012972C File Offset: 0x0012792C
		internal void set_override(MethodInfo mdecl)
		{
			RuntimeMethodBuilder.ExtendArray<MethodInfo>(ref this.override_methods, mdecl);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x0012973A File Offset: 0x0012793A
		private void RejectIfCreated()
		{
			if (this.type.is_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_MethodBaked);
			}
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x00126C2D File Offset: 0x00124E2D
		private static NotSupportedException NotSupported()
		{
			return new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x00129754 File Offset: 0x00127954
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException(SR.Argument_NeedGenericMethodDefinition);
			}
			ArgumentNullException.ThrowIfNull(typeArguments, "typeArguments");
			for (int i = 0; i < typeArguments.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(typeArguments[i], "typeArguments");
			}
			return new MethodOnTypeBuilderInstantiation(this, typeArguments);
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06007DEC RID: 32236 RVA: 0x001297A3 File Offset: 0x001279A3
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06007DED RID: 32237 RVA: 0x001297A3 File Offset: 0x001279A3
		public override bool IsGenericMethod
		{
			get
			{
				return this.generic_params != null;
			}
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x001297AE File Offset: 0x001279AE
		public override MethodInfo GetGenericMethodDefinition()
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException();
			}
			return this;
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x001297C0 File Offset: 0x001279C0
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return Type.EmptyTypes;
			}
			Type[] array = new Type[this.generic_params.Length];
			for (int i = 0; i < this.generic_params.Length; i++)
			{
				array[i] = this.generic_params[i];
			}
			return array;
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x00129808 File Offset: 0x00127A08
		protected override GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names)
		{
			this.type.check_not_created();
			this.generic_params = new RuntimeGenericTypeParameterBuilder[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string argument = names[i];
				ArgumentNullException.ThrowIfNull(argument, "names");
				this.generic_params[i] = new RuntimeGenericTypeParameterBuilder(this.type, this, argument, i);
			}
			return this.generic_params;
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x0012986C File Offset: 0x00127A6C
		protected override void SetSignatureCore(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					ArgumentNullException.ThrowIfNull(parameterTypes[i], "parameterTypes");
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
			if (returnType != null)
			{
				this.rtype = returnType;
			}
			this.returnModReq = returnTypeRequiredCustomModifiers;
			this.returnModOpt = returnTypeOptionalCustomModifiers;
			this.paramModReq = parameterTypeRequiredCustomModifiers;
			this.paramModOpt = parameterTypeOptionalCustomModifiers;
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x001298E9 File Offset: 0x00127AE9
		public override Module Module
		{
			get
			{
				return this.GetModule();
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x001298F4 File Offset: 0x00127AF4
		public override ParameterInfo ReturnParameter
		{
			get
			{
				if (!this.type.is_created)
				{
					throw new InvalidOperationException(SR.InvalidOperation_TypeNotCreated);
				}
				if (this.created == null)
				{
					this.created = (RuntimeMethodInfo)MethodBase.GetMethodFromHandle(this.mhandle);
				}
				return this.created.ReturnParameter;
			}
		}

		// Token: 0x04001813 RID: 6163
		private RuntimeMethodHandle mhandle;

		// Token: 0x04001814 RID: 6164
		private Type rtype;

		// Token: 0x04001815 RID: 6165
		internal Type[] parameters;

		// Token: 0x04001816 RID: 6166
		private MethodAttributes attrs;

		// Token: 0x04001817 RID: 6167
		private MethodImplAttributes iattrs;

		// Token: 0x04001818 RID: 6168
		private string name;

		// Token: 0x04001819 RID: 6169
		private int table_idx;

		// Token: 0x0400181A RID: 6170
		private byte[] code;

		// Token: 0x0400181B RID: 6171
		private RuntimeILGenerator ilgen;

		// Token: 0x0400181C RID: 6172
		private RuntimeTypeBuilder type;

		// Token: 0x0400181D RID: 6173
		internal ParameterBuilder[] pinfo;

		// Token: 0x0400181E RID: 6174
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400181F RID: 6175
		private MethodInfo[] override_methods;

		// Token: 0x04001820 RID: 6176
		private string pi_dll;

		// Token: 0x04001821 RID: 6177
		private string pi_entry;

		// Token: 0x04001822 RID: 6178
		private CharSet charset;

		// Token: 0x04001823 RID: 6179
		private uint extra_flags;

		// Token: 0x04001824 RID: 6180
		private CallingConvention native_cc;

		// Token: 0x04001825 RID: 6181
		private CallingConventions call_conv;

		// Token: 0x04001826 RID: 6182
		private bool init_locals = true;

		// Token: 0x04001827 RID: 6183
		private IntPtr generic_container;

		// Token: 0x04001828 RID: 6184
		internal RuntimeGenericTypeParameterBuilder[] generic_params;

		// Token: 0x04001829 RID: 6185
		private Type[] returnModReq;

		// Token: 0x0400182A RID: 6186
		private Type[] returnModOpt;

		// Token: 0x0400182B RID: 6187
		private Type[][] paramModReq;

		// Token: 0x0400182C RID: 6188
		private Type[][] paramModOpt;

		// Token: 0x0400182D RID: 6189
		private RuntimeMethodInfo created;
	}
}

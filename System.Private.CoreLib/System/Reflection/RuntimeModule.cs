using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000710 RID: 1808
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeModule : Module
	{
		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x0011CCDA File Offset: 0x0011AEDA
		public override Assembly Assembly
		{
			get
			{
				return this.assembly;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060077AD RID: 30637 RVA: 0x0011CCE2 File Offset: 0x0011AEE2
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x0011CCEA File Offset: 0x0011AEEA
		public override string ScopeName
		{
			get
			{
				return this.scopename;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060077AF RID: 30639 RVA: 0x0011CCF2 File Offset: 0x0011AEF2
		public override int MDStreamVersion
		{
			get
			{
				if (this._impl == IntPtr.Zero)
				{
					throw new NotSupportedException();
				}
				return RuntimeModule.GetMDStreamVersion(this._impl);
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060077B0 RID: 30640 RVA: 0x0011CD12 File Offset: 0x0011AF12
		public override Guid ModuleVersionId
		{
			get
			{
				return this.GetModuleVersionId();
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060077B1 RID: 30641 RVA: 0x0011CD1A File Offset: 0x0011AF1A
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public override string FullyQualifiedName
		{
			get
			{
				return this.fqname;
			}
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x0011CD22 File Offset: 0x0011AF22
		public override bool IsResource()
		{
			return this.is_resource;
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x0011CD2C File Offset: 0x0011AF2C
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] FindTypes(TypeFilter filter, object filterCriteria)
		{
			List<Type> list = new List<Type>();
			foreach (Type type in this.GetTypes())
			{
				if (filter != null && filter(type, filterCriteria))
				{
					list.Add(type);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x0011CD72 File Offset: 0x0011AF72
		[RequiresUnreferencedCode("Fields might be removed")]
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (this.IsResource())
			{
				return null;
			}
			Type globalType = RuntimeModule.GetGlobalType(this._impl);
			if (globalType == null)
			{
				return null;
			}
			return globalType.GetField(name, bindingAttr);
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x0011CDA4 File Offset: 0x0011AFA4
		[RequiresUnreferencedCode("Fields might be removed")]
		public override FieldInfo[] GetFields(BindingFlags bindingFlags)
		{
			if (this.IsResource())
			{
				return Array.Empty<FieldInfo>();
			}
			Type globalType = RuntimeModule.GetGlobalType(this._impl);
			if (!(globalType != null))
			{
				return Array.Empty<FieldInfo>();
			}
			return globalType.GetFields(bindingFlags);
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x0011CDE1 File Offset: 0x0011AFE1
		public override int MetadataToken
		{
			get
			{
				return RuntimeModule.get_MetadataToken(this);
			}
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x0011CDEC File Offset: 0x0011AFEC
		[RequiresUnreferencedCode("Methods might be removed")]
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (this.IsResource())
			{
				return null;
			}
			Type globalType = RuntimeModule.GetGlobalType(this._impl);
			if (globalType == null)
			{
				return null;
			}
			if (types == null)
			{
				return globalType.GetMethod(name);
			}
			return globalType.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x0011CE38 File Offset: 0x0011B038
		[RequiresUnreferencedCode("Methods might be removed")]
		public override MethodInfo[] GetMethods(BindingFlags bindingFlags)
		{
			if (this.IsResource())
			{
				return Array.Empty<MethodInfo>();
			}
			Type globalType = RuntimeModule.GetGlobalType(this._impl);
			if (!(globalType != null))
			{
				return Array.Empty<MethodInfo>();
			}
			return globalType.GetMethods(bindingFlags);
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x0011CE75 File Offset: 0x0011B075
		public override void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
		{
			RuntimeModule.GetPEKind(this._impl, out peKind, out machine);
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x0011CE84 File Offset: 0x0011B084
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string className, bool throwOnError, bool ignoreCase)
		{
			ArgumentException.ThrowIfNullOrEmpty(className, "className");
			return this.assembly.InternalGetType(this, className, throwOnError, ignoreCase);
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x0011CEA0 File Offset: 0x0011B0A0
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveField(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x0011CEB4 File Offset: 0x0011B0B4
		internal static FieldInfo ResolveField(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			IntPtr intPtr = RuntimeModule.ResolveFieldToken(monoModule, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (intPtr == IntPtr.Zero)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "Field");
			}
			return FieldInfo.GetFieldFromHandle(new RuntimeFieldHandle(intPtr));
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x0011CEF9 File Offset: 0x0011B0F9
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMember(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x0011CF0C File Offset: 0x0011B10C
		internal static MemberInfo ResolveMember(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			MemberInfo memberInfo = RuntimeModule.ResolveMemberToken(monoModule, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (memberInfo == null)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "MemberInfo");
			}
			return memberInfo;
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x0011CF48 File Offset: 0x0011B148
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMethod(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x0011CF5C File Offset: 0x0011B15C
		internal static MethodBase ResolveMethod(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			IntPtr intPtr = RuntimeModule.ResolveMethodToken(monoModule, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (intPtr == IntPtr.Zero)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "MethodBase");
			}
			return RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(new RuntimeMethodHandle(intPtr));
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0011CFA1 File Offset: 0x0011B1A1
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override string ResolveString(int metadataToken)
		{
			return RuntimeModule.ResolveString(this, this._impl, metadataToken);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0011CFB0 File Offset: 0x0011B1B0
		internal static string ResolveString(Module module, IntPtr monoModule, int metadataToken)
		{
			ResolveTokenError error;
			string text = RuntimeModule.ResolveStringToken(monoModule, metadataToken, out error);
			if (text == null)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "string");
			}
			return text;
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x0011CFD9 File Offset: 0x0011B1D9
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveType(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x0011CFEC File Offset: 0x0011B1EC
		internal static Type ResolveType(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			IntPtr intPtr = RuntimeModule.ResolveTypeToken(monoModule, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (intPtr == IntPtr.Zero)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "Type");
			}
			return Type.GetTypeFromHandle(new RuntimeTypeHandle(intPtr));
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x0011D031 File Offset: 0x0011B231
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public override byte[] ResolveSignature(int metadataToken)
		{
			return RuntimeModule.ResolveSignature(this, this._impl, metadataToken);
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0011D040 File Offset: 0x0011B240
		internal static byte[] ResolveSignature(Module module, IntPtr monoModule, int metadataToken)
		{
			ResolveTokenError error;
			byte[] array = RuntimeModule.ResolveSignature(monoModule, metadataToken, out error);
			if (array == null)
			{
				throw RuntimeModule.resolve_token_exception(module, metadataToken, error, "signature");
			}
			return array;
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0011D069 File Offset: 0x0011B269
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] GetTypes()
		{
			return RuntimeModule.InternalGetTypes(this._impl);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x0011D076 File Offset: 0x0011B276
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x0011D080 File Offset: 0x0011B280
		internal Guid GetModuleVersionId()
		{
			byte[] array = new byte[16];
			RuntimeModule.GetGuidInternal(this._impl, array);
			return new Guid(array);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0011D0A7 File Offset: 0x0011B2A7
		[UnconditionalSuppressMessage("SingleFile", "IL3002:RequiresAssemblyFiles", Justification = "Module Name is used only for diagnostic reporting message")]
		internal static Exception resolve_token_exception(Module module, int metadataToken, ResolveTokenError error, string tokenType)
		{
			return RuntimeModule.resolve_token_exception(module.Name, metadataToken, error, tokenType);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x0011D0B7 File Offset: 0x0011B2B7
		internal static Exception resolve_token_exception(string name, int metadataToken, ResolveTokenError error, string tokenType)
		{
			if (error == ResolveTokenError.OutOfRange)
			{
				return new ArgumentOutOfRangeException("metadataToken", SR.Format(SR.Argument_InvalidToken, metadataToken, name));
			}
			return new ArgumentException(SR.Format(SR.Argument_ResolveType, metadataToken, tokenType, name), "metadataToken");
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0011D0F4 File Offset: 0x0011B2F4
		internal static IntPtr[] ptrs_from_types(Type[] types)
		{
			if (types == null)
			{
				return null;
			}
			IntPtr[] array = new IntPtr[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentException();
				}
				array[i] = types[i].TypeHandle.Value;
			}
			return array;
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x0011D142 File Offset: 0x0011B342
		private protected override ModuleHandle GetModuleHandleImpl()
		{
			return new ModuleHandle(this._impl);
		}

		// Token: 0x060077D1 RID: 30673
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_MetadataToken(Module module);

		// Token: 0x060077D2 RID: 30674
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetMDStreamVersion(IntPtr module);

		// Token: 0x060077D3 RID: 30675
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type[] InternalGetTypes(IntPtr module);

		// Token: 0x060077D4 RID: 30676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGuidInternal(IntPtr module, byte[] guid);

		// Token: 0x060077D5 RID: 30677
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type GetGlobalType(IntPtr module);

		// Token: 0x060077D6 RID: 30678
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveTypeToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);

		// Token: 0x060077D7 RID: 30679
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveMethodToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);

		// Token: 0x060077D8 RID: 30680
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveFieldToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);

		// Token: 0x060077D9 RID: 30681
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string ResolveStringToken(IntPtr module, int token, out ResolveTokenError error);

		// Token: 0x060077DA RID: 30682
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MemberInfo ResolveMemberToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);

		// Token: 0x060077DB RID: 30683
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern byte[] ResolveSignature(IntPtr module, int metadataToken, out ResolveTokenError error);

		// Token: 0x060077DC RID: 30684
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetPEKind(IntPtr module, out PortableExecutableKinds peKind, out ImageFileMachine machine);

		// Token: 0x040015B5 RID: 5557
		internal IntPtr _impl;

		// Token: 0x040015B6 RID: 5558
		internal Assembly assembly;

		// Token: 0x040015B7 RID: 5559
		internal string fqname;

		// Token: 0x040015B8 RID: 5560
		internal string name;

		// Token: 0x040015B9 RID: 5561
		internal string scopename;

		// Token: 0x040015BA RID: 5562
		internal bool is_resource;

		// Token: 0x040015BB RID: 5563
		internal int token;
	}
}

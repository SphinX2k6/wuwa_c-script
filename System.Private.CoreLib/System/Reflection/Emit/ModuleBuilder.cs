using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C8 RID: 1992
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ModuleBuilder : Module
	{
		// Token: 0x06007FFB RID: 32763 RVA: 0x0012DE7C File Offset: 0x0012C07C
		public void CreateGlobalFunctions()
		{
			this.CreateGlobalFunctionsCore();
		}

		// Token: 0x06007FFC RID: 32764
		protected abstract void CreateGlobalFunctionsCore();

		// Token: 0x06007FFD RID: 32765 RVA: 0x0012DE84 File Offset: 0x0012C084
		public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineEnumCore(name, visibility, underlyingType);
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x0012DE9A File Offset: 0x0012C09A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType)
		{
			return this.DefineDocument(url, language);
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x0012DEA4 File Offset: 0x0012C0A4
		public ISymbolDocumentWriter DefineDocument(string url, Guid language = default(Guid))
		{
			ArgumentException.ThrowIfNullOrEmpty(url, "url");
			return this.DefineDocumentCore(url, language);
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x0012DEB9 File Offset: 0x0012C0B9
		protected virtual ISymbolDocumentWriter DefineDocumentCore(string url, Guid language = default(Guid))
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotADebugModule);
		}

		// Token: 0x06008001 RID: 32769
		protected abstract EnumBuilder DefineEnumCore(string name, TypeAttributes visibility, Type underlyingType);

		// Token: 0x06008002 RID: 32770 RVA: 0x0012DEC8 File Offset: 0x0012C0C8
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineGlobalMethod(name, attributes, CallingConventions.Standard, returnType, null, null, parameterTypes, null, null);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x0012DEE8 File Offset: 0x0012C0E8
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			return this.DefineGlobalMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x0012DF08 File Offset: 0x0012C108
		public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredParameterTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalParameterTypeCustomModifiers)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineGlobalMethodCore(name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
		}

		// Token: 0x06008005 RID: 32773
		protected abstract MethodBuilder DefineGlobalMethodCore(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] requiredReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] optionalReturnTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] requiredParameterTypeCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] optionalParameterTypeCustomModifiers);

		// Token: 0x06008006 RID: 32774 RVA: 0x0012DF35 File Offset: 0x0012C135
		public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
		{
			return this.DefineInitializedDataCore(name, data, attributes);
		}

		// Token: 0x06008007 RID: 32775
		protected abstract FieldBuilder DefineInitializedDataCore(string name, byte[] data, FieldAttributes attributes);

		// Token: 0x06008008 RID: 32776 RVA: 0x0012DF40 File Offset: 0x0012C140
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, name, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x0012DF64 File Offset: 0x0012C164
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethodCore(name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
		}

		// Token: 0x0600800A RID: 32778
		[RequiresUnreferencedCode("P/Invoke marshalling may dynamically access members that could be trimmed.")]
		protected abstract MethodBuilder DefinePInvokeMethodCore(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);

		// Token: 0x0600800B RID: 32779 RVA: 0x0012DF86 File Offset: 0x0012C186
		public TypeBuilder DefineType(string name)
		{
			return this.DefineType(name, TypeAttributes.NotPublic, null, null);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x0012DF92 File Offset: 0x0012C192
		public TypeBuilder DefineType(string name, TypeAttributes attr)
		{
			return this.DefineType(name, attr, null, null);
		}

		// Token: 0x0600800D RID: 32781 RVA: 0x0012DF9E File Offset: 0x0012C19E
		public TypeBuilder DefineType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent)
		{
			return this.DefineType(name, attr, parent, null);
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x0012DFAA File Offset: 0x0012C1AA
		public TypeBuilder DefineType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] interfaces)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineTypeCore(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x0012DFC4 File Offset: 0x0012C1C4
		public TypeBuilder DefineType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, int typesize)
		{
			return this.DefineType(name, attr, parent, PackingSize.Unspecified, typesize);
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x0012DFD2 File Offset: 0x0012C1D2
		public TypeBuilder DefineType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, PackingSize packsize)
		{
			return this.DefineType(name, attr, parent, packsize, 0);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x0012DFE0 File Offset: 0x0012C1E0
		public TypeBuilder DefineType(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, PackingSize packingSize, int typesize)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineTypeCore(name, attr, parent, null, packingSize, typesize);
		}

		// Token: 0x06008012 RID: 32786
		protected abstract TypeBuilder DefineTypeCore(string name, TypeAttributes attr, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type parent, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] interfaces, PackingSize packingSize, int typesize);

		// Token: 0x06008013 RID: 32787 RVA: 0x0012DFFB File Offset: 0x0012C1FB
		public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
		{
			return this.DefineUninitializedDataCore(name, size, attributes);
		}

		// Token: 0x06008014 RID: 32788
		protected abstract FieldBuilder DefineUninitializedDataCore(string name, int size, FieldAttributes attributes);

		// Token: 0x06008015 RID: 32789 RVA: 0x0012E006 File Offset: 0x0012C206
		public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			ArgumentNullException.ThrowIfNull(arrayClass, "arrayClass");
			ArgumentException.ThrowIfNullOrEmpty(methodName, "methodName");
			return this.GetArrayMethodCore(arrayClass, methodName, callingConvention, returnType, parameterTypes);
		}

		// Token: 0x06008016 RID: 32790
		protected abstract MethodInfo GetArrayMethodCore(Type arrayClass, string methodName, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes);

		// Token: 0x06008017 RID: 32791 RVA: 0x0012E02B File Offset: 0x0012C22B
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06008018 RID: 32792
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06008019 RID: 32793 RVA: 0x0012E050 File Offset: 0x0012C250
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x0600801A RID: 32794
		public abstract int GetTypeMetadataToken(Type type);

		// Token: 0x0600801B RID: 32795
		public abstract int GetFieldMetadataToken(FieldInfo field);

		// Token: 0x0600801C RID: 32796
		public abstract int GetMethodMetadataToken(MethodInfo method);

		// Token: 0x0600801D RID: 32797
		public abstract int GetMethodMetadataToken(ConstructorInfo constructor);

		// Token: 0x0600801E RID: 32798
		public abstract int GetSignatureMetadataToken(SignatureHelper signature);

		// Token: 0x0600801F RID: 32799
		public abstract int GetStringMetadataToken(string stringConstant);
	}
}

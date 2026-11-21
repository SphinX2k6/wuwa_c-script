using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;

namespace System
{
	// Token: 0x0200009A RID: 154
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class Type : MemberInfo, IReflect
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x0001A399 File Offset: 0x00018599
		internal IntPtr GetUnderlyingNativeHandle()
		{
			return this._impl.Value;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00007B65 File Offset: 0x00005D65
		internal virtual bool IsTypeBuilder()
		{
			return false;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001A3A8 File Offset: 0x000185A8
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, ignoreCase, ref stackCrawlMark);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001A3C4 File Offset: 0x000185C4
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, false, ref stackCrawlMark);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001A3E0 File Offset: 0x000185E0
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, false, false, ref stackCrawlMark);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001A3FC File Offset: 0x000185FC
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] Func<AssemblyName, Assembly> assemblyResolver, [Nullable(new byte[]
		{
			2,
			2,
			1,
			2
		})] Func<Assembly, string, bool, Type> typeResolver)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Type.GetType(typeName, assemblyResolver, typeResolver, false, false, ref stackCrawlMark);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001A418 File Offset: 0x00018618
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] Func<AssemblyName, Assembly> assemblyResolver, [Nullable(new byte[]
		{
			2,
			2,
			1,
			2
		})] Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Type.GetType(typeName, assemblyResolver, typeResolver, throwOnError, false, ref stackCrawlMark);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0001A434 File Offset: 0x00018634
		[RequiresUnreferencedCode("The type might be removed")]
		[return: Nullable(2)]
		public static Type GetType(string typeName, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] Func<AssemblyName, Assembly> assemblyResolver, [Nullable(new byte[]
		{
			2,
			2,
			1,
			2
		})] Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Type.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackCrawlMark);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001A450 File Offset: 0x00018650
		[RequiresUnreferencedCode("The type might be removed")]
		private static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			return TypeNameResolver.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackMark);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001A45F File Offset: 0x0001865F
		[NullableContext(2)]
		public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
		{
			if (handle.Value == IntPtr.Zero)
			{
				return null;
			}
			return Type.internal_from_handle(handle.Value);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001A47D File Offset: 0x0001867D
		internal virtual Type InternalResolve()
		{
			return this.UnderlyingSystemType;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000FD41 File Offset: 0x0000DF41
		internal virtual Type RuntimeResolve()
		{
			throw new NotImplementedException();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000070DD File Offset: 0x000052DD
		internal virtual bool IsUserType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001A485 File Offset: 0x00018685
		internal virtual MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001A485 File Offset: 0x00018685
		internal virtual ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001A485 File Offset: 0x00018685
		internal virtual FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
		}

		// Token: 0x060007AA RID: 1962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_handle(IntPtr handle);

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001A499 File Offset: 0x00018699
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00009E60 File Offset: 0x00008060
		public new Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060007AE RID: 1966
		[Nullable(2)]
		public abstract string Namespace { [NullableContext(2)] get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060007AF RID: 1967
		[Nullable(2)]
		public abstract string AssemblyQualifiedName { [NullableContext(2)] get; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060007B0 RID: 1968
		[Nullable(2)]
		public abstract string FullName { [NullableContext(2)] get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060007B1 RID: 1969
		public abstract Assembly Assembly { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060007B2 RID: 1970
		public new abstract Module Module { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0001A49D File Offset: 0x0001869D
		public bool IsInterface
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001A4AC File Offset: 0x000186AC
		public bool IsNested
		{
			get
			{
				return this.DeclaringType != null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public override Type DeclaringType
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public virtual MethodBase DeclaringMethod
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public override Type ReflectedType
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060007B8 RID: 1976
		public abstract Type UnderlyingSystemType { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsTypeDefinition
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0001A4C4 File Offset: 0x000186C4
		public bool IsArray
		{
			get
			{
				return this.IsArrayImpl();
			}
		}

		// Token: 0x060007BB RID: 1979
		protected abstract bool IsArrayImpl();

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0001A4CC File Offset: 0x000186CC
		public bool IsByRef
		{
			get
			{
				return this.IsByRefImpl();
			}
		}

		// Token: 0x060007BD RID: 1981
		protected abstract bool IsByRefImpl();

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0001A4D4 File Offset: 0x000186D4
		public bool IsPointer
		{
			get
			{
				return this.IsPointerImpl();
			}
		}

		// Token: 0x060007BF RID: 1983
		protected abstract bool IsPointerImpl();

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsConstructedGenericType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0001A4DC File Offset: 0x000186DC
		public virtual bool IsGenericTypeParameter
		{
			get
			{
				return this.IsGenericParameter && this.DeclaringMethod == null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0001A4F1 File Offset: 0x000186F1
		public virtual bool IsGenericMethodParameter
		{
			get
			{
				return this.IsGenericParameter && this.DeclaringMethod != null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsGenericType
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSZArray
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0001A509 File Offset: 0x00018709
		public virtual bool IsVariableBoundArray
		{
			get
			{
				return this.IsArray && !this.IsSZArray;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual bool IsByRefLike
		{
			[Intrinsic]
			get
			{
				throw new NotSupportedException(SR.NotSupported_SubclassOverride);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsFunctionPointer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsUnmanagedFunctionPointer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001A52A File Offset: 0x0001872A
		public bool HasElementType
		{
			get
			{
				return this.HasElementTypeImpl();
			}
		}

		// Token: 0x060007CC RID: 1996
		protected abstract bool HasElementTypeImpl();

		// Token: 0x060007CD RID: 1997
		[NullableContext(2)]
		public abstract Type GetElementType();

		// Token: 0x060007CE RID: 1998 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual int GetArrayRank()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001A51E File Offset: 0x0001871E
		[Intrinsic]
		public virtual Type GetGenericTypeDefinition()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0001A532 File Offset: 0x00018732
		public virtual Type[] GenericTypeArguments
		{
			get
			{
				if (!this.IsGenericType || this.IsGenericTypeDefinition)
				{
					return Type.EmptyTypes;
				}
				return this.GetGenericArguments();
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001A550 File Offset: 0x00018750
		public virtual Type[] GetOptionalCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001A550 File Offset: 0x00018750
		public virtual Type[] GetRequiredCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0001A557 File Offset: 0x00018757
		public virtual int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException(SR.Arg_NotGenericParameter);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0001A56A File Offset: 0x0001876A
		public virtual Type[] GetGenericParameterConstraints()
		{
			if (!this.IsGenericParameter)
			{
				throw new InvalidOperationException(SR.Arg_NotGenericParameter);
			}
			throw new InvalidOperationException();
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001A584 File Offset: 0x00018784
		public TypeAttributes Attributes
		{
			get
			{
				return this.GetAttributeFlagsImpl();
			}
		}

		// Token: 0x060007D8 RID: 2008
		protected abstract TypeAttributes GetAttributeFlagsImpl();

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001A58C File Offset: 0x0001878C
		public bool IsAbstract
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) > TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0001A59D File Offset: 0x0001879D
		public bool IsImport
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001A5AE File Offset: 0x000187AE
		public bool IsSealed
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Sealed) > TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0001A5BF File Offset: 0x000187BF
		public bool IsSpecialName
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.SpecialName) > TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0001A5D0 File Offset: 0x000187D0
		public bool IsClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && !this.IsValueType;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0001A5E8 File Offset: 0x000187E8
		public bool IsNestedAssembly
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedAssembly;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0001A5F5 File Offset: 0x000187F5
		public bool IsNestedFamANDAssem
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamANDAssem;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0001A602 File Offset: 0x00018802
		public bool IsNestedFamily
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedFamily;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0001A60F File Offset: 0x0001880F
		public bool IsNestedFamORAssem
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.VisibilityMask;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0001A61C File Offset: 0x0001881C
		public bool IsNestedPrivate
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPrivate;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0001A629 File Offset: 0x00018829
		public bool IsNestedPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001A636 File Offset: 0x00018836
		public bool IsNotPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0001A643 File Offset: 0x00018843
		public bool IsPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.Public;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001A650 File Offset: 0x00018850
		public bool IsAutoLayout
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0001A65E File Offset: 0x0001885E
		public bool IsExplicitLayout
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.ExplicitLayout;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001A66D File Offset: 0x0001886D
		public bool IsLayoutSequential
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.SequentialLayout;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0001A67B File Offset: 0x0001887B
		public bool IsAnsiClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.NotPublic;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001A68C File Offset: 0x0001888C
		public bool IsAutoClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.AutoClass;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0001A6A1 File Offset: 0x000188A1
		public bool IsUnicodeClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.StringFormatMask) == TypeAttributes.UnicodeClass;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001A6B6 File Offset: 0x000188B6
		public bool IsCOMObject
		{
			get
			{
				return this.IsCOMObjectImpl();
			}
		}

		// Token: 0x060007ED RID: 2029
		protected abstract bool IsCOMObjectImpl();

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001A6BE File Offset: 0x000188BE
		public bool IsContextful
		{
			get
			{
				return this.IsContextfulImpl();
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00007B65 File Offset: 0x00005D65
		protected virtual bool IsContextfulImpl()
		{
			return false;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0001A6C6 File Offset: 0x000188C6
		public virtual bool IsEnum
		{
			[Intrinsic]
			get
			{
				return this.IsSubclassOf(typeof(Enum));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0001A6D8 File Offset: 0x000188D8
		public bool IsMarshalByRef
		{
			get
			{
				return this.IsMarshalByRefImpl();
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00007B65 File Offset: 0x00005D65
		protected virtual bool IsMarshalByRefImpl()
		{
			return false;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0001A6E0 File Offset: 0x000188E0
		public bool IsPrimitive
		{
			[Intrinsic]
			get
			{
				return this.IsPrimitiveImpl();
			}
		}

		// Token: 0x060007F4 RID: 2036
		protected abstract bool IsPrimitiveImpl();

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001A6E8 File Offset: 0x000188E8
		public bool IsValueType
		{
			[Intrinsic]
			get
			{
				return this.IsValueTypeImpl();
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001A6F0 File Offset: 0x000188F0
		protected virtual bool IsValueTypeImpl()
		{
			return this.IsSubclassOf(typeof(ValueType));
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0001A702 File Offset: 0x00018902
		[NullableContext(2)]
		[Intrinsic]
		public bool IsAssignableTo([NotNullWhen(true)] Type targetType)
		{
			return targetType != null && targetType.IsAssignableFrom(this);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSignatureType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecurityCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsSecurityTransparent
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0001A563 File Offset: 0x00018763
		[Nullable(2)]
		public virtual StructLayoutAttribute StructLayoutAttribute
		{
			[NullableContext(2)]
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0001A710 File Offset: 0x00018910
		[Nullable(2)]
		public ConstructorInfo TypeInitializer
		{
			[NullableContext(2)]
			[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
			get
			{
				return this.GetConstructorImpl(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, Type.EmptyTypes, null);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0001A722 File Offset: 0x00018922
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		[return: Nullable(2)]
		public ConstructorInfo GetConstructor(Type[] types)
		{
			return this.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, types, null);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0001A72F File Offset: 0x0001892F
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		[return: Nullable(2)]
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Type[] types)
		{
			return this.GetConstructor(bindingAttr, null, types, null);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0001A73B File Offset: 0x0001893B
		[NullableContext(2)]
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetConstructor(bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0001A74C File Offset: 0x0001894C
		[NullableContext(2)]
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			ArgumentNullException.ThrowIfNull(types, "types");
			for (int i = 0; i < types.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(types[i], "types");
			}
			return this.GetConstructorImpl(bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06000802 RID: 2050
		[NullableContext(2)]
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(1)] Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06000803 RID: 2051 RVA: 0x0001A78F File Offset: 0x0001898F
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		public ConstructorInfo[] GetConstructors()
		{
			return this.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		}

		// Token: 0x06000804 RID: 2052
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

		// Token: 0x06000805 RID: 2053 RVA: 0x0001A799 File Offset: 0x00018999
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		[return: Nullable(2)]
		public EventInfo GetEvent(string name)
		{
			return this.GetEvent(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000806 RID: 2054
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		[return: Nullable(2)]
		public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

		// Token: 0x06000807 RID: 2055 RVA: 0x0001A7A4 File Offset: 0x000189A4
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
		public virtual EventInfo[] GetEvents()
		{
			return this.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000808 RID: 2056
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

		// Token: 0x06000809 RID: 2057 RVA: 0x0001A7AE File Offset: 0x000189AE
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)]
		[return: Nullable(2)]
		public FieldInfo GetField(string name)
		{
			return this.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x0600080A RID: 2058
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		[return: Nullable(2)]
		public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

		// Token: 0x0600080B RID: 2059 RVA: 0x0001A7B9 File Offset: 0x000189B9
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)]
		public FieldInfo[] GetFields()
		{
			return this.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x0600080C RID: 2060
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

		// Token: 0x0600080D RID: 2061 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type[] GetFunctionPointerCallingConventions()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type GetFunctionPointerReturnType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type[] GetFunctionPointerParameterTypes()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001A7C3 File Offset: 0x000189C3
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2731)]
		public MemberInfo[] GetMember(string name)
		{
			return this.GetMember(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001A7CE File Offset: 0x000189CE
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			return this.GetMember(name, MemberTypes.All, bindingAttr);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0001A51E File Offset: 0x0001871E
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001A7DD File Offset: 0x000189DD
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2731)]
		public MemberInfo[] GetMembers()
		{
			return this.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0001A7E8 File Offset: 0x000189E8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "This is finding the MemberInfo with the same MetadataToken as specified MemberInfo. If the specified MemberInfo exists and wasn't trimmed, then the current Type's MemberInfo couldn't have been trimmed.")]
		public virtual MemberInfo GetMemberWithSameMetadataDefinitionAs(MemberInfo member)
		{
			ArgumentNullException.ThrowIfNull(member, "member");
			foreach (MemberInfo memberInfo in this.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (memberInfo.HasSameMetadataDefinitionAs(member))
				{
					return memberInfo;
				}
			}
			throw Type.CreateGetMemberWithSameMetadataDefinitionAsNotFoundException(member);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0001A82C File Offset: 0x00018A2C
		private protected static ArgumentException CreateGetMemberWithSameMetadataDefinitionAsNotFoundException(MemberInfo member)
		{
			return new ArgumentException(SR.Format(SR.Arg_MemberInfoNotFound, member.Name), "member");
		}

		// Token: 0x06000816 RID: 2070
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)8191)]
		public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

		// Token: 0x06000817 RID: 2071 RVA: 0x0001A848 File Offset: 0x00018A48
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0001A853 File Offset: 0x00018A53
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return this.GetMethodImpl(name, bindingAttr, null, CallingConventions.Any, null, null);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0001A86C File Offset: 0x00018A6C
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Type[] types)
		{
			return this.GetMethod(name, bindingAttr, null, types, null);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001A879 File Offset: 0x00018A79
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, Type[] types)
		{
			return this.GetMethod(name, types, null);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001A884 File Offset: 0x00018A84
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, Type[] types, [Nullable(2)] ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, modifiers);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001A892 File Offset: 0x00018A92
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public MethodInfo GetMethod([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public MethodInfo GetMethod([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(types, "types");
			for (int i = 0; i < types.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(types[i], "types");
			}
			return this.GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x0600081E RID: 2078
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected abstract MethodInfo GetMethodImpl([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers);

		// Token: 0x0600081F RID: 2079 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types)
		{
			return this.GetMethod(name, genericParameterCount, types, null);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0001A900 File Offset: 0x00018B00
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types, [Nullable(2)] ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, genericParameterCount, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, modifiers);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0001A910 File Offset: 0x00018B10
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, int genericParameterCount, BindingFlags bindingAttr, Type[] types)
		{
			return this.GetMethod(name, genericParameterCount, bindingAttr, null, types, null);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001A91F File Offset: 0x00018B1F
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public MethodInfo GetMethod([Nullable(1)] string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, genericParameterCount, bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001A934 File Offset: 0x00018B34
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public MethodInfo GetMethod([Nullable(1)] string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(genericParameterCount, "genericParameterCount");
			ArgumentNullException.ThrowIfNull(types, "types");
			for (int i = 0; i < types.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(types[i], "types");
			}
			return this.GetMethodImpl(name, genericParameterCount, bindingAttr, binder, callConvention, types, modifiers);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001A563 File Offset: 0x00018763
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		protected virtual MethodInfo GetMethodImpl([Nullable(1)] string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001A991 File Offset: 0x00018B91
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		public MethodInfo[] GetMethods()
		{
			return this.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000826 RID: 2086
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

		// Token: 0x06000827 RID: 2087 RVA: 0x0001A99B File Offset: 0x00018B9B
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes)]
		[return: Nullable(2)]
		public Type GetNestedType(string name)
		{
			return this.GetNestedType(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000828 RID: 2088
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		[return: Nullable(2)]
		public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

		// Token: 0x06000829 RID: 2089 RVA: 0x0001A9A6 File Offset: 0x00018BA6
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes)]
		public Type[] GetNestedTypes()
		{
			return this.GetNestedTypes(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x0600082A RID: 2090
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		public abstract Type[] GetNestedTypes(BindingFlags bindingAttr);

		// Token: 0x0600082B RID: 2091 RVA: 0x0001A9B0 File Offset: 0x00018BB0
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		[return: Nullable(2)]
		public PropertyInfo GetProperty(string name)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001A9BB File Offset: 0x00018BBB
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		[return: Nullable(2)]
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return this.GetPropertyImpl(name, bindingAttr, null, null, null, null);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001A9D4 File Offset: 0x00018BD4
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "Linker doesn't recognize GetPropertyImpl(BindingFlags.Public) but this is what the body is doing")]
		public PropertyInfo GetProperty([Nullable(1)] string name, Type returnType)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return this.GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, null, null);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001A9EE File Offset: 0x00018BEE
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		[return: Nullable(2)]
		public PropertyInfo GetProperty(string name, Type[] types)
		{
			return this.GetProperty(name, null, types);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001A9F9 File Offset: 0x00018BF9
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		[return: Nullable(2)]
		public PropertyInfo GetProperty(string name, [Nullable(2)] Type returnType, Type[] types)
		{
			return this.GetProperty(name, returnType, types, null);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001AA05 File Offset: 0x00018C05
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		public PropertyInfo GetProperty([Nullable(1)] string name, Type returnType, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, types, modifiers);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0001AA15 File Offset: 0x00018C15
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public PropertyInfo GetProperty([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, Type returnType, [Nullable(1)] Type[] types, ParameterModifier[] modifiers)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(types, "types");
			return this.GetPropertyImpl(name, bindingAttr, binder, returnType, types, modifiers);
		}

		// Token: 0x06000832 RID: 2098
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		protected abstract PropertyInfo GetPropertyImpl([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers);

		// Token: 0x06000833 RID: 2099 RVA: 0x0001AA3D File Offset: 0x00018C3D
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
		public PropertyInfo[] GetProperties()
		{
			return this.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000834 RID: 2100
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		// Token: 0x06000835 RID: 2101 RVA: 0x0001A4BD File Offset: 0x000186BD
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2731)]
		public virtual MemberInfo[] GetDefaultMembers()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0001AA48 File Offset: 0x00018C48
		public virtual RuntimeTypeHandle TypeHandle
		{
			[Intrinsic]
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001AA5A File Offset: 0x00018C5A
		public static RuntimeTypeHandle GetTypeHandle(object o)
		{
			ArgumentNullException.ThrowIfNull(o, "o");
			return o.GetType().TypeHandle;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0001AA74 File Offset: 0x00018C74
		public static Type[] GetTypeArray(object[] args)
		{
			ArgumentNullException.ThrowIfNull(args, "args");
			Type[] array = new Type[args.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (args[i] == null)
				{
					throw new ArgumentException(SR.ArgumentNull_ArrayValue, "args");
				}
				array[i] = args[i].GetType();
			}
			return array;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TypeCode GetTypeCode(Type type)
		{
			if (RuntimeHelpers.IsKnownConstant(type) && type is RuntimeType)
			{
				return Type.GetRuntimeTypeCode((RuntimeType)type);
			}
			if (type == null)
			{
				return TypeCode.Empty;
			}
			return type.GetTypeCodeImpl();
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static TypeCode GetRuntimeTypeCode(RuntimeType type)
		{
			RuntimeType left = type;
			if (type.IsActualEnum)
			{
				left = (RuntimeType)type.GetEnumUnderlyingType();
			}
			if (left == typeof(sbyte))
			{
				return TypeCode.SByte;
			}
			if (left == typeof(byte))
			{
				return TypeCode.Byte;
			}
			if (left == typeof(short))
			{
				return TypeCode.Int16;
			}
			if (left == typeof(ushort))
			{
				return TypeCode.UInt16;
			}
			if (left == typeof(int))
			{
				return TypeCode.Int32;
			}
			if (left == typeof(uint))
			{
				return TypeCode.UInt32;
			}
			if (left == typeof(long))
			{
				return TypeCode.Int64;
			}
			if (left == typeof(ulong))
			{
				return TypeCode.UInt64;
			}
			if (left == typeof(bool))
			{
				return TypeCode.Boolean;
			}
			if (left == typeof(char))
			{
				return TypeCode.Char;
			}
			if (left == typeof(float))
			{
				return TypeCode.Single;
			}
			if (left == typeof(double))
			{
				return TypeCode.Double;
			}
			if (left == typeof(decimal))
			{
				return TypeCode.Decimal;
			}
			if (left == typeof(DateTime))
			{
				return TypeCode.DateTime;
			}
			if (left == typeof(string))
			{
				return TypeCode.String;
			}
			if (left == typeof(DBNull))
			{
				return TypeCode.DBNull;
			}
			return TypeCode.Object;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001AC60 File Offset: 0x00018E60
		protected virtual TypeCode GetTypeCodeImpl()
		{
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (this != underlyingSystemType && underlyingSystemType != null)
			{
				return Type.GetTypeCode(underlyingSystemType);
			}
			return TypeCode.Object;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600083C RID: 2108
		public abstract Guid GUID { get; }

		// Token: 0x0600083D RID: 2109 RVA: 0x0001AC83 File Offset: 0x00018E83
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromCLSID(Guid clsid)
		{
			return Type.GetTypeFromCLSID(clsid, null, false);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001AC8D File Offset: 0x00018E8D
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromCLSID(Guid clsid, bool throwOnError)
		{
			return Type.GetTypeFromCLSID(clsid, null, throwOnError);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0001AC97 File Offset: 0x00018E97
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromCLSID(Guid clsid, string server)
		{
			return Type.GetTypeFromCLSID(clsid, server, false);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001ACA1 File Offset: 0x00018EA1
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError)
		{
			return Marshal.GetTypeFromCLSID(clsid, server, throwOnError);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001ACAB File Offset: 0x00018EAB
		[SupportedOSPlatform("windows")]
		[return: Nullable(2)]
		public static Type GetTypeFromProgID(string progID)
		{
			return Type.GetTypeFromProgID(progID, null, false);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0001ACB5 File Offset: 0x00018EB5
		[SupportedOSPlatform("windows")]
		[return: Nullable(2)]
		public static Type GetTypeFromProgID(string progID, bool throwOnError)
		{
			return Type.GetTypeFromProgID(progID, null, throwOnError);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0001ACBF File Offset: 0x00018EBF
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromProgID([Nullable(1)] string progID, string server)
		{
			return Type.GetTypeFromProgID(progID, server, false);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001ACC9 File Offset: 0x00018EC9
		[NullableContext(2)]
		[SupportedOSPlatform("windows")]
		public static Type GetTypeFromProgID([Nullable(1)] string progID, string server, bool throwOnError)
		{
			return Marshal.GetTypeFromProgID(progID, server, throwOnError);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000845 RID: 2117
		[Nullable(2)]
		public abstract Type BaseType { [NullableContext(2)] get; }

		// Token: 0x06000846 RID: 2118 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public object InvokeMember([Nullable(1)] string name, BindingFlags invokeAttr, Binder binder, object target, object[] args)
		{
			return this.InvokeMember(name, invokeAttr, binder, target, args, null, null, null);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		[NullableContext(2)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public object InvokeMember([Nullable(1)] string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture)
		{
			return this.InvokeMember(name, invokeAttr, binder, target, args, null, culture, null);
		}

		// Token: 0x06000848 RID: 2120
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public abstract object InvokeMember([Nullable(1)] string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, [Nullable(new byte[]
		{
			2,
			1
		})] string[] namedParameters);

		// Token: 0x06000849 RID: 2121 RVA: 0x0001AD12 File Offset: 0x00018F12
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: Nullable(2)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public Type GetInterface(string name)
		{
			return this.GetInterface(name, false);
		}

		// Token: 0x0600084A RID: 2122
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		[return: Nullable(2)]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public abstract Type GetInterface(string name, bool ignoreCase);

		// Token: 0x0600084B RID: 2123
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public abstract Type[] GetInterfaces();

		// Token: 0x0600084C RID: 2124 RVA: 0x0001AD1C File Offset: 0x00018F1C
		public virtual InterfaceMapping GetInterfaceMap([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001AD33 File Offset: 0x00018F33
		[NullableContext(2)]
		public virtual bool IsInstanceOfType([NotNullWhen(true)] object o)
		{
			return o != null && this.IsAssignableFrom(o.GetType());
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001AD46 File Offset: 0x00018F46
		[NullableContext(2)]
		public virtual bool IsEquivalentTo([NotNullWhen(true)] Type other)
		{
			return this == other;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0001AD50 File Offset: 0x00018F50
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "The single instance field on enum types is never trimmed")]
		[Intrinsic]
		public virtual Type GetEnumUnderlyingType()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "enumType");
			}
			FieldInfo[] fields = this.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (fields == null || fields.Length != 1)
			{
				throw new ArgumentException(SR.Argument_InvalidEnum, "enumType");
			}
			return fields[0].FieldType;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0001AD9F File Offset: 0x00018F9F
		[RequiresDynamicCode("It might not be possible to create an array of the enum type at runtime. Use Enum.GetValues<T> or the GetEnumValuesAsUnderlyingType method instead.")]
		public virtual Array GetEnumValues()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "enumType");
			}
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual Array GetEnumValuesAsUnderlyingType()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001A563 File Offset: 0x00018763
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public virtual Type MakeArrayType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0001A563 File Offset: 0x00018763
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public virtual Type MakeArrayType(int rank)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type MakeByRefType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0001A51E File Offset: 0x0001871E
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public virtual Type MakeGenericType(params Type[] typeArguments)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type MakePointerType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001ADBE File Offset: 0x00018FBE
		public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments)
		{
			return new SignatureConstructedGenericType(genericTypeDefinition, typeArguments);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0001ADC7 File Offset: 0x00018FC7
		public static Type MakeGenericMethodParameter(int position)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(position, "position");
			return new SignatureGenericMethodParameterType(position);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0001ADDC File Offset: 0x00018FDC
		internal string FormatTypeName()
		{
			Type rootElementType = this.GetRootElementType();
			if (rootElementType.IsPrimitive || rootElementType.IsNested || rootElementType == typeof(void) || rootElementType == typeof(TypedReference))
			{
				return this.Name;
			}
			return this.ToString();
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0001AE31 File Offset: 0x00019031
		public override string ToString()
		{
			return "Type: " + this.Name;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001AE43 File Offset: 0x00019043
		[NullableContext(2)]
		public override bool Equals(object o)
		{
			return o != null && this.Equals(o as Type);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001AE58 File Offset: 0x00019058
		public override int GetHashCode()
		{
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType != this)
			{
				return underlyingSystemType.GetHashCode();
			}
			return base.GetHashCode();
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0001AE7D File Offset: 0x0001907D
		[NullableContext(2)]
		public virtual bool Equals(Type o)
		{
			return !(o == null) && this.UnderlyingSystemType == o.UnderlyingSystemType;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001AE98 File Offset: 0x00019098
		[NullableContext(2)]
		[Intrinsic]
		public static bool operator ==(Type left, Type right)
		{
			return left == right || (left != null && right != null && !(left is RuntimeType) && !(right is RuntimeType) && left.Equals(right));
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001AEBF File Offset: 0x000190BF
		[NullableContext(2)]
		[Intrinsic]
		public static bool operator !=(Type left, Type right)
		{
			return !(left == right);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0001AECB File Offset: 0x000190CB
		[Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[return: Nullable(2)]
		public static Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ReflectionOnly);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0001AED7 File Offset: 0x000190D7
		public static Binder DefaultBinder
		{
			get
			{
				Binder result;
				if ((result = Type.s_defaultBinder) == null)
				{
					result = (Interlocked.CompareExchange<Binder>(ref Type.s_defaultBinder, new DefaultBinder(), null) ?? Type.s_defaultBinder);
				}
				return result;
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001AEFC File Offset: 0x000190FC
		public virtual bool IsEnumDefined(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (!this.IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "value");
			}
			Type type = value.GetType();
			if (type.IsEnum)
			{
				if (!type.IsEquivalentTo(this))
				{
					throw new ArgumentException(SR.Format(SR.Arg_EnumAndObjectMustBeSameType, type, this));
				}
				type = type.GetEnumUnderlyingType();
			}
			if (type == typeof(string))
			{
				object[] enumNames = this.GetEnumNames();
				return Array.IndexOf<object>(enumNames, value) >= 0;
			}
			if (!Type.IsIntegerType(type))
			{
				throw new InvalidOperationException(SR.InvalidOperation_UnknownEnumType);
			}
			Type enumUnderlyingType = this.GetEnumUnderlyingType();
			if (enumUnderlyingType.GetTypeCodeImpl() != type.GetTypeCodeImpl())
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumUnderlyingTypeAndObjectMustBeSameType, type, enumUnderlyingType));
			}
			return Type.BinarySearch(this.GetEnumRawConstantValues(), value) >= 0;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001AFD0 File Offset: 0x000191D0
		[return: Nullable(2)]
		public virtual string GetEnumName(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (!this.IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "value");
			}
			Type type = value.GetType();
			if (!type.IsEnum && !Type.IsIntegerType(type))
			{
				throw new ArgumentException(SR.Arg_MustBeEnumBaseTypeOrEnum, "value");
			}
			int num = Type.BinarySearch(this.GetEnumRawConstantValues(), value);
			if (num >= 0)
			{
				return this.GetEnumNames()[num];
			}
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0001B044 File Offset: 0x00019244
		public virtual string[] GetEnumNames()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(SR.Arg_MustBeEnum, "enumType");
			}
			string[] result;
			Array array;
			this.GetEnumData(out result, out array);
			return result;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0001B074 File Offset: 0x00019274
		private Array GetEnumRawConstantValues()
		{
			string[] array;
			Array result;
			this.GetEnumData(out array, out result);
			return result;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001B08C File Offset: 0x0001928C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "Literal fields on enums can never be trimmed")]
		private void GetEnumData(out string[] enumNames, out Array enumValues)
		{
			FieldInfo[] fields = this.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] array = new object[fields.Length];
			string[] array2 = new string[fields.Length];
			for (int i = 0; i < fields.Length; i++)
			{
				array2[i] = fields[i].Name;
				array[i] = fields[i].GetRawConstantValue();
			}
			Comparer @default = Comparer.Default;
			for (int j = 1; j < array.Length; j++)
			{
				int num = j;
				string text = array2[j];
				object obj = array[j];
				bool flag = false;
				while (@default.Compare(array[num - 1], obj) > 0)
				{
					array2[num] = array2[num - 1];
					array[num] = array[num - 1];
					num--;
					flag = true;
					if (num == 0)
					{
						break;
					}
				}
				if (flag)
				{
					array2[num] = text;
					array[num] = obj;
				}
			}
			enumNames = array2;
			enumValues = array;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001B158 File Offset: 0x00019358
		private static int BinarySearch(Array array, object value)
		{
			ulong[] array2 = new ulong[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Enum.ToUInt64(array.GetValue(i));
			}
			ulong value2 = Enum.ToUInt64(value);
			return Array.BinarySearch<ulong>(array2, value2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001B1A0 File Offset: 0x000193A0
		internal static bool IsIntegerType(Type t)
		{
			return t == typeof(int) || t == typeof(short) || t == typeof(ushort) || t == typeof(byte) || t == typeof(sbyte) || t == typeof(uint) || t == typeof(long) || t == typeof(ulong) || t == typeof(char);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0001B254 File Offset: 0x00019454
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public virtual bool IsSerializable
		{
			get
			{
				if ((this.GetAttributeFlagsImpl() & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
				{
					return true;
				}
				Type type = this.UnderlyingSystemType;
				if (type is RuntimeType)
				{
					while (!(type == typeof(Delegate)) && !(type == typeof(Enum)))
					{
						type = type.BaseType;
						if (!(type != null))
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0001B2B8 File Offset: 0x000194B8
		public virtual bool ContainsGenericParameters
		{
			get
			{
				if (this.HasElementType)
				{
					return this.GetRootElementType().ContainsGenericParameters;
				}
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (!this.IsGenericType)
				{
					return false;
				}
				Type[] genericArguments = this.GetGenericArguments();
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (genericArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001B310 File Offset: 0x00019510
		internal Type GetRootElementType()
		{
			Type type = this;
			while (type.HasElementType)
			{
				type = type.GetElementType();
			}
			return type;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0001B334 File Offset: 0x00019534
		public bool IsVisible
		{
			get
			{
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (this.HasElementType)
				{
					return this.GetElementType().IsVisible;
				}
				Type type = this;
				while (type.IsNested)
				{
					if (!type.IsNestedPublic)
					{
						return false;
					}
					type = type.DeclaringType;
				}
				if (!type.IsPublic)
				{
					return false;
				}
				if (this.IsGenericType && !this.IsGenericTypeDefinition)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (!genericArguments[i].IsVisible)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0001B3B8 File Offset: 0x000195B8
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
		public virtual Type[] FindInterfaces(TypeFilter filter, [Nullable(2)] object filterCriteria)
		{
			ArgumentNullException.ThrowIfNull(filter, "filter");
			Type[] interfaces = this.GetInterfaces();
			int num = 0;
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (!filter(interfaces[i], filterCriteria))
				{
					interfaces[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == interfaces.Length)
			{
				return interfaces;
			}
			Type[] array = new Type[num];
			num = 0;
			foreach (Type type in interfaces)
			{
				if (type != null)
				{
					array[num++] = type;
				}
			}
			return array;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0001B434 File Offset: 0x00019634
		[NullableContext(2)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		[return: Nullable(1)]
		public virtual MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria)
		{
			MethodInfo[] array = null;
			ConstructorInfo[] array2 = null;
			FieldInfo[] array3 = null;
			PropertyInfo[] array4 = null;
			EventInfo[] array5 = null;
			Type[] array6 = null;
			int num = 0;
			if ((memberType & MemberTypes.Method) != (MemberTypes)0)
			{
				array = this.GetMethods(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (!filter(array[i], filterCriteria))
						{
							array[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array.Length;
				}
			}
			if ((memberType & MemberTypes.Constructor) != (MemberTypes)0)
			{
				array2 = this.GetConstructors(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						if (!filter(array2[i], filterCriteria))
						{
							array2[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array2.Length;
				}
			}
			if ((memberType & MemberTypes.Field) != (MemberTypes)0)
			{
				array3 = this.GetFields(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						if (!filter(array3[i], filterCriteria))
						{
							array3[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array3.Length;
				}
			}
			if ((memberType & MemberTypes.Property) != (MemberTypes)0)
			{
				array4 = this.GetProperties(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array4.Length; i++)
					{
						if (!filter(array4[i], filterCriteria))
						{
							array4[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array4.Length;
				}
			}
			if ((memberType & MemberTypes.Event) != (MemberTypes)0)
			{
				array5 = this.GetEvents(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array5.Length; i++)
					{
						if (!filter(array5[i], filterCriteria))
						{
							array5[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array5.Length;
				}
			}
			if ((memberType & MemberTypes.NestedType) != (MemberTypes)0)
			{
				array6 = this.GetNestedTypes(bindingAttr);
				if (filter != null)
				{
					for (int i = 0; i < array6.Length; i++)
					{
						if (!filter(array6[i], filterCriteria))
						{
							array6[i] = null;
						}
						else
						{
							num++;
						}
					}
				}
				else
				{
					num += array6.Length;
				}
			}
			MemberInfo[] array7 = new MemberInfo[num];
			num = 0;
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null)
					{
						array7[num++] = array[i];
					}
				}
			}
			if (array2 != null)
			{
				foreach (ConstructorInfo constructorInfo in array2)
				{
					if (constructorInfo != null)
					{
						array7[num++] = constructorInfo;
					}
				}
			}
			if (array3 != null)
			{
				foreach (FieldInfo fieldInfo in array3)
				{
					if (fieldInfo != null)
					{
						array7[num++] = fieldInfo;
					}
				}
			}
			if (array4 != null)
			{
				foreach (PropertyInfo propertyInfo in array4)
				{
					if (propertyInfo != null)
					{
						array7[num++] = propertyInfo;
					}
				}
			}
			if (array5 != null)
			{
				foreach (EventInfo eventInfo in array5)
				{
					if (eventInfo != null)
					{
						array7[num++] = eventInfo;
					}
				}
			}
			if (array6 != null)
			{
				foreach (Type type in array6)
				{
					if (type != null)
					{
						array7[num++] = type;
					}
				}
			}
			return array7;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001B728 File Offset: 0x00019928
		public virtual bool IsSubclassOf(Type c)
		{
			Type type = this;
			if (type == c)
			{
				return false;
			}
			while (type != null)
			{
				if (type == c)
				{
					return true;
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001B760 File Offset: 0x00019960
		[NullableContext(2)]
		[Intrinsic]
		public virtual bool IsAssignableFrom([NotNullWhen(true)] Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (this == c)
			{
				return true;
			}
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType is RuntimeType)
			{
				return underlyingSystemType.IsAssignableFrom(c);
			}
			if (c.IsSubclassOf(this))
			{
				return true;
			}
			if (this.IsInterface)
			{
				return c.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(c))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001B7E4 File Offset: 0x000199E4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2085:UnrecognizedReflectionPattern", Justification = "The GetInterfaces technically requires all interfaces to be preservedBut this method only compares the result against the passed in ifaceType.So if ifaceType exists, then trimming should have kept it implemented on any type.")]
		internal bool ImplementInterface(Type ifaceType)
		{
			Type type = this;
			while (type != null)
			{
				Type[] interfaces = type.GetInterfaces();
				if (interfaces != null)
				{
					for (int i = 0; i < interfaces.Length; i++)
					{
						if (interfaces[i] == ifaceType || (interfaces[i] != null && interfaces[i].ImplementInterface(ifaceType)))
						{
							return true;
						}
					}
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001B844 File Offset: 0x00019A44
		private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null)
			{
				throw new InvalidFilterCriteriaException(SR.InvalidFilterCriteriaException_CritInt);
			}
			MemberTypes memberType = m.MemberType;
			if (memberType != MemberTypes.Constructor)
			{
				if (memberType == MemberTypes.Field)
				{
					FieldAttributes fieldAttributes;
					try
					{
						fieldAttributes = (FieldAttributes)((int)filterCriteria);
					}
					catch
					{
						throw new InvalidFilterCriteriaException(SR.InvalidFilterCriteriaException_CritInt);
					}
					FieldAttributes attributes = ((FieldInfo)m).Attributes;
					return ((fieldAttributes & FieldAttributes.FieldAccessMask) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.FieldAccessMask) == (fieldAttributes & FieldAttributes.FieldAccessMask)) && ((fieldAttributes & FieldAttributes.Static) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.InitOnly) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.InitOnly) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.Literal) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Literal) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.NotSerialized) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.NotSerialized) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.PinvokeImpl) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.PinvokeImpl) != FieldAttributes.PrivateScope);
				}
				if (memberType != MemberTypes.Method)
				{
					return false;
				}
			}
			MethodAttributes methodAttributes;
			try
			{
				methodAttributes = (MethodAttributes)((int)filterCriteria);
			}
			catch
			{
				throw new InvalidFilterCriteriaException(SR.InvalidFilterCriteriaException_CritInt);
			}
			MethodAttributes attributes2;
			if (m.MemberType == MemberTypes.Method)
			{
				attributes2 = ((MethodInfo)m).Attributes;
			}
			else
			{
				attributes2 = ((ConstructorInfo)m).Attributes;
			}
			return ((methodAttributes & MethodAttributes.MemberAccessMask) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.MemberAccessMask) == (methodAttributes & MethodAttributes.MemberAccessMask)) && ((methodAttributes & MethodAttributes.Static) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Static) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Final) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Final) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Virtual) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Abstract) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.SpecialName) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.SpecialName) != MethodAttributes.PrivateScope);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		private static bool FilterNameImpl(MemberInfo m, object filterCriteria, StringComparison comparison)
		{
			string text = filterCriteria as string;
			if (text == null)
			{
				throw new InvalidFilterCriteriaException(SR.InvalidFilterCriteriaException_CritString);
			}
			ReadOnlySpan<char> readOnlySpan = text.AsSpan().Trim();
			ReadOnlySpan<char> span = m.Name;
			if (m.MemberType == MemberTypes.NestedType)
			{
				span = span.Slice(span.LastIndexOf('+') + 1);
			}
			if (readOnlySpan.EndsWith('*'))
			{
				readOnlySpan = readOnlySpan.Slice(0, readOnlySpan.Length - 1);
				return span.StartsWith(readOnlySpan, comparison);
			}
			return span.Equals(readOnlySpan, comparison);
		}

		// Token: 0x0400029C RID: 668
		internal RuntimeTypeHandle _impl;

		// Token: 0x0400029D RID: 669
		internal LoaderAllocator m_keepalive;

		// Token: 0x0400029E RID: 670
		private static Binder s_defaultBinder;

		// Token: 0x0400029F RID: 671
		public static readonly char Delimiter = '.';

		// Token: 0x040002A0 RID: 672
		public static readonly Type[] EmptyTypes = Array.Empty<Type>();

		// Token: 0x040002A1 RID: 673
		public static readonly object Missing = System.Reflection.Missing.Value;

		// Token: 0x040002A2 RID: 674
		public static readonly MemberFilter FilterAttribute = new MemberFilter(Type.FilterAttributeImpl);

		// Token: 0x040002A3 RID: 675
		public static readonly MemberFilter FilterName = (MemberInfo m, object c) => Type.FilterNameImpl(m, c, StringComparison.Ordinal);

		// Token: 0x040002A4 RID: 676
		public static readonly MemberFilter FilterNameIgnoreCase = (MemberInfo m, object c) => Type.FilterNameImpl(m, c, StringComparison.OrdinalIgnoreCase);
	}
}

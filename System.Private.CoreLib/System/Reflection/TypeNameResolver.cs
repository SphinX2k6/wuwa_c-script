using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200071B RID: 1819
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct TypeNameResolver
	{
		// Token: 0x0600784F RID: 30799 RVA: 0x0011E260 File Offset: 0x0011C460
		[RequiresUnreferencedCode("The type might be removed")]
		internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			ArgumentNullException.ThrowIfNull(typeName, "typeName");
			if (typeName.Length == 0)
			{
				if (throwOnError)
				{
					throw new TypeLoadException(SR.Arg_TypeLoadNullStr);
				}
				return null;
			}
			else
			{
				TypeName typeName2 = TypeNameParser.Parse(typeName, throwOnError, null);
				if (typeName2 == null)
				{
					return null;
				}
				TypeNameResolver typeNameResolver = default(TypeNameResolver);
				typeNameResolver._assemblyResolver = assemblyResolver;
				typeNameResolver._typeResolver = typeResolver;
				typeNameResolver._throwOnError = throwOnError;
				typeNameResolver._ignoreCase = ignoreCase;
				typeNameResolver._stackMark = Unsafe.AsPointer<StackCrawlMark>(ref stackMark);
				return typeNameResolver.Resolve(typeName2);
			}
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x0011E2EC File Offset: 0x0011C4EC
		private Assembly ResolveAssembly(AssemblyName name)
		{
			Assembly assembly;
			if (this._assemblyResolver != null)
			{
				assembly = this._assemblyResolver(name);
				if (assembly == null && this._throwOnError)
				{
					throw new FileNotFoundException(SR.Format(SR.FileNotFound_ResolveAssembly, name.FullName));
				}
			}
			else
			{
				ref StackCrawlMark stackMark = ref Unsafe.AsRef<StackCrawlMark>(this._stackMark);
				if (!this._throwOnError)
				{
					try
					{
						assembly = Assembly.Load(name, ref stackMark, null);
					}
					catch (FileNotFoundException)
					{
						return null;
					}
					return assembly;
				}
				assembly = Assembly.Load(name, ref stackMark, null);
			}
			return assembly;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0011E374 File Offset: 0x0011C574
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "TypeNameResolver.GetType is marked as RequiresUnreferencedCode.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "TypeNameResolver.GetType is marked as RequiresUnreferencedCode.")]
		private unsafe Type GetType(string escapedTypeName, ReadOnlySpan<string> nestedTypeNames, TypeName parsedName)
		{
			Assembly assembly = (parsedName.AssemblyName != null) ? this.ResolveAssembly(parsedName.AssemblyName.ToAssemblyName()) : null;
			Type type;
			if (this._typeResolver != null)
			{
				type = this._typeResolver(assembly, escapedTypeName, this._ignoreCase);
				if (type == null)
				{
					if (this._throwOnError)
					{
						throw new TypeLoadException((assembly == null) ? SR.Format(SR.TypeLoad_ResolveType, escapedTypeName) : SR.Format(SR.TypeLoad_ResolveTypeFromAssembly, escapedTypeName, assembly.FullName));
					}
					return null;
				}
			}
			else
			{
				if (assembly == null)
				{
					ref StackCrawlMark stackMark = ref Unsafe.AsRef<StackCrawlMark>(this._stackMark);
					type = RuntimeType.GetType(escapedTypeName, this._throwOnError, this._ignoreCase, ref stackMark);
				}
				else
				{
					type = assembly.GetType(escapedTypeName, this._throwOnError, this._ignoreCase);
				}
				if (type == null)
				{
					return null;
				}
			}
			int i = 0;
			while (i < nestedTypeNames.Length)
			{
				BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
				if (this._ignoreCase)
				{
					bindingFlags |= BindingFlags.IgnoreCase;
				}
				type = type.GetNestedType(*nestedTypeNames[i], bindingFlags);
				if (type == null)
				{
					if (this._throwOnError)
					{
						throw new TypeLoadException(SR.Format(SR.TypeLoad_ResolveNestedType, *nestedTypeNames[i], (i > 0) ? (*nestedTypeNames[i - 1]) : TypeNameHelpers.Unescape(escapedTypeName)));
					}
					return null;
				}
				else
				{
					i++;
				}
			}
			return type;
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0011E4A0 File Offset: 0x0011C6A0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL3050:RequiresDynamicCode", Justification = "Used to implement resolving types from strings.")]
		private Type Resolve(TypeName typeName)
		{
			if (typeName.IsSimple)
			{
				return this.GetSimpleType(typeName);
			}
			if (typeName.IsConstructedGenericType)
			{
				return this.GetGenericType(typeName);
			}
			if (typeName.IsArray || typeName.IsPointer || typeName.IsByRef)
			{
				Type type = this.Resolve(typeName.GetElementType());
				if (type == null)
				{
					return null;
				}
				if (typeName.IsArray)
				{
					if (!typeName.IsSZArray)
					{
						return type.MakeArrayType(typeName.GetArrayRank());
					}
					return type.MakeArrayType();
				}
				else
				{
					if (typeName.IsByRef)
					{
						return type.MakeByRefType();
					}
					if (typeName.IsPointer)
					{
						return type.MakePointerType();
					}
				}
			}
			return null;
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0011E53C File Offset: 0x0011C73C
		private Type GetSimpleType(TypeName typeName)
		{
			if (typeName.IsNested)
			{
				TypeName typeName2 = typeName;
				int num = 0;
				do
				{
					num++;
					typeName2 = typeName2.DeclaringType;
				}
				while (typeName2.IsNested);
				string[] array = new string[num];
				typeName2 = typeName;
				while (typeName2.IsNested)
				{
					array[--num] = TypeNameHelpers.Unescape(typeName2.Name);
					typeName2 = typeName2.DeclaringType;
				}
				return this.GetType(typeName2.FullName, array, typeName);
			}
			return this.GetType(typeName.FullName, default(ReadOnlySpan<string>), typeName);
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x0011E5C0 File Offset: 0x0011C7C0
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:UnrecognizedReflectionPattern", Justification = "Used to implement resolving types from strings.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL3050:RequiresDynamicCode", Justification = "Used to implement resolving types from strings.")]
		private unsafe Type GetGenericType(TypeName typeName)
		{
			Type type = this.Resolve(typeName.GetGenericTypeDefinition());
			if (type == null)
			{
				return null;
			}
			ReadOnlySpan<TypeName> genericArguments = typeName.GetGenericArguments();
			Type[] array = new Type[genericArguments.Length];
			for (int i = 0; i < genericArguments.Length; i++)
			{
				Type type2 = this.Resolve(*genericArguments[i]);
				if (type2 == null)
				{
					return null;
				}
				array[i] = type2;
			}
			return type.MakeGenericType(array);
		}

		// Token: 0x040015E1 RID: 5601
		private Func<AssemblyName, Assembly> _assemblyResolver;

		// Token: 0x040015E2 RID: 5602
		private Func<Assembly, string, bool, Type> _typeResolver;

		// Token: 0x040015E3 RID: 5603
		private bool _throwOnError;

		// Token: 0x040015E4 RID: 5604
		private bool _ignoreCase;

		// Token: 0x040015E5 RID: 5605
		private unsafe void* _stackMark;
	}
}

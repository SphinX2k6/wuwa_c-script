using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000760 RID: 1888
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Module : ICustomAttributeProvider, ISerializable
	{
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Assembly Assembly
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x0600796E RID: 31086 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public virtual string FullyQualifiedName
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresAssemblyFiles("Returns <Unknown> for modules with no file path")]
		public virtual string Name
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual int MDStreamVersion
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06007971 RID: 31089 RVA: 0x001203C8 File Offset: 0x0011E5C8
		public virtual Guid ModuleVersionId
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual string ScopeName
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06007973 RID: 31091 RVA: 0x001203DA File Offset: 0x0011E5DA
		public ModuleHandle ModuleHandle
		{
			get
			{
				return this.GetModuleHandleImpl();
			}
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x001203E2 File Offset: 0x0011E5E2
		private protected virtual ModuleHandle GetModuleHandleImpl()
		{
			return ModuleHandle.EmptyHandle;
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsResource()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06007978 RID: 31096 RVA: 0x001203E9 File Offset: 0x0011E5E9
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x001203F1 File Offset: 0x0011E5F1
		[RequiresUnreferencedCode("Methods might be removed")]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return this.GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, null, null);
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x0012040B File Offset: 0x0011E60B
		[RequiresUnreferencedCode("Methods might be removed")]
		[return: Nullable(2)]
		public MethodInfo GetMethod(string name, Type[] types)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, types, null);
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x0012041C File Offset: 0x0011E61C
		[NullableContext(2)]
		[RequiresUnreferencedCode("Methods might be removed")]
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

		// Token: 0x0600797F RID: 31103 RVA: 0x0001A4BD File Offset: 0x000186BD
		[NullableContext(2)]
		[RequiresUnreferencedCode("Methods might be removed")]
		protected virtual MethodInfo GetMethodImpl([Nullable(1)] string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] types, ParameterModifier[] modifiers)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x0012046C File Offset: 0x0011E66C
		[RequiresUnreferencedCode("Methods might be removed")]
		public MethodInfo[] GetMethods()
		{
			return this.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Methods might be removed")]
		public virtual MethodInfo[] GetMethods(BindingFlags bindingFlags)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x00120476 File Offset: 0x0011E676
		[RequiresUnreferencedCode("Fields might be removed")]
		[return: Nullable(2)]
		public FieldInfo GetField(string name)
		{
			return this.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Fields might be removed")]
		[return: Nullable(2)]
		public virtual FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x00120481 File Offset: 0x0011E681
		[RequiresUnreferencedCode("Fields might be removed")]
		public FieldInfo[] GetFields()
		{
			return this.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Fields might be removed")]
		public virtual FieldInfo[] GetFields(BindingFlags bindingFlags)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types might be removed")]
		public virtual Type[] GetTypes()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x0012048B File Offset: 0x0011E68B
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string className)
		{
			return this.GetType(className, false, false);
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00120496 File Offset: 0x0011E696
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string className, bool ignoreCase)
		{
			return this.GetType(className, false, ignoreCase);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string className, bool throwOnError, bool ignoreCase)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x001204A4 File Offset: 0x0011E6A4
		[NullableContext(2)]
		[RequiresUnreferencedCode("Types might be removed")]
		[return: Nullable(1)]
		public virtual Type[] FindTypes(TypeFilter filter, object filterCriteria)
		{
			Type[] types = this.GetTypes();
			int num = 0;
			for (int i = 0; i < types.Length; i++)
			{
				if (filter != null && !filter(types[i], filterCriteria))
				{
					types[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == types.Length)
			{
				return types;
			}
			Type[] array = new Type[num];
			num = 0;
			for (int j = 0; j < types.Length; j++)
			{
				if (types[j] != null)
				{
					array[num++] = types[j];
				}
			}
			return array;
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual int MetadataToken
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x0012051C File Offset: 0x0011E71C
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public FieldInfo ResolveField(int metadataToken)
		{
			return this.ResolveField(metadataToken, null, null);
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x0001A4BD File Offset: 0x000186BD
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual FieldInfo ResolveField(int metadataToken, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericTypeArguments, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x00120527 File Offset: 0x0011E727
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public MemberInfo ResolveMember(int metadataToken)
		{
			return this.ResolveMember(metadataToken, null, null);
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0001A4BD File Offset: 0x000186BD
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual MemberInfo ResolveMember(int metadataToken, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericTypeArguments, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00120532 File Offset: 0x0011E732
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public MethodBase ResolveMethod(int metadataToken)
		{
			return this.ResolveMethod(metadataToken, null, null);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0001A4BD File Offset: 0x000186BD
		[NullableContext(2)]
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual MethodBase ResolveMethod(int metadataToken, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericTypeArguments, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual byte[] ResolveSignature(int metadataToken)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual string ResolveString(int metadataToken)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x0012053D File Offset: 0x0011E73D
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public Type ResolveType(int metadataToken)
		{
			return this.ResolveType(metadataToken, null, null);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Trimming changes metadata tokens")]
		public virtual Type ResolveType(int metadataToken, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericTypeArguments, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00092631 File Offset: 0x00090831
		[NullableContext(2)]
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x0009264E File Offset: 0x0009084E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x0011699B File Offset: 0x00114B9B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Module left, Module right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00120548 File Offset: 0x0011E748
		[NullableContext(2)]
		public static bool operator !=(Module left, Module right)
		{
			return !(left == right);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00120554 File Offset: 0x0011E754
		public override string ToString()
		{
			return this.ScopeName;
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x0012055C File Offset: 0x0011E75C
		private static bool FilterTypeNameImpl(Type cls, object filterCriteria, StringComparison comparison)
		{
			string text = filterCriteria as string;
			if (text == null)
			{
				throw new InvalidFilterCriteriaException(SR.InvalidFilterCriteriaException_CritString);
			}
			if (text.EndsWith('*'))
			{
				ReadOnlySpan<char> value = text.AsSpan(0, text.Length - 1);
				return cls.Name.AsSpan().StartsWith(value, comparison);
			}
			return cls.Name.Equals(text, comparison);
		}

		// Token: 0x040016CC RID: 5836
		public static readonly TypeFilter FilterTypeName = (Type m, object c) => Module.FilterTypeNameImpl(m, c, StringComparison.Ordinal);

		// Token: 0x040016CD RID: 5837
		public static readonly TypeFilter FilterTypeNameIgnoreCase = (Type m, object c) => Module.FilterTypeNameImpl(m, c, StringComparison.OrdinalIgnoreCase);
	}
}

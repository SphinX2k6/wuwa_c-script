using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace System.Reflection.Emit
{
	// Token: 0x020007A0 RID: 1952
	internal sealed class MethodOnTypeBuilderInstantiation : MethodInfo
	{
		// Token: 0x06007C5E RID: 31838 RVA: 0x00125FEC File Offset: 0x001241EC
		internal MethodOnTypeBuilderInstantiation(MethodOnTypeBuilderInstantiation gmd, Type[] typeArguments) : this(gmd._method, gmd._type)
		{
			this._typeArguments = new Type[typeArguments.Length];
			typeArguments.CopyTo(this._typeArguments, 0);
			this._genericMethodDefinition = gmd;
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00126024 File Offset: 0x00124224
		internal MethodOnTypeBuilderInstantiation(MethodInfo method, Type[] typeArguments) : this(MethodOnTypeBuilderInstantiation.ExtractBaseMethod(method), method.DeclaringType)
		{
			this._typeArguments = new Type[typeArguments.Length];
			typeArguments.CopyTo(this._typeArguments, 0);
			if (this._method != method)
			{
				this._genericMethodDefinition = method;
			}
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00126074 File Offset: 0x00124274
		public override Type[] GetGenericArguments()
		{
			if (!this._method.IsGenericMethodDefinition)
			{
				return Type.EmptyTypes;
			}
			Type[] array = this._typeArguments ?? this._method.GetGenericArguments();
			Type[] array2 = new Type[array.Length];
			array.CopyTo(array2, 0);
			return array2;
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06007C61 RID: 31841 RVA: 0x001260BA File Offset: 0x001242BA
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return this._method.IsGenericMethodDefinition && this._typeArguments == null;
			}
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x001260D4 File Offset: 0x001242D4
		public override MethodInfo GetGenericMethodDefinition()
		{
			return this._genericMethodDefinition ?? this._method;
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x001260E8 File Offset: 0x001242E8
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public override MethodInfo MakeGenericMethod(params Type[] typeArgs)
		{
			if (!this._method.IsGenericMethodDefinition || this._typeArguments != null)
			{
				throw new InvalidOperationException(SR.Argument_NeedGenericMethodDefinition);
			}
			ArgumentNullException.ThrowIfNull(typeArgs, "typeArgs");
			if (this._method.GetGenericArguments().Length != typeArgs.Length)
			{
				throw new ArgumentException(SR.Format(SR.Argument_NotEnoughGenArguments, this._method.GetGenericArguments().Length, typeArgs.Length));
			}
			for (int i = 0; i < typeArgs.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(typeArgs[i], "typeArgs");
			}
			return new MethodOnTypeBuilderInstantiation(this, typeArgs);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00126180 File Offset: 0x00124380
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2060:MakeGenericMethod", Justification = "MethodOnTypeBuilderInst is Reflection.Emit's underlying implementation of MakeGenericMethod. Callers of the outer calls to MakeGenericMethod will be warned as appropriate.")]
		internal MethodInfo RuntimeResolve()
		{
			MethodInfo methodInfo = this._type.InternalResolve().GetMethod(this._method);
			if (this._typeArguments != null)
			{
				Type[] array = new Type[this._typeArguments.Length];
				for (int i = 0; i < this._typeArguments.Length; i++)
				{
					array[i] = this._typeArguments[i].InternalResolve();
				}
				methodInfo = methodInfo.MakeGenericMethod(array);
			}
			return methodInfo;
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x001261E6 File Offset: 0x001243E6
		internal override int GetParametersCount()
		{
			return this._method.GetParametersCount();
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x001261F3 File Offset: 0x001243F3
		internal static MethodInfo GetMethod(MethodInfo method, TypeBuilderInstantiation type)
		{
			return new MethodOnTypeBuilderInstantiation(method, type);
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x001261FC File Offset: 0x001243FC
		internal MethodOnTypeBuilderInstantiation(MethodInfo method, Type type)
		{
			this._method = method;
			this._type = type;
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x00126214 File Offset: 0x00124414
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Reflection.Emit is not subject to trimming")]
		private static MethodInfo ExtractBaseMethod(MethodInfo info)
		{
			if (info is MethodBuilder)
			{
				return info;
			}
			MethodOnTypeBuilderInstantiation methodOnTypeBuilderInstantiation = info as MethodOnTypeBuilderInstantiation;
			if (methodOnTypeBuilderInstantiation != null)
			{
				return methodOnTypeBuilderInstantiation._method;
			}
			if (info.IsGenericMethod)
			{
				info = info.GetGenericMethodDefinition();
			}
			Type declaringType = info.DeclaringType;
			if (!declaringType.IsGenericType || declaringType.IsGenericTypeDefinition)
			{
				return info;
			}
			return (MethodInfo)declaringType.Module.ResolveMethod(info.MetadataToken);
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x0012627B File Offset: 0x0012447B
		public override MemberTypes MemberType
		{
			get
			{
				return this._method.MemberType;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06007C6A RID: 31850 RVA: 0x00126288 File Offset: 0x00124488
		public override string Name
		{
			get
			{
				return this._method.Name;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x00126295 File Offset: 0x00124495
		public override Type DeclaringType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06007C6C RID: 31852 RVA: 0x00126295 File Offset: 0x00124495
		public override Type ReflectedType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x0012629D File Offset: 0x0012449D
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._method.GetCustomAttributes(inherit);
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x001262AB File Offset: 0x001244AB
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._method.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x001262BA File Offset: 0x001244BA
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._method.IsDefined(attributeType, inherit);
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06007C70 RID: 31856 RVA: 0x001262C9 File Offset: 0x001244C9
		public override Module Module
		{
			get
			{
				return this._method.Module;
			}
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x001262D6 File Offset: 0x001244D6
		public override ParameterInfo[] GetParameters()
		{
			return this._method.GetParameters();
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x001262E3 File Offset: 0x001244E3
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this._method.GetMethodImplementationFlags();
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x001262F0 File Offset: 0x001244F0
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this._method.MethodHandle;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x001262FD File Offset: 0x001244FD
		public override MethodAttributes Attributes
		{
			get
			{
				return this._method.Attributes;
			}
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x0001A563 File Offset: 0x00018763
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06007C76 RID: 31862 RVA: 0x0012630A File Offset: 0x0012450A
		public override CallingConventions CallingConvention
		{
			get
			{
				return this._method.CallingConvention;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00126318 File Offset: 0x00124518
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this._method.ContainsGenericParameters || this._type.ContainsGenericParameters)
				{
					return true;
				}
				if (!this.IsGenericMethod)
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

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06007C78 RID: 31864 RVA: 0x0012636D File Offset: 0x0012456D
		public override bool IsGenericMethod
		{
			get
			{
				return this._method.IsGenericMethod;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x0012637A File Offset: 0x0012457A
		public override Type ReturnType
		{
			get
			{
				return this._method.ReturnType;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06007C7A RID: 31866 RVA: 0x0001A563 File Offset: 0x00018763
		public override ParameterInfo ReturnParameter
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x0001A563 File Offset: 0x00018763
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x0001A563 File Offset: 0x00018763
		public override MethodInfo GetBaseDefinition()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x00126387 File Offset: 0x00124587
		internal override Type[] GetParameterTypes()
		{
			return this._method.GetParameterTypes();
		}

		// Token: 0x040017AB RID: 6059
		private Type[] _typeArguments;

		// Token: 0x040017AC RID: 6060
		private MethodInfo _genericMethodDefinition;

		// Token: 0x040017AD RID: 6061
		internal MethodInfo _method;

		// Token: 0x040017AE RID: 6062
		private Type _type;
	}
}

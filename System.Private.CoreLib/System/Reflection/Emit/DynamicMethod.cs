using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x0200079D RID: 1949
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class DynamicMethod : MethodInfo
	{
		// Token: 0x06007C12 RID: 31762 RVA: 0x00125594 File Offset: 0x00123794
		public sealed override Delegate CreateDelegate(Type delegateType)
		{
			ArgumentNullException.ThrowIfNull(delegateType, "delegateType");
			if (this._deleg != null)
			{
				return this._deleg;
			}
			this.CreateDynMethod();
			return this._deleg = Delegate.CreateDelegate(delegateType, null, this);
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x001255D2 File Offset: 0x001237D2
		public sealed override Delegate CreateDelegate(Type delegateType, [Nullable(2)] object target)
		{
			ArgumentNullException.ThrowIfNull(delegateType, "delegateType");
			this.CreateDynMethod();
			return Delegate.CreateDelegate(delegateType, target, this);
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x001255F0 File Offset: 0x001237F0
		public DynamicILInfo GetDynamicILInfo()
		{
			DynamicILInfo result;
			if ((result = this._dynamicILInfo) == null)
			{
				result = (this._dynamicILInfo = new DynamicILInfo(this));
			}
			return result;
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x00125616 File Offset: 0x00123816
		public ILGenerator GetILGenerator(int streamSize)
		{
			return this.GetILGeneratorInternal(streamSize);
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x0012561F File Offset: 0x0012381F
		internal RuntimeILGenerator GetRuntimeILGenerator()
		{
			return this.GetILGeneratorInternal(64);
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x0012562C File Offset: 0x0012382C
		private RuntimeILGenerator GetILGeneratorInternal(int streamSize)
		{
			RuntimeILGenerator result;
			if ((result = this._ilGenerator) == null)
			{
				result = (this._ilGenerator = new RuntimeILGenerator(this.Module, new DynamicMethod.DynamicMethodTokenGenerator(this), streamSize));
			}
			return result;
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x00125660 File Offset: 0x00123860
		[NullableContext(2)]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if ((this.CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				throw new NotSupportedException(SR.NotSupported_CallToVarArg);
			}
			object result;
			try
			{
				this.CreateDynMethod();
				result = this.GetRuntimeMethodInfo().Invoke(obj, invokeAttr, binder, parameters, culture);
			}
			catch (MethodAccessException inner)
			{
				throw new TargetInvocationException(SR.TargetInvocation_MethodCannotBeInvoked, inner);
			}
			return result;
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x001256C0 File Offset: 0x001238C0
		internal RuntimeMethodInfo GetRuntimeMethodInfo()
		{
			if (this._method == null)
			{
				this._method = new RuntimeMethodInfo(this._mhandle);
			}
			return this._method;
		}

		// Token: 0x06007C1A RID: 31770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void create_dynamic_method(DynamicMethod m, string name, MethodAttributes attributes, CallingConventions callingConvention);

		// Token: 0x06007C1B RID: 31771 RVA: 0x001256E4 File Offset: 0x001238E4
		private void CreateDynMethod()
		{
			lock (this)
			{
				if (this._mhandle.Value == IntPtr.Zero)
				{
					if (this._ilGenerator == null || this._ilGenerator.ILOffset == 0)
					{
						throw new InvalidOperationException(SR.Format(SR.InvalidOperation_BadEmptyMethodBody, this.Name));
					}
					this._ilGenerator.label_fixup(this);
					try
					{
						this._creating = true;
						if (this._refs != null)
						{
							for (int i = 0; i < this._refs.Length; i++)
							{
								DynamicMethod dynamicMethod = this._refs[i] as DynamicMethod;
								if (dynamicMethod != null && !dynamicMethod._creating)
								{
									dynamicMethod.CreateDynMethod();
								}
							}
						}
					}
					finally
					{
						this._creating = false;
					}
					DynamicMethod.create_dynamic_method(this, this.Name, this.Attributes, this.CallingConvention);
					this._ilGenerator = null;
				}
			}
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x001257DC File Offset: 0x001239DC
		private int AddRef(object reference)
		{
			if (this._refs == null)
			{
				this._refs = new object[4];
			}
			if (this._nrefs >= this._refs.Length - 1)
			{
				object[] array = new object[this._refs.Length * 2];
				Array.Copy(this._refs, array, this._refs.Length);
				this._refs = array;
			}
			this._refs[this._nrefs] = reference;
			this._refs[this._nrefs + 1] = null;
			this._nrefs += 2;
			return this._nrefs - 1;
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x00125870 File Offset: 0x00123A70
		internal override int GetParametersCount()
		{
			return this.GetParametersAsSpan().Length;
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x0012588C File Offset: 0x00123A8C
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes)
		{
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, false, true);
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x001258B0 File Offset: 0x00123AB0
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, bool restrictedSkipVisibility)
		{
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, restrictedSkipVisibility, true);
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x001258D4 File Offset: 0x00123AD4
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Module m)
		{
			ArgumentNullException.ThrowIfNull(m, "m");
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, m, false, false);
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x00125904 File Offset: 0x00123B04
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Module m, bool skipVisibility)
		{
			ArgumentNullException.ThrowIfNull(m, "m");
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, m, skipVisibility, false);
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x00125938 File Offset: 0x00123B38
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Module m, bool skipVisibility)
		{
			ArgumentNullException.ThrowIfNull(m, "m");
			this.Init(name, attributes, callingConvention, returnType, parameterTypes, null, m, skipVisibility, false);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x0012596C File Offset: 0x00123B6C
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Type owner)
		{
			ArgumentNullException.ThrowIfNull(owner, "owner");
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, null, false, false);
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0012599C File Offset: 0x00123B9C
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Type owner, bool skipVisibility)
		{
			ArgumentNullException.ThrowIfNull(owner, "owner");
			this.Init(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, null, skipVisibility, false);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x001259D0 File Offset: 0x00123BD0
		[RequiresDynamicCode("Creating a DynamicMethod requires dynamic code.")]
		public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, [Nullable(2)] Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, Type owner, bool skipVisibility)
		{
			ArgumentNullException.ThrowIfNull(owner, "owner");
			this.Init(name, attributes, callingConvention, returnType, parameterTypes, owner, null, skipVisibility, false);
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x00125A04 File Offset: 0x00123C04
		private static Module GetDynamicMethodsModule()
		{
			if (DynamicMethod.s_anonymouslyHostedDynamicMethodsModule != null)
			{
				return DynamicMethod.s_anonymouslyHostedDynamicMethodsModule;
			}
			AssemblyBuilder.EnsureDynamicCodeSupported();
			object obj = DynamicMethod.s_anonymouslyHostedDynamicMethodsModuleLock;
			lock (obj)
			{
				if (DynamicMethod.s_anonymouslyHostedDynamicMethodsModule != null)
				{
					return DynamicMethod.s_anonymouslyHostedDynamicMethodsModule;
				}
				DynamicMethod.s_anonymouslyHostedDynamicMethodsModule = RuntimeAssemblyBuilder.InternalDefineDynamicAssembly(new AssemblyName("Anonymously Hosted DynamicMethods Assembly"), AssemblyBuilderAccess.Run, AssemblyLoadContext.Default, null).ManifestModule;
			}
			return DynamicMethod.s_anonymouslyHostedDynamicMethodsModule;
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x00125AA0 File Offset: 0x00123CA0
		[MemberNotNull("_parameterTypes")]
		[MemberNotNull("_returnType")]
		[MemberNotNull("_module")]
		[MemberNotNull("_name")]
		private void Init(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] signature, Type owner, Module m, bool skipVisibility, bool transparentMethod)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			AssemblyBuilder.EnsureDynamicCodeSupported();
			if (attributes != (MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static) || callingConvention != CallingConventions.Standard)
			{
				throw new NotSupportedException(SR.NotSupported_DynamicMethodFlags);
			}
			if (signature != null)
			{
				this._parameterTypes = new RuntimeType[signature.Length];
				for (int i = 0; i < signature.Length; i++)
				{
					if (signature[i] == null)
					{
						throw new ArgumentException(SR.Arg_InvalidTypeInSignature);
					}
					this._parameterTypes[i] = (signature[i].UnderlyingSystemType as RuntimeType);
					if (this._parameterTypes[i] == null || this._parameterTypes[i] == typeof(void))
					{
						throw new ArgumentException(SR.Arg_InvalidTypeInSignature);
					}
				}
			}
			else
			{
				this._parameterTypes = Array.Empty<RuntimeType>();
			}
			RuntimeType returnType2;
			if (returnType != null)
			{
				if ((returnType2 = (returnType.UnderlyingSystemType as RuntimeType)) == null)
				{
					throw new NotSupportedException(SR.Arg_InvalidTypeInRetType);
				}
			}
			else
			{
				returnType2 = (RuntimeType)typeof(void);
			}
			this._returnType = returnType2;
			if (transparentMethod)
			{
				this._module = DynamicMethod.GetDynamicMethodsModule();
				this._restrictedSkipVisibility = skipVisibility;
			}
			else
			{
				if (m != null)
				{
					this._module = RuntimeModuleBuilder.GetRuntimeModuleFromModule(m);
				}
				else
				{
					RuntimeType runtimeType = ((owner != null) ? owner.UnderlyingSystemType : null) as RuntimeType;
					if (runtimeType != null)
					{
						if (runtimeType.HasElementType || runtimeType.ContainsGenericParameters || runtimeType.IsGenericParameter || runtimeType.IsInterface)
						{
							throw new ArgumentException(SR.Argument_InvalidTypeForDynamicMethod);
						}
						this._typeOwner = runtimeType;
						this._module = runtimeType.GetRuntimeModule();
					}
					else
					{
						this._module = null;
					}
				}
				this._skipVisibility = skipVisibility;
			}
			this._ilGenerator = null;
			this._initLocals = true;
			this._methodHandle = null;
			this._name = name;
			this._attributes = attributes;
			this._callingConvention = callingConvention;
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00125C5C File Offset: 0x00123E5C
		public override string ToString()
		{
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(100);
			valueStringBuilder.Append(this.ReturnType.FormatTypeName());
			valueStringBuilder.Append(' ');
			valueStringBuilder.Append(this.Name);
			valueStringBuilder.Append('(');
			MethodBase.AppendParameters(ref valueStringBuilder, this.GetParameterTypes(), this.CallingConvention);
			valueStringBuilder.Append(')');
			return valueStringBuilder.ToString();
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06007C29 RID: 31785 RVA: 0x00125CCC File Offset: 0x00123ECC
		public override string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06007C2A RID: 31786 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public override Type DeclaringType
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06007C2B RID: 31787 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public override Type ReflectedType
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06007C2C RID: 31788 RVA: 0x00125CD4 File Offset: 0x00123ED4
		public override Module Module
		{
			get
			{
				return this._module;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06007C2D RID: 31789 RVA: 0x00125CDC File Offset: 0x00123EDC
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw new InvalidOperationException(SR.InvalidOperation_NotAllowedInDynamicMethod);
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06007C2E RID: 31790 RVA: 0x00125CF3 File Offset: 0x00123EF3
		public override MethodAttributes Attributes
		{
			get
			{
				return this._attributes;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06007C2F RID: 31791 RVA: 0x00125CFB File Offset: 0x00123EFB
		public override CallingConventions CallingConvention
		{
			get
			{
				return this._callingConvention;
			}
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x00007B62 File Offset: 0x00005D62
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x00125D04 File Offset: 0x00123F04
		public override ParameterInfo[] GetParameters()
		{
			return this.GetParametersAsSpan().ToArray();
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00125D20 File Offset: 0x00123F20
		internal override ReadOnlySpan<ParameterInfo> GetParametersAsSpan()
		{
			ParameterInfo[] array = this.LoadParameters();
			return array;
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.NoInlining;
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06007C34 RID: 31796 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsSecurityCritical
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSecuritySafeCritical
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsSecurityTransparent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x00125D3C File Offset: 0x00123F3C
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(SR.Arg_MustBeType, "attributeType");
			}
			bool flag = attributeType.IsAssignableFrom(typeof(MethodImplAttribute));
			object[] array = CustomAttribute.CreateAttributeArrayHelper(runtimeType, (flag > false) ? 1 : 0);
			if (flag)
			{
				array[0] = new MethodImplAttribute((MethodImplOptions)this.GetMethodImplementationFlags());
			}
			return array;
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00125D9F File Offset: 0x00123F9F
		public override object[] GetCustomAttributes(bool inherit)
		{
			return new object[]
			{
				new MethodImplAttribute((MethodImplOptions)this.GetMethodImplementationFlags())
			};
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00125DB5 File Offset: 0x00123FB5
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			return attributeType.IsAssignableFrom(typeof(MethodImplAttribute));
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06007C3A RID: 31802 RVA: 0x00125DD2 File Offset: 0x00123FD2
		public override Type ReturnType
		{
			get
			{
				return this._returnType;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06007C3B RID: 31803 RVA: 0x00125DDA File Offset: 0x00123FDA
		public override ParameterInfo ReturnParameter
		{
			get
			{
				return new RuntimeParameterInfo(this, null, this._returnType, -1);
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06007C3C RID: 31804 RVA: 0x00125DEA File Offset: 0x00123FEA
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				return new EmptyCAHolder();
			}
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x00125DF1 File Offset: 0x00123FF1
		[NullableContext(2)]
		public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName)
		{
			if (position < 0 || position > this._parameterTypes.Length)
			{
				throw new ArgumentOutOfRangeException(SR.ArgumentOutOfRange_ParamSequence);
			}
			position--;
			if (position >= 0)
			{
				RuntimeParameterInfo[] array = this.LoadParameters();
				array[position].SetName(parameterName);
				array[position].SetAttributes(attributes);
			}
			return null;
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00125E2E File Offset: 0x0012402E
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06007C3F RID: 31807 RVA: 0x00125E38 File Offset: 0x00124038
		// (set) Token: 0x06007C40 RID: 31808 RVA: 0x00125E40 File Offset: 0x00124040
		public bool InitLocals
		{
			get
			{
				return this._initLocals;
			}
			set
			{
				this._initLocals = value;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x00125E49 File Offset: 0x00124049
		internal RuntimeType[] ArgumentTypes
		{
			get
			{
				return this._parameterTypes;
			}
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00125E54 File Offset: 0x00124054
		private RuntimeParameterInfo[] LoadParameters()
		{
			if (this._parameters == null)
			{
				Type[] parameterTypes = this._parameterTypes;
				Type[] array = parameterTypes;
				RuntimeParameterInfo[] array2 = new RuntimeParameterInfo[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = new RuntimeParameterInfo(this, null, array[i], i);
				}
				if (this._parameters == null)
				{
					this._parameters = array2;
				}
			}
			return this._parameters;
		}

		// Token: 0x04001791 RID: 6033
		private RuntimeMethodHandle _mhandle;

		// Token: 0x04001792 RID: 6034
		private RuntimeType _returnType;

		// Token: 0x04001793 RID: 6035
		private RuntimeType[] _parameterTypes;

		// Token: 0x04001794 RID: 6036
		private Module _module;

		// Token: 0x04001795 RID: 6037
		private bool _skipVisibility;

		// Token: 0x04001796 RID: 6038
		private bool _restrictedSkipVisibility;

		// Token: 0x04001797 RID: 6039
		private bool _initLocals;

		// Token: 0x04001798 RID: 6040
		private RuntimeILGenerator _ilGenerator;

		// Token: 0x04001799 RID: 6041
		private int _nrefs;

		// Token: 0x0400179A RID: 6042
		private object[] _refs;

		// Token: 0x0400179B RID: 6043
		private IntPtr _referencedBy;

		// Token: 0x0400179C RID: 6044
		private RuntimeType _typeOwner;

		// Token: 0x0400179D RID: 6045
		private string _name;

		// Token: 0x0400179E RID: 6046
		private MethodAttributes _attributes;

		// Token: 0x0400179F RID: 6047
		private CallingConventions _callingConvention;

		// Token: 0x040017A0 RID: 6048
		private RuntimeParameterInfo[] _parameters;

		// Token: 0x040017A1 RID: 6049
		private Delegate _deleg;

		// Token: 0x040017A2 RID: 6050
		private RuntimeMethodInfo _method;

		// Token: 0x040017A3 RID: 6051
		private bool _creating;

		// Token: 0x040017A4 RID: 6052
		private DynamicILInfo _dynamicILInfo;

		// Token: 0x040017A5 RID: 6053
		private object _methodHandle;

		// Token: 0x040017A6 RID: 6054
		private static volatile Module s_anonymouslyHostedDynamicMethodsModule;

		// Token: 0x040017A7 RID: 6055
		private static readonly object s_anonymouslyHostedDynamicMethodsModuleLock = new object();

		// Token: 0x0200079E RID: 1950
		private sealed class DynamicMethodTokenGenerator : ITokenGenerator
		{
			// Token: 0x06007C44 RID: 31812 RVA: 0x00125EB8 File Offset: 0x001240B8
			public DynamicMethodTokenGenerator(DynamicMethod m)
			{
				this._m = m;
			}

			// Token: 0x06007C45 RID: 31813 RVA: 0x00125EC7 File Offset: 0x001240C7
			public int GetToken(string str)
			{
				return this._m.AddRef(str);
			}

			// Token: 0x06007C46 RID: 31814 RVA: 0x00066B61 File Offset: 0x00064D61
			public int GetToken(MethodBase method, Type[] opt_paratypes)
			{
				throw new InvalidOperationException();
			}

			// Token: 0x06007C47 RID: 31815 RVA: 0x00125EC7 File Offset: 0x001240C7
			public int GetToken(MemberInfo member, bool create_open_instance)
			{
				return this._m.AddRef(member);
			}

			// Token: 0x06007C48 RID: 31816 RVA: 0x00125EC7 File Offset: 0x001240C7
			public int GetToken(SignatureHelper helper)
			{
				return this._m.AddRef(helper);
			}

			// Token: 0x040017A8 RID: 6056
			private readonly DynamicMethod _m;
		}
	}
}

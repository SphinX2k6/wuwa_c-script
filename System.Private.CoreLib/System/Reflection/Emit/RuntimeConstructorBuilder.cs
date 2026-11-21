using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A4 RID: 1956
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeConstructorBuilder : ConstructorBuilder
	{
		// Token: 0x06007CB2 RID: 31922 RVA: 0x001267B8 File Offset: 0x001249B8
		[DynamicDependency("paramModOpt")]
		internal RuntimeConstructorBuilder(RuntimeTypeBuilder tb, MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.attrs = (attributes | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
			this.call_conv = callingConvention;
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
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			this.table_idx = this.get_next_table_index(6, 1);
			((RuntimeModuleBuilder)tb.Module).RegisterToken(this, this.MetadataToken);
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x0012686A File Offset: 0x00124A6A
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x00126872 File Offset: 0x00124A72
		// (set) Token: 0x06007CB5 RID: 31925 RVA: 0x0012687A File Offset: 0x00124A7A
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x00126883 File Offset: 0x00124A83
		internal RuntimeTypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x0012688B File Offset: 0x00124A8B
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x00126893 File Offset: 0x00124A93
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw RuntimeConstructorBuilder.not_created();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x001268B0 File Offset: 0x00124AB0
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

		// Token: 0x06007CBA RID: 31930 RVA: 0x00126912 File Offset: 0x00124B12
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x00126926 File Offset: 0x00124B26
		internal override Type GetParameterType(int pos)
		{
			return this.parameters[pos];
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x00126930 File Offset: 0x00124B30
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Linker doesn't analyze RuntimeResolve but it's an identity function")]
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetConstructor(this);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x00126943 File Offset: 0x00124B43
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw RuntimeConstructorBuilder.not_supported();
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x00126943 File Offset: 0x00124B43
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw RuntimeConstructorBuilder.not_supported();
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x0012694A File Offset: 0x00124B4A
		public override int MetadataToken
		{
			get
			{
				return 100663296 | this.table_idx;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06007CC0 RID: 31936 RVA: 0x00126943 File Offset: 0x00124B43
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw RuntimeConstructorBuilder.not_supported();
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x00126958 File Offset: 0x00124B58
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x00126883 File Offset: 0x00124A83
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x00126883 File Offset: 0x00124A83
		public override Type DeclaringType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x00126960 File Offset: 0x00124B60
		public override string Name
		{
			get
			{
				if ((this.attrs & MethodAttributes.Static) == MethodAttributes.PrivateScope)
				{
					return ConstructorInfo.ConstructorName;
				}
				return ConstructorInfo.TypeConstructorName;
			}
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x00126978 File Offset: 0x00124B78
		protected override ParameterBuilder DefineParameterCore(int iSequence, ParameterAttributes attributes, string strParamName)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(iSequence, "iSequence");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(iSequence, this.GetParametersCount(), "iSequence");
			if (this.type.is_created)
			{
				throw RuntimeConstructorBuilder.not_after_created();
			}
			ParameterBuilder parameterBuilder = new RuntimeParameterBuilder(this, iSequence, attributes, strParamName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[iSequence] = parameterBuilder;
			return parameterBuilder;
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x00126943 File Offset: 0x00124B43
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw RuntimeConstructorBuilder.not_supported();
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x00126943 File Offset: 0x00124B43
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw RuntimeConstructorBuilder.not_supported();
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x00126943 File Offset: 0x00124B43
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw RuntimeConstructorBuilder.not_supported();
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x001269E8 File Offset: 0x00124BE8
		protected override ILGenerator GetILGeneratorCore(int streamSize)
		{
			if (this.finished)
			{
				throw new InvalidOperationException();
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) != MethodAttributes.PrivateScope || (this.iattrs & (MethodImplAttributes)4099) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException();
			}
			this.ilgen = new RuntimeILGenerator(this.type.Module, ((RuntimeModuleBuilder)this.type.Module).GetTokenGenerator(), streamSize);
			return this.ilgen;
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x00126A68 File Offset: 0x00124C68
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			if (con.ReflectedType.FullName == "System.Runtime.CompilerServices.MethodImplAttribute")
			{
				int implementationFlags = (int)BinaryPrimitives.ReadUInt16LittleEndian(binaryAttribute.Slice(2));
				base.SetImplementationFlags((MethodImplAttributes)implementationFlags);
				return;
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

		// Token: 0x06007CCB RID: 31947 RVA: 0x00126AF7 File Offset: 0x00124CF7
		protected override void SetImplementationFlagsCore(MethodImplAttributes attributes)
		{
			if (this.type.is_created)
			{
				throw RuntimeConstructorBuilder.not_after_created();
			}
			this.iattrs = attributes;
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x00126B13 File Offset: 0x00124D13
		public override Module Module
		{
			get
			{
				return this.type.Module;
			}
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x00126B20 File Offset: 0x00124D20
		public override string ToString()
		{
			return "Name: " + this.Name;
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x00126B34 File Offset: 0x00124D34
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0))
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_BadEmptyMethodBody, this.Name));
			}
			if (base.IsStatic && ((this.call_conv & CallingConventions.VarArgs) != (CallingConventions)0 || (this.call_conv & CallingConventions.HasThis) != (CallingConventions)0))
			{
				throw new TypeLoadException();
			}
			RuntimeILGenerator runtimeILGenerator = this.ilgen;
			if (runtimeILGenerator == null)
			{
				return;
			}
			runtimeILGenerator.label_fixup(this);
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x00126BBC File Offset: 0x00124DBC
		internal void ResolveUserTypes()
		{
			RuntimeTypeBuilder.ResolveUserTypes(this.parameters);
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

		// Token: 0x06007CD0 RID: 31952 RVA: 0x00126C1E File Offset: 0x00124E1E
		internal override int get_next_table_index(int table, int count)
		{
			return this.type.get_next_table_index(table, count);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x00126C2D File Offset: 0x00124E2D
		private static NotSupportedException not_supported()
		{
			return new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x00126C39 File Offset: 0x00124E39
		private static InvalidOperationException not_after_created()
		{
			return new InvalidOperationException(SR.InvalidOperation_TypeHasBeenCreated);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00126C45 File Offset: 0x00124E45
		private static NotSupportedException not_created()
		{
			return new NotSupportedException(SR.InvalidOperation_TypeNotCreated);
		}

		// Token: 0x040017BF RID: 6079
		private RuntimeMethodHandle mhandle;

		// Token: 0x040017C0 RID: 6080
		private RuntimeILGenerator ilgen;

		// Token: 0x040017C1 RID: 6081
		internal Type[] parameters;

		// Token: 0x040017C2 RID: 6082
		private MethodAttributes attrs;

		// Token: 0x040017C3 RID: 6083
		private MethodImplAttributes iattrs;

		// Token: 0x040017C4 RID: 6084
		private int table_idx;

		// Token: 0x040017C5 RID: 6085
		private CallingConventions call_conv;

		// Token: 0x040017C6 RID: 6086
		private RuntimeTypeBuilder type;

		// Token: 0x040017C7 RID: 6087
		internal ParameterBuilder[] pinfo;

		// Token: 0x040017C8 RID: 6088
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040017C9 RID: 6089
		private bool init_locals = true;

		// Token: 0x040017CA RID: 6090
		private Type[][] paramModReq;

		// Token: 0x040017CB RID: 6091
		private Type[][] paramModOpt;

		// Token: 0x040017CC RID: 6092
		internal bool finished;
	}
}

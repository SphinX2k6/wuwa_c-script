using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C7 RID: 1991
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MethodBuilder : MethodInfo
	{
		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06007FE6 RID: 32742 RVA: 0x0012DD9B File Offset: 0x0012BF9B
		// (set) Token: 0x06007FE7 RID: 32743 RVA: 0x0012DDA3 File Offset: 0x0012BFA3
		public bool InitLocals
		{
			get
			{
				return this.InitLocalsCore;
			}
			set
			{
				this.InitLocalsCore = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06007FE8 RID: 32744
		// (set) Token: 0x06007FE9 RID: 32745
		protected abstract bool InitLocalsCore { get; set; }

		// Token: 0x06007FEA RID: 32746 RVA: 0x0012DDAC File Offset: 0x0012BFAC
		public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
		{
			ArgumentNullException.ThrowIfNull(names, "names");
			if (names.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptyArray, "names");
			}
			return this.DefineGenericParametersCore(names);
		}

		// Token: 0x06007FEB RID: 32747
		protected abstract GenericTypeParameterBuilder[] DefineGenericParametersCore(params string[] names);

		// Token: 0x06007FEC RID: 32748 RVA: 0x0012DDD4 File Offset: 0x0012BFD4
		public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, [Nullable(2)] string strParamName)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(position, "position");
			return this.DefineParameterCore(position, attributes, strParamName);
		}

		// Token: 0x06007FED RID: 32749
		protected abstract ParameterBuilder DefineParameterCore(int position, ParameterAttributes attributes, [Nullable(2)] string strParamName);

		// Token: 0x06007FEE RID: 32750 RVA: 0x0012DDEA File Offset: 0x0012BFEA
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x0012DDF4 File Offset: 0x0012BFF4
		public ILGenerator GetILGenerator(int size)
		{
			return this.GetILGeneratorCore(size);
		}

		// Token: 0x06007FF0 RID: 32752
		protected abstract ILGenerator GetILGeneratorCore(int size);

		// Token: 0x06007FF1 RID: 32753 RVA: 0x0012DDFD File Offset: 0x0012BFFD
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007FF2 RID: 32754
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007FF3 RID: 32755 RVA: 0x0012DE22 File Offset: 0x0012C022
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x0012DE46 File Offset: 0x0012C046
		public void SetImplementationFlags(MethodImplAttributes attributes)
		{
			this.SetImplementationFlagsCore(attributes);
		}

		// Token: 0x06007FF5 RID: 32757
		protected abstract void SetImplementationFlagsCore(MethodImplAttributes attributes);

		// Token: 0x06007FF6 RID: 32758 RVA: 0x0012DE4F File Offset: 0x0012C04F
		public void SetParameters(params Type[] parameterTypes)
		{
			this.SetSignature(null, null, null, parameterTypes, null, null);
		}

		// Token: 0x06007FF7 RID: 32759 RVA: 0x0012DE5D File Offset: 0x0012C05D
		[NullableContext(2)]
		public void SetReturnType(Type returnType)
		{
			this.SetSignature(returnType, null, null, null, null, null);
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x0012DE6B File Offset: 0x0012C06B
		[NullableContext(2)]
		public void SetSignature(Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers)
		{
			this.SetSignatureCore(returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}

		// Token: 0x06007FF9 RID: 32761
		[NullableContext(2)]
		protected abstract void SetSignatureCore(Type returnType, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] returnTypeOptionalCustomModifiers, [Nullable(new byte[]
		{
			2,
			1
		})] Type[] parameterTypes, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeRequiredCustomModifiers, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Type[][] parameterTypeOptionalCustomModifiers);
	}
}

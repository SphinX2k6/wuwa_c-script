using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007BD RID: 1981
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ConstructorBuilder : ConstructorInfo
	{
		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x0012D836 File Offset: 0x0012BA36
		// (set) Token: 0x06007F72 RID: 32626 RVA: 0x0012D83E File Offset: 0x0012BA3E
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

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06007F73 RID: 32627
		// (set) Token: 0x06007F74 RID: 32628
		protected abstract bool InitLocalsCore { get; set; }

		// Token: 0x06007F75 RID: 32629 RVA: 0x0012D847 File Offset: 0x0012BA47
		public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName)
		{
			return this.DefineParameterCore(iSequence, attributes, strParamName);
		}

		// Token: 0x06007F76 RID: 32630
		protected abstract ParameterBuilder DefineParameterCore(int iSequence, ParameterAttributes attributes, string strParamName);

		// Token: 0x06007F77 RID: 32631 RVA: 0x0012D852 File Offset: 0x0012BA52
		public ILGenerator GetILGenerator()
		{
			return this.GetILGeneratorCore(64);
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x0012D85C File Offset: 0x0012BA5C
		public ILGenerator GetILGenerator(int streamSize)
		{
			return this.GetILGeneratorCore(streamSize);
		}

		// Token: 0x06007F79 RID: 32633
		protected abstract ILGenerator GetILGeneratorCore(int streamSize);

		// Token: 0x06007F7A RID: 32634 RVA: 0x0012D865 File Offset: 0x0012BA65
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007F7B RID: 32635
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007F7C RID: 32636 RVA: 0x0012D88A File Offset: 0x0012BA8A
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x0012D8AE File Offset: 0x0012BAAE
		public void SetImplementationFlags(MethodImplAttributes attributes)
		{
			this.SetImplementationFlagsCore(attributes);
		}

		// Token: 0x06007F7E RID: 32638
		protected abstract void SetImplementationFlagsCore(MethodImplAttributes attributes);
	}
}

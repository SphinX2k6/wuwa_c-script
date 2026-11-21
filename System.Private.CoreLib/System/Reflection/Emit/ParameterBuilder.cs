using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007CF RID: 1999
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ParameterBuilder
	{
		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06008033 RID: 32819 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public virtual int Attributes
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06008034 RID: 32820 RVA: 0x0012F241 File Offset: 0x0012D441
		public bool IsIn
		{
			get
			{
				return (this.Attributes & 1) != 0;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x0012F24E File Offset: 0x0012D44E
		public bool IsOptional
		{
			get
			{
				return (this.Attributes & 16) != 0;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06008036 RID: 32822 RVA: 0x0012F25C File Offset: 0x0012D45C
		public bool IsOut
		{
			get
			{
				return (this.Attributes & 2) != 0;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public virtual string Name
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06008038 RID: 32824 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public virtual int Position
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public virtual void SetConstant(object defaultValue)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x0012F269 File Offset: 0x0012D469
		[NullableContext(1)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x0600803B RID: 32827
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x0600803C RID: 32828 RVA: 0x0012F28E File Offset: 0x0012D48E
		[NullableContext(1)]
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}
	}
}

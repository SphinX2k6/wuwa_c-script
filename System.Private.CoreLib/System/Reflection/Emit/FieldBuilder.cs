using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C1 RID: 1985
	public abstract class FieldBuilder : FieldInfo
	{
		// Token: 0x06007F9F RID: 32671 RVA: 0x0012D966 File Offset: 0x0012BB66
		[NullableContext(2)]
		public void SetConstant(object defaultValue)
		{
			this.SetConstantCore(defaultValue);
		}

		// Token: 0x06007FA0 RID: 32672
		[NullableContext(2)]
		protected abstract void SetConstantCore(object defaultValue);

		// Token: 0x06007FA1 RID: 32673 RVA: 0x0012D96F File Offset: 0x0012BB6F
		[NullableContext(1)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007FA2 RID: 32674
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007FA3 RID: 32675 RVA: 0x0012D994 File Offset: 0x0012BB94
		[NullableContext(1)]
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x0012D9B8 File Offset: 0x0012BBB8
		public void SetOffset(int iOffset)
		{
			this.SetOffsetCore(iOffset);
		}

		// Token: 0x06007FA5 RID: 32677
		protected abstract void SetOffsetCore(int iOffset);
	}
}

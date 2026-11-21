using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007D1 RID: 2001
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PropertyBuilder : PropertyInfo
	{
		// Token: 0x0600803E RID: 32830 RVA: 0x0012F2B2 File Offset: 0x0012D4B2
		public void AddOtherMethod(MethodBuilder mdBuilder)
		{
			this.AddOtherMethodCore(mdBuilder);
		}

		// Token: 0x0600803F RID: 32831
		protected abstract void AddOtherMethodCore(MethodBuilder mdBuilder);

		// Token: 0x06008040 RID: 32832 RVA: 0x0012F2BB File Offset: 0x0012D4BB
		[NullableContext(2)]
		public void SetConstant(object defaultValue)
		{
			this.SetConstantCore(defaultValue);
		}

		// Token: 0x06008041 RID: 32833
		[NullableContext(2)]
		protected abstract void SetConstantCore(object defaultValue);

		// Token: 0x06008042 RID: 32834 RVA: 0x0012F2C4 File Offset: 0x0012D4C4
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06008043 RID: 32835
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06008044 RID: 32836 RVA: 0x0012F2E9 File Offset: 0x0012D4E9
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x0012F30D File Offset: 0x0012D50D
		public void SetGetMethod(MethodBuilder mdBuilder)
		{
			this.SetGetMethodCore(mdBuilder);
		}

		// Token: 0x06008046 RID: 32838
		protected abstract void SetGetMethodCore(MethodBuilder mdBuilder);

		// Token: 0x06008047 RID: 32839 RVA: 0x0012F316 File Offset: 0x0012D516
		public void SetSetMethod(MethodBuilder mdBuilder)
		{
			this.SetSetMethodCore(mdBuilder);
		}

		// Token: 0x06008048 RID: 32840
		protected abstract void SetSetMethodCore(MethodBuilder mdBuilder);
	}
}

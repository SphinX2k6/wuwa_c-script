using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C0 RID: 1984
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EventBuilder
	{
		// Token: 0x06007F93 RID: 32659 RVA: 0x0012D8F9 File Offset: 0x0012BAF9
		public void AddOtherMethod(MethodBuilder mdBuilder)
		{
			this.AddOtherMethodCore(mdBuilder);
		}

		// Token: 0x06007F94 RID: 32660
		protected abstract void AddOtherMethodCore(MethodBuilder mdBuilder);

		// Token: 0x06007F95 RID: 32661 RVA: 0x0012D902 File Offset: 0x0012BB02
		public void SetAddOnMethod(MethodBuilder mdBuilder)
		{
			this.SetAddOnMethodCore(mdBuilder);
		}

		// Token: 0x06007F96 RID: 32662
		protected abstract void SetAddOnMethodCore(MethodBuilder mdBuilder);

		// Token: 0x06007F97 RID: 32663 RVA: 0x0012D90B File Offset: 0x0012BB0B
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007F98 RID: 32664
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007F99 RID: 32665 RVA: 0x0012D930 File Offset: 0x0012BB30
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x0012D954 File Offset: 0x0012BB54
		public void SetRaiseMethod(MethodBuilder mdBuilder)
		{
			this.SetRaiseMethodCore(mdBuilder);
		}

		// Token: 0x06007F9B RID: 32667
		protected abstract void SetRaiseMethodCore(MethodBuilder mdBuilder);

		// Token: 0x06007F9C RID: 32668 RVA: 0x0012D95D File Offset: 0x0012BB5D
		public void SetRemoveOnMethod(MethodBuilder mdBuilder)
		{
			this.SetRemoveOnMethodCore(mdBuilder);
		}

		// Token: 0x06007F9D RID: 32669
		protected abstract void SetRemoveOnMethodCore(MethodBuilder mdBuilder);
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C3 RID: 1987
	public abstract class GenericTypeParameterBuilder : TypeInfo
	{
		// Token: 0x06007FA7 RID: 32679 RVA: 0x0012D9C1 File Offset: 0x0012BBC1
		[NullableContext(1)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007FA8 RID: 32680
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007FA9 RID: 32681 RVA: 0x0012D9D0 File Offset: 0x0012BBD0
		[NullableContext(1)]
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x0012D9F4 File Offset: 0x0012BBF4
		[NullableContext(2)]
		public void SetBaseTypeConstraint([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type baseTypeConstraint)
		{
			this.SetBaseTypeConstraintCore(baseTypeConstraint);
		}

		// Token: 0x06007FAB RID: 32683
		[NullableContext(2)]
		protected abstract void SetBaseTypeConstraintCore([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type baseTypeConstraint);

		// Token: 0x06007FAC RID: 32684 RVA: 0x0012D9FD File Offset: 0x0012BBFD
		public void SetInterfaceConstraints([Nullable(new byte[]
		{
			2,
			1
		})] params Type[] interfaceConstraints)
		{
			this.SetInterfaceConstraintsCore(interfaceConstraints);
		}

		// Token: 0x06007FAD RID: 32685
		protected abstract void SetInterfaceConstraintsCore([Nullable(new byte[]
		{
			2,
			1
		})] params Type[] interfaceConstraints);

		// Token: 0x06007FAE RID: 32686 RVA: 0x0012DA06 File Offset: 0x0012BC06
		public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes)
		{
			this.SetGenericParameterAttributesCore(genericParameterAttributes);
		}

		// Token: 0x06007FAF RID: 32687
		protected abstract void SetGenericParameterAttributesCore(GenericParameterAttributes genericParameterAttributes);
	}
}

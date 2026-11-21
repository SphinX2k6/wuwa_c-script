using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006DF RID: 1759
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class UnsafeAccessorAttribute : Attribute
	{
		// Token: 0x060074EE RID: 29934 RVA: 0x001160A9 File Offset: 0x001142A9
		public UnsafeAccessorAttribute(UnsafeAccessorKind kind)
		{
			this.Kind = kind;
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060074EF RID: 29935 RVA: 0x001160B8 File Offset: 0x001142B8
		public UnsafeAccessorKind Kind { get; }

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060074F0 RID: 29936 RVA: 0x001160C0 File Offset: 0x001142C0
		// (set) Token: 0x060074F1 RID: 29937 RVA: 0x001160C8 File Offset: 0x001142C8
		public string Name { get; set; }
	}
}

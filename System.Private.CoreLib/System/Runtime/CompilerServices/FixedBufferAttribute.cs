using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000699 RID: 1689
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FixedBufferAttribute : Attribute
	{
		// Token: 0x060073F5 RID: 29685 RVA: 0x0011485E File Offset: 0x00112A5E
		public FixedBufferAttribute(Type elementType, int length)
		{
			this.ElementType = elementType;
			this.Length = length;
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x00114874 File Offset: 0x00112A74
		public Type ElementType { get; }

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060073F7 RID: 29687 RVA: 0x0011487C File Offset: 0x00112A7C
		public int Length { get; }
	}
}

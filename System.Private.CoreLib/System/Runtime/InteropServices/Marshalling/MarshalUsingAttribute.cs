using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200061B RID: 1563
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public sealed class MarshalUsingAttribute : Attribute
	{
		// Token: 0x060071F3 RID: 29171 RVA: 0x00111AC4 File Offset: 0x0010FCC4
		public MarshalUsingAttribute()
		{
			this.CountElementName = string.Empty;
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00111AD7 File Offset: 0x0010FCD7
		public MarshalUsingAttribute(Type nativeType) : this()
		{
			this.NativeType = nativeType;
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x00111AE6 File Offset: 0x0010FCE6
		[Nullable(2)]
		public Type NativeType { [NullableContext(2)] get; }

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060071F6 RID: 29174 RVA: 0x00111AEE File Offset: 0x0010FCEE
		// (set) Token: 0x060071F7 RID: 29175 RVA: 0x00111AF6 File Offset: 0x0010FCF6
		public string CountElementName { get; set; }

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060071F8 RID: 29176 RVA: 0x00111AFF File Offset: 0x0010FCFF
		// (set) Token: 0x060071F9 RID: 29177 RVA: 0x00111B07 File Offset: 0x0010FD07
		public int ConstantElementCount { get; set; }

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x00111B10 File Offset: 0x0010FD10
		// (set) Token: 0x060071FB RID: 29179 RVA: 0x00111B18 File Offset: 0x0010FD18
		public int ElementIndirectionDepth { get; set; }

		// Token: 0x04001386 RID: 4998
		public const string ReturnsCountValue = "return-value";
	}
}

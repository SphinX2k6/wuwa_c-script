using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005A5 RID: 1445
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class MarshalAsAttribute : Attribute
	{
		// Token: 0x06006F93 RID: 28563 RVA: 0x00007BA1 File Offset: 0x00005DA1
		internal object CloneInternal()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x0010CEF3 File Offset: 0x0010B0F3
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			this.Value = unmanagedType;
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x0010CEF3 File Offset: 0x0010B0F3
		public MarshalAsAttribute(short unmanagedType)
		{
			this.Value = unmanagedType;
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x0010CF02 File Offset: 0x0010B102
		public UnmanagedType Value { get; }

		// Token: 0x0400122F RID: 4655
		public VarEnum SafeArraySubType;

		// Token: 0x04001230 RID: 4656
		public Type SafeArrayUserDefinedSubType;

		// Token: 0x04001231 RID: 4657
		public int IidParameterIndex;

		// Token: 0x04001232 RID: 4658
		public UnmanagedType ArraySubType;

		// Token: 0x04001233 RID: 4659
		public short SizeParamIndex;

		// Token: 0x04001234 RID: 4660
		public int SizeConst;

		// Token: 0x04001235 RID: 4661
		public string MarshalType;

		// Token: 0x04001236 RID: 4662
		public Type MarshalTypeRef;

		// Token: 0x04001237 RID: 4663
		public string MarshalCookie;
	}
}

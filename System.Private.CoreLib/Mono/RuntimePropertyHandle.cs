using System;

namespace Mono
{
	// Token: 0x020009ED RID: 2541
	internal struct RuntimePropertyHandle : IEquatable<RuntimePropertyHandle>
	{
		// Token: 0x06009425 RID: 37925 RVA: 0x001719C7 File Offset: 0x0016FBC7
		internal RuntimePropertyHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06009426 RID: 37926 RVA: 0x001719D0 File Offset: 0x0016FBD0
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x001719D8 File Offset: 0x0016FBD8
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimePropertyHandle)obj).Value;
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00171A1D File Offset: 0x0016FC1D
		public bool Equals(RuntimePropertyHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x00171A2E File Offset: 0x0016FC2E
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x040022BE RID: 8894
		private readonly IntPtr value;
	}
}

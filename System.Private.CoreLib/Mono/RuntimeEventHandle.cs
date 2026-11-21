using System;

namespace Mono
{
	// Token: 0x020009EC RID: 2540
	internal struct RuntimeEventHandle : IEquatable<RuntimeEventHandle>
	{
		// Token: 0x06009420 RID: 37920 RVA: 0x00171952 File Offset: 0x0016FB52
		internal RuntimeEventHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06009421 RID: 37921 RVA: 0x0017195B File Offset: 0x0016FB5B
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00171964 File Offset: 0x0016FB64
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeEventHandle)obj).Value;
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x001719A9 File Offset: 0x0016FBA9
		public bool Equals(RuntimeEventHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x001719BA File Offset: 0x0016FBBA
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x040022BD RID: 8893
		private readonly IntPtr value;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x020009EA RID: 2538
	internal struct RuntimeClassHandle : IEquatable<RuntimeClassHandle>
	{
		// Token: 0x06009414 RID: 37908 RVA: 0x00171810 File Offset: 0x0016FA10
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			this.value = value;
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00171819 File Offset: 0x0016FA19
		internal unsafe RuntimeStructs.MonoClass* Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00171824 File Offset: 0x0016FA24
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeClassHandle)obj).Value;
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x0017186C File Offset: 0x0016FA6C
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00171887 File Offset: 0x0016FA87
		public bool Equals(RuntimeClassHandle handle)
		{
			return this.value == handle.Value;
		}

		// Token: 0x06009419 RID: 37913
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass);

		// Token: 0x0600941A RID: 37914 RVA: 0x00171898 File Offset: 0x0016FA98
		internal RuntimeTypeHandle GetTypeHandle()
		{
			return new RuntimeTypeHandle(RuntimeClassHandle.GetTypeFromClass(this.value));
		}

		// Token: 0x040022BB RID: 8891
		private unsafe readonly RuntimeStructs.MonoClass* value;
	}
}

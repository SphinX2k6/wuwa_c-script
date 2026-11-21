using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C6 RID: 1990
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x06007FE3 RID: 32739 RVA: 0x0012DD87 File Offset: 0x0012BF87
		public void SetLocalSymInfo(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			this.SetLocalSymInfoCore(name);
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x0012DD04 File Offset: 0x0012BF04
		protected virtual void SetLocalSymInfoCore(string name)
		{
			throw new NotSupportedException(SR.NotSupported_EmitDebugInfo);
		}
	}
}

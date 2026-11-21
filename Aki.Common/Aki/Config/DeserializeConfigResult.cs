using System;
using System.Runtime.CompilerServices;

namespace Aki.Config
{
	// Token: 0x0200002B RID: 43
	public struct DeserializeConfigResult<[Nullable(2)] T>
	{
		// Token: 0x0400023E RID: 574
		public bool Success;

		// Token: 0x0400023F RID: 575
		[Nullable(1)]
		public T Value;

		// Token: 0x04000240 RID: 576
		public int Position;
	}
}

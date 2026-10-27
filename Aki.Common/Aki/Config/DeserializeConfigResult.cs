using System;
using System.Runtime.CompilerServices;

namespace Aki.Config
{
	// Token: 0x0200002A RID: 42
	public struct DeserializeConfigResult<[Nullable(2)] T>
	{
		// Token: 0x04000239 RID: 569
		public bool Success;

		// Token: 0x0400023A RID: 570
		[Nullable(1)]
		public T Value;

		// Token: 0x0400023B RID: 571
		public int Position;
	}
}

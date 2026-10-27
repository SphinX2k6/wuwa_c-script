using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000397 RID: 919
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedFill_SetValue
	{
		// Token: 0x04000EBD RID: 3773
		public EFillType Type;

		// Token: 0x04000EBE RID: 3774
		public int? ModelId;

		// Token: 0x04000EBF RID: 3775
		public IPieceIndex Centre;

		// Token: 0x04000EC0 RID: 3776
		public IJigsawConfig Config;
	}
}

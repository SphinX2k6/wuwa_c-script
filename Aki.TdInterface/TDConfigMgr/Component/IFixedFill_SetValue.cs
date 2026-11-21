using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E0 RID: 992
	public class IFixedFill_SetValue
	{
		// Token: 0x04000FB4 RID: 4020
		public EFillType Type;

		// Token: 0x04000FB5 RID: 4021
		public int? ModelId;

		// Token: 0x04000FB6 RID: 4022
		public IPieceIndex Centre;

		// Token: 0x04000FB7 RID: 4023
		public IJigsawConfig Config;
	}
}

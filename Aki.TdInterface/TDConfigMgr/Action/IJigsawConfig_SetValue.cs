using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B67 RID: 7015
	public class IJigsawConfig_SetValue
	{
		// Token: 0x04005BE2 RID: 23522
		public int Row;

		// Token: 0x04005BE3 RID: 23523
		public int Column;

		// Token: 0x04005BE4 RID: 23524
		public int Size;

		// Token: 0x04005BE5 RID: 23525
		public EJigsawShape? Shape;

		// Token: 0x04005BE6 RID: 23526
		[Nullable(1)]
		public List<IJigsawPiece> Pieces;
	}
}

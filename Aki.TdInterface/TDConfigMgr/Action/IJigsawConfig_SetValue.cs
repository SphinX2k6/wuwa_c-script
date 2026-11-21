using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D14 RID: 7444
	public class IJigsawConfig_SetValue
	{
		// Token: 0x0400607B RID: 24699
		public int Row;

		// Token: 0x0400607C RID: 24700
		public int Column;

		// Token: 0x0400607D RID: 24701
		public int Size;

		// Token: 0x0400607E RID: 24702
		public EJigsawShape? Shape;

		// Token: 0x0400607F RID: 24703
		public List<IJigsawPiece> Pieces;
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A6 RID: 26278
	public class IEndStateT
	{
		// Token: 0x1700C342 RID: 49986
		// (get) Token: 0x0602DACF RID: 187087 RVA: 0x0063FFAF File Offset: 0x0063E1AF
		// (set) Token: 0x0602DAD0 RID: 187088 RVA: 0x0063FFB7 File Offset: 0x0063E1B7
		public List<int> StayFlowMontageActors { get; set; }

		// Token: 0x1700C343 RID: 49987
		// (get) Token: 0x0602DAD1 RID: 187089 RVA: 0x0063FFC0 File Offset: 0x0063E1C0
		// (set) Token: 0x0602DAD2 RID: 187090 RVA: 0x0063FFC8 File Offset: 0x0063E1C8
		public byte NullMask { get; set; }

		// Token: 0x0602DAD3 RID: 187091 RVA: 0x0063FFD1 File Offset: 0x0063E1D1
		public IEndStateT()
		{
			this.StayFlowMontageActors = null;
			this.NullMask = 0;
		}
	}
}

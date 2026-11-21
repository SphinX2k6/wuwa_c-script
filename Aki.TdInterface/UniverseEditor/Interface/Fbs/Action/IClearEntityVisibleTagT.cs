using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F4 RID: 27124
	public class IClearEntityVisibleTagT
	{
		// Token: 0x1700C77A RID: 51066
		// (get) Token: 0x0602E873 RID: 190579 RVA: 0x006589C1 File Offset: 0x00656BC1
		// (set) Token: 0x0602E874 RID: 190580 RVA: 0x006589C9 File Offset: 0x00656BC9
		public List<int> EntityIds { get; set; }

		// Token: 0x0602E875 RID: 190581 RVA: 0x006589D2 File Offset: 0x00656BD2
		public IClearEntityVisibleTagT()
		{
			this.EntityIds = null;
		}
	}
}

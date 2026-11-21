using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x020047EA RID: 18410
	public class IOfflineEntityComponentConfigT
	{
		// Token: 0x1700806A RID: 32874
		// (get) Token: 0x0601B317 RID: 111383 RVA: 0x003DAAA5 File Offset: 0x003D8CA5
		// (set) Token: 0x0601B318 RID: 111384 RVA: 0x003DAAAD File Offset: 0x003D8CAD
		public List<EComponent> Components { get; set; }

		// Token: 0x0601B319 RID: 111385 RVA: 0x003DAAB6 File Offset: 0x003D8CB6
		public IOfflineEntityComponentConfigT()
		{
			this.Components = null;
		}
	}
}

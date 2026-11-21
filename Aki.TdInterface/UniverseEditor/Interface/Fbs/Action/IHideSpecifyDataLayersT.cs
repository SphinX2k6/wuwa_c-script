using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB1 RID: 28593
	public class IHideSpecifyDataLayersT
	{
		// Token: 0x1700D167 RID: 53607
		// (get) Token: 0x06031817 RID: 202775 RVA: 0x006B5B97 File Offset: 0x006B3D97
		// (set) Token: 0x06031818 RID: 202776 RVA: 0x006B5B9F File Offset: 0x006B3D9F
		public EHideType Type { get; set; }

		// Token: 0x1700D168 RID: 53608
		// (get) Token: 0x06031819 RID: 202777 RVA: 0x006B5BA8 File Offset: 0x006B3DA8
		// (set) Token: 0x0603181A RID: 202778 RVA: 0x006B5BB0 File Offset: 0x006B3DB0
		public List<int> DataLayers { get; set; }

		// Token: 0x0603181B RID: 202779 RVA: 0x006B5BB9 File Offset: 0x006B3DB9
		public IHideSpecifyDataLayersT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.DataLayers = null;
		}
	}
}

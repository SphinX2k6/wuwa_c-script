using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006519 RID: 25881
	public class ICommonBtTreeT
	{
		// Token: 0x1700BF08 RID: 48904
		// (get) Token: 0x0602C1FA RID: 180730 RVA: 0x00602B86 File Offset: 0x00600D86
		// (set) Token: 0x0602C1FB RID: 180731 RVA: 0x00602B8E File Offset: 0x00600D8E
		public ICommonBtStartT Root { get; set; }

		// Token: 0x1700BF09 RID: 48905
		// (get) Token: 0x0602C1FC RID: 180732 RVA: 0x00602B97 File Offset: 0x00600D97
		// (set) Token: 0x0602C1FD RID: 180733 RVA: 0x00602B9F File Offset: 0x00600D9F
		public List<int> _SelectedNodeIds { get; set; }

		// Token: 0x1700BF0A RID: 48906
		// (get) Token: 0x0602C1FE RID: 180734 RVA: 0x00602BA8 File Offset: 0x00600DA8
		// (set) Token: 0x0602C1FF RID: 180735 RVA: 0x00602BB0 File Offset: 0x00600DB0
		public byte NullMask { get; set; }

		// Token: 0x0602C200 RID: 180736 RVA: 0x00602BB9 File Offset: 0x00600DB9
		public ICommonBtTreeT()
		{
			this.Root = null;
			this._SelectedNodeIds = null;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E6 RID: 17638
	public class ILevelBuildingGridConfigT
	{
		// Token: 0x17007C95 RID: 31893
		// (get) Token: 0x0601A646 RID: 108102 RVA: 0x003C479B File Offset: 0x003C299B
		// (set) Token: 0x0601A647 RID: 108103 RVA: 0x003C47A3 File Offset: 0x003C29A3
		public int LevelId { get; set; }

		// Token: 0x17007C96 RID: 31894
		// (get) Token: 0x0601A648 RID: 108104 RVA: 0x003C47AC File Offset: 0x003C29AC
		// (set) Token: 0x0601A649 RID: 108105 RVA: 0x003C47B4 File Offset: 0x003C29B4
		public int CellSize { get; set; }

		// Token: 0x17007C97 RID: 31895
		// (get) Token: 0x0601A64A RID: 108106 RVA: 0x003C47BD File Offset: 0x003C29BD
		// (set) Token: 0x0601A64B RID: 108107 RVA: 0x003C47C5 File Offset: 0x003C29C5
		public List<ILevelBuildingGridT> Grids { get; set; }

		// Token: 0x17007C98 RID: 31896
		// (get) Token: 0x0601A64C RID: 108108 RVA: 0x003C47CE File Offset: 0x003C29CE
		// (set) Token: 0x0601A64D RID: 108109 RVA: 0x003C47D6 File Offset: 0x003C29D6
		public int _MaxGridId { get; set; }

		// Token: 0x0601A64E RID: 108110 RVA: 0x003C47DF File Offset: 0x003C29DF
		public ILevelBuildingGridConfigT()
		{
			this.LevelId = 0;
			this.CellSize = 0;
			this.Grids = null;
			this._MaxGridId = 0;
		}
	}
}

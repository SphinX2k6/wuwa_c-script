using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007422 RID: 29730
	public class ITowerDungeonPrefabConfigT
	{
		// Token: 0x1700E1BB RID: 57787
		// (get) Token: 0x06036017 RID: 221207 RVA: 0x00758B44 File Offset: 0x00756D44
		// (set) Token: 0x06036018 RID: 221208 RVA: 0x00758B4C File Offset: 0x00756D4C
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700E1BC RID: 57788
		// (get) Token: 0x06036019 RID: 221209 RVA: 0x00758B55 File Offset: 0x00756D55
		// (set) Token: 0x0603601A RID: 221210 RVA: 0x00758B5D File Offset: 0x00756D5D
		public int Index { get; set; }

		// Token: 0x0603601B RID: 221211 RVA: 0x00758B66 File Offset: 0x00756D66
		public ITowerDungeonPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}

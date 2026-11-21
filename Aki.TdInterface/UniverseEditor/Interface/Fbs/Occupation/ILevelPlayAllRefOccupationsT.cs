using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004801 RID: 18433
	public class ILevelPlayAllRefOccupationsT
	{
		// Token: 0x17008091 RID: 32913
		// (get) Token: 0x0601B3D7 RID: 111575 RVA: 0x003DC1A0 File Offset: 0x003DA3A0
		// (set) Token: 0x0601B3D8 RID: 111576 RVA: 0x003DC1A8 File Offset: 0x003DA3A8
		public int LevelPlayId { get; set; }

		// Token: 0x17008092 RID: 32914
		// (get) Token: 0x0601B3D9 RID: 111577 RVA: 0x003DC1B1 File Offset: 0x003DA3B1
		// (set) Token: 0x0601B3DA RID: 111578 RVA: 0x003DC1B9 File Offset: 0x003DA3B9
		public List<INodeRefOccupationDataT> LevelPlayOpenOccupations { get; set; }

		// Token: 0x17008093 RID: 32915
		// (get) Token: 0x0601B3DB RID: 111579 RVA: 0x003DC1C2 File Offset: 0x003DA3C2
		// (set) Token: 0x0601B3DC RID: 111580 RVA: 0x003DC1CA File Offset: 0x003DA3CA
		public List<INodeRefOccupationsT> NodeOccupations { get; set; }

		// Token: 0x0601B3DD RID: 111581 RVA: 0x003DC1D3 File Offset: 0x003DA3D3
		public ILevelPlayAllRefOccupationsT()
		{
			this.LevelPlayId = 0;
			this.LevelPlayOpenOccupations = null;
			this.NodeOccupations = null;
		}
	}
}

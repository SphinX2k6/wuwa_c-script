using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D8 RID: 17880
	public class ITakePhoto2PosConditionT
	{
		// Token: 0x17007D11 RID: 32017
		// (get) Token: 0x0601A1E3 RID: 106979 RVA: 0x003B8BB2 File Offset: 0x003B6DB2
		// (set) Token: 0x0601A1E4 RID: 106980 RVA: 0x003B8BBA File Offset: 0x003B6DBA
		public int RangeEntity { get; set; }

		// Token: 0x0601A1E5 RID: 106981 RVA: 0x003B8BC3 File Offset: 0x003B6DC3
		public ITakePhoto2PosConditionT()
		{
			this.RangeEntity = 0;
		}
	}
}

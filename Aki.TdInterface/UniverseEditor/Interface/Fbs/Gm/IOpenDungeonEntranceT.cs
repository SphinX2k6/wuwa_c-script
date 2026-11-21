using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE1 RID: 19169
	public class IOpenDungeonEntranceT
	{
		// Token: 0x1700865F RID: 34399
		// (get) Token: 0x0601CE10 RID: 118288 RVA: 0x00410BCC File Offset: 0x0040EDCC
		// (set) Token: 0x0601CE11 RID: 118289 RVA: 0x00410BD4 File Offset: 0x0040EDD4
		public EGmCommand Type { get; set; }

		// Token: 0x17008660 RID: 34400
		// (get) Token: 0x0601CE12 RID: 118290 RVA: 0x00410BDD File Offset: 0x0040EDDD
		// (set) Token: 0x0601CE13 RID: 118291 RVA: 0x00410BE5 File Offset: 0x0040EDE5
		public int EntranceId { get; set; }

		// Token: 0x0601CE14 RID: 118292 RVA: 0x00410BEE File Offset: 0x0040EDEE
		public IOpenDungeonEntranceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntranceId = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004465 RID: 17509
	public class IDartboardZoneTypeT
	{
		// Token: 0x17007B92 RID: 31634
		// (get) Token: 0x0601A180 RID: 106880 RVA: 0x003BA732 File Offset: 0x003B8932
		// (set) Token: 0x0601A181 RID: 106881 RVA: 0x003BA73A File Offset: 0x003B893A
		public EDartboardZoneType Type { get; set; }

		// Token: 0x0601A182 RID: 106882 RVA: 0x003BA743 File Offset: 0x003B8943
		public IDartboardZoneTypeT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006673 RID: 26227
	public class IEnableLevelPlayConfigT
	{
		// Token: 0x1700C2D6 RID: 49878
		// (get) Token: 0x0602D90F RID: 186639 RVA: 0x0063D04C File Offset: 0x0063B24C
		// (set) Token: 0x0602D910 RID: 186640 RVA: 0x0063D054 File Offset: 0x0063B254
		public int LevelPlayId { get; set; }

		// Token: 0x1700C2D7 RID: 49879
		// (get) Token: 0x0602D911 RID: 186641 RVA: 0x0063D05D File Offset: 0x0063B25D
		// (set) Token: 0x0602D912 RID: 186642 RVA: 0x0063D065 File Offset: 0x0063B265
		public bool Enable { get; set; }

		// Token: 0x0602D913 RID: 186643 RVA: 0x0063D06E File Offset: 0x0063B26E
		public IEnableLevelPlayConfigT()
		{
			this.LevelPlayId = 0;
			this.Enable = false;
		}
	}
}

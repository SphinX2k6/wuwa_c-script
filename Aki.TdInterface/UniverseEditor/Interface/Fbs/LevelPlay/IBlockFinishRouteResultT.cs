using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200443E RID: 17470
	public class IBlockFinishRouteResultT
	{
		// Token: 0x17007B18 RID: 31512
		// (get) Token: 0x06019FDC RID: 106460 RVA: 0x003B7354 File Offset: 0x003B5554
		// (set) Token: 0x06019FDD RID: 106461 RVA: 0x003B735C File Offset: 0x003B555C
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007B19 RID: 31513
		// (get) Token: 0x06019FDE RID: 106462 RVA: 0x003B7365 File Offset: 0x003B5565
		// (set) Token: 0x06019FDF RID: 106463 RVA: 0x003B736D File Offset: 0x003B556D
		public int ZoneCount { get; set; }

		// Token: 0x06019FE0 RID: 106464 RVA: 0x003B7376 File Offset: 0x003B5576
		public IBlockFinishRouteResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.ZoneCount = 0;
		}
	}
}

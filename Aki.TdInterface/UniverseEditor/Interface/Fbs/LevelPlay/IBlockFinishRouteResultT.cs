using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A6 RID: 18598
	public class IBlockFinishRouteResultT
	{
		// Token: 0x17008157 RID: 33111
		// (get) Token: 0x0601B7AD RID: 112557 RVA: 0x003E3560 File Offset: 0x003E1760
		// (set) Token: 0x0601B7AE RID: 112558 RVA: 0x003E3568 File Offset: 0x003E1768
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17008158 RID: 33112
		// (get) Token: 0x0601B7AF RID: 112559 RVA: 0x003E3571 File Offset: 0x003E1771
		// (set) Token: 0x0601B7B0 RID: 112560 RVA: 0x003E3579 File Offset: 0x003E1779
		public int ZoneCount { get; set; }

		// Token: 0x0601B7B1 RID: 112561 RVA: 0x003E3582 File Offset: 0x003E1782
		public IBlockFinishRouteResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.ZoneCount = 0;
		}
	}
}

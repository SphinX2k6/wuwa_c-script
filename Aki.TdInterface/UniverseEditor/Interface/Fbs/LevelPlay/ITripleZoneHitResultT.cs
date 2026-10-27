using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D9 RID: 17881
	public class ITripleZoneHitResultT
	{
		// Token: 0x17007F20 RID: 32544
		// (get) Token: 0x0601B109 RID: 110857 RVA: 0x003DB745 File Offset: 0x003D9945
		// (set) Token: 0x0601B10A RID: 110858 RVA: 0x003DB74D File Offset: 0x003D994D
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007F21 RID: 32545
		// (get) Token: 0x0601B10B RID: 110859 RVA: 0x003DB756 File Offset: 0x003D9956
		// (set) Token: 0x0601B10C RID: 110860 RVA: 0x003DB75E File Offset: 0x003D995E
		public int Probability { get; set; }

		// Token: 0x17007F22 RID: 32546
		// (get) Token: 0x0601B10D RID: 110861 RVA: 0x003DB767 File Offset: 0x003D9967
		// (set) Token: 0x0601B10E RID: 110862 RVA: 0x003DB76F File Offset: 0x003D996F
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601B10F RID: 110863 RVA: 0x003DB778 File Offset: 0x003D9978
		public ITripleZoneHitResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
			this.Zones = null;
		}
	}
}
